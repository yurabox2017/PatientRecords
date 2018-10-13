<ValueConversion(GetType(System.Windows.Visibility), GetType(System.Boolean))>
Public Class DetailGridVisibleConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
        Dim visibleValue As Boolean = False
        If value IsNot Nothing AndAlso TypeOf value Is Visibility Then
            visibleValue = Not (DirectCast(value, Visibility) = Visibility.Collapsed)
        End If
        Return visibleValue
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
        Dim visibleValue As Visibility = Visibility.Collapsed
        If TypeOf value Is Boolean Then
            If DirectCast(value, Boolean) = True Then
                visibleValue = Visibility.Visible
            End If
        End If
        Return visibleValue
    End Function
End Class

