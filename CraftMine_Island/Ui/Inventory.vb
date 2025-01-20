Imports System
Imports System.Drawing
Imports System.IO
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace CraftMine_V2

    Public Partial Class Inventory
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Inventory_Load(sender As Object, e As EventArgs)

            Update_Labels()

            ' When the user crafts the item, The boolean would be true and therefore would show that the user has the item in the character form

            ' Each if statment is connected to a specific picturebox
            If Craftingtable = True Then
                pic1.Image = My.Resources.Resources.Crafting_Table
            End If

            If furnace = True Then
                pic2.Image = My.Resources.Resources.Furnace
            End If

            If anvil = True Then
                pic3.Image = My.Resources.Resources.Anvil
            End If

            If woodarmor = True Then
                pic4.Image = My.Resources.Resources.Wooden_Armor
            End If

            If ironarmor = True Then
                pic5.Image = My.Resources.Resources.Iron_Armor
            End If

            If goldarmor = True Then
                pic6.Image = My.Resources.Resources.Golden_Armor
            End If

            If woodensword = True Then
                pic12.Image = My.Resources.Resources.Wooden_Sword
            End If

            If woodenpick = True Then
                pic7.Image = My.Resources.Resources.Wooden_Pickaxe
            End If

            If stonepick = True Then
                pic8.Image = My.Resources.Resources.Stone_Pick
            End If

            If ironpick = True Then
                pic9.Image = My.Resources.Resources.Iron_Pick
            End If

            If goldpick = True Then
                pic10.Image = My.Resources.Resources.Golden_Pick
            End If

            If goldaxe = True Then
                pic11.Image = My.Resources.Resources.Golden_Axe
            End If


        End Sub

        Public Sub Update_Labels()

            ' This is to update what the player has when they craft something
            Labelwood.Text = Format("Wood:  " & wood.ToString())
            Labelstone.Text = Format("Stone:  " & stone.ToString())
            Labelcoal.Text = Format("Coal:  " & coal.ToString())
            LabelIron.Text = Format("Iron:  " & iron.ToString())
            Labelgold.Text = Format("Gold:  " & gold.ToString())
            LabelIronbar.Text = Format("Iron Bar:  " & ironbar.ToString())
            Labelgoldbar.Text = Format("Gold Bar:  " & goldbar.ToString())

            LabelPoints.Text = Format("You have collected these points: " & Points.ToString())
            LabelTime.Text = Format("You have played for: " & " Hours:  " & hour.ToString() & " , Minutes:  " & minutes.ToString() & " , Seconds:  " & seconds.ToString())
            Labeltrees.Text = Format("You have destroyed " & treevalue.ToString() & " of Trees ")
            LabelRock.Text = Format("You have destroyed " & rockvalue.ToString() & " of Rocks ")
            Label23.Text = Format("You have destroyed " & mineralvalue.ToString() & " of Minerals ")

            Quest1.Text = Format(" - Get 5 Wood")
            Quest2.Text = Format(" - Get a Crafting Table")
            Quest3.Text = Format(" - Create a Wooden Pickaxe")
            Quest4.Text = Format(" - Get 5 Coal, 5 Iron, 5 Gold")
            Quest5.Text = Format(" - Get 10 Gold Bars")
            Quest6.Text = Format(" - Get 150 Points")
            Quest7.Text = Format(" - Create Ship")


            ' This is for the Quest and if the requirements are good then it would change and you would get points

            Dim Q1 As Boolean = Nothing, Q2 As Boolean = Nothing, Q3 As Boolean = Nothing, Q4 As Boolean = Nothing, Q5 As Boolean = Nothing, Q6 As Boolean = Nothing

            If Q1 = True Then

                Quest1.Text = Format(" - Get 5 Wood - DONE")
                Quest1.ForeColor = Color.Green

            ElseIf Q2 = True Then
                Quest2.Text = Format(" - Get a Crafting Table - DONE")
                Quest2.ForeColor = Color.Green

            ElseIf Q3 = True Then
                Quest3.Text = Format(" - Create a Wooden Pickaxe - DONE")
                Quest3.ForeColor = Color.Green

            ElseIf Q4 = True Then
                Quest4.Text = Format(" - Get 5 Coal, 5 Iron, 5 Gold - DONE")
                Quest4.ForeColor = Color.Green

            ElseIf Q5 = True Then
                Quest5.Text = Format(" - Get 10 Gold Bars - DONE")
                Quest5.ForeColor = Color.Green

            ElseIf Q6 = True Then
                Quest6.Text = Format(" - Get 150 Points - DONE")
                Quest6.ForeColor = Color.Green

            End If




        End Sub
        Private Sub Export1_Click(sender As Object, e As EventArgs)

            correctuser = "Bob"
            Points = 50
            level = 5
            wood = 2
            stone = 6
            coal = 8
            iron = 3
            ironbar = 15
            goldbar = 20
            treevalue = 37
            rockvalue = 23
            mineralvalue = 50

            ' This is used to write 

            Dim Filewriter = New StreamWriter(infofile, True)

            If MsgBox("Would you like to put your data in a file so you can show off to your friends?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Filewriter.WriteLine("

-----------------------------------------------------------------------------------------------------

This infomation is for the username called " & correctuser & ", Here is all of your thing which are provided by the Craft-Mine Security 

In your journey, You have colleted " & Points.ToString() & " points and you are level" & level.ToString() & ", Nice :)

