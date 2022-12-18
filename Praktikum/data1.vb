Public Class data1
    Private nim As String
    Private nama As String
    Private prodi As String
    Public Property get_nim() As String
        Get
            Return nim
        End Get
        Set(value As String)
            nim = value
        End Set
    End Property
    Public Property get_nama() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property get_prodi() As String
        Get
            Return prodi
        End Get
        Set(value As String)
            prodi = value
        End Set
    End Property
End Class
