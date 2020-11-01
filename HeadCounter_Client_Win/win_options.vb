Imports System.Text.RegularExpressions

Public Class win_options


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_opt_save.Click
        FunctionDebloat.SaveSet()
        Me.Close()
        win_main.Activate()
    End Sub

    Private Sub btn_opt_cancel_Click(sender As Object, e As EventArgs) Handles btn_opt_cancel.Click
        Me.Close()
        win_main.Activate()
    End Sub

    Private Sub Location_cbNtxt_check(sender As Object, e As EventArgs) Handles chk_loc_location.CheckStateChanged, chk_loc_country.CheckStateChanged, chk_loc_state.CheckedChanged, chk_loc_postal.CheckedChanged
        FunctionDebloat.Location_cbNtxt_check()
    End Sub

    Private Sub win_options_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim loc As Point

        loc = win_main.Location + New Size(win_main.Size.Width, 0)
        Me.Location = loc

    End Sub

    Private Sub txt_loc_country_TextChanged(sender As Object, e As EventArgs) Handles txt_loc_country.TextChanged
        Dim digitsOnly As Regex = New Regex("[\d]+")

        sender.Text = digitsOnly.Replace(sender.Text, "")

        My.Settings.country_txt = sender.Text
    End Sub

    Private Sub txt_loc_state_TextChanged(sender As Object, e As EventArgs) Handles txt_loc_state.TextChanged, txt_loc_postal.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        Dim a As Integer

        sender.Text = digitsOnly.Replace(sender.Text, "")
        sender.SelectionLength = 0

        If Integer.TryParse(sender.Text, a) Then
            If sender.name Is txt_loc_postal Then
                My.Settings.postal_txt = a
            ElseIf sender.name Is txt_loc_state Then
                My.Settings.state_txt = a
            End If
        End If
    End Sub

    Private Sub btn_sethotkey_Click(sender As Object, e As EventArgs) Handles btn_sethotkey.Click
        win_hotkey_capture.Show()
    End Sub
End Class
