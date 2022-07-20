Public Class frm_mainmenu_a176426

    Private Sub frm_mainmenu_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click

        frm_products_a176426.Show()
        'Me.Hide()

    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click

        frm_orders_a176426.Show()


    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        frm_customers_a176426.Show()

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a176426.Show()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_catalog_Click(sender As Object, e As EventArgs) Handles btn_catalog.Click
        frm_productcatalog_a176426.Show()

    End Sub

    Private Sub btn_insertproducts_Click(sender As Object, e As EventArgs) Handles btn_insertproducts.Click
        frm_insertproducts_a176426.Show()

    End Sub

    Private Sub btn_insertstaff_Click(sender As Object, e As EventArgs) Handles btn_insertstaff.Click
        frm_insertstaff_a176426.Show()

    End Sub

    Private Sub btn_insertcustomers_Click(sender As Object, e As EventArgs) Handles btn_insertcustomers.Click
        frm_insertcustomers_a176426.Show()

    End Sub

    Private Sub btn_updateproducts_Click(sender As Object, e As EventArgs) Handles btn_updateproducts.Click
        frm_updateproducts_a176426.Show()

    End Sub

    Private Sub btn_updatecustomers_Click(sender As Object, e As EventArgs) Handles btn_updatecustomers.Click
        frm_updatecustomers_a176426.Show()

    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click
        frm_updatestaff_a176426.Show()

    End Sub

    Private Sub btn_makeorders_Click(sender As Object, e As EventArgs) Handles btn_makeorders.Click
        frm_makeorders_a176426.Show()

    End Sub

    Private Sub btn_vieworders_Click(sender As Object, e As EventArgs) Handles btn_vieworders.Click
        frm_vieworders_a176426.Show()
    End Sub
End Class