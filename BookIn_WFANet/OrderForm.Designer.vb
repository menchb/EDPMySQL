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
        Me.components = New System.ComponentModel.Container()
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
        Me.dgOrder = New System.Windows.Forms.DataGridView()
        Me.OrderidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERFILLEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnReloadOrder = New System.Windows.Forms.Button()
        Me.btnExportOrder = New System.Windows.Forms.Button()
        Me.btnImportOrder = New System.Windows.Forms.Button()
        Me.dgOrderLine = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTEACHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTLINEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnReloadOrderLine = New System.Windows.Forms.Button()
        Me.btnExportOrderLine = New System.Windows.Forms.Button()
        Me.btnImportOrderLine = New System.Windows.Forms.Button()
        CType(Me.dgOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgOrderLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(59, 474)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 47)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrder.Location = New System.Drawing.Point(289, 381)
        Me.btnDeleteOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(185, 47)
        Me.btnDeleteOrder.TabIndex = 25
        Me.btnDeleteOrder.Text = "Delete Order"
        Me.btnDeleteOrder.UseVisualStyleBackColor = True
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateOrder.Location = New System.Drawing.Point(289, 326)
        Me.btnUpdateOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(185, 47)
        Me.btnUpdateOrder.TabIndex = 24
        Me.btnUpdateOrder.Text = "Update Order"
        Me.btnUpdateOrder.UseVisualStyleBackColor = True
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.Location = New System.Drawing.Point(289, 271)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnDeleteOrderLine.Location = New System.Drawing.Point(289, 161)
        Me.btnDeleteOrderLine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteOrderLine.Name = "btnDeleteOrderLine"
        Me.btnDeleteOrderLine.Size = New System.Drawing.Size(185, 47)
        Me.btnDeleteOrderLine.TabIndex = 43
        Me.btnDeleteOrderLine.Text = "Delete Order Line"
        Me.btnDeleteOrderLine.UseVisualStyleBackColor = True
        '
        'btnUpdateOrderLine
        '
        Me.btnUpdateOrderLine.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateOrderLine.Location = New System.Drawing.Point(289, 106)
        Me.btnUpdateOrderLine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateOrderLine.Name = "btnUpdateOrderLine"
        Me.btnUpdateOrderLine.Size = New System.Drawing.Size(185, 47)
        Me.btnUpdateOrderLine.TabIndex = 42
        Me.btnUpdateOrderLine.Text = "Update Order Line"
        Me.btnUpdateOrderLine.UseVisualStyleBackColor = True
        '
        'btnAddOrderLine
        '
        Me.btnAddOrderLine.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrderLine.Location = New System.Drawing.Point(289, 51)
        Me.btnAddOrderLine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddOrderLine.Name = "btnAddOrderLine"
        Me.btnAddOrderLine.Size = New System.Drawing.Size(185, 47)
        Me.btnAddOrderLine.TabIndex = 41
        Me.btnAddOrderLine.Text = "Add Order Line"
        Me.btnAddOrderLine.UseVisualStyleBackColor = True
        '
        'dgOrder
        '
        Me.dgOrder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgOrder.AutoGenerateColumns = False
        Me.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderidDataGridViewTextBoxColumn, Me.CUSTOMERIDDataGridViewTextBoxColumn, Me.ORDERDATEDataGridViewTextBoxColumn, Me.ORDERFILLEDDataGridViewTextBoxColumn})
        Me.dgOrder.DataSource = Me.OrderBindingSource
        Me.dgOrder.Location = New System.Drawing.Point(690, -6)
        Me.dgOrder.Name = "dgOrder"
        Me.dgOrder.RowHeadersWidth = 51
        Me.dgOrder.RowTemplate.Height = 24
        Me.dgOrder.Size = New System.Drawing.Size(607, 373)
        Me.dgOrder.TabIndex = 44
        '
        'OrderidDataGridViewTextBoxColumn
        '
        Me.OrderidDataGridViewTextBoxColumn.DataPropertyName = "order_id"
        Me.OrderidDataGridViewTextBoxColumn.HeaderText = "order_id"
        Me.OrderidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderidDataGridViewTextBoxColumn.Name = "OrderidDataGridViewTextBoxColumn"
        Me.OrderidDataGridViewTextBoxColumn.Width = 125
        '
        'CUSTOMERIDDataGridViewTextBoxColumn
        '
        Me.CUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Name = "CUSTOMERIDDataGridViewTextBoxColumn"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Width = 125
        '
        'ORDERDATEDataGridViewTextBoxColumn
        '
        Me.ORDERDATEDataGridViewTextBoxColumn.DataPropertyName = "ORDER_DATE"
        Me.ORDERDATEDataGridViewTextBoxColumn.HeaderText = "ORDER_DATE"
        Me.ORDERDATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ORDERDATEDataGridViewTextBoxColumn.Name = "ORDERDATEDataGridViewTextBoxColumn"
        Me.ORDERDATEDataGridViewTextBoxColumn.Width = 125
        '
        'ORDERFILLEDDataGridViewTextBoxColumn
        '
        Me.ORDERFILLEDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_FILLED"
        Me.ORDERFILLEDDataGridViewTextBoxColumn.HeaderText = "ORDER_FILLED"
        Me.ORDERFILLEDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ORDERFILLEDDataGridViewTextBoxColumn.Name = "ORDERFILLEDDataGridViewTextBoxColumn"
        Me.ORDERFILLEDDataGridViewTextBoxColumn.Width = 125
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(BookIn_WFANet.Order)
        '
        'btnReloadOrder
        '
        Me.btnReloadOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReloadOrder.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnReloadOrder.Location = New System.Drawing.Point(578, 290)
        Me.btnReloadOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReloadOrder.Name = "btnReloadOrder"
        Me.btnReloadOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReloadOrder.Size = New System.Drawing.Size(85, 47)
        Me.btnReloadOrder.TabIndex = 52
        Me.btnReloadOrder.Text = "Reload"
        Me.btnReloadOrder.UseVisualStyleBackColor = True
        '
        'btnExportOrder
        '
        Me.btnExportOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportOrder.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnExportOrder.Location = New System.Drawing.Point(578, 235)
        Me.btnExportOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportOrder.Name = "btnExportOrder"
        Me.btnExportOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExportOrder.Size = New System.Drawing.Size(85, 47)
        Me.btnExportOrder.TabIndex = 51
        Me.btnExportOrder.Text = "Export"
        Me.btnExportOrder.UseVisualStyleBackColor = True
        '
        'btnImportOrder
        '
        Me.btnImportOrder.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportOrder.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnImportOrder.Location = New System.Drawing.Point(578, 180)
        Me.btnImportOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImportOrder.Name = "btnImportOrder"
        Me.btnImportOrder.Size = New System.Drawing.Size(85, 47)
        Me.btnImportOrder.TabIndex = 50
        Me.btnImportOrder.Text = "Import"
        Me.btnImportOrder.UseVisualStyleBackColor = True
        '
        'dgOrderLine
        '
        Me.dgOrderLine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgOrderLine.AutoGenerateColumns = False
        Me.dgOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrderLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.ORDERIDDataGridViewTextBoxColumn1, Me.COSTEACHDataGridViewTextBoxColumn, Me.COSTLINEDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn})
        Me.dgOrderLine.DataSource = Me.OrderLineBindingSource
        Me.dgOrderLine.Location = New System.Drawing.Point(690, 371)
        Me.dgOrderLine.Name = "dgOrderLine"
        Me.dgOrderLine.RowHeadersWidth = 51
        Me.dgOrderLine.RowTemplate.Height = 24
        Me.dgOrderLine.Size = New System.Drawing.Size(607, 360)
        Me.dgOrderLine.TabIndex = 53
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.Width = 125
        '
        'ORDERIDDataGridViewTextBoxColumn1
        '
        Me.ORDERIDDataGridViewTextBoxColumn1.DataPropertyName = "ORDER_ID"
        Me.ORDERIDDataGridViewTextBoxColumn1.HeaderText = "ORDER_ID"
        Me.ORDERIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.ORDERIDDataGridViewTextBoxColumn1.Name = "ORDERIDDataGridViewTextBoxColumn1"
        Me.ORDERIDDataGridViewTextBoxColumn1.Width = 125
        '
        'COSTEACHDataGridViewTextBoxColumn
        '
        Me.COSTEACHDataGridViewTextBoxColumn.DataPropertyName = "COST_EACH"
        Me.COSTEACHDataGridViewTextBoxColumn.HeaderText = "COST_EACH"
        Me.COSTEACHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.COSTEACHDataGridViewTextBoxColumn.Name = "COSTEACHDataGridViewTextBoxColumn"
        Me.COSTEACHDataGridViewTextBoxColumn.Width = 125
        '
        'COSTLINEDataGridViewTextBoxColumn
        '
        Me.COSTLINEDataGridViewTextBoxColumn.DataPropertyName = "COST_LINE"
        Me.COSTLINEDataGridViewTextBoxColumn.HeaderText = "COST_LINE"
        Me.COSTLINEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.COSTLINEDataGridViewTextBoxColumn.Name = "COSTLINEDataGridViewTextBoxColumn"
        Me.COSTLINEDataGridViewTextBoxColumn.Width = 125
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        Me.QUANTITYDataGridViewTextBoxColumn.Width = 125
        '
        'OrderLineBindingSource
        '
        Me.OrderLineBindingSource.DataSource = GetType(BookIn_WFANet.OrderLine)
        '
        'btnReloadOrderLine
        '
        Me.btnReloadOrderLine.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReloadOrderLine.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnReloadOrderLine.Location = New System.Drawing.Point(578, 658)
        Me.btnReloadOrderLine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReloadOrderLine.Name = "btnReloadOrderLine"
        Me.btnReloadOrderLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReloadOrderLine.Size = New System.Drawing.Size(85, 47)
        Me.btnReloadOrderLine.TabIndex = 56
        Me.btnReloadOrderLine.Text = "Reload"
        Me.btnReloadOrderLine.UseVisualStyleBackColor = True
        '
        'btnExportOrderLine
        '
        Me.btnExportOrderLine.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportOrderLine.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnExportOrderLine.Location = New System.Drawing.Point(578, 603)
        Me.btnExportOrderLine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportOrderLine.Name = "btnExportOrderLine"
        Me.btnExportOrderLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExportOrderLine.Size = New System.Drawing.Size(85, 47)
        Me.btnExportOrderLine.TabIndex = 55
        Me.btnExportOrderLine.Text = "Export"
        Me.btnExportOrderLine.UseVisualStyleBackColor = True
        '
        'btnImportOrderLine
        '
        Me.btnImportOrderLine.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportOrderLine.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnImportOrderLine.Location = New System.Drawing.Point(578, 548)
        Me.btnImportOrderLine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImportOrderLine.Name = "btnImportOrderLine"
        Me.btnImportOrderLine.Size = New System.Drawing.Size(85, 47)
        Me.btnImportOrderLine.TabIndex = 54
        Me.btnImportOrderLine.Text = "Import"
        Me.btnImportOrderLine.UseVisualStyleBackColor = True
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1295, 729)
        Me.Controls.Add(Me.btnReloadOrderLine)
        Me.Controls.Add(Me.btnExportOrderLine)
        Me.Controls.Add(Me.btnImportOrderLine)
        Me.Controls.Add(Me.dgOrderLine)
        Me.Controls.Add(Me.btnReloadOrder)
        Me.Controls.Add(Me.btnExportOrder)
        Me.Controls.Add(Me.btnImportOrder)
        Me.Controls.Add(Me.dgOrder)
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
        CType(Me.dgOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgOrderLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgOrder As DataGridView
    Friend WithEvents btnReloadOrder As Button
    Friend WithEvents btnExportOrder As Button
    Friend WithEvents btnImportOrder As Button
    Friend WithEvents dgOrderLine As DataGridView
    Friend WithEvents btnReloadOrderLine As Button
    Friend WithEvents btnExportOrderLine As Button
    Friend WithEvents btnImportOrderLine As Button
    Friend WithEvents OrderidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDERDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDERFILLEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDERIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents COSTEACHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COSTLINEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderLineBindingSource As BindingSource
End Class
