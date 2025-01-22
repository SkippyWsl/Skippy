Public Class Advanced

    Private Sub btn_cal_Click(sender As Object, e As EventArgs) Handles btn_cal.Click
        Skippy.Scom("Cal")
    End Sub

    Private Sub btn_sethome_Click(sender As Object, e As EventArgs) Handles btn_sethome.Click
        Skippy.Scom("Set")
    End Sub

    Private Sub btn_getx_Click(sender As Object, e As EventArgs) Handles btn_getx.Click
        Skippy.Smsg = String.Empty
        Skippy.Scom("Getx")
        While Skippy.Smsg = String.Empty
            Application.DoEvents()
        End While
        MessageBox.Show("Current X position is " & Skippy.Smsg)
    End Sub

    Private Sub btn_goto_Click(sender As Object, e As EventArgs) Handles btn_goto.Click
        If IsNumeric(tb_goto.Text) Then
            Dim x
            Dim target
            Skippy.Smsg = String.Empty
            Skippy.Scom("Getx")
            While Skippy.Smsg = String.Empty
                Application.DoEvents()
            End While
            x = Convert.ToInt32(Skippy.Smsg)
            target = Convert.ToInt32(tb_goto.Text)
            Skippy.Scom(target - x)
        Else
            MessageBox.Show("Go to Value is not numeric")
        End If
    End Sub

    Private Sub Advanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_steps.Text = Skippy.stepwide
        Label1.Select()
    End Sub

    Private Sub tb_steps_GotFocus(sender As Object, e As EventArgs) Handles tb_steps.GotFocus
        tb_steps.ResetText()
    End Sub

    Private Sub tb_goto_GotFocus(sender As Object, e As EventArgs) Handles tb_goto.GotFocus
        tb_goto.ResetText()
    End Sub

    Private Sub tb_steps_TextChanged(sender As Object, e As EventArgs) Handles tb_steps.TextChanged
        If IsNumeric(tb_steps.Text) Then
            Skippy.stepwide = tb_steps.Text
        ElseIf tb_steps.Text = "" Then
            Exit Sub
        Else
            MessageBox.Show("Step Value is not numeric")
        End If
    End Sub
End Class