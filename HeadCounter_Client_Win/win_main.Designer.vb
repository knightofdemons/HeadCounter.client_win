<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class win_main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(win_main))
        Me.bt_smoke = New System.Windows.Forms.Button()
        Me.rbt_joint = New System.Windows.Forms.RadioButton()
        Me.rbt_bowl = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_unitdefault = New System.Windows.Forms.TextBox()
        Me.lb_metric = New System.Windows.Forms.Label()
        Me.bt_deletelist = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lb_total_total = New System.Windows.Forms.Label()
        Me.lb_total_mj = New System.Windows.Forms.Label()
        Me.lb_total_head = New System.Windows.Forms.Label()
        Me.lb_total_joint = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_about = New System.Windows.Forms.Button()
        Me.btn_options = New System.Windows.Forms.Button()
        Me.table_view = New System.Windows.Forms.DataGridView()
        Me.lb_last = New System.Windows.Forms.Label()
        Me.timer_lb_last = New System.Windows.Forms.Timer(Me.components)
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.TIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SmokeHeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_last = New System.Windows.Forms.ToolStripTextBox()
        Me.ShowHideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_totray = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.table_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_smoke
        '
        Me.bt_smoke.Font = New System.Drawing.Font("Candara", 24.0!)
        Me.bt_smoke.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_smoke.Location = New System.Drawing.Point(8, 327)
        Me.bt_smoke.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_smoke.Name = "bt_smoke"
        Me.bt_smoke.Size = New System.Drawing.Size(284, 73)
        Me.bt_smoke.TabIndex = 0
        Me.bt_smoke.Text = "🔥 Smoke Head 🔥"
        Me.bt_smoke.UseVisualStyleBackColor = True
        '
        'rbt_joint
        '
        Me.rbt_joint.AutoSize = True
        Me.rbt_joint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rbt_joint.Checked = True
        Me.rbt_joint.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_joint.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.rbt_joint.Location = New System.Drawing.Point(194, 236)
        Me.rbt_joint.Margin = New System.Windows.Forms.Padding(4)
        Me.rbt_joint.Name = "rbt_joint"
        Me.rbt_joint.Size = New System.Drawing.Size(61, 23)
        Me.rbt_joint.TabIndex = 2
        Me.rbt_joint.TabStop = True
        Me.rbt_joint.Text = "Joint"
        Me.rbt_joint.UseVisualStyleBackColor = True
        '
        'rbt_bowl
        '
        Me.rbt_bowl.AutoSize = True
        Me.rbt_bowl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rbt_bowl.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_bowl.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.rbt_bowl.Location = New System.Drawing.Point(48, 236)
        Me.rbt_bowl.Margin = New System.Windows.Forms.Padding(4)
        Me.rbt_bowl.Name = "rbt_bowl"
        Me.rbt_bowl.Size = New System.Drawing.Size(61, 23)
        Me.rbt_bowl.TabIndex = 3
        Me.rbt_bowl.TabStop = True
        Me.rbt_bowl.Text = "Bowl"
        Me.rbt_bowl.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt_joint)
        Me.GroupBox1.Controls.Add(Me.rbt_bowl)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txt_unitdefault)
        Me.GroupBox1.Controls.Add(Me.lb_metric)
        Me.GroupBox1.Controls.Add(Me.bt_smoke)
        Me.GroupBox1.Location = New System.Drawing.Point(618, -3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(300, 407)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HeadCounter_Client_Win.My.Resources.Resources.pic_joint
        Me.PictureBox2.Location = New System.Drawing.Point(156, 18)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(136, 214)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HeadCounter_Client_Win.My.Resources.Resources.pic_bong
        Me.PictureBox1.Location = New System.Drawing.Point(8, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txt_unitdefault
        '
        Me.txt_unitdefault.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_unitdefault.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txt_unitdefault.Font = New System.Drawing.Font("Candara Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unitdefault.Location = New System.Drawing.Point(101, 276)
        Me.txt_unitdefault.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_unitdefault.MaxLength = 6
        Me.txt_unitdefault.Name = "txt_unitdefault"
        Me.txt_unitdefault.Size = New System.Drawing.Size(51, 33)
        Me.txt_unitdefault.TabIndex = 4
        Me.txt_unitdefault.Text = "0.1"
        Me.txt_unitdefault.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_unitdefault.WordWrap = False
        '
        'lb_metric
        '
        Me.lb_metric.AutoSize = True
        Me.lb_metric.Font = New System.Drawing.Font("Candara Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_metric.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lb_metric.Location = New System.Drawing.Point(151, 281)
        Me.lb_metric.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_metric.Name = "lb_metric"
        Me.lb_metric.Size = New System.Drawing.Size(72, 26)
        Me.lb_metric.TabIndex = 5
        Me.lb_metric.Text = "g / unit"
        '
        'bt_deletelist
        '
        Me.bt_deletelist.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_deletelist.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_deletelist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_deletelist.Location = New System.Drawing.Point(6, 606)
        Me.bt_deletelist.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_deletelist.Name = "bt_deletelist"
        Me.bt_deletelist.Size = New System.Drawing.Size(604, 35)
        Me.bt_deletelist.TabIndex = 7
        Me.bt_deletelist.Text = "Delete Selected"
        Me.bt_deletelist.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lb_total_total)
        Me.GroupBox2.Controls.Add(Me.lb_total_mj)
        Me.GroupBox2.Controls.Add(Me.lb_total_head)
        Me.GroupBox2.Controls.Add(Me.lb_total_joint)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(618, 601)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 100)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Statistics"
        '
        'lb_total_total
        '
        Me.lb_total_total.AutoSize = True
        Me.lb_total_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_total_total.Location = New System.Drawing.Point(128, 19)
        Me.lb_total_total.Name = "lb_total_total"
        Me.lb_total_total.Size = New System.Drawing.Size(108, 19)
        Me.lb_total_total.TabIndex = 7
        Me.lb_total_total.Text = "00000000000"
        '
        'lb_total_mj
        '
        Me.lb_total_mj.AutoSize = True
        Me.lb_total_mj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_total_mj.Location = New System.Drawing.Point(128, 73)
        Me.lb_total_mj.Name = "lb_total_mj"
        Me.lb_total_mj.Size = New System.Drawing.Size(45, 19)
        Me.lb_total_mj.TabIndex = 6
        Me.lb_total_mj.Text = "0000"
        '
        'lb_total_head
        '
        Me.lb_total_head.AutoSize = True
        Me.lb_total_head.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_total_head.Location = New System.Drawing.Point(128, 57)
        Me.lb_total_head.Name = "lb_total_head"
        Me.lb_total_head.Size = New System.Drawing.Size(63, 19)
        Me.lb_total_head.TabIndex = 5
        Me.lb_total_head.Text = "000000"
        '
        'lb_total_joint
        '
        Me.lb_total_joint.AutoSize = True
        Me.lb_total_joint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_total_joint.Location = New System.Drawing.Point(128, 38)
        Me.lb_total_joint.Name = "lb_total_joint"
        Me.lb_total_joint.Size = New System.Drawing.Size(108, 19)
        Me.lb_total_joint.TabIndex = 4
        Me.lb_total_joint.Text = "00000000000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MaryJane"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Heads"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Joints"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total"
        '
        'btn_about
        '
        Me.btn_about.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.btn_about.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_about.Location = New System.Drawing.Point(316, 649)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(149, 53)
        Me.btn_about.TabIndex = 9
        Me.btn_about.Text = "About and Privacy"
        Me.btn_about.UseVisualStyleBackColor = True
        '
        'btn_options
        '
        Me.btn_options.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_options.Location = New System.Drawing.Point(6, 648)
        Me.btn_options.Name = "btn_options"
        Me.btn_options.Size = New System.Drawing.Size(304, 54)
        Me.btn_options.TabIndex = 10
        Me.btn_options.Text = "Options"
        Me.btn_options.UseVisualStyleBackColor = True
        '
        'table_view
        '
        Me.table_view.AllowUserToAddRows = False
        Me.table_view.AllowUserToDeleteRows = False
        Me.table_view.AllowUserToResizeRows = False
        Me.table_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.table_view.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_view.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.table_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_view.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.table_view.ColumnHeadersHeight = 20
        Me.table_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_view.DefaultCellStyle = DataGridViewCellStyle2
        Me.table_view.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.table_view.EnableHeadersVisualStyles = False
        Me.table_view.Location = New System.Drawing.Point(6, 8)
        Me.table_view.MultiSelect = False
        Me.table_view.Name = "table_view"
        Me.table_view.RowHeadersVisible = False
        Me.table_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.table_view.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.table_view.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table_view.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.table_view.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.table_view.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.table_view.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.table_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_view.ShowCellToolTips = False
        Me.table_view.ShowEditingIcon = False
        Me.table_view.ShowRowErrors = False
        Me.table_view.Size = New System.Drawing.Size(604, 591)
        Me.table_view.TabIndex = 11
        Me.table_view.TabStop = False
        '
        'lb_last
        '
        Me.lb_last.AutoSize = True
        Me.lb_last.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_last.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_last.Location = New System.Drawing.Point(642, 451)
        Me.lb_last.Name = "lb_last"
        Me.lb_last.Size = New System.Drawing.Size(128, 33)
        Me.lb_last.TabIndex = 12
        Me.lb_last.Text = "Loading..."
        '
        'timer_lb_last
        '
        Me.timer_lb_last.Enabled = True
        Me.timer_lb_last.Interval = 500
        '
        'btn_exit
        '
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exit.Font = New System.Drawing.Font("Candara", 14.0!)
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_exit.Location = New System.Drawing.Point(471, 674)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(139, 28)
        Me.btn_exit.TabIndex = 13
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'TIcon
        '
        Me.TIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TIcon.BalloonTipText = "Doubleclick Trayicon to Show/Hide"
        Me.TIcon.BalloonTipTitle = "Tip"
        Me.TIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TIcon.Text = "HeadCounter"
        Me.TIcon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmokeHeadToolStripMenuItem, Me.menu_last, Me.ShowHideToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 88)
        '
        'SmokeHeadToolStripMenuItem
        '
        Me.SmokeHeadToolStripMenuItem.Name = "SmokeHeadToolStripMenuItem"
        Me.SmokeHeadToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SmokeHeadToolStripMenuItem.Text = "🔥 Smoke Head 🔥"
        '
        'menu_last
        '
        Me.menu_last.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.menu_last.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.menu_last.Enabled = False
        Me.menu_last.Name = "menu_last"
        Me.menu_last.Size = New System.Drawing.Size(100, 16)
        Me.menu_last.Text = "00:00:00:00"
        Me.menu_last.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.menu_last.ToolTipText = "Time since last smoke"
        '
        'ShowHideToolStripMenuItem
        '
        Me.ShowHideToolStripMenuItem.Name = "ShowHideToolStripMenuItem"
        Me.ShowHideToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ShowHideToolStripMenuItem.Text = "Show/Hide"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btn_totray
        '
        Me.btn_totray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_totray.Location = New System.Drawing.Point(471, 649)
        Me.btn_totray.Name = "btn_totray"
        Me.btn_totray.Size = New System.Drawing.Size(138, 25)
        Me.btn_totray.TabIndex = 14
        Me.btn_totray.Text = "Minimize to tray"
        Me.btn_totray.UseVisualStyleBackColor = True
        '
        'win_main
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btn_exit
        Me.ClientSize = New System.Drawing.Size(927, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_totray)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lb_last)
        Me.Controls.Add(Me.table_view)
        Me.Controls.Add(Me.btn_options)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bt_deletelist)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "win_main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.table_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_smoke As Button
    Friend WithEvents rbt_joint As RadioButton
    Friend WithEvents rbt_bowl As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_unitdefault As TextBox
    Friend WithEvents lb_metric As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents bt_deletelist As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lb_total_total As Label
    Friend WithEvents lb_total_mj As Label
    Friend WithEvents lb_total_head As Label
    Friend WithEvents lb_total_joint As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_about As Button
    Friend WithEvents btn_options As Button
    Friend WithEvents table_view As DataGridView
    Friend WithEvents lb_last As Label
    Friend WithEvents timer_lb_last As Timer
    Friend WithEvents btn_exit As Button
    Friend WithEvents TIcon As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowHideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmokeHeadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_last As ToolStripTextBox
    Friend WithEvents btn_totray As Button
End Class
