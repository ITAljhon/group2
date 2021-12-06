<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.EmployeeFirstName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeLastName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.Button()
        Me.RequestForm = New System.Windows.Forms.Button()
        Me.ListItems = New System.Windows.Forms.Button()
        Me.DefaultTable = New System.Windows.Forms.Button()
        Me.EID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Home = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ItemsAvailable = New System.Windows.Forms.DataGridView()
        Me.Submit = New System.Windows.Forms.Button()
        Me.EmployeeID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dateFormat = New System.Windows.Forms.TextBox()
        Me.timeFormat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Items = New System.Windows.Forms.RichTextBox()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeFirstName
        '
        Me.EmployeeFirstName.AutoSize = True
        Me.EmployeeFirstName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmployeeFirstName.Location = New System.Drawing.Point(7, 29)
        Me.EmployeeFirstName.Name = "EmployeeFirstName"
        Me.EmployeeFirstName.Size = New System.Drawing.Size(119, 20)
        Me.EmployeeFirstName.TabIndex = 0
        Me.EmployeeFirstName.Text = "Employee Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.EmployeeLastName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.RequestForm)
        Me.Panel1.Controls.Add(Me.ListItems)
        Me.Panel1.Controls.Add(Me.DefaultTable)
        Me.Panel1.Controls.Add(Me.EID)
        Me.Panel1.Controls.Add(Me.EmployeeFirstName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 474)
        Me.Panel1.TabIndex = 1
        '
        'EmployeeLastName
        '
        Me.EmployeeLastName.AutoSize = True
        Me.EmployeeLastName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmployeeLastName.Location = New System.Drawing.Point(7, 9)
        Me.EmployeeLastName.Name = "EmployeeLastName"
        Me.EmployeeLastName.Size = New System.Drawing.Size(119, 20)
        Me.EmployeeLastName.TabIndex = 7
        Me.EmployeeLastName.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(7, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No."
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.Transparent
        Me.Logout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Logout.FlatAppearance.BorderSize = 0
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Location = New System.Drawing.Point(0, 399)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(75, 26)
        Me.Logout.TabIndex = 5
        Me.Logout.Text = " Log out"
        Me.Logout.UseVisualStyleBackColor = False
        '
        'RequestForm
        '
        Me.RequestForm.BackColor = System.Drawing.Color.Gainsboro
        Me.RequestForm.FlatAppearance.BorderSize = 0
        Me.RequestForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RequestForm.Location = New System.Drawing.Point(0, 245)
        Me.RequestForm.Name = "RequestForm"
        Me.RequestForm.Size = New System.Drawing.Size(200, 53)
        Me.RequestForm.TabIndex = 4
        Me.RequestForm.Text = "Request Item"
        Me.RequestForm.UseVisualStyleBackColor = False
        '
        'ListItems
        '
        Me.ListItems.BackColor = System.Drawing.Color.Gainsboro
        Me.ListItems.FlatAppearance.BorderSize = 0
        Me.ListItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListItems.Location = New System.Drawing.Point(0, 186)
        Me.ListItems.Name = "ListItems"
        Me.ListItems.Size = New System.Drawing.Size(198, 53)
        Me.ListItems.TabIndex = 3
        Me.ListItems.Text = "List of Item"
        Me.ListItems.UseVisualStyleBackColor = False
        '
        'DefaultTable
        '
        Me.DefaultTable.BackColor = System.Drawing.Color.DarkGray
        Me.DefaultTable.FlatAppearance.BorderSize = 0
        Me.DefaultTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DefaultTable.Location = New System.Drawing.Point(0, 127)
        Me.DefaultTable.Name = "DefaultTable"
        Me.DefaultTable.Size = New System.Drawing.Size(200, 53)
        Me.DefaultTable.TabIndex = 2
        Me.DefaultTable.Text = "Home"
        Me.DefaultTable.UseVisualStyleBackColor = False
        '
        'EID
        '
        Me.EID.AutoSize = True
        Me.EID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EID.Location = New System.Drawing.Point(30, 53)
        Me.EID.Name = "EID"
        Me.EID.Size = New System.Drawing.Size(24, 15)
        Me.EID.TabIndex = 1
        Me.EID.Text = "EID"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Home)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ItemsAvailable)
        Me.Panel2.Controls.Add(Me.Submit)
        Me.Panel2.Controls.Add(Me.EmployeeID)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dateFormat)
        Me.Panel2.Controls.Add(Me.timeFormat)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Items)
        Me.Panel2.Controls.Add(Me.SearchBox)
        Me.Panel2.Location = New System.Drawing.Point(198, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(732, 473)
        Me.Panel2.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(118, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "(Use the 24-Hour and yy/mm/dd formats)"
        Me.Label8.Visible = False
        '
        'Home
        '
        Me.Home.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Home.Location = New System.Drawing.Point(0, 56)
        Me.Home.Name = "Home"
        Me.Home.RowTemplate.Height = 25
        Me.Home.Size = New System.Drawing.Size(729, 417)
        Me.Home.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(118, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Note: Please specify Time and Date properly."
        Me.Label7.Visible = False
        '
        'ItemsAvailable
        '
        Me.ItemsAvailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemsAvailable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.ItemsAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsAvailable.Location = New System.Drawing.Point(0, 56)
        Me.ItemsAvailable.Name = "ItemsAvailable"
        Me.ItemsAvailable.RowTemplate.Height = 25
        Me.ItemsAvailable.Size = New System.Drawing.Size(729, 417)
        Me.ItemsAvailable.TabIndex = 1
        Me.ItemsAvailable.Visible = False
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(523, 350)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 12
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'EmployeeID
        '
        Me.EmployeeID.Location = New System.Drawing.Point(367, 350)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(79, 23)
        Me.EmployeeID.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(367, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Employee ID"
        '
        'dateFormat
        '
        Me.dateFormat.Location = New System.Drawing.Point(234, 350)
        Me.dateFormat.Name = "dateFormat"
        Me.dateFormat.Size = New System.Drawing.Size(79, 23)
        Me.dateFormat.TabIndex = 9
        '
        'timeFormat
        '
        Me.timeFormat.Location = New System.Drawing.Point(118, 350)
        Me.timeFormat.Name = "timeFormat"
        Me.timeFormat.Size = New System.Drawing.Size(79, 23)
        Me.timeFormat.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(234, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(118, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(118, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Items to be borrowed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(83, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lending Form"
        '
        'Items
        '
        Me.Items.Location = New System.Drawing.Point(118, 167)
        Me.Items.Name = "Items"
        Me.Items.Size = New System.Drawing.Size(480, 131)
        Me.Items.TabIndex = 3
        Me.Items.Text = ""
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(6, 21)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.PlaceholderText = "Search with Transaction ID..."
        Me.SearchBox.Size = New System.Drawing.Size(223, 23)
        Me.SearchBox.TabIndex = 2
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 474)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmployeeFirstName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Home As DataGridView
    Friend WithEvents EID As Label
    Friend WithEvents RequestForm As Button
    Friend WithEvents ListItems As Button
    Friend WithEvents DefaultTable As Button
    Friend WithEvents ItemsAvailable As DataGridView
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Logout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeLastName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Items As RichTextBox
    Friend WithEvents Submit As Button
    Friend WithEvents EmployeeID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dateFormat As TextBox
    Friend WithEvents timeFormat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
