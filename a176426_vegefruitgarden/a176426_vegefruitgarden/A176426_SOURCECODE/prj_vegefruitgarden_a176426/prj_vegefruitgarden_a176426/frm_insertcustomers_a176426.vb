Public Class frm_insertcustomers_a176426
    Private Sub frm_insertcustomers_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_id.Text = generate_id()
        refresh_grid()

    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUST_ID) AS LASTID FROM TBL_CUSTOMER_A176426").Rows(0).Item("LASTID")
        'MsgBox(lastid)
        Dim newid As String = "CU" & Mid(lastid, 3) + 1
        Return newid

    End Function

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A176426"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customers.DataSource = mydatatable


        grd_customers.Columns(0).HeaderText = "CUSTOMER ID"
        grd_customers.Columns(1).HeaderText = "CUSTOMER NAME"


    End Sub

    Private Sub clear_fields()

        txt_id.Text = generate_id()

        txt_name.Text = ""


    End Sub




    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A176426 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)


        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()
            txt_id.Text = generate_id()

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try


    End Sub
End Class