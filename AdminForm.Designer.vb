<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.btnOrders = New FontAwesome.Sharp.IconButton()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.btnProducts = New FontAwesome.Sharp.IconButton()
        Me.btnUsers = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ImageHome = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.txtCurrentUser = New System.Windows.Forms.TextBox()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnMaximized = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnInventoryReport = New FontAwesome.Sharp.IconButton()
        Me.btnSalesReport = New FontAwesome.Sharp.IconButton()
        Me.SidePanel.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.btnSalesReport)
        Me.SidePanel.Controls.Add(Me.btnInventoryReport)
        Me.SidePanel.Controls.Add(Me.btnOrders)
        Me.SidePanel.Controls.Add(Me.btnLogout)
        Me.SidePanel.Controls.Add(Me.btnInventory)
        Me.SidePanel.Controls.Add(Me.btnProducts)
        Me.SidePanel.Controls.Add(Me.btnUsers)
        Me.SidePanel.Controls.Add(Me.PanelLogo)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePanel.Location = New System.Drawing.Point(0, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(250, 853)
        Me.SidePanel.TabIndex = 0
        '
        'btnOrders
        '
        Me.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnOrders.IconColor = System.Drawing.Color.Gainsboro
        Me.btnOrders.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOrders.IconSize = 40
        Me.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.Location = New System.Drawing.Point(0, 320)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnOrders.Size = New System.Drawing.Size(250, 60)
        Me.btnOrders.TabIndex = 4
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.btnLogout.IconColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 40
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 793)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLogout.Size = New System.Drawing.Size(250, 60)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed
        Me.btnInventory.IconColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventory.IconSize = 40
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 260)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnInventory.Size = New System.Drawing.Size(250, 60)
        Me.btnInventory.TabIndex = 3
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.btnProducts.IconColor = System.Drawing.Color.Gainsboro
        Me.btnProducts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProducts.IconSize = 40
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 200)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnProducts.Size = New System.Drawing.Size(250, 60)
        Me.btnProducts.TabIndex = 2
        Me.btnProducts.Text = "Products"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnUsers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnUsers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUsers.IconSize = 40
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(0, 140)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUsers.Size = New System.Drawing.Size(250, 60)
        Me.btnUsers.TabIndex = 1
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImageHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(250, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'ImageHome
        '
        Me.ImageHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImageHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ImageHome.BackgroundImage = Global.InventoryManagementApp.My.Resources.Resources.pexels_ella_olsson_1640777
        Me.ImageHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImageHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImageHome.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ImageHome.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ImageHome.IconColor = System.Drawing.SystemColors.ControlText
        Me.ImageHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ImageHome.IconSize = 107
        Me.ImageHome.Location = New System.Drawing.Point(18, 16)
        Me.ImageHome.Name = "ImageHome"
        Me.ImageHome.Size = New System.Drawing.Size(215, 107)
        Me.ImageHome.TabIndex = 0
        Me.ImageHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.txtCurrentUser)
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.btnMaximized)
        Me.PanelTitleBar.Controls.Add(Me.btnClose)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(250, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1132, 75)
        Me.PanelTitleBar.TabIndex = 1
        '
        'txtCurrentUser
        '
        Me.txtCurrentUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtCurrentUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurrentUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.txtCurrentUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtCurrentUser.Location = New System.Drawing.Point(878, 38)
        Me.txtCurrentUser.Name = "txtCurrentUser"
        Me.txtCurrentUser.ReadOnly = True
        Me.txtCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCurrentUser.Size = New System.Drawing.Size(244, 25)
        Me.txtCurrentUser.TabIndex = 7
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.IconSize = 15
        Me.btnMinimize.Location = New System.Drawing.Point(1054, 6)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(20, 17)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximized
        '
        Me.btnMaximized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximized.FlatAppearance.BorderSize = 0
        Me.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximized.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMaximized.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaximized.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMaximized.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximized.IconSize = 15
        Me.btnMaximized.Location = New System.Drawing.Point(1080, 6)
        Me.btnMaximized.Name = "btnMaximized"
        Me.btnMaximized.Size = New System.Drawing.Size(20, 17)
        Me.btnMaximized.TabIndex = 3
        Me.btnMaximized.UseVisualStyleBackColor = True
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
        Me.btnClose.IconSize = 15
        Me.btnClose.Location = New System.Drawing.Point(1106, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 17)
        Me.btnClose.TabIndex = 2
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(49, 27)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(50, 20)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 40
        Me.IconCurrentForm.Location = New System.Drawing.Point(6, 18)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(40, 40)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.IconPictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(250, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1132, 778)
        Me.PanelDesktop.TabIndex = 2
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconPictureBox1.BackgroundImage = Global.InventoryManagementApp.My.Resources.Resources.pexels_ella_olsson_1640777
        Me.IconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 472
        Me.IconPictureBox1.Location = New System.Drawing.Point(197, 141)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(761, 472)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'btnInventoryReport
        '
        Me.btnInventoryReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventoryReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventoryReport.FlatAppearance.BorderSize = 0
        Me.btnInventoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryReport.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInventoryReport.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.btnInventoryReport.IconColor = System.Drawing.Color.Gainsboro
        Me.btnInventoryReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventoryReport.IconSize = 40
        Me.btnInventoryReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryReport.Location = New System.Drawing.Point(0, 380)
        Me.btnInventoryReport.Name = "btnInventoryReport"
        Me.btnInventoryReport.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnInventoryReport.Size = New System.Drawing.Size(250, 60)
        Me.btnInventoryReport.TabIndex = 7
        Me.btnInventoryReport.Text = "Inventory Report"
        Me.btnInventoryReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventoryReport.UseVisualStyleBackColor = True
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalesReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalesReport.FlatAppearance.BorderSize = 0
        Me.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesReport.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSalesReport.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.btnSalesReport.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSalesReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalesReport.IconSize = 40
        Me.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalesReport.Location = New System.Drawing.Point(0, 440)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSalesReport.Size = New System.Drawing.Size(250, 60)
        Me.btnSalesReport.TabIndex = 8
        Me.btnSalesReport.Text = "Order Report"
        Me.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 853)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.SidePanel)
        Me.MinimumSize = New System.Drawing.Size(1400, 900)
        Me.Name = "AdminForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin - Inventory Management"
        Me.SidePanel.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SidePanel As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents ImageHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnUsers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btnOrders As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximized As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents txtCurrentUser As TextBox
    Friend WithEvents btnSalesReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventoryReport As FontAwesome.Sharp.IconButton
End Class
