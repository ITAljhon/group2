Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            openCon()
            cmd.Connection = con
            Dim READER As MySqlDataReader
            Dim count As Integer
            count = 0
            cmd.CommandText = "SELECT * FROM `employee` WHERE username='" & username.Text & "' and password ='" & password.Text & "'"
            READER = cmd.ExecuteReader

            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MsgBox("Successfully logged in")
                Employee.EmployeeFirstName.Text = READER("first_name")
                Employee.EmployeeLastName.Text = READER("last_name")
                Employee.EID.Text = READER("employee_id")
                READER.Close()
                Employee.Show()
                Me.Close()
            ElseIf count > 1 Then
                MsgBox("Username and password are duplicate")
            Else
                Try
                    con.Close()
                    openCon()
                    cmd.Connection = con
                    count = 0
                    cmd.CommandText = "SELECT * FROM `admin` WHERE username='" & username.Text & "' and password ='" & password.Text & "'"
                    READER = cmd.ExecuteReader

                    While READER.Read
                        count = count + 1
                    End While

                    If count = 1 Then
                        MsgBox("Successfully logged in")
                        READER.Close()
                        Admin.Show()
                        Me.Close()
                    ElseIf count > 1 Then
                        MsgBox("Username and password are duplicate")
                    Else
                        MsgBox("Username and password are incorrect")
                    End If
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Signup.Show()
    End Sub
End Class
