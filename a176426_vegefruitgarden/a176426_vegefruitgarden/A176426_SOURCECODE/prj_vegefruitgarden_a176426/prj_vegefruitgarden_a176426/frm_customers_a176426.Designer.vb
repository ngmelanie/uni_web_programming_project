<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customers_a176426
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_customers = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_customers = New System.Windows.Forms.Label()
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(36, 32)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(115, 30)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_customers
        '
        Me.grd_customers.AllowUserToAddRows = False
        Me.grd_customers.AllowUserToDeleteRows = False
        Me.grd_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_customers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_customers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customers.Location = New System.Drawing.Point(46, 164)
        Me.grd_customers.Name = "grd_customers"
        Me.grd_customers.ReadOnly = True
        Me.grd_customers.RowHeadersWidth = 51
        Me.grd_customers.RowTemplate.Height = 24
        Me.grd_customers.Size = New System.Drawing.Size(710, 209)
        Me.grd_customers.TabIndex = 1
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Monotype Corsiva", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(257, 32)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(317, 52)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "VegeFruit Garden"
        '
        'lbl_customers
        '
        Me.lbl_customers.AutoSize = True
        Me.lbl_customers.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customers.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customers.Location = New System.Drawing.Point(302, 85)
        Me.lbl_customers.Name = "lbl_customers"
        Me.lbl_customers.Size = New System.Drawing.Size(213, 33)
        Me.lbl_customers.TabIndex = 3
        Me.lbl_customers.Text = "- CUSTOMERS -"
        '
        'frm_customers_a176426
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_vegefruitgarden_a176426.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_customers)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_customers)
        Me.Controls.Add(Me.btn_back)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.Name = "frm_customers_a176426"
        Me.Text = "VegeFruit Garden - Customers"
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents grd_customers As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_customers As Label
End Class
