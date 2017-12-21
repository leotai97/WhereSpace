Public Class MainWnd

  Private m_Dir As Dir

  Private Sub btnScan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnScan.Click
    Dim oNode As TreeNode
    Dim oDir As IO.DirectoryInfo
    Dim oDC As Dir
    Dim cur As Cursor = Me.Cursor

    Me.Cursor = Cursors.WaitCursor

    Try
      oDir = New IO.DirectoryInfo(txtPath.Text)
    Catch
      MsgBox("Error: " & Err.Description, MsgBoxStyle.Information)
      Return
    End Try

    m_Dir = New Dir(oDir.Name)

    Parse(oDir, m_Dir)

    m_Dir.Sort()

    oNode = New TreeNode
    oNode.Text = m_Dir.Name & " " & m_Dir.FSize
    For Each oDC In m_Dir.Kids
      oDC.DoNodes(oNode)
    Next
    tree.Nodes.Add(oNode)

    Me.Cursor = cur

  End Sub

  Private Sub Parse(ByRef oDir As IO.DirectoryInfo, ByRef oDC As Dir)
    Dim oSubDC As Dir
    Dim oSub As IO.DirectoryInfo
    Dim oFile As IO.FileInfo

    ' full failure

    Try
      For Each oSub In oDir.GetDirectories
        oSubDC = New Dir(oSub.Name)
        oDC.Kids.Add(oSubDC)
        Parse(oSub, oSubDC)
        oDC.Size += oSubDC.Size
      Next
    Catch
    End Try

    Try
      For Each oFile In oDir.GetFiles
        oDC.Size += oFile.Length
      Next
    Catch
    End Try

  End Sub


End Class
