Imports System

Namespace CraftMine_V2
    Public Partial Class GrassLand
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub GrassLand_Load(sender As Object, e As EventArgs)

            ' This allows movement for my character
            AddHandler KeyUp, AddressOf CraftMine_keyUp
            AddHandler KeyDown, AddressOf CraftMine_keydown

            ' This adds the player onto the form
            PlayerG.Adding(Me, 816, 684)
            formlist.Add(Me)

            ' Adds the Trees onto the form
            tree1.Adding(Me, 180, 90)
            tree2.Adding(Me, 266, 90)
            tree3.Adding(Me, 266, 193)
            tree4.Adding(Me, 375, 228)
            tree5.Adding(Me, 361, 132)
            tree6.Adding(Me, 469, 90)
            tree7.Adding(Me, 1116, 611)
            tree8.Adding(Me, 1214, 601)
            tree9.Adding(Me, 1243, 693)
            tree10.Adding(Me, 1345, 670)
            tree11.Adding(Me, 1141, 693)

            ' Adds the Fruit Trees onto the form
            Fruit1.Adding(Me, 180, 181)
            Fruit2.Adding(Me, 361, 37)
            Fruit3.Adding(Me, 493, 193)
            Fruit4.Adding(Me, 1319, 586)

            ' Adds the Rock onto the form
            Rock1.Adding(Me, 106, 684)
            Rock2.Adding(Me, 170, 601)
            Rock3.Adding(Me, 266, 601)
            Rock4.Adding(Me, 284, 693)
            Rock5.Adding(Me, 361, 611)
            Rock6.Adding(Me, 389, 693)
            Rock7.Adding(Me, 1053, 214)
            Rock8.Adding(Me, 1027, 132)
            Rock9.Adding(Me, 1214, 111)
            Rock10.Adding(Me, 1260, 205)
            Rock11.Adding(Me, 1128, 90)

            ' Adds the Coal Nodes onto the form
            Coal1.Adding(Me, 1141, 193)
            Coal2.Adding(Me, 189, 693)

        End Sub
    End Class
End Namespace
