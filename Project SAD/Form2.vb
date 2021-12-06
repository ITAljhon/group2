Imports MySql.Data.MySqlClient
Public Class Employee

    Dim table As New DataTable()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim bindingSource As New BindingSource
            Dim adapter As New MySqlDataAdapter("SELECT * FROM `transactions` WHERE Last_Name='" & EmployeeLastName.Text & "' and `First Name` ='" & EmployeeFirstName.Text & "'", con)

            adapter.Fill(table)
            bindingSource.DataSource = table

            Home.DataSource = bindingSource
            adapter.Update(table)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ListItems.Click
        DefaultTable.BackColor = Color.Gainsboro
        RequestForm.BackColor = Color.Gainsboro
        ListItems.BackColor = Color.DarkGray
        Home.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        SearchBox.Visible = False
        ItemsAvailable.Visible = True
        table.Rows.Clear()
        table.Columns.Clear()


        Try
            Dim bindingSource As New BindingSource
            Dim adapter As New MySqlDataAdapter("SELECT * FROM `items`", con)

            adapter.Fill(table)
            bindingSource.DataSource = table

            ItemsAvailable.DataSource = bindingSource
            adapter.Update(table)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DefaultTable.Click
        ListItems.BackColor = Color.Gainsboro
        RequestForm.BackColor = Color.Gainsboro
        DefaultTable.BackColor = Color.DarkGray
        Label7.Visible = False
        Label8.Visible = False
        ItemsAvailable.Visible = True
        SearchBox.Visible = True
        Home.Visible = True
        table.Rows.Clear()
        table.Columns.Clear()

        Try
            Dim bindingSource As New BindingSource
            Dim adapter As New MySqlDataAdapter("SELECT * FROM `transactions` WHERE Last_Name='" & EmployeeLastName.Text & "' and `First Name` ='" & EmployeeFirstName.Text & "'", con)

            adapter.Fill(table)
            bindingSource.DataSource = table

            Home.DataSource = bindingSource
            adapter.Update(table)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Dim DV As New DataView(table)
        DV.RowFilter = String.Format("CONVERT([Transaction ID], 'System.String') like '%{0}%'", SearchBox.Text)
        Home.DataSource = DV
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Logout.Click
        con.Close()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub RequestForm_Click(sender As Object, e As EventArgs) Handles RequestForm.Click
        ListItems.BackColor = Color.Gainsboro
        DefaultTable.BackColor = Color.Gainsboro
        RequestForm.BackColor = Color.DarkGray
        ItemsAvailable.Visible = False
        Home.Visible = False
        SearchBox.Visible = False
        Label7.Visible = True
        Label8.Visible = True
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        If Items.Text = Nothing OrElse timeFormat.Text = Nothing OrElse dateFormat.Text = Nothing OrElse EmployeeID.Text = Nothing Then
            MsgBox("Error: There are empty fields")
        Else
            Try
                openCon()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `transactions`(`employee_id`, `First Name`, `Last_Name`, `Item`, `Time`, `Date`) VALUES ('" & EmployeeID.Text & "', '" & EmployeeFirstName.Text & "','" & EmployeeLastName.Text & "',
                                        '" & Items.Text & "','" & timeFormat.Text & "','" & dateFormat.Text & "')"
                cmd.ExecuteReader()
                MsgBox("Successfully registered!")
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub
End Class