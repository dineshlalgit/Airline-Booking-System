<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bookurflight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bookurflight))
        Me.onebtnrd = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.roundrd = New System.Windows.Forms.RadioButton()
        Me.destination_c = New System.Windows.Forms.ComboBox()
        Me.arrival_c = New System.Windows.Forms.ComboBox()
        Me.dtpicker_d = New System.Windows.Forms.DateTimePicker()
        Me.dtpicker_a = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.conrdbtn1 = New System.Windows.Forms.RadioButton()
        Me.conrdbtn2 = New System.Windows.Forms.RadioButton()
        Me.concession_c = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.adults_c = New System.Windows.Forms.ComboBox()
        Me.Children_c = New System.Windows.Forms.ComboBox()
        Me.store_c = New System.Windows.Forms.ComboBox()
        Me.class_c = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nextbtn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'onebtnrd
        '
        Me.onebtnrd.AutoSize = True
        Me.onebtnrd.BackColor = System.Drawing.Color.Transparent
        Me.onebtnrd.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onebtnrd.ForeColor = System.Drawing.Color.Red
        Me.onebtnrd.Location = New System.Drawing.Point(58, 90)
        Me.onebtnrd.Name = "onebtnrd"
        Me.onebtnrd.Size = New System.Drawing.Size(140, 35)
        Me.onebtnrd.TabIndex = 0
        Me.onebtnrd.TabStop = True
        Me.onebtnrd.Text = "One way "
        Me.onebtnrd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(427, -8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 78)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Book your flight"
        '
        'roundrd
        '
        Me.roundrd.AutoSize = True
        Me.roundrd.BackColor = System.Drawing.Color.Transparent
        Me.roundrd.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundrd.ForeColor = System.Drawing.Color.Red
        Me.roundrd.Location = New System.Drawing.Point(224, 90)
        Me.roundrd.Name = "roundrd"
        Me.roundrd.Size = New System.Drawing.Size(169, 35)
        Me.roundrd.TabIndex = 2
        Me.roundrd.TabStop = True
        Me.roundrd.Text = "Round Trip"
        Me.roundrd.UseVisualStyleBackColor = False
        '
        'destination_c
        '
        Me.destination_c.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destination_c.ForeColor = System.Drawing.Color.Tomato
        Me.destination_c.FormattingEnabled = True
        Me.destination_c.Items.AddRange(New Object() {"Agartala – Singerbhil Airport", "Agatti Island – Agatti Island Airport", "Agra – Kheria Airport", "Ahmedabad – Sardar Vallabhbhai Patel International Airport", "Aizawl – Aizawl Airport", "Akola – Akola Airport", "Allahabad – Bamrauli Airport", "Along – Along Airport", "Amritsar – Raja Sansi Airport", "Aurangabad – Chikkalthana Airport", "Bagdogra – Bagdogra Airport", "Balurghat – Balurghat Airport", "Bangalore – Kempegowda Airport", "Bareli – Bareli Airport", "Belgaum – Sambre Airport", "Bellary – Bellary Airport", "Bhatinda – Bhatinda Airport", "Bhavnagar – Bhavnagar Airport", "Bhopal – Raja Bhoj Airport", "Bhubaneswar – Biju Patnaik Airport", "Bhuj – Rudra Mata Airport", "Bikaner – Bikaner Airport", "Bilaspur – Bilaspur Airport", "Bombay (Mumbai) – Chhatrapati Shivaji Airport", "Calcutta (Kolkata) – Netaji Subhas Chandra Airport", "Car Nicobar – Car Nicobar Airport", "Chandigarh – Shaheed Bhagat Singh Airport", "Coimbatore – Peelamedu Airport", "Cooch Behar – Cooch Behar Airport", "Cudappah – Cuddapah Airport", "Daman – Daman Airport", "Daparizo – Daparizo Airport", "Darjeeling – Darjeeling Airport", "Dehradun – Jolly Grant Airport", "Delhi – Indira Gandhi Airport", "Deparizo – Deparizo Airport", "Dhanbad – Dhanbad Airport", "Dharamsala – Gaggal Airport", "Dibrugarh – Chabua Airport", "Dimapur – Dimapur Airport", "Diu – Diu Airport", "Gaya – Gaya Airport", "Goa – Dabolim Airport", "Gorakhpur – Gorakhpur Airport", "Guna – Guna Airport", "Guwahati – Borjhar Airport", "Gwalior – Rajmata Vijaya Raje Scindia Air Terminal", "Hissar – Hissar Airport", "Hubli – Hubli Airport", "Hyderabad – Rajiv Gandhi International Airport", "Imphal – Municipal Airport", "Indore – Devi Ahilyabai Holkar Airport", "Jabalpur – Rani Durgawati Airport (Dumna Airport)", "Jagdalpur – Jagdalpur Airport", "Jaipur – Sanganeer Airport", "Jaisalmer – Jaisalmer Airport", "Jammu – Satwari Airport", "Jamnagar – Govardhanpur Airport", "Jamshedpur – Sonari Airport", "Jeypore – Jeypore Airport", "Jodhpur – Jodhpur Airport", "Jorhat – Rowriah Airport", "Kailashahar – Kailashahar Airport", "Kamalpur – Kamalpur Airport", "Kandla – Kandla Airport", "Kanpur – Kanpur Airport", "Keshod – Keshod Airport", "Khajuraho – Khajuraho Airport", "Khowai – Khowai Airport", "Kochi – Cochin International Airport", "Kolhapur – Kolhapur Airport", "Kota – Kinabalu International Airport", "Kozhikode – Calicut International Airport (Karipur Airport)", "Kulu – Bhuntar Airport", "Leh – Kushok Bakula Rinpoche Airport", "Lilabari – Lilabari Airport", "Lucknow – Amausi Airport", "Ludhiana – Sahnewal Airport", "Madras (Chennai) – Meenambakkam International Airport", "Madurai – Madurai Airport", "Malda – Malda Airport", "Mangalore – Bajpe Airport", "Mohanbari – Mohanbari Airport", "Muzaffarnagar – Muzaffarnagar Airport", "Muzaffarpur – Muzaffarpur Airport", "Mysore – Mandakalli Airport", "Nagpur – Dr. Babasaheb Ambedkar International Airport", "Nanded – Shri Guru Gobind Singh Ji Airport", "Nasik – Ozar Airport and Gandhinagar Airport", "Neyveli – Neyveli Airport", "Information about List of all Airports in India - List of Indian Airports - Names" &
                " of all Airports of India", "Osmanabad – Osmanabad Airport", "Pantnagar – Pantnagar Airport", "Pasighat – Pasighat Airport", "Pathankot – Pathankot Airport", "Patna – Jai Prakash Narayan International Airport", "Pondicherry – Pondicherry Airport", "Porbandar – Porbandar Airport", "Port Blair – Veer Savarkar International Airport", "Pune – Lohegaon Airport", "Puttaparthi – Puttaprathe Airport", "Raipur – Swami Vivekananda Airport", "Rajahmundry – Rajahmundry Airport", "Rajkot – Rajkot Airport", "Rajouri – Rajouri Airport", "Ramagundam – Ramagundam Airport", "Ranchi – Birsa Munda Airport", "Ratnagiri – Ratnagiri Airport", "Rewa – Rewa Airport", "Rourkela – Rourkela Airport", "Rupsi – Rupsi Airport", "Salem – Salem Airport", "Satna – Satna Airport", "Shillong – Umroi Airport", "Sholapur – Solapur Airport", "Silchar – Kumbhirgram Airport", "Simla – Shimla Airport", "Srinagar – Srinagar international Airport", "Surat – Surat Airport", "Tezpur – Salonibari Airport", "Tezu – Tezu Airport", "Thanjavur – Thanjavur Airport", "Thiruvananthapuram – Thiruvananthapuram International Airport", "Tiruchirapally – Tiruchirapalli International Airport", "Tirupati – Tirupati Airport", "Tuticorin – Tuticorin Airport", "Udaipur – Dabok Airport", "Vadodara – Civil Airport Harni", "Varanasi – Lal Bahadur Shastri Airport", "Vijayawada – Gannavaram Airport", "Visakhapatnam – Visakhapatnam Airport", "Warangal – Warangal Airport", "Zero – Ziro Airport"})
        Me.destination_c.Location = New System.Drawing.Point(57, 131)
        Me.destination_c.Name = "destination_c"
        Me.destination_c.Size = New System.Drawing.Size(532, 35)
        Me.destination_c.TabIndex = 3
        Me.destination_c.Text = "FROM"
        '
        'arrival_c
        '
        Me.arrival_c.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrival_c.ForeColor = System.Drawing.Color.Tomato
        Me.arrival_c.FormattingEnabled = True
        Me.arrival_c.Items.AddRange(New Object() {"Agartala – Singerbhil Airport", "Agatti Island – Agatti Island Airport", "Agra – Kheria Airport", "Ahmedabad – Sardar Vallabhbhai Patel International Airport", "Aizawl – Aizawl Airport", "Akola – Akola Airport", "Allahabad – Bamrauli Airport", "Along – Along Airport", "Amritsar – Raja Sansi Airport", "Aurangabad – Chikkalthana Airport", "Bagdogra – Bagdogra Airport", "Balurghat – Balurghat Airport", "Bangalore – Kempegowda Airport", "Bareli – Bareli Airport", "Belgaum – Sambre Airport", "Bellary – Bellary Airport", "Bhatinda – Bhatinda Airport", "Bhavnagar – Bhavnagar Airport", "Bhopal – Raja Bhoj Airport", "Bhubaneswar – Biju Patnaik Airport", "Bhuj – Rudra Mata Airport", "Bikaner – Bikaner Airport", "Bilaspur – Bilaspur Airport", "Bombay (Mumbai) – Chhatrapati Shivaji Airport", "Calcutta (Kolkata) – Netaji Subhas Chandra Airport", "Car Nicobar – Car Nicobar Airport", "Chandigarh – Shaheed Bhagat Singh Airport", "Coimbatore – Peelamedu Airport", "Cooch Behar – Cooch Behar Airport", "Cudappah – Cuddapah Airport", "Daman – Daman Airport", "Daparizo – Daparizo Airport", "Darjeeling – Darjeeling Airport", "Dehradun – Jolly Grant Airport", "Delhi – Indira Gandhi Airport", "Deparizo – Deparizo Airport", "Dhanbad – Dhanbad Airport", "Dharamsala – Gaggal Airport", "Dibrugarh – Chabua Airport", "Dimapur – Dimapur Airport", "Diu – Diu Airport", "Gaya – Gaya Airport", "Goa – Dabolim Airport", "Gorakhpur – Gorakhpur Airport", "Guna – Guna Airport", "Guwahati – Borjhar Airport", "Gwalior – Rajmata Vijaya Raje Scindia Air Terminal", "Hissar – Hissar Airport", "Hubli – Hubli Airport", "Hyderabad – Rajiv Gandhi International Airport", "Imphal – Municipal Airport", "Indore – Devi Ahilyabai Holkar Airport", "Jabalpur – Rani Durgawati Airport (Dumna Airport)", "Jagdalpur – Jagdalpur Airport", "Jaipur – Sanganeer Airport", "Jaisalmer – Jaisalmer Airport", "Jammu – Satwari Airport", "Jamnagar – Govardhanpur Airport", "Jamshedpur – Sonari Airport", "Jeypore – Jeypore Airport", "Jodhpur – Jodhpur Airport", "Jorhat – Rowriah Airport", "Kailashahar – Kailashahar Airport", "Kamalpur – Kamalpur Airport", "Kandla – Kandla Airport", "Kanpur – Kanpur Airport", "Keshod – Keshod Airport", "Khajuraho – Khajuraho Airport", "Khowai – Khowai Airport", "Kochi – Cochin International Airport", "Kolhapur – Kolhapur Airport", "Kota – Kinabalu International Airport", "Kozhikode – Calicut International Airport (Karipur Airport)", "Kulu – Bhuntar Airport", "Leh – Kushok Bakula Rinpoche Airport", "Lilabari – Lilabari Airport", "Lucknow – Amausi Airport", "Ludhiana – Sahnewal Airport", "Madras (Chennai) – Meenambakkam International Airport", "Madurai – Madurai Airport", "Malda – Malda Airport", "Mangalore – Bajpe Airport", "Mohanbari – Mohanbari Airport", "Muzaffarnagar – Muzaffarnagar Airport", "Muzaffarpur – Muzaffarpur Airport", "Mysore – Mandakalli Airport", "Nagpur – Dr. Babasaheb Ambedkar International Airport", "Nanded – Shri Guru Gobind Singh Ji Airport", "Nasik – Ozar Airport and Gandhinagar Airport", "Neyveli – Neyveli Airport", "Information about List of all Airports in India - List of Indian Airports - Names" &
                " of all Airports of India", "Osmanabad – Osmanabad Airport", "Pantnagar – Pantnagar Airport", "Pasighat – Pasighat Airport", "Pathankot – Pathankot Airport", "Patna – Jai Prakash Narayan International Airport", "Pondicherry – Pondicherry Airport", "Porbandar – Porbandar Airport", "Port Blair – Veer Savarkar International Airport", "Pune – Lohegaon Airport", "Puttaparthi – Puttaprathe Airport", "Raipur – Swami Vivekananda Airport", "Rajahmundry – Rajahmundry Airport", "Rajkot – Rajkot Airport", "Rajouri – Rajouri Airport", "Ramagundam – Ramagundam Airport", "Ranchi – Birsa Munda Airport", "Ratnagiri – Ratnagiri Airport", "Rewa – Rewa Airport", "Rourkela – Rourkela Airport", "Rupsi – Rupsi Airport", "Salem – Salem Airport", "Satna – Satna Airport", "Shillong – Umroi Airport", "Sholapur – Solapur Airport", "Silchar – Kumbhirgram Airport", "Simla – Shimla Airport", "Srinagar – Srinagar international Airport", "Surat – Surat Airport", "Tezpur – Salonibari Airport", "Tezu – Tezu Airport", "Thanjavur – Thanjavur Airport", "Thiruvananthapuram – Thiruvananthapuram International Airport", "Tiruchirapally – Tiruchirapalli International Airport", "Tirupati – Tirupati Airport", "Tuticorin – Tuticorin Airport", "Udaipur – Dabok Airport", "Vadodara – Civil Airport Harni", "Varanasi – Lal Bahadur Shastri Airport", "Vijayawada – Gannavaram Airport", "Visakhapatnam – Visakhapatnam Airport", "Warangal – Warangal Airport", "Zero – Ziro Airport"})
        Me.arrival_c.Location = New System.Drawing.Point(662, 131)
        Me.arrival_c.Name = "arrival_c"
        Me.arrival_c.Size = New System.Drawing.Size(528, 35)
        Me.arrival_c.TabIndex = 4
        Me.arrival_c.Text = "To"
        '
        'dtpicker_d
        '
        Me.dtpicker_d.CustomFormat = ""
        Me.dtpicker_d.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker_d.Location = New System.Drawing.Point(57, 218)
        Me.dtpicker_d.Name = "dtpicker_d"
        Me.dtpicker_d.Size = New System.Drawing.Size(532, 35)
        Me.dtpicker_d.TabIndex = 5
        '
        'dtpicker_a
        '
        Me.dtpicker_a.CustomFormat = "Returning"
        Me.dtpicker_a.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker_a.Location = New System.Drawing.Point(662, 218)
        Me.dtpicker_a.Name = "dtpicker_a"
        Me.dtpicker_a.Size = New System.Drawing.Size(528, 35)
        Me.dtpicker_a.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(51, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Departing"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(656, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Returning"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(51, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(439, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Would you Like to avail concession"
        '
        'conrdbtn1
        '
        Me.conrdbtn1.AutoSize = True
        Me.conrdbtn1.BackColor = System.Drawing.Color.Transparent
        Me.conrdbtn1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conrdbtn1.ForeColor = System.Drawing.Color.Red
        Me.conrdbtn1.Location = New System.Drawing.Point(57, 316)
        Me.conrdbtn1.Name = "conrdbtn1"
        Me.conrdbtn1.Size = New System.Drawing.Size(72, 35)
        Me.conrdbtn1.TabIndex = 10
        Me.conrdbtn1.TabStop = True
        Me.conrdbtn1.Text = "Yes"
        Me.conrdbtn1.UseVisualStyleBackColor = False
        '
        'conrdbtn2
        '
        Me.conrdbtn2.AutoSize = True
        Me.conrdbtn2.BackColor = System.Drawing.Color.Transparent
        Me.conrdbtn2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conrdbtn2.ForeColor = System.Drawing.Color.Red
        Me.conrdbtn2.Location = New System.Drawing.Point(174, 316)
        Me.conrdbtn2.Name = "conrdbtn2"
        Me.conrdbtn2.Size = New System.Drawing.Size(66, 35)
        Me.conrdbtn2.TabIndex = 11
        Me.conrdbtn2.TabStop = True
        Me.conrdbtn2.Text = "No"
        Me.conrdbtn2.UseVisualStyleBackColor = False
        '
        'concession_c
        '
        Me.concession_c.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.concession_c.ForeColor = System.Drawing.Color.Tomato
        Me.concession_c.FormattingEnabled = True
        Me.concession_c.Items.AddRange(New Object() {"Student Passenger", "LTC(Leave Travell Concession)", "Senior Citizen", "Armed Forces", "Reverse Engineer", "Para Military Force", "Bravery Awardee", "War Widom", "War Disabled Officer"})
        Me.concession_c.Location = New System.Drawing.Point(57, 357)
        Me.concession_c.Name = "concession_c"
        Me.concession_c.Size = New System.Drawing.Size(532, 35)
        Me.concession_c.TabIndex = 12
        Me.concession_c.Text = "Concession Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(47, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 31)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Adults"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(203, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 31)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Children"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(366, 406)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(294, 31)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Weight of luggage in Kg"
        '
        'adults_c
        '
        Me.adults_c.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adults_c.ForeColor = System.Drawing.Color.Tomato
        Me.adults_c.FormattingEnabled = True
        Me.adults_c.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.adults_c.Location = New System.Drawing.Point(53, 458)
        Me.adults_c.Name = "adults_c"
        Me.adults_c.Size = New System.Drawing.Size(85, 27)
        Me.adults_c.TabIndex = 16
        '
        'Children_c
        '
        Me.Children_c.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Children_c.ForeColor = System.Drawing.Color.Tomato
        Me.Children_c.FormattingEnabled = True
        Me.Children_c.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.Children_c.Location = New System.Drawing.Point(209, 458)
        Me.Children_c.Name = "Children_c"
        Me.Children_c.Size = New System.Drawing.Size(103, 27)
        Me.Children_c.TabIndex = 17
        '
        'store_c
        '
        Me.store_c.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.store_c.ForeColor = System.Drawing.Color.Tomato
        Me.store_c.FormattingEnabled = True
        Me.store_c.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.store_c.Location = New System.Drawing.Point(372, 458)
        Me.store_c.Name = "store_c"
        Me.store_c.Size = New System.Drawing.Size(85, 27)
        Me.store_c.TabIndex = 18
        '
        'class_c
        '
        Me.class_c.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.class_c.ForeColor = System.Drawing.Color.Tomato
        Me.class_c.FormattingEnabled = True
        Me.class_c.Items.AddRange(New Object() {"Economy", "Business", "First", "First/Business", "Economy/Business"})
        Me.class_c.Location = New System.Drawing.Point(52, 522)
        Me.class_c.Name = "class_c"
        Me.class_c.Size = New System.Drawing.Size(533, 35)
        Me.class_c.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(47, 488)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 31)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Class"
        '
        'nextbtn
        '
        Me.nextbtn.BackColor = System.Drawing.Color.White
        Me.nextbtn.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextbtn.ForeColor = System.Drawing.Color.Red
        Me.nextbtn.Location = New System.Drawing.Point(750, 656)
        Me.nextbtn.Name = "nextbtn"
        Me.nextbtn.Size = New System.Drawing.Size(116, 48)
        Me.nextbtn.TabIndex = 21
        Me.nextbtn.Text = "Next"
        Me.nextbtn.UseVisualStyleBackColor = False
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.White
        Me.back_btn.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.Color.Red
        Me.back_btn.Location = New System.Drawing.Point(508, 656)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(116, 48)
        Me.back_btn.TabIndex = 22
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'Bookurflight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Airline_Booking_System.My.Resources.Resources.homepage_flights
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.nextbtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.class_c)
        Me.Controls.Add(Me.store_c)
        Me.Controls.Add(Me.Children_c)
        Me.Controls.Add(Me.adults_c)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.concession_c)
        Me.Controls.Add(Me.conrdbtn2)
        Me.Controls.Add(Me.conrdbtn1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpicker_a)
        Me.Controls.Add(Me.dtpicker_d)
        Me.Controls.Add(Me.arrival_c)
        Me.Controls.Add(Me.destination_c)
        Me.Controls.Add(Me.roundrd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.onebtnrd)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bookurflight"
        Me.Text = "Bookurflight"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents onebtnrd As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents roundrd As RadioButton
    Friend WithEvents destination_c As ComboBox
    Friend WithEvents arrival_c As ComboBox
    Friend WithEvents dtpicker_d As DateTimePicker
    Friend WithEvents dtpicker_a As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents conrdbtn1 As RadioButton
    Friend WithEvents conrdbtn2 As RadioButton
    Friend WithEvents concession_c As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents adults_c As ComboBox
    Friend WithEvents Children_c As ComboBox
    Friend WithEvents store_c As ComboBox
    Friend WithEvents class_c As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents nextbtn As Button
    Friend WithEvents back_btn As Button
End Class
