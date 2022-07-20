Public Class frm_makeorders_a176426


    Private Sub frm_makeorders_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        Dim mysql As String = "select fld_product_name from tbl_products_a176426 order by fld_product_name"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mytable)


        grd_neworder.ColumnCount = grd_order.ColumnCount
        For i = 0 To grd_neworder.ColumnCount - 1
            grd_neworder.Columns(i).HeaderText = grd_order.Columns(i).HeaderText
        Next

        cmb_staffid.DataSource = run_sql_query("select fld_staff_id from tbl_staff_a176426 order by fld_staff_id")
        cmb_staffid.DisplayMember = "FLD_STAFF_ID"

        cmb_custid.DataSource = run_sql_query("select fld_cust_id from tbl_customer_a176426 order by fld_cust_id")
        cmb_custid.DisplayMember = "FLD_CUST_ID"

        txt_orderid.Text = generate_id()

        'refer to the list
        lst_product.DataSource = mytable
        lst_product.DisplayMember = "fld_product_name"

        refresh_text(lst_product.Text)




    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub

    Private Sub refresh_grid()
        grd_order.DataSource = run_sql_query("SELECT * FROM TBL_ORDER_A176426")

        grd_order.Columns(0).HeaderText = "ORDER ID"
        grd_order.Columns(1).HeaderText = "ORDER DATE"
        grd_order.Columns(2).HeaderText = "PRODUCT ID"
        grd_order.Columns(3).HeaderText = "CUSTOMER ID"
        grd_order.Columns(4).HeaderText = "STAFF ID"
        grd_order.Columns(5).HeaderText = "PRODUCT NAME"
        grd_order.Columns(6).HeaderText = "PRICE (RM)"
        grd_order.Columns(7).HeaderText = "QUANTITY"

    End Sub

    Private Sub btn_addline_Click(sender As Object, e As EventArgs) Handles btn_addline.Click
        grd_neworder.RowCount = grd_neworder.RowCount + 1
        Dim current_row As Integer = grd_neworder.RowCount - 1

        grd_neworder(0, current_row).Value = txt_orderid.Text
        grd_neworder(1, current_row).Value = dte_orderdate.Text
        grd_neworder(2, current_row).Value = txt_productid.Text
        grd_neworder(3, current_row).Value = cmb_custid.Text
        grd_neworder(4, current_row).Value = cmb_staffid.Text
        grd_neworder(5, current_row).Value = txt_product.Text
        grd_neworder(6, current_row).Value = txt_price.Text
        grd_neworder(7, current_row).Value = txt_quantity.Text


        'for the subtotal
        If grd_neworder.RowCount > 0 Then
            Dim sbttls As Double
            sbttls = 0

            For index As Integer = 0 To grd_neworder.RowCount - 1
                sbttls += grd_neworder.Rows(index).Cells(6).Value * grd_neworder.Rows(index).Cells(7).Value
            Next

            txt_subtotal.Text = sbttls
        ElseIf grd_neworder.RowCount = 0 Then

            txt_subtotal.Text = "RM 0.00"
        End If


        'for the Grand Total
        If grd_order.RowCount > 0 Then
            Dim ttl As Double
            ttl = 0

            For index As Integer = 0 To grd_order.RowCount - 1
                ttl += grd_order.Rows(index).Cells(6).Value * grd_order.Rows(index).Cells(7).Value
            Next

            txt_total.Text = ttl
        ElseIf grd_order.RowCount = 0 Then

            txt_total.Text = "RM 0.00"
        End If



    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click

        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction

        Try
            For i As Integer = 0 To grd_neworder.RowCount - 1

                Dim orderid As String = grd_neworder(0, i).Value
                Dim orderdate As String = grd_neworder(1, i).Value
                Dim productid As String = grd_neworder(2, i).Value
                Dim custid As String = grd_neworder(3, i).Value
                Dim staffid As String = grd_neworder(4, i).Value
                Dim product As String = grd_neworder(5, i).Value
                Dim price As String = grd_neworder(6, i).Value
                Dim quantity As String = grd_neworder(7, i).Value
                Dim mysql As String = "INSERT INTO TBL_ORDER_A176426 VALUES ('" & orderid & "','" & orderdate & "','" & productid & "', '" & custid & "','" & staffid & "','" & product & "'," & price & "," & quantity & ")"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                mywriter.ExecuteNonQuery()

            Next

            mytransaction.Commit()
            myconnection2.Close()

            Beep()
            MsgBox("Transaction successful!")
            refresh_grid()
            grd_neworder.Rows.Clear()
            txt_orderid.Text = generate_id()

        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        'mytransaction.Commit()
        ' myconnection2.Close()


    End Sub




    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A176426").Rows(0).Item("LASTID")
        Dim newid As String = "OD" & Mid(lastid, 3) + 1
        Return newid

    End Function

    Private Sub refresh_text(product As String)

        Dim mysql As String = "select * from tbl_products_a176426 where fld_product_name='" & product & "'"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mytable)
        txt_productid.Text = mytable.Rows(0).Item("fld_product_id")
        txt_product.Text = mytable.Rows(0).Item("fld_product_name")
        txt_price.Text = mytable.Rows(0).Item("fld_price")

        txt_orderid.Text = generate_id()

    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)
    End Sub
    Private Sub lst_product_KeyUp(sender As Object, e As KeyEventArgs) Handles lst_product.KeyUp
        refresh_text(lst_product.Text)
    End Sub
    Private Sub lst_product_KeyDown(sender As Object, e As KeyEventArgs) Handles lst_product.KeyDown
        refresh_text(lst_product.Text)
    End Sub

    Private Sub grd_neworder_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grd_neworder.UserDeletedRow
        Dim sbttl As Decimal
        If grd_neworder.RowCount + 1 Then
            For Each subtotal As DataGridViewRow In grd_neworder.Rows
                sbttl += subtotal.Cells(6).Value * subtotal.Cells(7).Value
            Next
            txt_subtotal.Text = sbttl

        End If


    End Sub

    Private Sub grd_neworder_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grd_neworder.RowsRemoved
        Dim sbttl As Decimal
        If grd_neworder.RowCount + 1 Then
            For Each subtotal As DataGridViewRow In grd_neworder.Rows
                sbttl += subtotal.Cells(6).Value * subtotal.Cells(7).Value
            Next
            txt_subtotal.Text = sbttl

        End If
    End Sub

    Private Sub grd_order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_order.CellContentClick

    End Sub

    Private Sub grd_order_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grd_order.RowsRemoved

        Dim ttl As Decimal
        If grd_order.RowCount + 1 Then
            For Each total As DataGridViewRow In grd_order.Rows
                ttl += total.Cells(6).Value * total.Cells(7).Value
            Next
            txt_total.Text = ttl

        End If



    End Sub

    Private Sub grd_order_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grd_order.UserDeletedRow

        Dim ttl As Decimal
        If grd_order.RowCount + 1 Then
            For Each total As DataGridViewRow In grd_order.Rows
                ttl += total.Cells(6).Value * total.Cells(7).Value
            Next
            txt_total.Text = ttl

        End If


    End Sub
End Class