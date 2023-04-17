<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookForm
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
        Me.dgBook = New System.Windows.Forms.DataGridView()
        Me.btnImportBook = New System.Windows.Forms.Button()
        Me.btnExportBook = New System.Windows.Forms.Button()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUBLICATIONYEARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETAILPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCKSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHORIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUBLISHERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnReload = New System.Windows.Forms.Button()
        CType(Me.dgBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgBook
        '
        Me.dgBook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgBook.AutoGenerateColumns = False
        Me.dgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.PUBLICATIONYEARDataGridViewTextBoxColumn, Me.RETAILPRICEDataGridViewTextBoxColumn, Me.STOCKSDataGridViewTextBoxColumn, Me.AUTHORIDDataGridViewTextBoxColumn, Me.PUBLISHERIDDataGridViewTextBoxColumn})
        Me.dgBook.DataSource = Me.BookBindingSource
        Me.dgBook.Location = New System.Drawing.Point(508, -2)
        Me.dgBook.Name = "dgBook"
        Me.dgBook.RowHeadersWidth = 51
        Me.dgBook.RowTemplate.Height = 24
        Me.dgBook.Size = New System.Drawing.Size(579, 734)
        Me.dgBook.TabIndex = 46
        '
        'btnImportBook
        '
        Me.btnImportBook.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportBook.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnImportBook.Location = New System.Drawing.Point(394, 624)
        Me.btnImportBook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImportBook.Name = "btnImportBook"
        Me.btnImportBook.Size = New System.Drawing.Size(85, 47)
        Me.btnImportBook.TabIndex = 47
        Me.btnImportBook.Text = "Import"
        Me.btnImportBook.UseVisualStyleBackColor = True
        '
        'btnExportBook
        '
        Me.btnExportBook.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportBook.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnExportBook.Location = New System.Drawing.Point(301, 624)
        Me.btnExportBook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportBook.Name = "btnExportBook"
        Me.btnExportBook.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExportBook.Size = New System.Drawing.Size(85, 47)
        Me.btnExportBook.TabIndex = 48
        Me.btnExportBook.Text = "Export"
        Me.btnExportBook.UseVisualStyleBackColor = True
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.Width = 68
        '
        'TITLEDataGridViewTextBoxColumn
        '
        Me.TITLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.HeaderText = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TITLEDataGridViewTextBoxColumn.Name = "TITLEDataGridViewTextBoxColumn"
        Me.TITLEDataGridViewTextBoxColumn.Width = 75
        '
        'PUBLICATIONYEARDataGridViewTextBoxColumn
        '
        Me.PUBLICATIONYEARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PUBLICATIONYEARDataGridViewTextBoxColumn.DataPropertyName = "PUBLICATION_YEAR"
        Me.PUBLICATIONYEARDataGridViewTextBoxColumn.HeaderText = "PUBLICATION_YEAR"
        Me.PUBLICATIONYEARDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PUBLICATIONYEARDataGridViewTextBoxColumn.Name = "PUBLICATIONYEARDataGridViewTextBoxColumn"
        Me.PUBLICATIONYEARDataGridViewTextBoxColumn.Width = 172
        '
        'RETAILPRICEDataGridViewTextBoxColumn
        '
        Me.RETAILPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RETAILPRICEDataGridViewTextBoxColumn.DataPropertyName = "RETAIL_PRICE"
        Me.RETAILPRICEDataGridViewTextBoxColumn.HeaderText = "RETAIL_PRICE"
        Me.RETAILPRICEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RETAILPRICEDataGridViewTextBoxColumn.Name = "RETAILPRICEDataGridViewTextBoxColumn"
        Me.RETAILPRICEDataGridViewTextBoxColumn.Width = 133
        '
        'STOCKSDataGridViewTextBoxColumn
        '
        Me.STOCKSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STOCKSDataGridViewTextBoxColumn.DataPropertyName = "STOCKS"
        Me.STOCKSDataGridViewTextBoxColumn.HeaderText = "STOCKS"
        Me.STOCKSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STOCKSDataGridViewTextBoxColumn.Name = "STOCKSDataGridViewTextBoxColumn"
        Me.STOCKSDataGridViewTextBoxColumn.Width = 93
        '
        'AUTHORIDDataGridViewTextBoxColumn
        '
        Me.AUTHORIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AUTHORIDDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR_ID"
        Me.AUTHORIDDataGridViewTextBoxColumn.HeaderText = "AUTHOR_ID"
        Me.AUTHORIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AUTHORIDDataGridViewTextBoxColumn.Name = "AUTHORIDDataGridViewTextBoxColumn"
        Me.AUTHORIDDataGridViewTextBoxColumn.Width = 117
        '
        'PUBLISHERIDDataGridViewTextBoxColumn
        '
        Me.PUBLISHERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PUBLISHERIDDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHER_ID"
        Me.PUBLISHERIDDataGridViewTextBoxColumn.HeaderText = "PUBLISHER_ID"
        Me.PUBLISHERIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PUBLISHERIDDataGridViewTextBoxColumn.Name = "PUBLISHERIDDataGridViewTextBoxColumn"
        Me.PUBLISHERIDDataGridViewTextBoxColumn.Width = 135
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataSource = GetType(BookIn_WFANet.Book)
        '
        'btnReload
        '
        Me.btnReload.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnReload.Location = New System.Drawing.Point(208, 624)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReload.Size = New System.Drawing.Size(85, 47)
        Me.btnReload.TabIndex = 49
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1086, 729)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.dgBook)
        Me.Controls.Add(Me.btnExportBook)
        Me.Controls.Add(Me.btnImportBook)
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
        CType(Me.dgBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgBook As DataGridView
    Friend WithEvents btnImportBook As Button
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents btnExportBook As Button
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PUBLICATIONYEARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RETAILPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STOCKSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AUTHORIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PUBLISHERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnReload As Button
End Class
