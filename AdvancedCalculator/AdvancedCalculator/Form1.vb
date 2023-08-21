Public Class Form1
    Dim number = New String() {"0", "0"}
    Dim op As String
    Dim index = 0
    Dim size = 0
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If number(index) = "0" Then
            number(index) = "1"
            txtInputOutput.Text = number(index)
        Else
            number(index) = number(index) & "1"
            txtInputOutput.Text = number(index)
        End If
        size += 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If number(index) = "0" Then
            number(index) = "2"
            txtInputOutput.Text = number(index)
        Else
            number(index) = number(index) & "4"
            txtInputOutput.Text = number(index)
        End If
        size += 1
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If number(index) = "0" Then
            number(index) = "3"
            txtInputOutput.Text = number(index)
        Else
            number(index) = number(index) & "3"
            txtInputOutput.Text = number(index)
        End If
        size += 1
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If number(index) = "0" Then
            number(index) = "4"
            txtInputOutput.Text = number(index)
        Else
            number(index) = number(index) & "4"
            txtInputOutput.Text = number(index)
        End If
        size += 1
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If number(index) = "0" Then
            number(index) = "5"
            txtInputOutput.Text = number(index)
        Else
            number(index) = number(index) & "5"
            txtInputOutput.Text = number(index)
        End If
        size += 1
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If number(index) = "0" Then
            number(index) = "6"
            txtInputOutput.Text = number(index)
        Else
            number(index) = number(index) & "6"
            txtInputOutput.Text = number(index)
        End If
        size += 1
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If number(index) = "0" Then
            number(index) = "7"
            txtInputOutput.Text = number(index)
        Else
            number(index) = number(index) & "7"
            txtInputOutput.Text = number(index)
        End If
        size += 1
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If number(index) = "0" Then
            number(index) = "8"
            txtInputOutput.Text = number(index)
        Else
            number(index) = number(index) & "8"
            txtInputOutput.Text = number(index)
        End If
        size += 1
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If number(index) = "0" Then
            number(index) = "9"
            txtInputOutput.Text = number(index)
        Else
            number(index) = number(index) & "9"
            txtInputOutput.Text = number(index)
        End If
        size += 1
    End Sub
    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If Not number(index) = "0" Then
            number(index) = number(index) & "."
            txtInputOutput.Text = number(index)
            size += 1
        End If

    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If Not number(index) = "0" Then
            number(index) = number(index) & "0"
            size += 1
        End If
        txtInputOutput.Text = number(index)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If index = 0 Then
            lblOutput.Text = number(index) & "+"
            txtInputOutput.Text = ""
            op = "+"
            index = 1
            size = 0
        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If index = 0 Then
            lblOutput.Text = number(index) & "-"
            txtInputOutput.Text = ""
            op = "-"
            index = 1
            size = 0
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If index = 0 Then
            lblOutput.Text = number(index) & "*"
            txtInputOutput.Text = ""
            op = "*"
            index = 1
            size = 0
        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If index = 0 Then
            lblOutput.Text = number(index) & "/"
            txtInputOutput.Text = ""
            op = "/"
            index = 1
            size = 0
        End If
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If op = "+" Then
            Dim temp As Double
            temp = Val(number(0)) + Val(number(1))
            lblOutput.Text = ""
            txtInputOutput.Text = temp
            op = ""
            number(0) = "" & temp
            number(1) = "0"
            index = 0
        ElseIf op = "-" Then
            Dim temp As Double
            temp = Val(number(0)) - Val(number(1))
            lblOutput.Text = ""
            txtInputOutput.Text = temp
            op = ""
            number(0) = "" & temp
            number(1) = "0"
            index = 0
        ElseIf op = "*" Then
            Dim temp As Double
            temp = Val(number(0)) * Val(number(1))
            lblOutput.Text = ""
            txtInputOutput.Text = temp
            op = ""
            number(0) = "" & temp
            number(1) = "0"
            index = 0
        ElseIf op = "/" Then
            Dim temp As Double
            temp = Val(number(0)) / Val(number(1))
            lblOutput.Text = ""
            txtInputOutput.Text = temp
            op = ""
            number(0) = "" & temp
            number(1) = "0"
            index = 0
        End If
        size = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = ""
        txtInputOutput.Text = ""
        number(0) = "0"
        number(1) = "0"
        index = 0
        size = 0
    End Sub

    Private Sub bntRemove_Click(sender As Object, e As EventArgs) Handles bntRemove.Click
        If Not number(index) = "0" Then
            Dim split() As Char = number(index).ToCharArray()
            Dim temp As String
            temp = ""
            For i As Integer = 0 To split.Length - 2 Step 1
                temp &= split(i)
            Next

            number(index) = temp
            txtInputOutput.Text = temp
        End If


    End Sub
End Class
