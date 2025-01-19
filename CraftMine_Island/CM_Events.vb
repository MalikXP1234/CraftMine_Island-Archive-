Imports System.IO
Module CM_Events

    Public Filewriter As New StreamWriter(LeaderboardFile, True)

    ' This is Mainly for the Player's Data : Materials and Resources
    Public WithEvents Craftmine_Timer_Data, CraftMine_InGameTimer As New Timer

    Public Sub CraftMine_Data() Handles Craftmine_Timer_Data.Tick  ' Controls all data in CraftMine

        Craftmine_Timer_Data.Interval = 1

        CraftMine_label()

        If Plains.Visible = True Then
            PlayerP.Collosion()

        ElseIf Tundra.Visible = True Then
            PlayerT.Collosion()

        ElseIf Forest.Visible = True Then
            PlayerF.Collosion()

        ElseIf Mountains.Visible = True Then
            PlayerM.Collosion()

        ElseIf Beach.Visible = True Then
            PlayerB.Collosion()
            PlayerB.Ship_collision()

        End If

        For Each form In formlist
            If form.Visible = True Then

                form.Controls.Add(Mining)

                form.Controls.Add(ui)

                Beach.Controls.Add(Shipp)
            End If
        Next

        CraftMine_InGameTimer.Start()

    End Sub

    Public Sub CraftMine_Timer() Handles CraftMine_InGameTimer.Tick ' Ingame timer checks how long the user has played

        CraftMine_InGameTimer.Interval = 1000

        seconds += 1

        If seconds > 59 Then
            seconds = 0
            minutes += 1
            If minutes = 59 Then
                minutes = 0
                hour = 1
            End If
        End If

    End Sub

End Module
