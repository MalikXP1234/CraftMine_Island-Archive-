Imports System

Namespace CraftMine_V2
    Public Partial Class SnowLand
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub SnowLand_Load(sender As Object, e As EventArgs)

            ' This allows movement for the character
            AddHandler KeyUp, AddressOf CraftMine_keyUp
            AddHandler KeyDown, AddressOf CraftMine_keydown

            ' This adds the Player onto the form
            PlayerS.Adding(Me, 1376, 401)
            formlist.Add(Me)

            ' Adds the Trees onto the form
            tree12.Adding(Me, 230, 90)
            tree13.Adding(Me, 230, 185)
            tree14.Adding(Me, 348, 185)
            tree15.Adding(Me, 554, 172)
            tree16.Adding(Me, 683, 172)
            tree17.Adding(Me, 759, 75)
            tree18.Adding(Me, 888, 75)
            tree19.Adding(Me, 921, 172)
            tree20.Adding(Me, 1027, 75)
            tree21.Adding(Me, 1038, 159)
            tree22.Adding(Me, 1130, 65)
            tree23.Adding(Me, 1259, 65)
            tree24.Adding(Me, 1250, 159)

            ' Adds the Fruit Trees Onto the form
            Fruit5.Adding(Me, 138, 172)
            Fruit6.Adding(Me, 375, 90)
            Fruit7.Adding(Me, 450, 185)
            Fruit8.Adding(Me, 491, 90)
            Fruit9.Adding(Me, 602, 90)
            Fruit10.Adding(Me, 798, 172)
            Fruit11.Adding(Me, 1141, 159)

            Iron1.Adding(Me, 159, 615)
            Iron2.Adding(Me, 241, 633)
            Iron3.Adding(Me, 311, 593)
            Iron4.Adding(Me, 348, 663)
            Iron5.Adding(Me, 407, 593)
            Iron6.Adding(Me, 470, 675)
            Iron7.Adding(Me, 528, 602)
            Iron8.Adding(Me, 602, 684)
            Iron9.Adding(Me, 666, 602)
            Iron10.Adding(Me, 725, 684)
            Iron11.Adding(Me, 775, 615)
            Iron12.Adding(Me, 871, 675)
            Iron13.Adding(Me, 888, 605)
            Iron14.Adding(Me, 986, 672)
            Iron15.Adding(Me, 995, 602)
            Iron16.Adding(Me, 1107, 684)
            Iron17.Adding(Me, 1107, 602)
            Iron18.Adding(Me, 1222, 675)
            Iron19.Adding(Me, 1222, 602)
            Iron20.Adding(Me, 1334, 675)
            Iron21.Adding(Me, 1334, 605)

        End Sub
    End Class
End Namespace
