Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace CraftMine_V2


    ' Form overrides dispose to clean up the component list.
    Public Partial Class LeaderBoard
        Inherits Form


        ' Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        ' NOTE: The following procedure is required by the Windows Form Designer
        ' It can be modified using the Windows Form Designer.  
        ' Do not modify it using the code editor.
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()
            LeaderBoardButton = New Button()
            AddHandler LeaderBoardButton.Click, New EventHandler(AddressOf LeaderBoard_Button)
            ListBox1 = New ListBox()
            Label1 = New Label()
            Button1 = New Button()
            AddHandler Button1.Click, New EventHandler(AddressOf Button1_Click)
            SuspendLayout()
            ' 
            ' LeaderBoardButton
            ' 
            LeaderBoardButton.Font = New Font("Microsoft Sans Serif", 36.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            LeaderBoardButton.Location = New Point(405, 339)
            LeaderBoardButton.Name = "LeaderBoardButton"
            LeaderBoardButton.Size = New Size(172, 70)
            LeaderBoardButton.TabIndex = 10
            LeaderBoardButton.Text = "Check"
            LeaderBoardButton.UseVisualStyleBackColor = True
            ' 
            ' ListBox1
            ' 
            ListBox1.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
            ListBox1.FormattingEnabled = True
            ListBox1.ItemHeight = 15
            ListBox1.Location = New Point(25, 106)
            ListBox1.Name = "ListBox1"
            ListBox1.Size = New Size(355, 289)
            ListBox1.TabIndex = 11
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Font = New Font("Microsoft Sans Serif", 48.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Label1.Location = New Point(12, 9)
            Label1.Name = "Label1"
            Label1.Size = New Size(405, 73)
            Label1.TabIndex = 17
            Label1.Text = "LeaderBoard"
            ' 
            ' Button1
            ' 
            Button1.Font = New Font("Microsoft Sans Serif", 36.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Button1.Location = New Point(567, 9)
            Button1.Name = "Button1"
            Button1.Size = New Size(221, 73)
            Button1.TabIndex = 18
            Button1.Text = "Go Back"
            Button1.UseVisualStyleBackColor = True
            ' 
            ' LeaderBoard
            ' 
            AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(192, 192, 255)
            ClientSize = New Size(800, 450)
            Controls.Add(Button1)
            Controls.Add(Label1)
            Controls.Add(ListBox1)
            Controls.Add(LeaderBoardButton)
            Name = "LeaderBoard"
            Text = "LeaderBoard"
            AddHandler Load, New EventHandler(AddressOf LeaderBoard_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend LeaderBoardButton As Button
        Friend ListBox1 As ListBox
        Friend Label1 As Label
        Friend Button1 As Button
    End Class
End Namespace
