﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproducts_a176426
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_insert = New System.Windows.Forms.Label()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_categoryid = New System.Windows.Forms.TextBox()
        Me.txt_supplierid = New System.Windows.Forms.TextBox()
        Me.txt_storage = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.pic_products = New System.Windows.Forms.PictureBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.lbl_storage = New System.Windows.Forms.Label()
        Me.lbl_supplierid = New System.Windows.Forms.Label()
        Me.lbl_categoryid = New System.Windows.Forms.Label()
        Me.lbl_picture = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Monotype Corsiva", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(510, 35)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(317, 52)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "VegeFruit Garden"
        '
        'lbl_insert
        '
        Me.lbl_insert.AutoSize = True
        Me.lbl_insert.BackColor = System.Drawing.Color.Transparent
        Me.lbl_insert.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_insert.Location = New System.Drawing.Point(573, 88)
        Me.lbl_insert.Name = "lbl_insert"
        Me.lbl_insert.Size = New System.Drawing.Size(214, 33)
        Me.lbl_insert.TabIndex = 1
        Me.lbl_insert.Text = "- Insert Products -"
        '
        'grd_products
        '
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_products.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(109, 165)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.RowTemplate.Height = 24
        Me.grd_products.Size = New System.Drawing.Size(1139, 270)
        Me.grd_products.TabIndex = 2
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(42, 35)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(116, 30)
        Me.btn_back.TabIndex = 3
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(201, 532)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(351, 27)
        Me.txt_name.TabIndex = 4
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(201, 483)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(166, 27)
        Me.txt_id.TabIndex = 5
        '
        'txt_weight
        '
        Me.txt_weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_weight.Location = New System.Drawing.Point(775, 532)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(166, 27)
        Me.txt_weight.TabIndex = 6
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(201, 584)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(166, 27)
        Me.txt_price.TabIndex = 7
        '
        'txt_categoryid
        '
        Me.txt_categoryid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_categoryid.Location = New System.Drawing.Point(775, 481)
        Me.txt_categoryid.Name = "txt_categoryid"
        Me.txt_categoryid.Size = New System.Drawing.Size(166, 27)
        Me.txt_categoryid.TabIndex = 8
        '
        'txt_supplierid
        '
        Me.txt_supplierid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_supplierid.Location = New System.Drawing.Point(775, 584)
        Me.txt_supplierid.Name = "txt_supplierid"
        Me.txt_supplierid.Size = New System.Drawing.Size(166, 27)
        Me.txt_supplierid.TabIndex = 9
        '
        'txt_storage
        '
        Me.txt_storage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_storage.Location = New System.Drawing.Point(201, 637)
        Me.txt_storage.Name = "txt_storage"
        Me.txt_storage.Size = New System.Drawing.Size(351, 27)
        Me.txt_storage.TabIndex = 10
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_insert.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(597, 709)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(153, 35)
        Me.btn_insert.TabIndex = 11
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'pic_products
        '
        Me.pic_products.BackColor = System.Drawing.SystemColors.Control
        Me.pic_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_products.Location = New System.Drawing.Point(1045, 453)
        Me.pic_products.Name = "pic_products"
        Me.pic_products.Size = New System.Drawing.Size(245, 237)
        Me.pic_products.TabIndex = 12
        Me.pic_products.TabStop = False
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_picture.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.Location = New System.Drawing.Point(775, 630)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(128, 32)
        Me.btn_picture.TabIndex = 13
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'txt_picture
        '
        Me.txt_picture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_picture.Location = New System.Drawing.Point(775, 666)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(252, 24)
        Me.txt_picture.TabIndex = 14
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(53, 534)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(133, 22)
        Me.lbl_name.TabIndex = 15
        Me.lbl_name.Text = "Product Name :"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(53, 483)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(107, 22)
        Me.lbl_id.TabIndex = 16
        Me.lbl_id.Text = "Product ID :"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(53, 586)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(112, 22)
        Me.lbl_price.TabIndex = 17
        Me.lbl_price.Text = "Price (RM) :"
        '
        'lbl_weight
        '
        Me.lbl_weight.AutoSize = True
        Me.lbl_weight.BackColor = System.Drawing.Color.Transparent
        Me.lbl_weight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_weight.Location = New System.Drawing.Point(628, 534)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(122, 22)
        Me.lbl_weight.TabIndex = 18
        Me.lbl_weight.Text = "Weight (KG) :"
        '
        'lbl_storage
        '
        Me.lbl_storage.AutoSize = True
        Me.lbl_storage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_storage.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_storage.Location = New System.Drawing.Point(53, 639)
        Me.lbl_storage.Name = "lbl_storage"
        Me.lbl_storage.Size = New System.Drawing.Size(81, 22)
        Me.lbl_storage.TabIndex = 19
        Me.lbl_storage.Text = "Storage :"
        '
        'lbl_supplierid
        '
        Me.lbl_supplierid.AutoSize = True
        Me.lbl_supplierid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_supplierid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_supplierid.Location = New System.Drawing.Point(628, 586)
        Me.lbl_supplierid.Name = "lbl_supplierid"
        Me.lbl_supplierid.Size = New System.Drawing.Size(114, 22)
        Me.lbl_supplierid.TabIndex = 20
        Me.lbl_supplierid.Text = "Supplier ID :"
        '
        'lbl_categoryid
        '
        Me.lbl_categoryid.AutoSize = True
        Me.lbl_categoryid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_categoryid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoryid.Location = New System.Drawing.Point(628, 483)
        Me.lbl_categoryid.Name = "lbl_categoryid"
        Me.lbl_categoryid.Size = New System.Drawing.Size(117, 22)
        Me.lbl_categoryid.TabIndex = 21
        Me.lbl_categoryid.Text = "Category ID :"
        '
        'lbl_picture
        '
        Me.lbl_picture.AutoSize = True
        Me.lbl_picture.BackColor = System.Drawing.Color.Transparent
        Me.lbl_picture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_picture.Location = New System.Drawing.Point(628, 639)
        Me.lbl_picture.Name = "lbl_picture"
        Me.lbl_picture.Size = New System.Drawing.Size(77, 22)
        Me.lbl_picture.TabIndex = 22
        Me.lbl_picture.Text = "Picture :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_insertproducts_a176426
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_vegefruitgarden_a176426.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1346, 786)
        Me.Controls.Add(Me.lbl_picture)
        Me.Controls.Add(Me.lbl_categoryid)
        Me.Controls.Add(Me.lbl_supplierid)
        Me.Controls.Add(Me.lbl_storage)
        Me.Controls.Add(Me.lbl_weight)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.pic_products)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_storage)
        Me.Controls.Add(Me.txt_supplierid)
        Me.Controls.Add(Me.txt_categoryid)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.lbl_insert)
        Me.Controls.Add(Me.lbl_title)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(1364, 833)
        Me.Name = "frm_insertproducts_a176426"
        Me.Text = "VegeFruit Garden - Insert Products"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_insert As Label
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_categoryid As TextBox
    Friend WithEvents txt_supplierid As TextBox
    Friend WithEvents txt_storage As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents pic_products As PictureBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_weight As Label
    Friend WithEvents lbl_storage As Label
    Friend WithEvents lbl_supplierid As Label
    Friend WithEvents lbl_categoryid As Label
    Friend WithEvents lbl_picture As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
