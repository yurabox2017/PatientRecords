<ValueConversion(GetType(System.DateTime), GetType(System.String))>
Public Class DateToString
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As System.Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
        If value Is System.DBNull.Value Then
            Return Nothing
        Else
            If IsDate(value) Then
                Return CType(value, Date).ToString(parameter)
            Else
                Return value
            End If
        End If
    End Function

    Public Function ConvertBack(value As Object, targetType As System.Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
        If value Is Nothing OrElse Not IsDate(value) Then
            Return value
        Else
            Return System.Convert.ToDateTime(value)
        End If
    End Function
End Class
