Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class win_main
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = Hotkey.WM_HOTKEY Then
            Hotkey.handleHotKeyEvent(m.WParam)
        End If
        MyBase.WndProc(m)
    End Sub


    Dim MouseDownLocation As Point
    Dim isMouseDown As Boolean
    Dim hasFocus As Boolean = True

    Private Sub win_main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        hasFocus = True
    End Sub

    Private Sub win_main_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        hasFocus = False
    End Sub
    Private Sub TIcon_SingleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TIcon.MouseClick
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show()
        Else
            Me.Activate()
        End If
    End Sub
    Private Sub TIcon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TIcon.DoubleClick, btn_totray.Click
        If hasFocus Then
            If Me.Visible = True Then
                ShowInTaskbar = False
                Me.Hide()
            Else
                Me.Show()
                ShowInTaskbar = True
                Me.WindowState = FormWindowState.Normal
                Me.Activate()
            End If
        Else
            Me.Activate()
        End If

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            MouseDownLocation = e.Location
            isMouseDown = True
            Me.Cursor = Cursors.NoMove2D
        End If

    End Sub
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If isMouseDown = True Then
            Me.Location = Me.Location + (e.Location - MouseDownLocation)
        End If

    End Sub
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        win_about.Show()
    End Sub

    Private Sub btn_options_Click(sender As Object, e As EventArgs) Handles btn_options.Click
        win_options.Show()
        win_options.Activate()
    End Sub

    Private Sub win_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ssplit As String
        Dim s As String


        If My.Settings.data Is Nothing Then
            My.Settings.data = New DataTable
            Dim table_main As DataTable = My.Settings.data
            table_main.TableName = "table_main"
            Dim primaryKey(1) As DataColumn

            With table_main
                .Columns.Add("id", GetType(Int32))
                .Columns.Add("session", System.Type.GetType("System.String"))
                .Columns.Add("type", System.Type.GetType("System.String"))
                .Columns.Add("amount", System.Type.GetType("System.Decimal"))
                .Columns.Add("g_or_oz", System.Type.GetType("System.Boolean"))
                .Columns.Add("date", System.Type.GetType("System.DateTime"))
                .Columns.Add("location", System.Type.GetType("System.String"))
            End With
            primaryKey(0) = My.Settings.data.Columns("id")
            table_main.PrimaryKey = primaryKey
            table_main.Columns("id").AutoIncrement = True
            table_main.Columns("id").Unique = True

            Dim firstRow As DataRow = table_main.NewRow
            firstRow("session") = "0000-0000-0000"
            firstRow("type") = "Bowl"
            firstRow("amount") = 0.0
            firstRow("g_or_oz") = True
            firstRow("date") = DateAndTime.DateValue("January 1, 2000")
            firstRow("location") = "France,00,000"
            table_main.Rows.Add(firstRow)

        End If


        ssplit = My.Settings.data.Rows(My.Settings.data.Rows.Count - 1).Item("location")
        Dim asplit As Array = Split(ssplit, ",")
        If Not asplit(0) = "" Then
            My.Settings.country_txt = asplit(0).ToString
            If Integer.TryParse(asplit(1), s) Then
                My.Settings.state_txt = s
            End If
            If Integer.TryParse(asplit(2), s) Then
                My.Settings.postal_txt = s
            End If
        Else
            My.Settings.country_txt = ""
            My.Settings.state_txt = 0
            My.Settings.postal_txt = 0
        End If


        If My.Settings.type Like "Bowl" Then
            rbt_bowl.Checked = True
            rbt_joint.Checked = False
        Else
            rbt_bowl.Checked = False
            rbt_joint.Checked = True
        End If

        If My.Settings.metric Then
            lb_metric.Text = "g / unit"
            win_options.rbtn_opt_gram.Checked = True
            win_options.rbtn_opt_oz.Checked = False
        Else
            lb_metric.Text = "oz / unit"
            win_options.rbtn_opt_gram.Checked = False
            win_options.rbtn_opt_oz.Checked = True
        End If

        txt_unitdefault.Text = My.Settings.unit_default

        win_options.chk_loc_location.Checked = My.Settings.location_chk
        win_options.chk_loc_country.Checked = My.Settings.country_chk
        win_options.chk_loc_state.Checked = My.Settings.state_chk
        win_options.chk_loc_postal.Checked = My.Settings.postal_chk

        win_options.txt_loc_country.Text = My.Settings.country_txt
        win_options.txt_loc_state.Text = My.Settings.state_txt
        win_options.txt_loc_postal.Text = My.Settings.postal_txt

        table_view.DataSource = My.Settings.data
        table_view.Columns("id").Visible = False
        table_view.Columns("session").Visible = False
        table_view.Columns("type").HeaderText = "Type"
        table_view.Columns("amount").HeaderText = "Amount"
        table_view.Columns("g_or_oz").HeaderText = "Is metric(g)?"
        table_view.Columns("date").HeaderText = "Date"
        table_view.Columns("location").HeaderText = "Location"
        table_view.Columns("type").Width = 75
        table_view.Columns("amount").Width = 75
        table_view.Columns("g_or_oz").Width = 100
        table_view.Columns("date").MinimumWidth = 150
        table_view.Columns("location").MinimumWidth = 150
        table_view.Columns("amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        table_view.Columns("date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        table_view.Columns("location").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        table_view.Columns("id").ReadOnly = True
        table_view.Columns("session").ReadOnly = True
        table_view.Columns("amount").ReadOnly = True
        table_view.Columns("type").ReadOnly = True
        table_view.Columns("g_or_oz").ReadOnly = True
        table_view.Columns("location").ReadOnly = True
        table_view.Columns("date").DefaultCellStyle.Format = "dd/MM/yy hh:mm"


        If table_view.Rows(0).Visible Then
            Dim currencyManager1 As CurrencyManager = CType(BindingContext(table_view.DataSource), CurrencyManager)
            currencyManager1.SuspendBinding()
            table_view.Rows(0).Visible = False
            currencyManager1.ResumeBinding()
        End If

        If Not My.Settings.smokekey = "" Then
            FunctionDebloat.RegisterHotkey(My.Settings.smokekey)
        End If


        TIcon.Icon = Me.Icon
        My.Settings.Save()
        Dim tot_total As Integer = My.Settings.data.Rows.Count
        Dim tot_joints As Integer = My.Settings.data.Select("type = 'Joint'").Length
        Dim tot_bowls As Integer = My.Settings.data.Select("type = 'Bowl'").Length
        Dim tot_mj As Decimal = 0.0

        For i As Integer = 0 To My.Settings.data.Rows.Count - 1
            tot_mj += My.Settings.data.Rows(i)(3)
        Next

        lb_total_total.Text = tot_total
        lb_total_joint.Text = tot_joints
        lb_total_head.Text = tot_bowls
        lb_total_mj.Text = tot_mj
    End Sub

    Private Sub win_main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Hotkey.unregisterHotkeys(Me)
        If rbt_bowl.Checked Then
            My.Settings.type = "Bowl"
        ElseIf rbt_joint.Checked Then
            My.Settings.type = "Joint"
        End If

        '+ write local json
        '+ upload local json


        My.Settings.Save()


    End Sub

    Private Sub Txt_unitdefault_TextChanged(sender As Object, e As EventArgs) Handles txt_unitdefault.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d.]")
        Dim a As Decimal

        txt_unitdefault.Text = Replace(txt_unitdefault.Text, ",", ".")
        txt_unitdefault.Text = digitsOnly.Replace(txt_unitdefault.Text, "")
        If Not txt_unitdefault.Text.Contains(".") Then
            txt_unitdefault.Text = "0." + txt_unitdefault.Text
            txt_unitdefault.SelectionLength = 0
        End If

        If Decimal.TryParse(txt_unitdefault.Text, a) Then
            My.Settings.unit_default = a
        End If
    End Sub

    Private Sub bt_deletelist_Click(sender As Object, e As EventArgs) Handles bt_deletelist.Click
        My.Settings.data.Rows.RemoveAt(table_view.CurrentCell.RowIndex)
    End Sub

    Private Shared Sub bt_smoke_Click() Handles bt_smoke.Click
        FunctionDebloat.newSmoke()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer_lb_last.Tick
        Dim last As TimeSpan

        last = DateTime.Now.Subtract(My.Settings.data.Rows(My.Settings.data.Rows.Count - 1).Item("date"))
        Dim lasttype As String = My.Settings.data.Rows(My.Settings.data.Rows.Count - 1).Item("type")

        If last.Days > 0 Then
            lb_last.Text = "Last " + lasttype + " was " + vbCrLf + CInt(last.Days).ToString() + "d " + CInt(last.Hours).ToString() + "h " + CInt(last.Minutes).ToString() + "min " + CInt(last.Seconds).ToString() + "sec ago."
        ElseIf last.Hours > 0 Then
            lb_last.Text = "Last " + lasttype + " was " + vbCrLf + CInt(last.Hours).ToString() + "h " + CInt(last.Minutes).ToString() + "min " + CInt(last.Seconds).ToString() + "sec ago."
        ElseIf last.Minutes > 0 Then
            lb_last.Text = "Last " + lasttype + " was " + vbCrLf + CInt(last.Minutes).ToString() + "min " + CInt(last.Seconds).ToString() + "sec ago."
        Else
            lb_last.Text = "Last " + lasttype + " was " + vbCrLf + CInt(last.Seconds).ToString() + "sec ago."
        End If

        menu_last.Text = last.ToString("hh\:mm\:ss")

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        End
    End Sub

    Private Sub ShowHideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowHideToolStripMenuItem.Click
        If Me.Visible = True Then
            Me.Hide()
        Else
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            Me.Activate()
        End If
    End Sub

    Private Sub SmokeHeadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmokeHeadToolStripMenuItem.Click
        FunctionDebloat.newSmoke()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        End
    End Sub
