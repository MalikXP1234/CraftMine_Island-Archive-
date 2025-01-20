Imports System
Imports System.Collections.Generic
Imports System.IO
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace CraftMine_V2

    Public Partial Class LeaderBoard

        Private FirstTry As Integer = 0

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub LeaderBoard_Button(sender As Object, e As EventArgs)

            FirstTry += 1

            ' Reads the file which contains the Leaderboard

            ' List for Storing the UserName/Password
            Dim UList = New List(Of String)()
            Dim PList = New List(Of Integer)()
            Dim Player_Points As Integer = New Integer()
            ' Used to store the correct versions back to the list
            Dim NameHolder As String
            Dim PointsHolder As String
            Dim Sections As String()
            Dim outputs As String

            If File.Exists(LeaderboardFile) Then

                Dim fileholder = File.ReadAllLines(LeaderboardFile)

                MsgBox("Your datafile has been found!")

                For Each Part In fileholder

                    Sections = Part.Split(":"c) ' indicates when there is a split

                    ' Splits the Words into two sections
                    UList.Add(Sections(0))
                    PList.Add(Conversions.ToInteger(Sections(1)))

                Next


                Player_Points = PList.Count ' Gets the points

                ' Bubble Sort beings here
                Dim i = 0, loopTo = Player_Points - 2

                While i <= loopTo

                    If PList(i) < PList(i + 1) Then ' Compares the value of points

                        ' Swaps name around
                        NameHolder = UList(i)
                        UList(i) = UList(i + 1)
                        UList(i + 1) = NameHolder
                        ' Swaps Points around
                        PointsHolder = PList(i).ToString()
                        PList(i) = PList(i + 1)
                        PList(i + 1) = Conversions.ToInteger(PointsHolder)

                    End If

                    i += 1 ' Checks the length of the points

                End While

                MsgBox("Data has been collected")

                ' Display the items in the listbox to showcase the user's Points
                If FirstTry = 1 Then

                    ListBox1.Items.Add("Here is the list of user's Points from File Data")
                    ListBox1.Items.Add("-----------------------------------")

                    Dim i = 0, loopTo1 = UList.Count - 1

                    While i <= loopTo1

                        outputs = UList(i) & " : " & PList(i).ToString() & " Point "


                        ListBox1.Items.Add(outputs)
                        ListBox1.Items.Add("-----------------------------------")
                        i += 1
                    End While

                End If
            Else
                MsgBox("Sorry to let you know that there is no file that has data to be displayed")

            End If


        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)

            Visible = False
            My.Forms.Main_Menu.Visible = True

            ListBox1.Items.Clear()
            FirstTry = 0

        End Sub

        Private Sub LeaderBoard_Load(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
