
Imports System.Data.OleDb
Imports Renci.SshNet
Imports System.Deployment.Application
Imports MySql.Data.MySqlClient
Imports System.Windows.Threading
Class MainWindow
    Public l_med_section As Object
    Public l_tunnel As ForwardedPortLocal
    Public l_client As SshClient
    Public l_timer As DispatcherTimer
    Private Sub cmdNewPatient_MouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles cmdNewPatient.MouseLeftButtonUp
        Try
            Dim newpatient As New NewPatient()

            newpatient.Owner = Me
            newpatient.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdSearhPatient_MouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles cmdSearhPatient.MouseLeftButtonUp
        Try
            Dim searhpatient As New SearhPatient()
            Dim l_profile As New PatientClass
            searhpatient.ddlMedSection.ItemsSource = l_profile.get_med_section.DefaultView
            searhpatient.Owner = Me
            searhpatient.ShowDialog()
        Catch ex As Exception
            open_ssh_conn()
            ' MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub cmdCreateDB_MouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles cmdCreateDB.MouseLeftButtonUp
    ' Dim test As Byte() = My.Resources.id_rsa
    'IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory & "id_rsa", My.Resources.id_rsa)
    '    Dim l_private_key As String
    '    l_private_key = IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory & "Key\id_rsa")

    'Using l_stream = New IO.FileStream("I:\PatientRecods\PatientRecods\bin\Debug\Key\id_rsa", IO.FileMode.Open, IO.FileAccess.Read)
    '        Dim pk = New PrivateKeyFile(l_stream, "5HAN7PZ2?AdQ")
    '        Dim con_info = New ConnectionInfo("cpanel11.d.fozzy.com", 22, "romanber", New PrivateKeyAuthenticationMethod("romanber", pk))
    '        Dim l_client = New SshClient(con_info)
    '        l_client.Connect()
    '        Dim l_tunnel = New ForwardedPortLocal("127.0.0.1", 22, "127.0.0.1", 3306)
    '        l_client.AddForwardedPort(l_tunnel)
    '        l_tunnel.Start()
    '        Dim conn As New MySqlConnection("Server=127.0.0.1;Database=romanber_patient;User Id=romanber_admin;Password=abcd@12345;charset=cp1251;Port=22")
    '        Dim cmd As New MySqlCommand("select * from test", conn)
    '        ' cmd.Connection = conn
    '        conn.Open()
    '        Dim test As String = cmd.ExecuteScalar
    '        conn.Close()

    '        l_tunnel.Stop()
    '        l_client.Disconnect()
    '    End Using



    '    'l_key.HostKey. = l_pr_key_byte
    '    'Try


    '    '    'Using l_client As New SshNet.SshClient(con_info)
    '    '    '    l_client.Connect()
    '    '    '    l_client.
    '    '    '    l_client.Disconnect()
    '    '    'End Using
    '    'Catch ex As Common.ProxyException
    '    '    MsgBox(ex.Message)
    '    'End Try

    '    'Dim cat As New ADOX.Catalog
    '    'Try
    '    '    If IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\DB\PatientRecordsDB.mdb") = True Then
    '    '        Me.cmdCreateDB.IsEnabled = False
    '    '        MessageBox.Show("База данных уже существует")
    '    '        Exit Sub
    '    '    Else
    '    '        cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & AppDomain.CurrentDomain.BaseDirectory & "\DB\PatientRecordsDB.mdb")
    '    '        MessageBox.Show("База данных " & AppDomain.CurrentDomain.BaseDirectory & "\DB\PatientRecordsDB.mdb успешно создана")
    '    '        Me.cmdNewPatient.IsEnabled = True
    '    '        Me.cmdSearhPatient.IsEnabled = True
    '    '        Me.cmdCreateDB.IsEnabled = False
    '    '    End If
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)
    '    'End Try
    'End Sub

    Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded

        Try
            l_timer = New DispatcherTimer
            l_timer.Interval = TimeSpan.FromSeconds(60)
            AddHandler l_timer.Tick, AddressOf timer_tick

            IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory & "id_rsa", My.Resources.id_rsa)
            open_ssh_conn()
            l_timer.Start()
            'String.Format("Версия {0}.{1}.{2}.{3}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor,
            ' My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

            Me.txtVersion.Content = String.Format("Версия {0}", ApplicationDeployment.CurrentDeployment.CurrentVersion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub timer_tick()
        Try
            If l_tunnel.IsStarted Then
                lblConnect.Content = "Подключено"
            Else
                lblConnect.Content = "Не Подключено"
                'l_client.Connect()
                l_tunnel.Start()
            End If
            'My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "log_patient_records.txt", lblConnect.Content & " " & Date.Now & Environment.NewLine, True)
        Catch ex As Exception
            MsgBox(ex.Message)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "log_patient_records.txt", "Ошибка повторного подключения " & ex.Message & " " & Date.Now & Environment.NewLine, True)
        End Try
    End Sub
    Public Sub open_ssh_conn()

        Dim l_stream = New IO.FileStream(AppDomain.CurrentDomain.BaseDirectory & "id_rsa", IO.FileMode.Open, IO.FileAccess.Read)
        Dim pk = New PrivateKeyFile(l_stream, "5HAN7PZ2?AdQ")
        l_stream.Dispose()
        Dim con_info = New ConnectionInfo("cpanel14.d.fozzy.com", 22, "romanber", New PrivateKeyAuthenticationMethod("romanber", pk))
        l_client = New SshClient(con_info)
        l_client.Connect()
        l_tunnel = New ForwardedPortLocal("127.0.0.1", 22, "127.0.0.1", 3306)
        l_client.AddForwardedPort(l_tunnel)
        'If Not l_tunnel.IsStarted Then
        l_tunnel.Start()


        'End If
        'Dim conn As New MySqlConnection("Server=127.0.0.1;Database=romanber_patient;User Id=romanber_admin;Password=abcd@12345;charset=cp1251;Port=22")
        ' Dim cmd As New MySqlCommand("select * from test", conn)
        ' cmd.Connection = conn
        ' conn.Open()
        'Dim test As String = cmd.ExecuteScalar
        'conn.Close()

        ' l_tunnel.Stop()
        'l_client.Disconnect()
        'End Using
    End Sub

    Private Sub cmdCalendar_MouseLeftButtonUp(sender As System.Object, e As System.Windows.Input.MouseButtonEventArgs) Handles cmdCalendar.MouseLeftButtonUp
        Dim calendar As New Calendar
        calendar.Owner = Me
        calendar.ShowDialog()
    End Sub
End Class
