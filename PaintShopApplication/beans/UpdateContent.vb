Public Class UpdateContent
    Private garagesAtt As Garage()
    Private colorsAtt As Color()
    Private carsAtt As Car()
    Private formulasAtt As Formula()

    Property garages() As Garage()
        Get
            Return garagesAtt
        End Get
        Set(ByVal Value As Garage())
            garagesAtt = Value
        End Set
    End Property

    Property colors() As Color()
        Get
            Return colorsAtt
        End Get
        Set(ByVal Value As Color())
            colorsAtt = Value
        End Set
    End Property

    Property cars() As Car()
        Get
            Return carsAtt
        End Get
        Set(ByVal Value As Car())
            carsAtt = Value
        End Set
    End Property

    Property formulas() As Formula()
        Get
            Return formulasAtt
        End Get
        Set(ByVal Value As Formula())
            formulasAtt = Value
        End Set
    End Property


End Class
