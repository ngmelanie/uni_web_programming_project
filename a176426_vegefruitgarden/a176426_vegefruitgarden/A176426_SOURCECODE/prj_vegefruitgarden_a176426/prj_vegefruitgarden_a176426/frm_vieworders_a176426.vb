Imports System.ComponentModel

Public Class frm_vieworders_a176426
    Private Sub frm_vieworders_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A176426"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable


        cmb_orderid.DataSource = mydatatable
        cmb_orderid.DisplayMember = "fld_order_id"


        refresh_grid(cmb_orderid.Text)

    End Sub

    Private Sub refresh_grid(order_id As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A176426 WHERE FLD_ORDER_ID like '%" & order_id & "%'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable


        grd_order.Columns(0).HeaderText = "ORDER ID"
        grd_order.Columns(1).HeaderText = "ORDER DATE"
        grd_order.Columns(2).HeaderText = "PRODUCT ID"
        grd_order.Columns(3).HeaderText = "CUSTOMER ID"
        grd_order.Columns(4).HeaderText = "STAFF ID"
        grd_order.Columns(5).HeaderText = "PRODUCT NAME"
        grd_order.Columns(6).HeaderText = "PRICE"
        grd_order.Columns(7).HeaderText = "ORDER QUANITY"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub

    Private Sub cmb_orderid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_orderid.SelectedIndexChanged

        refresh_grid(cmb_orderid.Text)

        Dim ttl As Decimal
        If grd_order.RowCount + 1 Then
            For Each total As DataGridViewRow In grd_order.Rows
                ttl += total.Cells(6).Value * total.Cells(7).Value
            Next
            txt_total.Text = ttl

        End If



    End Sub


End Class