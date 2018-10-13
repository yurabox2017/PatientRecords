Imports System.Data.OleDb
Imports System.Windows.Navigation
Imports System.Data
Imports System.Windows.Ink
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Renci.SshNet
Public Structure test
    Private _test_name As String
    Public Property testsend As String
        Get
            Return _test_name
        End Get
        Set(ByVal value As String)
            _test_name = value
        End Set
    End Property
End Structure
Public Class PatientClass
    Inherits Object
    Public conn = New MySqlConnection("Server=127.0.0.1;Database=romanber_patient;User Id=romanber_admin;Password=abcd@12345;charset=cp1251;Port=22;default command timeout=10000")
    Structure NewPatientProfile
        Dim id As Int32
        Dim photo_pers1 As Byte()
        Dim photo_pers2 As Byte()
        Dim photo_pers3 As Byte()
        Dim photo_xray1 As Byte()
        Dim photo_xray2 As Byte()
        Dim photo_xray3 As Byte()
        Dim photo_xray4 As Byte()

        Dim zhang_fu_xu As String
        Dim xang_ke_qi As String
        Dim data As String

        Dim ImgCanvas1 As Byte()
        Dim ImgCanvas2 As Byte()

    End Structure
#Region "свойства"
    'Structure NewPatientProfile
    Private _id As Int32
    Private _last_name As String
    Private _first_name As String
    Private _second_name As String
    Private _birth_date As String
    Private _contact_phone As String
    Private _mobile_phone As String
    Private _e_mail As String
    Private _sex As String
    Private _med_sect_name As String
    Private _med_sect_id As Integer
    Private _diagnos As String
    Private _address As String
    Private _job_place As String
    Private _Complaint As String
    Private _photo_pers1 As Byte()
    Private _photo_pers2 As Byte()
    Private _photo_pers3 As Byte()
    Private _photo_xray1 As Byte()
    Private _photo_xray2 As Byte()
    Private _photo_xray3 As Byte()
    Private _photo_xray4 As Byte()

    Private _stvol As String
    Private _vetv As String
    Private _layer As String

    Private _zhang_fu_xu As String
    Private _xang_ke_qi As String
    Private _data1 As String
    Private _data2 As String
    Private _data3 As String
    Private _data4 As String
    Private _data5 As String
    Private _data6 As String
    Private _data7 As String
    Private _data8 As String
    Private _data9 As String
    Private _data10 As String
    Private _data11 As String
    Private _data12 As String
    Private _data13 As String
    Private _data14 As String
    Private _data15 As String
    Private _data16 As String
    Private _data17 As String
    Private _data18 As String
    Private _data19 As String
    Private _data20 As String

    Private _comment1 As String
    Private _comment2 As String
    Private _comment3 As String
    Private _comment4 As String
    Private _comment5 As String
    Private _comment6 As String
    Private _comment7 As String
    Private _comment8 As String
    Private _comment9 As String
    Private _comment10 As String
    Private _comment11 As String
    Private _comment12 As String
    Private _comment13 As String
    Private _comment14 As String
    Private _comment15 As String
    Private _comment16 As String
    Private _comment17 As String
    Private _comment18 As String
    Private _comment19 As String
    Private _comment20 As String

    Private _txtDot0 As String
    Private _txtDot1 As String
    Private _txtDot2 As String
    Private _txtDot3 As String
    Private _txtDot4 As String
    Private _txtDot5 As String
    Private _txtDot6 As String
    Private _txtDot7 As String
    Private _txtDot8 As String
    Private _txtDot9 As String
    Private _txtDot10 As String
    Private _txtDot11 As String
    Private _txtDot12 As String
    Private _txtDot13 As String
    Private _txtDot14 As String
    Private _txtDot15 As String
    Private _txtDot16 As String
    Private _txtDot17 As String
    Private _txtDot18 As String
    Private _txtDot19 As String
    Private _txtDot20 As String

    Private _ImgCanvas0 As Byte()
    Private _ImgCanvas1 As Byte()
    Private _ImgCanvas2 As Byte()
    Private _ImgCanvas3 As Byte()
    Private _ImgCanvas4 As Byte()
    Private _ImgCanvas5 As Byte()
    Private _ImgCanvas6 As Byte()
    Private _ImgCanvas7 As Byte()
    Private _ImgCanvas8 As Byte()
    Private _ImgCanvas9 As Byte()
    Private _ImgCanvas10 As Byte()
    Private _ImgCanvas11 As Byte()
    Private _ImgCanvas12 As Byte()
    Private _ImgCanvas13 As Byte()
    Private _ImgCanvas14 As Byte()
    Private _ImgCanvas15 As Byte()
    Private _ImgCanvas16 As Byte()
    Private _ImgCanvas17 As Byte()
    Private _ImgCanvas18 As Byte()
    Private _ImgCanvas19 As Byte()
    Private _ImgCanvas20 As Byte()
    Private _strokes As List(Of ClassStrokes)

    ' End Structure
