<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Dim FROMLabel As System.Windows.Forms.Label
        Dim TOLabel As System.Windows.Forms.Label
        Dim DepartingLabel As System.Windows.Forms.Label
        Dim ReturningLabel As System.Windows.Forms.Label
        Dim Concession_TypeLabel As System.Windows.Forms.Label
        Dim AdultsLabel As System.Windows.Forms.Label
        Dim ChildrensLabel As System.Windows.Forms.Label
        Dim InfantsLabel As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim Name_On_CardLabel As System.Windows.Forms.Label
        Dim Card_NumberLabel As System.Windows.Forms.Label
        Dim Expiry_DateLabel As System.Windows.Forms.Label
        Dim CCVLabel As System.Windows.Forms.Label
        Dim E_Mail_IDLabel As System.Windows.Forms.Label
        Me.AirlinedataDataSet = New Airline_Booking_System.AirlinedataDataSet()
        Me.AirlinetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirlinetableTableAdapter = New Airline_Booking_System.AirlinedataDataSetTableAdapters.AirlinetableTableAdapter()
        Me.TableAdapterManager = New Airline_Booking_System.AirlinedataDataSetTableAdapters.TableAdapterManager()
        Me.AirlinetableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AirlinetableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FROMTextBox = New System.Windows.Forms.TextBox()
        Me.TOTextBox = New System.Windows.Forms.TextBox()
        Me.DepartingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReturningDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Concession_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.AdultsTextBox = New System.Windows.Forms.TextBox()
        Me.ChildrensTextBox = New System.Windows.Forms.TextBox()
        Me.InfantsTextBox = New System.Windows.Forms.TextBox()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.Name_On_CardTextBox = New System.Windows.Forms.TextBox()
        Me.Card_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Expiry_DateTextBox = New System.Windows.Forms.TextBox()
        Me.CCVTextBox = New System.Windows.Forms.TextBox()
        Me.E_Mail_IDTextBox = New System.Windows.Forms.TextBox()
        FROMLabel = New System.Windows.Forms.Label()
        TOLabel = New System.Windows.Forms.Label()
        DepartingLabel = New System.Windows.Forms.Label()
        ReturningLabel = New System.Windows.Forms.Label()
        Concession_TypeLabel = New System.Windows.Forms.Label()
        AdultsLabel = New System.Windows.Forms.Label()
        ChildrensLabel = New System.Windows.Forms.Label()
        InfantsLabel = New System.Windows.Forms.Label()
        ClassLabel = New System.Windows.Forms.Label()
        Name_On_CardLabel = New System.Windows.Forms.Label()
        Card_NumberLabel = New System.Windows.Forms.Label()
        Expiry_DateLabel = New System.Windows.Forms.Label()
        CCVLabel = New System.Windows.Forms.Label()
        E_Mail_IDLabel = New System.Windows.Forms.Label()
        CType(Me.AirlinedataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirlinetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirlinetableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AirlinetableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AirlinedataDataSet
        '
        Me.AirlinedataDataSet.DataSetName = "AirlinedataDataSet"
        Me.AirlinedataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AirlinetableBindingSource
        '
        Me.AirlinetableBindingSource.DataMember = "Airlinetable"
        Me.AirlinetableBindingSource.DataSource = Me.AirlinedataDataSet
        '
        'AirlinetableTableAdapter
        '
        Me.AirlinetableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AirlinetableTableAdapter = Me.AirlinetableTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Airline_Booking_System.AirlinedataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AirlinetableBindingNavigator
        '
        Me.AirlinetableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AirlinetableBindingNavigator.BindingSource = Me.AirlinetableBindingSource
        Me.AirlinetableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AirlinetableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AirlinetableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AirlinetableBindingNavigatorSaveItem})
        Me.AirlinetableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AirlinetableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AirlinetableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AirlinetableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AirlinetableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AirlinetableBindingNavigator.Name = "AirlinetableBindingNavigator"
        Me.AirlinetableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AirlinetableBindingNavigator.Size = New System.Drawing.Size(1349, 25)
        Me.AirlinetableBindingNavigator.TabIndex = 0
        Me.AirlinetableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AirlinetableBindingNavigatorSaveItem
        '
        Me.AirlinetableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AirlinetableBindingNavigatorSaveItem.Image = CType(resources.GetObject("AirlinetableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AirlinetableBindingNavigatorSaveItem.Name = "AirlinetableBindingNavigatorSaveItem"
        Me.AirlinetableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AirlinetableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FROMLabel
        '
        FROMLabel.AutoSize = True
        FROMLabel.Location = New System.Drawing.Point(461, 113)
        FROMLabel.Name = "FROMLabel"
        FROMLabel.Size = New System.Drawing.Size(41, 13)
        FROMLabel.TabIndex = 1
        FROMLabel.Text = "FROM:"
        '
        'FROMTextBox
        '
        Me.FROMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "FROM", True))
        Me.FROMTextBox.Location = New System.Drawing.Point(559, 110)
        Me.FROMTextBox.Name = "FROMTextBox"
        Me.FROMTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FROMTextBox.TabIndex = 2
        '
        'TOLabel
        '
        TOLabel.AutoSize = True
        TOLabel.Location = New System.Drawing.Point(461, 139)
        TOLabel.Name = "TOLabel"
        TOLabel.Size = New System.Drawing.Size(25, 13)
        TOLabel.TabIndex = 3
        TOLabel.Text = "TO:"
        '
        'TOTextBox
        '
        Me.TOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "TO", True))
        Me.TOTextBox.Location = New System.Drawing.Point(559, 136)
        Me.TOTextBox.Name = "TOTextBox"
        Me.TOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TOTextBox.TabIndex = 4
        '
        'DepartingLabel
        '
        DepartingLabel.AutoSize = True
        DepartingLabel.Location = New System.Drawing.Point(461, 166)
        DepartingLabel.Name = "DepartingLabel"
        DepartingLabel.Size = New System.Drawing.Size(56, 13)
        DepartingLabel.TabIndex = 5
        DepartingLabel.Text = "Departing:"
        '
        'DepartingDateTimePicker
        '
        Me.DepartingDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AirlinetableBindingSource, "Departing", True))
        Me.DepartingDateTimePicker.Location = New System.Drawing.Point(559, 162)
        Me.DepartingDateTimePicker.Name = "DepartingDateTimePicker"
        Me.DepartingDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DepartingDateTimePicker.TabIndex = 6
        '
        'ReturningLabel
        '
        ReturningLabel.AutoSize = True
        ReturningLabel.Location = New System.Drawing.Point(461, 192)
        ReturningLabel.Name = "ReturningLabel"
        ReturningLabel.Size = New System.Drawing.Size(56, 13)
        ReturningLabel.TabIndex = 7
        ReturningLabel.Text = "Returning:"
        '
        'ReturningDateTimePicker
        '
        Me.ReturningDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AirlinetableBindingSource, "Returning", True))
        Me.ReturningDateTimePicker.Location = New System.Drawing.Point(559, 188)
        Me.ReturningDateTimePicker.Name = "ReturningDateTimePicker"
        Me.ReturningDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ReturningDateTimePicker.TabIndex = 8
        '
        'Concession_TypeLabel
        '
        Concession_TypeLabel.AutoSize = True
        Concession_TypeLabel.Location = New System.Drawing.Point(461, 217)
        Concession_TypeLabel.Name = "Concession_TypeLabel"
        Concession_TypeLabel.Size = New System.Drawing.Size(92, 13)
        Concession_TypeLabel.TabIndex = 9
        Concession_TypeLabel.Text = "Concession Type:"
        '
        'Concession_TypeTextBox
        '
        Me.Concession_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "Concession Type", True))
        Me.Concession_TypeTextBox.Location = New System.Drawing.Point(559, 214)
        Me.Concession_TypeTextBox.Name = "Concession_TypeTextBox"
        Me.Concession_TypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Concession_TypeTextBox.TabIndex = 10
        '
        'AdultsLabel
        '
        AdultsLabel.AutoSize = True
        AdultsLabel.Location = New System.Drawing.Point(461, 243)
        AdultsLabel.Name = "AdultsLabel"
        AdultsLabel.Size = New System.Drawing.Size(39, 13)
        AdultsLabel.TabIndex = 11
        AdultsLabel.Text = "Adults:"
        '
        'AdultsTextBox
        '
        Me.AdultsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "Adults", True))
        Me.AdultsTextBox.Location = New System.Drawing.Point(559, 240)
        Me.AdultsTextBox.Name = "AdultsTextBox"
        Me.AdultsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AdultsTextBox.TabIndex = 12
        '
        'ChildrensLabel
        '
        ChildrensLabel.AutoSize = True
        ChildrensLabel.Location = New System.Drawing.Point(461, 269)
        ChildrensLabel.Name = "ChildrensLabel"
        ChildrensLabel.Size = New System.Drawing.Size(53, 13)
        ChildrensLabel.TabIndex = 13
        ChildrensLabel.Text = "Childrens:"
        '
        'ChildrensTextBox
        '
        Me.ChildrensTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "Childrens", True))
        Me.ChildrensTextBox.Location = New System.Drawing.Point(559, 266)
        Me.ChildrensTextBox.Name = "ChildrensTextBox"
        Me.ChildrensTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ChildrensTextBox.TabIndex = 14
        '
        'InfantsLabel
        '
        InfantsLabel.AutoSize = True
        InfantsLabel.Location = New System.Drawing.Point(461, 295)
        InfantsLabel.Name = "InfantsLabel"
        InfantsLabel.Size = New System.Drawing.Size(42, 13)
        InfantsLabel.TabIndex = 15
        InfantsLabel.Text = "Infants:"
        '
        'InfantsTextBox
        '
        Me.InfantsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "Infants", True))
        Me.InfantsTextBox.Location = New System.Drawing.Point(559, 292)
        Me.InfantsTextBox.Name = "InfantsTextBox"
        Me.InfantsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.InfantsTextBox.TabIndex = 16
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.Location = New System.Drawing.Point(461, 321)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(35, 13)
        ClassLabel.TabIndex = 17
        ClassLabel.Text = "Class:"
        '
        'ClassTextBox
        '
        Me.ClassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "Class", True))
        Me.ClassTextBox.Location = New System.Drawing.Point(559, 318)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ClassTextBox.TabIndex = 18
        '
        'Name_On_CardLabel
        '
        Name_On_CardLabel.AutoSize = True
        Name_On_CardLabel.Location = New System.Drawing.Point(461, 347)
        Name_On_CardLabel.Name = "Name_On_CardLabel"
        Name_On_CardLabel.Size = New System.Drawing.Size(80, 13)
        Name_On_CardLabel.TabIndex = 19
        Name_On_CardLabel.Text = "Name On Card:"
        '
        'Name_On_CardTextBox
        '
        Me.Name_On_CardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "Name On Card", True))
        Me.Name_On_CardTextBox.Location = New System.Drawing.Point(559, 344)
        Me.Name_On_CardTextBox.Name = "Name_On_CardTextBox"
        Me.Name_On_CardTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Name_On_CardTextBox.TabIndex = 20
        '
        'Card_NumberLabel
        '
        Card_NumberLabel.AutoSize = True
        Card_NumberLabel.Location = New System.Drawing.Point(461, 373)
        Card_NumberLabel.Name = "Card_NumberLabel"
        Card_NumberLabel.Size = New System.Drawing.Size(72, 13)
        Card_NumberLabel.TabIndex = 21
        Card_NumberLabel.Text = "Card Number:"
        '
        'Card_NumberTextBox
        '
        Me.Card_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "Card Number", True))
        Me.Card_NumberTextBox.Location = New System.Drawing.Point(559, 370)
        Me.Card_NumberTextBox.Name = "Card_NumberTextBox"
        Me.Card_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Card_NumberTextBox.TabIndex = 22
        '
        'Expiry_DateLabel
        '
        Expiry_DateLabel.AutoSize = True
        Expiry_DateLabel.Location = New System.Drawing.Point(461, 399)
        Expiry_DateLabel.Name = "Expiry_DateLabel"
        Expiry_DateLabel.Size = New System.Drawing.Size(64, 13)
        Expiry_DateLabel.TabIndex = 23
        Expiry_DateLabel.Text = "Expiry Date:"
        '
        'Expiry_DateTextBox
        '
        Me.Expiry_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "Expiry Date", True))
        Me.Expiry_DateTextBox.Location = New System.Drawing.Point(559, 396)
        Me.Expiry_DateTextBox.Name = "Expiry_DateTextBox"
        Me.Expiry_DateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Expiry_DateTextBox.TabIndex = 24
        '
        'CCVLabel
        '
        CCVLabel.AutoSize = True
        CCVLabel.Location = New System.Drawing.Point(461, 425)
        CCVLabel.Name = "CCVLabel"
        CCVLabel.Size = New System.Drawing.Size(31, 13)
        CCVLabel.TabIndex = 25
        CCVLabel.Text = "CCV:"
        '
        'CCVTextBox
        '
        Me.CCVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "CCV", True))
        Me.CCVTextBox.Location = New System.Drawing.Point(559, 422)
        Me.CCVTextBox.Name = "CCVTextBox"
        Me.CCVTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CCVTextBox.TabIndex = 26
        '
        'E_Mail_IDLabel
        '
        E_Mail_IDLabel.AutoSize = True
        E_Mail_IDLabel.Location = New System.Drawing.Point(461, 451)
        E_Mail_IDLabel.Name = "E_Mail_IDLabel"
        E_Mail_IDLabel.Size = New System.Drawing.Size(53, 13)
        E_Mail_IDLabel.TabIndex = 27
        E_Mail_IDLabel.Text = "E-Mail ID:"
        '
        'E_Mail_IDTextBox
        '
        Me.E_Mail_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirlinetableBindingSource, "E-Mail ID", True))
        Me.E_Mail_IDTextBox.Location = New System.Drawing.Point(559, 448)
        Me.E_Mail_IDTextBox.Name = "E_Mail_IDTextBox"
        Me.E_Mail_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.E_Mail_IDTextBox.TabIndex = 28
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 745)
        Me.Controls.Add(FROMLabel)
        Me.Controls.Add(Me.FROMTextBox)
        Me.Controls.Add(TOLabel)
        Me.Controls.Add(Me.TOTextBox)
        Me.Controls.Add(DepartingLabel)
        Me.Controls.Add(Me.DepartingDateTimePicker)
        Me.Controls.Add(ReturningLabel)
        Me.Controls.Add(Me.ReturningDateTimePicker)
        Me.Controls.Add(Concession_TypeLabel)
        Me.Controls.Add(Me.Concession_TypeTextBox)
        Me.Controls.Add(AdultsLabel)
        Me.Controls.Add(Me.AdultsTextBox)
        Me.Controls.Add(ChildrensLabel)
        Me.Controls.Add(Me.ChildrensTextBox)
        Me.Controls.Add(InfantsLabel)
        Me.Controls.Add(Me.InfantsTextBox)
        Me.Controls.Add(ClassLabel)
        Me.Controls.Add(Me.ClassTextBox)
        Me.Controls.Add(Name_On_CardLabel)
        Me.Controls.Add(Me.Name_On_CardTextBox)
        Me.Controls.Add(Card_NumberLabel)
        Me.Controls.Add(Me.Card_NumberTextBox)
        Me.Controls.Add(Expiry_DateLabel)
        Me.Controls.Add(Me.Expiry_DateTextBox)
        Me.Controls.Add(CCVLabel)
        Me.Controls.Add(Me.CCVTextBox)
        Me.Controls.Add(E_Mail_IDLabel)
        Me.Controls.Add(Me.E_Mail_IDTextBox)
        Me.Controls.Add(Me.AirlinetableBindingNavigator)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.AirlinedataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirlinetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirlinetableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AirlinetableBindingNavigator.ResumeLayout(False)
        Me.AirlinetableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AirlinedataDataSet As AirlinedataDataSet
    Friend WithEvents AirlinetableBindingSource As BindingSource
    Friend WithEvents AirlinetableTableAdapter As AirlinedataDataSetTableAdapters.AirlinetableTableAdapter
    Friend WithEvents TableAdapterManager As AirlinedataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AirlinetableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AirlinetableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FROMTextBox As TextBox
    Friend WithEvents TOTextBox As TextBox
    Friend WithEvents DepartingDateTimePicker As DateTimePicker
    Friend WithEvents ReturningDateTimePicker As DateTimePicker
    Friend WithEvents Concession_TypeTextBox As TextBox
    Friend WithEvents AdultsTextBox As TextBox
    Friend WithEvents ChildrensTextBox As TextBox
    Friend WithEvents InfantsTextBox As TextBox
    Friend WithEvents ClassTextBox As TextBox
    Friend WithEvents Name_On_CardTextBox As TextBox
    Friend WithEvents Card_NumberTextBox As TextBox
    Friend WithEvents Expiry_DateTextBox As TextBox
    Friend WithEvents CCVTextBox As TextBox
    Friend WithEvents E_Mail_IDTextBox As TextBox
End Class
