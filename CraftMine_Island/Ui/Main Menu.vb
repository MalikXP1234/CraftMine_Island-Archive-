Imports System
Imports Microsoft.VisualBasic

Namespace CraftMine_V2
    Public Partial Class Main_Menu
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Play1_Click(sender As Object, e As EventArgs) ' Takes User to the Play Menu Form

            Visible = False
            My.Forms.Play_Menu.Visible = True

        End Sub

        Private Sub Quit1_Click(sender As Object, e As EventArgs) ' Ask User to leave the game or not

            If MsgBox("Would you like to quit the cool game?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Visible = True

                Environment.Exit(0)

            End If

        End Sub

        Private Sub Lead1_Click(sender As Object, e As EventArgs) ' Takes User to LeaderBoard Form to see Score

            ' Place for LeaderBoard Form

            Visible = False
            My.Forms.LeaderBoard.Visible = True

        End Sub

        Private Sub Main_Menu_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub Main_Menu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
