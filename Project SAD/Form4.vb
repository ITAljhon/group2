Public Class Signup
    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        If FirstName.Text = Nothing OrElse LastName.Text = Nothing OrElse middleName.Text = Nothing OrElse employeeID.Text = Nothing OrElse
            username.Text = Nothing OrElse password.Text = Nothing OrElse confirmPassword.Text = Nothing Then

            MsgBox("Error: Empty Fields")
        Else
            If password.Text = confirmPassword.Text Then
                Try
                    openCon()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO `employee`(`employee_id`, `first_name`, `middle_name`, `last_name`, `username`, `password`) VALUES ('" & employeeID.Text & "', '" & FirstName.Text & "','" & middleName.Text & "',
                                        '" & LastName.Text & "','" & username.Text & "','" & password.Text & "')"
                    cmd.ExecuteReader()
                    MsgBox("Successfully registered!")
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            Else
                MsgBox("Error: Password does not match")
            End If
        End If

    End Sub

    Private Sub HidePassword_CheckedChanged(sender As Object, e As EventArgs) Handles HidePassword.CheckedChanged
        If HidePassword.Checked = True Then
            password.UseSystemPasswordChar = True
            confirmPassword.UseSystemPasswordChar = True
        Else
            password.UseSystemPasswordChar = False
            confirmPassword.UseSystemPasswordChar = False
        End If
    End Sub
End Class