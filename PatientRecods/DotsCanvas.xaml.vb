Imports System.Windows.Media.Animation
Imports PatientRecods.ClassStrokes
Public Class DotsCanvas
    Public l_strok As New List(Of ClassStrokes)
    Public l_visible_strokes As Boolean
    Public l_strok_name As String
    Private Sub cmdSave_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdSave.MouseLeftButtonUp
        Try
            'l_strok.Clear()
            l_strok.RemoveAll(Function(x) x.stroke_name.Contains(l_strok_name))
            l_strok.Add(New ClassStrokes(l_strok_name, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
                                         Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
                                         Nothing, IIf(l_visible_strokes, cmn.GetByteFromCanvas(Me.DrawlingCanvas), cmn.ImgGetBytesFromImg(Me.PhotoCanvas.Source)), Me.DrawlingCanvas.Strokes))

            Me.DialogResult = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DotsCanvas_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        'menushow("IncreaseWidth")
        'menushow("IncreaseHeight")

        'Me.WindowStyle = Windows.WindowStyle.SingleBorderWindow
        If l_visible_strokes Then
            Me.DrawlingCanvas.Strokes = l_strok.Find(Function(x) x.stroke_name.Contains(l_strok_name)).strokes
        Else
            Me.PhotoCanvas.Source = cmn.ImgGetImgFromByte(IIf(l_strok.Find(Function(x) x.stroke_name.Contains(l_strok_name)).lnk_canvas1.Length > 0, l_strok.Find(Function(x) x.stroke_name.Contains(l_strok_name)).lnk_canvas1, Nothing))
        End If
    End Sub

    'Public Sub menushow(p1 As String)
    '    'Throw New NotImplementedException
    '    Dim sb As Storyboard = Resources("p")
    '    sb.Begin(Me)

    'End Sub

    'Private Sub w2_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles w2.Loaded
    '    menushow("IncreaseWidth")
    '    menushow("IncreaseHeight")
    'End Sub


    Private Sub cmdClear_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdClear.MouseLeftButtonUp
        Me.DrawlingCanvas.Strokes.Clear()
        l_strok.RemoveAll(Function(x) x.stroke_name.Contains(l_strok_name))
    End Sub
End Class
