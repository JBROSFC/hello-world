Public Class Form1
    Dim numberOne As Integer
    Dim numberTwo As Integer
    Dim firstNumberCheck As Boolean = True
    Dim operatorSymbol As Char
    Private Sub btnNo1_Click(sender As Object, e As EventArgs) Handles btnNo1.Click
        If firstNumberCheck = True Then
            txtNumberOne.Text = txtNumberOne.Text & 1
            numberOne = txtNumberOne.Text
        Else
            txtNumberTwo.Text = txtNumberTwo.Text & 1
            numberTwo = txtNumberTwo.Text
        End If

    End Sub

    Private Sub btnNo2_Click(sender As Object, e As EventArgs) Handles btnNo2.Click
        txtNumberOne.Text = 2
    End Sub

    Private Sub btnNo3_Click(sender As Object, e As EventArgs) Handles btnNo3.Click
        txtNumberOne.Text = 3
    End Sub

    Private Sub btnNo4_Click(sender As Object, e As EventArgs) Handles btnNo4.Click
        txtNumberOne.Text = 4
    End Sub

    Private Sub btnNo5_Click(sender As Object, e As EventArgs) Handles btnNo5.Click
        txtNumberOne.Text = 5
    End Sub

    Private Sub btnNo6_Click(sender As Object, e As EventArgs) Handles btnNo6.Click
        txtNumberOne.Text = 6
    End Sub

    Private Sub btnNo7_Click(sender As Object, e As EventArgs) Handles btnNo7.Click
        txtNumberOne.Text = 7
    End Sub

    Private Sub btnNo8_Click(sender As Object, e As EventArgs) Handles btnNo8.Click
        txtNumberOne.Text = 8
    End Sub

    Private Sub btnNo9_Click(sender As Object, e As EventArgs) Handles btnNo9.Click
        txtNumberOne.Text = 9
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        firstNumberCheck = False
        lblOperator.Text = "+"
        operatorSymbol = "+"
    End Sub
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        If operatorSymbol = "+" Then
            txtAnswer.Text = numberOne + numberTwo
        End If


    End Sub
End Class
