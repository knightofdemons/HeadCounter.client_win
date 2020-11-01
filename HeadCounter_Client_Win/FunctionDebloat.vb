Public Class FunctionDebloat
    Public Shared Function newSmoke()
        Dim newrow As DataRow = My.Settings.data.NewRow
        newrow("session") = "0000-0000-0000"
        newrow("type") = My.Settings.type
        newrow("amount") = My.Settings.unit_default
        newrow("g_or_oz") = My.Settings.metric
        newrow("date") = Date.Now()
        newrow("location") = My.Settings.location_txt
        My.Settings.data.Rows.Add(newrow)

        Dim currencyManager1 As CurrencyManager = CType(win_main.BindingContext(win_main.table_view.DataSource), CurrencyManager)
        currencyManager1.SuspendBinding()
        win_main.table_view.Rows(0).Visible = False
        currencyManager1.ResumeBinding()


        Dim tot_total As Integer = My.Settings.data.Rows.Count
        Dim tot_joints As Integer = My.Settings.data.Select("type = 'Joint'").Length
        Dim tot_bowls As Integer = My.Settings.data.Select("type = 'Bowl'").Length
        Dim tot_mj As Decimal = 0.0

        For i As Integer = 0 To My.Settings.data.Rows.Count - 1
            tot_mj += My.Settings.data.Rows(i)(3)
        Next

        win_main.lb_total_total.Text = tot_total
        win_main.lb_total_joint.Text = tot_joints
        win_main.lb_total_head.Text = tot_bowls
        win_main.lb_total_mj.Text = tot_mj

        My.Settings.Save()
    End Function


    Public Shared Function Location_cbNtxt_check()
        If win_options.chk_loc_location.Checked Then
            win_options.chk_loc_country.Enabled = True

            If win_options.chk_loc_country.Checked Then
                win_options.txt_loc_country.Enabled = True
                win_options.chk_loc_state.Enabled = True
                If win_options.chk_loc_state.Checked Then
                    win_options.txt_loc_state.Enabled = True
                    win_options.chk_loc_postal.Enabled = True
                    If win_options.chk_loc_postal.Checked Then
                        win_options.txt_loc_postal.Enabled = True
                    Else
                        win_options.txt_loc_postal.Enabled = False
                    End If
                Else
                    win_options.txt_loc_postal.Enabled = False
                    win_options.chk_loc_postal.Enabled = False
                    win_options.txt_loc_state.Enabled = False
                End If
            Else
                win_options.chk_loc_state.Enabled = False
                win_options.txt_loc_country.Enabled = False
                win_options.chk_loc_postal.Enabled = False
                win_options.txt_loc_postal.Enabled = False
                win_options.txt_loc_state.Enabled = False
            End If

        Else
            win_options.chk_loc_country.Enabled = False
            win_options.chk_loc_state.Enabled = False
            win_options.chk_loc_postal.Enabled = False

            win_options.txt_loc_country.Enabled = False
            win_options.txt_loc_state.Enabled = False
            win_options.txt_loc_postal.Enabled = False
        End If
    End Function

    Public Shared Function SaveSet()
        Dim s As String

        If win_options.rbtn_opt_gram.Checked Then
            My.Settings.type = True
        Else
            My.Settings.type = False
        End If

        If win_options.chk_loc_location.Checked Then
            My.Settings.location_chk = win_options.chk_loc_location.Checked

            If win_options.chk_loc_country.Checked Then
                My.Settings.country_chk = win_options.chk_loc_country.Checked
                My.Settings.country_txt = win_options.txt_loc_country.Text
                If win_options.chk_loc_state.Checked Then
                    My.Settings.state_chk = win_options.chk_loc_state.Checked
                    If Integer.TryParse(win_options.txt_loc_state.Text, s) Then
                        My.Settings.state_txt = s
                    End If
                    If win_options.chk_loc_postal.Checked Then
                        My.Settings.postal_chk = win_options.chk_loc_postal.Checked
                        If Integer.TryParse(win_options.txt_loc_postal.Text, s) Then
                            My.Settings.postal_txt = s
                        End If
                    Else
                        My.Settings.postal_chk = False
                        My.Settings.postal_txt = ""
                    End If
                Else
                    My.Settings.state_chk = False
                    My.Settings.state_txt = ""
                End If
            Else
                My.Settings.country_chk = False
                My.Settings.country_txt = ""
            End If
            My.Settings.location_txt = win_options.txt_loc_country.Text + "," + win_options.txt_loc_state.Text + "," + win_options.txt_loc_postal.Text
        Else
            My.Settings.location_chk = False
            My.Settings.location_txt = ""
        End If

        My.Settings.Save()
    End Function


    Public Shared Function RegisterHotkey(hString As String)

        Try
            Hotkey.unregisterHotkeys(win_main)
        Catch ex As Exception
        End Try

        If win_hotkey_capture.lb_pressed.Text.Contains("+") Then
            Dim ssplit As Array = Split(hString, "+")
            Dim modifier As Int32
            Select Case ssplit(0)
                Case "ALT"
                    modifier = &H1
                Case "CTRL"
                    modifier = &H2
                Case "SHIFT"
                    modifier = &H4
                Case "WIN"
                    modifier = &H8
            End Select
            Hotkey.registerHotkey(win_main, ssplit(1), modifier)
        Else
            Hotkey.registerHotkey(win_main, hString, 0)
        End If


        win_options.lb_keybinding.Text = win_hotkey_capture.lb_pressed.Text
        My.Settings.smokekey = win_hotkey_capture.lb_pressed.Text
    End Function
End Class
