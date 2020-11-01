<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class win_options
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(win_options))
        Me.btn_opt_save = New System.Windows.Forms.Button()
        Me.btn_opt_cancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtn_opt_oz = New System.Windows.Forms.RadioButton()
        Me.rbtn_opt_gram = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_loc_location = New System.Windows.Forms.CheckBox()
        Me.txt_loc_postal = New System.Windows.Forms.TextBox()
        Me.chk_loc_postal = New System.Windows.Forms.CheckBox()
        Me.txt_loc_state = New System.Windows.Forms.TextBox()
        Me.chk_loc_state = New System.Windows.Forms.CheckBox()
        Me.txt_loc_country = New System.Windows.Forms.TextBox()
        Me.chk_loc_country = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lb_keybinding = New System.Windows.Forms.Label()
        Me.btn_sethotkey = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_opt_save
        '
        Me.btn_opt_save.Font = New System.Drawing.Font("Candara", 24.0!)
        Me.btn_opt_save.Location = New System.Drawing.Point(12, 447)
        Me.btn_opt_save.Name = "btn_opt_save"
        Me.btn_opt_save.Size = New System.Drawing.Size(136, 47)
        Me.btn_opt_save.TabIndex = 10
        Me.btn_opt_save.Text = "Save"
        Me.btn_opt_save.UseVisualStyleBackColor = True
        '
        'btn_opt_cancel
        '
        Me.btn_opt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_opt_cancel.Font = New System.Drawing.Font("Candara", 24.0!)
        Me.btn_opt_cancel.Location = New System.Drawing.Point(12, 500)
        Me.btn_opt_cancel.Name = "btn_opt_cancel"
        Me.btn_opt_cancel.Size = New System.Drawing.Size(136, 47)
        Me.btn_opt_cancel.TabIndex = 11
        Me.btn_opt_cancel.Text = "Cancel"
        Me.btn_opt_cancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtn_opt_oz)
        Me.GroupBox1.Controls.Add(Me.rbtn_opt_gram)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 82)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Units"
        '
        'rbtn_opt_oz
        '
        Me.rbtn_opt_oz.AutoSize = True
        Me.rbtn_opt_oz.Location = New System.Drawing.Point(13, 49)
        Me.rbtn_opt_oz.Name = "rbtn_opt_oz"
        Me.rbtn_opt_oz.Size = New System.Drawing.Size(78, 23)
        Me.rbtn_opt_oz.TabIndex = 1
        Me.rbtn_opt_oz.Text = "Ounces"
        Me.rbtn_opt_oz.UseVisualStyleBackColor = True
        '
        'rbtn_opt_gram
        '
        Me.rbtn_opt_gram.AutoSize = True
        Me.rbtn_opt_gram.Checked = True
        Me.rbtn_opt_gram.Location = New System.Drawing.Point(13, 20)
        Me.rbtn_opt_gram.Name = "rbtn_opt_gram"
        Me.rbtn_opt_gram.Size = New System.Drawing.Size(71, 23)
        Me.rbtn_opt_gram.TabIndex = 0
        Me.rbtn_opt_gram.TabStop = True
        Me.rbtn_opt_gram.Text = "Grams"
        Me.rbtn_opt_gram.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk_loc_location)
        Me.GroupBox3.Controls.Add(Me.txt_loc_postal)
        Me.GroupBox3.Controls.Add(Me.chk_loc_postal)
        Me.GroupBox3.Controls.Add(Me.txt_loc_state)
        Me.GroupBox3.Controls.Add(Me.chk_loc_state)
        Me.GroupBox3.Controls.Add(Me.txt_loc_country)
        Me.GroupBox3.Controls.Add(Me.chk_loc_country)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(139, 158)
        Me.GroupBox3.TabIndex = 102
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Location"
        '
        'chk_loc_location
        '
        Me.chk_loc_location.AutoSize = True
        Me.chk_loc_location.Location = New System.Drawing.Point(117, 4)
        Me.chk_loc_location.Name = "chk_loc_location"
        Me.chk_loc_location.Size = New System.Drawing.Size(15, 14)
        Me.chk_loc_location.TabIndex = 3
        Me.chk_loc_location.UseVisualStyleBackColor = True
        '
        'txt_loc_postal
        '
        Me.txt_loc_postal.Enabled = False
        Me.txt_loc_postal.Location = New System.Drawing.Point(54, 93)
        Me.txt_loc_postal.MaxLength = 4
        Me.txt_loc_postal.Name = "txt_loc_postal"
        Me.txt_loc_postal.Size = New System.Drawing.Size(72, 27)
        Me.txt_loc_postal.TabIndex = 9
        '
        'chk_loc_postal
        '
        Me.chk_loc_postal.AutoSize = True
        Me.chk_loc_postal.Enabled = False
        Me.chk_loc_postal.Location = New System.Drawing.Point(21, 126)
        Me.chk_loc_postal.Name = "chk_loc_postal"
        Me.chk_loc_postal.Size = New System.Drawing.Size(109, 23)
        Me.chk_loc_postal.TabIndex = 8
        Me.chk_loc_postal.Text = "Postal Code"
        Me.chk_loc_postal.UseVisualStyleBackColor = True
        '
        'txt_loc_state
        '
        Me.txt_loc_state.Enabled = False
        Me.txt_loc_state.Location = New System.Drawing.Point(6, 93)
        Me.txt_loc_state.MaxLength = 2
        Me.txt_loc_state.Name = "txt_loc_state"
        Me.txt_loc_state.Size = New System.Drawing.Size(42, 27)
        Me.txt_loc_state.TabIndex = 7
        '
        'chk_loc_state
        '
        Me.chk_loc_state.AutoSize = True
        Me.chk_loc_state.Enabled = False
        Me.chk_loc_state.Location = New System.Drawing.Point(4, 73)
        Me.chk_loc_state.Name = "chk_loc_state"
        Me.chk_loc_state.Size = New System.Drawing.Size(64, 23)
        Me.chk_loc_state.TabIndex = 6
        Me.chk_loc_state.Text = "State"
        Me.chk_loc_state.UseVisualStyleBackColor = True
        '
        'txt_loc_country
        '
        Me.txt_loc_country.Enabled = False
        Me.txt_loc_country.Location = New System.Drawing.Point(6, 40)
        Me.txt_loc_country.Name = "txt_loc_country"
        Me.txt_loc_country.Size = New System.Drawing.Size(124, 27)
        Me.txt_loc_country.TabIndex = 5
        '
        'chk_loc_country
        '
        Me.chk_loc_country.AutoSize = True
        Me.chk_loc_country.Enabled = False
        Me.chk_loc_country.Location = New System.Drawing.Point(4, 20)
        Me.chk_loc_country.Name = "chk_loc_country"
        Me.chk_loc_country.Size = New System.Drawing.Size(83, 23)
        Me.chk_loc_country.TabIndex = 4
        Me.chk_loc_country.Text = "Country"
        Me.chk_loc_country.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_sethotkey)
        Me.GroupBox2.Controls.Add(Me.lb_keybinding)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 71)
        Me.GroupBox2.TabIndex = 103
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SmokeKey"
        '
        'lb_keybinding
        '
        Me.lb_keybinding.AutoSize = True
        Me.lb_keybinding.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_keybinding.Location = New System.Drawing.Point(9, 23)
        Me.lb_keybinding.Name = "lb_keybinding"
        Me.lb_keybinding.Size = New System.Drawing.Size(121, 15)
        Me.lb_keybinding.TabIndex = 0
        Me.lb_keybinding.Text = "Alt+Ctrl+Shift+Enter"
        Me.lb_keybinding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_sethotkey
        '
        Me.btn_sethotkey.Location = New System.Drawing.Point(21, 41)
        Me.btn_sethotkey.Name = "btn_sethotkey"
        Me.btn_sethotkey.Size = New System.Drawing.Size(81, 23)
        Me.btn_sethotkey.TabIndex = 1
        Me.btn_sethotkey.Text = "Set"
        Me.btn_sethotkey.UseVisualStyleBackColor = True
        '
        'win_options
        '
        Me.AcceptButton = Me.btn_opt_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btn_opt_cancel
        Me.ClientSize = New System.Drawing.Size(160, 559)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_opt_cancel)
        Me.Controls.Add(Me.btn_opt_save)
        Me.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "win_options"
        Me.Text = "Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_opt_save As Button
    Friend WithEvents btn_opt_cancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtn_opt_oz As RadioButton
    Friend WithEvents rbtn_opt_gram As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_loc_state As TextBox
    Friend WithEvents chk_loc_state As CheckBox
    Friend WithEvents txt_loc_country As TextBox
    Friend WithEvents chk_loc_country As CheckBox
    Friend WithEvents txt_loc_postal As TextBox
    Friend WithEvents chk_loc_postal As CheckBox
    Friend WithEvents chk_loc_location As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lb_keybinding As Label
    Friend WithEvents btn_sethotkey As Button
End Class
