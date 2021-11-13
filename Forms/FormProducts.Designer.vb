<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProducts
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
        Me.grbForm = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxRecordStatus = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnUpdate = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.txtQtySold = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQtyOnHand = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxList = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewProduct = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityOnHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitySold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearchClear = New FontAwesome.Sharp.IconButton()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.grbForm.SuspendLayout()
        Me.GroupBoxList.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbForm
        '
        Me.grbForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbForm.Controls.Add(Me.Label8)
        Me.grbForm.Controls.Add(Me.cbxRecordStatus)
        Me.grbForm.Controls.Add(Me.txtDescription)
        Me.grbForm.Controls.Add(Me.Label7)
        Me.grbForm.Controls.Add(Me.Label6)
        Me.grbForm.Controls.Add(Me.cbxCategory)
        Me.grbForm.Controls.Add(Me.btnClear)
        Me.grbForm.Controls.Add(Me.btnUpdate)
        Me.grbForm.Controls.Add(Me.btnDelete)
        Me.grbForm.Controls.Add(Me.txtQtySold)
        Me.grbForm.Controls.Add(Me.Label5)
        Me.grbForm.Controls.Add(Me.txtQtyOnHand)
        Me.grbForm.Controls.Add(Me.Label4)
        Me.grbForm.Controls.Add(Me.txtProductName)
        Me.grbForm.Controls.Add(Me.Label3)
        Me.grbForm.Controls.Add(Me.btnSave)
        Me.grbForm.Controls.Add(Me.txtPrice)
        Me.grbForm.Controls.Add(Me.Label2)
        Me.grbForm.Controls.Add(Me.txtId)
        Me.grbForm.Controls.Add(Me.Label1)
        Me.grbForm.Location = New System.Drawing.Point(12, 7)
        Me.grbForm.Name = "grbForm"
        Me.grbForm.Size = New System.Drawing.Size(1090, 325)
        Me.grbForm.TabIndex = 5
        Me.grbForm.TabStop = False
        Me.grbForm.Text = "Form"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(25, 219)
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
        Me.cbxRecordStatus.Location = New System.Drawing.Point(133, 219)
        Me.cbxRecordStatus.Name = "cbxRecordStatus"
        Me.cbxRecordStatus.Size = New System.Drawing.Size(392, 28)
        Me.cbxRecordStatus.TabIndex = 4
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(133, 126)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PlaceholderText = "Enter Product Description"
        Me.txtDescription.Size = New System.Drawing.Size(392, 27)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.Tag = "fdsf"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(25, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(25, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Category"
        '
        'cbxCategory
        '
        Me.cbxCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Items.AddRange(New Object() {"Admin", "Standard"})
        Me.cbxCategory.Location = New System.Drawing.Point(133, 171)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(392, 28)
        Me.cbxCategory.TabIndex = 3
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
        'txtQtySold
        '
        Me.txtQtySold.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtQtySold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtySold.Enabled = False
        Me.txtQtySold.Location = New System.Drawing.Point(642, 126)
        Me.txtQtySold.Name = "txtQtySold"
        Me.txtQtySold.PlaceholderText = "Autogenerated"
        Me.txtQtySold.ReadOnly = True
        Me.txtQtySold.Size = New System.Drawing.Size(419, 27)
        Me.txtQtySold.TabIndex = 8
        Me.txtQtySold.Tag = "fdsf"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(543, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Qty Sold"
        '
        'txtQtyOnHand
        '
        Me.txtQtyOnHand.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtQtyOnHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtyOnHand.Enabled = False
        Me.txtQtyOnHand.Location = New System.Drawing.Point(642, 81)
        Me.txtQtyOnHand.Name = "txtQtyOnHand"
        Me.txtQtyOnHand.PlaceholderText = "Autogenerated"
        Me.txtQtyOnHand.ReadOnly = True
        Me.txtQtyOnHand.Size = New System.Drawing.Size(419, 27)
        Me.txtQtyOnHand.TabIndex = 7
        Me.txtQtyOnHand.Tag = "fdsf"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(543, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Qty On Hand"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductName.Location = New System.Drawing.Point(133, 81)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PlaceholderText = "Enter Product Name"
        Me.txtProductName.Size = New System.Drawing.Size(392, 27)
        Me.txtProductName.TabIndex = 1
        Me.txtProductName.Tag = "fdsf"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(25, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product Name"
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
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(642, 35)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PlaceholderText = "Enter Price"
        Me.txtPrice.Size = New System.Drawing.Size(419, 27)
        Me.txtPrice.TabIndex = 5
        Me.txtPrice.Tag = "fdsf"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(543, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Price"
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
        Me.GroupBoxList.TabIndex = 4
        Me.GroupBoxList.TabStop = False
        Me.GroupBoxList.Text = "List"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewProduct)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1084, 315)
        Me.Panel2.TabIndex = 20
        '
        'DataGridViewProduct
        '
        Me.DataGridViewProduct.AllowUserToAddRows = False
        Me.DataGridViewProduct.AllowUserToDeleteRows = False
        Me.DataGridViewProduct.AllowUserToOrderColumns = True
        Me.DataGridViewProduct.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.ProductName, Me.Category, Me.Price, Me.CreatedOn, Me.CreatedBy, Me.RecordStatus, Me.CategoryId, Me.Description, Me.QuantityOnHand, Me.QuantitySold})
        Me.DataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewProduct.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewProduct.MultiSelect = False
        Me.DataGridViewProduct.Name = "DataGridViewProduct"
        Me.DataGridViewProduct.ReadOnly = True
        Me.DataGridViewProduct.RowHeadersWidth = 51
        Me.DataGridViewProduct.RowTemplate.Height = 29
        Me.DataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProduct.Size = New System.Drawing.Size(1084, 315)
        Me.DataGridViewProduct.TabIndex = 0
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
        'Category
        '
        Me.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Category.DataPropertyName = "Category"
        Me.Category.HeaderText = "Category"
        Me.Category.MinimumWidth = 100
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 125
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
        'CategoryId
        '
        Me.CategoryId.DataPropertyName = "CategoryId"
        Me.CategoryId.HeaderText = "Category Id"
        Me.CategoryId.MinimumWidth = 6
        Me.CategoryId.Name = "CategoryId"
        Me.CategoryId.ReadOnly = True
        Me.CategoryId.Visible = False
        Me.CategoryId.Width = 125
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.MinimumWidth = 6
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Visible = False
        Me.Description.Width = 125
        '
        'QuantityOnHand
        '
        Me.QuantityOnHand.DataPropertyName = "QuantityOnHand"
        Me.QuantityOnHand.HeaderText = "Qty On Hand"
        Me.QuantityOnHand.MinimumWidth = 6
        Me.QuantityOnHand.Name = "QuantityOnHand"
        Me.QuantityOnHand.ReadOnly = True
        Me.QuantityOnHand.Visible = False
        Me.QuantityOnHand.Width = 125
        '
        'QuantitySold
        '
        Me.QuantitySold.DataPropertyName = "QuantitySold"
        Me.QuantitySold.HeaderText = "Quantity Sold"
        Me.QuantitySold.MinimumWidth = 6
        Me.QuantitySold.Name = "QuantitySold"
        Me.QuantitySold.ReadOnly = True
        Me.QuantitySold.Visible = False
        Me.QuantitySold.Width = 125
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
        'FormProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 731)
        Me.Controls.Add(Me.grbForm)
        Me.Controls.Add(Me.GroupBoxList)
        Me.Name = "FormProducts"
        Me.Text = "Products"
        Me.grbForm.ResumeLayout(False)
        Me.grbForm.PerformLayout()
        Me.GroupBoxList.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbForm As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxRecordStatus As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents txtQtySold As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQtyOnHand As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxList As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewProduct As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearchClear As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents CreatedOn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents RecordStatus As DataGridViewTextBoxColumn
    Friend WithEvents CategoryId As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents QuantityOnHand As DataGridViewTextBoxColumn
    Friend WithEvents QuantitySold As DataGridViewTextBoxColumn
End Class
