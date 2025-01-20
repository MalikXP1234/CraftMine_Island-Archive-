Public Module Subroutine

    ' Movement Variables
    Public playerup, playerdown, playerleft, playerright As Boolean

    ' Data file Variables
    Public DataFile As String = String.Concat("CraftMine_list.txt")
    Public infofile As String = String.Concat("Info.txt")
    Public LeaderboardFile As String = String.Concat("LeaderBoard.txt")

    ' Inventory Variables
    Public woodenpick, woodensword, stonepick, ironpick, goldpick, goldaxe As Boolean
    Public Craftingtable, furnace, anvil, woodarmor, ironarmor, goldarmor As Boolean

    ' timers
    Public Craftmine_Timer_Data, CraftMine_InGameTimer As Timer

    ' UI Variables
    Public Points, totalpoints As Integer
    Public Health As Integer = 10
    Public Defence As Integer = 0

    ' Login Checker Variables
    Public LoginChecker As Boolean = False
    Public correctuser, correctpass As String

    ' Data Variables
    Public seconds, minutes, hour As Integer
    Public treevalue, rockvalue, mineralvalue As Integer
    Public level As Integer

    ' Label Variables
    Public Mining As Label = New Label()
    Public Fighting As Label = New Label()
    Public ui As Label = New Label()
    Public Respawn As Label = New Label()
    Public Shipp As Label = New Label()
    Public Tutorial As Label = New Label()
    Public labelcounter As Integer = 0
    Public message As Label = New Label()
    Public done As Boolean

    Sub New()
        Craftmine_Timer_Data = New Timer()
        CraftMine_InGameTimer = New Timer()
    End Sub



    Public Sub CraftMine_keyUp(sender As Object, e As KeyEventArgs) ' Smooth Movement for Player

        Select Case e.KeyCode

            Case Keys.W
                playerup = False
                Exit Select

            Case Keys.A
                playerleft = False
                Exit Select

            Case Keys.S
                playerdown = False
                Exit Select

            Case Keys.D
                playerright = False
                Exit Select

        End Select

    End Sub

    Public Sub CraftMine_keydown(sender As Object, e As KeyEventArgs) ' Smooth Movement for Player

        Select Case e.KeyCode

            Case Keys.W

                If Not playerdown And Not playerleft And Not playerright Then
                    playerup = True
                End If

                Exit Select

            Case Keys.A

                If Not playerright And Not playerup And Not playerdown Then
                    playerleft = True
                End If

                Exit Select

            Case Keys.S

                If Not playerup And Not playerleft And Not playerright Then
                    playerdown = True
                End If

                Exit Select

            Case Keys.D

                If Not playerleft And Not playerup And Not playerdown Then
                    playerright = True
                End If

                Exit Select

            Case = Keys.Space And Conversions.ToInteger(charatercollision)
                counter += 1
                Exit Select

            Case = Keys.Space And Conversions.ToInteger(done = False)
                labelcounter += 1
                Exit Select

            Case Keys.Q
                'My.Forms.Inventory.Visible = True
                Exit Select

        End Select



    End Sub

    Public Sub CraftMine_label()

        Call Ui_Label()

        Call Mining_Label()

        Call Ship_Label()

        Call CraftMine_Tutorial()

        Call Sign_Label()

    End Sub

    Public Sub Ui_Label() ' This is used for the main UI of the player, which shows health, defence and points

        ui.Text = Format(" Health: " & Health.ToString() & Environment.NewLine & " Defence: " & Defence.ToString() & Environment.NewLine & " Points: " & Points.ToString())
        ui.Location = New Point(1420, 0)
        ui.Visible = True
        ui.Font = New Font("Microsoft Sans Serif", 22.0F, FontStyle.Bold)
        ui.Size = New Size(400, 110)

    End Sub

    Public Sub Mining_Label()

        Mining.Text = "Press the Spacebar 3 times to break the object"
        Mining.Location = New Point(787, 367)
        Mining.Visible = False
        Mining.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold)
        Mining.Size = New Size(470, 40)

    End Sub

    Public Sub Ship_Label()

        Shipp.Text = "Press the Spacebar 3 times to Fix the ship"
        Shipp.Location = New Point(787, 367)
        Shipp.Visible = False
        Shipp.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold)
        Shipp.Size = New Size(470, 40)


    End Sub

    Public Sub Sign_Label()
        message.Text = "Press the Spacebar 3 times to look at the sign"
        message.Location = New Point(787, 367)
        message.Visible = False
        message.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold)
        message.Size = New Size(470, 40)
    End Sub

    Public Sub CraftMine_Tutorial()

        My.Forms.BeachLand.Controls.Add(Tutorial)

        Tutorial.Visible = True
        Tutorial.Location = New Point(147, 211)
        Tutorial.Font = New Font("Microsoft Sans Serif", 22.0F, FontStyle.Bold)
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
            CraftMine_Timer_Movement.Start()
            Tutorial.Visible = False
            done = True
        End If


    End Sub

End Module
