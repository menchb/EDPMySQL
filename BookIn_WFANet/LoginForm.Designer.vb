<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.UsernameTextBox.Location = New System.Drawing.Point(416, 190)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(229, 23)
        Me.UsernameTextBox.TabIndex = 0
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.UsernameLabel.Location = New System.Drawing.Point(425, 170)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(69, 17)
        Me.UsernameLabel.TabIndex = 1
        Me.UsernameLabel.Text = "&User name"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PasswordTextBox.Location = New System.Drawing.Point(416, 257)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(229, 23)
        Me.PasswordTextBox.TabIndex = 3
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PasswordLabel.Location = New System.Drawing.Point(425, 238)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(61, 17)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "&Password"
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.Window
        Me.OK.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.OK.Location = New System.Drawing.Point(412, 361)
        Me.OK.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(112, 38)
        Me.OK.TabIndex = 5
        Me.OK.Text = "&OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.Window
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Cancel.Location = New System.Drawing.Point(531, 361)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(112, 38)
        Me.Cancel.TabIndex = 6
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1086, 554)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button
End Class
