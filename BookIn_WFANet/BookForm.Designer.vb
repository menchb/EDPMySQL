<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookForm
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
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.PublicationYearTextBox = New System.Windows.Forms.TextBox()
        Me.PublicationYearLabel = New System.Windows.Forms.Label()
        Me.StocksTextBox = New System.Windows.Forms.TextBox()
        Me.StocksLabel = New System.Windows.Forms.Label()
        Me.RetailPriceTextBox = New System.Windows.Forms.TextBox()
        Me.RetailPriceLabel = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherLabel = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Publication_Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Retail_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Publisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ISBNLabel.Location = New System.Drawing.Point(59, 76)
        Me.ISBNLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(35, 17)
        Me.ISBNLabel.TabIndex = 2
        Me.ISBNLabel.Text = "ISBN"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ISBNTextBox.Location = New System.Drawing.Point(63, 96)
        Me.ISBNTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(184, 23)
        Me.ISBNTextBox.TabIndex = 3
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TitleTextBox.Location = New System.Drawing.Point(63, 162)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(184, 23)
        Me.TitleTextBox.TabIndex = 5
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TitleLabel.Location = New System.Drawing.Point(59, 143)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(33, 17)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "Title"
        '
        'PublicationYearTextBox
        '
        Me.PublicationYearTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicationYearTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PublicationYearTextBox.Location = New System.Drawing.Point(63, 239)
        Me.PublicationYearTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PublicationYearTextBox.Name = "PublicationYearTextBox"
        Me.PublicationYearTextBox.Size = New System.Drawing.Size(184, 23)
        Me.PublicationYearTextBox.TabIndex = 7
        '
        'PublicationYearLabel
        '
        Me.PublicationYearLabel.AutoSize = True
        Me.PublicationYearLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicationYearLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PublicationYearLabel.Location = New System.Drawing.Point(59, 219)
        Me.PublicationYearLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PublicationYearLabel.Name = "PublicationYearLabel"
        Me.PublicationYearLabel.Size = New System.Drawing.Size(98, 17)
        Me.PublicationYearLabel.TabIndex = 6
        Me.PublicationYearLabel.Text = "Publication Year"
        '
        'StocksTextBox
        '
        Me.StocksTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StocksTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.StocksTextBox.Location = New System.Drawing.Point(63, 306)
        Me.StocksTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StocksTextBox.Name = "StocksTextBox"
        Me.StocksTextBox.Size = New System.Drawing.Size(184, 23)
        Me.StocksTextBox.TabIndex = 9
        '
        'StocksLabel
        '
        Me.StocksLabel.AutoSize = True
        Me.StocksLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StocksLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.StocksLabel.Location = New System.Drawing.Point(59, 287)
        Me.StocksLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StocksLabel.Name = "StocksLabel"
        Me.StocksLabel.Size = New System.Drawing.Size(43, 17)
        Me.StocksLabel.TabIndex = 8
        Me.StocksLabel.Text = "Stocks"
        '
        'RetailPriceTextBox
        '
        Me.RetailPriceTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailPriceTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RetailPriceTextBox.Location = New System.Drawing.Point(63, 383)
        Me.RetailPriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RetailPriceTextBox.Name = "RetailPriceTextBox"
        Me.RetailPriceTextBox.Size = New System.Drawing.Size(184, 23)
        Me.RetailPriceTextBox.TabIndex = 11
        '
        'RetailPriceLabel
        '
        Me.RetailPriceLabel.AutoSize = True
        Me.RetailPriceLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailPriceLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RetailPriceLabel.Location = New System.Drawing.Point(59, 363)
        Me.RetailPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RetailPriceLabel.Name = "RetailPriceLabel"
        Me.RetailPriceLabel.Size = New System.Drawing.Size(72, 17)
        Me.RetailPriceLabel.TabIndex = 10
        Me.RetailPriceLabel.Text = "Retail Price"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.AuthorTextBox.Location = New System.Drawing.Point(285, 97)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(184, 23)
        Me.AuthorTextBox.TabIndex = 13
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.AuthorLabel.Location = New System.Drawing.Point(282, 76)
        Me.AuthorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(47, 17)
        Me.AuthorLabel.TabIndex = 12
        Me.AuthorLabel.Text = "Author"
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PublisherTextBox.Location = New System.Drawing.Point(285, 163)
        Me.PublisherTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(184, 23)
        Me.PublisherTextBox.TabIndex = 15
        '
        'PublisherLabel
        '
        Me.PublisherLabel.AutoSize = True
        Me.PublisherLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PublisherLabel.Location = New System.Drawing.Point(282, 143)
        Me.PublisherLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PublisherLabel.Name = "PublisherLabel"
        Me.PublisherLabel.Size = New System.Drawing.Size(59, 17)
        Me.PublisherLabel.TabIndex = 14
        Me.PublisherLabel.Text = "Publisher"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBack.Location = New System.Drawing.Point(58, 474)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 47)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnDelete.Location = New System.Drawing.Point(208, 474)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 47)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnUpdate.Location = New System.Drawing.Point(301, 474)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(85, 47)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnAdd.Location = New System.Drawing.Point(394, 474)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 47)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBN, Me.Title, Me.Publication_Year, Me.Stocks, Me.Retail_Price, Me.Author, Me.Publisher})
        Me.DataGridView1.Location = New System.Drawing.Point(508, -2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(579, 559)
        Me.DataGridView1.TabIndex = 46
        '
        'ISBN
        '
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.MinimumWidth = 6
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Width = 80
        '
        'Title
        '
        Me.Title.HeaderText = "Title"
        Me.Title.MinimumWidth = 6
        Me.Title.Name = "Title"
        Me.Title.Width = 80
        '
        'Publication_Year
        '
        Me.Publication_Year.HeaderText = "Publication Year"
        Me.Publication_Year.MinimumWidth = 6
        Me.Publication_Year.Name = "Publication_Year"
        Me.Publication_Year.Width = 50
        '
        'Stocks
        '
        Me.Stocks.HeaderText = "Stocks"
        Me.Stocks.MinimumWidth = 6
        Me.Stocks.Name = "Stocks"
        Me.Stocks.Width = 50
        '
        'Retail_Price
        '
        Me.Retail_Price.HeaderText = "Retail Price"
        Me.Retail_Price.MinimumWidth = 6
        Me.Retail_Price.Name = "Retail_Price"
        Me.Retail_Price.Width = 50
        '
        'Author
        '
        Me.Author.HeaderText = "Author"
        Me.Author.MinimumWidth = 6
        Me.Author.Name = "Author"
        Me.Author.Width = 125
        '
        'Publisher
        '
        Me.Publisher.HeaderText = "Publisher"
        Me.Publisher.MinimumWidth = 6
        Me.Publisher.Name = "Publisher"
        Me.Publisher.Width = 125
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1086, 554)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.PublisherTextBox)
        Me.Controls.Add(Me.PublisherLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.RetailPriceTextBox)
        Me.Controls.Add(Me.RetailPriceLabel)
        Me.Controls.Add(Me.StocksTextBox)
        Me.Controls.Add(Me.StocksLabel)
        Me.Controls.Add(Me.PublicationYearTextBox)
        Me.Controls.Add(Me.PublicationYearLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(Me.ISBNLabel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BookForm"
        Me.Text = "Book"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents PublicationYearTextBox As TextBox
    Friend WithEvents PublicationYearLabel As Label
    Friend WithEvents StocksTextBox As TextBox
    Friend WithEvents StocksLabel As Label
    Friend WithEvents RetailPriceTextBox As TextBox
    Friend WithEvents RetailPriceLabel As Label
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents PublisherTextBox As TextBox
    Friend WithEvents PublisherLabel As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Publication_Year As DataGridViewTextBoxColumn
    Friend WithEvents Stocks As DataGridViewTextBoxColumn
    Friend WithEvents Retail_Price As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents Publisher As DataGridViewTextBoxColumn
End Class
