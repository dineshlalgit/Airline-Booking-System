<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login_pass
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_pass))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.admin_text = New System.Windows.Forms.TextBox()
        Me.adminpass_text = New System.Windows.Forms.Label()
        Me.passtext = New System.Windows.Forms.TextBox()
        Me.adminrd = New System.Windows.Forms.RadioButton()
        Me.userrdbtn = New System.Windows.Forms.RadioButton()
        Me.admincancel = New System.Windows.Forms.Button()
        Me.adminbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Red
        Me.UsernameLabel.Location = New System.Drawing.Point(743, 160)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(130, 30)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "UserName"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Red
        Me.PasswordLabel.Location = New System.Drawing.Point(743, 213)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(118, 30)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.IndianRed
        Me.UsernameTextBox.Location = New System.Drawing.Point(879, 160)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(258, 30)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.IndianRed
        Me.PasswordTextBox.Location = New System.Drawing.Point(879, 213)
        Me.PasswordTextBox.Multiline = True
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(258, 30)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.Moccasin
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.Red
        Me.OK.Location = New System.Drawing.Point(800, 289)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 33)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Moccasin
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.Red
        Me.Cancel.Location = New System.Drawing.Point(931, 289)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(98, 33)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(174, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 73)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Airline Booking System"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(57, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "AdminName"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'admin_text
        '
        Me.admin_text.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_text.ForeColor = System.Drawing.Color.IndianRed
        Me.admin_text.Location = New System.Drawing.Point(238, 160)
        Me.admin_text.Multiline = True
        Me.admin_text.Name = "admin_text"
        Me.admin_text.Size = New System.Drawing.Size(258, 30)
        Me.admin_text.TabIndex = 9
        '
        'adminpass_text
        '
        Me.adminpass_text.BackColor = System.Drawing.Color.Transparent
        Me.adminpass_text.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminpass_text.ForeColor = System.Drawing.Color.Red
        Me.adminpass_text.Location = New System.Drawing.Point(57, 210)
        Me.adminpass_text.Name = "adminpass_text"
        Me.adminpass_text.Size = New System.Drawing.Size(164, 30)
        Me.adminpass_text.TabIndex = 10
        Me.adminpass_text.Text = "Password"
        Me.adminpass_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'passtext
        '
        Me.passtext.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtext.ForeColor = System.Drawing.Color.IndianRed
        Me.passtext.Location = New System.Drawing.Point(238, 210)
        Me.passtext.Multiline = True
        Me.passtext.Name = "passtext"
        Me.passtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtext.Size = New System.Drawing.Size(258, 30)
        Me.passtext.TabIndex = 11
        '
        'adminrd
        '
        Me.adminrd.AutoSize = True
        Me.adminrd.BackColor = System.Drawing.Color.Transparent
        Me.adminrd.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminrd.ForeColor = System.Drawing.Color.Red
        Me.adminrd.Location = New System.Drawing.Point(169, 101)
        Me.adminrd.Name = "adminrd"
        Me.adminrd.Size = New System.Drawing.Size(199, 35)
        Me.adminrd.TabIndex = 12
        Me.adminrd.TabStop = True
        Me.adminrd.Text = "Admin account"
        Me.adminrd.UseVisualStyleBackColor = False
        '
        'userrdbtn
        '
        Me.userrdbtn.AutoSize = True
        Me.userrdbtn.BackColor = System.Drawing.Color.Transparent
        Me.userrdbtn.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userrdbtn.ForeColor = System.Drawing.Color.Red
        Me.userrdbtn.Location = New System.Drawing.Point(852, 101)
        Me.userrdbtn.Name = "userrdbtn"
        Me.userrdbtn.Size = New System.Drawing.Size(175, 35)
        Me.userrdbtn.TabIndex = 13
        Me.userrdbtn.TabStop = True
        Me.userrdbtn.Text = "User account"
        Me.userrdbtn.UseVisualStyleBackColor = False
        '
        'admincancel
        '
        Me.admincancel.BackColor = System.Drawing.Color.Moccasin
        Me.admincancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.admincancel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admincancel.ForeColor = System.Drawing.Color.Red
        Me.admincancel.Location = New System.Drawing.Point(319, 289)
        Me.admincancel.Name = "admincancel"
        Me.admincancel.Size = New System.Drawing.Size(98, 33)
        Me.admincancel.TabIndex = 15
        Me.admincancel.Text = "&Cancel"
        Me.admincancel.UseVisualStyleBackColor = False
        '
        'adminbtn
        '
        Me.adminbtn.BackColor = System.Drawing.Color.Moccasin
        Me.adminbtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.adminbtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminbtn.ForeColor = System.Drawing.Color.Red
        Me.adminbtn.Location = New System.Drawing.Point(188, 289)
        Me.adminbtn.Name = "adminbtn"
        Me.adminbtn.Size = New System.Drawing.Size(94, 33)
        Me.adminbtn.TabIndex = 14
        Me.adminbtn.Text = "&OK"
        Me.adminbtn.UseVisualStyleBackColor = False
        '
        'Login_pass
        '
        Me.AcceptButton = Me.OK
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Airline_Booking_System.My.Resources.Resources.Flight_Discounts_GettyImages_sb10062851ai_001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(1254, 737)
        Me.Controls.Add(Me.admincancel)
        Me.Controls.Add(Me.adminbtn)
        Me.Controls.Add(Me.userrdbtn)
        Me.Controls.Add(Me.adminrd)
        Me.Controls.Add(Me.passtext)
        Me.Controls.Add(Me.adminpass_text)
        Me.Controls.Add(Me.admin_text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login_pass"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Airline Booking System"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents admin_text As TextBox
    Friend WithEvents adminpass_text As Label
    Friend WithEvents passtext As TextBox
    Friend WithEvents adminrd As RadioButton
    Friend WithEvents userrdbtn As RadioButton
    Friend WithEvents admincancel As Button
    Friend WithEvents adminbtn As Button
End Class
