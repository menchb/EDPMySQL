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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.ISBNTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(220, 23)
        Me.ISBNTextBox.TabIndex = 3
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TitleTextBox.Location = New System.Drawing.Point(63, 162)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(220, 23)
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
        Me.PublicationYearTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PublicationYearTextBox.Name = "PublicationYearTextBox"
        Me.PublicationYearTextBox.Size = New System.Drawing.Size(220, 23)
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
        Me.StocksTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StocksTextBox.Name = "StocksTextBox"
        Me.StocksTextBox.Size = New System.Drawing.Size(220, 23)
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
        Me.RetailPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RetailPriceTextBox.Name = "RetailPriceTextBox"
        Me.RetailPriceTextBox.Size = New System.Drawing.Size(220, 23)
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
        Me.AuthorTextBox.Location = New System.Drawing.Point(379, 96)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(220, 23)
        Me.AuthorTextBox.TabIndex = 13
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.AuthorLabel.Location = New System.Drawing.Point(375, 76)
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
        Me.PublisherTextBox.Location = New System.Drawing.Point(379, 162)
        Me.PublisherTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(220, 23)
        Me.PublisherTextBox.TabIndex = 15
        '
        'PublisherLabel
        '
        Me.PublisherLabel.AutoSize = True
        Me.PublisherLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PublisherLabel.Location = New System.Drawing.Point(375, 143)
        Me.PublisherLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PublisherLabel.Name = "PublisherLabel"
        Me.PublisherLabel.Size = New System.Drawing.Size(59, 17)
        Me.PublisherLabel.TabIndex = 14
        Me.PublisherLabel.Text = "Publisher"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnAdd.Location = New System.Drawing.Point(515, 442)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(0, 0)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnUpdate.Location = New System.Drawing.Point(421, 442)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(0, 0)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnDelete.Location = New System.Drawing.Point(328, 442)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(0, 0)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBack.Location = New System.Drawing.Point(63, 442)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(0, 0)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Location = New System.Drawing.Point(58, 474)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 47)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.Location = New System.Drawing.Point(396, 474)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 47)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.Location = New System.Drawing.Point(489, 474)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 47)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.Location = New System.Drawing.Point(582, 474)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 47)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(724, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BookForm"
        Me.Text = "Book"
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
