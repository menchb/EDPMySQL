<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerForm
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
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinceLabel = New System.Windows.Forms.Label()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.ZIPLabel = New System.Windows.Forms.Label()
        Me.ZIPTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Province = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(58, 84)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(184, 23)
        Me.IDTextBox.TabIndex = 0
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel.Location = New System.Drawing.Point(58, 65)
        Me.IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(21, 17)
        Me.IDLabel.TabIndex = 1
        Me.IDLabel.Text = "ID"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.Location = New System.Drawing.Point(58, 124)
        Me.FirstNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(69, 17)
        Me.FirstNameLabel.TabIndex = 3
        Me.FirstNameLabel.Text = "First Name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(58, 144)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(184, 23)
        Me.FirstNameTextBox.TabIndex = 2
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.Location = New System.Drawing.Point(58, 186)
        Me.LastNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(68, 17)
        Me.LastNameLabel.TabIndex = 5
        Me.LastNameLabel.Text = "Last Name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(58, 203)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(184, 23)
        Me.LastNameTextBox.TabIndex = 4
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.Location = New System.Drawing.Point(58, 244)
        Me.CityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(29, 17)
        Me.CityLabel.TabIndex = 7
        Me.CityLabel.Text = "City"
        '
        'CityTextBox
        '
        Me.CityTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(58, 261)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(184, 23)
        Me.CityTextBox.TabIndex = 6
        '
        'ProvinceLabel
        '
        Me.ProvinceLabel.AutoSize = True
        Me.ProvinceLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceLabel.Location = New System.Drawing.Point(58, 300)
        Me.ProvinceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProvinceLabel.Name = "ProvinceLabel"
        Me.ProvinceLabel.Size = New System.Drawing.Size(56, 17)
        Me.ProvinceLabel.TabIndex = 9
        Me.ProvinceLabel.Text = "Province"
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(58, 319)
        Me.ProvinceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(184, 23)
        Me.ProvinceTextBox.TabIndex = 8
        '
        'ZIPLabel
        '
        Me.ZIPLabel.AutoSize = True
        Me.ZIPLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPLabel.Location = New System.Drawing.Point(58, 369)
        Me.ZIPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ZIPLabel.Name = "ZIPLabel"
        Me.ZIPLabel.Size = New System.Drawing.Size(26, 17)
        Me.ZIPLabel.TabIndex = 11
        Me.ZIPLabel.Text = "ZIP"
        '
        'ZIPTextBox
        '
        Me.ZIPTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPTextBox.Location = New System.Drawing.Point(58, 389)
        Me.ZIPTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ZIPTextBox.Name = "ZIPTextBox"
        Me.ZIPTextBox.Size = New System.Drawing.Size(184, 23)
        Me.ZIPTextBox.TabIndex = 10
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneLabel.Location = New System.Drawing.Point(288, 65)
        Me.PhoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(43, 17)
        Me.PhoneLabel.TabIndex = 13
        Me.PhoneLabel.Text = "Phone"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(287, 84)
        Me.PhoneTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(169, 23)
        Me.PhoneTextBox.TabIndex = 12
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(287, 128)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(39, 17)
        Me.EmailLabel.TabIndex = 15
        Me.EmailLabel.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(287, 144)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(169, 23)
        Me.EmailTextBox.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(208, 474)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 47)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(301, 474)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(85, 47)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(394, 474)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 47)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(58, 474)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 47)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.First_Name, Me.Last_Name, Me.City, Me.Province, Me.ZIP, Me.Phone, Me.Email})
        Me.DataGridView1.Location = New System.Drawing.Point(508, -2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(579, 559)
        Me.DataGridView1.TabIndex = 45
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.Width = 20
        '
        'First_Name
        '
        Me.First_Name.HeaderText = "First Name"
        Me.First_Name.MinimumWidth = 6
        Me.First_Name.Name = "First_Name"
        Me.First_Name.Width = 80
        '
        'Last_Name
        '
        Me.Last_Name.HeaderText = "Last Name"
        Me.Last_Name.MinimumWidth = 6
        Me.Last_Name.Name = "Last_Name"
        Me.Last_Name.Width = 80
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.MinimumWidth = 6
        Me.City.Name = "City"
        Me.City.Width = 80
        '
        'Province
        '
        Me.Province.HeaderText = "Province"
        Me.Province.MinimumWidth = 6
        Me.Province.Name = "Province"
        Me.Province.Width = 80
        '
        'ZIP
        '
        Me.ZIP.HeaderText = "ZIP"
        Me.ZIP.MinimumWidth = 6
        Me.ZIP.Name = "ZIP"
        Me.ZIP.Width = 40
        '
        'Phone
        '
        Me.Phone.HeaderText = "Phone"
        Me.Phone.MinimumWidth = 6
        Me.Phone.Name = "Phone"
        Me.Phone.Width = 70
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.MinimumWidth = 6
        Me.Email.Name = "Email"
        Me.Email.Width = 80
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1086, 554)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.ZIPLabel)
        Me.Controls.Add(Me.ZIPTextBox)
        Me.Controls.Add(Me.ProvinceLabel)
        Me.Controls.Add(Me.ProvinceTextBox)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerForm"
        Me.Text = "Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents ProvinceLabel As Label
    Friend WithEvents ProvinceTextBox As TextBox
    Friend WithEvents ZIPLabel As Label
    Friend WithEvents ZIPTextBox As TextBox
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents First_Name As DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn
    Friend WithEvents Province As DataGridViewTextBoxColumn
    Friend WithEvents ZIP As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
End Class
