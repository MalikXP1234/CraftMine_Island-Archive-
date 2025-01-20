Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace CraftMine_V2
    <CompilerServices.DesignerGenerated()>

    ' Form overrides dispose to clean up the component list.
    Public Partial Class Inventory
        Inherits Form

                ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: node
''' Actual value was not null.
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToVariableDeclaratorOrNull(IsPatternExpressionSyntax node)
'''    at System.Linq.Enumerable.WhereSelectListIterator`2.MoveNext()
'''    at System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()
'''    at System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
'''    at System.Linq.Buffer`1..ctor(IEnumerable`1 source)
'''    at System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToDeclarationStatement(List`1 des, List`1 isPatternExpressions)
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.InsertRequiredDeclarations(SyntaxList`1 convertedStatements, CSharpSyntaxNode originaNode)
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatement(StatementSyntax statement, CSharpSyntaxVisitor`1 methodBodyVisitor)
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.<>c__DisplayClass10_0.<ConvertStatements>b__0(StatementSyntax s)
'''    at System.Linq.Enumerable.<SelectManyIterator>d__17`2.MoveNext()
'''    at Microsoft.CodeAnalysis.SyntaxList`1.CreateNode(IEnumerable`1 nodes)
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatements(SyntaxList`1 statements, MethodBodyExecutableStatementVisitor iteratorState)
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertBody(BlockSyntax body, ArrowExpressionClauseSyntax expressionBody, Boolean hasReturnType, MethodBodyExecutableStatementVisitor iteratorState)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         // Form overrides dispose to clean up the component list.
'''         [System.Diagnostics.@DebuggerNonUserCodeAttribute()]
'''         protected override void Dispose(bool disposing)
'''         {
'''             try
'''             {
'''                 if (disposing && this.components is not null)
'''                 {
'''                     this.components.Dispose();
'''                 }
'''             }
'''             finally
'''             {
'''                 base.Dispose(disposing);
'''             }
'''         }
''' 
''' 

        ' Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        ' NOTE: The following procedure is required by the Windows Form Designer
        ' It can be modified using the Windows Form Designer.  
        ' Do not modify it using the code editor.
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.pic9 = New System.Windows.Forms.PictureBox()
            Me.pic8 = New System.Windows.Forms.PictureBox()
            Me.pic7 = New System.Windows.Forms.PictureBox()
            Me.pic11 = New System.Windows.Forms.PictureBox()
            Me.pic12 = New System.Windows.Forms.PictureBox()
            Me.pic5 = New System.Windows.Forms.PictureBox()
            Me.pic6 = New System.Windows.Forms.PictureBox()
            Me.pic10 = New System.Windows.Forms.PictureBox()
            Me.pic2 = New System.Windows.Forms.PictureBox()
            Me.pic3 = New System.Windows.Forms.PictureBox()
            Me.pic4 = New System.Windows.Forms.PictureBox()
            Me.pic1 = New System.Windows.Forms.PictureBox()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label52 = New System.Windows.Forms.Label()
            Me.Label51 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.PictureBox22 = New System.Windows.Forms.PictureBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.PictureBox35 = New System.Windows.Forms.PictureBox()
            Me.PictureBox36 = New System.Windows.Forms.PictureBox()
            Me.PictureBox37 = New System.Windows.Forms.PictureBox()
            Me.PictureBox38 = New System.Windows.Forms.PictureBox()
            Me.TabPage6 = New System.Windows.Forms.TabPage()
            Me.Quest7 = New System.Windows.Forms.Label()
            Me.Quest6 = New System.Windows.Forms.Label()
            Me.Quest5 = New System.Windows.Forms.Label()
            Me.Quest4 = New System.Windows.Forms.Label()
            Me.Quest3 = New System.Windows.Forms.Label()
            Me.Quest2 = New System.Windows.Forms.Label()
            Me.Quest1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.Goldbar1 = New System.Windows.Forms.Button()
            Me.Label46 = New System.Windows.Forms.Label()
            Me.Label43 = New System.Windows.Forms.Label()
            Me.Ironbar1 = New System.Windows.Forms.Button()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.Labelgoldbar = New System.Windows.Forms.Label()
            Me.LabelIronbar = New System.Windows.Forms.Label()
            Me.Labelgold = New System.Windows.Forms.Label()
            Me.LabelIron = New System.Windows.Forms.Label()
            Me.Labelcoal = New System.Windows.Forms.Label()
            Me.Labelstone = New System.Windows.Forms.Label()
            Me.Labelwood = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.PictureBox21 = New System.Windows.Forms.PictureBox()
            Me.PictureBox20 = New System.Windows.Forms.PictureBox()
            Me.PictureBox18 = New System.Windows.Forms.PictureBox()
            Me.PictureBox19 = New System.Windows.Forms.PictureBox()
            Me.PictureBox6 = New System.Windows.Forms.PictureBox()
            Me.PictureBox5 = New System.Windows.Forms.PictureBox()
            Me.PictureBox4 = New System.Windows.Forms.PictureBox()
            Me.PictureBox3 = New System.Windows.Forms.PictureBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.TabPage5 = New System.Windows.Forms.TabPage()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.Toolpress6 = New System.Windows.Forms.Button()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Armorpress3 = New System.Windows.Forms.Button()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Toolpress5 = New System.Windows.Forms.Button()
            Me.Toolpress2 = New System.Windows.Forms.Button()
            Me.Toolpress3 = New System.Windows.Forms.Button()
            Me.Toolpress4 = New System.Windows.Forms.Button()
            Me.Toolpress1 = New System.Windows.Forms.Button()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.Label40 = New System.Windows.Forms.Label()
            Me.Armorpress2 = New System.Windows.Forms.Button()
            Me.Craftpress2 = New System.Windows.Forms.Button()
            Me.Craftpress3 = New System.Windows.Forms.Button()
            Me.Armorpress1 = New System.Windows.Forms.Button()
            Me.Craftpress1 = New System.Windows.Forms.Button()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.PictureBox17 = New System.Windows.Forms.PictureBox()
            Me.PictureBox16 = New System.Windows.Forms.PictureBox()
            Me.PictureBox11 = New System.Windows.Forms.PictureBox()
            Me.PictureBox12 = New System.Windows.Forms.PictureBox()
            Me.PictureBox13 = New System.Windows.Forms.PictureBox()
            Me.PictureBox14 = New System.Windows.Forms.PictureBox()
            Me.PictureBox15 = New System.Windows.Forms.PictureBox()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.PictureBox7 = New System.Windows.Forms.PictureBox()
            Me.PictureBox8 = New System.Windows.Forms.PictureBox()
            Me.PictureBox9 = New System.Windows.Forms.PictureBox()
            Me.PictureBox10 = New System.Windows.Forms.PictureBox()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.LabelRock = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Labeltrees = New System.Windows.Forms.Label()
            Me.Export1 = New System.Windows.Forms.Button()
            Me.LabelTime = New System.Windows.Forms.Label()
            Me.LabelPoints = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.pic9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox37, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage6.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage5.SuspendLayout()
            CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage3.SuspendLayout()
            Me.TabPage4.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage6)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage5)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Controls.Add(Me.TabPage4)
            Me.TabControl1.Location = New System.Drawing.Point(15, 12)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(916, 550)
            Me.TabControl1.TabIndex = 1
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.pic9)
            Me.TabPage1.Controls.Add(Me.pic8)
            Me.TabPage1.Controls.Add(Me.pic7)
            Me.TabPage1.Controls.Add(Me.pic11)
            Me.TabPage1.Controls.Add(Me.pic12)
            Me.TabPage1.Controls.Add(Me.pic5)
            Me.TabPage1.Controls.Add(Me.pic6)
            Me.TabPage1.Controls.Add(Me.pic10)
            Me.TabPage1.Controls.Add(Me.pic2)
            Me.TabPage1.Controls.Add(Me.pic3)
            Me.TabPage1.Controls.Add(Me.pic4)
            Me.TabPage1.Controls.Add(Me.pic1)
            Me.TabPage1.Controls.Add(Me.Label48)
            Me.TabPage1.Controls.Add(Me.Label52)
            Me.TabPage1.Controls.Add(Me.Label51)
            Me.TabPage1.Controls.Add(Me.Label50)
            Me.TabPage1.Controls.Add(Me.Label49)
            Me.TabPage1.Controls.Add(Me.PictureBox22)
            Me.TabPage1.Controls.Add(Me.Label11)
            Me.TabPage1.Controls.Add(Me.PictureBox35)
            Me.TabPage1.Controls.Add(Me.PictureBox36)
            Me.TabPage1.Controls.Add(Me.PictureBox37)
            Me.TabPage1.Controls.Add(Me.PictureBox38)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(908, 524)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Character"
            '
            'pic9
            '
            Me.pic9.BackColor = System.Drawing.Color.Silver
            Me.pic9.Image = CType(resources.GetObject("pic9.Image"), System.Drawing.Image)
            Me.pic9.Location = New System.Drawing.Point(779, 220)
            Me.pic9.Name = "pic9"
            Me.pic9.Size = New System.Drawing.Size(48, 48)
            Me.pic9.TabIndex = 77
            Me.pic9.TabStop = False
            '
            'pic8
            '
            Me.pic8.BackColor = System.Drawing.Color.Silver
            Me.pic8.Image = CType(resources.GetObject("pic8.Image"), System.Drawing.Image)
            Me.pic8.Location = New System.Drawing.Point(678, 220)
            Me.pic8.Name = "pic8"
            Me.pic8.Size = New System.Drawing.Size(48, 48)
            Me.pic8.TabIndex = 73
            Me.pic8.TabStop = False
            '
            'pic7
            '
            Me.pic7.BackColor = System.Drawing.Color.Silver
            Me.pic7.Image = CType(resources.GetObject("pic7.Image"), System.Drawing.Image)
            Me.pic7.Location = New System.Drawing.Point(577, 220)
            Me.pic7.Name = "pic7"
            Me.pic7.Size = New System.Drawing.Size(48, 48)
            Me.pic7.TabIndex = 74
            Me.pic7.TabStop = False
            '
            'pic11
            '
            Me.pic11.BackColor = System.Drawing.Color.Silver
            Me.pic11.Image = CType(resources.GetObject("pic11.Image"), System.Drawing.Image)
            Me.pic11.Location = New System.Drawing.Point(678, 311)
            Me.pic11.Name = "pic11"
            Me.pic11.Size = New System.Drawing.Size(48, 48)
            Me.pic11.TabIndex = 76
            Me.pic11.TabStop = False
            '
            'pic12
            '
            Me.pic12.BackColor = System.Drawing.Color.Silver
            Me.pic12.Image = CType(resources.GetObject("pic12.Image"), System.Drawing.Image)
            Me.pic12.Location = New System.Drawing.Point(779, 311)
            Me.pic12.Name = "pic12"
            Me.pic12.Size = New System.Drawing.Size(48, 48)
            Me.pic12.TabIndex = 75
            Me.pic12.TabStop = False
            '
            'pic5
            '
            Me.pic5.BackColor = System.Drawing.Color.Silver
            Me.pic5.Image = CType(resources.GetObject("pic5.Image"), System.Drawing.Image)
            Me.pic5.Location = New System.Drawing.Point(148, 386)
            Me.pic5.Name = "pic5"
            Me.pic5.Size = New System.Drawing.Size(48, 48)
            Me.pic5.TabIndex = 72
            Me.pic5.TabStop = False
            '
            'pic6
            '
            Me.pic6.BackColor = System.Drawing.Color.Silver
            Me.pic6.Image = CType(resources.GetObject("pic6.Image"), System.Drawing.Image)
            Me.pic6.Location = New System.Drawing.Point(238, 386)
            Me.pic6.Name = "pic6"
            Me.pic6.Size = New System.Drawing.Size(48, 48)
            Me.pic6.TabIndex = 71
            Me.pic6.TabStop = False
            '
            'pic10
            '
            Me.pic10.BackColor = System.Drawing.Color.Silver
            Me.pic10.Image = CType(resources.GetObject("pic10.Image"), System.Drawing.Image)
            Me.pic10.Location = New System.Drawing.Point(577, 311)
            Me.pic10.Name = "pic10"
            Me.pic10.Size = New System.Drawing.Size(48, 48)
            Me.pic10.TabIndex = 70
            Me.pic10.TabStop = False
            '
            'pic2
            '
            Me.pic2.BackColor = System.Drawing.Color.Silver
            Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
            Me.pic2.Location = New System.Drawing.Point(148, 167)
            Me.pic2.Name = "pic2"
            Me.pic2.Size = New System.Drawing.Size(48, 48)
            Me.pic2.TabIndex = 69
            Me.pic2.TabStop = False
            '
            'pic3
            '
            Me.pic3.BackColor = System.Drawing.Color.Silver
            Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
            Me.pic3.Location = New System.Drawing.Point(238, 167)
            Me.pic3.Name = "pic3"
            Me.pic3.Size = New System.Drawing.Size(48, 48)
            Me.pic3.TabIndex = 68
            Me.pic3.TabStop = False
            '
            'pic4
            '
            Me.pic4.BackColor = System.Drawing.Color.Silver
            Me.pic4.Image = CType(resources.GetObject("pic4.Image"), System.Drawing.Image)
            Me.pic4.Location = New System.Drawing.Point(65, 386)
            Me.pic4.Name = "pic4"
            Me.pic4.Size = New System.Drawing.Size(48, 48)
            Me.pic4.TabIndex = 67
            Me.pic4.TabStop = False
            '
            'pic1
            '
            Me.pic1.BackColor = System.Drawing.Color.Silver
            Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
            Me.pic1.Location = New System.Drawing.Point(65, 167)
            Me.pic1.Name = "pic1"
            Me.pic1.Size = New System.Drawing.Size(48, 48)
            Me.pic1.TabIndex = 66
            Me.pic1.TabStop = False
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.BackColor = System.Drawing.Color.Silver
            Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label48.ForeColor = System.Drawing.Color.Black
            Me.Label48.Location = New System.Drawing.Point(664, 157)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(80, 29)
            Me.Label48.TabIndex = 44
            Me.Label48.Text = "Tools"
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.Location = New System.Drawing.Point(573, 487)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(305, 20)
            Me.Label52.TabIndex = 60
            Me.Label52.Text = "Maybe craft a Item and check back ;)"
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.BackColor = System.Drawing.Color.Silver
            Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.Location = New System.Drawing.Point(388, 186)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(126, 29)
            Me.Label51.TabIndex = 50
            Me.Label51.Text = "Character"
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.BackColor = System.Drawing.Color.Silver
            Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label50.Location = New System.Drawing.Point(131, 330)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(83, 29)
            Me.Label50.TabIndex = 46
            Me.Label50.Text = "Armor"
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.BackColor = System.Drawing.Color.Silver
            Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label49.Location = New System.Drawing.Point(121, 111)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(107, 29)
            Me.Label49.TabIndex = 45
            Me.Label49.Text = "Stations"
            '
            'PictureBox22
            '
            Me.PictureBox22.BackColor = System.Drawing.Color.Silver
            Me.PictureBox22.Image = Global.CraftMine_V2.My.Resources.Resources.Front_Character
            Me.PictureBox22.Location = New System.Drawing.Point(424, 246)
            Me.PictureBox22.Name = "PictureBox22"
            Me.PictureBox22.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox22.TabIndex = 31
            Me.PictureBox22.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox22, "Used to craft tools" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 4 Wood to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(17, 15)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(445, 29)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Character - (What your character has)"
            '
            'PictureBox35
            '
            Me.PictureBox35.BackColor = System.Drawing.Color.Silver
            Me.PictureBox35.Location = New System.Drawing.Point(558, 136)
            Me.PictureBox35.Name = "PictureBox35"
            Me.PictureBox35.Size = New System.Drawing.Size(302, 278)
            Me.PictureBox35.TabIndex = 61
            Me.PictureBox35.TabStop = False
            '
            'PictureBox36
            '
            Me.PictureBox36.BackColor = System.Drawing.Color.Silver
            Me.PictureBox36.Location = New System.Drawing.Point(32, 80)
            Me.PictureBox36.Name = "PictureBox36"
            Me.PictureBox36.Size = New System.Drawing.Size(287, 188)
            Me.PictureBox36.TabIndex = 62
            Me.PictureBox36.TabStop = False
            '
            'PictureBox37
            '
            Me.PictureBox37.BackColor = System.Drawing.Color.Silver
            Me.PictureBox37.Location = New System.Drawing.Point(32, 296)
            Me.PictureBox37.Name = "PictureBox37"
            Me.PictureBox37.Size = New System.Drawing.Size(287, 188)
            Me.PictureBox37.TabIndex = 63
            Me.PictureBox37.TabStop = False
            '
            'PictureBox38
            '
            Me.PictureBox38.BackColor = System.Drawing.Color.Silver
            Me.PictureBox38.Location = New System.Drawing.Point(378, 167)
            Me.PictureBox38.Name = "PictureBox38"
            Me.PictureBox38.Size = New System.Drawing.Size(144, 147)
            Me.PictureBox38.TabIndex = 64
            Me.PictureBox38.TabStop = False
            '
            'TabPage6
            '
            Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.TabPage6.Controls.Add(Me.Quest7)
            Me.TabPage6.Controls.Add(Me.Quest6)
            Me.TabPage6.Controls.Add(Me.Quest5)
            Me.TabPage6.Controls.Add(Me.Quest4)
            Me.TabPage6.Controls.Add(Me.Quest3)
            Me.TabPage6.Controls.Add(Me.Quest2)
            Me.TabPage6.Controls.Add(Me.Quest1)
            Me.TabPage6.Controls.Add(Me.Label2)
            Me.TabPage6.Location = New System.Drawing.Point(4, 22)
            Me.TabPage6.Name = "TabPage6"
            Me.TabPage6.Size = New System.Drawing.Size(908, 524)
            Me.TabPage6.TabIndex = 5
            Me.TabPage6.Text = "Quests"
            '
            'Quest7
            '
            Me.Quest7.AutoSize = True
            Me.Quest7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Quest7.ForeColor = System.Drawing.Color.Red
            Me.Quest7.Location = New System.Drawing.Point(35, 472)
            Me.Quest7.Name = "Quest7"
            Me.Quest7.Size = New System.Drawing.Size(29, 25)
            Me.Quest7.TabIndex = 28
            Me.Quest7.Text = "G"
            '
            'Quest6
            '
            Me.Quest6.AutoSize = True
            Me.Quest6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Quest6.ForeColor = System.Drawing.Color.Red
            Me.Quest6.Location = New System.Drawing.Point(35, 406)
            Me.Quest6.Name = "Quest6"
            Me.Quest6.Size = New System.Drawing.Size(18, 25)
            Me.Quest6.TabIndex = 27
            Me.Quest6.Text = "I"
            '
            'Quest5
            '
            Me.Quest5.AutoSize = True
            Me.Quest5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Quest5.ForeColor = System.Drawing.Color.Red
            Me.Quest5.Location = New System.Drawing.Point(35, 340)
            Me.Quest5.Name = "Quest5"
            Me.Quest5.Size = New System.Drawing.Size(29, 25)
            Me.Quest5.TabIndex = 26
            Me.Quest5.Text = "G"
            '
            'Quest4
            '
            Me.Quest4.AutoSize = True
            Me.Quest4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Quest4.ForeColor = System.Drawing.Color.Red
            Me.Quest4.Location = New System.Drawing.Point(35, 274)
            Me.Quest4.Name = "Quest4"
            Me.Quest4.Size = New System.Drawing.Size(18, 25)
            Me.Quest4.TabIndex = 25
            Me.Quest4.Text = "I"
            '
            'Quest3
            '
            Me.Quest3.AutoSize = True
            Me.Quest3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Quest3.ForeColor = System.Drawing.Color.Red
            Me.Quest3.Location = New System.Drawing.Point(35, 208)
            Me.Quest3.Name = "Quest3"
            Me.Quest3.Size = New System.Drawing.Size(28, 25)
            Me.Quest3.TabIndex = 24
            Me.Quest3.Text = "C"
            '
            'Quest2
            '
            Me.Quest2.AutoSize = True
            Me.Quest2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Quest2.ForeColor = System.Drawing.Color.Red
            Me.Quest2.Location = New System.Drawing.Point(35, 143)
            Me.Quest2.Name = "Quest2"
            Me.Quest2.Size = New System.Drawing.Size(27, 25)
            Me.Quest2.TabIndex = 23
            Me.Quest2.Text = "S"
            '
            'Quest1
            '
            Me.Quest1.AutoSize = True
            Me.Quest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Quest1.ForeColor = System.Drawing.Color.Red
            Me.Quest1.Location = New System.Drawing.Point(35, 77)
            Me.Quest1.Name = "Quest1"
            Me.Quest1.Size = New System.Drawing.Size(33, 25)
            Me.Quest1.TabIndex = 22
            Me.Quest1.Text = "W"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(18, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(370, 29)
            Me.Label2.TabIndex = 20
            Me.Label2.Text = "Quests - (Give you tasks to do)"
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.Label45)
            Me.TabPage2.Controls.Add(Me.Goldbar1)
            Me.TabPage2.Controls.Add(Me.Label46)
            Me.TabPage2.Controls.Add(Me.Label43)
            Me.TabPage2.Controls.Add(Me.Ironbar1)
            Me.TabPage2.Controls.Add(Me.Label44)
            Me.TabPage2.Controls.Add(Me.Labelgoldbar)
            Me.TabPage2.Controls.Add(Me.LabelIronbar)
            Me.TabPage2.Controls.Add(Me.Labelgold)
            Me.TabPage2.Controls.Add(Me.LabelIron)
            Me.TabPage2.Controls.Add(Me.Labelcoal)
            Me.TabPage2.Controls.Add(Me.Labelstone)
            Me.TabPage2.Controls.Add(Me.Labelwood)
            Me.TabPage2.Controls.Add(Me.Label6)
            Me.TabPage2.Controls.Add(Me.PictureBox21)
            Me.TabPage2.Controls.Add(Me.PictureBox20)
            Me.TabPage2.Controls.Add(Me.PictureBox18)
            Me.TabPage2.Controls.Add(Me.PictureBox19)
            Me.TabPage2.Controls.Add(Me.PictureBox6)
            Me.TabPage2.Controls.Add(Me.PictureBox5)
            Me.TabPage2.Controls.Add(Me.PictureBox4)
            Me.TabPage2.Controls.Add(Me.PictureBox3)
            Me.TabPage2.Controls.Add(Me.PictureBox1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(908, 524)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Inventory"
            '
            'Label45
            '
            Me.Label45.AutoSize = True
            Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label45.Location = New System.Drawing.Point(669, 432)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(114, 29)
            Me.Label45.TabIndex = 41
            Me.Label45.Text = "Goldbar:"
            '
            'Goldbar1
            '
            Me.Goldbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Goldbar1.Location = New System.Drawing.Point(789, 430)
            Me.Goldbar1.Name = "Goldbar1"
            Me.Goldbar1.Size = New System.Drawing.Size(99, 35)
            Me.Goldbar1.TabIndex = 40
            Me.Goldbar1.Text = "Craft"
            Me.Goldbar1.UseVisualStyleBackColor = True
            '
            'Label46
            '
            Me.Label46.AutoSize = True
            Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label46.Location = New System.Drawing.Point(748, 459)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(0, 20)
            Me.Label46.TabIndex = 39
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label43.Location = New System.Drawing.Point(375, 432)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(103, 29)
            Me.Label43.TabIndex = 37
            Me.Label43.Text = "Ironbar:"
            '
            'Ironbar1
            '
            Me.Ironbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Ironbar1.Location = New System.Drawing.Point(484, 430)
            Me.Ironbar1.Name = "Ironbar1"
            Me.Ironbar1.Size = New System.Drawing.Size(99, 35)
            Me.Ironbar1.TabIndex = 36
            Me.Ironbar1.Text = "Craft"
            Me.Ironbar1.UseVisualStyleBackColor = True
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label44.Location = New System.Drawing.Point(454, 459)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(0, 20)
            Me.Label44.TabIndex = 35
            '
            'Labelgoldbar
            '
            Me.Labelgoldbar.AutoSize = True
            Me.Labelgoldbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Labelgoldbar.Location = New System.Drawing.Point(83, 467)
            Me.Labelgoldbar.Name = "Labelgoldbar"
            Me.Labelgoldbar.Size = New System.Drawing.Size(32, 29)
            Me.Labelgoldbar.TabIndex = 21
            Me.Labelgoldbar.Text = "G"
            '
            'LabelIronbar
            '
            Me.LabelIronbar.AutoSize = True
            Me.LabelIronbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelIronbar.Location = New System.Drawing.Point(83, 401)
            Me.LabelIronbar.Name = "LabelIronbar"
            Me.LabelIronbar.Size = New System.Drawing.Size(20, 29)
            Me.LabelIronbar.TabIndex = 20
            Me.LabelIronbar.Text = "I"
            '
            'Labelgold
            '
            Me.Labelgold.AutoSize = True
            Me.Labelgold.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Labelgold.Location = New System.Drawing.Point(83, 335)
            Me.Labelgold.Name = "Labelgold"
            Me.Labelgold.Size = New System.Drawing.Size(32, 29)
            Me.Labelgold.TabIndex = 8
            Me.Labelgold.Text = "G"
            '
            'LabelIron
            '
            Me.LabelIron.AutoSize = True
            Me.LabelIron.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelIron.Location = New System.Drawing.Point(83, 269)
            Me.LabelIron.Name = "LabelIron"
            Me.LabelIron.Size = New System.Drawing.Size(20, 29)
            Me.LabelIron.TabIndex = 7
            Me.LabelIron.Text = "I"
            '
            'Labelcoal
            '
            Me.Labelcoal.AutoSize = True
            Me.Labelcoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Labelcoal.Location = New System.Drawing.Point(83, 203)
            Me.Labelcoal.Name = "Labelcoal"
            Me.Labelcoal.Size = New System.Drawing.Size(31, 29)
            Me.Labelcoal.TabIndex = 6
            Me.Labelcoal.Text = "C"
            '
            'Labelstone
            '
            Me.Labelstone.AutoSize = True
            Me.Labelstone.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Labelstone.Location = New System.Drawing.Point(83, 138)
            Me.Labelstone.Name = "Labelstone"
            Me.Labelstone.Size = New System.Drawing.Size(30, 29)
            Me.Labelstone.TabIndex = 3
            Me.Labelstone.Text = "S"
            '
            'Labelwood
            '
            Me.Labelwood.AutoSize = True
            Me.Labelwood.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Labelwood.Location = New System.Drawing.Point(83, 72)
            Me.Labelwood.Name = "Labelwood"
            Me.Labelwood.Size = New System.Drawing.Size(36, 29)
            Me.Labelwood.TabIndex = 2
            Me.Labelwood.Text = "W"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(16, 18)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(334, 29)
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "Inventory - (What you have) "
            '
            'PictureBox21
            '
            Me.PictureBox21.Image = Global.CraftMine_V2.My.Resources.Resources.Gold_Bar
            Me.PictureBox21.Location = New System.Drawing.Point(615, 422)
            Me.PictureBox21.Name = "PictureBox21"
            Me.PictureBox21.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox21.TabIndex = 42
            Me.PictureBox21.TabStop = False
            '
            'PictureBox20
            '
            Me.PictureBox20.Image = Global.CraftMine_V2.My.Resources.Resources.Iron_Bar
            Me.PictureBox20.Location = New System.Drawing.Point(321, 422)
            Me.PictureBox20.Name = "PictureBox20"
            Me.PictureBox20.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox20.TabIndex = 38
            Me.PictureBox20.TabStop = False
            '
            'PictureBox18
            '
            Me.PictureBox18.Image = Global.CraftMine_V2.My.Resources.Resources.Gold_Bar
            Me.PictureBox18.Location = New System.Drawing.Point(29, 458)
            Me.PictureBox18.Name = "PictureBox18"
            Me.PictureBox18.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox18.TabIndex = 25
            Me.PictureBox18.TabStop = False
            '
            'PictureBox19
            '
            Me.PictureBox19.Image = Global.CraftMine_V2.My.Resources.Resources.Iron_Bar
            Me.PictureBox19.Location = New System.Drawing.Point(29, 391)
            Me.PictureBox19.Name = "PictureBox19"
            Me.PictureBox19.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox19.TabIndex = 24
            Me.PictureBox19.TabStop = False
            '
            'PictureBox6
            '
            Me.PictureBox6.Image = Global.CraftMine_V2.My.Resources.Resources.Coal_Ore
            Me.PictureBox6.Location = New System.Drawing.Point(29, 195)
            Me.PictureBox6.Name = "PictureBox6"
            Me.PictureBox6.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox6.TabIndex = 18
            Me.PictureBox6.TabStop = False
            '
            'PictureBox5
            '
            Me.PictureBox5.Image = Global.CraftMine_V2.My.Resources.Resources.Gold_Ore
            Me.PictureBox5.Location = New System.Drawing.Point(29, 326)
            Me.PictureBox5.Name = "PictureBox5"
            Me.PictureBox5.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox5.TabIndex = 17
            Me.PictureBox5.TabStop = False
            '
            'PictureBox4
            '
            Me.PictureBox4.Image = Global.CraftMine_V2.My.Resources.Resources.Stone
            Me.PictureBox4.Location = New System.Drawing.Point(29, 128)
            Me.PictureBox4.Name = "PictureBox4"
            Me.PictureBox4.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox4.TabIndex = 16
            Me.PictureBox4.TabStop = False
            '
            'PictureBox3
            '
            Me.PictureBox3.BackgroundImage = Global.CraftMine_V2.My.Resources.Resources.Iron_Ore
            Me.PictureBox3.Location = New System.Drawing.Point(29, 259)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox3.TabIndex = 15
            Me.PictureBox3.TabStop = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.CraftMine_V2.My.Resources.Resources.Wood
            Me.PictureBox1.Location = New System.Drawing.Point(29, 62)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox1.TabIndex = 13
            Me.PictureBox1.TabStop = False
            '
            'TabPage5
            '
            Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.TabPage5.Controls.Add(Me.Label47)
            Me.TabPage5.Controls.Add(Me.Label36)
            Me.TabPage5.Controls.Add(Me.Toolpress6)
            Me.TabPage5.Controls.Add(Me.Label31)
            Me.TabPage5.Controls.Add(Me.Armorpress3)
            Me.TabPage5.Controls.Add(Me.Label21)
            Me.TabPage5.Controls.Add(Me.Label22)
            Me.TabPage5.Controls.Add(Me.Label25)
            Me.TabPage5.Controls.Add(Me.Label26)
            Me.TabPage5.Controls.Add(Me.Label27)
            Me.TabPage5.Controls.Add(Me.Label30)
            Me.TabPage5.Controls.Add(Me.Toolpress5)
            Me.TabPage5.Controls.Add(Me.Toolpress2)
            Me.TabPage5.Controls.Add(Me.Toolpress3)
            Me.TabPage5.Controls.Add(Me.Toolpress4)
            Me.TabPage5.Controls.Add(Me.Toolpress1)
            Me.TabPage5.Controls.Add(Me.Label32)
            Me.TabPage5.Controls.Add(Me.Label33)
            Me.TabPage5.Controls.Add(Me.Label34)
            Me.TabPage5.Controls.Add(Me.Label35)
            Me.TabPage5.Controls.Add(Me.Label38)
            Me.TabPage5.Controls.Add(Me.Label39)
            Me.TabPage5.Controls.Add(Me.Label40)
            Me.TabPage5.Controls.Add(Me.Armorpress2)
            Me.TabPage5.Controls.Add(Me.Craftpress2)
            Me.TabPage5.Controls.Add(Me.Craftpress3)
            Me.TabPage5.Controls.Add(Me.Armorpress1)
            Me.TabPage5.Controls.Add(Me.Craftpress1)
            Me.TabPage5.Controls.Add(Me.Label12)
            Me.TabPage5.Controls.Add(Me.PictureBox17)
            Me.TabPage5.Controls.Add(Me.PictureBox16)
            Me.TabPage5.Controls.Add(Me.PictureBox11)
            Me.TabPage5.Controls.Add(Me.PictureBox12)
            Me.TabPage5.Controls.Add(Me.PictureBox13)
            Me.TabPage5.Controls.Add(Me.PictureBox14)
            Me.TabPage5.Controls.Add(Me.PictureBox15)
            Me.TabPage5.Controls.Add(Me.PictureBox2)
            Me.TabPage5.Controls.Add(Me.PictureBox7)
            Me.TabPage5.Controls.Add(Me.PictureBox8)
            Me.TabPage5.Controls.Add(Me.PictureBox9)
            Me.TabPage5.Controls.Add(Me.PictureBox10)
            Me.TabPage5.Location = New System.Drawing.Point(4, 22)
            Me.TabPage5.Name = "TabPage5"
            Me.TabPage5.Size = New System.Drawing.Size(908, 524)
            Me.TabPage5.TabIndex = 4
            Me.TabPage5.Text = "Crafting"
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label47.Location = New System.Drawing.Point(551, 485)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(343, 20)
            Me.Label47.TabIndex = 59
            Me.Label47.Text = "Hover over the image to see the materials"
            '
            'Label36
            '
            Me.Label36.AutoSize = True
            Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label36.Location = New System.Drawing.Point(501, 419)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(126, 29)
            Me.Label36.TabIndex = 57
            Me.Label36.Text = "Gold Axe:"
            '
            'Toolpress6
            '
            Me.Toolpress6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Toolpress6.Location = New System.Drawing.Point(633, 417)
            Me.Toolpress6.Name = "Toolpress6"
            Me.Toolpress6.Size = New System.Drawing.Size(130, 35)
            Me.Toolpress6.TabIndex = 56
            Me.Toolpress6.Text = "Craft"
            Me.Toolpress6.UseVisualStyleBackColor = True
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label31.Location = New System.Drawing.Point(89, 283)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(194, 29)
            Me.Label31.TabIndex = 54
            Me.Label31.Text = "Wooden Armor:"
            '
            'Armorpress3
            '
            Me.Armorpress3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Armorpress3.Location = New System.Drawing.Point(238, 413)
            Me.Armorpress3.Name = "Armorpress3"
            Me.Armorpress3.Size = New System.Drawing.Size(130, 35)
            Me.Armorpress3.TabIndex = 53
            Me.Armorpress3.Text = "Craft"
            Me.Armorpress3.UseVisualStyleBackColor = True
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(501, 347)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(174, 29)
            Me.Label21.TabIndex = 47
            Me.Label21.Text = "Gold Pickaxe:"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(501, 281)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(163, 29)
            Me.Label22.TabIndex = 46
            Me.Label22.Text = "Iron Pickaxe:"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(501, 215)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(186, 29)
            Me.Label25.TabIndex = 45
            Me.Label25.Text = "Stone Pickaxe:"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.Location = New System.Drawing.Point(595, 215)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(27, 29)
            Me.Label26.TabIndex = 44
            Me.Label26.Text = "0"
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.Location = New System.Drawing.Point(501, 150)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(209, 29)
            Me.Label27.TabIndex = 43
            Me.Label27.Text = "wooden pickaxe:"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(501, 84)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(195, 29)
            Me.Label30.TabIndex = 42
            Me.Label30.Text = "Wooden sword:"
            '
            'Toolpress5
            '
            Me.Toolpress5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Toolpress5.Location = New System.Drawing.Point(681, 345)
            Me.Toolpress5.Name = "Toolpress5"
            Me.Toolpress5.Size = New System.Drawing.Size(130, 35)
            Me.Toolpress5.TabIndex = 40
            Me.Toolpress5.Text = "Craft"
            Me.Toolpress5.UseVisualStyleBackColor = True
            '
            'Toolpress2
            '
            Me.Toolpress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Toolpress2.Location = New System.Drawing.Point(716, 148)
            Me.Toolpress2.Name = "Toolpress2"
            Me.Toolpress2.Size = New System.Drawing.Size(130, 35)
            Me.Toolpress2.TabIndex = 39
            Me.Toolpress2.Text = "Craft"
            Me.Toolpress2.UseVisualStyleBackColor = True
            '
            'Toolpress3
            '
            Me.Toolpress3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Toolpress3.Location = New System.Drawing.Point(693, 213)
            Me.Toolpress3.Name = "Toolpress3"
            Me.Toolpress3.Size = New System.Drawing.Size(130, 35)
            Me.Toolpress3.TabIndex = 38
            Me.Toolpress3.Text = "Craft"
            Me.Toolpress3.UseVisualStyleBackColor = True
            '
            'Toolpress4
            '
            Me.Toolpress4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Toolpress4.Location = New System.Drawing.Point(670, 281)
            Me.Toolpress4.Name = "Toolpress4"
            Me.Toolpress4.Size = New System.Drawing.Size(130, 35)
            Me.Toolpress4.TabIndex = 37
            Me.Toolpress4.Text = "Craft"
            Me.Toolpress4.UseVisualStyleBackColor = True
            '
            'Toolpress1
            '
            Me.Toolpress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Toolpress1.Location = New System.Drawing.Point(702, 84)
            Me.Toolpress1.Name = "Toolpress1"
            Me.Toolpress1.Size = New System.Drawing.Size(130, 35)
            Me.Toolpress1.TabIndex = 36
            Me.Toolpress1.Text = "Craft"
            Me.Toolpress1.UseVisualStyleBackColor = True
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label32.Location = New System.Drawing.Point(580, 244)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(0, 20)
            Me.Label32.TabIndex = 35
            '
            'Label33
            '
            Me.Label33.AutoSize = True
            Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label33.Location = New System.Drawing.Point(89, 347)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(142, 29)
            Me.Label33.TabIndex = 26
            Me.Label33.Text = "Iron Armor:"
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label34.Location = New System.Drawing.Point(89, 415)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(153, 29)
            Me.Label34.TabIndex = 25
            Me.Label34.Text = "Gold Armor:"
            '
            'Label35
            '
            Me.Label35.AutoSize = True
            Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label35.Location = New System.Drawing.Point(88, 82)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(186, 29)
            Me.Label35.TabIndex = 24
            Me.Label35.Text = "Crafting Table:"
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label38.Location = New System.Drawing.Point(88, 217)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(76, 29)
            Me.Label38.TabIndex = 21
            Me.Label38.Text = "Anvil:"
            '
            'Label39
            '
            Me.Label39.AutoSize = True
            Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label39.Location = New System.Drawing.Point(89, 150)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(115, 29)
            Me.Label39.TabIndex = 20
            Me.Label39.Text = "Furnace:"
            '
            'Label40
            '
            Me.Label40.AutoSize = True
            Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label40.Location = New System.Drawing.Point(18, 20)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(423, 29)
            Me.Label40.TabIndex = 19
            Me.Label40.Text = "Crafting - (create items to help you)"
            '
            'Armorpress2
            '
            Me.Armorpress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Armorpress2.Location = New System.Drawing.Point(238, 347)
            Me.Armorpress2.Name = "Armorpress2"
            Me.Armorpress2.Size = New System.Drawing.Size(130, 35)
            Me.Armorpress2.TabIndex = 17
            Me.Armorpress2.Text = "Craft"
            Me.Armorpress2.UseVisualStyleBackColor = True
            '
            'Craftpress2
            '
            Me.Craftpress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Craftpress2.Location = New System.Drawing.Point(210, 148)
            Me.Craftpress2.Name = "Craftpress2"
            Me.Craftpress2.Size = New System.Drawing.Size(130, 35)
            Me.Craftpress2.TabIndex = 15
            Me.Craftpress2.Text = "Craft"
            Me.Craftpress2.UseVisualStyleBackColor = True
            '
            'Craftpress3
            '
            Me.Craftpress3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Craftpress3.Location = New System.Drawing.Point(171, 213)
            Me.Craftpress3.Name = "Craftpress3"
            Me.Craftpress3.Size = New System.Drawing.Size(130, 35)
            Me.Craftpress3.TabIndex = 13
            Me.Craftpress3.Text = "Craft"
            Me.Craftpress3.UseVisualStyleBackColor = True
            '
            'Armorpress1
            '
            Me.Armorpress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Armorpress1.Location = New System.Drawing.Point(289, 281)
            Me.Armorpress1.Name = "Armorpress1"
            Me.Armorpress1.Size = New System.Drawing.Size(130, 35)
            Me.Armorpress1.TabIndex = 12
            Me.Armorpress1.Text = "Craft"
            Me.Armorpress1.UseVisualStyleBackColor = True
            '
            'Craftpress1
            '
            Me.Craftpress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Craftpress1.Location = New System.Drawing.Point(280, 80)
            Me.Craftpress1.Name = "Craftpress1"
            Me.Craftpress1.Size = New System.Drawing.Size(130, 35)
            Me.Craftpress1.TabIndex = 11
            Me.Craftpress1.Text = "Craft"
            Me.Craftpress1.UseVisualStyleBackColor = True
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(167, 244)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(0, 20)
            Me.Label12.TabIndex = 2
            '
            'PictureBox17
            '
            Me.PictureBox17.Image = Global.CraftMine_V2.My.Resources.Resources.Golden_Axe
            Me.PictureBox17.Location = New System.Drawing.Point(447, 410)
            Me.PictureBox17.Name = "PictureBox17"
            Me.PictureBox17.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox17.TabIndex = 58
            Me.PictureBox17.TabStop = False
            '
            'PictureBox16
            '
            Me.PictureBox16.Image = Global.CraftMine_V2.My.Resources.Resources.Golden_Armor
            Me.PictureBox16.Location = New System.Drawing.Point(34, 408)
            Me.PictureBox16.Name = "PictureBox16"
            Me.PictureBox16.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox16.TabIndex = 55
            Me.PictureBox16.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox16, "Gives you Defence" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 5 Gold Bars to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox11
            '
            Me.PictureBox11.Image = Global.CraftMine_V2.My.Resources.Resources.Stone_Pick
            Me.PictureBox11.Location = New System.Drawing.Point(447, 207)
            Me.PictureBox11.Name = "PictureBox11"
            Me.PictureBox11.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox11.TabIndex = 52
            Me.PictureBox11.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox11, "This would allow you to mine coal and iron ore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 5 Stone to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox12
            '
            Me.PictureBox12.Image = Global.CraftMine_V2.My.Resources.Resources.Golden_Pick
            Me.PictureBox12.Location = New System.Drawing.Point(447, 338)
            Me.PictureBox12.Name = "PictureBox12"
            Me.PictureBox12.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox12.TabIndex = 51
            Me.PictureBox12.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox12, "Gold power allows you to triple the Materials from rocks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 5 Gold Bars " &
        "to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox13
            '
            Me.PictureBox13.Image = Global.CraftMine_V2.My.Resources.Resources.Wooden_Pickaxe
            Me.PictureBox13.Location = New System.Drawing.Point(447, 140)
            Me.PictureBox13.Name = "PictureBox13"
            Me.PictureBox13.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox13.TabIndex = 50
            Me.PictureBox13.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox13, "This would allow you to mine stone" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 5 Wood to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox14
            '
            Me.PictureBox14.Image = Global.CraftMine_V2.My.Resources.Resources.Iron_Pick
            Me.PictureBox14.Location = New System.Drawing.Point(447, 271)
            Me.PictureBox14.Name = "PictureBox14"
            Me.PictureBox14.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox14.TabIndex = 49
            Me.PictureBox14.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox14, "This would allow you to mine gold" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 5 Iron Bars to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox15
            '
            Me.PictureBox15.Image = Global.CraftMine_V2.My.Resources.Resources.Wooden_Sword
            Me.PictureBox15.Location = New System.Drawing.Point(447, 74)
            Me.PictureBox15.Name = "PictureBox15"
            Me.PictureBox15.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox15.TabIndex = 48
            Me.PictureBox15.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox15, "Gives you the abiliry to attack" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 4 Wood to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = Global.CraftMine_V2.My.Resources.Resources.Anvil
            Me.PictureBox2.Location = New System.Drawing.Point(34, 207)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox2.TabIndex = 34
            Me.PictureBox2.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox2, "Used to craft Iron and Gold items" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 7 Iron Bars to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox7
            '
            Me.PictureBox7.Image = Global.CraftMine_V2.My.Resources.Resources.Iron_Armor
            Me.PictureBox7.Location = New System.Drawing.Point(34, 338)
            Me.PictureBox7.Name = "PictureBox7"
            Me.PictureBox7.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox7.TabIndex = 33
            Me.PictureBox7.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox7, "Gives you Defence" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 5 Iron Bars to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox8
            '
            Me.PictureBox8.Image = Global.CraftMine_V2.My.Resources.Resources.Furnace
            Me.PictureBox8.Location = New System.Drawing.Point(34, 140)
            Me.PictureBox8.Name = "PictureBox8"
            Me.PictureBox8.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox8.TabIndex = 32
            Me.PictureBox8.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox8, "Used to smelt the Iron and gold ore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 9 Stone to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox9
            '
            Me.PictureBox9.Image = Global.CraftMine_V2.My.Resources.Resources.Wooden_Armor
            Me.PictureBox9.Location = New System.Drawing.Point(34, 271)
            Me.PictureBox9.Name = "PictureBox9"
            Me.PictureBox9.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox9.TabIndex = 31
            Me.PictureBox9.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox9, "Gives you Defence" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 5 Wood to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'PictureBox10
            '
            Me.PictureBox10.Image = Global.CraftMine_V2.My.Resources.Resources.Crafting_Table
            Me.PictureBox10.Location = New System.Drawing.Point(34, 74)
            Me.PictureBox10.Name = "PictureBox10"
            Me.PictureBox10.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox10.TabIndex = 30
            Me.PictureBox10.TabStop = False
            Me.ToolTip1.SetToolTip(Me.PictureBox10, "Used to craft tools" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need 4 Wood to craft this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'TabPage3
            '
            Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.TabPage3.Controls.Add(Me.Label29)
            Me.TabPage3.Controls.Add(Me.Label28)
            Me.TabPage3.Controls.Add(Me.LabelRock)
            Me.TabPage3.Controls.Add(Me.Label23)
            Me.TabPage3.Controls.Add(Me.Labeltrees)
            Me.TabPage3.Controls.Add(Me.Export1)
            Me.TabPage3.Controls.Add(Me.LabelTime)
            Me.TabPage3.Controls.Add(Me.LabelPoints)
            Me.TabPage3.Controls.Add(Me.Label1)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Size = New System.Drawing.Size(908, 524)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Info"
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.Location = New System.Drawing.Point(117, 61)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(27, 29)
            Me.Label29.TabIndex = 14
            Me.Label29.Text = "0"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(28, 61)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(83, 29)
            Me.Label28.TabIndex = 13
            Me.Label28.Text = "Level:"
            '
            'LabelRock
            '
            Me.LabelRock.AutoSize = True
            Me.LabelRock.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelRock.Location = New System.Drawing.Point(28, 292)
            Me.LabelRock.Name = "LabelRock"
            Me.LabelRock.Size = New System.Drawing.Size(441, 29)
            Me.LabelRock.TabIndex = 10
            Me.LabelRock.Text = "You have Destroyed number of rocks"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(28, 354)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(478, 29)
            Me.Label23.TabIndex = 9
            Me.Label23.Text = "You have Destroyed number of Minerals"
            '
            'Labeltrees
            '
            Me.Labeltrees.AutoSize = True
            Me.Labeltrees.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Labeltrees.Location = New System.Drawing.Point(28, 223)
            Me.Labeltrees.Name = "Labeltrees"
            Me.Labeltrees.Size = New System.Drawing.Size(447, 29)
            Me.Labeltrees.TabIndex = 6
            Me.Labeltrees.Text = "You have Destroyed number of Trees"
            '
            'Export1
            '
            Me.Export1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Export1.Location = New System.Drawing.Point(801, 467)
            Me.Export1.Name = "Export1"
            Me.Export1.Size = New System.Drawing.Size(92, 44)
            Me.Export1.TabIndex = 5
            Me.Export1.Text = "Export"
            Me.Export1.UseVisualStyleBackColor = True
            '
            'LabelTime
            '
            Me.LabelTime.AutoSize = True
            Me.LabelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelTime.Location = New System.Drawing.Point(28, 163)
            Me.LabelTime.Name = "LabelTime"
            Me.LabelTime.Size = New System.Drawing.Size(251, 29)
            Me.LabelTime.TabIndex = 2
            Me.LabelTime.Text = "You have played for:"
            '
            'LabelPoints
            '
            Me.LabelPoints.AutoSize = True
            Me.LabelPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelPoints.Location = New System.Drawing.Point(28, 112)
            Me.LabelPoints.Name = "LabelPoints"
            Me.LabelPoints.Size = New System.Drawing.Size(391, 29)
            Me.LabelPoints.TabIndex = 1
            Me.LabelPoints.Text = "You have collected these points:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(17, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(280, 29)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Info - (Your Infomation)"
            '
            'TabPage4
            '
            Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.TabPage4.Controls.Add(Me.Button1)
            Me.TabPage4.ForeColor = System.Drawing.Color.Black
            Me.TabPage4.Location = New System.Drawing.Point(4, 22)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Size = New System.Drawing.Size(908, 524)
            Me.TabPage4.TabIndex = 3
            Me.TabPage4.Text = "Options"
            '
            'Button1
            '
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Location = New System.Drawing.Point(354, 229)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(232, 55)
            Me.Button1.TabIndex = 12
            Me.Button1.Text = "Quit"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Inventory
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Silver
            Me.ClientSize = New System.Drawing.Size(960, 574)
            Me.Controls.Add(Me.TabControl1)
            Me.Name = "Inventory"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Inventory"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            CType(Me.pic9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox37, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage6.ResumeLayout(False)
            Me.TabPage6.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage5.ResumeLayout(False)
            Me.TabPage5.PerformLayout()
            CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            Me.TabPage4.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend TabControl1 As TabControl
        Friend TabPage1 As TabPage
        Friend Label11 As Label
        Friend TabPage2 As TabPage
        Friend PictureBox6 As PictureBox
        Friend PictureBox5 As PictureBox
        Friend PictureBox4 As PictureBox
        Friend PictureBox3 As PictureBox
        Friend PictureBox1 As PictureBox
        Friend Labelgold As Label
        Friend LabelIron As Label
        Friend Labelcoal As Label
        Friend Labelstone As Label
        Friend Labelwood As Label
        Friend Label6 As Label
        Friend TabPage5 As TabPage
        Friend PictureBox2 As PictureBox
        Friend PictureBox7 As PictureBox
        Friend PictureBox8 As PictureBox
        Friend PictureBox9 As PictureBox
        Friend PictureBox10 As PictureBox
        Friend Label33 As Label
        Friend Label34 As Label
        Friend Label35 As Label
        Friend Label38 As Label
        Friend Label39 As Label
        Friend Label40 As Label
        Friend Armorpress2 As Button
        Friend Craftpress2 As Button
        Friend Craftpress3 As Button
        Friend Armorpress1 As Button
        Friend Craftpress1 As Button
        Friend Label12 As Label
        Friend TabPage3 As TabPage
        Friend Label29 As Label
        Friend Label28 As Label
        Friend LabelRock As Label
        Friend Label23 As Label
        Friend Labeltrees As Label
        Friend Export1 As Button
        Friend LabelTime As Label
        Friend LabelPoints As Label
        Friend Label1 As Label
        Friend TabPage4 As TabPage
        Friend TabPage6 As TabPage
        Friend PictureBox17 As PictureBox
        Friend Label36 As Label
        Friend Toolpress6 As Button
        Friend PictureBox16 As PictureBox
        Friend Label31 As Label
        Friend Armorpress3 As Button
        Friend PictureBox11 As PictureBox
        Friend PictureBox12 As PictureBox
        Friend PictureBox13 As PictureBox
        Friend PictureBox14 As PictureBox
        Friend PictureBox15 As PictureBox
        Friend Label21 As Label
        Friend Label22 As Label
        Friend Label25 As Label
        Friend Label26 As Label
        Friend Label27 As Label
        Friend Label30 As Label
        Friend Toolpress5 As Button
        Friend Toolpress2 As Button
        Friend Toolpress3 As Button
        Friend Toolpress4 As Button
        Friend Toolpress1 As Button
        Friend Label32 As Label
        Friend PictureBox18 As PictureBox
        Friend PictureBox19 As PictureBox
        Friend Labelgoldbar As Label
        Friend LabelIronbar As Label
        Friend PictureBox21 As PictureBox
        Friend Label45 As Label
        Friend Goldbar1 As Button
        Friend Label46 As Label
        Friend PictureBox20 As PictureBox
        Friend Label43 As Label
        Friend Ironbar1 As Button
        Friend Label44 As Label
        Friend ToolTip1 As ToolTip
        Friend Label47 As Label
        Friend PictureBox22 As PictureBox
        Friend Label50 As Label
        Friend Label49 As Label
        Friend Label48 As Label
        Friend Label52 As Label
        Friend Label51 As Label
        Friend Label2 As Label
        Friend Quest7 As Label
        Friend Quest6 As Label
        Friend Quest5 As Label
        Friend Quest4 As Label
        Friend Quest3 As Label
        Friend Quest2 As Label
        Friend Quest1 As Label
        Friend Button1 As Button
        Friend PictureBox35 As PictureBox
        Friend PictureBox36 As PictureBox
        Friend PictureBox37 As PictureBox
        Friend PictureBox38 As PictureBox
        Friend pic9 As PictureBox
        Friend pic11 As PictureBox
        Friend pic12 As PictureBox
        Friend pic7 As PictureBox
        Friend pic8 As PictureBox
        Friend pic5 As PictureBox
        Friend pic6 As PictureBox
        Friend pic10 As PictureBox
        Friend pic2 As PictureBox
        Friend pic3 As PictureBox
        Friend pic4 As PictureBox
        Friend pic1 As PictureBox
    End Class
End Namespace
