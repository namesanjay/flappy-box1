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
        Button1 = New Button()
        DGV = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(870, 195)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 41)
        Label1.TabIndex = 0
        Label1.Text = "Flappy Box"
        ' 
        ' esy
        ' 
        esy.Location = New Point(543, 487)
        esy.Margin = New Padding(3, 4, 3, 4)
        esy.Name = "esy"
        esy.Size = New Size(102, 69)
        esy.TabIndex = 1
        esy.Text = "Easy"
        esy.UseVisualStyleBackColor = True
        ' 
        ' mid
        ' 
        mid.Location = New Point(913, 487)
        mid.Margin = New Padding(3, 4, 3, 4)
        mid.Name = "mid"
        mid.Size = New Size(109, 69)
        mid.TabIndex = 2
        mid.Text = "Medium"
        mid.UseVisualStyleBackColor = True
        ' 
        ' hrd
        ' 
        hrd.Location = New Point(1234, 487)
        hrd.Margin = New Padding(3, 4, 3, 4)
        hrd.Name = "hrd"
        hrd.Size = New Size(125, 69)
        hrd.TabIndex = 3
        hrd.Text = "Hard"
        hrd.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(727, 730)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 32)
        Button1.TabIndex = 4
        Button1.Text = "Display High Score"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(727, 791)
        DGV.Name = "DGV"
        DGV.RowHeadersWidth = 51
        DGV.RowTemplate.Height = 29
        DGV.Size = New Size(429, 89)
        DGV.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1019, 730)
        Button2.Name = "Button2"
        Button2.Size = New Size(137, 32)
        Button2.TabIndex = 6
        Button2.Text = "Hide High Score"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(913, 952)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 39)
        Button3.TabIndex = 7
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1055)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DGV)
        Controls.Add(Button1)
        Controls.Add(hrd)
        Controls.Add(mid)
        Controls.Add(esy)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents esy As Button
    Friend WithEvents mid As Button
    Friend WithEvents hrd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
