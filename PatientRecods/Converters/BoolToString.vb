Imports System.Globalization

<ValueConversion(GetType(System.Boolean), GetType(System.String))>
Public Class BoolToString
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        If value Is Nothing OrElse value Is DBNull.Value Then
            Return "Нет"
        Else
            If value Then
                Return "Да"
            Else
                Return "Нет"
            End If
        End If
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Return (System.Convert.ToString(value) = "Да")
    End Function
End Class
