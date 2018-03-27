Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connection As MySqlConnection

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
    Function GetCredentials(ByVal Username As String, ByVal Password As String) As String
        Dim Result As String
        If Username = "admin" And Password = "admin" Then
            Result = "true"
        Else
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            Result = "false"
        End If
        Return Result
    End Function

    Private Sub BtnFunction_Click(sender As System.Object, e As System.EventArgs) Handles BtnFunction.Click
        Dim Usern As String
        Dim Pass As String
        Usern = TxtUsername.Text
        Pass = TxtPassword.Text
        If GetCredentials(Usern, Pass) = "true" Then
            MsgBox("Correct Credentials, Going to the Looping Sequence now")
        Else
            MsgBox("Incorrect Credentials, Please Try Again")
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            Return
        End If

    End Sub

    Private Sub BtnDatabase_Click(sender As System.Object, e As System.EventArgs) Handles BtnDatabase.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=wamatu;database=Visual"

        Try
            connection.Open()
            MessageBox.Show("Connection Succcessful")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
