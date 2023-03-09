<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderForm
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.OrderIDLabel = New System.Windows.Forms.Label()
        Me.CustomerIDLabel = New System.Windows.Forms.Label()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.OrderFilledLabel = New System.Windows.Forms.Label()
        Me.OrderFilledTextBox = New System.Windows.Forms.TextBox()
        Me.OrderLineIDLabel = New System.Windows.Forms.Label()
        Me.OrderLineIDTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.CostEach = New System.Windows.Forms.Label()
        Me.CostEachTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.btnDeleteOrderLine = New System.Windows.Forms.Button()
        Me.btnUpdateOrderLine = New System.Windows.Forms.Button()
        Me.btnAddOrderLine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(59, 474)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 47)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrder.Location = New System.Drawing.Point(416, 335)
        Me.btnDeleteOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(185, 47)
        Me.btnDeleteOrder.TabIndex = 25
        Me.btnDeleteOrder.Text = "Delete Order"
        Me.btnDeleteOrder.UseVisualStyleBackColor = True
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateOrder.Location = New System.Drawing.Point(416, 280)
        Me.btnUpdateOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(185, 47)
        Me.btnUpdateOrder.TabIndex = 24
        Me.btnUpdateOrder.Text = "Update Order"
        Me.btnUpdateOrder.UseVisualStyleBackColor = True
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.Location = New System.Drawing.Point(416, 225)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(185, 47)
        Me.btnAddOrder.TabIndex = 23
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDTextBox.Location = New System.Drawing.Point(59, 60)
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.Size = New System.Drawing.Size(167, 23)
        Me.OrderIDTextBox.TabIndex = 27
        '
        'OrderIDLabel
        '
        Me.OrderIDLabel.AutoSize = True
        Me.OrderIDLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDLabel.Location = New System.Drawing.Point(55, 40)
        Me.OrderIDLabel.Name = "OrderIDLabel"
        Me.OrderIDLabel.Size = New System.Drawing.Size(57, 17)
        Me.OrderIDLabel.TabIndex = 28
        Me.OrderIDLabel.Text = "Order ID"
        '
        'CustomerIDLabel
        '
        Me.CustomerIDLabel.AutoSize = True
        Me.CustomerIDLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDLabel.Location = New System.Drawing.Point(55, 95)
        Me.CustomerIDLabel.Name = "CustomerIDLabel"
        Me.CustomerIDLabel.Size = New System.Drawing.Size(78, 17)
        Me.CustomerIDLabel.TabIndex = 30
        Me.CustomerIDLabel.Text = "Customer ID"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(59, 115)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(167, 23)
        Me.CustomerIDTextBox.TabIndex = 29
        '
        'OrderFilledLabel
        '
        Me.OrderFilledLabel.AutoSize = True
        Me.OrderFilledLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderFilledLabel.Location = New System.Drawing.Point(59, 154)
        Me.OrderFilledLabel.Name = "OrderFilledLabel"
        Me.OrderFilledLabel.Size = New System.Drawing.Size(73, 17)
        Me.OrderFilledLabel.TabIndex = 32
        Me.OrderFilledLabel.Text = "Order Filled"
        '
        'OrderFilledTextBox
        '
        Me.OrderFilledTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderFilledTextBox.Location = New System.Drawing.Point(61, 174)
        Me.OrderFilledTextBox.Name = "OrderFilledTextBox"
        Me.OrderFilledTextBox.Size = New System.Drawing.Size(167, 23)
        Me.OrderFilledTextBox.TabIndex = 31
        '
        'OrderLineIDLabel
        '
        Me.OrderLineIDLabel.AutoSize = True
        Me.OrderLineIDLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderLineIDLabel.Location = New System.Drawing.Point(59, 210)
        Me.OrderLineIDLabel.Name = "OrderLineIDLabel"
        Me.OrderLineIDLabel.Size = New System.Drawing.Size(83, 17)
        Me.OrderLineIDLabel.TabIndex = 34
        Me.OrderLineIDLabel.Text = "Order Line ID"
        '
        'OrderLineIDTextBox
        '
        Me.OrderLineIDTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderLineIDTextBox.Location = New System.Drawing.Point(61, 230)
        Me.OrderLineIDTextBox.Name = "OrderLineIDTextBox"
        Me.OrderLineIDTextBox.Size = New System.Drawing.Size(167, 23)
        Me.OrderLineIDTextBox.TabIndex = 33
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNLabel.Location = New System.Drawing.Point(59, 265)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(35, 17)
        Me.ISBNLabel.TabIndex = 36
        Me.ISBNLabel.Text = "ISBN"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNTextBox.Location = New System.Drawing.Point(61, 285)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(167, 23)
        Me.ISBNTextBox.TabIndex = 35
        '
        'CostEach
        '
        Me.CostEach.AutoSize = True
        Me.CostEach.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostEach.Location = New System.Drawing.Point(59, 324)
        Me.CostEach.Name = "CostEach"
        Me.CostEach.Size = New System.Drawing.Size(62, 17)
        Me.CostEach.TabIndex = 38
        Me.CostEach.Text = "Cost Each"
        '
        'CostEachTextBox
        '
        Me.CostEachTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostEachTextBox.Location = New System.Drawing.Point(61, 344)
        Me.CostEachTextBox.Name = "CostEachTextBox"
        Me.CostEachTextBox.Size = New System.Drawing.Size(167, 23)
        Me.CostEachTextBox.TabIndex = 37
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityLabel.Location = New System.Drawing.Point(59, 381)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(57, 17)
        Me.QuantityLabel.TabIndex = 40
        Me.QuantityLabel.Text = "Quantity"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(61, 401)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(167, 23)
        Me.QuantityTextBox.TabIndex = 39
        '
        'btnDeleteOrderLine
        '
        Me.btnDeleteOrderLine.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrderLine.Location = New System.Drawing.Point(416, 170)
        Me.btnDeleteOrderLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteOrderLine.Name = "btnDeleteOrderLine"
        Me.btnDeleteOrderLine.Size = New System.Drawing.Size(185, 47)
        Me.btnDeleteOrderLine.TabIndex = 43
        Me.btnDeleteOrderLine.Text = "Delete Order Line"
        Me.btnDeleteOrderLine.UseVisualStyleBackColor = True
        '
        'btnUpdateOrderLine
        '
        Me.btnUpdateOrderLine.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateOrderLine.Location = New System.Drawing.Point(416, 115)
        Me.btnUpdateOrderLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdateOrderLine.Name = "btnUpdateOrderLine"
        Me.btnUpdateOrderLine.Size = New System.Drawing.Size(185, 47)
        Me.btnUpdateOrderLine.TabIndex = 42
        Me.btnUpdateOrderLine.Text = "Update Order Line"
        Me.btnUpdateOrderLine.UseVisualStyleBackColor = True
        '
        'btnAddOrderLine
        '
        Me.btnAddOrderLine.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrderLine.Location = New System.Drawing.Point(416, 60)
        Me.btnAddOrderLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddOrderLine.Name = "btnAddOrderLine"
        Me.btnAddOrderLine.Size = New System.Drawing.Size(185, 47)
        Me.btnAddOrderLine.TabIndex = 41
        Me.btnAddOrderLine.Text = "Add Order Line"
        Me.btnAddOrderLine.UseVisualStyleBackColor = True
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(724, 554)
        Me.Controls.Add(Me.btnDeleteOrderLine)
        Me.Controls.Add(Me.btnUpdateOrderLine)
        Me.Controls.Add(Me.btnAddOrderLine)
        Me.Controls.Add(Me.QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.CostEach)
        Me.Controls.Add(Me.CostEachTextBox)
        Me.Controls.Add(Me.ISBNLabel)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(Me.OrderLineIDLabel)
        Me.Controls.Add(Me.OrderLineIDTextBox)
        Me.Controls.Add(Me.OrderFilledLabel)
        Me.Controls.Add(Me.OrderFilledTextBox)
        Me.Controls.Add(Me.CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.OrderIDLabel)
        Me.Controls.Add(Me.OrderIDTextBox)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnUpdateOrder)
        Me.Controls.Add(Me.btnAddOrder)
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Name = "OrderForm"
        Me.Text = "Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents OrderIDTextBox As TextBox
    Friend WithEvents OrderIDLabel As Label
    Friend WithEvents CustomerIDLabel As Label
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents OrderFilledLabel As Label
    Friend WithEvents OrderFilledTextBox As TextBox
    Friend WithEvents OrderLineIDLabel As Label
    Friend WithEvents OrderLineIDTextBox As TextBox
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents CostEach As Label
    Friend WithEvents CostEachTextBox As TextBox
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents btnDeleteOrderLine As Button
    Friend WithEvents btnUpdateOrderLine As Button
    Friend WithEvents btnAddOrderLine As Button
End Class
