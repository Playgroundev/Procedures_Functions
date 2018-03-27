Public Class Form1

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim User As String
        Dim Password As String
        User = TxtUsername.Text
        Password = TxtPassword.Text
        If User = "" Or Password = "" Then
            MsgBox("Complete Fill in")
            Return
        End If
        Call Login(User, Password)

    End Sub
    Sub Login(ByVal Username As String, ByVal Password As String)
        If Username = "admin" And Password = "admin" Then
            MsgBox("Correct Credentials")
        Else
            MsgBox("Incorrect Credentials")
            TxtUsername.Text = ""
            TxtPassword.Text = ""
        End If
    End Sub

    Private Sub BtnExit_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        Call Exiting()

    End Sub



    Sub Exiting()
        Close()
    End Sub

End Class
