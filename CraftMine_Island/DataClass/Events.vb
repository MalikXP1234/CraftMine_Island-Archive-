Imports System.IO
Imports System.Reflection

Public Module Events


    Public Filewriter As StreamWriter = New StreamWriter(LeaderboardFile, True)

        Public CraftMine_Timer_Movement As Timer
        Public CraftMine_Timer_Collision As Timer
        Public CraftMine_InGameTimer As Timer

        Public formlist As List(Of Form) = New List(Of Form)()
        Public treestorage As List(Of PictureBox) = New List(Of PictureBox)(), fruitstorage As List(Of PictureBox) = New List(Of PictureBox)(), rockstorage As List(Of PictureBox) = New List(Of PictureBox)(), Coalstorage As List(Of PictureBox) = New List(Of PictureBox)(), Ironstorage As List(Of PictureBox) = New List(Of PictureBox)(), Goldstorage As List(Of PictureBox) = New List(Of PictureBox)(), characterlist As List(Of PictureBox) = New List(Of PictureBox)()

        Sub New()
            CraftMine_Timer_Movement = New Timer()
            CraftMine_Timer_Collision = New Timer()
            CraftMine_InGameTimer = New Timer()
            AddHandler CraftMine_Timer_Movement.Tick, Sub(__, ___) CraftMine_Movement()
            AddHandler CraftMine_Timer_Collision.Tick, Sub(__, ___) CraftMine_Data()
            AddHandler CraftMine_InGameTimer.Tick, Sub(__, ___) CraftMine_Timer()
        End Sub


        Public Sub CraftMine_Movement() ' Controls The Movement of The player 

            CraftMine_Timer_Movement.Interval = 30

        If My.Forms.GrassLand.Visible = True Then

            PlayerG.Movement()

        ElseIf My.Forms.SnowLand.Visible = True Then

            PlayerS.Movement()

        ElseIf My.Forms.Forestland.Visible = True Then

            PlayerF.Movement()

        ElseIf My.Forms.MountainLand.Visible = True Then

            PlayerM.Movement()

        ElseIf My.Forms.BeachLand.Visible = True Then

            PlayerB.Movement()

            End If

            Call CraftMine_InGameTimer.Start()

        End Sub

        Public Sub CraftMine_Data()  ' Controls all data in CraftMine

            Craftmine_Timer_Data.Interval = 1

            CraftMine_label()

        If My.Forms.GrassLand.Visible = True Then

            PlayerG.Collosion()
            PlayerG.GrassLand_Barrier()

        ElseIf My.Forms.SnowLand.Visible = True Then

            PlayerS.Collosion()
            PlayerS.SnowLand_Barrier()

        ElseIf My.Forms.ForestLand.Visible = True Then

            PlayerF.Collosion()
            PlayerF.Forest_Barrier()
            PlayerF.Puzzle_collision()

        ElseIf My.Forms.MountainLand.Visible = True Then

            PlayerM.Collosion()
            PlayerM.Mountain_Barrier()

        ElseIf My.Forms.BeachLand.Visible = True Then

            PlayerB.Collosion()
                PlayerB.Beach_Barrier()
                PlayerB.Ship_collision()

            End If

            For Each form In formlist
                If form.Visible = True Then

                    form.Controls.Add(Mining)

                    form.Controls.Add(ui)

                    form.Controls.Add(Respawn)

                My.Forms.BeachLand.Controls.Add(Shipp)

                My.Forms.ForestLand.Controls.Add(message)
            End If
            Next


        End Sub

        Public Sub CraftMine_Timer() ' Ingame timer checks how long the user has played

            CraftMine_InGameTimer.Interval = 1000

            seconds += 1

            If seconds > 59 Then
                seconds = 0
                minutes += 1
                If minutes = 59 Then
                    minutes = 0
                    Hour = 1
                End If
            End If

        End Sub

    End Module

