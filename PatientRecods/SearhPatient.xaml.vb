

Public Class SearhPatient
    Public l_profile As New PatientClass
    Private Sub SearhPatient_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        Me.dtStartDate.SelectedDate = Format(Date.Now.AddDays(-30), "dd.MM.yyyy")
        Me.dtEndDate.SelectedDate = Format(DateTime.Now, "dd.MM.yyyy")
    End Sub

    Private Sub cmdLoad_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdLoad.MouseLeftButtonUp
        Try
            update_gr_patient()

            If Not Me.grPatient.HasItems Then

                If MessageBox.Show("Нет данных" + vbCrLf + "Добавить нового?", "Поиск пациента", MessageBoxButton.YesNo, MessageBoxImage.Information) = MessageBoxResult.Yes Then
                    Dim l_open_win As New NewPatient
                    l_open_win.ShowDialog()
                End If
            End If
            ' Throw New Exception
        Catch ex As Exception
            MsgBox(ex.Message)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "log_patient_records.txt", ex.Message & " " & Date.Now & Environment.NewLine, True)
            ' Dim l_open_ssh As New MainWindow
            ' l_open_ssh.open_ssh_conn()
        End Try
    End Sub

    Private Sub grPatient_MouseDoubleClick(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles grPatient.MouseDoubleClick
        'Try
        Dim l_open_patient_info As New NewPatient
        l_open_patient_info.Title = "Редактировать пациента"
        l_open_patient_info.cmdAddPhoto.Content = "Изменить фото"
        l_open_patient_info.cmdAddDots.Content = "Просмотреть точки"
        l_open_patient_info.cmdSave.Content = "Изменить"
        l_open_patient_info.l_profile.id = CType(Me.grPatient.SelectedItem, PatientClass).id
        l_open_patient_info.txtFamilyName.Text = CType(Me.grPatient.SelectedItem, PatientClass).last_name
        l_open_patient_info.txtFirstName.Text = CType(Me.grPatient.SelectedItem, PatientClass).first_name
        l_open_patient_info.txtPatronymic.Text = CType(Me.grPatient.SelectedItem, PatientClass).second_name
        l_open_patient_info.dtBirthDay.Child.Text = IIf(IsDBNull(CType(Me.grPatient.SelectedItem, PatientClass).birth_date), Nothing, CType(Me.grPatient.SelectedItem, PatientClass).birth_date)
        l_open_patient_info.ddlbSex.Text = CType(Me.grPatient.SelectedItem, PatientClass).sex
        'l_open_patient_info.ddlMedSection.SelectedValue = CType(Me.grPatient.SelectedItem, PatientClass).med_sect_name
        l_open_patient_info.txtMobile.Child.Text = CType(Me.grPatient.SelectedItem, PatientClass).mobile_phone
        l_open_patient_info.txtContactPhone.Child.Text = CType(Me.grPatient.SelectedItem, PatientClass).contact_phone
        l_open_patient_info.txtEMail.Text = CType(Me.grPatient.SelectedItem, PatientClass).e_mail
        l_open_patient_info.txtDiagnos.Text = CType(Me.grPatient.SelectedItem, PatientClass).diagnos
        l_open_patient_info.txtAddress.Text = CType(Me.grPatient.SelectedItem, PatientClass).address
        l_open_patient_info.txtJobPlace.Text = CType(Me.grPatient.SelectedItem, PatientClass).job_place
        l_open_patient_info.txtComplaint.Document = New Documents.FlowDocument(New Documents.Paragraph(New Documents.Run(CType(Me.grPatient.SelectedItem, PatientClass).Complaint)))
        l_open_patient_info.l_profile = CType(Me.grPatient.SelectedItem, PatientClass)

        l_open_patient_info.ShowDialog()
        update_gr_patient()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Sub update_gr_patient()
        Try
            Me.Cursor = Cursors.Wait
            Me.grPatient.ItemsSource = New SearchPatientClassCollect(Me.txtFamilyName.Text, Me.txtFirstName.Text, Me.txtPatronymic.Text, _
            IIf(IsDate(Me.dtBirthDay.Child.Text), Me.dtBirthDay.Child.Text, Nothing), IIf(IsNothing(Me.dtStartDate.SelectedDate), Nothing, Me.dtStartDate.SelectedDate), _
            IIf(IsNothing(Me.dtEndDate.SelectedDate), Nothing, Me.dtEndDate.SelectedDate), Me.ddlMedSection.SelectedValue)

        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub cmdDel_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdDel.MouseLeftButtonUp
        Try
            If Me.grPatient.SelectedItem Is Nothing Then
                MessageBox.Show("Не выбрана запись!", "Удалить запись", MessageBoxButton.OK, MessageBoxImage.Error)
            Else
                If MessageBox.Show("Удалить запись?", "", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel) = MessageBoxResult.OK Then
                    Dim l_patient As New PatientClass
                    l_patient.DelProfile(CType(Me.grPatient.SelectedItem, PatientClass).id)
                    update_gr_patient()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtFamilyName_TextChanged(sender As System.Object, e As System.Windows.Controls.TextChangedEventArgs) Handles txtFamilyName.TextChanged
        If CType(FindName(sender.name), TextBox).Text = Nothing Then
            Me.dtStartDate.SelectedDate = Format(Date.Now.AddDays(-30), "dd.MM.yyyy")
            Me.dtEndDate.SelectedDate = Format(DateTime.Now, "dd.MM.yyyy")
        Else
            Me.dtStartDate.SelectedDate = Nothing
            Me.dtEndDate.SelectedDate = Nothing
        End If
    End Sub

    Private Sub cmdCalendar_MouseLeftButtonUp(sender As System.Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdCalendar.MouseLeftButtonUp
        If Me.grPatient.SelectedItem Is Nothing Then
            MessageBox.Show("Не выбрана запись!", "Календарь", MessageBoxButton.OK, MessageBoxImage.Error)
        Else
            Dim calendarRecord As New CreateRecordDate
            calendarRecord.Owner = Me
            calendarRecord.ShowDialog()
        End If
    End Sub
End Class
