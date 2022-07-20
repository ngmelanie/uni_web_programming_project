Public Class frm_updatestaff_a176426

    Dim current_code As String
    Private Sub frm_updatestaff_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_code()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A176426"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "STAFF NAME"



    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_code = grd_staff(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_staff(1, current_row).Value


    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_code()
    End Sub

    Private Sub grd_staff_KeyUp(sender As Object, e As KeyEventArgs) Handles grd_staff.KeyUp
        get_current_code()
    End Sub

    Private Sub grd_staff_KeyDown(sender As Object, e As KeyEventArgs) Handles grd_staff.KeyDown
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFF_A176426 SET FLD_STAFF_NAME='" & txt_name.Text & "' WHERE FLD_STAFF_ID ='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the staff """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A176426 WHERE FLD_STAFF_ID='" & current_code & "'")


            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub
End Class