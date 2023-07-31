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
        Label1 = New Label()
        esy = New Button()
        mid = New Button()
        hrd = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(761, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 32)
        Label1.TabIndex = 0
        Label1.Text = "Flappy Box"
        ' 
        ' esy
        ' 
        esy.Location = New Point(464, 370)
        esy.Name = "esy"
        esy.Size = New Size(89, 52)
        esy.TabIndex = 1
        esy.Text = "Easy"
        esy.UseVisualStyleBackColor = True
        ' 
        ' mid
        ' 
        mid.Location = New Point(761, 370)
        mid.Name = "mid"
        mid.Size = New Size(95, 42)
        mid.TabIndex = 2
        mid.Text = "Medium"
        mid.UseVisualStyleBackColor = True
        ' 
        ' hrd
        ' 
        hrd.Location = New Point(1080, 365)
        hrd.Name = "hrd"
        hrd.Size = New Size(109, 52)
        hrd.TabIndex = 3
        hrd.Text = "Hard"
        hrd.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(hrd)
        Controls.Add(mid)
        Controls.Add(esy)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents esy As Button
    Friend WithEvents mid As Button
    Friend WithEvents hrd As Button
End Class
