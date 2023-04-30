<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AverageMarksForm
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Marks2TextBox = New System.Windows.Forms.TextBox()
        Me.Marks1TextBox = New System.Windows.Forms.TextBox()
        Me.Marks3TextBox = New System.Windows.Forms.TextBox()
        Me.Marks4TextBox = New System.Windows.Forms.TextBox()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter students name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(261, 21)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(141, 23)
        Me.NameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter students grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Subject 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Subject 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Subject 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Subject 4:"
        '
        'Marks2TextBox
        '
        Me.Marks2TextBox.Location = New System.Drawing.Point(261, 163)
        Me.Marks2TextBox.Name = "Marks2TextBox"
        Me.Marks2TextBox.Size = New System.Drawing.Size(141, 23)
        Me.Marks2TextBox.TabIndex = 7
        '
        'Marks1TextBox
        '
        Me.Marks1TextBox.Location = New System.Drawing.Point(261, 115)
        Me.Marks1TextBox.Name = "Marks1TextBox"
        Me.Marks1TextBox.Size = New System.Drawing.Size(141, 23)
        Me.Marks1TextBox.TabIndex = 7
        '
        'Marks3TextBox
        '
        Me.Marks3TextBox.Location = New System.Drawing.Point(261, 214)
        Me.Marks3TextBox.Name = "Marks3TextBox"
        Me.Marks3TextBox.Size = New System.Drawing.Size(141, 23)
        Me.Marks3TextBox.TabIndex = 8
        '
        'Marks4TextBox
        '
        Me.Marks4TextBox.Location = New System.Drawing.Point(261, 250)
        Me.Marks4TextBox.Name = "Marks4TextBox"
        Me.Marks4TextBox.Size = New System.Drawing.Size(141, 23)
        Me.Marks4TextBox.TabIndex = 9
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(46, 317)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(77, 23)
        Me.ComputeButton.TabIndex = 10
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(270, 317)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(77, 23)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(482, 317)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(77, 23)
        Me.LoadButton.TabIndex = 12
        Me.LoadButton.TabStop = False
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'AverageMarksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.Marks4TextBox)
        Me.Controls.Add(Me.Marks3TextBox)
        Me.Controls.Add(Me.Marks1TextBox)
        Me.Controls.Add(Me.Marks2TextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AverageMarksForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Marks2TextBox As TextBox
    Friend WithEvents Marks1TextBox As TextBox
    Friend WithEvents Marks3TextBox As TextBox
    Friend WithEvents Marks4TextBox As TextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents LoadButton As Button
End Class
