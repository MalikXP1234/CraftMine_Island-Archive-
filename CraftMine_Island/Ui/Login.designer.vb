Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace CraftMine_V2
    <CompilerServices.DesignerGenerated()>

    ' Form overrides dispose to clean up the component list.
    Public Partial Class Login
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
            Signup1 = New Button()
            AddHandler Signup1.Click, New EventHandler(AddressOf Signup1_Click)
            Label5 = New Label()
            Label6 = New Label()
            signuser = New TextBox()
            signpass = New TextBox()
            Label4 = New Label()
            Login1 = New Button()
            AddHandler Login1.Click, New EventHandler(AddressOf Login1_Click)
            loguser = New TextBox()
            logpass = New TextBox()
            Label3 = New Label()
            Label2 = New Label()
            Label1 = New Label()
            SuspendLayout()
            ' 
            ' Signup1
            ' 
            Signup1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Signup1.Location = New Point(224, 261)
            Signup1.Name = "Signup1"
            Signup1.Size = New Size(291, 50)
            Signup1.TabIndex = 27
            Signup1.Text = "Sign Up"
            Signup1.UseVisualStyleBackColor = True
            ' 
            ' Label5
            ' 
            Label5.AutoSize = True
            Label5.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Label5.Location = New Point(28, 195)
            Label5.Name = "Label5"
            Label5.Size = New Size(159, 33)
            Label5.TabIndex = 26
            Label5.Text = "Password :"
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Label6.Location = New Point(21, 135)
            Label6.Name = "Label6"
            Label6.Size = New Size(166, 33)
            Label6.TabIndex = 25
            Label6.Text = "Username :"
            ' 
            ' signuser
            ' 
            signuser.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            signuser.Location = New Point(193, 135)
            signuser.Name = "signuser"
            signuser.Size = New Size(322, 40)
            signuser.TabIndex = 24
            ' 
            ' signpass
            ' 
            signpass.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            signpass.Location = New Point(193, 195)
            signpass.Name = "signpass"
            signpass.Size = New Size(322, 40)
            signpass.TabIndex = 23
            ' 
            ' Label4
            ' 
            Label4.AutoSize = True
            Label4.Font = New Font("Microsoft Sans Serif", 48.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Label4.Location = New Point(21, 26)
            Label4.Name = "Label4"
            Label4.Size = New Size(260, 73)
            Label4.TabIndex = 22
            Label4.Text = "Sign Up"
            ' 
            ' Login1
            ' 
            Login1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Login1.Location = New Point(822, 261)
            Login1.Name = "Login1"
            Login1.Size = New Size(291, 50)
            Login1.TabIndex = 21
            Login1.Text = "Login"
            Login1.UseVisualStyleBackColor = True
            ' 
            ' loguser
            ' 
            loguser.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            loguser.Location = New Point(791, 135)
            loguser.Name = "loguser"
            loguser.Size = New Size(322, 40)
            loguser.TabIndex = 20
            ' 
            ' logpass
            ' 
            logpass.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            logpass.Location = New Point(791, 195)
            logpass.Name = "logpass"
            logpass.PasswordChar = "*"c
            logpass.Size = New Size(322, 40)
            logpass.TabIndex = 19
            ' 
            ' Label3
            ' 
            Label3.AutoSize = True
            Label3.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Label3.Location = New Point(619, 135)
            Label3.Name = "Label3"
            Label3.Size = New Size(166, 33)
            Label3.TabIndex = 18
            Label3.Text = "Username :"
            ' 
            ' Label2
            ' 
            Label2.AutoSize = True
            Label2.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Label2.Location = New Point(626, 195)
            Label2.Name = "Label2"
            Label2.Size = New Size(159, 33)
            Label2.TabIndex = 17
            Label2.Text = "Password :"
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Font = New Font("Microsoft Sans Serif", 48.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Label1.Location = New Point(619, 26)
            Label1.Name = "Label1"
            Label1.Size = New Size(190, 73)
            Label1.TabIndex = 16
            Label1.Text = "Login"
            ' 
            ' Login
            ' 
            AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(192, 192, 255)
            ClientSize = New Size(1134, 336)
            Controls.Add(Signup1)
            Controls.Add(Label5)
            Controls.Add(Label6)
            Controls.Add(signuser)
            Controls.Add(signpass)
            Controls.Add(Label4)
            Controls.Add(Login1)
            Controls.Add(loguser)
            Controls.Add(logpass)
            Controls.Add(Label3)
            Controls.Add(Label2)
            Controls.Add(Label1)
            Name = "Login"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Login"
            AddHandler Load, New EventHandler(AddressOf Login_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend Signup1 As Button
        Friend Label5 As Label
        Friend Label6 As Label
        Friend signuser As TextBox
        Friend signpass As TextBox
        Friend Label4 As Label
        Friend Login1 As Button
        Friend loguser As TextBox
        Friend logpass As TextBox
        Friend Label3 As Label
        Friend Label2 As Label
        Friend Label1 As Label
    End Class
End Namespace
