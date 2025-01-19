Imports System.IO
Imports System.Reflection

Module CM_Subroutines

    ' Data file 
    Public DataFile As String = Application.StartupPath.Concat("CraftMine_list.txt")
    Public infofile As String = Application.StartupPath.Concat("Info.txt")
    Public LeaderboardFile As String = Application.StartupPath.Concat("LeaderBoard.txt")

    ' This is used for the Inventory form and checks for crafting specifically and collision
    Public woodenpick, woodensword, stonepick, ironpick, goldpick, goldaxe As Boolean
    Public Craftingtable, furnace, anvil, woodarmor, ironarmor, goldarmor As Boolean

    ' ui data
    Public Points, totalpoints As Integer
    Public Health As Integer = 10
    Public Defence As Integer = 0

    ' Login Checker
    Public LoginChecker As Boolean = False
    Public correctuser, correctpass As String

    ' Infomation data
    Public seconds, minutes, hour As Integer
    Public treevalue, rockvalue, mineralvalue As Integer
    Public level As Integer

    ' This is used for the randomise values
    Public Mining As New Label
    Public Fighting As New Label
    Public ui As New Label
    Public popup As New Label
    Public Shipp As New Label
    Public Tutorial As New Label
    Public labelcounter As Integer = 0
    Public done As Boolean

    Public Sub CraftMine_keydown(sender As Object, e As KeyEventArgs) ' Controls the press to make the player move

        If done = True Then

            If Plains.Visible = True Then
                PlayerP.Movements(e)

            ElseIf Tundra.Visible = True Then
                PlayerT.Movements(e)

            ElseIf Forest.Visible = True Then
                PlayerF.Movements(e)

            ElseIf Mountains.Visible = True Then
                PlayerM.Movements(e)

            ElseIf Beach.Visible = True Then
                PlayerB.Movements(e)

            End If
        End If

        Select Case e.KeyCode

            Case Keys.Space And charatercollision = True
                counter += 1

            Case Keys.Space And done = False
                labelcounter += 1

            Case Keys.Q

        End Select


    End Sub

    Public Sub CraftMine_label()

        Ui_Label()

        Mining_Label()

        Ship_Label()

        CraftMine_Tutorial()

    End Sub

    Public Sub Ui_Label() ' This is used for the main UI of the player, which shows health, defence and points

        ui.Text = Format(" Health: " & Health & Environment.NewLine & " Defence: " & Defence & Environment.NewLine & " Points: " & Points)
        ui.Location = New Point(1420, 0)
        ui.Visible = True
        ui.Font = New Font("Microsoft Sans Serif", 22, FontStyle.Bold)
        ui.Size = New Size(400, 110)

    End Sub

    ' Could merge all 3 labels as I can change the text which would work
    Public Sub Mining_Label()

        Mining.Text = "Press the Spacebar 3 times to break the object"
        Mining.Location = New Point(787, 367)
        Mining.Visible = False
        Mining.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
        Mining.Size = New Size(470, 40)

    End Sub

    Public Sub Ship_Label()

        Shipp.Text = "Press the Spacebar 3 times to Fix the ship"
        Shipp.Location = New Point(787, 367)
        Shipp.Visible = False
        Shipp.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
        Shipp.Size = New Size(470, 40)


    End Sub

    Public Sub CraftMine_Tutorial()

        Beach.Controls.Add(Tutorial)

        Tutorial.Visible = True
        Tutorial.Location = New Point(147, 211)
        Tutorial.Font = New Font("Microsoft Sans Serif", 22, FontStyle.Bold)
        Tutorial.Size = New Size(500, 211)

        If labelcounter = 0 Then
            Tutorial.Text = "Ouch My head hurts. Where am I? What is this location

Press SpaceBar to Continue
"
        ElseIf labelcounter = 1 Then
            Tutorial.Text = "I need to get out of here, look there is a ship!

Press SpaceBar to Continue
"

        ElseIf labelcounter = 2 Then
            Tutorial.Text = "mhmm, They are materials all over the place, 

Press SpaceBar to Continue
"

        ElseIf labelcounter = 3 Then
            Tutorial.Text = "I somehow have the ability to get a inventory up by pressing
Q!

Press SpaceBar to Continue
"

        ElseIf labelcounter = 3 Then
            Tutorial.Text = "I can simply touch the object to interact with it

Press SpaceBar to Continue
"

        ElseIf labelcounter = 4 Then
            Tutorial.Text = "Let's get out of here by fixing the ship :D 

Press SpaceBar to Continue
"
        ElseIf labelcounter = 5 Then

            Tutorial.Visible = False
            done = True
        End If

    End Sub


End Module
