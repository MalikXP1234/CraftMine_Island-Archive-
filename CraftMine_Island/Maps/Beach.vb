Imports System
Imports Microsoft.VisualBasic

Namespace CraftMine_V2
    Public Partial Class Beach
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Beach_Load(sender As Object, e As EventArgs)

            ' Message Box
            MsgBox("Instructions:

--------------------------------------------------------

Your main objective is to escape the island!

Use W,A,S,D to move around (One key at a time)

Collide with Object to break it (Object may overlaps)

Press Q to open up inventory (Warning: Don't press this and a movement key at the same time. Will cause error)

Craft Items and explore

Have fun!!!!

--------------------------------------------------------
")

            ' This allows movement for my character
            AddHandler KeyUp, AddressOf CraftMine_keyUp
            AddHandler KeyDown, AddressOf CraftMine_keydown

            ' This is used to start the timer like Movement and Collision
            CraftMine_Timer_Collision.Start()

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
            tree33.Adding(Me, 1199, 59)
            tree34.Adding(Me, 1285, 59)

            Ship.Adding(Me, 1224, 433)

        End Sub

    End Class
End Namespace
