Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade As String
        grade = TextBox1.Text
        grade = Microsoft.VisualBasic.UCase(grade)

        Select Case grade
            Case "A"
                TextBox2.Text = "High disticntion"

            Case "B"
                TextBox2.Text = "Disticition"
            Case "C"
                TextBox2.Text = "Credit"
            Case "D"
                TextBox2.Text = "PASS"
            Case Else

                TextBox2.Text = "FAIL"

        End Select
    End Sub
End Class
