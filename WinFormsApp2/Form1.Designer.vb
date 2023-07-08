<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        bird = New PictureBox()
        Timer1 = New Timer(components)
        Scr = New Label()
        CType(bird, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bird
        ' 
        resources.ApplyResources(bird, "bird")
        bird.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        bird.Name = "bird"
        bird.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 40
        ' 
        ' Scr
        ' 
        resources.ApplyResources(Scr, "Scr")
        Scr.BackColor = Color.BlueViolet
        Scr.Name = "Scr"
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Scr)
        Controls.Add(bird)
        Name = "Form1"
        CType(bird, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bird As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Scr As Label
End Class
