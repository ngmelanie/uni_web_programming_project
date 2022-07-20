Public Class frm_productcatalog_a176426
    Private Sub frm_productcatalog_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A176426"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_id.Text)

    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176426 WHERE FLD_PRODUCT_ID='" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_categoryid.Text = mydatatable.Rows(0).Item("FLD_CATEGORY_ID")
        txt_weight.Text = mydatatable.Rows(0).Item("FLD_WEIGHT_KG")
        txt_supplierid.Text = mydatatable.Rows(0).Item("FLD_SUPPLIER_ID")
        txt_storage.Text = mydatatable.Rows(0).Item("FLD_STORAGE")


        Try
            pic_products.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

        Catch ex As Exception
            pic_products.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

        End Try


    End Sub


    Private Sub lst_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_id.MouseClick

        refresh_text(lst_id.Text)

    End Sub

    Private Sub lst_id_KeyUp(sender As Object, e As KeyEventArgs) Handles lst_id.KeyUp
        refresh_text(lst_id.Text)
    End Sub

    Private Sub lst_id_KeyDown(sender As Object, e As KeyEventArgs) Handles lst_id.KeyDown
        refresh_text(lst_id.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub


End Class