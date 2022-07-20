Public Class frm_orders_a176426
    Private Sub frm_orders_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A176426"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_orders.DataSource = mydatatable

        refresh_grid()

    End Sub

    Private Sub refresh_grid()
        grd_orders.Columns(0).HeaderText = "ORDER ID"
        grd_orders.Columns(1).HeaderText = "ORDER DATE"
        grd_orders.Columns(2).HeaderText = "PRODUCT ID"
        grd_orders.Columns(3).HeaderText = "CUSTOMER ID"
        grd_orders.Columns(3).HeaderText = "STAFF ID"
        grd_orders.Columns(3).HeaderText = "PRODUCT NAME"
        grd_orders.Columns(3).HeaderText = "PRICE"
        grd_orders.Columns(3).HeaderText = "ORDER QUANITY"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub
End Class