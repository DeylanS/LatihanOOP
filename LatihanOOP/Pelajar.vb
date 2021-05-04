Public Class Pelajar
    Private strNoMatrik As String

    Sub New(ByVal strNoMatrik As String)
        Me.strNoMatrik = strNoMatrik
    End Sub

    Public Function Politeknik() As String
        Dim strKodPoli As String = strNoMatrik.Substring(0, 2)

        If strKodPoli = 18 Then
            Return "PTSS"
        Else
            Return "Not PTSS"
        End If
    End Function

    Public Function Program() As String
        Dim strKodProg As String = strNoMatrik.Substring(2, 3)

        If strKodProg = "DDT" Then
            Return "Diploma Digital Teknologi"
        Else
            Return "Not Diploma Digital Teknologi"
        End If
    End Function

    Public Function Ambilan() As String
        Dim strKodTahun As String = strNoMatrik.Substring(5, 2)
        Dim strKodSesi As String = strNoMatrik.Substring(7, 2)

        If strKodTahun = 19 And strKodSesi = "F1" Then
            Return "Sesi Jun 2019"
        Else
            Return "Bukan Sesi Jun 2019"
        End If


    End Function
End Class
