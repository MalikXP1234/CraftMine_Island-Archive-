Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace CraftMine_V2
    <CompilerServices.DesignerGenerated()>

    ' Form overrides dispose to clean up the component list.
    Public Partial Class Play_Menu
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
            Game1 = New Button()
            AddHandler Game1.Click, New EventHandler(AddressOf Game1_Click)
            Back1 = New Button()
            AddHandler Back1.Click, New EventHandler(AddressOf Back1_Click)
            SignupLogin1 = New Button()
            AddHandler SignupLogin1.Click, New EventHandler(AddressOf SignupLogin1_Click)
            Label1 = New Label()
            AddHandler Label1.Click, New EventHandler(AddressOf Label1_Click)
            SuspendLayout()
            ' 
            ' Game1
            ' 
            Game1.Font = New Font("Microsoft Sans Serif", 36.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Game1.Location = New Point(182, 171)
            Game1.Name = "Game1"
            Game1.Size = New Size(359, 70)
            Game1.TabIndex = 9
            Game1.Text = "Game!!!"
            Game1.UseVisualStyleBackColor = True
            ' 
            ' Back1
            ' 
            Back1.Font = New Font("Microsoft Sans Serif", 36.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Back1.Location = New Point(182, 416)
            Back1.Name = "Back1"
            Back1.Size = New Size(359, 70)
            Back1.TabIndex = 8
            Back1.Text = "Go Back"
            Back1.UseVisualStyleBackColor = True
            ' 
            ' SignupLogin1
            ' 
            SignupLogin1.Font = New Font("Microsoft Sans Serif", 36.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            SignupLogin1.Location = New Point(182, 290)
            SignupLogin1.Name = "SignupLogin1"
            SignupLogin1.Size = New Size(359, 70)
            SignupLogin1.TabIndex = 7
            SignupLogin1.Text = "SignUp/Login"
            SignupLogin1.UseVisualStyleBackColor = True
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Font = New Font("Microsoft Sans Serif", 72.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Label1.Location = New Point(108, 20)
            Label1.Name = "Label1"
            Label1.Size = New Size(496, 108)
            Label1.TabIndex = 6
            Label1.Text = "Play Menu"
            ' 
            ' Play_Menu
            ' 
            AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(192, 192, 255)
            ClientSize = New Size(734, 586)
            Controls.Add(Game1)
            Controls.Add(Back1)
            Controls.Add(SignupLogin1)
            Controls.Add(Label1)
            Name = "Play_Menu"
            StartPosition = FormStartPosition.CenterScreen
            Text = "S"
            AddHandler Load, New EventHandler(AddressOf Play_Menu_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend Game1 As Button
        Friend Back1 As Button
        Friend SignupLogin1 As Button
        Friend Label1 As Label
    End Class
End Namespace
