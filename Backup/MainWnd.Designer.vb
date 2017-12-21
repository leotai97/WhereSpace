<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWnd
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtPath = New System.Windows.Forms.TextBox
    Me.btnScan = New System.Windows.Forms.Button
    Me.btnPath = New System.Windows.Forms.Button
    Me.tree = New System.Windows.Forms.TreeView
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(29, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Path"
    '
    'txtPath
    '
    Me.txtPath.Location = New System.Drawing.Point(12, 25)
    Me.txtPath.Name = "txtPath"
    Me.txtPath.Size = New System.Drawing.Size(762, 20)
    Me.txtPath.TabIndex = 1
    '
    'btnScan
    '
    Me.btnScan.Location = New System.Drawing.Point(818, 23)
    Me.btnScan.Name = "btnScan"
    Me.btnScan.Size = New System.Drawing.Size(47, 23)
    Me.btnScan.TabIndex = 2
    Me.btnScan.Text = "Scan"
    Me.btnScan.UseVisualStyleBackColor = True
    '
    'btnPath
    '
    Me.btnPath.Location = New System.Drawing.Point(777, 23)
    Me.btnPath.Name = "btnPath"
    Me.btnPath.Size = New System.Drawing.Size(38, 23)
    Me.btnPath.TabIndex = 3
    Me.btnPath.Text = "Path"
    Me.btnPath.UseVisualStyleBackColor = True
    '
    'tree
    '
    Me.tree.Location = New System.Drawing.Point(15, 51)
    Me.tree.Name = "tree"
    Me.tree.Size = New System.Drawing.Size(850, 503)
    Me.tree.TabIndex = 4
    '
    'MainWnd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(869, 566)
    Me.Controls.Add(Me.tree)
    Me.Controls.Add(Me.btnPath)
    Me.Controls.Add(Me.btnScan)
    Me.Controls.Add(Me.txtPath)
    Me.Controls.Add(Me.Label1)
    Me.Name = "MainWnd"
    Me.Text = "Where Space"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtPath As System.Windows.Forms.TextBox
  Friend WithEvents btnScan As System.Windows.Forms.Button
  Friend WithEvents btnPath As System.Windows.Forms.Button
  Friend WithEvents tree As System.Windows.Forms.TreeView

End Class
