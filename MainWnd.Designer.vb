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
    Me.components = New System.ComponentModel.Container()
    Me.txtPath = New System.Windows.Forms.TextBox()
    Me.btnScan = New System.Windows.Forms.Button()
    Me.btnPath = New System.Windows.Forms.Button()
    Me.btnSort = New System.Windows.Forms.Button()
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.tree = New System.Windows.Forms.TreeView()
    Me.SuspendLayout()
    '
    'txtPath
    '
    Me.txtPath.Location = New System.Drawing.Point(15, 25)
    Me.txtPath.Name = "txtPath"
    Me.txtPath.Size = New System.Drawing.Size(714, 20)
    Me.txtPath.TabIndex = 1
    Me.ToolTip1.SetToolTip(Me.txtPath, "Enter starting directory")
    '
    'btnScan
    '
    Me.btnScan.Location = New System.Drawing.Point(776, 25)
    Me.btnScan.Name = "btnScan"
    Me.btnScan.Size = New System.Drawing.Size(40, 20)
    Me.btnScan.TabIndex = 2
    Me.btnScan.Text = "Scan"
    Me.ToolTip1.SetToolTip(Me.btnScan, "Start the scan")
    Me.btnScan.UseVisualStyleBackColor = True
    '
    'btnPath
    '
    Me.btnPath.Location = New System.Drawing.Point(732, 25)
    Me.btnPath.Name = "btnPath"
    Me.btnPath.Size = New System.Drawing.Size(38, 20)
    Me.btnPath.TabIndex = 3
    Me.btnPath.Text = "Path"
    Me.ToolTip1.SetToolTip(Me.btnPath, "Browse for a path")
    Me.btnPath.UseVisualStyleBackColor = True
    '
    'btnSort
    '
    Me.btnSort.Location = New System.Drawing.Point(822, 25)
    Me.btnSort.Name = "btnSort"
    Me.btnSort.Size = New System.Drawing.Size(38, 20)
    Me.btnSort.TabIndex = 5
    Me.btnSort.Text = "Low"
    Me.ToolTip1.SetToolTip(Me.btnSort, "Switch the sort direction")
    Me.btnSort.UseVisualStyleBackColor = True
    '
    'tree
    '
    Me.tree.Location = New System.Drawing.Point(91, 134)
    Me.tree.Name = "tree"
    Me.tree.Size = New System.Drawing.Size(274, 387)
    Me.tree.TabIndex = 6
    '
    'MainWnd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(869, 623)
    Me.Controls.Add(Me.tree)
    Me.Controls.Add(Me.btnSort)
    Me.Controls.Add(Me.btnPath)
    Me.Controls.Add(Me.btnScan)
    Me.Controls.Add(Me.txtPath)
    Me.Name = "MainWnd"
    Me.Text = "Where Space"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtPath As System.Windows.Forms.TextBox
  Friend WithEvents btnScan As System.Windows.Forms.Button
  Friend WithEvents btnPath As System.Windows.Forms.Button
  Friend WithEvents btnSort As Button
  Friend WithEvents ToolTip1 As ToolTip
  Friend WithEvents tree As TreeView
End Class
