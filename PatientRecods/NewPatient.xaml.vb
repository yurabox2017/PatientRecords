Imports System.Data.OleDb
Imports Microsoft.VisualBasic.Information
Imports System.Windows.Ink

Public Class NewPatient
    Public l_strokes As New List(Of ClassStrokes)
    Public l_profile As New PatientClass
    Private Sub cmdSave_MouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles cmdSave.MouseLeftButtonUp

        Try
            With Me.l_profile
                .last_name = Me.txtFamilyName.Text
                .first_name = Me.txtFirstName.Text
                .second_name = Me.txtPatronymic.Text()
                If IsDate(Me.dtBirthDay.Child.Text) Then .birth_date = Me.dtBirthDay.Child.Text
                If Me.txtContactPhone.Child.Text.Replace(" ", Nothing).Length > 2 Then .contact_phone = Me.txtContactPhone.Child.Text
                If Me.txtMobile.Child.Text.Replace(" ", Nothing).Length > 2 Then .mobile_phone = Me.txtMobile.Child.Text
                .e_mail = Me.txtEMail.Text
                If Me.ddlbSex.SelectedItem IsNot Nothing Then .sex = Me.ddlbSex.SelectedItem.Content
                If Me.ddlMedSection.SelectedItem IsNot Nothing Then .med_sect_id = Me.ddlMedSection.SelectedValue
                .diagnos = Me.txtDiagnos.Text
                .address = Me.txtAddress.Text
                .job_place = Me.txtJobPlace.Text

                .strokes = l_strokes
                'If l_strokes.Count > 0 Then .ImgCanvas2 = l_strokes.Find(Function(x) x.stroke_name.Contains("stroke1")).strokes.Find(Function(x) x.canvas_name.Contains("stroke1")).lnk_canvas
                .Complaint = New TextRange(Me.txtComplaint.Document.ContentStart, Me.txtComplaint.Document.ContentEnd).Text
            End With

            If Me.cmdSave.Content = "Сохранить" Then
                Me.l_profile.SaveProfile()
            Else
                Me.l_profile.EditProfile()
            End If

            Me.refresh()

            If Me.cmdSave.Content = "Изменить" Then
                Me.DialogResult = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub cmdAddPhoto_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdAddPhoto.MouseLeftButtonUp
        Try
            Dim l_str As test = New test
            l_str.testsend = "привет как дела"
            Dim l_win As New LoadPicture
            'Передаем фото
            l_win.l_photos = l_profile
            l_win.Owner = Me
            l_win.ShowDialog()
            'Получаем фото
            l_profile = l_win.l_photos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub refresh()
        Me.txtFamilyName.Text = Nothing
        Me.txtFirstName.Text = Nothing
        Me.txtPatronymic.Text = Nothing
        Me.dtBirthDay.Child.Text = Nothing
        Me.txtContactPhone.Child.Text = Nothing
        Me.txtMobile.Child.Text = Nothing
        Me.txtEMail.Text = Nothing
        Me.ddlbSex.SelectedItem = Nothing
        Me.txtDiagnos.Text = Nothing
        Me.txtAddress.Text = Nothing
        Me.txtJobPlace.Text = Nothing
        Me.txtComplaint.Document.Blocks.Clear()
        l_strokes.Clear()
        l_profile = Nothing
        l_profile = New PatientClass

    End Sub

    Private Sub cmdAddDots_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdAddDots.MouseLeftButtonUp
        Try
            Dim l_open_dots As New Dots
            'Передаем
            l_open_dots.l_patient = l_profile

            'If Me.cmdSave.Content = "Изменить" Then
            '    l_open_dots.cmdSave.Content = "Изменить"

            '    'l_open_dots.DrawlingCanvas.Visibility = Windows.Visibility.Hidden
            '    'l_open_dots.PhotoCanvas.Visibility = Windows.Visibility.Visible
            '    'l_open_dots.cmdClear.Visibility = Windows.Visibility.Hidden
            '    'l_open_dots.cmdClearAll.Visibility = Windows.Visibility.Hidden
            '    'l_open_dots.l_visible_strokes = False
            'Else
            '    'l_open_dots.l_visible_strokes = True
            'End If
            l_open_dots.Owner = Me
            l_open_dots.ShowDialog()

            'l_open_dots.PhotoCanvas.Visibility = Windows.Visibility.Hidden
            'Получаем
            l_profile.strokes = l_open_dots.l_patient.strokes
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdClearAll_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdClearAll.MouseLeftButtonUp
        refresh()
    End Sub

    Private Sub NewPatient_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        Me.ddlMedSection.ItemsSource = l_profile.get_med_section.DefaultView
        Me.ddlMedSection.SelectedValue = l_profile.med_sect_id
    End Sub
End Class
