<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class win_hotkey_capture
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lb_instructions = New System.Windows.Forms.Label()
        Me.lb_pressed = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(97, 143)
        Me.btn_ok.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(218, 58)
        Me.btn_ok.TabIndex = 0
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(324, 143)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(218, 57)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'lb_instructions
        '
        Me.lb_instructions.AutoSize = True
        Me.lb_instructions.Font = New System.Drawing.Font("Candara", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_instructions.Location = New System.Drawing.Point(3, 3)
        Me.lb_instructions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_instructions.Name = "lb_instructions"
        Me.lb_instructions.Size = New System.Drawing.Size(628, 45)
        Me.lb_instructions.TabIndex = 2
        Me.lb_instructions.Text = "Press any Keycombination and click OK"
        '
        'lb_pressed
        '
        Me.lb_pressed.AutoSize = True
        Me.lb_pressed.Font = New System.Drawing.Font("Candara", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_pressed.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lb_pressed.Location = New System.Drawing.Point(191, 48)
        Me.lb_pressed.Name = "lb_pressed"
        Me.lb_pressed.Size = New System.Drawing.Size(214, 59)
        Me.lb_pressed.TabIndex = 3
        Me.lb_pressed.Text = "CTRL+F12"
        Me.lb_pressed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Smokekey_capture
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancel
        Me.ClientSize = New System.Drawing.Size(637, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.lb_pressed)
        Me.Controls.Add(Me.lb_instructions)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_ok)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Smokekey_capture"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents lb_instructions As Label
    Friend WithEvents lb_pressed As Label
    Friend WithEvents Timer1 As Timer
End Class
