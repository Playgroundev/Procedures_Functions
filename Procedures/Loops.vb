Public Class Loops

    Private Sub Loops_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Schools() As String
        Schools = {}
    End Sub

    Private Sub BtnPopulate_Click(sender As System.Object, e As System.EventArgs) Handles BtnPopulate.Click
        Try
            Dim Schools() As String
            Schools = {"Kitui Boys", "Kijabe Boys", "Lukenya Boys", "Anestar Boys", "Alliance Boys", "Utumishi Boys"}
            For i = 1 To UBound(Schools)
                LstOutput.Items.Add(Schools(i))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Private Sub BtnWhile_Click(sender As System.Object, e As System.EventArgs) Handles BtnWhile.Click
        Dim Number As Integer
        Do While Number <= 100
            LstWhile.Items.Add(Number)
            Number += 1
        Loop

    End Sub
End Class