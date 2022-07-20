Public Class frm_insertproducts_a176426

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_insertproducts_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A176426")

        txt_id.Text = generate_id()

        txt_picture.Text = defaultpicture
        pic_products.BackgroundImage = Image.FromFile(defaultpicture)

        refresh_grid()
    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A176426").Rows(0).Item("LASTID")
        'MsgBox(lastid)
        Dim newid As String = "P0" & Mid(lastid, 3) + 1
        Return newid

    End Function

    Private Sub refresh_grid()
        grd_products.Columns(0).HeaderText = "PRODUCT ID"
        grd_products.Columns(1).HeaderText = "PRODUCT NAME"
        grd_products.Columns(2).HeaderText = "PRICE (RM)"
        grd_products.Columns(3).HeaderText = "CATEGORY ID"
        grd_products.Columns(4).HeaderText = "WEIGHT (KG)"
        grd_products.Columns(5).HeaderText = "SUPPLIER ID"
        grd_products.Columns(6).HeaderText = "STORAGE"

    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176426.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A176426 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', " & txt_price.Text & " , '" & txt_categoryid.Text & "', " & txt_weight.Text & ", '" & txt_supplierid.Text & "','" & txt_storage.Text & "')"


        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A176426")

            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_price.Text = ""
            txt_categoryid.Text = ""
            txt_weight.Text = ""
            txt_supplierid.Text = ""
            txt_storage.Text = ""
            txt_picture.Text = defaultpicture
            pic_products.BackgroundImage = Image.FromFile(defaultpicture)


        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()


        End Try
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg) | *.jpg"
        OpenFileDialog1.ShowDialog()

        pic_products.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub
End Class