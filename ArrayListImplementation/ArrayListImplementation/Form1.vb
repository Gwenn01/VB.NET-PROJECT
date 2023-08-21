Public Class Form1
    Dim list = New MyArrayList

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim data As String
        data = txtAdd.Text
        list.add(data)
        display()
        txtAdd.Text = ""
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim data As String
        data = list.remove()
        display()
        txtRemove.Text = data
    End Sub

    Private Sub btnAddIndex_Click(sender As Object, e As EventArgs) Handles btnAddIndex.Click
        Dim data As String
        Dim index As Integer
        data = textAddIndex.Text
        index = nmcAdd.Text
        list.addIndex(data, index)
        display()
        textAddIndex.Text = ""
    End Sub

    Private Sub btnRemoveIndex_Click(sender As Object, e As EventArgs) Handles btnRemoveIndex.Click
        Dim data As String
        Dim index As Integer
        index = nmcRemove.Text
        data = list.removeIndex(index)
        display()
        txtRemoveIndex.Text = data
    End Sub
    Public Sub display()
        txt1.Text = list.array(0)
        txt2.Text = list.array(1)
        txt3.Text = list.array(2)
        txt4.Text = list.array(3)
        txt5.Text = list.array(4)
        txt6.Text = list.array(5)
        txt7.Text = list.array(6)
        txt8.Text = list.array(7)
        txt9.Text = list.array(8)
        txt10.Text = list.array(9)
    End Sub
End Class
Public Class MyArrayList
    Dim arr(10) As String
    Dim index = -1
    Dim size = 0

    Public Sub add(data As String)
        If isFull() Then
            Return
        End If
        index += 1
        size += 1
        arr(index) = data
    End Sub
    Public Sub addIndex(data As String, position As Integer)
        If isFull() Then
            Return
        End If
        If arr(position) = "" Then
            MsgBox("Put Value first")
            Return
        End If
        Dim i As Integer
        i = index
        Do While i >= position
            arr(i + 1) = arr(i)
            i -= 1
        Loop
        arr(position) = data
        index += 1
        size += 1
    End Sub

    Public Function remove() As String
        If isEmpty() Then
            Return "Exception"
        End If
        Dim data As String
        data = arr(index)
        arr(index) = ""
        index -= 1
        size -= 1
        Return data
    End Function
    Public Function removeIndex(position As Integer) As String
        If isEmpty() Then
            Return "Exception"
        End If
        If arr(position) = "" Then
            Return "Exception"
        End If

        Dim data As String
        data = arr(position)
        For i = position To index Step 1
            arr(i) = arr(i + 1)
        Next
        arr(index) = ""
        index -= 1
        size -= 1
        Return data
    End Function
    Public Function array() As String()
        Return arr
    End Function
    Public Function isEmpty()
        Return size = 0
    End Function
    Public Function isFull()
        Return size = 10
    End Function
End Class
