Public Class frm_updateproducts_a176426

    Dim current_code As String
    Private Sub frm_updateproducts_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176426"
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

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_categoryid.Text = ""
        txt_weight.Text = ""
        txt_supplierid.Text = ""
        txt_storage.Text = ""

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_code = grd_products(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_categoryid.Text = grd_products(3, current_row).Value
        txt_weight.Text = grd_products(4, current_row).Value
        txt_supplierid.Text = grd_products(5, current_row).Value
        txt_storage.Text = grd_products(6, current_row).Value

    End Sub

    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick
        get_current_code()
    End Sub

    Private Sub grd_products_KeyDown(sender As Object, e As KeyEventArgs) Handles grd_products.KeyDown
        get_current_code()
    End Sub

    Private Sub grd_products_KeyUp(sender As Object, e As KeyEventArgs) Handles grd_products.KeyUp
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A176426 SET FLD_PRODUCT_NAME='" & txt_name.Text & "' WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A176426 SET FLD_PRICE=" & txt_price.Text & " WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A176426 SET FLD_CATEGORY_ID='" & txt_categoryid.Text & "' WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A176426 SET FLD_WEIGHT_KG=" & txt_weight.Text & " WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A176426 SET FLD_SUPPLIER_ID='" & txt_supplierid.Text & "' WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A176426 SET FLD_STORAGE='" & txt_storage.Text & "' WHERE FLD_PRODUCT_ID ='" & current_code & "'")


        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCTS_A176426 WHERE FLD_PRODUCT_ID='" & current_code & "'")


            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub
End Class