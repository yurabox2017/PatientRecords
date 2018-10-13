Public Class BaseTab
    Inherits UserControl


    Private _title As String

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public ReadOnly Property UniqueTabName As String
        Get
            Return Me.Name
        End Get
    End Property
End Class
