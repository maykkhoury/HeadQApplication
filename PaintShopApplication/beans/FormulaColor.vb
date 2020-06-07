Imports Newtonsoft.Json

Public Class FormulaColor
    Private id_formulaColorAtt As Integer

    Private id_formulaAtt As Integer

    Private id_colorAtt As Integer

    Private id_carAtt As Integer

    Private id_formulaColorStrAtt As String

    <JsonProperty("id_formulaColor")>
    Property id_formulaColorStr() As String
        Get
            Return id_formulaColorStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaColorStrAtt = Value
        End Set
    End Property


    Private id_formulaStrAtt As String
    <JsonProperty("id_formula")>
    Property id_formulaStr() As String
        Get
            Return id_formulaStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaStrAtt = Value
        End Set
    End Property

    Private id_colorStrAtt As String
    <JsonProperty("id_color")>
    Property id_colorStr() As String
        Get
            Return id_colorStrAtt
        End Get
        Set(ByVal Value As String)
            id_colorStrAtt = Value
        End Set
    End Property


    Private id_carStrAtt As String

    <JsonIgnore>
    Property id_carStr() As String
        Get
            Return id_carStrAtt
        End Get
        Set(ByVal Value As String)
            id_carStrAtt = Value
        End Set
    End Property

    Private quantiteAtt As Decimal

    Private quantiteStrAtt As String
    <JsonProperty("quantite")>
    Property quantiteStr() As String
        Get
            Return quantiteStrAtt
        End Get
        Set(ByVal Value As String)
            quantiteStrAtt = Value
        End Set
    End Property


    Private quantiteEncAtt As String

    Private id_UnitAtt As Integer
    Private id_UnitStrAtt As Integer
    <JsonProperty("id_Unit")>
    Property id_UnitStr() As String
        Get
            Return id_UnitStrAtt
        End Get
        Set(ByVal Value As String)
            id_UnitStrAtt = Value
        End Set
    End Property

    Private encryptedAtt As Boolean = False

    Private encryptedStrAtt As String = "0"
    <JsonProperty("encrypted")>
    Property encryptedStr() As String
        Get
            Return encryptedStrAtt
        End Get
        Set(ByVal Value As String)
            encryptedStrAtt = Value
        End Set
    End Property
    <JsonIgnore>
    Property encrypted() As Boolean
        Get
            Return encryptedAtt
        End Get
        Set(ByVal Value As Boolean)
            encryptedAtt = Value
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

    <JsonIgnore>
    Property id_formulaColor() As Integer
        Get
            Return id_formulaColorAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaColorAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property id_formula() As Integer
        Get
            Return id_formulaAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property id_color() As Integer
        Get
            Return id_colorAtt
        End Get
        Set(ByVal Value As Integer)
            id_colorAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property quantite() As Decimal
        Get
            Return quantiteAtt
        End Get
        Set(ByVal Value As Decimal)
            quantiteAtt = Value
        End Set
    End Property
    <JsonIgnore>
    Property quantiteEnc() As String
        Get
            Return quantiteEncAtt
        End Get
        Set(ByVal Value As String)
            quantiteEncAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property id_Unit() As Integer
        Get
            Return id_UnitAtt
        End Get
        Set(ByVal Value As Integer)
            id_UnitAtt = Value
        End Set
    End Property

End Class
