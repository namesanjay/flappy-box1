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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Scr = New Label()
        bird = New PictureBox()
        Timer1 = New Timer(components)
        Label1 = New Label()
        CType(bird, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Scr
        ' 
        resources.ApplyResources(Scr, "Scr")
        Scr.BackColor = Color.BlueViolet
        Scr.Name = "Scr"
        ' 
        ' bird
        ' 
        bird.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        resources.ApplyResources(bird, "bird")
        bird.Name = "bird"
        bird.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 40
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.BackColor = Color.Cyan
        Label1.Name = "Label1"
        ' 
        ' Form2
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        Controls.Add(Label1)
        Controls.Add(bird)
        Controls.Add(Scr)
        Name = "Form2"
        CType(bird, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Scr As Label
    Friend WithEvents bird As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
