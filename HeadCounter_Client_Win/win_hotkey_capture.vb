Imports System.ComponentModel

Public NotInheritable Class win_hotkey_capture

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Public btpressed As Int32
    Public btmod As Int32

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Hotkey.unregisterHotkeys(win_main)
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        FunctionDebloat.RegisterHotkey(lb_pressed.Text)
        Me.Close()
        win_options.Activate()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        win_options.Activate()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Activate()
    End Sub

    Private Sub Smokekey_capture_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Timer1.Enabled = False
        FunctionDebloat.RegisterHotkey(lb_pressed.Text)
    End Sub

    Private Sub Smokekey_capture_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_ok.KeyDown, lb_pressed.KeyDown, btn_cancel.KeyDown, Me.KeyDown, lb_instructions.KeyDown

        If Not LSet(StrReverse(lb_pressed.Text), 1) = "+" Then
            lb_pressed.Text = ""
        End If

        Select Case e.KeyCode
            Case 16 To 18
                Select Case e.KeyCode
                    Case 16
                        lb_pressed.Text = "SHIFT+"
                    Case 17
                        lb_pressed.Text = "CTRL+"
                    Case 18
                        lb_pressed.Text = "ALT+"
                    Case 91 To 92
                        lb_pressed.Text = "WIN+"
                End Select
                btmod = e.KeyCode
            Case Else
                lb_pressed.Text += e.KeyCode.ToString()
        End Select
        btpressed = e.KeyCode
    End Sub
End Class
