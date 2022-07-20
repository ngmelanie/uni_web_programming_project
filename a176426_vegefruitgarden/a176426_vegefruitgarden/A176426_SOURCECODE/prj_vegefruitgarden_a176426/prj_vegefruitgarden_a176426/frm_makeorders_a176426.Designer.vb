<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorders_a176426
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_makeorders = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.btn_addline = New System.Windows.Forms.Button()
        Me.grd_neworder = New System.Windows.Forms.DataGridView()
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.cmb_custid = New System.Windows.Forms.ComboBox()
        Me.dte_orderdate = New System.Windows.Forms.DateTimePicker()
        Me.cmb_staffid = New System.Windows.Forms.ComboBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_orderid = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_product = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_neworder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Monotype Corsiva", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(584, 63)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(317, 52)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "VegeFruit Garden"
        '
        'lbl_makeorders
        '
        Me.lbl_makeorders.AutoSize = True
        Me.lbl_makeorders.BackColor = System.Drawing.Color.Transparent
        Me.lbl_makeorders.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_makeorders.Location = New System.Drawing.Point(655, 115)
        Me.lbl_makeorders.Name = "lbl_makeorders"
        Me.lbl_makeorders.Size = New System.Drawing.Size(199, 33)
        Me.lbl_makeorders.TabIndex = 1
        Me.lbl_makeorders.Text = "- Make Orders - "
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(123, 182)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(1251, 189)
        Me.grd_order.TabIndex = 2
        '
        'btn_addline
        '
        Me.btn_addline.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_addline.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addline.Location = New System.Drawing.Point(1212, 516)
        Me.btn_addline.Name = "btn_addline"
        Me.btn_addline.Size = New System.Drawing.Size(162, 40)
        Me.btn_addline.TabIndex = 3
        Me.btn_addline.Text = "ADD LINE"
        Me.btn_addline.UseVisualStyleBackColor = False
        '
        'grd_neworder
        '
        Me.grd_neworder.AllowUserToAddRows = False
        Me.grd_neworder.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_neworder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_neworder.Location = New System.Drawing.Point(123, 594)
        Me.grd_neworder.Name = "grd_neworder"
        Me.grd_neworder.ReadOnly = True
        Me.grd_neworder.RowHeadersWidth = 51
        Me.grd_neworder.RowTemplate.Height = 24
        Me.grd_neworder.Size = New System.Drawing.Size(1251, 162)
        Me.grd_neworder.TabIndex = 4
        '
        'btn_makeorder
        '
        Me.btn_makeorder.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_makeorder.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeorder.Location = New System.Drawing.Point(593, 795)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(308, 43)
        Me.btn_makeorder.TabIndex = 5
        Me.btn_makeorder.Text = "SAVE ORDER"
        Me.btn_makeorder.UseVisualStyleBackColor = False
        '
        'cmb_custid
        '
        Me.cmb_custid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_custid.FormattingEnabled = True
        Me.cmb_custid.Location = New System.Drawing.Point(437, 454)
        Me.cmb_custid.Name = "cmb_custid"
        Me.cmb_custid.Size = New System.Drawing.Size(121, 28)
        Me.cmb_custid.TabIndex = 6
        '
        'dte_orderdate
        '
        Me.dte_orderdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dte_orderdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dte_orderdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dte_orderdate.Location = New System.Drawing.Point(437, 524)
        Me.dte_orderdate.Name = "dte_orderdate"
        Me.dte_orderdate.Size = New System.Drawing.Size(200, 27)
        Me.dte_orderdate.TabIndex = 7
        '
        'cmb_staffid
        '
        Me.cmb_staffid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_staffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_staffid.FormattingEnabled = True
        Me.cmb_staffid.Location = New System.Drawing.Point(282, 455)
        Me.cmb_staffid.Name = "cmb_staffid"
        Me.cmb_staffid.Size = New System.Drawing.Size(121, 28)
        Me.cmb_staffid.TabIndex = 9
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(760, 524)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(121, 27)
        Me.txt_quantity.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Step 1: Select your order information."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 565)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(614, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Step 3: Confirm your order in the list below, click 'Make Order' when done. "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 502)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Order ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 435)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Staff ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Customer ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(897, 502)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Product ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1046, 435)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Product Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1026, 769)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 22)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "SUBTOTAL (RM):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1030, 802)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 26)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "TOTAL (RM):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(433, 502)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 19)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Order Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(756, 502)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 19)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Quantity:"
        '
        'txt_orderid
        '
        Me.txt_orderid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderid.Location = New System.Drawing.Point(282, 524)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.Size = New System.Drawing.Size(100, 27)
        Me.txt_orderid.TabIndex = 28
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(1046, 524)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(145, 27)
        Me.txt_price.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1046, 502)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 19)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Price per unit (RM):"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(42, 34)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(115, 32)
        Me.btn_back.TabIndex = 31
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.ItemHeight = 16
        Me.lst_product.Location = New System.Drawing.Point(760, 418)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(262, 68)
        Me.lst_product.TabIndex = 32
        '
        'txt_productid
        '
        Me.txt_productid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productid.Location = New System.Drawing.Point(901, 524)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.ReadOnly = True
        Me.txt_productid.Size = New System.Drawing.Size(121, 27)
        Me.txt_productid.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(756, 387)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(372, 22)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Step 2: Choose a product to buy from this list."
        '
        'txt_product
        '
        Me.txt_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product.Location = New System.Drawing.Point(1046, 456)
        Me.txt_product.Name = "txt_product"
        Me.txt_product.ReadOnly = True
        Me.txt_product.Size = New System.Drawing.Size(305, 27)
        Me.txt_product.TabIndex = 35
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(1212, 766)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(121, 30)
        Me.txt_subtotal.TabIndex = 36
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(1212, 802)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(121, 30)
        Me.txt_total.TabIndex = 37
        '
        'frm_makeorders_a176426
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_vegefruitgarden_a176426.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1493, 890)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.txt_product)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_productid)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.cmb_staffid)
        Me.Controls.Add(Me.dte_orderdate)
        Me.Controls.Add(Me.cmb_custid)
        Me.Controls.Add(Me.btn_makeorder)
        Me.Controls.Add(Me.grd_neworder)
        Me.Controls.Add(Me.btn_addline)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.lbl_makeorders)
        Me.Controls.Add(Me.lbl_title)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(1511, 937)
        Me.Name = "frm_makeorders_a176426"
        Me.Text = "VegeFruit Garden - Make Orders"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_neworder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_makeorders As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents btn_addline As Button
    Friend WithEvents grd_neworder As DataGridView
    Friend WithEvents btn_makeorder As Button
    Friend WithEvents cmb_custid As ComboBox
    Friend WithEvents dte_orderdate As DateTimePicker
    Friend WithEvents cmb_staffid As ComboBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_orderid As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lst_product As ListBox
    Friend WithEvents txt_productid As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_product As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_total As TextBox
End Class
