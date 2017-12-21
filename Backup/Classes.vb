Public Class Dir

  Public Kids As List(Of Dir)
  Public Size As Long
  Public Name As String

  Public Sub New(ByVal sName As String)
    Kids = New List(Of Dir)
    Name = sName
    Size = 0
  End Sub

  Public ReadOnly Property FSize() As String
    Get
      If Size < 1024 Then Return Size.ToString
      If Size < 1024000 Then Return Size \ 1024 & " KB"
      If Size < 1024000000 Then Return Size \ 1024000 & " MB"
      Return Size \ 1024000000 & " GB"
    End Get
  End Property

  Public Sub Sort()
    Dim oDir As Dir
    Dim keys() As String
    Dim i, n As Integer
    Dim dirs() As Dir

    n = Kids.Count
    If n < 2 Then Return

    ReDim dirs(n - 1)
    ReDim keys(n - 1)

    i = 0
    For Each oDir In Kids
      keys(i) = Right(Strings.StrDup(64, "0") & oDir.Size, 64)
      dirs(i) = oDir
      i += 1
    Next

    Array.Sort(keys, dirs)

    Kids = New List(Of Dir)
    For i = n - 1 To 0 Step -1
      oDir = dirs(i)
      Kids.Add(oDir)
      oDir.Sort()
    Next

  End Sub

  Public Sub DoNodes(ByVal oPNode As TreeNode)
    Dim oSub As Dir
    Dim oNode As TreeNode

    oNode = New TreeNode
    oNode.Text = Me.Name & " " & Me.FSize
    For Each oSub In Kids
      oSub.DoNodes(oNode)
    Next
    oPNode.Nodes.Add(oNode)
  End Sub

End Class
