<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SubtitleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.SystemColors.Window
        Me.btnBook.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBook.Location = New System.Drawing.Point(71, 384)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(121, 62)
        Me.btnBook.TabIndex = 0
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.SystemColors.Window
        Me.btnCustomer.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnCustomer.Location = New System.Drawing.Point(377, 384)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(121, 62)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.SystemColors.Window
        Me.btnAdmin.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnAdmin.Location = New System.Drawing.Point(529, 384)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(121, 62)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.SystemColors.Window
        Me.btnOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnOrder.Location = New System.Drawing.Point(224, 384)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(121, 62)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Book Antiqua", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TitleLabel.Location = New System.Drawing.Point(131, 140)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(474, 148)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "Book In"
        '
        'SubtitleLabel
        '
        Me.SubtitleLabel.AutoSize = True
        Me.SubtitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.SubtitleLabel.Font = New System.Drawing.Font("Book Antiqua", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtitleLabel.ForeColor = System.Drawing.Color.Teal
        Me.SubtitleLabel.Location = New System.Drawing.Point(169, 261)
        Me.SubtitleLabel.Name = "SubtitleLabel"
        Me.SubtitleLabel.Size = New System.Drawing.Size(151, 18)
        Me.SubtitleLabel.TabIndex = 5
        Me.SubtitleLabel.Text = "By Menchie Belarmino"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(724, 554)
        Me.Controls.Add(Me.SubtitleLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnBook)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomeForm"
        Me.Text = "Home - Book In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBook As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents SubtitleLabel As Label
End Class
