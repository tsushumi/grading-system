<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayrollForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.HoursWorkedTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PayRateTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrossPayTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Name"
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(134, 12)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(158, 23)
        Me.EmployeeNameTextBox.TabIndex = 1
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(57, 184)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(75, 23)
        Me.ComputeButton.TabIndex = 2
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'HoursWorkedTextBox
        '
        Me.HoursWorkedTextBox.Location = New System.Drawing.Point(134, 54)
        Me.HoursWorkedTextBox.Name = "HoursWorkedTextBox"
        Me.HoursWorkedTextBox.Size = New System.Drawing.Size(158, 23)
        Me.HoursWorkedTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hours Worked"
        '
        'PayRateTextBox
        '
        Me.PayRateTextBox.Location = New System.Drawing.Point(134, 87)
        Me.PayRateTextBox.Name = "PayRateTextBox"
        Me.PayRateTextBox.Size = New System.Drawing.Size(158, 23)
        Me.PayRateTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pay Rate"
        '
        'GrossPayTextBox
        '
        Me.GrossPayTextBox.Location = New System.Drawing.Point(134, 116)
        Me.GrossPayTextBox.Name = "GrossPayTextBox"
        Me.GrossPayTextBox.Size = New System.Drawing.Size(158, 23)
        Me.GrossPayTextBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gross Pay"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(194, 184)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 254)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GrossPayTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PayRateTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HoursWorkedTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PayrollForm"
        Me.Text = "PayrollForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents HoursWorkedTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PayRateTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GrossPayTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ExitButton As Button
End Class
