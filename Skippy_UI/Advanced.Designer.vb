﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Advanced
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Advanced))
        Me.tb_steps = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cal = New System.Windows.Forms.Button()
        Me.btn_sethome = New System.Windows.Forms.Button()
        Me.btn_getx = New System.Windows.Forms.Button()
        Me.tb_goto = New System.Windows.Forms.TextBox()
        Me.btn_goto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_steps
        '
        Me.tb_steps.Location = New System.Drawing.Point(13, 13)
        Me.tb_steps.Name = "tb_steps"
        Me.tb_steps.Size = New System.Drawing.Size(100, 20)
        Me.tb_steps.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(119, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Step size in mm"
        '
        'btn_cal
        '
        Me.btn_cal.Location = New System.Drawing.Point(13, 40)
        Me.btn_cal.Name = "btn_cal"
        Me.btn_cal.Size = New System.Drawing.Size(75, 23)
        Me.btn_cal.TabIndex = 2
        Me.btn_cal.Text = "Calibrate 0"
        Me.btn_cal.UseVisualStyleBackColor = True
        '
        'btn_sethome
        '
        Me.btn_sethome.Location = New System.Drawing.Point(94, 40)
        Me.btn_sethome.Name = "btn_sethome"
        Me.btn_sethome.Size = New System.Drawing.Size(75, 23)
        Me.btn_sethome.TabIndex = 3
        Me.btn_sethome.Text = "Set Home"
        Me.btn_sethome.UseVisualStyleBackColor = True
        '
        'btn_getx
        '
        Me.btn_getx.Location = New System.Drawing.Point(175, 40)
        Me.btn_getx.Name = "btn_getx"
        Me.btn_getx.Size = New System.Drawing.Size(75, 23)
        Me.btn_getx.TabIndex = 4
        Me.btn_getx.Text = "Get X pos"
        Me.btn_getx.UseVisualStyleBackColor = True
        '
        'tb_goto
        '
        Me.tb_goto.Location = New System.Drawing.Point(94, 71)
        Me.tb_goto.Name = "tb_goto"
        Me.tb_goto.Size = New System.Drawing.Size(100, 20)
        Me.tb_goto.TabIndex = 5
        '
        'btn_goto
        '
        Me.btn_goto.Location = New System.Drawing.Point(12, 69)
        Me.btn_goto.Name = "btn_goto"
        Me.btn_goto.Size = New System.Drawing.Size(75, 23)
        Me.btn_goto.TabIndex = 6
        Me.btn_goto.Text = "Go to"
        Me.btn_goto.UseVisualStyleBackColor = True
        '
        'Advanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 109)
        Me.Controls.Add(Me.btn_goto)
        Me.Controls.Add(Me.tb_goto)
        Me.Controls.Add(Me.btn_getx)
        Me.Controls.Add(Me.btn_sethome)
        Me.Controls.Add(Me.btn_cal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_steps)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Advanced"
        Me.Text = "Advanced Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_steps As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cal As Button
    Friend WithEvents btn_sethome As Button
    Friend WithEvents btn_getx As Button
    Friend WithEvents tb_goto As TextBox
    Friend WithEvents btn_goto As Button
End Class