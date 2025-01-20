Imports System
Imports System.IO
Imports Microsoft.VisualBasic

Namespace CraftMine_V2

    Public Partial Class Login

        ' Login Data 
        Public username1, password1 As String
        Friend username2, password2 As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Login_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub Signup1_Click(sender As Object, e As EventArgs)

            Dim ASCII_data As Integer

            ' Inputs data for user
            username1 = signuser.Text
            password1 = signpass.Text

            ' Find error
            If String.IsNullOrEmpty(username1) Then
                MsgBox("Please say something for username here")
                Return
            End If

            ' Find errors
            Dim i = 1, loopTo = Len(username1)

            While i <= loopTo
                ASCII_data = Asc(Mid(username1, i, 1))

                If ASCII_data = 32 Then
                    MsgBox("Please, dont add any spaces to your username")
                    Return
                End If

                If ASCII_data >= 58 And ASCII_data <= 64 Then
                    MsgBox("Please, you are not allowed to use these special characters. Remove them and try again")
                    Return
                End If

                If ASCII_data >= 33 And ASCII_data <= 47 Then
                    MsgBox("Please, you are not allowed to use these special characters. Remove them and try again")
                    Return
                End If

                i += 1

            End While

            Dim i = 1, loopTo1 = Len(password1)

            While i <= loopTo1
                ASCII_data = Asc(Mid(password1, i, 1))

                If ASCII_data = 32 Then
                    MsgBox("Please, dont add any spaces to your password")
                    Return
                End If

                i += 1

            End While

            ' checks if the user has not said anthing for the password
            If String.IsNullOrEmpty(password1) Then
                MsgBox("Please put something for password here")
                Return
            End If


            MsgBox(" Welcome! " & username1 & " To the Craft-Mine club ")

            ' Creates file for system to fill
            Dim Filewriter = New StreamWriter(DataFile, True)
            Filewriter.WriteLine(username1 & ":" & password1) ' Inputs data from user
            Filewriter.Close()

            signuser.Text = ""
            signpass.Text = ""



        End Sub



        Private Sub Login1_Click(sender As Object, e As EventArgs) ' Stores username and password

            Dim A, B As Integer ' stores letters to add up

            Dim check = DirectCast(Nothing, Boolean) ' Checks if both inputs are correct

            Dim letters As String ' A and B store it in here


            ' Holds the file to be read by the system
            Dim fileholder = File.ReadAllLines(DataFile)

            username2 = loguser.Text

            password2 = logpass.Text

            ' Checks if the user has not said anything for the username
            If String.IsNullOrEmpty(username2) Then
                MsgBox("Please say something for login username here")
                Return
            End If

            ' checks if the user has not said anthing for the password
            If String.IsNullOrEmpty(password2) Then
                MsgBox("Please put something for login password here")
                Return
            End If


            ' Checks word in file
            For Each word In fileholder
                Dim loopTo = Len(word)
                For A = 1 To loopTo ' checks the length
                    letters = Mid(word, A, 1) ' add the letter
                    If Not Equals(letters, ":") Then ' if it reaches ":" then it would stop
                        correctuser += letters ' add the full word
                    End If

                    If Equals(letters, ":") Then
                        GoTo checkpassword
                    End If ' Goes and repeat for the next word (Password)
                Next

checkpassword:


                Dim loopTo1 = Len(word)
                For B = A + 1 To loopTo1
                    letters = Mid(word, B, 1)
                    correctpass += letters
                Next

                ' if the loop did it correctly and if the user input is the same then it would make the check be true
                If Equals(If(correctuser, ""), If(username2, "")) And Equals(If(correctpass, ""), If(password2, "")) Then
                    check = True
                End If

                If check = True Then Exit For ' Exit the code

                correctuser = ""
                correctpass = ""

            Next ' continues for the last step

            ' Finally it will say to the user, you are loggin in and you can play
            If check = True Then
                MsgBox(" Hey, " & username2 & " You are now logged in :D ")

                Visible = False
                My.Forms.Play_Menu.Visible = True

                LoginChecker = True

                Return
            Else
                MsgBox("Account has not been found")

            End If ' Error if system has not found the file


        End Sub


    End Class
End Namespace