End Class


Public Class Hotkey

#Region "Declarations - WinAPI, Hotkey constant and Modifier Enum"
    ''' <summary>
    ''' Declaration of winAPI function wrappers. The winAPI functions are used to register / unregister a hotkey
    ''' </summary>
    Private Declare Function RegisterHotKey Lib "user32" _
        (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer

    Private Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    Public Const WM_HOTKEY As Integer = &H312

    Enum KeyModifier
        None = 0
        Alt = &H1
        Control = &H2
        Shift = &H4
        Winkey = &H8
    End Enum 'This enum is just to make it easier to call the registerHotKey function: The modifier integer codes are replaced by a friendly "Alt","Shift" etc.
#End Region


#Region "Hotkey registration, unregistration and handling"
    Public Shared Sub registerHotkey(ByRef sourceForm As Form, ByVal triggerKey As String, ByVal modifier As KeyModifier)
        RegisterHotKey(sourceForm.Handle, 1, modifier, Asc(triggerKey.ToUpper))
    End Sub
    Public Shared Sub unregisterHotkeys(ByRef sourceForm As Form)
        UnregisterHotKey(sourceForm.Handle, 1)  'Remember to call unregisterHotkeys() when closing your application.
    End Sub
    Public Shared Sub handleHotKeyEvent(ByVal hotkeyID As IntPtr)
        FunctionDebloat.newSmoke()
    End Sub
#End Region

End Class