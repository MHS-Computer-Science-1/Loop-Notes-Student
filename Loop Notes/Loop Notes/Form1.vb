Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Add 1-5 to the ListBox the LONG WAY

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Add 1-5 to the ListBox the LOOP WAY

        'Loops are used to automatically repeat code
        'Our loop will use the i variable to
        'count from 1 to 5


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Display -10 to 10

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer

        'A step command can be used to make the loop
        'count differently
        'Step 2, means count up by 2s

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Display a NASA countdown from 10 to 1 in the ListBox
        'At the end, display "BLASTOFF!"



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'DO WHILE loops can do the same things as for loops


        'DO WHILE loops repeat until the Boolean expression
        'is FALSE


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Display -10 to 10

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'DO WHILE Loops can do more than count

        Dim r As New Random
        Dim secret As Integer
        secret = r.Next(1, 11)



        MsgBox("You got it right!")

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click


    End Sub
End Class
