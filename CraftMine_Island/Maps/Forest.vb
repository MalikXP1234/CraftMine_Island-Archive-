Imports System

Namespace CraftMine_V2
    Public Partial Class Forest
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Forest_Load(sender As Object, e As EventArgs)

            ' This allows movement for my character
            AddHandler KeyUp, AddressOf CraftMine_keyUp
            AddHandler KeyDown, AddressOf CraftMine_keydown

            ' This adds the player onto the form
            PlayerF.Adding(Me, 819, 628)
            formlist.Add(Me)

            ' Adds the Trees onto the form
            tree35.Adding(Me, 93, 665)
            tree36.Adding(Me, 211, 649)
            tree37.Adding(Me, 128, 549)
            tree38.Adding(Me, 236, 549)
            tree39.Adding(Me, 138, 439)
            tree40.Adding(Me, 236, 439)
            tree41.Adding(Me, 175, 346)
            tree42.Adding(Me, 1381, 693)
            tree43.Adding(Me, 1332, 602)
            tree44.Adding(Me, 1448, 612)
            tree45.Adding(Me, 1332, 523)
            tree46.Adding(Me, 1436, 523)
            tree47.Adding(Me, 1345, 439)
            tree48.Adding(Me, 1426, 375)
            tree49.Adding(Me, 1345, 346)

            ' Adds the Fruit Trees onto the form
            Fruit12.Adding(Me, 362, 121)
            Fruit13.Adding(Me, 402, 30)
            Fruit14.Adding(Me, 492, 30)
            Fruit15.Adding(Me, 513, 121)
            Fruit16.Adding(Me, 612, 39)
            Fruit17.Adding(Me, 634, 121)
            Fruit18.Adding(Me, 767, 106)
            Fruit19.Adding(Me, 904, 30)
            Fruit20.Adding(Me, 924, 106)
            Fruit21.Adding(Me, 1028, 30)
            Fruit22.Adding(Me, 1028, 121)
            Fruit23.Adding(Me, 1139, 86)

            ' This adds the Puzzle onto the form
            Redbox.Adding(Me, 415, 717)
            Bluebox.Adding(Me, 75, 76)
            Greenbox.Adding(Me, 1001, 225)
            Yellowbox.Adding(Me, 1228, 717)
            Orangebox.Adding(Me, 1484, 203)
            Sign.Adding(Me, 981, 659)

        End Sub
    End Class
End Namespace
