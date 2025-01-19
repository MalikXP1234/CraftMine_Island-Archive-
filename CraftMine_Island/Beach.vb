Public Class Beach
    Private Sub Beach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Movement for Player
        AddHandler Me.KeyDown, AddressOf CraftMine_keydown

        ' This is used to start the timer like Movement and Collision
        PlayerB.Adding(Me, 801, 370)
        formlist.Add(Me)

        ' Adds the Trees onto the form
        tree25.Adding(Me, 93, 59)
        tree26.Adding(Me, 199, 44)
        tree27.Adding(Me, 301, 59)
        tree28.Adding(Me, 402, 59)
        tree29.Adding(Me, 496, 59)
        tree30.Adding(Me, 608, 59)
        tree31.Adding(Me, 1027, 59)
        tree32.Adding(Me, 1110, 44)
        tree33.Adding(Me, 1199, 59)
        tree34.Adding(Me, 1285, 59)

        Ship.Adding(Me, 1224, 433)

        Craftmine_Timer_Data.Start()
 

    End Sub
End Class