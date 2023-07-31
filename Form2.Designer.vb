<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Scr = New Label()
        bird = New PictureBox()
        Timer1 = New Timer(components)
        CType(bird, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Scr
        ' 
        Scr.AutoSize = True
        Scr.BackColor = Color.BlueViolet
        Scr.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Scr.Location = New Point(69, 70)
        Scr.Name = "Scr"
        Scr.Size = New Size(97, 30)
        Scr.TabIndex = 0
        Scr.Text = "Score : 0"
        ' 
        ' bird
        ' 
        bird.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        bird.Location = New Point(133, 158)
        bird.Name = "bird"
        bird.Size = New Size(47, 48)
        bird.TabIndex = 1
        bird.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 40
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 450)
        Controls.Add(bird)
        Controls.Add(Scr)
        Name = "Form2"
        Text = "Form2"
        CType(bird, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Scr As Label
    Friend WithEvents bird As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
