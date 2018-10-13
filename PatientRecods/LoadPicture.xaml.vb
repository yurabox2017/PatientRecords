Imports System.Windows.Media.Animation

Public Class LoadPicture
    Public l_photos As PatientClass
    Private Sub cmdPhotoPers1_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdPhotoPers1.MouseLeftButtonUp
        Dim l_file_dlg = New Microsoft.Win32.OpenFileDialog

        If l_file_dlg.ShowDialog Then
            Dim l_img_source As New System.Windows.Media.Imaging.BitmapImage

            l_img_source.BeginInit()
            l_img_source.UriSource = New Uri(l_file_dlg.FileName, UriKind.Relative)
            l_img_source.EndInit()
            l_img_source.Freeze()

            Select Case sender.Name
                Case "cmdPhotoPers1"
                    Me.PhotoPers1.Source = l_img_source
                Case "cmdPhotoPers2"
                    Me.PhotoPers2.Source = l_img_source
                Case "cmdPhotoPers3"
                    Me.PhotoPers3.Source = l_img_source
                Case "cmdPhotoXRay1"
                    Me.PhotoXRay1.Source = l_img_source
                Case "cmdPhotoXRay2"
                    Me.PhotoXRay2.Source = l_img_source
                Case "cmdPhotoXRay3"
                    Me.PhotoXRay3.Source = l_img_source
                Case "cmdPhotoXRay4"
                    Me.PhotoXRay4.Source = l_img_source
            End Select

        End If
    End Sub

    Private Sub cmdAddPhoto_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdAddPhoto.MouseLeftButtonUp
        Try
            With Me.l_photos
                .photo_pers1 = cmn.ImgGetBytesFromImg(Me.PhotoPers1.Source)
                .photo_pers2 = cmn.ImgGetBytesFromImg(Me.PhotoPers2.Source)
                .photo_pers3 = cmn.ImgGetBytesFromImg(Me.PhotoPers3.Source)
                .photo_xray1 = cmn.ImgGetBytesFromImg(Me.PhotoXRay1.Source)
                .photo_xray2 = cmn.ImgGetBytesFromImg(Me.PhotoXRay2.Source)
                .photo_xray3 = cmn.ImgGetBytesFromImg(Me.PhotoXRay3.Source)
                .photo_xray4 = cmn.ImgGetBytesFromImg(Me.PhotoXRay4.Source)
            End With
            Me.DialogResult = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadPicture_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        Try
            Dim l_test As test = New test
            MsgBox(l_test.testsend)
            With Me.l_photos
                Me.PhotoPers1.Source = cmn.ImgGetImgFromByte(IIf(.photo_pers1 IsNot Nothing, .photo_pers1, Nothing))
                Me.PhotoPers2.Source = cmn.ImgGetImgFromByte(IIf(.photo_pers2 IsNot Nothing, .photo_pers2, Nothing))
                Me.PhotoPers3.Source = cmn.ImgGetImgFromByte(IIf(.photo_pers3 IsNot Nothing, .photo_pers3, Nothing))
                Me.PhotoXRay1.Source = cmn.ImgGetImgFromByte(IIf(.photo_xray1 IsNot Nothing, .photo_xray1, Nothing))
                Me.PhotoXRay2.Source = cmn.ImgGetImgFromByte(IIf(.photo_xray2 IsNot Nothing, .photo_xray2, Nothing))
                Me.PhotoXRay3.Source = cmn.ImgGetImgFromByte(IIf(.photo_xray3 IsNot Nothing, .photo_xray3, Nothing))
                Me.PhotoXRay4.Source = cmn.ImgGetImgFromByte(IIf(.photo_xray4 IsNot Nothing, .photo_xray4, Nothing))
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdClearAll_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdClearAll.MouseLeftButtonUp
        Me.PhotoPers1.Source = Nothing
        Me.PhotoPers2.Source = Nothing
        Me.PhotoPers3.Source = Nothing
        Me.PhotoXRay1.Source = Nothing
        Me.PhotoXRay2.Source = Nothing
        Me.PhotoXRay3.Source = Nothing
        Me.PhotoXRay4.Source = Nothing
    End Sub

    'Private Sub PhotoPers1_MouseEnter(sender As System.Object, e As System.Windows.Input.MouseEventArgs) Handles PhotoPers1.MouseEnter
    '    'Me.PhotoPers1.Height = 200
    'End Sub

    'Private Sub PhotoPers1_ImageFailed(sender As System.Object, e As System.Windows.ExceptionRoutedEventArgs)

    'End Sub

    'Private Sub Canvas1_MouseEnter(sender As System.Object, e As System.Windows.Input.MouseEventArgs) Handles Canvas1.MouseEnter
    '    Canvas.SetLeft(Me.PhotoPers1, 30)
    '    Canvas.SetTop(Me.PhotoPers1, 30)
    'End Sub

    'Private Sub PhotoPers1_MouseEnter(sender As System.Object, e As System.Windows.Input.MouseEventArgs) Handles PhotoPers1.MouseEnter
    '    Image. .SetLeft(Me.PhotoPers1, 50)
    '    ImageDrawi()
    'End Sub

    'Private Sub Border1_MouseEnter(sender As System.Object, e As System.Windows.Input.MouseEventArgs) Handles Border1.MouseEnter
    '    Border(Me.PhotoPers1, 50)
    'End Sub

    'Private Sub Canvas1_MouseLeave(sender As System.Object, e As System.Windows.Input.MouseEventArgs) Handles Canvas1.MouseLeave
    '    Canvas.SetLeft(Me.PhotoPers1, 0)
    '    Canvas.SetTop(Me.PhotoPers1, 0)
    'End Sub

    'Private Sub Canvas1_MouseEnter(sender As System.Object, e As System.Windows.Input.MouseEventArgs) Handles Canvas1.MouseEnter
    '    Select Case sender.Name
    '        Case "Canvas1"

    '            CType(FindName("Border" & 1), Border).Focus()



    '    End Select
    'End Sub

    'Private Sub Canvas1_MouseLeave(sender As System.Object, e As System.Windows.Input.MouseEventArgs) Handles Canvas1.MouseLeave
    '    Select Case sender.Name
    '        Case "Canvas1"
    '            For i = 1 To 2
    '                CType(FindName("Border" & i), Border).Visibility = Windows.Visibility.Visible
    '            Next
    '    End Select
    'End Sub

    Private Sub PhotoPers1_MouseLeftButtonUp(sender As System.Object, e As System.Windows.Input.MouseButtonEventArgs) Handles PhotoPers1.MouseLeftButtonUp
        'CType(FindName("Border2"), Border).Visibility = Windows.Visibility.Hidden
        'Grid.SetZIndex(Me.PhotoPers1, 10)
        Dim l_image As Image = CType(Me.FindName(sender.name), Image)
        If l_image.RenderTransform.Value.M11 <> 1.0 Then
            move_scale(l_image, 1, 1, 1)
        Else
            Select Case sender.Name
                Case "PhotoPers1"
                    Panel.SetZIndex(Me.Border1, 1)
                    Panel.SetZIndex(Me.Border2, 0)
                    Panel.SetZIndex(Me.Border3, 0)
                    Panel.SetZIndex(Me.Border4, 0)
                    Panel.SetZIndex(Me.Border5, 0)
                    Panel.SetZIndex(Me.Border6, 0)
                    Panel.SetZIndex(Me.Border7, 0)
                    move_scale(l_image, 3.5, 1, 1)
                    'Panel.SetZIndex(Me.Border1, 0)
                Case "PhotoPers2"
                    Panel.SetZIndex(Me.Border1, 0)
                    Panel.SetZIndex(Me.Border2, 1)
                    Panel.SetZIndex(Me.Border3, 0)
                    Panel.SetZIndex(Me.Border4, 0)
                    Panel.SetZIndex(Me.Border5, 0)
                    Panel.SetZIndex(Me.Border6, 0)
                    Panel.SetZIndex(Me.Border7, 0)
                    move_scale(l_image, 3.5, -50, 1)
                Case "PhotoPers3"
                    Panel.SetZIndex(Me.Border1, 0)
                    Panel.SetZIndex(Me.Border2, 0)
                    Panel.SetZIndex(Me.Border3, 1)
                    Panel.SetZIndex(Me.Border4, 0)
                    Panel.SetZIndex(Me.Border5, 0)
                    Panel.SetZIndex(Me.Border6, 0)
                    Panel.SetZIndex(Me.Border7, 0)
                    move_scale(l_image, 3.5, -100, 1)
            End Select
        End If
    End Sub
    Private Sub PhotoXRay1_MouseLeftButtonUp(sender As System.Object, e As System.Windows.Input.MouseButtonEventArgs) Handles PhotoXRay1.MouseLeftButtonUp
        Dim l_image As Image = CType(Me.FindName(sender.name), Image)
        If l_image.RenderTransform.Value.M11 <> 1.0 Then
            move_scale(l_image, 1, 1, 1)
        Else
            Select Case sender.Name
                Case "PhotoXRay1"
                    Panel.SetZIndex(Me.Border1, 0)
                    Panel.SetZIndex(Me.Border2, 0)
                    Panel.SetZIndex(Me.Border3, 0)
                    Panel.SetZIndex(Me.Border4, 1)
                    Panel.SetZIndex(Me.Border5, 0)
                    Panel.SetZIndex(Me.Border6, 0)
                    Panel.SetZIndex(Me.Border7, 0)
                    move_scale(l_image, 3.5, 1, -70)
                    'Panel.SetZIndex(Me.Border1, 0)
                Case "PhotoXRay2"
                    Panel.SetZIndex(Me.Border1, 0)
                    Panel.SetZIndex(Me.Border2, 0)
                    Panel.SetZIndex(Me.Border3, 0)
                    Panel.SetZIndex(Me.Border4, 0)
                    Panel.SetZIndex(Me.Border5, 1)
                    Panel.SetZIndex(Me.Border6, 0)
                    Panel.SetZIndex(Me.Border7, 0)
                    move_scale(l_image, 3.5, -50, -70)
                Case "PhotoXRay3"
                    Panel.SetZIndex(Me.Border1, 0)
                    Panel.SetZIndex(Me.Border2, 0)
                    Panel.SetZIndex(Me.Border3, 0)
                    Panel.SetZIndex(Me.Border4, 0)
                    Panel.SetZIndex(Me.Border5, 0)
                    Panel.SetZIndex(Me.Border6, 1)
                    Panel.SetZIndex(Me.Border7, 0)
                    'Panel.SetZIndex(Me.Border4, 1)
                    move_scale(l_image, 3.5, -100, -70)
                Case "PhotoXRay4"
                    Panel.SetZIndex(Me.Border1, 0)
                    Panel.SetZIndex(Me.Border2, 0)
                    Panel.SetZIndex(Me.Border3, 0)
                    Panel.SetZIndex(Me.Border4, 0)
                    Panel.SetZIndex(Me.Border5, 0)
                    Panel.SetZIndex(Me.Border6, 0)
                    Panel.SetZIndex(Me.Border7, 1)
                    move_scale(l_image, 3.5, -150, -70)
            End Select
        End If
    End Sub
    Sub move_scale(p_image As Image, p_scale As Double, p_moveX As Double, p_moveY As Double)
        Dim test As Object = Me.Width

        Dim l_move As TranslateTransform = New TranslateTransform(p_moveX, p_moveY)
        Dim l_scale As ScaleTransform = New ScaleTransform(p_scale, p_scale)

        Dim l_anim_scale As DoubleAnimation = New DoubleAnimation(1, p_scale, New Duration(TimeSpan.FromSeconds(1)))
        Dim l_anim_moveX As DoubleAnimation = New DoubleAnimation(1, p_moveX, New Duration(TimeSpan.FromSeconds(1)))
        Dim l_anim_moveY As DoubleAnimation = New DoubleAnimation(1, p_moveY, New Duration(TimeSpan.FromSeconds(1)))

        Dim l_transGrp As TransformGroup = New TransformGroup
        l_transGrp.Children.Add(l_move)
        l_transGrp.Children.Add(l_scale)
        p_image.RenderTransform = l_transGrp

        'anim1.From = 1
        'anim1.To = 100
        'anim2.From = 1
        'anim2.To = newX

        l_transGrp.Children(0).BeginAnimation(TranslateTransform.XProperty, l_anim_moveX, HandoffBehavior.Compose)
        l_transGrp.Children(0).BeginAnimation(TranslateTransform.YProperty, l_anim_moveY, HandoffBehavior.Compose)
        l_transGrp.Children(1).BeginAnimation(ScaleTransform.ScaleXProperty, l_anim_scale, HandoffBehavior.Compose)
        l_transGrp.Children(1).BeginAnimation(ScaleTransform.ScaleYProperty, l_anim_scale, HandoffBehavior.Compose)
        'Grid.SetZIndex(target, 10)
        ' dim
        'dim tr As TranslateTransform = target.RenderTransform  (target.RenderTransform).Children(1)  TranslateTransform
        'l_tra()
        'anim2.Duration = New Duration(TimeSpan.FromSeconds(0.5))
        'New DoubleAnimation(left, newX - left, New Duration(TimeSpan.FromSeconds(2)))
        ' trans.BeginAnimation(TranslateTransform.XProperty, anim1)
        ' trans.BeginAnimation(TranslateTransform.XProperty, anim2)
        'l_transGrp.BeginAnimation(, anim2)
        'scale.BeginAnimation(l_transGrp.Transform, anim2)
        'scale.BeginAnimation(ScaleTransform.ScaleYProperty, anim2)
        'trans.BeginAnimation(TranslateTransform.XProperty, anim2)
        'trans.BeginAnimation(TranslateTransform.YProperty, anim2)
    End Sub


End Class
