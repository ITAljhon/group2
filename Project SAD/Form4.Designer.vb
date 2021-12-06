<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.middleName = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.employeeID = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.confirmPassword = New System.Windows.Forms.TextBox()
        Me.Register = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HidePassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Username:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Confirm password:"
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(141, 56)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(152, 23)
        Me.FirstName.TabIndex = 8
        '
        'middleName
        '
        Me.middleName.Location = New System.Drawing.Point(440, 56)
        Me.middleName.Name = "middleName"
        Me.middleName.Size = New System.Drawing.Size(130, 23)
        Me.middleName.TabIndex = 9
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(141, 98)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(152, 23)
        Me.LastName.TabIndex = 10
        '
        'employeeID
        '
        Me.employeeID.Location = New System.Drawing.Point(440, 100)
        Me.employeeID.Name = "employeeID"
        Me.employeeID.Size = New System.Drawing.Size(130, 23)
        Me.employeeID.TabIndex = 11
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(141, 170)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(152, 23)
        Me.username.TabIndex = 12
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(141, 213)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(152, 23)
        Me.password.TabIndex = 13
        Me.password.UseSystemPasswordChar = True
        '
        'confirmPassword
        '
        Me.confirmPassword.Location = New System.Drawing.Point(141, 254)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(152, 23)
        Me.confirmPassword.TabIndex = 14
        Me.confirmPassword.UseSystemPasswordChar = True
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(265, 306)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(75, 23)
        Me.Register.TabIndex = 15
        Me.Register.Text = "Sign up"
        Me.Register.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign Up"
        '
        'HidePassword
        '
        Me.HidePassword.AutoSize = True
        Me.HidePassword.Checked = True
        Me.HidePassword.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HidePassword.Location = New System.Drawing.Point(328, 215)
        Me.HidePassword.Name = "HidePassword"
        Me.HidePassword.Size = New System.Drawing.Size(51, 19)
        Me.HidePassword.TabIndex = 16
        Me.HidePassword.Text = "Hide"
        Me.HidePassword.UseVisualStyleBackColor = True
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 357)
        Me.Controls.Add(Me.HidePassword)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.confirmPassword)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.employeeID)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.middleName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Signup"
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FirstName As TextBox
    Friend WithEvents middleName As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents employeeID As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents confirmPassword As TextBox
    Friend WithEvents Register As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents HidePassword As CheckBox
End Class
