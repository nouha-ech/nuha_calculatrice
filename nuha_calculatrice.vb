Public Class Form1
    Dim num1 As Double
    Dim num2 As Double
    Dim operation As String

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        Dim btn As Button = CType(sender, Button)
        TextBox1.Text = TextBox1.Text + btn.Text
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text = TextBox1.Text + "."
        End If
    End Sub

    Private Sub Operation_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click, btnPower.Click, btnModulo.Click
        Dim btn As Button = CType(sender, Button)
        operation = btn.Text
        num1 = Val(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        num2 = Val(TextBox1.Text)

        Select Case operation
            Case "+"
                TextBox1.Text = (num1 + num2).ToString()
            Case "-"
                TextBox1.Text = (num1 - num2).ToString()
            Case "*"
                TextBox1.Text = (num1 * num2).ToString()
            Case "/"
                If num2 <> 0 Then
                    TextBox1.Text = (num1 / num2).ToString()
                Else
                    TextBox1.Text = "Error: Division by zero"
                End If
            Case "^"
                TextBox1.Text = Math.Pow(num1, num2).ToString()
            Case "%"
                TextBox1.Text = (num1 Mod num2).ToString()
            Case "C"
                TextBox1.Text = ""
                num1 = 0
                num2 = 0
                operation = ""
            Case "sqrt"
                If num1 >= 0 Then
                    TextBox1.Text = Math.Sqrt(num1).ToString()
                Else
                    TextBox1.Text = "Error: Invalid input for square root"
                End If
            Case "1/x"
                If num1 <> 0 Then
                    TextBox1.Text = (1 / num1).ToString()
                Else
                    TextBox1.Text = "Error: Division by zero"
                End If
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
        num1 = 0
        num2 = 0
        operation = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
