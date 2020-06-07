Imports Newtonsoft.Json

Public Class Color
    Private id_colorAtt As Integer
    Private id_colorStrAtt As String

    Private colorImgPathAtt As String

    Private defaultPriceAtt As Decimal
    Private defaultPriceStrAtt As String

    Private id_defaultCurrenyAtt As Integer
    Private id_defaultCurrenyStrAtt As String

    Private id_defaultUnitAtt As Integer
    Private id_defaultUnitStrAtt As String

    Private name_colorAtt As String

    Private name_color_alternativeAtt As String
    Private name_color_alternative2Att As String
    Private colorCodeAtt As String

    Private id_unit_on_entryAtt As Integer
    Private id_unit_on_entryStrAtt As String

    Private masse_volumiqueAtt As String

    Private masse_volumique_extAtt As String

    Private argbAtt As String
    Private actionTypeAtt As String

    Property actionType() As String
        Get
            Return actionTypeAtt
        End Get
        Set(ByVal Value As String)
            actionTypeAtt = Value
        End Set
    End Property
    Property argb() As String
        Get
            Return argbAtt
        End Get
        Set(ByVal Value As String)
            argbAtt = Value
        End Set
    End Property

    Property masse_volumique_ext() As String
        Get
            Return masse_volumique_extAtt
        End Get
        Set(ByVal Value As String)
            masse_volumique_extAtt = Value.Trim
        End Set
    End Property

    Property masse_volumique() As String
        Get
            Return masse_volumiqueAtt
        End Get
        Set(ByVal Value As String)
            masse_volumiqueAtt = Value.Trim
        End Set
    End Property

    <JsonIgnore>
    Property id_unit_on_entry() As Integer
        Get
            Return id_unit_on_entryAtt
        End Get
        Set(ByVal Value As Integer)
            id_unit_on_entryAtt = Value
        End Set
    End Property

    <JsonProperty("id_unit_on_entry")>
    Property id_unit_on_entryStr() As String
        Get
            Return id_unit_on_entryStrAtt
        End Get
        Set(ByVal Value As String)
            id_unit_on_entryStrAtt = Value
        End Set
    End Property

    Property colorCode() As String
        Get
            Return colorCodeAtt
        End Get
        Set(ByVal Value As String)
            colorCodeAtt = Value
        End Set
    End Property
    Property name_color() As String
        Get
            Return name_colorAtt
        End Get
        Set(ByVal Value As String)
            name_colorAtt = Value
        End Set
    End Property

    Property name_color_alternative() As String
        Get
            Return name_color_alternativeAtt
        End Get
        Set(ByVal Value As String)
            name_color_alternativeAtt = Value
        End Set
    End Property
    Property name_color_alternative2() As String
        Get
            Return name_color_alternative2Att
        End Get
        Set(ByVal Value As String)
            name_color_alternative2Att = Value
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

    <JsonProperty("id_color")>
    Property id_colorStr() As String
        Get
            Return id_colorStrAtt
        End Get
        Set(ByVal Value As String)
            id_colorStrAtt = Value
        End Set
    End Property


    Property colorImgPath() As String
        Get
            Return colorImgPathAtt
        End Get
        Set(ByVal Value As String)
            colorImgPathAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property defaultPrice() As Decimal
        Get
            Return defaultPriceAtt
        End Get
        Set(ByVal Value As Decimal)
            defaultPriceAtt = Value
        End Set
    End Property

    <JsonProperty("defaultPrice")>
    Property defaultPriceStr() As String
        Get
            Return defaultPriceStrAtt
        End Get
        Set(ByVal Value As String)
            defaultPriceStrAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property id_defaultCurreny() As Integer
        Get
            Return id_defaultCurrenyAtt
        End Get
        Set(ByVal Value As Integer)
            id_defaultCurrenyAtt = Value
        End Set
    End Property

    <JsonProperty("id_defaultCurreny")>
    Property id_defaultCurrenyStr() As String
        Get
            Return id_defaultCurrenyStrAtt
        End Get
        Set(ByVal Value As String)
            id_defaultCurrenyStrAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property id_defaultUnit() As Integer
        Get
            Return id_defaultUnitAtt
        End Get
        Set(ByVal Value As Integer)
            id_defaultUnitAtt = Value
        End Set
    End Property

    <JsonProperty("id_defaultUnit")>
    Property id_defaultUnitStr() As String
        Get
            Return id_defaultUnitStrAtt
        End Get
        Set(ByVal Value As String)
            id_defaultUnitStrAtt = Value
        End Set
    End Property

End Class
