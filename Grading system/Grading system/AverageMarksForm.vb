Public Class AverageMarksForm


    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Try
            Dim TotalMarksDouble, AverageDouble, Marks1Double, Marks2Double, Marks3Double, Marks4Double As Double
            Dim DisplayString, Display2String As String

            If NameTextBox.Text.Trim = String.Empty Then
                MessageBox.Show("Name is required", "Name is missing Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                NameTextBox.Focus()
                NameTextBox.SelectAll()

            ElseIf IsNumeric(Marks1TextBox.Text) = False OrElse (Double.Parse(Marks1TextBox.Text,
              Globalization.NumberStyles.Number) < 0R Or (Double.Parse(Marks1TextBox.Text,
              Globalization.NumberStyles.Number)) > 100) Then

                MessageBox.Show("Subject 1 value must be numeric between 0 and 100", "Grade value Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                Marks1TextBox.Focus()
                Marks1TextBox.SelectAll()

            ElseIf IsNumeric(Marks2TextBox.Text) = False OrElse (Double.Parse(Marks2TextBox.Text,
               Globalization.NumberStyles.Number) < 0R Or (Double.Parse(Marks2TextBox.Text,
               Globalization.NumberStyles.Number)) > 100) Then

                MessageBox.Show("Subject 2 value must be numeric between 0 and 100", "Grade value Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                Marks2TextBox.Focus()
                Marks2TextBox.SelectAll()
            ElseIf IsNumeric(Marks3TextBox.Text) = False OrElse (Double.Parse(Marks3TextBox.Text,
               Globalization.NumberStyles.Number) < 0R Or (Double.Parse(Marks3TextBox.Text,
               Globalization.NumberStyles.Number)) > 100) Then

                MessageBox.Show("Subject 3 value must be numeric between 0 and 100", "Grade value Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)

                Marks3TextBox.Focus()
                Marks3TextBox.SelectAll()

            ElseIf IsNumeric(Marks4TextBox.Text) = False OrElse (Double.Parse(Marks4TextBox.Text,
             Globalization.NumberStyles.Number) < 0R Or (Double.Parse(Marks4TextBox.Text,
             Globalization.NumberStyles.Number)) > 100I) Then

                MessageBox.Show("Subject 4 value must be numeric between 0 and 100", "Grade value Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                Marks4TextBox.Focus()
                Marks4TextBox.SelectAll()
            Else

                Marks1Double = Double.Parse(Marks1TextBox.Text,
                   Globalization.NumberStyles.Number)
                Marks2Double = Double.Parse(Marks2TextBox.Text,
                   Globalization.NumberStyles.Number)
                Marks3Double = Double.Parse(Marks3TextBox.Text,
                   Globalization.NumberStyles.Number)
                Marks4Double = Double.Parse(Marks4TextBox.Text,
                   Globalization.NumberStyles.Number)


                TotalMarksDouble = Marks1Double + Marks2Double + Marks3Double + Marks4Double
                AverageDouble = TotalMarksDouble / 4
                DisplayString = NameTextBox.Text & ControlChars.NewLine & "Total Marks: " &
                                        TotalMarksDouble.ToString("N2") & ControlChars.NewLine &
                                        "Average Mark is: " & AverageDouble
                Display2String = "Final Grade is: "

                If AverageDouble < 50 Then
                    MessageBox.Show(DisplayString & ControlChars.NewLine & "Failed", "Final Grade Value",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf AverageDouble < 65 Then
                    MessageBox.Show(DisplayString & ControlChars.NewLine & Display2String & " C", "Final Grade Value",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf AverageDouble < 75 Then
                    MessageBox.Show(DisplayString & ControlChars.NewLine & Display2String & "B", "Final Grade Value",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(DisplayString & ControlChars.NewLine & Display2String & "A", "Final Grade Value",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                '                Select Case AverageDouble
                '               Case 0 To 49
                '              MessageBox.Show(DisplayString & ControlChars.NewLine & "Failed", "Final Grade Value",
                '             MessageBoxButtons.OK, MessageBoxIcon.Information)
                '            Case 50 To 64
                '           MessageBox.Show(DisplayString & ControlChars.NewLine & Display2String & " C", "Final Grade Value",
                '          MessageBoxButtons.OK, MessageBoxIcon.Information)
                '         Case 65 To 74
                '        MessageBox.Show(DisplayString & ControlChars.NewLine & Display2String & "B", "Final Grade Value",
                '       MessageBoxButtons.OK, MessageBoxIcon.Information)
                '      Case Else
                '     MessageBox.Show(DisplayString & ControlChars.NewLine & Display2String & "A", "Final Grade Value",
                '    MessageBoxButtons.OK, MessageBoxIcon.Information)
                '
                ' End Select
            End If

        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ControlChars.NewLine &
                            ex.Message, "Compute Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Dim form As New PayrollForm
        Me.Hide()
        form.Show()
    End Sub
End Class

