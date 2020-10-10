<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Airlinebookingsystem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text2box = New System.Windows.Forms.TextBox()
        Me.Text1box = New System.Windows.Forms.TextBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Airlinebookingsystem
        '
        Me.Airlinebookingsystem.AutoSize = True
        Me.Airlinebookingsystem.BackColor = System.Drawing.Color.Transparent
        Me.Airlinebookingsystem.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Airlinebookingsystem.ForeColor = System.Drawing.Color.Tomato
        Me.Airlinebookingsystem.Location = New System.Drawing.Point(161, 0)
        Me.Airlinebookingsystem.Name = "Airlinebookingsystem"
        Me.Airlinebookingsystem.Size = New System.Drawing.Size(979, 109)
        Me.Airlinebookingsystem.TabIndex = 0
        Me.Airlinebookingsystem.Text = "Airline Booking System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(23, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Tomato
        Me.Label2.Location = New System.Drawing.Point(23, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 55)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Text2box
        '
        Me.Text2box.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2box.Location = New System.Drawing.Point(237, 317)
        Me.Text2box.Multiline = True
        Me.Text2box.Name = "Text2box"
        Me.Text2box.Size = New System.Drawing.Size(251, 55)
        Me.Text2box.TabIndex = 3
        '
        'Text1box
        '
        Me.Text1box.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1box.Location = New System.Drawing.Point(237, 143)
        Me.Text1box.Multiline = True
        Me.Text1box.Name = "Text1box"
        Me.Text1box.Size = New System.Drawing.Size(251, 55)
        Me.Text1box.TabIndex = 4
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.SystemColors.Info
        Me.login_btn.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.Color.Tomato
        Me.login_btn.Location = New System.Drawing.Point(553, 387)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(193, 57)
        Me.login_btn.TabIndex = 5
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Airline_Booking_System.My.Resources.Resources.Flight_Discounts_GettyImages_sb10062851ai_001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1235, 560)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.Text1box)
        Me.Controls.Add(Me.Text2box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Airlinebookingsystem)
        Me.Name = "Login"
        Me.Text = "AIRLINE BOOKING SYSTEM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Airlinebookingsystem As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Text2box As TextBox
    Friend WithEvents Text1box As TextBox
    Friend WithEvents login_btn As Button
End Class
