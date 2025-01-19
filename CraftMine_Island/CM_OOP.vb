Module CM_OOP ' CraftMine (Object Oriented programming)

    Public counter As Integer
    Public charatercollision As Boolean
    Public wood, stone, coal, iron, gold, ironbar, goldbar As Integer

    Public treestorage, fruitstorage, rockstorage, Coalstorage, Ironstorage, Goldstorage As New List(Of PictureBox)
    Public formlist As New List(Of Form)

    ' Creates all of the players for each form
    Public PlayerP As New Playerbox(48, 48, My.Resources.Front_Character)
    Public PlayerT As New Playerbox(48, 48, My.Resources.Front_Character)
    Public PlayerM As New Playerbox(48, 48, My.Resources.Front_Character)
    Public PlayerB As New Playerbox(48, 48, My.Resources.Front_Character)
    Public PlayerF As New Playerbox(48, 48, My.Resources.Front_Character)

    ' Grassland
    '--------------------------------------------------------------------------
    Public tree1 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree2 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree3 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree4 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree5 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree6 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree7 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree8 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree9 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree10 As New Tree(64, 64, My.Resources.Plain_Tree)
    Public tree11 As New Tree(64, 64, My.Resources.Plain_Tree)

    Public Fruit1 As New Fruit_tree(64, 64, My.Resources.Fruit_Tree)
    Public Fruit2 As New Fruit_tree(64, 64, My.Resources.Fruit_Tree)
    Public Fruit3 As New Fruit_tree(64, 64, My.Resources.Fruit_Tree)
    Public Fruit4 As New Fruit_tree(64, 64, My.Resources.Fruit_Tree)

    Public Rock1 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock2 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock3 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock4 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock5 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock6 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock7 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock8 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock9 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock10 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock11 As New Rock(64, 64, My.Resources.Normal_Rock)

    Public Coal1 As New Coal_Node(64, 64, My.Resources.Coal_Node)
    Public Coal2 As New Coal_Node(64, 64, My.Resources.Coal_Node)

    ' Snowland
    '--------------------------------------------------------------------------
    Public tree12 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree13 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree14 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree15 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree16 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree17 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree18 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree19 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree20 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree21 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree22 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree23 As New Tree(64, 64, My.Resources.White_Plain_Tree)
    Public tree24 As New Tree(64, 64, My.Resources.White_Plain_Tree)

    Public Fruit5 As New Fruit_tree(64, 64, My.Resources.White_Fruit_Tree)
    Public Fruit6 As New Fruit_tree(64, 64, My.Resources.White_Fruit_Tree)
    Public Fruit7 As New Fruit_tree(64, 64, My.Resources.White_Fruit_Tree)
    Public Fruit8 As New Fruit_tree(64, 64, My.Resources.White_Fruit_Tree)
    Public Fruit9 As New Fruit_tree(64, 64, My.Resources.White_Fruit_Tree)
    Public Fruit10 As New Fruit_tree(64, 64, My.Resources.White_Fruit_Tree)
    Public Fruit11 As New Fruit_tree(64, 64, My.Resources.White_Fruit_Tree)

    Public Iron1 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron2 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron3 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron4 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron5 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron6 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron7 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron8 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron9 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron10 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron11 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron12 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron13 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron14 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron15 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron16 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron17 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron18 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron19 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron20 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron21 As New Iron_Node(64, 64, My.Resources.Iron_Node)


    ' Mountains
    '--------------------------------------------------------------------------
    Public Rock12 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock13 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock14 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock15 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock16 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock17 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock18 As New Rock(64, 64, My.Resources.Normal_Rock)
    Public Rock19 As New Rock(64, 64, My.Resources.Normal_Rock)

    Public Iron22 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron23 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron24 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron25 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron26 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron27 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron28 As New Iron_Node(64, 64, My.Resources.Iron_Node)
    Public Iron29 As New Iron_Node(64, 64, My.Resources.Iron_Node)

    Public Gold1 As New Gold_Node(64, 64, My.Resources.Gold_Node)
    Public Gold2 As New Gold_Node(64, 64, My.Resources.Gold_Node)
    Public Gold3 As New Gold_Node(64, 64, My.Resources.Gold_Node)
    Public Gold4 As New Gold_Node(64, 64, My.Resources.Gold_Node)
    Public Gold5 As New Gold_Node(64, 64, My.Resources.Gold_Node)
    Public Gold6 As New Gold_Node(64, 64, My.Resources.Gold_Node)
    Public Gold7 As New Gold_Node(64, 64, My.Resources.Gold_Node)

    Public Coal3 As New Coal_Node(64, 64, My.Resources.Coal_Node)
    Public Coal4 As New Coal_Node(64, 64, My.Resources.Coal_Node)
    Public Coal5 As New Coal_Node(64, 64, My.Resources.Coal_Node)
    Public Coal6 As New Coal_Node(64, 64, My.Resources.Coal_Node)
    Public Coal7 As New Coal_Node(64, 64, My.Resources.Coal_Node)
    Public Coal8 As New Coal_Node(64, 64, My.Resources.Coal_Node)
    Public Coal9 As New Coal_Node(64, 64, My.Resources.Coal_Node)

    ' Beach
    '--------------------------------------------------------------------------

    Public tree25 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)
    Public tree26 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)
    Public tree27 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)
    Public tree28 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)
    Public tree29 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)
    Public tree30 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)
    Public tree31 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)
    Public tree32 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)
    Public tree33 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)
    Public tree34 As New Tree(64, 64, My.Resources.Plain_Beach_Tree)

    Public Ship As New CM_Objects(128, 64, My.Resources.Broke_ship)

    ' Forest
    '--------------------------------------------------------------------------

    Public tree35 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree36 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree37 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree38 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree39 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree40 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree41 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree42 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree43 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree44 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree45 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree46 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree47 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree48 As New Tree(64, 64, My.Resources.Dark_Plain_tree)
    Public tree49 As New Tree(64, 64, My.Resources.Dark_Plain_tree)

    Public Fruit12 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit13 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit14 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit15 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit16 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit17 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit18 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit19 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit20 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit21 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit22 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)
    Public Fruit23 As New Fruit_tree(64, 64, My.Resources.Dark_Fruit_Tree)

    ' This will be used for the puzzle 
    Public Redbox As New CM_Objects(40, 40, My.Resources.Red)
    Public Bluebox As New CM_Objects(40, 40, My.Resources.Blue)
    Public Yellowbox As New CM_Objects(40, 40, My.Resources.Yellow)
    Public Greenbox As New CM_Objects(40, 40, My.Resources.Green)
    Public Orangebox As New CM_Objects(40, 40, My.Resources.Orange)


    Public Class CM_Objects ' Main Parent Class

        Inherits PictureBox

        Public Sub New(W As Integer, H As Integer, MainImage As Image)

            Size = New Size(W, H)

            Image = MainImage

            BackColor = Color.Transparent

        End Sub

        Public Sub Adding(form As Form, X As Integer, Y As Integer) ' Adds the picturebox to the form

            Location = New Point(X, Y)

            form.Controls.Add(Me)

        End Sub

    End Class

    Public Class Tree

        Inherits CM_Objects

        Public Sub New(W As Integer, H As Integer, MainImage As Image)

            MyBase.New(W, H, MainImage)

            treestorage.Add(Me)

        End Sub

    End Class

    Public Class Fruit_tree

        Inherits CM_Objects

        Public Sub New(W As Integer, H As Integer, MainImage As Image)

            MyBase.New(W, H, MainImage)

            fruitstorage.Add(Me)

        End Sub


    End Class

    Public Class Rock

        Inherits CM_Objects

        Public Sub New(W As Integer, H As Integer, MainImage As Image)

            MyBase.New(W, H, MainImage)

            rockstorage.Add(Me)

        End Sub

    End Class

    Public Class Coal_Node

        Inherits CM_Objects

        Public Sub New(W As Integer, H As Integer, MainImage As Image)

            MyBase.New(W, H, MainImage)

            Coalstorage.Add(Me)

        End Sub


    End Class

    Public Class Iron_Node

        Inherits CM_Objects

        Public Sub New(W As Integer, H As Integer, MainImage As Image)

            MyBase.New(W, H, MainImage)

            Ironstorage.Add(Me)

        End Sub


    End Class

    Public Class Gold_Node

        Inherits CM_Objects

        Public Sub New(W As Integer, H As Integer, MainImage As Image)

            MyBase.New(W, H, MainImage)

            treestorage.Add(Me)

        End Sub


    End Class

    Public Class Playerbox

        Inherits CM_Objects

        Dim playerspeed As Integer = 5 ' Determines the speed of the user
        Dim rnmaterials, rnpoints As Integer
        Dim rnnumber As New Random


        Public Sub New(W As Integer, H As Integer, MainImage As Image)

            MyBase.New(W, H, MainImage)

        End Sub

        Public Sub Movements(e As KeyEventArgs)

            If e.KeyData = Keys.D Then
                Me.Image = My.Resources.Right_Character
                Me.Left += 5

            ElseIf e.KeyData = Keys.A Then
                Me.Image = My.Resources.Left_Character
                Me.Left -= 5

            ElseIf e.KeyData = Keys.W Then
                Me.Image = My.Resources.Back_Character
                Me.Top -= 5

            ElseIf e.KeyData = Keys.S Then
                Me.Image = My.Resources.Front_Character
                Me.Top += 5

            End If

        End Sub

        Public Sub Collosion()

            Type_one(treestorage, wood, treevalue, goldaxe)
            Type_one(fruitstorage, wood, treevalue, goldaxe)
            Type_two(rockstorage, stone, rockvalue, goldpick, woodenpick)
            Type_two(Coalstorage, coal, rockvalue, goldpick, stonepick)
            Type_two(Ironstorage, iron, rockvalue, goldpick, stonepick)
            Type_two(Goldstorage, gold, rockvalue, goldpick, ironpick)


        End Sub

        Public Sub Type_one(ByRef Storage As List(Of PictureBox), ByRef Material As Integer, ByRef value As Integer, ByRef Special_item As Boolean)


            For Each Item As PictureBox In Storage ' checks which item has been collided

                If Me.Bounds.IntersectsWith(Item.Bounds) And Item.Visible = True Then ' Start of solution

                    Mining.Visible = True
                    charatercollision = True

                    If counter = 3 Then ' This will remove object and add points
                        Item.Visible = False
                        Mining.Visible = False
                        charatercollision = False
                        rnmaterials = rnnumber.Next(1, 7)
                        rnpoints = rnnumber.Next(1, 5)

                        MsgBox("You have collected " & rnmaterials & " materials and  " & rnpoints & " Points ")

                        Points += rnpoints
                        Material += rnmaterials
                        value += 1
                        counter = 0


                    ElseIf counter = 3 And Special_item = True Then ' Special Item allows you to get more points
                        Item.Visible = False
                        Mining.Visible = False
                        charatercollision = False
                        rnmaterials = rnnumber.Next(1, 7)
                        rnpoints = rnnumber.Next(1, 5)

                        MsgBox("You have collected " & rnmaterials & " materials and  " & rnpoints & " Points ")

                        Points += (rnpoints * 3)
                        Material += (rnmaterials * 3)
                        value += 1
                        counter = 0

                    End If

                End If

                If Item.Visible = False And seconds = 60 Then
                    Item.Visible = True
                End If
            Next


        End Sub

        ' This Second type of collision is mostly on the Rocks and nodes which may need tools to break 
        Public Sub Type_two(ByRef Storage As List(Of PictureBox), ByRef Material As Integer, ByRef value As Integer, ByRef Special_item As Boolean, ByRef Correct_item As Boolean)

            For Each Item As PictureBox In Storage

                If Me.Bounds.IntersectsWith(Item.Bounds) And Item.Visible = True Then


                    Mining.Visible = True
                    charatercollision = True

                    If counter = 3 And Correct_item = False Then '
                        Me.Location = New Point(779, 413)
                        Mining.Visible = False

                        counter = 0

                        MsgBox(" You need to have a Pickaxe or a better version. It goes from Wood, Stone, Iron, Gold :D  ")

                    ElseIf counter = 3 And Correct_item = True Then
                        Item.Visible = False
                        Mining.Visible = False
                        charatercollision = False
                        rnmaterials = rnnumber.Next(1, 7)
                        rnpoints = rnnumber.Next(1, 5)

                        MsgBox("You have collected " & rnmaterials & " materials and  " & rnpoints & " Points ")

                        Points += rnpoints
                        Material += rnmaterials
                        value += 1
                        counter = 0

                    ElseIf counter = 3 And Special_item = True Then
                        Item.Visible = False
                        Mining.Visible = False
                        charatercollision = False
                        rnmaterials = rnnumber.Next(1, 7)
                        rnpoints = rnnumber.Next(1, 5)

                        MsgBox("You have collected " & rnmaterials & " materials and  " & rnpoints & " Points ")

                        Points += (rnpoints * 3)
                        Material += (rnmaterials * 3)
                        value += 1
                        counter = 0

                    End If
                End If
                If Item.Visible = False And seconds = 60 Then
                    Item.Visible = True
                End If
            Next

        End Sub

        Public Sub Puzzle_collision() '////PROGRESS////

            Dim ColourStack As New Stack
            Dim Retry As Boolean

            Dim correctOrder As String
            Dim checkOrder As String

            Dim stackValue As Integer = 0

            ' Collision for Puzzle
            If Me.Bounds.IntersectsWith(Redbox.Bounds) And Redbox.Visible = True Then
                ColourStack.Push("Red")
                stackValue += 1
                Redbox.Visible = False

            ElseIf Me.Bounds.IntersectsWith(Orangebox.Bounds) And Orangebox.Visible = True Then
                ColourStack.Push("Orange")
                stackValue += 1
                Orangebox.Visible = False

            ElseIf Me.Bounds.IntersectsWith(Yellowbox.Bounds) And Yellowbox.Visible = True Then
                ColourStack.Push("Yellow")
                stackValue += 1
                Yellowbox.Visible = False

            ElseIf Me.Bounds.IntersectsWith(Greenbox.Bounds) And Greenbox.Visible = True Then
                ColourStack.Push("Green")
                stackValue += 1
                Greenbox.Visible = False

            ElseIf Me.Bounds.IntersectsWith(Bluebox.Bounds) And Bluebox.Visible = True Then
                ColourStack.Push("Blue")
                stackValue += 1
                Bluebox.Visible = False

            End If

            ' Correct Order
            correctOrder = "Red, Orange, Yellow, Green, Blue"


            If Redbox.Visible = False And Orangebox.Visible = False And Yellowbox.Visible = False And Greenbox.Visible = False And Bluebox.Visible = False Then



                ' Data Popped
                Dim firstvalue As String = ColourStack.Pop
                Dim Secondvalue As String = ColourStack.Pop
                Dim Thirdvalue As String = ColourStack.Pop
                Dim Fouthvalue As String = ColourStack.Pop
                Dim Fifthvalue As String = ColourStack.Pop

                ' Adds String together 
                checkOrder = firstvalue & ", " & Secondvalue & ", " & Thirdvalue & ", " & Fouthvalue & ", " & Fifthvalue

                ' Ouputs Order
                MsgBox(checkOrder)

                ' If Correct
                If correctOrder = checkOrder Then

                    MsgBox("Correct, Well done!")

                Else
                    ' Not Correct
                    MsgBox("That does not look right...Lets try again")
                    Retry = True
                End If

            End If

            ' Retry
            If Retry = True Then
                Redbox.Visible = True
                Orangebox.Visible = True
                Yellowbox.Visible = True
                Greenbox.Visible = True
                Bluebox.Visible = True
                Retry = False
            End If

        End Sub
        Public Sub Ship_collision() '////PROGRESS////

            Dim done As Boolean
            Dim completed As Boolean

            ' if User gets all materials then it becomes true
            If wood >= 50 And stone >= 50 And iron >= 50 And gold >= 50 And coal >= 50 Then

                done = True

            End If

            If Me.Bounds.IntersectsWith(Ship.Bounds) And Ship.Visible = True Then


                Shipp.Visible = True
                charatercollision = True

                ' Tells user about the ship
                If counter = 3 And done = False And completed = False Then

                    Me.Location = New Point(779, 413)
                    MsgBox("The ship is broken and I need to fix it ")
                    MsgBox("I can fully repair the ship if I collect: 50 wood, 50 stone, 50 gold, 50 iron, 50 coal ")
                    counter = 0


                    ' Tells user that they fix the ship
                ElseIf counter = 3 And done = True And completed = False Then

                    Me.Location = New Point(779, 413)
                    MsgBox("The Ship is Fixed, I can escape! ")
                    counter = 0

                    completed = True
                    Ship.Image = My.Resources.Shipluffy

                    If MsgBox("I can leave this place and get 500 bounus Points!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        totalpoints = Points + wood + stone + coal + iron + gold + ironbar + goldbar + treevalue + rockvalue + mineralvalue + 500

                        MsgBox("You have gained " & totalpoints & " Points, Amazing! " & correctuser)

                        ' Opens file which is used for the leaderboard as it reads from the file
                        Filewriter.WriteLine(correctuser & ":" & totalpoints)
                        Filewriter.Close()

                        For Each form In formlist

                            form.Visible = False

                            Me.Visible = False

                            End

                        Next

                    End If
                End If
            End If

        End Sub
    End Class

End Module
