Imports System.IO
Imports System.Windows.Ink
Imports System.Windows.Media.Animation
Public Class Dots
    Public l_strok As New List(Of ClassStrokes)
    Public l_visible_strokes As Boolean
    Public l_patient As New PatientClass
    Private Sub cmdSave_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdSave.MouseLeftButtonUp

        'l_patient.strokes = New List(Of ClassStrokes)
        'l_patient.strokes.Add(New ClassStrokes("stroke0", CType(FindName("DrawlingCanvas"), InkCanvas).Strokes))

        'For i = 1 To 20
        '    l_patient.strokes.Add(New ClassStrokes("stroke" & i, CType(FindName("DrawlingCanvas" & i), InkCanvas).Strokes))
        'Next
        'Try
        l_patient.data1 = Me.txtData1.Text
        l_patient.data2 = Me.txtData2.Text
        l_patient.data3 = Me.txtData3.Text
        l_patient.data4 = Me.txtData4.Text
        l_patient.data5 = Me.txtData5.Text
        l_patient.data6 = Me.txtData6.Text
        l_patient.data7 = Me.txtData7.Text
        l_patient.data8 = Me.txtData8.Text
        l_patient.data9 = Me.txtData9.Text
        l_patient.data10 = Me.txtData10.Text
        l_patient.data11 = Me.txtData11.Text
        l_patient.data12 = Me.txtData12.Text
        l_patient.data13 = Me.txtData13.Text
        l_patient.data14 = Me.txtData14.Text
        l_patient.data15 = Me.txtData15.Text
        l_patient.data16 = Me.txtData16.Text
        l_patient.data17 = Me.txtData17.Text
        l_patient.data18 = Me.txtData18.Text
        l_patient.data19 = Me.txtData19.Text
        l_patient.data20 = Me.txtData20.Text

        l_patient.zhang_fu_xu = Me.txtZhang.Text
        l_patient.xang_ke_qi = Me.txtXang.Text

        l_patient.comment1 = Me.txtComment1.Text
        l_patient.comment2 = Me.txtComment2.Text
        l_patient.comment3 = Me.txtComment3.Text
        l_patient.comment4 = Me.txtComment4.Text
        l_patient.comment5 = Me.txtComment5.Text
        l_patient.comment6 = Me.txtComment6.Text
        l_patient.comment7 = Me.txtComment7.Text
        l_patient.comment8 = Me.txtComment8.Text
        l_patient.comment9 = Me.txtComment9.Text
        l_patient.comment10 = Me.txtComment10.Text
        l_patient.comment11 = Me.txtComment11.Text
        l_patient.comment12 = Me.txtComment12.Text
        l_patient.comment13 = Me.txtComment13.Text
        l_patient.comment14 = Me.txtComment14.Text
        l_patient.comment15 = Me.txtComment15.Text
        l_patient.comment16 = Me.txtComment16.Text
        l_patient.comment17 = Me.txtComment17.Text
        l_patient.comment18 = Me.txtComment18.Text
        l_patient.comment19 = Me.txtComment19.Text
        l_patient.comment20 = Me.txtComment20.Text

        l_patient.stvol = Me.txtStvol.Text
        l_patient.vetv = Me.txtVetv.Text
        l_patient.layer = Me.txtLayer.Text

        l_patient.txtDot0 = Me.txtDot0.Text
        l_patient.txtDot1 = Me.txtDot1.Text
        l_patient.txtDot2 = Me.txtDot2.Text
        l_patient.txtDot3 = Me.txtDot3.Text
        l_patient.txtDot4 = Me.txtDot4.Text
        l_patient.txtDot5 = Me.txtDot5.Text
        l_patient.txtDot6 = Me.txtDot6.Text
        l_patient.txtDot7 = Me.txtDot7.Text
        l_patient.txtDot8 = Me.txtDot8.Text
        l_patient.txtDot9 = Me.txtDot9.Text
        l_patient.txtDot10 = Me.txtDot10.Text
        l_patient.txtDot11 = Me.txtDot11.Text
        l_patient.txtDot12 = Me.txtDot12.Text
        l_patient.txtDot13 = Me.txtDot13.Text
        l_patient.txtDot14 = Me.txtDot14.Text
        l_patient.txtDot15 = Me.txtDot15.Text
        l_patient.txtDot16 = Me.txtDot16.Text
        l_patient.txtDot17 = Me.txtDot17.Text
        l_patient.txtDot18 = Me.txtDot18.Text
        l_patient.txtDot19 = Me.txtDot19.Text
        l_patient.txtDot20 = Me.txtDot20.Text

        'If Me.cmdSave.Content <> "Изменить" Then
        '    l_patient.ImgCanvas0 = cmn.GetByteFromCanvas(Me.DrawlingCanvas)

        'Else
        '    l_patient.ImgCanvas0 = cmn.ImgGetBytesFromImg(Me.PhotoCanvas.Source)

        'End If

        Me.DialogResult = False
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Dots_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        Try
            Me.txtZhang.Text = l_patient.zhang_fu_xu
            Me.txtXang.Text = l_patient.xang_ke_qi
            Me.txtData1.Text = l_patient.data1
            Me.txtData2.Text = l_patient.data2
            Me.txtData3.Text = l_patient.data3
            Me.txtData4.Text = l_patient.data4
            Me.txtData5.Text = l_patient.data5
            Me.txtData6.Text = l_patient.data6
            Me.txtData7.Text = l_patient.data7
            Me.txtData8.Text = l_patient.data8
            Me.txtData9.Text = l_patient.data9
            Me.txtData10.Text = l_patient.data10
            Me.txtData11.Text = l_patient.data11
            Me.txtData12.Text = l_patient.data12
            Me.txtData13.Text = l_patient.data13
            Me.txtData14.Text = l_patient.data14
            Me.txtData15.Text = l_patient.data15
            Me.txtData16.Text = l_patient.data16
            Me.txtData17.Text = l_patient.data17
            Me.txtData18.Text = l_patient.data18
            Me.txtData19.Text = l_patient.data19
            Me.txtData20.Text = l_patient.data20

            Me.txtComment1.Text = l_patient.comment1
            Me.txtComment2.Text = l_patient.comment2
            Me.txtComment3.Text = l_patient.comment3
            Me.txtComment4.Text = l_patient.comment4
            Me.txtComment5.Text = l_patient.comment5
            Me.txtComment6.Text = l_patient.comment6
            Me.txtComment7.Text = l_patient.comment7
            Me.txtComment8.Text = l_patient.comment8
            Me.txtComment9.Text = l_patient.comment9
            Me.txtComment10.Text = l_patient.comment10
            Me.txtComment11.Text = l_patient.comment11
            Me.txtComment12.Text = l_patient.comment12
            Me.txtComment13.Text = l_patient.comment13
            Me.txtComment14.Text = l_patient.comment14
            Me.txtComment15.Text = l_patient.comment15
            Me.txtComment16.Text = l_patient.comment16
            Me.txtComment17.Text = l_patient.comment17
            Me.txtComment18.Text = l_patient.comment18
            Me.txtComment19.Text = l_patient.comment19
            Me.txtComment20.Text = l_patient.comment20

            Me.txtStvol.Text = l_patient.stvol
            Me.txtVetv.Text = l_patient.vetv
            Me.txtLayer.Text = l_patient.layer

            Me.txtDot0.Text = l_patient.txtDot0
            Me.txtDot1.Text = l_patient.txtDot1
            Me.txtDot2.Text = l_patient.txtDot2
            Me.txtDot3.Text = l_patient.txtDot3
            Me.txtDot4.Text = l_patient.txtDot4
            Me.txtDot5.Text = l_patient.txtDot5
            Me.txtDot6.Text = l_patient.txtDot6
            Me.txtDot7.Text = l_patient.txtDot7
            Me.txtDot8.Text = l_patient.txtDot8
            Me.txtDot9.Text = l_patient.txtDot9
            Me.txtDot10.Text = l_patient.txtDot10
            Me.txtDot11.Text = l_patient.txtDot11
            Me.txtDot12.Text = l_patient.txtDot12
            Me.txtDot13.Text = l_patient.txtDot13
            Me.txtDot14.Text = l_patient.txtDot14
            Me.txtDot15.Text = l_patient.txtDot15
            Me.txtDot16.Text = l_patient.txtDot16
            Me.txtDot17.Text = l_patient.txtDot17
            Me.txtDot18.Text = l_patient.txtDot18
            Me.txtDot19.Text = l_patient.txtDot19
            Me.txtDot20.Text = l_patient.txtDot20

            If l_visible_strokes Then
                If l_patient.strokes IsNot Nothing Then
                    'Me.DrawlingCanvas.Strokes = l_patient.strokes.Find(Function(x) x.stroke_name.Contains("stroke0")).strokes
                    'For i = 1 To 20
                    '    CType(FindName("DrawlingCanvas" & i), InkCanvas).Strokes = l_patient.strokes.Find(Function(x) x.stroke_name.Contains("stroke" & i)).strokes
                    'Next
                End If
                'Else
                '    Me.PhotoCanvas.Source = cmn.ImgGetImgFromByte(IIf(l_patient.ImgCanvas0 IsNot Nothing, l_patient.ImgCanvas0, Nothing))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub cmdClear_PreviewMouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdClear.PreviewMouseLeftButtonUp
    '    'Me.DrawlingCanvas.Strokes.Clear()
    'End Sub

    Private Sub cmdClearAll_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdClearAll.MouseLeftButtonUp
        For i = 1 To 20
            'CType(FindName("DrawlingCanvas" & i), InkCanvas).Strokes.Clear()
            CType(FindName("txtData" & i), TextBox).Text = Nothing
            CType(FindName("txtComment" & i), TextBox).Text = Nothing
            CType(FindName("txtDot" & i), TextBox).Text = Nothing
        Next
        'Me.DrawlingCanvas.Strokes.Clear()
        Me.txtDot0.Text = Nothing
        Me.txtStvol.Text = Nothing
        Me.txtVetv.Text = Nothing
        Me.txtLayer.Text = Nothing

        Me.txtZhang.Text = Nothing
        Me.txtXang.Text = Nothing

    End Sub
    Function get_image(p_byte As Byte()) As Object
        If p_byte IsNot Nothing Then
            Return p_byte
        Else
            Return Nothing
        End If

    End Function

    'Function AnimationProp(p_window As DotsCanvas) As DoubleAnimation
    '    Dim l_dbl_anim As New DoubleAnimation
    '    'p_window.WindowStyle = Windows.WindowStyle.None
    '    'p_window.AllowsTransparency = True
    '    l_dbl_anim.From = 0
    '    l_dbl_anim.To = 1
    '    l_dbl_anim.Duration = New Duration(TimeSpan.FromSeconds(2))
    '    Return l_dbl_anim
    'End Function

End Class
