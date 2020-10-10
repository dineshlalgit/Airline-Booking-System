<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payflight
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.namecard = New System.Windows.Forms.Label()
        Me.Cardnumber = New System.Windows.Forms.Label()
        Me.expiry = New System.Windows.Forms.Label()
        Me.CCV = New System.Windows.Forms.Label()
        Me.name_card = New System.Windows.Forms.TextBox()
        Me.Card_number = New System.Windows.Forms.TextBox()
        Me.expirydate = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.pay_btn = New System.Windows.Forms.Button()
        Me.cancel_btnpay = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.email_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(274, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment Gateway"
        '
        'namecard
        '
        Me.namecard.AutoSize = True
        Me.namecard.BackColor = System.Drawing.Color.Transparent
        Me.namecard.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namecard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.namecard.Location = New System.Drawing.Point(32, 169)
        Me.namecard.Name = "namecard"
        Me.namecard.Size = New System.Drawing.Size(230, 40)
        Me.namecard.TabIndex = 1
        Me.namecard.Text = "Name On Card"
        '
        'Cardnumber
        '
        Me.Cardnumber.AutoSize = True
        Me.Cardnumber.BackColor = System.Drawing.Color.Transparent
        Me.Cardnumber.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cardnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cardnumber.Location = New System.Drawing.Point(32, 223)
        Me.Cardnumber.Name = "Cardnumber"
        Me.Cardnumber.Size = New System.Drawing.Size(219, 42)
        Me.Cardnumber.TabIndex = 2
        Me.Cardnumber.Text = "Card Number"
        '
        'expiry
        '
        Me.expiry.AutoSize = True
        Me.expiry.BackColor = System.Drawing.Color.Transparent
        Me.expiry.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expiry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.expiry.Location = New System.Drawing.Point(32, 289)
        Me.expiry.Name = "expiry"
        Me.expiry.Size = New System.Drawing.Size(193, 42)
        Me.expiry.TabIndex = 3
        Me.expiry.Text = "Expiry Date"
        '
        'CCV
        '
        Me.CCV.AutoSize = True
        Me.CCV.BackColor = System.Drawing.Color.Transparent
        Me.CCV.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CCV.Location = New System.Drawing.Point(32, 345)
        Me.CCV.Name = "CCV"
        Me.CCV.Size = New System.Drawing.Size(95, 42)
        Me.CCV.TabIndex = 4
        Me.CCV.Text = "CCV"
        '
        'name_card
        '
        Me.name_card.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_card.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.name_card.Location = New System.Drawing.Point(284, 169)
        Me.name_card.Multiline = True
        Me.name_card.Name = "name_card"
        Me.name_card.Size = New System.Drawing.Size(293, 40)
        Me.name_card.TabIndex = 5
        '
        'Card_number
        '
        Me.Card_number.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Card_number.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Card_number.Location = New System.Drawing.Point(284, 226)
        Me.Card_number.Multiline = True
        Me.Card_number.Name = "Card_number"
        Me.Card_number.Size = New System.Drawing.Size(293, 39)
        Me.Card_number.TabIndex = 6
        '
        'expirydate
        '
        Me.expirydate.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expirydate.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.expirydate.Location = New System.Drawing.Point(284, 295)
        Me.expirydate.Mask = "00/00"
        Me.expirydate.Name = "expirydate"
        Me.expirydate.Size = New System.Drawing.Size(129, 39)
        Me.expirydate.TabIndex = 7
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.MaskedTextBox1.Location = New System.Drawing.Point(284, 348)
        Me.MaskedTextBox1.Mask = "0:0:0"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(129, 39)
        Me.MaskedTextBox1.TabIndex = 8
        '
        'pay_btn
        '
        Me.pay_btn.BackColor = System.Drawing.Color.Transparent
        Me.pay_btn.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_btn.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pay_btn.Location = New System.Drawing.Point(316, 535)
        Me.pay_btn.Name = "pay_btn"
        Me.pay_btn.Size = New System.Drawing.Size(153, 40)
        Me.pay_btn.TabIndex = 9
        Me.pay_btn.Text = "Pay now"
        Me.pay_btn.UseVisualStyleBackColor = False
        '
        'cancel_btnpay
        '
        Me.cancel_btnpay.BackColor = System.Drawing.Color.Transparent
        Me.cancel_btnpay.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btnpay.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cancel_btnpay.Location = New System.Drawing.Point(616, 535)
        Me.cancel_btnpay.Name = "cancel_btnpay"
        Me.cancel_btnpay.Size = New System.Drawing.Size(119, 40)
        Me.cancel_btnpay.TabIndex = 10
        Me.cancel_btnpay.Text = "Cancel"
        Me.cancel_btnpay.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 42)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "E-Mail ID"
        '
        'email_id
        '
        Me.email_id.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_id.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.email_id.Location = New System.Drawing.Point(284, 412)
        Me.email_id.Multiline = True
        Me.email_id.Name = "email_id"
        Me.email_id.Size = New System.Drawing.Size(293, 42)
        Me.email_id.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(32, 482)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 42)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Price"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.BackColor = System.Drawing.Color.Transparent
        Me.price.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.price.Location = New System.Drawing.Point(277, 482)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(0, 42)
        Me.price.TabIndex = 14
        '
        'payflight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Airline_Booking_System.My.Resources.Resources.Flexible_payment_Medview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 707)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.email_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cancel_btnpay)
        Me.Controls.Add(Me.pay_btn)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.expirydate)
        Me.Controls.Add(Me.Card_number)
        Me.Controls.Add(Me.name_card)
        Me.Controls.Add(Me.CCV)
        Me.Controls.Add(Me.expiry)
        Me.Controls.Add(Me.Cardnumber)
        Me.Controls.Add(Me.namecard)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "payflight"
        Me.Text = "payflight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents namecard As Label
    Friend WithEvents Cardnumber As Label
    Friend WithEvents expiry As Label
    Friend WithEvents CCV As Label
    Friend WithEvents name_card As TextBox
    Friend WithEvents Card_number As TextBox
    Friend WithEvents expirydate As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents pay_btn As Button
    Friend WithEvents cancel_btnpay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents email_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents price As Label
End Class
