Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Ink

Module cmn
#Region "Работа с картинками"
    ''' <summary>
    ''' Вернуть байты картинки из источника картинки
    ''' </summary>
    ''' <param name="p_source">Объект Source картинки</param>
    ''' <returns></returns>
    Function ImgGetBytesFromImg(ByVal p_source As Windows.Media.Imaging.BitmapImage) As Byte()

        If p_source IsNot Nothing Then
            If p_source.UriSource IsNot Nothing Then
                Return IO.File.ReadAllBytes(p_source.UriSource.OriginalString)
            ElseIf p_source.StreamSource IsNot Nothing Then
                Dim l_bytes(p_source.StreamSource.Length - 1) As Byte

                p_source.StreamSource.Position = 0 ' При передаче в эту функцию позиция указателя чтения в конце потока и чтения не происходит. Поэтому перемещаем указатель в начальную позицию
                p_source.StreamSource.Read(l_bytes, 0, l_bytes.Length)
                Return l_bytes
            Else
                Throw New Exception("Объект Source картинки не содержит ссылку на файл или байты")
            End If
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Вернуть источник для картинки из массива байт
    ''' </summary>
    ''' <param name="p_bytes"></param>
    ''' <returns></returns>
    Function ImgGetImgFromByte(ByVal p_bytes() As Byte, Optional ByVal p_f As Boolean = True) As Windows.Media.Imaging.BitmapImage
        Dim l_img As New System.Windows.Media.Imaging.BitmapImage

        If p_bytes IsNot Nothing Then
            l_img.BeginInit()
            l_img.StreamSource = New IO.MemoryStream(p_bytes)
            If p_f Then l_img.EndInit()
        End If

        Return l_img
    End Function

    ''' <summary>
    ''' Изменение размера картинки (текущие размеры умножаются на указанный коэффициент
    ''' </summary>    
    ''' <returns></returns>
    Function ImgResize(ByVal p_bytes() As Byte, ByVal p_new_width As Int16, ByVal p_new_height As Int16) As Byte()
        If p_new_width <= 0 Or p_new_height < 0 Then
            Return p_bytes
        Else
            'Dim l_img As Drawing.Image = Drawing.Image.FromStream(New IO.MemoryStream(p_bytes))
            'Dim l_img_new As New Drawing.Bitmap(p_new_width, p_new_height, l_img.PixelFormat)
            'Dim l_grafics As Drawing.Graphics = Drawing.Graphics.FromImage(l_img_new)
            Dim l_img As Windows.Media.Imaging.BitmapImage = ImgGetImgFromByte(p_bytes, False)
            Dim l_stream As New IO.MemoryStream

            'l_grafics.CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
            'l_grafics.SmoothingMode = Drawing.Drawing2D.SmoothingMode.HighQuality
            'l_grafics.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic

            'l_grafics.DrawImage(l_img, 0, 0, p_new_width, p_new_height)
            'l_grafics.Dispose()

            'l_img_new.SetPropertyItem(l_img.GetPropertyItem(9999))
            'l_img_new.Save(l_stream, l_img.RawFormat)

            Dim l_bytes(l_stream.Length) As Byte
            l_stream.Read(l_bytes, 0, l_bytes.Length)

            'Return l_bytes

            Dim l_i As New Windows.Media.Imaging.BitmapImage
            Dim l_e As New Windows.Media.Imaging.JpegBitmapEncoder

            l_i.BeginInit()
            l_img.DecodePixelHeight = p_new_height
            l_img.DecodePixelWidth = p_new_width
            l_img.EndInit()
            l_e.Frames.Add(Windows.Media.Imaging.BitmapFrame.Create(l_img))
            l_e.Save(l_stream)

            Return l_bytes

        End If
    End Function
    ''' <summary>
    ''' Перевести канвас в байты
    ''' </summary>    
    ''' <returns></returns>
    ''' 
    Function GetByteFromCanvas(p_canvas As System.Windows.Controls.InkCanvas) As Byte()
        Dim bounds As Rect = VisualTreeHelper.GetDescendantBounds(p_canvas)
        Dim bmp As RenderTargetBitmap = New RenderTargetBitmap(p_canvas.ActualWidth, p_canvas.ActualHeight, 100, 100, PixelFormats.Default)
        'bmp.Render(Me.DrawlingCanvas)

        Dim dv As DrawingVisual = New DrawingVisual

        Using dc As DrawingContext = dv.RenderOpen()
            Dim vb As VisualBrush = New VisualBrush(p_canvas)
            dc.DrawRectangle(vb, Nothing, New Rect(New Point(), bounds.Size))
        End Using

        bmp.Render(dv)

        Dim l_jpg_encoder As JpegBitmapEncoder = New JpegBitmapEncoder
        l_jpg_encoder.Frames.Add(BitmapFrame.Create(bmp))


        Dim l_stream As IO.MemoryStream = New IO.MemoryStream ' = System.IO.File.Create("C:\test\Canvas.png")
        l_jpg_encoder.Save(l_stream)

        Dim l_byte As Byte() = l_stream.ToArray()
        l_stream.Close()
        'Me.PhotoCanvas.Source = cmn.ImgGetImgFromByte(l_byte)
        Return l_byte
    End Function
#End Region
End Module

