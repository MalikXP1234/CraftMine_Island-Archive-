Imports System

Namespace CraftMine_V2
    Public Partial Class Mountains
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Mountains_Load(sender As Object, e As EventArgs)

            ' This allows movement for the character
            AddHandler KeyUp, AddressOf CraftMine_keyUp
            AddHandler KeyDown, AddressOf CraftMine_keydown

            ' This adds the Player onto the form
            PlayerM.Adding(Me, 125, 403)
            formlist.Add(Me)

            Rock12.Adding(Me, 105, 86)
            Rock13.Adding(Me, 125, 196)
            Rock14.Adding(Me, 236, 77)
            Rock15.Adding(Me, 236, 196)
            Rock16.Adding(Me, 361, 196)
            Rock17.Adding(Me, 361, 77)
            Rock18.Adding(Me, 485, 215)
            Rock19.Adding(Me, 460, 95)

            ' Adds the Iron Node Onto the form
            Iron22.Adding(Me, 778, 95)
            Iron23.Adding(Me, 808, 184)
            Iron24.Adding(Me, 872, 77)
            Iron25.Adding(Me, 911, 196)
            Iron26.Adding(Me, 1007, 77)
            Iron27.Adding(Me, 1017, 196)
            Iron28.Adding(Me, 1127, 77)
            Iron29.Adding(Me, 1144, 184)

            ' Adds the Gold Node Onto the form
            Gold1.Adding(Me, 1104, 583)
            Gold2.Adding(Me, 1114, 680)
            Gold3.Adding(Me, 1215, 568)
            Gold4.Adding(Me, 1225, 671)
            Gold5.Adding(Me, 1332, 568)
            Gold6.Adding(Me, 1345, 680)
            Gold7.Adding(Me, 1445, 626)

            ' Adds the Coal Node Onto the form
            Coal3.Adding(Me, 303, 671)
            Coal4.Adding(Me, 399, 583)
            Coal5.Adding(Me, 424, 680)
            Coal6.Adding(Me, 504, 583)
            Coal7.Adding(Me, 529, 693)
            Coal8.Adding(Me, 603, 568)
            Coal9.Adding(Me, 629, 680)

        End Sub
    End Class
End Namespace
