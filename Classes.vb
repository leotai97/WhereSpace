Public Class Dir
  Inherits TreeNode

  Public Size As Long
  Public Original As String

  Public Sub New(ByVal sName As String)
    Me.Text = sName
    Me.Size = 0
    Me.Original = sName
  End Sub

  Public ReadOnly Property FSize() As String
    Get
      Return Fsizer(Me.Size)
    End Get
  End Property

  Public Shared Function Fsizer(ByVal size As Long) As String

    If size < 1024 Then Return size.ToString
    If size < 1024000 Then Return size \ 1024 & " KB"
    If size < 1024000000 Then Return size \ 1024000 & " MB"
    Return size \ 1024000000 & " GB"

  End Function

  Public Sub Parse(ByRef oDir As IO.DirectoryInfo)
    Dim oSubDC As Dir
    Dim oSub As IO.DirectoryInfo
    Dim oFile As IO.FileInfo
    Dim list As IO.DirectoryInfo() = Nothing


    ' full failure

    Try
      list = oDir.GetDirectories()
    Catch ex As Exception
      Me.Text = Me.Text & " <No Access>"
      Return
    End Try

    For Each oSub In list
      oSubDC = New Dir(oSub.Name)
      Me.Nodes.Add(oSubDC)
      oSubDC.Parse(oSub)
      Me.Size += oSubDC.Size
    Next

    For Each oFile In oDir.GetFiles
      Me.Size += oFile.Length
    Next

    Me.Text = Me.Text & " " & FSize

  End Sub


End Class

Public Class Sorter
  Implements IComparer

  Public Enum enumDir
    High
    Low
  End Enum

  Public Direction As enumDir

  Public Sub New(ByVal eDir As enumDir)
    Direction = eDir
  End Sub

  Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
    Dim n1, n2 As Dir

    n1 = x
    n2 = y

    If Me.Direction = enumDir.High Then
      If n1.Size < n2.Size Then Return 1
      If n1.Size > n2.Size Then Return -1
    Else
      If n2.Size < n1.Size Then Return 1
      If n2.Size > n1.Size Then Return -1
    End If
    Return 0  ' equal

  End Function

End Class