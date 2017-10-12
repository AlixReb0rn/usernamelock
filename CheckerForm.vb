Public Class Form1

    'This Created By Alix Reb0rn
    'UsernameLock Created By Alix Reb0rn this is like Hardware id lock but easy functions this has.
    'Good Luck make anything with environment username checker even you can make a private trainer.

    'Change WebURL to your url that has user information.
    'im not responsible with any illegal stuff you made with this
    'Contact planetleaked@gmail.com if you failed making this checker.


    Dim WebURL As String = "https://pastebin.com/8UhdEecC" 'this url is the page you check username from.
    Dim ResponseChecker As New System.Net.WebClient 'This is the base webclient that get response from server.
    Dim DownloadPage As String = ResponseChecker.DownloadString(WebURL)



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SaveLog As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("UsernameLock_Log.txt", True) 'That saves log if your username allowed YES Else NO
        If DownloadPage.Contains(Environment.UserName) Then
            SaveLog.WriteLine("YES")
            SaveLog.Close()

        Else
            MsgBox("Sorry. Your username wont match")
            SaveLog.WriteLine("NO")
            SaveLog.Close()
            Environment.Exit(1)
        End If
    End Sub
End Class
