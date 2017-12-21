Public Class MainWnd

  Private m_Dir As Dir
  Private m_Direction As Sorter.enumDir = Sorter.enumDir.High

  Private Sub btnScan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnScan.Click
    Scan()
  End Sub

  Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click
    Dim d As FolderBrowserDialog
    Dim ret As DialogResult

    d = New FolderBrowserDialog
    ret = d.ShowDialog()
    If ret = DialogResult.OK Then
      txtPath.Text = d.SelectedPath
      Scan()
    End If

  End Sub


  Private Sub Scan()
    Dim oDir As IO.DirectoryInfo
    Dim cur As Cursor = Me.Cursor

    Try
      oDir = New IO.DirectoryInfo(txtPath.Text)
    Catch
      MsgBox("Error: " & Err.Description, MsgBoxStyle.Information)
      Return
    End Try

    Me.Cursor = Cursors.WaitCursor

    m_Dir = New Dir(oDir.Name)

    m_Dir.Parse(oDir)
    m_Dir.Text = m_Dir.Text & " " & m_Dir.FSize

    tree.Nodes.Clear()
    tree.Nodes.Add(m_Dir)
    tree.TreeViewNodeSorter = New Sorter(m_Direction)
    tree.Sort()

    Me.Cursor = cur

  End Sub

  Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

    If m_Direction = Sorter.enumDir.High Then
      btnSort.Text = "High"
      m_Direction = Sorter.enumDir.Low
    Else
      btnSort.Text = "Low"
      m_Direction = Sorter.enumDir.High
    End If

    If tree.Nodes.Count > 0 Then
      tree.TreeViewNodeSorter = New Sorter(m_Direction)
      tree.Sort()
    End If

  End Sub

  Private Sub MainWnd_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    Dim cw, ch As Integer
    Dim pad As Integer = 5

    cw = Me.ClientSize.Width
    ch = Me.ClientSize.Height

    txtPath.Left = pad
    txtPath.Top = pad
    txtPath.Width = cw - (btnPath.Width + btnScan.Width + btnSort.Width + pad * 5)

    tree.Left = pad
    tree.Top = txtPath.Top + txtPath.Height + pad
    tree.Width = cw - (pad * 2)
    tree.Height = ch - (tree.Top + pad)

    btnPath.Top = pad
    btnPath.Left = txtPath.Left + txtPath.Width + pad

    btnScan.Top = pad
    btnScan.Left = btnPath.Left + btnPath.Width + pad

    btnSort.Top = pad
    btnSort.Left = btnScan.Left + btnScan.Width + pad

  End Sub

  Private Sub txtPath_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPath.KeyDown

    If e.KeyCode = Keys.Enter Then
      Scan()
      e.Handled = True
    End If

  End Sub

  Private Sub tree_DoubleClick(sender As Object, e As EventArgs) Handles tree.DoubleClick
    Dim oDir As Dir = tree.SelectedNode
    Dim strPath As String

    If oDir Is Nothing Then Return

    strPath = Original(oDir)

    Process.Start("explorer.exe", """" & strPath & """")

  End Sub

  Private Function Original(ByVal oDir As Dir) As String

    If oDir.Parent Is Nothing Then
      If Strings.Right(oDir.Original, 1) = "\" Then Return Strings.Left(oDir.Original, oDir.Original.Length - 1)
      Return oDir.Original
    End If

    Return Original(oDir.Parent) & "\" & oDir.Original

  End Function


End Class

