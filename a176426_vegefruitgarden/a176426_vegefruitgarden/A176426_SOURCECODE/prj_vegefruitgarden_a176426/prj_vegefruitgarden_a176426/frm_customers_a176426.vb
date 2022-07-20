Public Class frm_customers_a176426

    Private Sub frm_customers_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A176426"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customers.DataSource = mydatatable

        refresh_grid()
    End Sub

    Private Sub refresh_grid()
        grd_customers.Columns(0).HeaderText = "CUSTOMER ID"
        grd_customers.Columns(1).HeaderText = "CUSTOMER NAME"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub


End Class