As you are a theif to nature, You have collected " & wood.ToString() & " Wood, " & stone.ToString() & " Stone, " & coal.ToString() & " Coal, " & iron.ToString() & " Iron, " & gold.ToString() & " Gold, " & ironbar.ToString() & " Iron Bars, " & goldbar.ToString() & " gold Bars, 

You are a danger to nature!!, You have destroyed " & treevalue.ToString() & " Trees, " & rockvalue.ToString() & " Rocks, " & mineralvalue.ToString() & " Minerals

Dammm thats a lot. 

-----------------------------------------------------------------------------------------------------

")
                Filewriter.Close()  ' Uses the varible from the user input

            End If

        End Sub


        Private Sub Craftpress1_Click(sender As Object, e As EventArgs) ' Crafting Table

            ironpick = True

            If Craftingtable = False Then

                If wood < 4 Then

                    MsgBox("You need to get more materials to get the item")

                ElseIf wood >= 4 Then

                    MsgBox("Nice, you have a crafting table now :)")
                    wood -= 4
                    Craftingtable = True


                End If

            End If

        End Sub

        Private Sub Craftpress2_Click(sender As Object, e As EventArgs) ' Furnace


            If furnace = False Then

                If Craftingtable = False Then
                    MsgBox("Get a crafting Table first")

                ElseIf stone < 9 Then
                    MsgBox("You need to get more materials to get the item")

                ElseIf stone >= 9 Then

                    MsgBox("Nice, you have a Furnace now :)")
                    stone -= 9
                    furnace = True

                End If

            End If


        End Sub

        Private Sub Craftpress3_Click(sender As Object, e As EventArgs) ' Anvil

            If ironbar < 7 And anvil = False Then

                MsgBox("You need to get more materials to get the item")

            ElseIf ironbar >= 7 Then

                MsgBox("Nice, you have a crafting table now :)")
                ironbar -= 7
                anvil = True


            End If

        End Sub

        Private Sub Armorpress1_Click(sender As Object, e As EventArgs) ' Wooden armor

            If wood < 5 And woodarmor = False Then

                MsgBox("You need to get more materials to get the item")

            ElseIf Craftingtable = False Then
                MsgBox("Get a crafting Table first")

            ElseIf wood >= 5 And Craftingtable = True Then

                MsgBox("Nice, you have Wooden Armor now :)")
                wood -= 5
                woodarmor = True
                Update_Labels()

            End If

        End Sub

        Private Sub Armorpress2_Click(sender As Object, e As EventArgs) ' Iron armor

            If ironbar < 5 And ironbar = Conversions.ToInteger(False) Then

                MsgBox("You need to get more materials to get the item")

            ElseIf anvil = False Then
                MsgBox("Get a Anvil first")

            ElseIf ironbar >= 5 And Craftingtable = True Then

                MsgBox("Nice, you have Iron Armor now :)")
                ironbar -= 5
                ironarmor = True
                Update_Labels()

            End If

        End Sub

        Private Sub Armorpress3_Click(sender As Object, e As EventArgs) ' Gold armor

            If goldbar < 5 And goldarmor = False Then

                MsgBox("You need to get more materials to get the item")

            ElseIf anvil = False Then
                MsgBox("Get a Anvil first")

            ElseIf goldbar >= 5 And anvil = True Then

                MsgBox("Nice, you have Gold Armor now :)")
                goldbar -= 5
                goldarmor = True
                Update_Labels()

            End If

        End Sub

        Private Sub Toolpress1_Click(sender As Object, e As EventArgs) ' Wooden Sword

            If wood < 4 And woodensword = False Then

                MsgBox("You need to get more materials to get the item")

            ElseIf Craftingtable = False Then
                MsgBox("Get a crafting Table first")

            ElseIf wood >= 4 And Craftingtable = True Then

                MsgBox("Nice, you have Wooden Sword now :)")
                wood -= 4
                woodensword = True
                Update_Labels()

            End If

        End Sub

        Private Sub Toolpress2_Click(sender As Object, e As EventArgs) ' Wooden Pickaxe

            If wood < 5 And woodenpick = False Then

                MsgBox("You need to get more materials to get the item")

            ElseIf Craftingtable = False Then
                MsgBox("Get a crafting Table first")

            ElseIf wood >= 5 And Craftingtable = True Then

                MsgBox("Nice, you have a Wooden Pickaxe now :)")
                wood -= 5
                woodenpick = True
                Update_Labels()

            End If

        End Sub

        Private Sub Toolpress3_Click(sender As Object, e As EventArgs) ' Stone Pickaxe

            If stone < 5 And stonepick = False Then

                MsgBox("You need to get more materials to get the item")

            ElseIf Craftingtable = False Then
                MsgBox("Get a crafting Table first")

            ElseIf stone >= 5 And Craftingtable = True Then
                MsgBox("Nice, you have a Stone Pickaxe now :)")
                stone -= 5
                stonepick = True
                Update_Labels()

            End If

        End Sub

        Private Sub Toolpress4_Click(sender As Object, e As EventArgs) ' Iron pickaxe

            If ironbar < 5 And ironpick = False Then

                MsgBox("You need to get more materials to get the item")

            ElseIf anvil = False Then
                MsgBox("Get a Anvil first")

            ElseIf ironbar >= 5 And anvil = True Then
                MsgBox("Nice, you have a Stone Pickaxe now :)")
                ironbar -= 5
                ironpick = True
                Update_Labels()

            End If

        End Sub

        Private Sub Toolpress5_Click(sender As Object, e As EventArgs) ' Golden Pickaxe

            If goldbar < 5 And goldpick = False Then

                MsgBox("You need to get more materials to get the item")

            ElseIf anvil = False Then
                MsgBox("Get a Anvil first")

            ElseIf goldbar >= 5 And anvil = True Then
                MsgBox("Nice, you have a Golden Pickaxe now :)")
                goldbar -= 5
                goldpick = True
                Update_Labels()

            End If

        End Sub

        Private Sub Toolpress6_Click(sender As Object, e As EventArgs) ' Golden Axe

            If goldbar < 5 And goldaxe = False Then

                MsgBox("You need to get more materials to get the item")

            ElseIf anvil = False Then
                MsgBox("Get a Anvil first")

            ElseIf goldbar >= 5 And anvil = True Then
                MsgBox("Nice, you have a Golden axe now :)")
                goldbar -= 5
                goldaxe = True
                Update_Labels()

            End If

        End Sub

        Private Sub Ironbar1_Click(sender As Object, e As EventArgs) ' Iron Bar

            If iron < 1 And coal < 1 Then

                MsgBox("You need to get more materials to get the item")

            ElseIf furnace = False Then
                MsgBox("Get a furnace first")

            ElseIf iron >= 1 And coal >= 1 And furnace = True Then
                MsgBox("Nice, you have a Iron bar now :)")
                coal -= 1
                iron -= 1
                ironbar += 1
                Update_Labels()

            End If

        End Sub

        Private Sub Goldbar1_Click(sender As Object, e As EventArgs) ' Gold Bar

            If gold < 1 And coal < 1 Then

                MsgBox("You need to get more materials to get the item")

            ElseIf furnace = False Then
                MsgBox("Get a furnace first")

            ElseIf gold >= 1 And coal >= 1 And furnace = True Then
                MsgBox("Nice, you have a Iron bar now :)")
                gold -= 1
                iron -= 1
                goldbar += 1
                Update_Labels()

            End If

        End Sub



        Private Sub Button1_Click(sender As Object, e As EventArgs)
            If MsgBox("Would you like to leave the game?, You points will be added up together and will be put into the LeaderBoard", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                totalpoints = Points + wood + stone + coal + iron + gold + ironbar + goldbar + treevalue + rockvalue + mineralvalue ' This will add all of the points together and this would then be placed into the leaderboard 

                Call MsgBox("You have gained " & totalpoints.ToString() & " Points, Amazing! " & correctuser)
            Else

            End If


            Filewriter.WriteLine(correctuser & ":" & totalpoints.ToString()) ' Uses the varible from the user input 
            Filewriter.Close()

            For Each form In formlist

                form.Visible = False

                Visible = False

                Close()

            Next

        End Sub

        Private Sub Inventory_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
