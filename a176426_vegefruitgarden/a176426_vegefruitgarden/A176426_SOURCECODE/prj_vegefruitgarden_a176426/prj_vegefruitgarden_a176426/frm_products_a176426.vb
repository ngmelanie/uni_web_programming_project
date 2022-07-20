Public Class frm_products_a176426

    Private Sub frm_products_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176426"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable

        refresh_grid()

    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176426 WHERE FLD_PRODUCT_NAME like '%" & txt_search.Text & "%'"

        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable

        grd_products.Columns(0).HeaderText = "PRODUCT ID"
        grd_products.Columns(1).HeaderText = "PRODUCT NAME"
        grd_products.Columns(2).HeaderText = "PRICE (RM)"
        grd_products.Columns(3).HeaderText = "CATEGORY ID"
        grd_products.Columns(4).HeaderText = "WEIGHT (KG)"
        grd_products.Columns(5).HeaderText = "SUPPLIER ID"
        grd_products.Columns(6).HeaderText = "STORAGE"

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        refresh_grid()
    End Sub




End Class