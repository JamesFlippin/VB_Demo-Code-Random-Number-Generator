Public Class frmMain
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim rnd As New Random

        Dim strNumber As String = String.Empty
        Dim intNumber As Integer = 0
        Dim intRoll As Integer = 0

        Dim intSum As Integer = 0
        Dim decAverage As Decimal = 0.0D
        Dim intHigh As Integer = 0
        Dim intLow As Integer = 0

        Dim intCount As Integer = 0
        Dim bolIsValid As Boolean = False
        Dim bolFirstTime As Boolean = True

        Try
            lbxNumbers.Items.Clear()

            For intCount = 1 To 5
                Do
                    strNumber = InputBox("Enter a number between 1 and 100", "Number Please - Prompt #" & intCount.ToString, "10")
                    strNumber = strNumber.Trim
                    If strNumber = String.Empty Then
                        Exit For
                    End If
                    If Integer.TryParse(strNumber, intNumber) Then
                        bolIsValid = True

                        intRoll = rnd.Next(1, intNumber) + 1
                        lbxNumbers.Items.Add(intRoll.ToString)
                        intSum += intRoll
                        If intRoll > intHigh Then
                            intHigh = intRoll
                        End If
                        If bolFirstTime Then
                            intLow = intRoll
                            bolFirstTime = False
                        End If
                        If intLow > intRoll Then
                            intLow = intRoll
                        End If
                    Else
                        MessageBox.Show("Not an Integer value, please try again.", "Not Integer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Loop Until bolIsValid
                bolIsValid = False
            Next
            MsgBox("Average: " & (intSum / intCount).ToString("n1"))
            lblHigh.Text = intHigh.ToString
            lblLow.Text = intLow.ToString
        Catch ex As Exception
            MessageBox.Show("A General Error has occured: " & ControlChars.NewLine & ControlChars.NewLine & ex.Message,
                            "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'test
    End Sub
End Class