#End Region

    Public Property id As Int32
        Get
            Return _id
        End Get
        Set(ByVal value As Int32)
            _id = value
        End Set
    End Property
    Public Property last_name As String
        Get
            Return _last_name
        End Get
        Set(ByVal value As String)
            _last_name = value

        End Set
    End Property
    Public Property first_name As String
        Get
            Return _first_name
        End Get
        Set(ByVal value As String)
            _first_name = value
        End Set
    End Property
    Public Property second_name As String
        Get
            Return _second_name
        End Get
        Set(ByVal value As String)
            _second_name = value
        End Set
    End Property
    Public Property birth_date As String
        Get
            Return _birth_date
        End Get
        Set(ByVal value As String)
            _birth_date = value
        End Set
    End Property
    Public Property contact_phone As String
        Get
            Return _contact_phone
        End Get
        Set(ByVal value As String)
            _contact_phone = value
        End Set
    End Property
    Public Property mobile_phone As String
        Get
            Return _mobile_phone
        End Get
        Set(ByVal value As String)
            _mobile_phone = value
        End Set
    End Property
    Public Property e_mail As String
        Get
            Return _e_mail
        End Get
        Set(ByVal value As String)
            _e_mail = value
        End Set
    End Property
    Public Property sex As String
        Get
            Return _sex
        End Get
        Set(ByVal value As String)
            _sex = value
        End Set
    End Property
    Public Property med_sect_name As String
        Get
            Return _med_sect_name
        End Get
        Set(ByVal value As String)
            _med_sect_name = value
        End Set
    End Property
    Public Property med_sect_id As Integer
        Get
            Return _med_sect_id
        End Get
        Set(ByVal value As Integer)
            _med_sect_id = value
        End Set
    End Property

    Public Property diagnos As String
        Get
            Return _diagnos
        End Get
        Set(ByVal value As String)
            _diagnos = value
        End Set
    End Property
    Public Property address As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property
    Public Property job_place As String
        Get
            Return _job_place
        End Get
        Set(ByVal value As String)
            _job_place = value
        End Set
    End Property
    Public Property Complaint As String
        Get
            Return _Complaint
        End Get
        Set(ByVal value As String)
            _Complaint = value
        End Set
    End Property
    Public Property photo_pers1 As Byte()
        Get
            Return _photo_pers1
        End Get
        Set(ByVal value As Byte())
            _photo_pers1 = value
        End Set
    End Property
    Public Property photo_pers2 As Byte()
        Get
            Return _photo_pers2
        End Get
        Set(ByVal value As Byte())
            _photo_pers2 = value
        End Set
    End Property
    Public Property photo_pers3 As Byte()
        Get
            Return _photo_pers3
        End Get
        Set(ByVal value As Byte())
            _photo_pers3 = value
        End Set
    End Property
    Public Property photo_xray1 As Byte()
        Get
            Return _photo_xray1
        End Get
        Set(ByVal value As Byte())
            _photo_xray1 = value
        End Set
    End Property
    Public Property photo_xray2 As Byte()
        Get
            Return _photo_xray2
        End Get
        Set(ByVal value As Byte())
            _photo_xray2 = value
        End Set
    End Property
    Public Property photo_xray3 As Byte()
        Get
            Return _photo_xray3
        End Get
        Set(ByVal value As Byte())
            _photo_xray3 = value
        End Set
    End Property
    Public Property photo_xray4 As Byte()
        Get
            Return _photo_xray4
        End Get
        Set(ByVal value As Byte())
            _photo_xray4 = value
        End Set
    End Property

    Public Property stvol As String
        Get
            Return _stvol
        End Get
        Set(ByVal value As String)
            _stvol = value
        End Set
    End Property
    Public Property vetv As String
        Get
            Return _vetv
        End Get
        Set(ByVal value As String)
            _vetv = value
        End Set
    End Property
    Public Property layer As String
        Get
            Return _layer
        End Get
        Set(ByVal value As String)
            _layer = value
        End Set
    End Property

    Public Property zhang_fu_xu As String
        Get
            Return _zhang_fu_xu
        End Get
        Set(ByVal value As String)
            _zhang_fu_xu = value
        End Set
    End Property
    Public Property xang_ke_qi As String
        Get
            Return _xang_ke_qi
        End Get
        Set(ByVal value As String)
            _xang_ke_qi = value
        End Set
    End Property

    Public Property data1 As String
        Get
            Return _data1
        End Get
        Set(ByVal value As String)
            _data1 = value
        End Set
    End Property
    Public Property data2 As String
        Get
            Return _data2
        End Get
        Set(ByVal value As String)
            _data2 = value
        End Set
    End Property
    Public Property data3 As String
        Get
            Return _data3
        End Get
        Set(ByVal value As String)
            _data3 = value
        End Set
    End Property
    Public Property data4 As String
        Get
            Return _data4
        End Get
        Set(ByVal value As String)
            _data4 = value
        End Set
    End Property
    Public Property data5 As String
        Get
            Return _data5
        End Get
        Set(ByVal value As String)
            _data5 = value
        End Set
    End Property
    Public Property data6 As String
        Get
            Return _data6
        End Get
        Set(ByVal value As String)
            _data6 = value
        End Set
    End Property
    Public Property data7 As String
        Get
            Return _data7
        End Get
        Set(ByVal value As String)
            _data7 = value
        End Set
    End Property
    Public Property data8 As String
        Get
            Return _data8
        End Get
        Set(ByVal value As String)
            _data8 = value
        End Set
    End Property
    Public Property data9 As String
        Get
            Return _data9
        End Get
        Set(ByVal value As String)
            _data9 = value
        End Set
    End Property
    Public Property data10 As String
        Get
            Return _data10
        End Get
        Set(ByVal value As String)
            _data10 = value
        End Set
    End Property
    Public Property data11 As String
        Get
            Return _data11
        End Get
        Set(ByVal value As String)
            _data11 = value
        End Set
    End Property
    Public Property data12 As String
        Get
            Return _data12
        End Get
        Set(ByVal value As String)
            _data12 = value
        End Set
    End Property
    Public Property data13 As String
        Get
            Return _data13
        End Get
        Set(ByVal value As String)
            _data13 = value
        End Set
    End Property
    Public Property data14 As String
        Get
            Return _data14
        End Get
        Set(ByVal value As String)
            _data14 = value
        End Set
    End Property
    Public Property data15 As String
        Get
            Return _data15
        End Get
        Set(ByVal value As String)
            _data15 = value
        End Set
    End Property
    Public Property data16 As String
        Get
            Return _data16
        End Get
        Set(ByVal value As String)
            _data16 = value
        End Set
    End Property
    Public Property data17 As String
        Get
            Return _data17
        End Get
        Set(ByVal value As String)
            _data17 = value
        End Set
    End Property
    Public Property data18 As String
        Get
            Return _data18
        End Get
        Set(ByVal value As String)
            _data18 = value
        End Set
    End Property
    Public Property data19 As String
        Get
            Return _data19
        End Get
        Set(ByVal value As String)
            _data19 = value
        End Set
    End Property
    Public Property data20 As String
        Get
            Return _data20
        End Get
        Set(ByVal value As String)
            _data20 = value
        End Set
    End Property

    Public Property comment1 As String
        Get
            Return _comment1
        End Get
        Set(ByVal value As String)
            _comment1 = value
        End Set
    End Property
    Public Property comment2 As String
        Get
            Return _comment2
        End Get
        Set(ByVal value As String)
            _comment2 = value
        End Set
    End Property
    Public Property comment3 As String
        Get
            Return _comment3
        End Get
        Set(ByVal value As String)
            _comment3 = value
        End Set
    End Property
    Public Property comment4 As String
        Get
            Return _comment4
        End Get
        Set(ByVal value As String)
            _comment4 = value
        End Set
    End Property
    Public Property comment5 As String
        Get
            Return _comment5
        End Get
        Set(ByVal value As String)
            _comment5 = value
        End Set
    End Property
    Public Property comment6 As String
        Get
            Return _comment6
        End Get
        Set(ByVal value As String)
            _comment6 = value
        End Set
    End Property
    Public Property comment7 As String
        Get
            Return _comment7
        End Get
        Set(ByVal value As String)
            _comment7 = value
        End Set
    End Property
    Public Property comment8 As String
        Get
            Return _comment8
        End Get
        Set(ByVal value As String)
            _comment8 = value
        End Set
    End Property
    Public Property comment9 As String
        Get
            Return _comment9
        End Get
        Set(ByVal value As String)
            _comment9 = value
        End Set
    End Property
    Public Property comment10 As String
        Get
            Return _comment10
        End Get
        Set(ByVal value As String)
            _comment10 = value
        End Set
    End Property
    Public Property comment11 As String
        Get
            Return _comment11
        End Get
        Set(ByVal value As String)
            _comment11 = value
        End Set
    End Property
    Public Property comment12 As String
        Get
            Return _comment12
        End Get
        Set(ByVal value As String)
            _comment12 = value
        End Set
    End Property
    Public Property comment13 As String
        Get
            Return _comment13
        End Get
        Set(ByVal value As String)
            _comment13 = value
        End Set
    End Property
    Public Property comment14 As String
        Get
            Return _comment14
        End Get
        Set(ByVal value As String)
            _comment14 = value
        End Set
    End Property
    Public Property comment15 As String
        Get
            Return _comment15
        End Get
        Set(ByVal value As String)
            _comment15 = value
        End Set
    End Property
    Public Property comment16 As String
        Get
            Return _comment16
        End Get
        Set(ByVal value As String)
            _comment16 = value
        End Set
    End Property
    Public Property comment17 As String
        Get
            Return _comment17
        End Get
        Set(ByVal value As String)
            _comment17 = value
        End Set
    End Property
    Public Property comment18 As String
        Get
            Return _comment18
        End Get
        Set(ByVal value As String)
            _comment18 = value
        End Set
    End Property
    Public Property comment19 As String
        Get
            Return _comment19
        End Get
        Set(ByVal value As String)
            _comment19 = value
        End Set
    End Property
    Public Property comment20 As String
        Get
            Return _comment20
        End Get
        Set(ByVal value As String)
            _comment20 = value
        End Set
    End Property

    Public Property txtDot0 As String
        Get
            Return _txtDot0
        End Get
        Set(ByVal value As String)
            _txtDot0 = value
        End Set
    End Property
    Public Property txtDot1 As String
        Get
            Return _txtDot1
        End Get
        Set(ByVal value As String)
            _txtDot1 = value
        End Set
    End Property
    Public Property txtDot2 As String
        Get
            Return _txtDot2
        End Get
        Set(ByVal value As String)
            _txtDot2 = value
        End Set
    End Property
    Public Property txtDot3 As String
        Get
            Return _txtDot3
        End Get
        Set(ByVal value As String)
            _txtDot3 = value
        End Set
    End Property
    Public Property txtDot4 As String
        Get
            Return _txtDot4
        End Get
        Set(ByVal value As String)
            _txtDot4 = value
        End Set
    End Property
    Public Property txtDot5 As String
        Get
            Return _txtDot5
        End Get
        Set(ByVal value As String)
            _txtDot5 = value
        End Set
    End Property
    Public Property txtDot6 As String
        Get
            Return _txtDot6
        End Get
        Set(ByVal value As String)
            _txtDot6 = value
        End Set
    End Property
    Public Property txtDot7 As String
        Get
            Return _txtDot7
        End Get
        Set(ByVal value As String)
            _txtDot7 = value
        End Set
    End Property
    Public Property txtDot8 As String
        Get
            Return _txtDot8
        End Get
        Set(ByVal value As String)
            _txtDot8 = value
        End Set
    End Property
    Public Property txtDot9 As String
        Get
            Return _txtDot9
        End Get
        Set(ByVal value As String)
            _txtDot9 = value
        End Set
    End Property
    Public Property txtDot10 As String
        Get
            Return _txtDot10
        End Get
        Set(ByVal value As String)
            _txtDot10 = value
        End Set
    End Property
    Public Property txtDot11 As String
        Get
            Return _txtDot11
        End Get
        Set(ByVal value As String)
            _txtDot11 = value
        End Set
    End Property
    Public Property txtDot12 As String
        Get
            Return _txtDot12
        End Get
        Set(ByVal value As String)
            _txtDot12 = value
        End Set
    End Property
    Public Property txtDot13 As String
        Get
            Return _txtDot13
        End Get
        Set(ByVal value As String)
            _txtDot13 = value
        End Set
    End Property
    Public Property txtDot14 As String
        Get
            Return _txtDot14
        End Get
        Set(ByVal value As String)
            _txtDot14 = value
        End Set
    End Property
    Public Property txtDot15 As String
        Get
            Return _txtDot15
        End Get
        Set(ByVal value As String)
            _txtDot15 = value
        End Set
    End Property
    Public Property txtDot16 As String
        Get
            Return _txtDot16
        End Get
        Set(ByVal value As String)
            _txtDot16 = value
        End Set
    End Property
    Public Property txtDot17 As String
        Get
            Return _txtDot17
        End Get
        Set(ByVal value As String)
            _txtDot17 = value
        End Set
    End Property
    Public Property txtDot18 As String
        Get
            Return _txtDot18
        End Get
        Set(ByVal value As String)
            _txtDot18 = value
        End Set
    End Property
    Public Property txtDot19 As String
        Get
            Return _txtDot19
        End Get
        Set(ByVal value As String)
            _txtDot19 = value
        End Set
    End Property
    Public Property txtDot20 As String
        Get
            Return _txtDot20
        End Get
        Set(ByVal value As String)
            _txtDot20 = value
        End Set
    End Property

    Public Property ImgCanvas0 As Byte()
        Get
            Return _ImgCanvas0
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas0 = value
        End Set
    End Property
    Public Property ImgCanvas1 As Byte()
        Get
            Return _ImgCanvas1
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas1 = value
        End Set
    End Property
    Public Property ImgCanvas2 As Byte()
        Get
            Return _ImgCanvas2
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas2 = value
        End Set
    End Property
    Public Property ImgCanvas3 As Byte()
        Get
            Return _ImgCanvas3
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas3 = value
        End Set
    End Property
    Public Property ImgCanvas4 As Byte()
        Get
            Return _ImgCanvas4
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas4 = value
        End Set
    End Property
    Public Property ImgCanvas5 As Byte()
        Get
            Return _ImgCanvas5
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas5 = value
        End Set
    End Property
    Public Property ImgCanvas6 As Byte()
        Get
            Return _ImgCanvas6
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas6 = value
        End Set
    End Property
    Public Property ImgCanvas7 As Byte()
        Get
            Return _ImgCanvas7
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas7 = value
        End Set
    End Property
    Public Property ImgCanvas8 As Byte()
        Get
            Return _ImgCanvas8
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas8 = value
        End Set
    End Property
    Public Property ImgCanvas9 As Byte()
        Get
            Return _ImgCanvas9
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas9 = value
        End Set
    End Property
    Public Property ImgCanvas10 As Byte()
        Get
            Return _ImgCanvas10
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas10 = value
        End Set
    End Property
    Public Property ImgCanvas11 As Byte()
        Get
            Return _ImgCanvas11
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas11 = value
        End Set
    End Property
    Public Property ImgCanvas12 As Byte()
        Get
            Return _ImgCanvas12
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas12 = value
        End Set
    End Property
    Public Property ImgCanvas13 As Byte()
        Get
            Return _ImgCanvas13
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas13 = value
        End Set
    End Property
    Public Property ImgCanvas14 As Byte()
        Get
            Return _ImgCanvas14
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas14 = value
        End Set
    End Property
    Public Property ImgCanvas15 As Byte()
        Get
            Return _ImgCanvas15
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas15 = value
        End Set
    End Property
    Public Property ImgCanvas16 As Byte()
        Get
            Return _ImgCanvas16
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas16 = value
        End Set
    End Property
    Public Property ImgCanvas17 As Byte()
        Get
            Return _ImgCanvas17
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas17 = value
        End Set
    End Property
    Public Property ImgCanvas18 As Byte()
        Get
            Return _ImgCanvas18
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas18 = value
        End Set
    End Property
    Public Property ImgCanvas19 As Byte()
        Get
            Return _ImgCanvas19
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas19 = value
        End Set
    End Property
    Public Property ImgCanvas20 As Byte()
        Get
            Return _ImgCanvas20
        End Get
        Set(ByVal value As Byte())
            _ImgCanvas20 = value
        End Set
    End Property


    Public Property strokes As List(Of ClassStrokes)
        Get
            Return _strokes
        End Get
        Set(value As List(Of ClassStrokes))
            _strokes = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByRef p_id As Int32, ByVal p_last_name As String, ByVal p_first_name As String, ByVal p_second_name As String, ByVal p_birth_date As String, ByVal p_contact_phone As String, ByVal p_mobile_phone As String, ByVal p_e_mail As String, ByVal p_sex As String, ByVal p_med_sect_name As String, ByVal p_med_sect_id As Integer, ByVal p_diagnos As String, ByVal p_address As String, ByVal p_job_place As String, ByVal p_Complaint As String, ByVal p_photo_pers1 As Byte(), ByVal p_photo_pers2 As Byte(), ByVal p_photo_pers3 As Byte(), ByVal p_photo_xray1 As Byte(), ByVal p_photo_xray2 As Byte(), ByVal p_photo_xray3 As Byte(), ByVal p_photo_xray4 As Byte(), ByVal p_zhang_fu_xu As String, ByVal p_xang_ke_qi As String, ByVal p_data1 As String, ByVal p_data2 As String, ByVal p_data3 As String, ByVal p_data4 As String, ByVal p_data5 As String, ByVal p_data6 As String, ByVal p_data7 As String, ByVal p_data8 As String, ByVal p_data9 As String, ByVal p_data10 As String, ByVal p_data11 As String, ByVal p_data12 As String, ByVal p_data13 As String, ByVal p_data14 As String, ByVal p_data15 As String, ByVal p_data16 As String, ByVal p_data17 As String, ByVal p_data18 As String, ByVal p_data19 As String, ByVal p_data20 As String, ByVal p_comment1 As String, ByVal p_comment2 As String, ByVal p_comment3 As String, ByVal p_comment4 As String, ByVal p_comment5 As String, ByVal p_comment6 As String, ByVal p_comment7 As String, ByVal p_comment8 As String, ByVal p_comment9 As String, ByVal p_comment10 As String, ByVal p_comment11 As String, ByVal p_comment12 As String, ByVal p_comment13 As String, ByVal p_comment14 As String, ByVal p_comment15 As String, ByVal p_comment16 As String, ByVal p_comment17 As String, ByVal p_comment18 As String, ByVal p_comment19 As String, ByVal p_comment20 As String, ByVal p_txtDot0 As String, ByVal p_txtDot1 As String, ByVal p_txtDot2 As String, ByVal p_txtDot3 As String, ByVal p_txtDot4 As String, ByVal p_txtDot5 As String, ByVal p_txtDot6 As String, ByVal p_txtDot7 As String, ByVal p_txtDot8 As String, ByVal p_txtDot9 As String, ByVal p_txtDot10 As String, ByVal p_txtDot11 As String, ByVal p_txtDot12 As String, ByVal p_txtDot13 As String, ByVal p_txtDot14 As String, ByVal p_txtDot15 As String, ByVal p_txtDot16 As String, ByVal p_txtDot17 As String, ByVal p_txtDot18 As String, ByVal p_txtDot19 As String, ByVal p_txtDot20 As String, p_stvol As String, p_vetv As String, p_layer As String)

        _id = p_id
        _last_name = p_last_name
        _first_name = p_first_name
        _second_name = p_second_name
        _birth_date = p_birth_date
        _contact_phone = p_contact_phone
        _mobile_phone = p_mobile_phone
        _e_mail = p_e_mail
        _sex = p_sex
        _med_sect_name = p_med_sect_name
        _med_sect_id = p_med_sect_id
        _diagnos = p_diagnos
        _address = p_address
        _job_place = p_job_place
        _Complaint = p_Complaint
        _photo_pers1 = p_photo_pers1
        _photo_pers2 = p_photo_pers2
        _photo_pers3 = p_photo_pers3
        _photo_xray1 = p_photo_xray1
        _photo_xray2 = p_photo_xray2
        _photo_xray3 = p_photo_xray3
        _photo_xray4 = p_photo_xray4

        _zhang_fu_xu = p_zhang_fu_xu
        _xang_ke_qi = p_xang_ke_qi

        _data1 = p_data1
        _data2 = p_data2
        _data3 = p_data3
        _data4 = p_data4
        _data5 = p_data5
        _data6 = p_data6
        _data7 = p_data7
        _data8 = p_data8
        _data9 = p_data9
        _data10 = p_data10
        _data11 = p_data11
        _data12 = p_data12
        _data13 = p_data13
        _data14 = p_data14
        _data15 = p_data15
        _data16 = p_data16
        _data17 = p_data17
        _data18 = p_data18
        _data19 = p_data19
        _data20 = p_data20

        _comment1 = p_comment1
        _comment2 = p_comment2
        _comment3 = p_comment3
        _comment4 = p_comment4
        _comment5 = p_comment5
        _comment6 = p_comment6
        _comment7 = p_comment7
        _comment8 = p_comment8
        _comment9 = p_comment9
        _comment10 = p_comment10
        _comment11 = p_comment11
        _comment12 = p_comment12
        _comment13 = p_comment13
        _comment14 = p_comment14
        _comment15 = p_comment15
        _comment16 = p_comment16
        _comment17 = p_comment17
        _comment18 = p_comment18
        _comment19 = p_comment19
        _comment20 = p_comment20

        _txtDot0 = p_txtDot0
        _txtDot1 = p_txtDot1
        _txtDot2 = p_txtDot2
        _txtDot3 = p_txtDot3
        _txtDot4 = p_txtDot4
        _txtDot5 = p_txtDot5
        _txtDot6 = p_txtDot6
        _txtDot7 = p_txtDot7
        _txtDot8 = p_txtDot8
        _txtDot9 = p_txtDot9
        _txtDot10 = p_txtDot10
        _txtDot11 = p_txtDot11
        _txtDot12 = p_txtDot12
        _txtDot13 = p_txtDot13
        _txtDot14 = p_txtDot14
        _txtDot15 = p_txtDot15
        _txtDot16 = p_txtDot16
        _txtDot17 = p_txtDot17
        _txtDot18 = p_txtDot18
        _txtDot19 = p_txtDot19
        _txtDot20 = p_txtDot20
        _stvol = p_stvol
        _vetv = p_vetv
        _layer = p_layer

    End Sub



    ''' <summary>
    ''' Сохранение анкеты
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SaveProfile()
        'Dim conn = New OleDbConnection("Provider=Microsoft." &
        '                   "Jet.OLEDB.4.0;Data Source=" & AppDomain.CurrentDomain.BaseDirectory & "\DB\PatientRecordsDB.mdb")

        Dim cmd = New MySqlCommand("save_patient", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = Me.last_name
        cmd.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = Me.first_name
        cmd.Parameters.Add("@second_name", MySqlDbType.VarChar).Value = Me.second_name
        cmd.Parameters.Add("@birth_date", MySqlDbType.Date).Value = convertDBnull(Me.birth_date)
        cmd.Parameters.Add("@contact_phone", MySqlDbType.VarChar).Value = IIf(Me.contact_phone Is Nothing, "", Me.contact_phone)
        cmd.Parameters.Add("@mobile_phone", MySqlDbType.VarChar).Value = IIf(Me.mobile_phone Is Nothing, "", Me.mobile_phone)
        cmd.Parameters.Add("@e_mail", MySqlDbType.VarChar).Value = Me.e_mail
        cmd.Parameters.Add("@sex", MySqlDbType.VarChar).Value = IIf(Me.sex Is Nothing, "", Me.sex)
        cmd.Parameters.Add("@med_section_id", MySqlDbType.Int32).Value = IIf(Me.med_sect_id = 0, Nothing, Me.med_sect_id)
        cmd.Parameters.Add("@diagnos", MySqlDbType.VarChar).Value = Me.diagnos
        cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = Me.address
        cmd.Parameters.Add("@job_place", MySqlDbType.VarChar).Value = Me.job_place
        cmd.Parameters.Add("@photo_pers1", MySqlDbType.MediumBlob).Value = IIf(Me.photo_pers1 Is Nothing, Nothing, Me.photo_pers1)
        cmd.Parameters.Add("@photo_pers2", MySqlDbType.MediumBlob).Value = IIf(Me.photo_pers2 Is Nothing, Nothing, Me.photo_pers2)
        cmd.Parameters.Add("@photo_pers3", MySqlDbType.MediumBlob).Value = IIf(Me.photo_pers3 Is Nothing, Nothing, Me.photo_pers3)
        cmd.Parameters.Add("@photo_xray1", MySqlDbType.MediumBlob).Value = IIf(Me.photo_xray1 Is Nothing, Nothing, Me.photo_xray1)
        cmd.Parameters.Add("@photo_xray2", MySqlDbType.MediumBlob).Value = IIf(Me.photo_xray2 Is Nothing, Nothing, Me.photo_xray2)
        cmd.Parameters.Add("@photo_xray3", MySqlDbType.MediumBlob).Value = IIf(Me.photo_xray3 Is Nothing, Nothing, Me.photo_xray3)
        cmd.Parameters.Add("@photo_xray4", MySqlDbType.MediumBlob).Value = IIf(Me.photo_xray4 Is Nothing, Nothing, Me.photo_xray4)

        cmd.Parameters.Add("@p_txtDots0", MySqlDbType.Text).Value = IIf(Me.txtDot0 IsNot Nothing, Me.txtDot0, Nothing)
        cmd.Parameters.Add("@p_txtDots1", MySqlDbType.Text).Value = IIf(txtDot1 IsNot Nothing, txtDot1, Nothing)
        cmd.Parameters.Add("@p_txtDots2", MySqlDbType.Text).Value = IIf(txtDot2 IsNot Nothing, txtDot2, Nothing)
        cmd.Parameters.Add("@p_txtDots3", MySqlDbType.Text).Value = IIf(txtDot3 IsNot Nothing, txtDot3, Nothing)
        cmd.Parameters.Add("@p_txtDots4", MySqlDbType.Text).Value = IIf(txtDot4 IsNot Nothing, txtDot4, Nothing)
        cmd.Parameters.Add("@p_txtDots5", MySqlDbType.Text).Value = IIf(txtDot5 IsNot Nothing, txtDot5, Nothing)
        cmd.Parameters.Add("@p_txtDots6", MySqlDbType.Text).Value = IIf(txtDot6 IsNot Nothing, txtDot6, Nothing)
        cmd.Parameters.Add("@p_txtDots7", MySqlDbType.Text).Value = IIf(txtDot7 IsNot Nothing, txtDot7, Nothing)
        cmd.Parameters.Add("@p_txtDots8", MySqlDbType.Text).Value = IIf(txtDot8 IsNot Nothing, txtDot8, Nothing)
        cmd.Parameters.Add("@p_txtDots9", MySqlDbType.Text).Value = IIf(txtDot9 IsNot Nothing, txtDot9, Nothing)
        cmd.Parameters.Add("@p_txtDots10", MySqlDbType.Text).Value = IIf(txtDot10 IsNot Nothing, txtDot10, Nothing)
        cmd.Parameters.Add("@p_txtDots11", MySqlDbType.Text).Value = IIf(txtDot11 IsNot Nothing, txtDot11, Nothing)
        cmd.Parameters.Add("@p_txtDots12", MySqlDbType.Text).Value = IIf(txtDot12 IsNot Nothing, txtDot12, Nothing)
        cmd.Parameters.Add("@p_txtDots13", MySqlDbType.Text).Value = IIf(txtDot13 IsNot Nothing, txtDot13, Nothing)
        cmd.Parameters.Add("@p_txtDots14", MySqlDbType.Text).Value = IIf(txtDot14 IsNot Nothing, txtDot14, Nothing)
        cmd.Parameters.Add("@p_txtDots15", MySqlDbType.Text).Value = IIf(txtDot15 IsNot Nothing, txtDot15, Nothing)
        cmd.Parameters.Add("@p_txtDots16", MySqlDbType.Text).Value = IIf(txtDot16 IsNot Nothing, txtDot16, Nothing)
        cmd.Parameters.Add("@p_txtDots17", MySqlDbType.Text).Value = IIf(txtDot17 IsNot Nothing, txtDot17, Nothing)
        cmd.Parameters.Add("@p_txtDots18", MySqlDbType.Text).Value = IIf(txtDot18 IsNot Nothing, txtDot18, Nothing)
        cmd.Parameters.Add("@p_txtDots19", MySqlDbType.Text).Value = IIf(txtDot19 IsNot Nothing, txtDot19, Nothing)
        cmd.Parameters.Add("@p_txtDots20", MySqlDbType.Text).Value = IIf(txtDot20 IsNot Nothing, txtDot20, Nothing)

        'cmd.Parameters.Add("@ImgCanvas0", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas0 IsNot Nothing, Me.ImgCanvas0, Nothing)
        'cmd.Parameters.Add("@ImgCanvas1", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas1 IsNot Nothing, Me.ImgCanvas1, Nothing)
        'cmd.Parameters.Add("@ImgCanvas2", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas2 IsNot Nothing, Me.ImgCanvas2, Nothing)
        'cmd.Parameters.Add("@ImgCanvas3", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas3 IsNot Nothing, Me.ImgCanvas3, Nothing)
        'cmd.Parameters.Add("@ImgCanvas4", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas4 IsNot Nothing, Me.ImgCanvas4, Nothing)
        'cmd.Parameters.Add("@ImgCanvas5", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas5 IsNot Nothing, Me.ImgCanvas5, Nothing)
        'cmd.Parameters.Add("@ImgCanvas6", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas6 IsNot Nothing, Me.ImgCanvas6, Nothing)
        'cmd.Parameters.Add("@ImgCanvas7", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas7 IsNot Nothing, Me.ImgCanvas7, Nothing)
        'cmd.Parameters.Add("@ImgCanvas8", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas8 IsNot Nothing, Me.ImgCanvas8, Nothing)
        'cmd.Parameters.Add("@ImgCanvas9", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas9 IsNot Nothing, Me.ImgCanvas9, Nothing)
        'cmd.Parameters.Add("@ImgCanvas10", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas10 IsNot Nothing, Me.ImgCanvas10, Nothing)
        'cmd.Parameters.Add("@ImgCanvas11", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas11 IsNot Nothing, Me.ImgCanvas11, Nothing)
        'cmd.Parameters.Add("@ImgCanvas12", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas12 IsNot Nothing, Me.ImgCanvas12, Nothing)
        'cmd.Parameters.Add("@ImgCanvas13", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas13 IsNot Nothing, Me.ImgCanvas13, Nothing)
        'cmd.Parameters.Add("@ImgCanvas14", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas14 IsNot Nothing, Me.ImgCanvas14, Nothing)
        'cmd.Parameters.Add("@ImgCanvas15", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas15 IsNot Nothing, Me.ImgCanvas15, Nothing)
        'cmd.Parameters.Add("@ImgCanvas16", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas16 IsNot Nothing, Me.ImgCanvas16, Nothing)
        'cmd.Parameters.Add("@ImgCanvas17", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas17 IsNot Nothing, Me.ImgCanvas17, Nothing)
        'cmd.Parameters.Add("@ImgCanvas18", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas18 IsNot Nothing, Me.ImgCanvas18, Nothing)
        'cmd.Parameters.Add("@ImgCanvas19", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas19 IsNot Nothing, Me.ImgCanvas19, Nothing)
        'cmd.Parameters.Add("@ImgCanvas20", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas20 IsNot Nothing, Me.ImgCanvas20, Nothing)

        cmd.Parameters.Add("@p_stvol", MySqlDbType.VarChar).Value = IIf(Me.stvol Is Nothing, "", Me.stvol)
        cmd.Parameters.Add("@p_vetv", MySqlDbType.VarChar).Value = IIf(Me.vetv Is Nothing, "", Me.vetv)
        cmd.Parameters.Add("@p_layer", MySqlDbType.VarChar).Value = IIf(Me.layer Is Nothing, "", Me.layer)

        cmd.Parameters.Add("@zhang_fu_xu", MySqlDbType.VarChar).Value = IIf(Me.zhang_fu_xu Is Nothing, "", Me.zhang_fu_xu)
        cmd.Parameters.Add("@xang_ke_qi", MySqlDbType.VarChar).Value = IIf(Me.xang_ke_qi Is Nothing, "", Me.xang_ke_qi)
        cmd.Parameters.Add("@complaint", MySqlDbType.VarChar).Value = Me.Complaint

        With Me
            cmd.Parameters.Add("@data1", MySqlDbType.Text).Value = IIf(.data1 Is Nothing, Nothing, .data1)
            cmd.Parameters.Add("@data2", MySqlDbType.Text).Value = IIf(.data2 Is Nothing, Nothing, .data2)
            cmd.Parameters.Add("@data3", MySqlDbType.Text).Value = IIf(.data3 Is Nothing, Nothing, .data3)
            cmd.Parameters.Add("@data4", MySqlDbType.Text).Value = IIf(.data4 Is Nothing, Nothing, .data4)
            cmd.Parameters.Add("@data5", MySqlDbType.Text).Value = IIf(.data5 Is Nothing, Nothing, .data5)
            cmd.Parameters.Add("@data6", MySqlDbType.Text).Value = IIf(.data6 Is Nothing, Nothing, .data6)
            cmd.Parameters.Add("@data7", MySqlDbType.Text).Value = IIf(.data7 Is Nothing, Nothing, .data7)
            cmd.Parameters.Add("@data8", MySqlDbType.Text).Value = IIf(.data8 Is Nothing, Nothing, .data8)
            cmd.Parameters.Add("@data9", MySqlDbType.Text).Value = IIf(.data9 Is Nothing, Nothing, .data9)
            cmd.Parameters.Add("@data10", MySqlDbType.Text).Value = IIf(.data10 Is Nothing, Nothing, .data10)
            cmd.Parameters.Add("@data11", MySqlDbType.Text).Value = IIf(.data11 Is Nothing, Nothing, .data11)
            cmd.Parameters.Add("@data12", MySqlDbType.Text).Value = IIf(.data12 Is Nothing, Nothing, .data12)
            cmd.Parameters.Add("@data13", MySqlDbType.Text).Value = IIf(.data13 Is Nothing, Nothing, .data13)
            cmd.Parameters.Add("@data14", MySqlDbType.Text).Value = IIf(.data14 Is Nothing, Nothing, .data14)
            cmd.Parameters.Add("@data15", MySqlDbType.Text).Value = IIf(.data15 Is Nothing, Nothing, .data15)
            cmd.Parameters.Add("@data16", MySqlDbType.Text).Value = IIf(.data16 Is Nothing, Nothing, .data16)
            cmd.Parameters.Add("@data17", MySqlDbType.Text).Value = IIf(.data17 Is Nothing, Nothing, .data17)
            cmd.Parameters.Add("@data18", MySqlDbType.Text).Value = IIf(.data18 Is Nothing, Nothing, .data18)
            cmd.Parameters.Add("@data19", MySqlDbType.Text).Value = IIf(.data19 Is Nothing, Nothing, .data19)
            cmd.Parameters.Add("@data20", MySqlDbType.Text).Value = IIf(.data20 Is Nothing, Nothing, .data20)
            cmd.Parameters.Add("@comment1", MySqlDbType.Text).Value = IIf(.comment1 Is Nothing, Nothing, .comment1)
            cmd.Parameters.Add("@comment2", MySqlDbType.Text).Value = IIf(.comment2 Is Nothing, Nothing, .comment2)
            cmd.Parameters.Add("@comment3", MySqlDbType.Text).Value = IIf(.comment3 Is Nothing, Nothing, .comment3)
            cmd.Parameters.Add("@comment4", MySqlDbType.Text).Value = IIf(.comment4 Is Nothing, Nothing, .comment4)
            cmd.Parameters.Add("@comment5", MySqlDbType.Text).Value = IIf(.comment5 Is Nothing, Nothing, .comment5)
            cmd.Parameters.Add("@comment6", MySqlDbType.Text).Value = IIf(.comment6 Is Nothing, Nothing, .comment6)
            cmd.Parameters.Add("@comment7", MySqlDbType.Text).Value = IIf(.comment7 Is Nothing, Nothing, .comment7)
            cmd.Parameters.Add("@comment8", MySqlDbType.Text).Value = IIf(.comment8 Is Nothing, Nothing, .comment8)
            cmd.Parameters.Add("@comment9", MySqlDbType.Text).Value = IIf(.comment9 Is Nothing, Nothing, .comment9)
            cmd.Parameters.Add("@comment10", MySqlDbType.Text).Value = IIf(.comment10 Is Nothing, Nothing, .comment10)
            cmd.Parameters.Add("@comment11", MySqlDbType.Text).Value = IIf(.comment11 Is Nothing, Nothing, .comment11)
            cmd.Parameters.Add("@comment12", MySqlDbType.Text).Value = IIf(.comment12 Is Nothing, Nothing, .comment12)
            cmd.Parameters.Add("@comment13", MySqlDbType.Text).Value = IIf(.comment13 Is Nothing, Nothing, .comment13)
            cmd.Parameters.Add("@comment14", MySqlDbType.Text).Value = IIf(.comment14 Is Nothing, Nothing, .comment14)
            cmd.Parameters.Add("@comment15", MySqlDbType.Text).Value = IIf(.comment15 Is Nothing, Nothing, .comment15)
            cmd.Parameters.Add("@comment16", MySqlDbType.Text).Value = IIf(.comment16 Is Nothing, Nothing, .comment16)
            cmd.Parameters.Add("@comment17", MySqlDbType.Text).Value = IIf(.comment17 Is Nothing, Nothing, .comment17)
            cmd.Parameters.Add("@comment18", MySqlDbType.Text).Value = IIf(.comment18 Is Nothing, Nothing, .comment18)
            cmd.Parameters.Add("@comment19", MySqlDbType.Text).Value = IIf(.comment19 Is Nothing, Nothing, .comment19)
            cmd.Parameters.Add("@comment20", MySqlDbType.Text).Value = IIf(.comment20 Is Nothing, Nothing, .comment20)
        End With



        Try
            conn.Open()
            cmd.ExecuteNonQuery()

        Finally
            conn.Close()
        End Try

    End Sub
    Public Function ToMySql(ByVal d As Date) As String
        Return d.ToString("yyyy-MM-dd")
    End Function
    Public Function convertDBnull(ByVal val As String) As Object
        If val = Nothing Then
            Return DBNull.Value
        Else
            Return ToMySql(val)
        End If
    End Function
    ''' <summary>
    ''' Изменение анкеты
    ''' </summary>
    ''' <param name="Me"></param>
    ''' <remarks></remarks>
    Public Sub EditProfile()
        'Dim conn = New OleDbConnection("Provider=Microsoft." &
        '                   "Jet.OLEDB.4.0;Data Source=" & AppDomain.CurrentDomain.BaseDirectory & "\DB\PatientRecordsDB.mdb")

        Dim cmd = New MySqlCommand("edit_patient", conn)
        cmd.CommandType = CommandType.StoredProcedure

        conn.Open()
        Try
            cmd.Parameters.Add("@p_id", MySqlDbType.Int32).Value = Me.id
            cmd.Parameters.Add("@p_last_name", MySqlDbType.VarChar).Value = Me.last_name
            cmd.Parameters.Add("@p_first_name", MySqlDbType.VarChar).Value = Me.first_name
            cmd.Parameters.Add("@p_second_name", MySqlDbType.VarChar).Value = Me.second_name
            cmd.Parameters.Add("@p_birth_date", MySqlDbType.Date).Value = convertDBnull(Me.birth_date)
            cmd.Parameters.Add("@p_contact_phone", MySqlDbType.VarChar).Value = IIf(Me.contact_phone Is Nothing, "", Me.contact_phone)
            cmd.Parameters.Add("@p_mobile_phone", MySqlDbType.VarChar).Value = IIf(Me.mobile_phone Is Nothing, "", Me.mobile_phone)
            cmd.Parameters.Add("@p_e_mail", MySqlDbType.VarChar).Value = Me.e_mail
            cmd.Parameters.Add("@p_sex", MySqlDbType.VarChar).Value = IIf(Me.sex Is Nothing, "", Me.sex)
            cmd.Parameters.Add("@p_med_section_id", MySqlDbType.Int32).Value = IIf(Me.med_sect_id = 0, Nothing, Me.med_sect_id)
            cmd.Parameters.Add("@p_diagnos", MySqlDbType.VarChar).Value = Me.diagnos
            cmd.Parameters.Add("@p_address", MySqlDbType.VarChar).Value = Me.address
            cmd.Parameters.Add("@p_job_place", MySqlDbType.VarChar).Value = Me.job_place
            cmd.Parameters.Add("@p_photo_pers1", MySqlDbType.MediumBlob).Value = IIf(Me.photo_pers1 Is Nothing, Nothing, Me.photo_pers1)
            cmd.Parameters.Add("@p_photo_pers2", MySqlDbType.MediumBlob).Value = IIf(Me.photo_pers2 Is Nothing, Nothing, Me.photo_pers2)
            cmd.Parameters.Add("@p_photo_pers3", MySqlDbType.MediumBlob).Value = IIf(Me.photo_pers3 Is Nothing, Nothing, Me.photo_pers3)
            cmd.Parameters.Add("@p_photo_xray1", MySqlDbType.MediumBlob).Value = IIf(Me.photo_xray1 Is Nothing, Nothing, Me.photo_xray1)
            cmd.Parameters.Add("@p_photo_xray2", MySqlDbType.MediumBlob).Value = IIf(Me.photo_xray2 Is Nothing, Nothing, Me.photo_xray2)
            cmd.Parameters.Add("@p_photo_xray3", MySqlDbType.MediumBlob).Value = IIf(Me.photo_xray3 Is Nothing, Nothing, Me.photo_xray3)
            cmd.Parameters.Add("@p_photo_xray4", MySqlDbType.MediumBlob).Value = IIf(Me.photo_xray4 Is Nothing, Nothing, Me.photo_xray4)

            cmd.Parameters.Add("@p_txtDots0", MySqlDbType.Text).Value = IIf(Me.txtDot0 IsNot Nothing, Me.txtDot0, Nothing)
            cmd.Parameters.Add("@p_txtDots1", MySqlDbType.Text).Value = IIf(txtDot1 IsNot Nothing, txtDot1, Nothing)
            cmd.Parameters.Add("@p_txtDots2", MySqlDbType.Text).Value = IIf(txtDot2 IsNot Nothing, txtDot2, Nothing)
            cmd.Parameters.Add("@p_txtDots3", MySqlDbType.Text).Value = IIf(txtDot3 IsNot Nothing, txtDot3, Nothing)
            cmd.Parameters.Add("@p_txtDots4", MySqlDbType.Text).Value = IIf(txtDot4 IsNot Nothing, txtDot4, Nothing)
            cmd.Parameters.Add("@p_txtDots5", MySqlDbType.Text).Value = IIf(txtDot5 IsNot Nothing, txtDot5, Nothing)
            cmd.Parameters.Add("@p_txtDots6", MySqlDbType.Text).Value = IIf(txtDot6 IsNot Nothing, txtDot6, Nothing)
            cmd.Parameters.Add("@p_txtDots7", MySqlDbType.Text).Value = IIf(txtDot7 IsNot Nothing, txtDot7, Nothing)
            cmd.Parameters.Add("@p_txtDots8", MySqlDbType.Text).Value = IIf(txtDot8 IsNot Nothing, txtDot8, Nothing)
            cmd.Parameters.Add("@p_txtDots9", MySqlDbType.Text).Value = IIf(txtDot9 IsNot Nothing, txtDot9, Nothing)
            cmd.Parameters.Add("@p_txtDots10", MySqlDbType.Text).Value = IIf(txtDot10 IsNot Nothing, txtDot10, Nothing)
            cmd.Parameters.Add("@p_txtDots11", MySqlDbType.Text).Value = IIf(txtDot11 IsNot Nothing, txtDot11, Nothing)
            cmd.Parameters.Add("@p_txtDots12", MySqlDbType.Text).Value = IIf(txtDot12 IsNot Nothing, txtDot12, Nothing)
            cmd.Parameters.Add("@p_txtDots13", MySqlDbType.Text).Value = IIf(txtDot13 IsNot Nothing, txtDot13, Nothing)
            cmd.Parameters.Add("@p_txtDots14", MySqlDbType.Text).Value = IIf(txtDot14 IsNot Nothing, txtDot14, Nothing)
            cmd.Parameters.Add("@p_txtDots15", MySqlDbType.Text).Value = IIf(txtDot15 IsNot Nothing, txtDot15, Nothing)
            cmd.Parameters.Add("@p_txtDots16", MySqlDbType.Text).Value = IIf(txtDot16 IsNot Nothing, txtDot16, Nothing)
            cmd.Parameters.Add("@p_txtDots17", MySqlDbType.Text).Value = IIf(txtDot17 IsNot Nothing, txtDot17, Nothing)
            cmd.Parameters.Add("@p_txtDots18", MySqlDbType.Text).Value = IIf(txtDot18 IsNot Nothing, txtDot18, Nothing)
            cmd.Parameters.Add("@p_txtDots19", MySqlDbType.Text).Value = IIf(txtDot19 IsNot Nothing, txtDot19, Nothing)
            cmd.Parameters.Add("@p_txtDots20", MySqlDbType.Text).Value = IIf(txtDot20 IsNot Nothing, txtDot20, Nothing)

            'cmd.Parameters.Add("@p_ImgCanvas0", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas0 IsNot Nothing, Me.ImgCanvas0, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas1", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas1 IsNot Nothing, Me.ImgCanvas1, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas2", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas2 IsNot Nothing, Me.ImgCanvas2, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas3", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas3 IsNot Nothing, Me.ImgCanvas3, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas4", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas4 IsNot Nothing, Me.ImgCanvas4, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas5", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas5 IsNot Nothing, Me.ImgCanvas5, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas6", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas6 IsNot Nothing, Me.ImgCanvas6, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas7", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas7 IsNot Nothing, Me.ImgCanvas7, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas8", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas8 IsNot Nothing, Me.ImgCanvas8, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas9", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas9 IsNot Nothing, Me.ImgCanvas9, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas10", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas10 IsNot Nothing, Me.ImgCanvas10, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas11", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas11 IsNot Nothing, Me.ImgCanvas11, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas12", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas12 IsNot Nothing, Me.ImgCanvas12, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas13", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas13 IsNot Nothing, Me.ImgCanvas13, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas14", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas14 IsNot Nothing, Me.ImgCanvas14, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas15", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas15 IsNot Nothing, Me.ImgCanvas15, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas16", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas16 IsNot Nothing, Me.ImgCanvas16, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas17", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas17 IsNot Nothing, Me.ImgCanvas17, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas18", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas18 IsNot Nothing, Me.ImgCanvas18, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas19", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas19 IsNot Nothing, Me.ImgCanvas19, Nothing)
            'cmd.Parameters.Add("@p_ImgCanvas20", MySqlDbType.MediumBlob).Value = IIf(Me.ImgCanvas20 IsNot Nothing, Me.ImgCanvas20, Nothing)

            cmd.Parameters.Add("@p_stvol", MySqlDbType.Text).Value = IIf(Me.stvol Is Nothing, "", Me.stvol)
            cmd.Parameters.Add("@p_vetv", MySqlDbType.Text).Value = IIf(Me.vetv Is Nothing, "", Me.vetv)
            cmd.Parameters.Add("@p_layer", MySqlDbType.Text).Value = IIf(Me.layer Is Nothing, "", Me.layer)

            cmd.Parameters.Add("@p_zhang_fu_xu", MySqlDbType.VarChar).Value = IIf(Me.zhang_fu_xu Is Nothing, Nothing, Me.zhang_fu_xu)
            cmd.Parameters.Add("@p_xang_ke_qi", MySqlDbType.VarChar).Value = IIf(Me.xang_ke_qi Is Nothing, Nothing, Me.xang_ke_qi)
            cmd.Parameters.Add("@p_complaint", MySqlDbType.VarChar).Value = Me.Complaint

            With Me
                cmd.Parameters.Add("@p_data1", MySqlDbType.Text).Value = IIf(.data1 Is Nothing, Nothing, .data1)
                cmd.Parameters.Add("@p_data2", MySqlDbType.Text).Value = IIf(.data2 Is Nothing, Nothing, .data2)
                cmd.Parameters.Add("@p_data3", MySqlDbType.Text).Value = IIf(.data3 Is Nothing, Nothing, .data3)
                cmd.Parameters.Add("@p_data4", MySqlDbType.Text).Value = IIf(.data4 Is Nothing, Nothing, .data4)
                cmd.Parameters.Add("@p_data5", MySqlDbType.Text).Value = IIf(.data5 Is Nothing, Nothing, .data5)
                cmd.Parameters.Add("@p_data6", MySqlDbType.Text).Value = IIf(.data6 Is Nothing, Nothing, .data6)
                cmd.Parameters.Add("@p_data7", MySqlDbType.Text).Value = IIf(.data7 Is Nothing, Nothing, .data7)
                cmd.Parameters.Add("@p_data8", MySqlDbType.Text).Value = IIf(.data8 Is Nothing, Nothing, .data8)
                cmd.Parameters.Add("@p_data9", MySqlDbType.Text).Value = IIf(.data9 Is Nothing, Nothing, .data9)
                cmd.Parameters.Add("@p_data10", MySqlDbType.Text).Value = IIf(.data10 Is Nothing, Nothing, .data10)
                cmd.Parameters.Add("@p_data11", MySqlDbType.Text).Value = IIf(.data11 Is Nothing, Nothing, .data11)
                cmd.Parameters.Add("@p_data12", MySqlDbType.Text).Value = IIf(.data12 Is Nothing, Nothing, .data12)
                cmd.Parameters.Add("@p_data13", MySqlDbType.Text).Value = IIf(.data13 Is Nothing, Nothing, .data13)
                cmd.Parameters.Add("@p_data14", MySqlDbType.Text).Value = IIf(.data14 Is Nothing, Nothing, .data14)
                cmd.Parameters.Add("@p_data15", MySqlDbType.Text).Value = IIf(.data15 Is Nothing, Nothing, .data15)
                cmd.Parameters.Add("@p_data16", MySqlDbType.Text).Value = IIf(.data16 Is Nothing, Nothing, .data16)
                cmd.Parameters.Add("@p_data17", MySqlDbType.Text).Value = IIf(.data17 Is Nothing, Nothing, .data17)
                cmd.Parameters.Add("@p_data18", MySqlDbType.Text).Value = IIf(.data18 Is Nothing, Nothing, .data18)
                cmd.Parameters.Add("@p_data19", MySqlDbType.Text).Value = IIf(.data19 Is Nothing, Nothing, .data19)
                cmd.Parameters.Add("@p_data20", MySqlDbType.Text).Value = IIf(.data20 Is Nothing, Nothing, .data20)
                cmd.Parameters.Add("@p_comment1", MySqlDbType.Text).Value = IIf(.comment1 Is Nothing, Nothing, .comment1)
                cmd.Parameters.Add("@p_comment2", MySqlDbType.Text).Value = IIf(.comment2 Is Nothing, Nothing, .comment2)
                cmd.Parameters.Add("@p_comment3", MySqlDbType.Text).Value = IIf(.comment3 Is Nothing, Nothing, .comment3)
                cmd.Parameters.Add("@p_comment4", MySqlDbType.Text).Value = IIf(.comment4 Is Nothing, Nothing, .comment4)
                cmd.Parameters.Add("@p_comment5", MySqlDbType.Text).Value = IIf(.comment5 Is Nothing, Nothing, .comment5)
                cmd.Parameters.Add("@p_comment6", MySqlDbType.Text).Value = IIf(.comment6 Is Nothing, Nothing, .comment6)
                cmd.Parameters.Add("@p_comment7", MySqlDbType.Text).Value = IIf(.comment7 Is Nothing, Nothing, .comment7)
                cmd.Parameters.Add("@p_comment8", MySqlDbType.Text).Value = IIf(.comment8 Is Nothing, Nothing, .comment8)
                cmd.Parameters.Add("@p_comment9", MySqlDbType.Text).Value = IIf(.comment9 Is Nothing, Nothing, .comment9)
                cmd.Parameters.Add("@p_comment10", MySqlDbType.Text).Value = IIf(.comment10 Is Nothing, Nothing, .comment10)
                cmd.Parameters.Add("@p_comment11", MySqlDbType.Text).Value = IIf(.comment11 Is Nothing, Nothing, .comment11)
                cmd.Parameters.Add("@p_comment12", MySqlDbType.Text).Value = IIf(.comment12 Is Nothing, Nothing, .comment12)
                cmd.Parameters.Add("@p_comment13", MySqlDbType.Text).Value = IIf(.comment13 Is Nothing, Nothing, .comment13)
                cmd.Parameters.Add("@p_comment14", MySqlDbType.Text).Value = IIf(.comment14 Is Nothing, Nothing, .comment14)
                cmd.Parameters.Add("@p_comment15", MySqlDbType.Text).Value = IIf(.comment15 Is Nothing, Nothing, .comment15)
                cmd.Parameters.Add("@p_comment16", MySqlDbType.Text).Value = IIf(.comment16 Is Nothing, Nothing, .comment16)
                cmd.Parameters.Add("@p_comment17", MySqlDbType.Text).Value = IIf(.comment17 Is Nothing, Nothing, .comment17)
                cmd.Parameters.Add("@p_comment18", MySqlDbType.Text).Value = IIf(.comment18 Is Nothing, Nothing, .comment18)
                cmd.Parameters.Add("@p_comment19", MySqlDbType.Text).Value = IIf(.comment19 Is Nothing, Nothing, .comment19)
                cmd.Parameters.Add("@p_comment20", MySqlDbType.Text).Value = IIf(.comment20 Is Nothing, Nothing, .comment20)
            End With


            cmd.ExecuteNonQuery()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub DelProfile(p_id As Integer)
        Try
            Dim cmd = New MySqlCommand("del_patient", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("p_id", MySqlDbType.Int32).Value = p_id
            conn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Function get_med_section() As DataTable
        Dim l_tbl As New DataTable
        Try
            Dim cmd = New MySqlCommand("get_med_section", conn)
            cmd.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim l_reader As MySqlDataReader = cmd.ExecuteReader()
            l_tbl.Load(l_reader)
            If l_tbl.Rows.Count > 0 Then
                Return l_tbl
            Else
                MsgBox("не удалось получить список Мед. разделов")
                Return Nothing
            End If

        Finally
            conn.Close()
        End Try

    End Function
End Class

Public Class SearchPatientClass
    Inherits Object
    Implements ComponentModel.INotifyPropertyChanged

#Region "свойства"
    Private _id As Int32
    Private _last_name As String
    Private _first_name As String
    Private _second_name As String
    Dim _photo_pers1 As Byte()
#End Region
    Public Property id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property
    Public Property last_name As String
        Get
            Return _last_name
        End Get
        Set(value As String)
            _last_name = value
            OnPropertyChanged(Me, "last_name")
        End Set
    End Property
    Public Property first_name As String
        Get
            Return _first_name
        End Get
        Set(value As String)
            _first_name = value
        End Set
    End Property
    Public Property second_name As String
        Get
            Return _second_name
        End Get
        Set(value As String)
            _second_name = value
        End Set
    End Property
    Public Property photo_pers1 As Byte()
        Get
            Return _photo_pers1
        End Get
        Set(value As Byte())
            _photo_pers1 = value
        End Set
    End Property
    Sub New(p_id As Int32, p_last_name As String, p_first_name As String, p_second_name As String, p_photo_pers1 As Byte())
        _id = p_id
        _last_name = p_last_name
        _first_name = p_first_name
        _second_name = p_second_name
        _photo_pers1 = p_photo_pers1
    End Sub

    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
    Private Sub OnPropertyChanged(sender As Object, p_prop_name As String)
        RaiseEvent PropertyChanged(sender, New PropertyChangedEventArgs(p_prop_name))
    End Sub
End Class
Public Class SearchPatientClassCollect
    Inherits Collections.ObjectModel.ObservableCollection(Of PatientClass)
    Public conn = New MySqlConnection("Server=127.0.0.1;Database=romanber_patient;User Id=romanber_admin;Password=abcd@12345;charset=cp1251;Port=22;default command timeout=10000")
    Sub New(p_last_name As String, p_first_name As String, p_second_name As String, p_birth_date As Date, p_date_from As Date, p_date_to As Date, p_med_id As Integer)

        Dim l_tbl As New DataTable
        Try
            Dim cmd = New MySqlCommand("get_patient_info", conn)
            cmd.CommandType = CommandType.StoredProcedure
            '& vbNewLine & _ для mysql
            '               "where si.last_name like IFNULL(@last_name,si.last_name)" & vbNewLine & _
            '               "and si.first_name like IFNULL(@first_name,si.first_name)" & vbNewLine & _
            '               "and si.second_name like IFNULL(@second_name,si.second_name)" & vbNewLine & _
            '               "and si.birth_date = IFNULL(@birth_date,si.birth_date)" & vbNewLine & _
            '               "and si.date_insert >= IFNULL(@date_from,si.date_insert)" & vbNewLine & _
            '               "and si.date_insert < IFNULL(@date_to+ interval 1 day,si.date_insert)", conn)

            'Dim cmd = New OleDbCommand("select * from subject_info si" & vbNewLine & _
            '            "where si.last_name like iif(IsNull(@last_name),si.last_name,@last_name)" & vbNewLine & _
            ' "and si.first_name like iif(IsNull(@first_name),si.first_name,@first_name)" & vbNewLine & _
            ' "and si.second_name like iif(IsNull(@second_name),si.second_name,@second_name)" & vbNewLine & _
            ' "and iif(IsNull(@birth_date),1,si.birth_date) = iif(IsNull(@birth_date),1,@birth_date)" & vbNewLine & _
            ' "and si.date_insert >= iif(IsNull(@date_from),si.date_insert,@date_from)" & vbNewLine & _
            ' "and si.date_insert <= iif(IsNull(@date_to),si.date_insert,DateAdd(""d"",1, @date_to))", conn)

            cmd.Parameters.Add("@p_last_name", MySqlDbType.VarChar).Value = IIf(p_last_name = "", DBNull.Value, p_last_name)
            cmd.Parameters.Add("@p_first_name", MySqlDbType.VarChar).Value = IIf(p_first_name = "", DBNull.Value, p_first_name)
            cmd.Parameters.Add("@p_second_name", MySqlDbType.VarChar).Value = IIf(p_second_name = "", DBNull.Value, p_second_name)
            cmd.Parameters.Add("@p_birth_date", MySqlDbType.Date).Value = convertDBnull(p_birth_date)
            cmd.Parameters.Add("@p_date_from", MySqlDbType.Date).Value = convertDBnull(p_date_from)
            cmd.Parameters.Add("@p_date_to", MySqlDbType.Date).Value = convertDBnull(p_date_to)
            cmd.Parameters.Add("@p_med_id", MySqlDbType.Int32).Value = IIf(p_med_id = 0, DBNull.Value, p_med_id)

            conn.Open()
            Dim l_reader As MySqlDataReader = cmd.ExecuteReader()
            l_tbl.Load(l_reader)

            If l_tbl.Rows.Count > 0 Then
                For i As Int32 = 0 To l_tbl.Rows.Count - 1
                    With l_tbl.Rows(i)
                        Dim l_get_data As New PatientClass(.Item("id"),
                                                                 Convert.ToString(.Item("last_name")),
                                                                 Convert.ToString(.Item("first_name")),
                                                                 Convert.ToString(.Item("second_name")),
                                                                 date_wout_time(Convert.ToString(.Item("birth_date"))),
                                                                 Convert.ToString(.Item("contact_phone")),
                                                                 Convert.ToString(.Item("mobile_phone")),
                                                                 Convert.ToString(.Item("e_mail")),
                                                                 Convert.ToString(.Item("sex")),
                                                                 Convert.ToString(.Item("section_name")),
                                                                 IIf(.Item("med_section_id") Is DBNull.Value, 0, .Item("med_section_id")),
                                                                 Convert.ToString(.Item("diagnos")),
                                                                 Convert.ToString(.Item("address")),
                                                                 Convert.ToString(.Item("job_place")),
                                                                 Convert.ToString(.Item("Complaint")),
                                                                 IIf(.Item("photo_pers1") Is DBNull.Value, Nothing, .Item("photo_pers1")),
                                                                 IIf(.Item("photo_pers2") Is DBNull.Value, Nothing, .Item("photo_pers2")),
                                                                 IIf(.Item("photo_pers3") Is DBNull.Value, Nothing, .Item("photo_pers3")),
                                                                 IIf(.Item("photo_xray1") Is DBNull.Value, Nothing, .Item("photo_xray1")),
                                                                 IIf(.Item("photo_xray2") Is DBNull.Value, Nothing, .Item("photo_xray2")),
                                                                 IIf(.Item("photo_xray3") Is DBNull.Value, Nothing, .Item("photo_xray3")),
                                                                 IIf(.Item("photo_xray4") Is DBNull.Value, Nothing, .Item("photo_xray4")),
                                                                 Convert.ToString(.Item("zhang_fu_xu")),
                                                                 Convert.ToString(.Item("xang_ke_qi")),
                                                                 Convert.ToString(.Item("data1")),
                                                                 Convert.ToString(.Item("data2")),
                                                                 Convert.ToString(.Item("data3")),
                                                                 Convert.ToString(.Item("data4")),
                                                                 Convert.ToString(.Item("data5")),
                                                                 Convert.ToString(.Item("data6")),
                                                                 Convert.ToString(.Item("data7")),
                                                                 Convert.ToString(.Item("data8")),
                                                                 Convert.ToString(.Item("data9")),
                                                                 Convert.ToString(.Item("data10")),
                                                                 Convert.ToString(.Item("data11")),
                                                                 Convert.ToString(.Item("data12")),
                                                                 Convert.ToString(.Item("data13")),
                                                                 Convert.ToString(.Item("data14")),
                                                                 Convert.ToString(.Item("data15")),
                                                                 Convert.ToString(.Item("data16")),
                                                                 Convert.ToString(.Item("data17")),
                                                                 Convert.ToString(.Item("data18")),
                                                                 Convert.ToString(.Item("data19")),
                                                                 Convert.ToString(.Item("data20")),
                                                                 Convert.ToString(.Item("comment1")),
                                                                 Convert.ToString(.Item("comment2")),
                                                                 Convert.ToString(.Item("comment3")),
                                                                 Convert.ToString(.Item("comment4")),
                                                                 Convert.ToString(.Item("comment5")),
                                                                 Convert.ToString(.Item("comment6")),
                                                                 Convert.ToString(.Item("comment7")),
                                                                 Convert.ToString(.Item("comment8")),
                                                                 Convert.ToString(.Item("comment9")),
                                                                 Convert.ToString(.Item("comment10")),
                                                                 Convert.ToString(.Item("comment11")),
                                                                 Convert.ToString(.Item("comment12")),
                                                                 Convert.ToString(.Item("comment13")),
                                                                 Convert.ToString(.Item("comment14")),
                                                                 Convert.ToString(.Item("comment15")),
                                                                 Convert.ToString(.Item("comment16")),
                                                                 Convert.ToString(.Item("comment17")),
                                                                 Convert.ToString(.Item("comment18")),
                                                                 Convert.ToString(.Item("comment19")),
                                                                 Convert.ToString(.Item("comment20")),
                                                                 Convert.ToString(.Item("txtDot0")),
                                                                Convert.ToString(.Item("txtDot1")),
                                                                Convert.ToString(.Item("txtDot2")),
                                                                Convert.ToString(.Item("txtDot3")),
                                                                Convert.ToString(.Item("txtDot4")),
                                                                Convert.ToString(.Item("txtDot5")),
                                                                Convert.ToString(.Item("txtDot6")),
                                                                Convert.ToString(.Item("txtDot7")),
                                                                Convert.ToString(.Item("txtDot8")),
                                                                Convert.ToString(.Item("txtDot9")),
                                                                Convert.ToString(.Item("txtDot10")),
                                                                Convert.ToString(.Item("txtDot11")),
                                                                Convert.ToString(.Item("txtDot12")),
                                                                Convert.ToString(.Item("txtDot13")),
                                                                 Convert.ToString(.Item("txtDot14")),
                                                                 Convert.ToString(.Item("txtDot15")),
                                                                 Convert.ToString(.Item("txtDot16")),
                                                                  Convert.ToString(.Item("txtDot17")),
                                                                 Convert.ToString(.Item("txtDot18")),
                                                                  Convert.ToString(.Item("txtDot19")),
                                                                  Convert.ToString(.Item("txtDot20")),
                                                                  Convert.ToString(.Item("stvol")),
                                                                  Convert.ToString(.Item("vetv")),
                                                                  Convert.ToString(.Item("layer")))
                        Me.Add(l_get_data)
                    End With
                Next
            End If

        Finally
            conn.Close()
        End Try
    End Sub
    Public Function ToMySql(ByVal d As Date) As String
        Return d.ToString("yyyy-MM-dd HH:mm:ss")
    End Function
    Public Function convertDBnull(ByVal val As String) As Object
        If val = "0:00:00" Then
            Return DBNull.Value
        Else
            Return ToMySql(val)
        End If
    End Function
    Public Function date_wout_time(ByVal p_date As String)
        If p_date.Length > 10 Then
            Return p_date.Substring(0, 10)
        Else
            Return Nothing
        End If
    End Function
End Class
Public Class ClassStrokes
    Inherits Object
    Private _stroke_name As String
    Private _strokes As StrokeCollection
    Public Property stroke_name As String
        Get
            Return _stroke_name
        End Get
        Set(value As String)
            _stroke_name = value
        End Set
    End Property

    Public Property strokes As StrokeCollection
        Get
            Return _strokes
        End Get
        Set(value As StrokeCollection)
            _strokes = value
        End Set
    End Property
    Sub New(p_stroke_name As String, p_strokes As StrokeCollection)
        _stroke_name = p_stroke_name
        _strokes = p_strokes
    End Sub

End Class

Public Class MedSection
    Private id As Integer
    Private med_sec_name As String

    Sub New(p_id As Integer, p_med_sec_name As String)
        id = p_id
        med_sec_name = p_med_sec_name
    End Sub

    Sub New()

    End Sub

End Class
Public Class MedSectionCollect
    Inherits Collections.ObjectModel.ObservableCollection(Of MedSection)
    Public conn = New MySqlConnection("Server=127.0.0.1;Database=romanber_patient;User Id=romanber_admin;Password=abcd@12345;charset=cp1251;Port=22;default command timeout=10000")
    Sub New()
        Dim l_tbl As New DataTable
        Try
            Dim cmd = New MySqlCommand("get_med_section", conn)
            cmd.CommandType = CommandType.StoredProcedure
            conn.Open()
            Dim l_reader As MySqlDataReader = cmd.ExecuteReader()
            l_tbl.Load(l_reader)
            If l_tbl.Rows.Count > 0 Then
                For i As Int32 = 0 To l_tbl.Rows.Count - 1
                    With l_tbl.Rows(i)
                        Dim l_med_section As New MedSection(.Item("id"), .Item("section_name"))
                        Me.Add(l_med_section)
                    End With
                Next
            End If

        Finally
            conn.Close()
        End Try
    End Sub

End Class

Class SshTunnel
    Implements IDisposable
    Private l_client As SshClient
    Private l_tunnel As ForwardedPortLocal
    Private l_localport As Integer
    Sub New()
        Using l_stream = New IO.FileStream(AppDomain.CurrentDomain.BaseDirectory & "Key\id_rsa", IO.FileMode.Open, IO.FileAccess.Read)
            Try
                Dim pk = New PrivateKeyFile(l_stream, "5HAN7PZ2?AdQ")
                Dim con_info = New ConnectionInfo("cpanel11.d.fozzy.com", 22, "romanber", New PrivateKeyAuthenticationMethod("romanber", pk))
                l_client = New SshClient(con_info)
                l_tunnel = New ForwardedPortLocal("127.0.0.1", 22, "127.0.0.1", 3306)
                l_client.Connect()
                l_client.AddForwardedPort(l_tunnel)
                l_tunnel.Start()

            Catch ex As Renci.SshNet.Common.SshException
                Dispose()

            End Try
        End Using

    End Sub


#Region "IDisposable Support"
    Private disposedValue As Boolean ' Чтобы обнаружить избыточные вызовы

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If l_tunnel IsNot Nothing Then
                    l_tunnel.Dispose()
                End If
                'If l_client IsNot Nothing Then
                '    l_client.Dispose()
                'End If
                ' TODO: освободить управляемое состояние (управляемые объекты).
            End If

            ' TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже Finalize().
            ' TODO: задать большие поля как null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: переопределить Finalize(), только если Dispose(ByVal disposing As Boolean) выше имеет код для освобождения неуправляемых ресурсов.
    'Protected Overrides Sub Finalize()
    '    ' Не изменяйте этот код.  Поместите код очистки в расположенную выше команду Удалить(ByVal удаление как булево).
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Этот код добавлен редактором Visual Basic для правильной реализации шаблона высвобождаемого класса.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Не изменяйте этот код. Разместите код очистки выше в Dispose(ByVal disposing As Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class

