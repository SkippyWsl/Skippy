<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Skippy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Skippy))
        Me.Previewwindow = New System.Windows.Forms.PictureBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.cmb_port = New System.Windows.Forms.ComboBox()
        Me.btn_left = New System.Windows.Forms.Button()
        Me.btn_right = New System.Windows.Forms.Button()
        Me.tb_move = New System.Windows.Forms.TextBox()
        Me.tb_range = New System.Windows.Forms.TextBox()
        Me.btn_run = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.status_camera = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Serial = New System.IO.Ports.SerialPort(Me.components)
        Me.btn_live = New System.Windows.Forms.Button()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.Savepath = New System.Windows.Forms.FolderBrowserDialog()
        Me.btn_dfine = New System.Windows.Forms.Button()
        Me.btn_ufine = New System.Windows.Forms.Button()
        Me.btn_advanced = New System.Windows.Forms.Button()
        Me.btn_light = New System.Windows.Forms.Button()
        Me.slider_light = New System.Windows.Forms.TrackBar()
        Me.ckb_stdpath = New System.Windows.Forms.CheckBox()
        Me.btn_focus = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.ckb_noreturn = New System.Windows.Forms.CheckBox()
        Me.btn_uvfine = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.btn_dvfine = New System.Windows.Forms.Button()
        Me.btn_down = New System.Windows.Forms.Button()
        Me.timeout = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Previewwindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Status.SuspendLayout()
        CType(Me.slider_light, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Previewwindow
        '
        Me.Previewwindow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Previewwindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Previewwindow.Location = New System.Drawing.Point(13, 13)
        Me.Previewwindow.Name = "Previewwindow"
        Me.Previewwindow.Size = New System.Drawing.Size(420, 280)
        Me.Previewwindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Previewwindow.TabIndex = 0
        Me.Previewwindow.TabStop = False
        '
        'btn_connect
        '
        Me.btn_connect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_connect.Location = New System.Drawing.Point(531, 12)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(90, 21)
        Me.btn_connect.TabIndex = 2
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'cmb_port
        '
        Me.cmb_port.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_port.FormattingEnabled = True
        Me.cmb_port.Location = New System.Drawing.Point(438, 12)
        Me.cmb_port.Name = "cmb_port"
        Me.cmb_port.Size = New System.Drawing.Size(90, 21)
        Me.cmb_port.TabIndex = 3
        '
        'btn_left
        '
        Me.btn_left.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_left.Location = New System.Drawing.Point(438, 66)
        Me.btn_left.Name = "btn_left"
        Me.btn_left.Size = New System.Drawing.Size(90, 20)
        Me.btn_left.TabIndex = 4
        Me.btn_left.Text = "Left"
        Me.btn_left.UseVisualStyleBackColor = True
        '
        'btn_right
        '
        Me.btn_right.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_right.Location = New System.Drawing.Point(625, 66)
        Me.btn_right.Name = "btn_right"
        Me.btn_right.Size = New System.Drawing.Size(90, 20)
        Me.btn_right.TabIndex = 5
        Me.btn_right.Text = "Right"
        Me.btn_right.UseVisualStyleBackColor = True
        '
        'tb_move
        '
        Me.tb_move.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_move.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tb_move.Location = New System.Drawing.Point(531, 66)
        Me.tb_move.Name = "tb_move"
        Me.tb_move.Size = New System.Drawing.Size(90, 20)
        Me.tb_move.TabIndex = 6
        Me.tb_move.Text = "mm to move"
        Me.tb_move.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_range
        '
        Me.tb_range.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_range.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tb_range.Location = New System.Drawing.Point(438, 116)
        Me.tb_range.Name = "tb_range"
        Me.tb_range.Size = New System.Drawing.Size(90, 20)
        Me.tb_range.TabIndex = 7
        Me.tb_range.Text = "Range"
        Me.tb_range.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_run
        '
        Me.btn_run.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_run.Location = New System.Drawing.Point(531, 116)
        Me.btn_run.Name = "btn_run"
        Me.btn_run.Size = New System.Drawing.Size(90, 20)
        Me.btn_run.TabIndex = 9
        Me.btn_run.Text = "Run"
        Me.btn_run.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_camera})
        Me.Status.Location = New System.Drawing.Point(0, 303)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(732, 22)
        Me.Status.TabIndex = 10
        Me.Status.Text = "StatusStrip1"
        '
        'status_camera
        '
        Me.status_camera.AutoSize = False
        Me.status_camera.Name = "status_camera"
        Me.status_camera.Size = New System.Drawing.Size(250, 17)
        '
        'Serial
        '
        '
        'btn_live
        '
        Me.btn_live.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_live.Location = New System.Drawing.Point(625, 13)
        Me.btn_live.Name = "btn_live"
        Me.btn_live.Size = New System.Drawing.Size(90, 21)
        Me.btn_live.TabIndex = 12
        Me.btn_live.Text = "Liveview"
        Me.btn_live.UseVisualStyleBackColor = True
        '
        'btn_picture
        '
        Me.btn_picture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_picture.Location = New System.Drawing.Point(532, 141)
        Me.btn_picture.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(90, 20)
        Me.btn_picture.TabIndex = 24
        Me.btn_picture.Text = "Take Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_stop.Location = New System.Drawing.Point(625, 116)
        Me.btn_stop.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(90, 20)
        Me.btn_stop.TabIndex = 25
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'Savepath
        '
        Me.Savepath.SelectedPath = "C:\Users\Snow\Desktop"
        '
        'btn_dfine
        '
        Me.btn_dfine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_dfine.Location = New System.Drawing.Point(531, 91)
        Me.btn_dfine.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_dfine.Name = "btn_dfine"
        Me.btn_dfine.Size = New System.Drawing.Size(90, 20)
        Me.btn_dfine.TabIndex = 29
        Me.btn_dfine.Text = "Down (0.1)"
        Me.btn_dfine.UseVisualStyleBackColor = True
        '
        'btn_ufine
        '
        Me.btn_ufine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ufine.Location = New System.Drawing.Point(531, 38)
        Me.btn_ufine.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ufine.Name = "btn_ufine"
        Me.btn_ufine.Size = New System.Drawing.Size(90, 20)
        Me.btn_ufine.TabIndex = 30
        Me.btn_ufine.Text = "Up (0.1)"
        Me.btn_ufine.UseVisualStyleBackColor = True
        '
        'btn_advanced
        '
        Me.btn_advanced.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_advanced.Location = New System.Drawing.Point(532, 165)
        Me.btn_advanced.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_advanced.Name = "btn_advanced"
        Me.btn_advanced.Size = New System.Drawing.Size(90, 20)
        Me.btn_advanced.TabIndex = 31
        Me.btn_advanced.Text = "Advanced"
        Me.btn_advanced.UseVisualStyleBackColor = True
        '
        'btn_light
        '
        Me.btn_light.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_light.Location = New System.Drawing.Point(438, 165)
        Me.btn_light.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_light.Name = "btn_light"
        Me.btn_light.Size = New System.Drawing.Size(90, 20)
        Me.btn_light.TabIndex = 32
        Me.btn_light.Text = "LED T/B"
        Me.btn_light.UseVisualStyleBackColor = True
        '
        'slider_light
        '
        Me.slider_light.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.slider_light.LargeChange = 25
        Me.slider_light.Location = New System.Drawing.Point(438, 190)
        Me.slider_light.Maximum = 255
        Me.slider_light.Name = "slider_light"
        Me.slider_light.Size = New System.Drawing.Size(287, 45)
        Me.slider_light.TabIndex = 33
        Me.slider_light.TickFrequency = 10
        Me.slider_light.Value = 125
        '
        'ckb_stdpath
        '
        Me.ckb_stdpath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckb_stdpath.AutoSize = True
        Me.ckb_stdpath.Location = New System.Drawing.Point(438, 240)
        Me.ckb_stdpath.Margin = New System.Windows.Forms.Padding(2)
        Me.ckb_stdpath.Name = "ckb_stdpath"
        Me.ckb_stdpath.Size = New System.Drawing.Size(198, 17)
        Me.ckb_stdpath.TabIndex = 34
        Me.ckb_stdpath.Text = "Set current Save directory as default"
        Me.ckb_stdpath.UseVisualStyleBackColor = True
        '
        'btn_focus
        '
        Me.btn_focus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_focus.Location = New System.Drawing.Point(438, 141)
        Me.btn_focus.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_focus.Name = "btn_focus"
        Me.btn_focus.Size = New System.Drawing.Size(90, 20)
        Me.btn_focus.TabIndex = 35
        Me.btn_focus.Text = "Focus"
        Me.btn_focus.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_home.Location = New System.Drawing.Point(625, 140)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(90, 20)
        Me.btn_home.TabIndex = 36
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'ckb_noreturn
        '
        Me.ckb_noreturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckb_noreturn.AutoSize = True
        Me.ckb_noreturn.Location = New System.Drawing.Point(438, 261)
        Me.ckb_noreturn.Margin = New System.Windows.Forms.Padding(2)
        Me.ckb_noreturn.Name = "ckb_noreturn"
        Me.ckb_noreturn.Size = New System.Drawing.Size(121, 17)
        Me.ckb_noreturn.TabIndex = 37
        Me.ckb_noreturn.Text = "Dont return after run"
        Me.ckb_noreturn.UseVisualStyleBackColor = True
        '
        'btn_uvfine
        '
        Me.btn_uvfine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_uvfine.Location = New System.Drawing.Point(625, 38)
        Me.btn_uvfine.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_uvfine.Name = "btn_uvfine"
        Me.btn_uvfine.Size = New System.Drawing.Size(90, 20)
        Me.btn_uvfine.TabIndex = 38
        Me.btn_uvfine.Text = "Up (0.01)"
        Me.btn_uvfine.UseVisualStyleBackColor = True
        '
        'btn_up
        '
        Me.btn_up.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_up.Location = New System.Drawing.Point(438, 38)
        Me.btn_up.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(90, 20)
        Me.btn_up.TabIndex = 39
        Me.btn_up.Text = "Up"
        Me.btn_up.UseVisualStyleBackColor = True
        '
        'btn_dvfine
        '
        Me.btn_dvfine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_dvfine.Location = New System.Drawing.Point(625, 91)
        Me.btn_dvfine.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_dvfine.Name = "btn_dvfine"
        Me.btn_dvfine.Size = New System.Drawing.Size(90, 20)
        Me.btn_dvfine.TabIndex = 40
        Me.btn_dvfine.Text = "Down (0.01)"
        Me.btn_dvfine.UseVisualStyleBackColor = True
        '
        'btn_down
        '
        Me.btn_down.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_down.Location = New System.Drawing.Point(438, 91)
        Me.btn_down.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_down.Name = "btn_down"
        Me.btn_down.Size = New System.Drawing.Size(90, 20)
        Me.btn_down.TabIndex = 41
        Me.btn_down.Text = "Down"
        Me.btn_down.UseVisualStyleBackColor = True
        '
        'timeout
        '
        Me.timeout.Interval = 2000
        '
        'Skippy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 325)
        Me.Controls.Add(Me.btn_down)
        Me.Controls.Add(Me.btn_dvfine)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.btn_uvfine)
        Me.Controls.Add(Me.ckb_noreturn)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_focus)
        Me.Controls.Add(Me.ckb_stdpath)
        Me.Controls.Add(Me.slider_light)
        Me.Controls.Add(Me.btn_light)
        Me.Controls.Add(Me.btn_advanced)
        Me.Controls.Add(Me.btn_ufine)
        Me.Controls.Add(Me.btn_dfine)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.btn_live)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.btn_run)
        Me.Controls.Add(Me.tb_range)
        Me.Controls.Add(Me.tb_move)
        Me.Controls.Add(Me.btn_right)
        Me.Controls.Add(Me.btn_left)
        Me.Controls.Add(Me.cmb_port)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.Previewwindow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Skippy"
        Me.Text = "Skippy v1.2"
        CType(Me.Previewwindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        CType(Me.slider_light, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Previewwindow As PictureBox
    Friend WithEvents btn_connect As Button
    Friend WithEvents cmb_port As ComboBox
    Friend WithEvents btn_left As Button
    Friend WithEvents btn_right As Button
    Friend WithEvents tb_move As TextBox
    Friend WithEvents tb_range As TextBox
    Friend WithEvents btn_run As Button
    Friend WithEvents Status As StatusStrip
    Friend WithEvents Serial As IO.Ports.SerialPort
    Friend WithEvents status_camera As ToolStripStatusLabel
    Friend WithEvents btn_live As Button
    Friend WithEvents btn_picture As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents Savepath As FolderBrowserDialog
    Friend WithEvents btn_dfine As Button
    Friend WithEvents btn_ufine As Button
    Friend WithEvents btn_advanced As Button
    Friend WithEvents btn_light As Button
    Friend WithEvents slider_light As TrackBar
    Friend WithEvents ckb_stdpath As CheckBox
    Friend WithEvents btn_focus As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents ckb_noreturn As CheckBox
    Friend WithEvents btn_uvfine As Button
    Friend WithEvents btn_up As Button
    Friend WithEvents btn_dvfine As Button
    Friend WithEvents btn_down As Button
    Friend WithEvents timeout As Timer
End Class
