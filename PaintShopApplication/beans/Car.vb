Imports Newtonsoft.Json

Public Class Car
    Private id_carAtt As Integer
    Private id_carStrAtt As String

    Private carImgPathAtt As String

    Private modelAtt As String

    Private carNameAtt As String
    Private colorCodeLocationAtt As String

    Private tableNameAtt As String
    Private actionTypeAtt As String

    Property actionType() As String
        Get
            Return actionTypeAtt
        End Get
        Set(ByVal Value As String)
            actionTypeAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property id_car() As Integer
        Get
            Return id_carAtt
        End Get
        Set(ByVal Value As Integer)
            id_carAtt = Value
        End Set
    End Property

    <JsonProperty("id_car")>
    Property id_carStr() As String
        Get
            Return id_carStrAtt
        End Get
        Set(ByVal Value As String)
            id_carStrAtt = Value
        End Set
    End Property


    Property carImgPath() As String
        Get
            Return carImgPathAtt
        End Get
        Set(ByVal Value As String)
            carImgPathAtt = Value.Trim
        End Set
    End Property


    Property model() As String
        Get
            Return modelAtt
        End Get
        Set(ByVal Value As String)
            modelAtt = Value.Trim
        End Set
    End Property


    Property carName() As String
        Get
            Return carNameAtt
        End Get
        Set(ByVal Value As String)
            carNameAtt = Value.Trim
        End Set
    End Property

    Property tableName() As String
        Get
            Return tableNameAtt
        End Get
        Set(ByVal Value As String)
            tableNameAtt = Value.Trim
        End Set

    End Property
    Property colorCodeLocation() As String
        Get
            Return colorCodeLocationAtt
        End Get
        Set(ByVal Value As String)
            colorCodeLocationAtt = Value.Trim
        End Set
    End Property

End Class
