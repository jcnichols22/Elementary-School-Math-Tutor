' Program Name: Elementary School Math tutor
' Developer:    Josh Nichols
' Date:         5/1/2022
' Purpose:      Allows the user to select between addition or subtraction with early or upper lementary then will
'               display math practice questions based on an input number

Public Class frmMath

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' This closes the application
        Application.Exit()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' This clears the list box to study different problems
        lstMath.Items.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This button displays different messages based on radio selection and fills the list box with
        ' math problems based on grade selection and number input in msg box
        Dim intNumber As Integer = 0
        Dim intSecond As Integer = 0
        If mnuAddition.Checked = False And mnuMultiplication.Checked = False Then
            MsgBox("Please select Addtion/Multiplication from the operation menu...!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If radEarly.Checked Then
            intNumber = InputBox("Please enter a number between 0 and 6 ...!", "Math Tutor")
            If intNumber > 6 Or intNumber < 0 Then
                MsgBox("Please enter a number between 0 and 6 ...", vbInformation)
                'if the number is not between 0 and 6 then call the
                'button click to accept the input again
                Call btnCalculate_Click(Me, e)
                Exit Sub
            End If
            intSecond = 6
        Else
            intNumber = InputBox("Please enter a number between 0 and 12 ...!", "Math Tutor")
            If intNumber > 12 Or intNumber < 0 Then
                MsgBox("Please enter a number between 0 and 12 ...", vbInformation)
                'if the number is not between 0 and 12 then call the
                'button click to accept the input again
                Call btnCalculate_Click(Me, e)
                Exit Sub
            End If
            intSecond = 12
        End If
        For intCount = 0 To intSecond
            If mnuAddition.Checked = True Then
                lstMath.Items.Add(intCount & " + " & intNumber & " = " & intCount + intNumber)
            Else
                lstMath.Items.Add(intCount & " X " & intNumber & " = " & intCount * intNumber)
            End If
        Next
    End Sub

    Private Sub mnuAddition_Click(sender As Object, e As EventArgs) Handles mnuAddition.Click
        ' if addition is selected addition is set to true and multiplication false
        mnuAddition.Checked = True
        mnuMultiplication.Checked = False
    End Sub

    Private Sub mnuMultiplication_Click(sender As Object, e As EventArgs) Handles mnuMultiplication.Click
        ' if multiplication is selected multiplication is set to true and addition set to false. 
        mnuMultiplication.Checked = True
        mnuAddition.Checked = False
    End Sub
End Class