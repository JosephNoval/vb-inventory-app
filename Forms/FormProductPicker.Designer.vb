<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductPicker
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
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.FooterBar = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridViewProduct = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityOnHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSearchClear = New FontAwesome.Sharp.IconButton()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.TitleBar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.Label1)
        Me.TitleBar.Controls.Add(Me.btnClose)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(952, 44)
        Me.TitleBar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Product Picker"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClose.IconColor = System.Drawing.Color.Gainsboro
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 20
        Me.btnClose.Location = New System.Drawing.Point(919, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 6
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FooterBar
        '
        Me.FooterBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FooterBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterBar.Location = New System.Drawing.Point(0, 511)
        Me.FooterBar.Name = "FooterBar"
        Me.FooterBar.Size = New System.Drawing.Size(952, 15)
        Me.FooterBar.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(952, 467)
        Me.Panel2.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridViewProduct)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 46)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(952, 421)
        Me.Panel4.TabIndex = 22
        '
        'DataGridViewProduct
        '
        Me.DataGridViewProduct.AllowUserToAddRows = False
        Me.DataGridViewProduct.AllowUserToDeleteRows = False
        Me.DataGridViewProduct.AllowUserToOrderColumns = True
        Me.DataGridViewProduct.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.ProductName, Me.QuantityOnHand, Me.Price})
        Me.DataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewProduct.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewProduct.MultiSelect = False
        Me.DataGridViewProduct.Name = "DataGridViewProduct"
        Me.DataGridViewProduct.ReadOnly = True
        Me.DataGridViewProduct.RowHeadersWidth = 51
        Me.DataGridViewProduct.RowTemplate.Height = 29
        Me.DataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProduct.Size = New System.Drawing.Size(952, 421)
        Me.DataGridViewProduct.TabIndex = 20
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
        'QuantityOnHand
        '
        Me.QuantityOnHand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QuantityOnHand.DataPropertyName = "QuantityOnHand"
        Me.QuantityOnHand.HeaderText = "Qty On Hand"
        Me.QuantityOnHand.MinimumWidth = 125
        Me.QuantityOnHand.Name = "QuantityOnHand"
        Me.QuantityOnHand.ReadOnly = True
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 125
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSearchClear)
        Me.Panel3.Controls.Add(Me.txtSearchBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(952, 46)
        Me.Panel3.TabIndex = 21
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
        Me.btnSearchClear.Location = New System.Drawing.Point(411, 9)
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
        Me.txtSearchBox.Location = New System.Drawing.Point(13, 9)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PlaceholderText = "Type To Search"
        Me.txtSearchBox.Size = New System.Drawing.Size(392, 27)
        Me.txtSearchBox.TabIndex = 18
        Me.txtSearchBox.Tag = "fdsf"
        '
        'FormProductPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(952, 526)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FooterBar)
        Me.Controls.Add(Me.TitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormProductPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProductPicker"
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBar As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents FooterBar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSearchClear As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents DataGridViewProduct As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents QuantityOnHand As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
End Class
