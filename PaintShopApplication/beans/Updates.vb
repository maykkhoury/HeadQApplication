Public Class Updates
    Private versionAtt As Integer
    Private updateContentAtt As UpdateContent

    Property version() As Integer
        Get
            Return versionAtt
        End Get
        Set(ByVal Value As Integer)
            versionAtt = Value
        End Set
    End Property

    Property updateContent() As UpdateContent
        Get
            Return updateContentAtt
        End Get
        Set(ByVal Value As UpdateContent)
            updateContentAtt = Value
        End Set
    End Property


   

End Class
