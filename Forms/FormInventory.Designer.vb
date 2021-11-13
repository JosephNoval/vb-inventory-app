<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventory
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
        Me.grbForm = New System.Windows.Forms.GroupBox()
        Me.btnProductPicker = New FontAwesome.Sharp.IconButton()
        Me.dtpInventoryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxRecordStatus = New System.Windows.Forms.ComboBox()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.lblProductId = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnUpdate = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxList = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewInventory = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearchClear = New FontAwesome.Sharp.IconButton()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbForm.SuspendLayout()
        Me.GroupBoxList.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbForm
        '
        Me.grbForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbForm.Controls.Add(Me.btnProductPicker)
        Me.grbForm.Controls.Add(Me.dtpInventoryDate)
        Me.grbForm.Controls.Add(Me.Label8)
        Me.grbForm.Controls.Add(Me.cbxRecordStatus)
        Me.grbForm.Controls.Add(Me.txtProductId)
        Me.grbForm.Controls.Add(Me.lblProductId)
        Me.grbForm.Controls.Add(Me.Label6)
        Me.grbForm.Controls.Add(Me.btnClear)
        Me.grbForm.Controls.Add(Me.btnUpdate)
        Me.grbForm.Controls.Add(Me.btnDelete)
        Me.grbForm.Controls.Add(Me.txtProductName)
        Me.grbForm.Controls.Add(Me.Label3)
        Me.grbForm.Controls.Add(Me.btnSave)
        Me.grbForm.Controls.Add(Me.txtQuantity)
        Me.grbForm.Controls.Add(Me.Label2)
        Me.grbForm.Controls.Add(Me.txtId)
        Me.grbForm.Controls.Add(Me.Label1)
        Me.grbForm.Location = New System.Drawing.Point(12, 7)
        Me.grbForm.Name = "grbForm"
        Me.grbForm.Size = New System.Drawing.Size(1090, 325)
        Me.grbForm.TabIndex = 7
        Me.grbForm.TabStop = False
        Me.grbForm.Text = "Form"
        '
        'btnProductPicker
        '
        Me.btnProductPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductPicker.IconChar = FontAwesome.Sharp.IconChar.HandPointer
        Me.btnProductPicker.IconColor = System.Drawing.Color.Black
        Me.btnProductPicker.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProductPicker.IconSize = 25
        Me.btnProductPicker.Location = New System.Drawing.Point(456, 79)
        Me.btnProductPicker.Name = "btnProductPicker"
        Me.btnProductPicker.Size = New System.Drawing.Size(69, 29)
        Me.btnProductPicker.TabIndex = 21
        Me.btnProductPicker.UseVisualStyleBackColor = True
        '
        'dtpInventoryDate
        '
        Me.dtpInventoryDate.Location = New System.Drawing.Point(677, 32)
        Me.dtpInventoryDate.Name = "dtpInventoryDate"
        Me.dtpInventoryDate.Size = New System.Drawing.Size(384, 27)
        Me.dtpInventoryDate.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(543, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Record Status"
        '
        'cbxRecordStatus
        '
        Me.cbxRecordStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.cbxRecordStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRecordStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxRecordStatus.FormattingEnabled = True
        Me.cbxRecordStatus.Items.AddRange(New Object() {"Active", "In Active"})
        Me.cbxRecordStatus.Location = New System.Drawing.Point(677, 80)
        Me.cbxRecordStatus.Name = "cbxRecordStatus"
        Me.cbxRecordStatus.Size = New System.Drawing.Size(384, 28)
        Me.cbxRecordStatus.TabIndex = 4
        '
        'txtProductId
        '
        Me.txtProductId.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductId.Location = New System.Drawing.Point(133, 173)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.PlaceholderText = "Hidden Product Id"
        Me.txtProductId.Size = New System.Drawing.Size(392, 27)
        Me.txtProductId.TabIndex = 2
        Me.txtProductId.Tag = "fdsf"
        '
        'lblProductId
        '
        Me.lblProductId.AutoSize = True
        Me.lblProductId.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblProductId.Location = New System.Drawing.Point(25, 175)
        Me.lblProductId.Name = "lblProductId"
        Me.lblProductId.Size = New System.Drawing.Size(77, 20)
        Me.lblProductId.TabIndex = 16
        Me.lblProductId.Text = "Product Id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(543, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Inventory Date"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(586, 260)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 49)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnUpdate.IconColor = System.Drawing.Color.Black
        Me.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(834, 260)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 49)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDelete.IconColor = System.Drawing.Color.Black
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(958, 260)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 49)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtProductName.Enabled = False
        Me.txtProductName.Location = New System.Drawing.Point(133, 81)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PlaceholderText = "Pick Product"
        Me.txtProductName.Size = New System.Drawing.Size(317, 27)
        Me.txtProductName.TabIndex = 1
        Me.txtProductName.Tag = "fdsf"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(25, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(710, 260)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 49)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Location = New System.Drawing.Point(133, 126)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PlaceholderText = "Enter Quantity"
        Me.txtQuantity.Size = New System.Drawing.Size(392, 27)
        Me.txtQuantity.TabIndex = 5
        Me.txtQuantity.Tag = "fdsf"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(27, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(133, 35)
        Me.txtId.Name = "txtId"
        Me.txtId.PlaceholderText = "Autogenerated"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(392, 27)
        Me.txtId.TabIndex = 1
        Me.txtId.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'GroupBoxList
        '
        Me.GroupBoxList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxList.Controls.Add(Me.Panel2)
        Me.GroupBoxList.Controls.Add(Me.Panel1)
        Me.GroupBoxList.Location = New System.Drawing.Point(12, 338)
        Me.GroupBoxList.Name = "GroupBoxList"
        Me.GroupBoxList.Size = New System.Drawing.Size(1090, 385)
        Me.GroupBoxList.TabIndex = 6
        Me.GroupBoxList.TabStop = False
        Me.GroupBoxList.Text = "List"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewInventory)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1084, 315)
        Me.Panel2.TabIndex = 20
        '
        'DataGridViewInventory
        '
        Me.DataGridViewInventory.AllowUserToAddRows = False
        Me.DataGridViewInventory.AllowUserToDeleteRows = False
        Me.DataGridViewInventory.AllowUserToOrderColumns = True
        Me.DataGridViewInventory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.DataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.ProductName, Me.Quantity, Me.InventoryDate, Me.CreatedOn, Me.CreatedBy, Me.RecordStatus, Me.ProductId})
        Me.DataGridViewInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewInventory.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewInventory.MultiSelect = False
        Me.DataGridViewInventory.Name = "DataGridViewInventory"
        Me.DataGridViewInventory.ReadOnly = True
        Me.DataGridViewInventory.RowHeadersWidth = 51
        Me.DataGridViewInventory.RowTemplate.Height = 29
        Me.DataGridViewInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInventory.Size = New System.Drawing.Size(1084, 315)
        Me.DataGridViewInventory.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearchClear)
        Me.Panel1.Controls.Add(Me.txtSearchBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 44)
        Me.Panel1.TabIndex = 19
        '
        'btnSearchClear
        '
        Me.btnSearchClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnSearchClear.IconColor = System.Drawing.Color.Black
        Me.btnSearchClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearchClear.IconSize = 23
        Me.btnSearchClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchClear.Location = New System.Drawing.Point(417, 7)
        Me.btnSearchClear.Name = "btnSearchClear"
        Me.btnSearchClear.Size = New System.Drawing.Size(80, 27)
        Me.btnSearchClear.TabIndex = 19
        Me.btnSearchClear.Text = "Clear"
        Me.btnSearchClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchClear.UseVisualStyleBackColor = True
        '
        'txtSearchBox
        '
        Me.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchBox.Location = New System.Drawing.Point(19, 7)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PlaceholderText = "Type To Search"
        Me.txtSearchBox.Size = New System.Drawing.Size(392, 27)
        Me.txtSearchBox.TabIndex = 18
        Me.txtSearchBox.Tag = "fdsf"
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 125
        '
        'ProductName
        '
        Me.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductName.DataPropertyName = "ProductName"
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.MinimumWidth = 150
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 125
        '
        'InventoryDate
        '
        Me.InventoryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InventoryDate.DataPropertyName = "InventoryDate"
        Me.InventoryDate.HeaderText = "Inventory Date"
        Me.InventoryDate.MinimumWidth = 6
        Me.InventoryDate.Name = "InventoryDate"
        Me.InventoryDate.ReadOnly = True
        '
        'CreatedOn
        '
        Me.CreatedOn.DataPropertyName = "CreatedOn"
        Me.CreatedOn.HeaderText = "Created On"
        Me.CreatedOn.MinimumWidth = 6
        Me.CreatedOn.Name = "CreatedOn"
        Me.CreatedOn.ReadOnly = True
        Me.CreatedOn.Width = 125
        '
        'CreatedBy
        '
        Me.CreatedBy.DataPropertyName = "CreatedBy"
        Me.CreatedBy.HeaderText = "Created By"
        Me.CreatedBy.MinimumWidth = 6
        Me.CreatedBy.Name = "CreatedBy"
        Me.CreatedBy.ReadOnly = True
        Me.CreatedBy.Width = 125
        '
        'RecordStatus
        '
        Me.RecordStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RecordStatus.DataPropertyName = "RecordStatus"
        Me.RecordStatus.HeaderText = "Record Status"
        Me.RecordStatus.MinimumWidth = 50
        Me.RecordStatus.Name = "RecordStatus"
        Me.RecordStatus.ReadOnly = True
        '
        'ProductId
        '
        Me.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductId.DataPropertyName = "ProductId"
        Me.ProductId.HeaderText = "Product Id"
        Me.ProductId.MinimumWidth = 100
        Me.ProductId.Name = "ProductId"
        Me.ProductId.ReadOnly = True
        Me.ProductId.Visible = False
        '
        'FormInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 731)
        Me.Controls.Add(Me.grbForm)
        Me.Controls.Add(Me.GroupBoxList)
        Me.Name = "FormInventory"
        Me.Text = "Inventory"
        Me.grbForm.ResumeLayout(False)
        Me.grbForm.PerformLayout()
        Me.GroupBoxList.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbForm As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxRecordStatus As ComboBox
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents lblProductId As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxList As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewInventory As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearchClear As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents dtpInventoryDate As DateTimePicker
    Friend WithEvents btnProductPicker As FontAwesome.Sharp.IconButton
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents InventoryDate As DataGridViewTextBoxColumn
    Friend WithEvents CreatedOn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents RecordStatus As DataGridViewTextBoxColumn
    Friend WithEvents ProductId As DataGridViewTextBoxColumn
End Class
