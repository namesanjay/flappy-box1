<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Restart_btn = New Button()
        exit_btn = New Button()
        menu_btn = New Button()
        SuspendLayout()
        ' 
        ' Restart_btn
        ' 
        Restart_btn.Location = New Point(319, 117)
        Restart_btn.Name = "Restart_btn"
        Restart_btn.Size = New Size(94, 29)
        Restart_btn.TabIndex = 0
        Restart_btn.Text = "Restart"
        Restart_btn.UseVisualStyleBackColor = True
        ' 
        ' exit_btn
        ' 
        exit_btn.Location = New Point(319, 280)
        exit_btn.Name = "exit_btn"
        exit_btn.Size = New Size(94, 29)
        exit_btn.TabIndex = 1
        exit_btn.Text = "Exit"
        exit_btn.UseVisualStyleBackColor = True
        ' 
        ' menu_btn
        ' 
        menu_btn.Location = New Point(319, 206)
        menu_btn.Name = "menu_btn"
        menu_btn.Size = New Size(94, 29)
        menu_btn.TabIndex = 2
        menu_btn.Text = "Main Menu"
        menu_btn.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(menu_btn)
        Controls.Add(exit_btn)
        Controls.Add(Restart_btn)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Restart_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents menu_btn As Button
End Class
