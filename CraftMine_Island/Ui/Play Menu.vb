Imports System
Imports Microsoft.VisualBasic

Namespace CraftMine_V2
    Public Partial Class Play_Menu
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub SignupLogin1_Click(sender As Object, e As EventArgs) ' Takes User for Account Creation

            Visible = False
            My.Forms.Login.Visible = True

        End Sub

        Private Sub Back1_Click(sender As Object, e As EventArgs) ' Takes User back to Main Menu Form

            Visible = False
            My.Forms.Main_Menu.Visible = True

        End Sub

        Private Sub Game1_Click(sender As Object, e As EventArgs) ' Checks if you created a Account and asking if you are ready to play

            If LoginChecker = True And MsgBox("Would you like to start you great Adventure??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Visible = False
                My.Forms.Beach.Visible = True
            End If

            If LoginChecker = False Then
                MsgBox("REMINDER: Create a account to play")

            End If

        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub Play_Menu_Load(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
