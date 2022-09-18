Imports System.Threading
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.IO.Ports

Public Class Skippy
    Public connected As Boolean
    Private led As String
    Public loaded As Integer
    Public kill As Boolean
    Private readBuffer As String = String.Empty
    Public Smsg As String = String.Empty
    Public runcapture As Thread
    Public Shared path As String
    Public liveview As Thread
    Public liveviewon As Boolean
    Public stepwide As Integer = 6
    Public finmov As Boolean


    Private Sub Skippy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Splash.Show()
        Thread.Sleep(3000)
        Splash.Close()

        led = "LEDT"
        connected = False
        path = My.Computer.FileSystem.SpecialDirectories.Desktop
        Savepath.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop
        liveviewon = False

        loaded = Cam.initialize()
        If loaded > 0 Then
            MessageBox.Show("Failed to initialize Camera. ERRORCODE " & loaded)
        End If

        Dim Portnames As String() = SerialPort.GetPortNames
        If Portnames.Length = 0 Then
            MessageBox.Show("No SerialPorts Detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmb_port.Items.AddRange(Portnames)
            cmb_port.Text = Portnames(0)
            For Each sp As String In Portnames
                Try
                    With Serial
                        .ParityReplace = &H3B
                        .PortName = sp
                        .BaudRate = 9600
                        .Parity = Parity.None
                        .DataBits = 8
                        .StopBits = StopBits.One
                        .Handshake = Handshake.None
                        .RtsEnable = False
                        .ReceivedBytesThreshold = 1
                        .ReadTimeout = 1000
                        .Open()
                        .WriteLine("Arduino?")
                    End With
                    'Thread.Sleep(1500)
                    Thread.Sleep(500)

                    Application.DoEvents()
                    If connected Then
                        btn_connect.Text = "Disconnect"
                        cmb_port.Enabled = False
                        status_camera.Text = "Serial Port Connected"
                        Exit For
                    Else
                        If Serial.IsOpen Then
                            Serial.Close()
                        End If
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next

            If connected = False Then
                MsgBox("Skippy failed to connect. Please make sure it is plugged in.")
            End If
        End If
    End Sub

    Private Sub Skippy_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        liveviewon = False
        If Serial.IsOpen = True Then
            Serial.WriteLine("Logout")
            Serial.Close()
        End If
        If loaded = 0 Then
            Cam.unloadSDK()
        End If
        If runcapture IsNot Nothing Then
            runcapture.Abort()
        End If
        If liveview IsNot Nothing Then
            liveview.Abort()
        End If
    End Sub

    Public Sub Scom(ByVal message As String)
        If Serial.IsOpen = True Then
            Serial.WriteLine(message)
            timeout.Interval = 1000
            timeout.Start()
        Else
            MsgBox("Serial Port not Connected. Connect and try again")
        End If
    End Sub

    Private Sub Serial_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles Serial.DataReceived
        'readBuffer = Serial.ReadExisting
        readBuffer = Serial.ReadLine

        If readBuffer.Contains("Arduino!") Then
            connected = True
            Scom(led + "125")
        ElseIf (readBuffer.Contains("Stop")) Then
            timeout.Stop()
            kill = True
            status_camera.Text = readBuffer
        ElseIf (readBuffer.Contains("ACK")) Then
            timeout.Stop()
            status_camera.Text = readBuffer
            timeout.Interval = 60000
            timeout.Start()
        ElseIf (readBuffer.Contains("Done")) Then
            timeout.Stop()
            finmov = True
            status_camera.Text = readBuffer

        Else
            Smsg = readBuffer
            status_camera.Text = readBuffer
        End If
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        If btn_connect.Text = "Connect" Then
            With Serial
                .ParityReplace = &H3B
                .PortName = cmb_port.Text
                .BaudRate = 9600
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = StopBits.One
                .Handshake = Handshake.None
                .RtsEnable = False
                .ReceivedBytesThreshold = 1
                .ReadTimeout = 1000
            End With
            Try
                Serial.Open()
            Catch ex As Exception
                MessageBox.Show("Error Open:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If Serial.IsOpen Then
                btn_connect.Text = "Disconnect"
                cmb_port.Enabled = False
                status_camera.Text = "Serial Port Connected"
                connected = True
                Scom(led + "125")
                Exit Sub
            Else
                MessageBox.Show("Error Opening COM port")
            End If
        End If
        If btn_connect.Text = "Disconnect" Then
            If connected = True Then
                Scom("Logoff")
            End If
            Serial.DiscardInBuffer()
                Serial.Close()
                If Serial.IsOpen = False Then
                    btn_connect.Text = "Connect"
                    cmb_port.Enabled = True
                    status_camera.Text = "Serial Port Disconnected"
                    connected = False
                    Exit Sub
                End If
            End If
    End Sub

    Private Sub tb_move_GotFocus(sender As Object, e As EventArgs) Handles tb_move.GotFocus
        tb_move.ResetText()
    End Sub

    Private Sub tb_range_GotFocus(sender As Object, e As EventArgs) Handles tb_range.GotFocus
        tb_range.ResetText()
    End Sub


    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If IsNumeric(tb_move.Text) Then
            Scom("Height" & tb_move.Text)
        Else
            MessageBox.Show("Move Value is not numeric")
        End If
    End Sub

    Private Sub btn_ufine_Click(sender As Object, e As EventArgs) Handles btn_ufine.Click
        If IsNumeric(tb_move.Text) Then
            Scom("M" & tb_move.Text)
        Else
            MessageBox.Show("Move Value is not numeric")
        End If
    End Sub

    Private Sub btn_uvfine_Click(sender As Object, e As EventArgs) Handles btn_uvfine.Click
        If IsNumeric(tb_move.Text) Then
            Scom("MM" & tb_move.Text)
        Else
            MessageBox.Show("Move Value is not numeric")
        End If
    End Sub

    Private Sub btn_down_Click(sender As Object, e As EventArgs) Handles btn_down.Click
        If IsNumeric(tb_move.Text) Then
            Dim buffer
            buffer = Convert.ToInt32(tb_move.Text) * -1
            Scom("Height" & buffer)
        Else
            MessageBox.Show("Move Value is not numeric")
        End If
    End Sub

    Private Sub btn_dfine_Click(sender As Object, e As EventArgs) Handles btn_dfine.Click
        If IsNumeric(tb_move.Text) Then
            Dim buffer
            buffer = Convert.ToInt32(tb_move.Text) * -1
            Scom("M" & buffer)
        Else
            MessageBox.Show("Move Value is not numeric")
        End If
    End Sub

    Private Sub btn_dvfine_Click(sender As Object, e As EventArgs) Handles btn_dvfine.Click
        If IsNumeric(tb_move.Text) Then
            Dim buffer
            buffer = Convert.ToInt32(tb_move.Text) * -1
            Scom("MM" & buffer)
        Else
            MessageBox.Show("Move Value is not numeric")
        End If
    End Sub

    Private Sub btn_left_Click(sender As Object, e As EventArgs) Handles btn_left.Click
        If IsNumeric(tb_move.Text) Then
            Dim buffer
            buffer = Convert.ToInt32(tb_move.Text) * -1
            Scom(buffer)
        Else
            MessageBox.Show("Move Value is not numeric")
        End If
    End Sub

    Private Sub btn_right_Click(sender As Object, e As EventArgs) Handles btn_right.Click
        If IsNumeric(tb_move.Text) Then
            Scom(tb_move.Text)
        Else
            MessageBox.Show("Move Value is not numeric")
        End If
    End Sub

    Private Sub btn_advanced_Click(sender As Object, e As EventArgs) Handles btn_advanced.Click
        Advanced.Show()
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        kill = True
    End Sub

    Private Sub btn_focus_Click(sender As Object, e As EventArgs) Handles btn_focus.Click
        If loaded = 0 Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                If Not Cam.focus(3) Then
                    MessageBox.Show("Error setting focus")
                End If
            Else
                If Not Cam.focus(1) Then
                    MessageBox.Show("Error setting focus")
                End If
            End If
        Else
            MessageBox.Show("SDK not loaded or no camera conected")
        End If

    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        If loaded = 0 Then
            If ckb_stdpath.Checked = False Then
                If Me.WindowState = FormWindowState.Maximized Then
                    Me.WindowState = FormWindowState.Normal
                End If
                If (Savepath.ShowDialog() = DialogResult.OK) Then
                    status_camera.Text = Savepath.SelectedPath
                    path = Savepath.SelectedPath
                    Cam.newpath(path, "image", 1)
                End If
            End If
            If Not Cam.picture() Then
                MessageBox.Show("Error taking image")
            End If
        Else
            MessageBox.Show("SDK not loaded or no camera conected")
        End If

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Scom("Home")
    End Sub

    Private Sub btn_light_Click(sender As Object, e As EventArgs) Handles btn_light.Click
        If connected = True Then
            If led = "LEDT" Then
                led = "LEDB"
                Scom("LEDT0")
                Scom("LEDB125")
                slider_light.Value = 125
                slider_light.Enabled = False
            Else
                led = "LEDT"
                Scom("LEDB0")
                Scom("LEDT125")
                slider_light.Value = 125
                slider_light.Enabled = True
            End If
        Else
            MessageBox.Show("Serial Port not Connected. Connect and try again")
        End If

    End Sub

    Private Sub slider_light_Scroll(sender As Object, e As EventArgs) Handles slider_light.Scroll
        Scom(led & slider_light.Value)
    End Sub

    Private Sub btn_run_Click(sender As Object, e As EventArgs) Handles btn_run.Click
        kill = False
        If IsNumeric(tb_range.Text) = True And Serial.IsOpen = True Then
            If ckb_stdpath.Checked = False Then
                If Me.WindowState = FormWindowState.Maximized Then
                    Me.WindowState = FormWindowState.Normal
                End If
                If (Savepath.ShowDialog() = DialogResult.OK) Then
                    status_camera.Text = Savepath.SelectedPath
                    path = Savepath.SelectedPath
                    Cam.newpath(path, "image", 1)
                End If
            End If
            runcapture = New Thread(AddressOf captures)
            runcapture.IsBackground = True
            runcapture.Start()
        Else
            MessageBox.Show("Move Value is not numeric or serial port not open")
        End If
    End Sub
    Private Sub captures()
        Dim mm As Integer = 0
        While mm < Int(tb_range.Text)
            If kill = True Then
                Thread.CurrentThread.Abort()
            End If
            If Not Cam.picture() Then
                MessageBox.Show("Error taking picture")
                kill = True
                Thread.CurrentThread.Abort()
            End If
            finmov = False
            Scom(stepwide)
            mm += stepwide
            While finmov = False
                'wait for done feedback here! Thread.Sleep(600)
            End While
        End While

        If (kill = False And ckb_noreturn.Checked = False) Then
            Scom("Home")
        End If
        Thread.CurrentThread.Abort()
    End Sub

    Private Sub btn_live_Click(sender As Object, e As EventArgs) Handles btn_live.Click
        If liveviewon Then
            liveviewon = False
        Else
            If loaded = 0 Then
                liveviewon = True
                liveview = New Thread(AddressOf UpdateLiveView)
                liveview.IsBackground = True
                liveview.Start()
            Else
                MessageBox.Show("SDK not loaded or no camera conected")
            End If
        End If
    End Sub
    Public Sub UpdateLiveView()

        Dim p As IntPtr
        Dim size As Integer
        If liveviewon = True Then
            p = Cam.initpreview()
            size = Cam.buffersize()
            Dim arr(size) As Byte


            While liveviewon
                Try
                    If Cam.preview() = True Then
                        Marshal.Copy(p, arr, 0, size)
                        Dim ms As New MemoryStream(arr)
                        Dim preview As New Bitmap(ms)
                        Previewwindow.Image = Nothing
                        Previewwindow.Image = preview
                        Thread.Sleep(16)
                    End If
                Catch ex As Exception

                End Try

            End While
        End If

        Previewwindow.Image = Nothing
        Thread.CurrentThread.Abort()

    End Sub

    Private Sub Previewwindow_Paint(sender As Object, e As PaintEventArgs) Handles Previewwindow.Paint
        If liveviewon Then
            Dim focusx = Previewwindow.Width / 7
            Dim focusy = Previewwindow.Height / 7
            e.Graphics.DrawRectangle(New Pen(Color.Red, 2.0F), New Rectangle(focusx * 3, focusy * 3, focusx, focusy))
        End If

    End Sub

    Private Sub timeout_Tick(sender As Object, e As EventArgs) Handles timeout.Tick
        timeout.Stop()
        connected = False
        btn_connect.PerformClick()
        MessageBox.Show("Serial Port has timed out")

    End Sub
End Class
