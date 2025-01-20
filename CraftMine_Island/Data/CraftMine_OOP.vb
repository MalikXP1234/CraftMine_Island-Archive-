Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace CraftMine_V2

    Friend Module Objects

        Public counter As Integer
        Public charatercollision As Boolean
        Public wood, stone, coal, iron, gold, ironbar, goldbar As Integer


        ' Creates all of the players for each form
        Public PlayerG As Playerbox = New Playerbox(48, 48, My.Resources.Resources.Front_Character)
        Public PlayerS As Playerbox = New Playerbox(48, 48, My.Resources.Resources.Front_Character)
        Public PlayerM As Playerbox = New Playerbox(48, 48, My.Resources.Resources.Front_Character)
        Public PlayerB As Playerbox = New Playerbox(48, 48, My.Resources.Resources.Front_Character)
        Public PlayerF As Playerbox = New Playerbox(48, 48, My.Resources.Resources.Front_Character)

        ' Grassland
        ' --------------------------------------------------------------------------
        Public tree1 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree2 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree3 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree4 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree5 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree6 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree7 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree8 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree9 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree10 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)
        Public tree11 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Tree)

        Public Fruit1 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Fruit_Tree)
        Public Fruit2 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Fruit_Tree)
        Public Fruit3 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Fruit_Tree)
        Public Fruit4 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Fruit_Tree)

        Public Rock1 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock2 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock3 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock4 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock5 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock6 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock7 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock8 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock9 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock10 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock11 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)

        Public Coal1 As Coal_Node = New Coal_Node(64, 64, My.Resources.Resources.Coal_Node)
        Public Coal2 As Coal_Node = New Coal_Node(64, 64, My.Resources.Resources.Coal_Node)

        ' Snowland
        ' --------------------------------------------------------------------------
        Public tree12 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree13 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree14 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree15 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree16 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree17 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree18 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree19 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree20 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree21 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree22 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree23 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)
        Public tree24 As Tree = New Tree(64, 64, My.Resources.Resources.White_Plain_Tree)

        Public Fruit5 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.White_Fruit_Tree)
        Public Fruit6 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.White_Fruit_Tree)
        Public Fruit7 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.White_Fruit_Tree)
        Public Fruit8 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.White_Fruit_Tree)
        Public Fruit9 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.White_Fruit_Tree)
        Public Fruit10 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.White_Fruit_Tree)
        Public Fruit11 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.White_Fruit_Tree)

        Public Iron1 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron2 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron3 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron4 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron5 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron6 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron7 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron8 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron9 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron10 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron11 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron12 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron13 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron14 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron15 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron16 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron17 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron18 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron19 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron20 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron21 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)


        ' Mountains
        ' --------------------------------------------------------------------------
        Public Rock12 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock13 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock14 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock15 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock16 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock17 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock18 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)
        Public Rock19 As Rock = New Rock(64, 64, My.Resources.Resources.Normal_Rock)

        Public Iron22 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron23 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron24 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron25 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron26 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron27 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron28 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)
        Public Iron29 As Iron_Node = New Iron_Node(64, 64, My.Resources.Resources.Iron_Node)

        Public Gold1 As Gold_Node = New Gold_Node(64, 64, My.Resources.Resources.Gold_Node)
        Public Gold2 As Gold_Node = New Gold_Node(64, 64, My.Resources.Resources.Gold_Node)
        Public Gold3 As Gold_Node = New Gold_Node(64, 64, My.Resources.Resources.Gold_Node)
        Public Gold4 As Gold_Node = New Gold_Node(64, 64, My.Resources.Resources.Gold_Node)
        Public Gold5 As Gold_Node = New Gold_Node(64, 64, My.Resources.Resources.Gold_Node)
        Public Gold6 As Gold_Node = New Gold_Node(64, 64, My.Resources.Resources.Gold_Node)
        Public Gold7 As Gold_Node = New Gold_Node(64, 64, My.Resources.Resources.Gold_Node)

        Public Coal3 As Coal_Node = New Coal_Node(64, 64, My.Resources.Resources.Coal_Node)
        Public Coal4 As Coal_Node = New Coal_Node(64, 64, My.Resources.Resources.Coal_Node)
        Public Coal5 As Coal_Node = New Coal_Node(64, 64, My.Resources.Resources.Coal_Node)
        Public Coal6 As Coal_Node = New Coal_Node(64, 64, My.Resources.Resources.Coal_Node)
        Public Coal7 As Coal_Node = New Coal_Node(64, 64, My.Resources.Resources.Coal_Node)
        Public Coal8 As Coal_Node = New Coal_Node(64, 64, My.Resources.Resources.Coal_Node)
        Public Coal9 As Coal_Node = New Coal_Node(64, 64, My.Resources.Resources.Coal_Node)

        ' Beach
        ' --------------------------------------------------------------------------

        Public tree25 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)
        Public tree26 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)
        Public tree27 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)
        Public tree28 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)
        Public tree29 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)
        Public tree30 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)
        Public tree31 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)
        Public tree32 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)
        Public tree33 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)
        Public tree34 As Tree = New Tree(64, 64, My.Resources.Resources.Plain_Beach_Tree)

        Public Ship As Game_object = New Game_object(128, 64, My.Resources.Resources.Broke_ship)

        ' Forest
        ' --------------------------------------------------------------------------

        Public tree35 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree36 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree37 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree38 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree39 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree40 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree41 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree42 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree43 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree44 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree45 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree46 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree47 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree48 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)
        Public tree49 As Tree = New Tree(64, 64, My.Resources.Resources.Dark_Plain_tree)

        Public Fruit12 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit13 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit14 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit15 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit16 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit17 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit18 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit19 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit20 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit21 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit22 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)
        Public Fruit23 As Fruit_tree = New Fruit_tree(64, 64, My.Resources.Resources.Dark_Fruit_Tree)

        ' This will be used for the puzzle 
        Public Redbox As Game_object = New Game_object(40, 40, My.Resources.Resources.Red_PressurePlate)
        Public Bluebox As Game_object = New Game_object(40, 40, My.Resources.Resources.Blue_PressurePlate)
        Public Yellowbox As Game_object = New Game_object(40, 40, My.Resources.Resources.Yellow_PressurePlate)
        Public Greenbox As Game_object = New Game_object(40, 40, My.Resources.Resources.Green_PressurePlate)
        Public Orangebox As Game_object = New Game_object(40, 40, My.Resources.Resources.Orange_PressurePlate)
        Public Sign As Game_object = New Game_object(40, 40, My.Resources.Resources.Sign_image)



        Public Class CraftMine_Object
            Inherits PictureBox

            Public Sub New(W As Integer, H As Integer, MainImage As Image)

                Size = New Size(W, H)

                Image = MainImage

                MyBase.BackColor = Color.Transparent

            End Sub

            Public Sub Adding(form As Form, X As Integer, Y As Integer)

                Location = New Point(X, Y)

                form.Controls.Add(Me)

            End Sub

        End Class


        Public Class Tree
            Inherits CraftMine_Object


            Public Sub New(W As Integer, H As Integer, MainImage As Image)
                MyBase.New(W, H, MainImage)

                treestorage.Add(Me)

            End Sub

        End Class


        Public Class Fruit_tree
            Inherits CraftMine_Object


            Public Sub New(W As Integer, H As Integer, MainImage As Image)
                MyBase.New(W, H, MainImage)

                fruitstorage.Add(Me)

            End Sub


        End Class


        Public Class Rock
            Inherits CraftMine_Object


            Public Sub New(W As Integer, H As Integer, MainImage As Image)
                MyBase.New(W, H, MainImage)

                rockstorage.Add(Me)

            End Sub

        End Class


        Public Class Coal_Node
            Inherits CraftMine_Object


            Public Sub New(W As Integer, H As Integer, MainImage As Image)
                MyBase.New(W, H, MainImage)

                Coalstorage.Add(Me)

            End Sub


        End Class


        Public Class Iron_Node
            Inherits CraftMine_Object


            Public Sub New(W As Integer, H As Integer, MainImage As Image)
                MyBase.New(W, H, MainImage)

                Ironstorage.Add(Me)

            End Sub


        End Class


        Public Class Gold_Node
            Inherits CraftMine_Object


            Public Sub New(W As Integer, H As Integer, MainImage As Image)
                MyBase.New(W, H, MainImage)

                Goldstorage.Add(Me)

            End Sub


        End Class


        Public Class Game_object
            Inherits CraftMine_Object ' This object will be used for other types of ojects which are different to the normal like a Ship or a puzzle


            Public Sub New(W As Integer, H As Integer, MainImage As Image)
                MyBase.New(W, H, MainImage)


            End Sub

        End Class


        Public Class Playerbox
            Inherits CraftMine_Object

            Private playerspeed As Integer = 5 ' Spped of player
            Private rnmaterials, rnpoints As Integer
            Private rnnumber As Random = New Random()
            Private stackValue As Integer = 0
            Private ColourStack As Stack = New Stack()



            Public Sub New(W As Integer, H As Integer, MainImage As Image)
                MyBase.New(W, H, MainImage)

            End Sub

            Public Sub Movement() ' Movement for player
                                ''' Cannot convert SwitchStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.CaseClauseSyntax'.
'''    at System.Linq.Enumerable.<CastIterator>d__97`1.MoveNext()
'''    at Microsoft.CodeAnalysis.VisualBasic.SyntaxFactory.SeparatedList[TNode](IEnumerable`1 nodes)
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.ConvertSwitchSection(SwitchSectionSyntax section)
'''    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
'''    at System.Linq.Buffer`1..ctor(IEnumerable`1 source)
'''    at System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitSwitchStatement(SwitchStatementSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input:
''' 
'''                 switch (true)
'''                 {
''' 
'''                     case object _ when CraftMine_V2.CraftMine_Subroutines.playerup:
'''                         {
'''                             base.Top = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(base.Top - 5);
'''                             base.Image = CraftMine_V2.My.Resources.Resources.Back_Character;
'''                             break;
'''                         }
''' 
'''                     case object _ when CraftMine_V2.CraftMine_Subroutines.playerdown:
'''                         {
'''                             base.Top = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(base.Top + 5);
'''                             base.Image = CraftMine_V2.My.Resources.Resources.Front_Character;
'''                             break;
'''                         }
''' 
'''                     case object _ when CraftMine_V2.CraftMine_Subroutines.playerright:
'''                         {
'''                             base.Left = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(base.Left + 5);
'''                             base.Image = CraftMine_V2.My.Resources.Resources.Right_Character;
'''                             break;
'''                         }
''' 
'''                     case object _ when CraftMine_V2.CraftMine_Subroutines.playerleft:
'''                         {
'''                             base.Left = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(base.Left - 5);
'''                             base.Image = CraftMine_V2.My.Resources.Resources.Left_Character;
'''                             break;
'''                         }
''' 
'''                 }
''' 
''' 

            End Sub

            Public Sub Collosion() ' All collision

                Type_one(treestorage, wood, treevalue, goldaxe)
                Type_one(fruitstorage, wood, treevalue, goldaxe)
                Type_two(rockstorage, stone, rockvalue, goldpick, woodenpick)
                Type_two(Coalstorage, coal, rockvalue, goldpick, stonepick)
                Type_two(Ironstorage, iron, rockvalue, goldpick, stonepick)
                Type_two(Goldstorage, gold, rockvalue, goldpick, ironpick)


            End Sub

            ' Collision for Trees, Fruit Trees
            Public Sub Type_one(ByRef Storage As List(Of PictureBox), ByRef Material As Integer, ByRef value As Integer, ByRef Special_item As Boolean)


                For Each Item In Storage ' checks which item has been collided

                    If Bounds.IntersectsWith(Item.Bounds) And Item.Visible = True Then ' Start of solution

                        CraftMine_Timer_Movement.Stop()
                        Mining.Visible = True
                        charatercollision = True

                        If counter = 3 And Special_item = False Then ' This will remove object and add points
                            Item.Visible = False
                            Mining.Visible = False
                            charatercollision = False
                            rnmaterials = rnnumber.Next(1, 7)
                            rnpoints = rnnumber.Next(1, 5)

                            Call MsgBox("You have collected " & rnmaterials.ToString() & " materials and " & rnpoints.ToString() & " Points ")

                            Points += rnpoints
                            Material += rnmaterials
                            value += 1
                            counter = 0
                            CraftMine_Timer_Movement.Start()

                        ElseIf counter = 3 And Special_item = True Then ' Special Item allows you to get more points
                            Item.Visible = False
                            Mining.Visible = False
                            charatercollision = False
                            rnmaterials = rnnumber.Next(1, 7)
                            rnpoints = rnnumber.Next(1, 5)

                            Call MsgBox("You have collected " & rnmaterials.ToString() & " materials and " & rnpoints.ToString() & " Points ")

                            Points += rnpoints * 3
                            Material += rnmaterials * 3
                            value += 1
                            counter = 0
                            CraftMine_Timer_Movement.Start()

                        End If

                    End If
                    If Item.Visible = False And seconds = 59 Then
                        Item.Visible = True
                    End If

                Next


            End Sub

            ' Collison For Stone, Coal, Iron, Gold
            Public Sub Type_two(ByRef Storage As List(Of PictureBox), ByRef Material As Integer, ByRef value As Integer, ByRef Special_item As Boolean, ByRef Correct_item As Boolean)

                For Each Item In Storage

                    If Bounds.IntersectsWith(Item.Bounds) And Item.Visible = True Then
                        CraftMine_Timer_Movement.Stop()
                        Mining.Visible = True
                        charatercollision = True

                        If counter = 3 And Correct_item = False And Special_item = False Then
                            Location = New Point(779, 413)
                            Mining.Visible = False
                            CraftMine_Timer_Movement.Start()
                            counter = 0

                            MsgBox(" You need to have a Pickaxe or a better version. It goes from Wood, Stone, Iron, Gold :D  ")

                        ElseIf counter = 3 And Correct_item = True And Special_item = False Then
                            Item.Visible = False
                            Mining.Visible = False
                            charatercollision = False
                            rnmaterials = rnnumber.Next(1, 7)
                            rnpoints = rnnumber.Next(1, 5)

                            Call MsgBox("You have collected " & rnmaterials.ToString() & " materials and " & rnpoints.ToString() & " Points ")

                            Points += rnpoints
                            Material += rnmaterials
                            value += 1
                            counter = 0
                            CraftMine_Timer_Movement.Start()

                        ElseIf counter = 3 And Special_item = True Then
                            Item.Visible = False
                            Mining.Visible = False
                            charatercollision = False
                            rnmaterials = rnnumber.Next(1, 7)
                            rnpoints = rnnumber.Next(1, 5)

                            Call MsgBox("You have collected " & rnmaterials.ToString() & " materials and " & rnpoints.ToString() & " Points ")

                            Points += rnpoints * 3
                            Material += rnmaterials * 3
                            value += 1
                            counter = 0
                            CraftMine_Timer_Movement.Start()

                        End If

                    End If
                    If Item.Visible = False And seconds = 59 Then
                        Item.Visible = True
                    End If
                Next

            End Sub

            Public Sub Puzzle_collision()

                Dim Retry = DirectCast(Nothing, Boolean)
                Dim firstvalue, Secondvalue, Thirdvalue, Fouthvalue, Fifthvalue As String
                Dim correctOrder As String
                Dim checkOrder As String


                ' Informs user of the puzzle
                If Bounds.IntersectsWith(Sign.Bounds) And stackValue = 0 And Sign.Visible = True Then
                    CraftMine_Timer_Movement.Stop()
                    message.Visible = True
                    charatercollision = True

                    If counter = 3 Then
                        Location = New Point(779, 413)
                        charatercollision = False
                        counter = 0
                        MsgBox("Hmm, This sign says that if I press these buttons in the correct order then I will get something?

What colour is the ocean?

What colour is the grass?

What is the colour of a bannana?

What is a fruit which has the same name as a colour?

What colour is a tomato?

Then I should come back and see what would happen........

")
                    End If
                End If

                ' Collision for Puzzle
                If Bounds.IntersectsWith(Redbox.Bounds) And Redbox.Visible = True Then
                    ColourStack.Push("Red") ' added to stack
                    stackValue += 1
                    Redbox.Visible = False

                ElseIf Bounds.IntersectsWith(Orangebox.Bounds) And Orangebox.Visible = True Then
                    ColourStack.Push("Orange")
                    stackValue += 1
                    Orangebox.Visible = False

                ElseIf Bounds.IntersectsWith(Yellowbox.Bounds) And Yellowbox.Visible = True Then
                    ColourStack.Push("Yellow")
                    stackValue += 1
                    Yellowbox.Visible = False

                ElseIf Bounds.IntersectsWith(Greenbox.Bounds) And Greenbox.Visible = True Then
                    ColourStack.Push("Green")
                    stackValue += 1
                    Greenbox.Visible = False

                ElseIf Bounds.IntersectsWith(Bluebox.Bounds) And Bluebox.Visible = True Then
                    ColourStack.Push("Blue")
                    stackValue += 1
                    Bluebox.Visible = False

                End If

                ' Correct Order
                correctOrder = "Red, Orange, Yellow, Green, Blue"


                If Bounds.IntersectsWith(Sign.Bounds) And stackValue = 5 Then
                    CraftMine_Timer_Movement.Stop()
                    message.Visible = True
                    charatercollision = True

                    If counter = 3 Then
                        Location = New Point(779, 413)
                        charatercollision = False
                        counter = 0
                        stackValue = 0
                        Sign.Visible = False

                        ' Data Popped
                        firstvalue = Conversions.ToString(ColourStack.Pop())
                        Secondvalue = Conversions.ToString(ColourStack.Pop())
                        Thirdvalue = Conversions.ToString(ColourStack.Pop())
                        Fouthvalue = Conversions.ToString(ColourStack.Pop())
                        Fifthvalue = Conversions.ToString(ColourStack.Pop())

                        ' Adds String together 
                        checkOrder = firstvalue & ", " & Secondvalue & ", " & Thirdvalue & ", " & Fouthvalue & ", " & Fifthvalue

                        ' Ouputs Order
                        MsgBox(checkOrder)

                        ' If Correct
                        If Equals(If(correctOrder, ""), If(checkOrder, "")) Then


                            Points += 50
                            MsgBox("Correct, Well done!")
                        Else
                            ' Not Correct
                            MsgBox("That does not look right...Lets try again")
                            Retry = True
                            stackValue = 0

                        End If

                    End If


                    ' Retry
                    If Retry = True Then
                        Redbox.Visible = True
                        Orangebox.Visible = True
                        Yellowbox.Visible = True
                        Greenbox.Visible = True
                        Bluebox.Visible = True
                        Sign.Visible = True
                        Retry = False
                    End If
                End If

            End Sub
            Public Sub Ship_collision()

                Dim done = DirectCast(Nothing, Boolean)
                Dim completed = DirectCast(Nothing, Boolean)

                ' if User gets all materials then it becomes true
                If wood >= 50 And stone >= 50 And iron >= 50 And gold >= 50 And coal >= 50 Then

                    done = True

                End If

                If Bounds.IntersectsWith(Ship.Bounds) And Ship.Visible = True Then
                    CraftMine_Timer_Movement.Stop()
                    Shipp.Visible = True
                    charatercollision = True

                    ' Tells user about the ship
                    If counter = 3 And done = False And completed = False Then
                        charatercollision = False
                        Location = New Point(779, 413)
                        MsgBox("The ship is broken and I need to fix it ")
                        MsgBox("I can fully repair the ship if I collect: 50 wood, 50 stone, 50 gold, 50 iron, 50 coal ")
                        counter = 0
                        CraftMine_Timer_Movement.Start()

                        ' Tells user that they fix the ship
                    ElseIf counter = 3 And done = True And completed = False Then
                        charatercollision = False
                        Location = New Point(779, 413)
                        MsgBox("The Ship is Fixed, I can escape! ")
                        counter = 0
                        CraftMine_Timer_Movement.Start()
                        completed = True
                        Ship.Image = My.Resources.Resources.Shipluffy

                        If MsgBox("I can leave this place and get 500 bounus Points!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            totalpoints = Points + wood + stone + coal + iron + gold + ironbar + goldbar + treevalue + rockvalue + mineralvalue + 500
                            Call MsgBox("You have gained " & totalpoints.ToString() & " Points, Amazing! " & correctuser)

                            ' Opens file which is used for the leaderboard as it reads from the file
                            Filewriter.WriteLine(correctuser & ":" & totalpoints.ToString())
                            Filewriter.Close()

                            For Each form In formlist

                                form.Visible = False

                                Visible = False

                                Environment.Exit(0)

                            Next

                        End If
                    End If
                End If

            End Sub

            Public Sub GrassLand_Barrier() ' This is for the Barrier Collision for Grassland

                If Top <= 50 Then
                    My.Forms.GrassLand.Visible = False
                    My.Forms.Forest.Visible = True
                    Location = New Point(833, 60)

                ElseIf Left <= 50 Then
                    My.Forms.GrassLand.Visible = False
                    My.Forms.SnowLand.Visible = True
                    Location = New Point(60, 406)

                ElseIf Top >= 720 Then
                    My.Forms.GrassLand.Visible = False
                    My.Forms.Beach.Visible = True
                    Location = New Point(821, 690)

                ElseIf Left >= 1500 Then
                    My.Forms.GrassLand.Visible = False
                    My.Forms.Mountains.Visible = True
                    Location = New Point(1480, 415)

                End If

            End Sub

            Public Sub SnowLand_Barrier() ' This is for the Barrier Collision for Grassland


                If Top <= 50 Then
                    Top += 30

                ElseIf Left <= 50 Then
                    Left += 30

                ElseIf Top >= 720 Then
                    Top -= 30

                ElseIf Left >= 1500 Then
                    My.Forms.SnowLand.Visible = False
                    My.Forms.GrassLand.Visible = True
                    Location = New Point(1480, 415)

                End If

            End Sub

            Public Sub Mountain_Barrier() ' This is for the Barrier Collision for Grassland

                If Top <= 50 Then
                    Top += 30

                ElseIf PlayerM.Left <= 50 Then
                    My.Forms.Mountains.Visible = False
                    My.Forms.GrassLand.Visible = True
                    Location = New Point(60, 406)

                ElseIf Top >= 720 Then
                    Top -= 30

                ElseIf Left >= 1500 Then
                    Left -= 30

                End If

            End Sub

            Public Sub Forest_Barrier() ' This is for the Barrier Collision for Grassland

                If Top <= 50 Then
                    Top += 30

                ElseIf Left <= 50 Then
                    Left += 30

                ElseIf Top >= 720 Then
                    My.Forms.Forest.Visible = False
                    My.Forms.GrassLand.Visible = True
                    Location = New Point(821, 690)

                ElseIf Left >= 1500 Then
                    Left -= 30

                End If

            End Sub

            Public Sub Beach_Barrier() ' This is for the Barrier Collision for Grassland

                If Top <= 50 Then
                    My.Forms.Beach.Visible = False
                    My.Forms.GrassLand.Visible = True
                    Location = New Point(833, 60)

                ElseIf Left <= 50 Then
                    Left += 30

                ElseIf Top >= 500 Then
                    Top -= 30

                ElseIf Left >= 1500 Then
                    Left -= 30

                End If



            End Sub


            Public Function Speed() As Object
                Return playerspeed

            End Function

        End Class

    End Module
End Namespace
