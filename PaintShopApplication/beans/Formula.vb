Imports Newtonsoft.Json

Public Class Formula
    Private modified_onceAtt As Boolean = False
    Property modified_once() As Boolean
        Get
            Return modified_onceAtt
        End Get
        Set(ByVal Value As Boolean)
            modified_onceAtt = Value
        End Set

    End Property

    Private id_formulaAtt As Integer
    Private id_formulaStrAtt As String
    <JsonProperty("id_formula")>
    Property id_formulaStr() As String
        Get
            Return id_formulaStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaStrAtt = Value.Trim
        End Set

    End Property

    Private formulaImgPathAtt As String

    Private otherPriceAtt As Decimal
    Private otherPriceStrAtt As String
    <JsonProperty("otherPrice")>
    Property otherPriceStr() As String
        Get
            Return otherPriceStrAtt
        End Get
        Set(ByVal Value As String)
            otherPriceStrAtt = Value.Trim
        End Set

    End Property

    Private id_otherCurrenyAtt As Integer
    Private id_otherCurrenyStrAtt As String
    <JsonProperty("id_otherCurreny")>
    Property id_otherCurrenyStr() As String
        Get
            Return id_otherCurrenyStrAtt
        End Get
        Set(ByVal Value As String)
            id_otherCurrenyStrAtt = Value.Trim
        End Set

    End Property

    Private id_otherUnitAtt As Integer
    Private id_otherUnitStrAtt As String
    <JsonProperty("id_otherUnit")>
    Property id_otherUnitStr() As String
        Get
            Return id_otherUnitStrAtt
        End Get
        Set(ByVal Value As String)
            id_otherUnitStrAtt = Value.Trim
        End Set

    End Property


    Private id_carAtt As Integer
    Private id_carStrAtt As String
    <JsonProperty("id_car")>
    Property id_carStr() As String
        Get
            Return id_carStrAtt
        End Get
        Set(ByVal Value As String)
            id_carStrAtt = Value.Trim
        End Set

    End Property

    Private name_carAtt As String

    Private typeAtt As String
    Private versionAtt As String
    Private name_formulaAtt As String

    Private variantAtt As String
    Private duplicateAtt As String
    Private colorRGBAtt As String
    Private c_yearAtt As String
    Private colorCodeAtt As String
    Private id_formulaXAtt As Integer
    Private id_formulaXpAtt As Integer
    Private id_formulaX2pAtt As Integer

    Private id_formulaYAtt As Integer
    Private id_formulaYpAtt As Integer
    Private id_formulaY2pAtt As Integer

    Private id_formulaZAtt As Integer
    Private id_formulaZpAtt As Integer
    Private id_formulaZ2pAtt As Integer

    Private id_formulaXStrAtt As String
    Private id_formulaXpStrAtt As String
    Private id_formulaX2pStrAtt As String

    Private id_formulaYStrAtt As String
    Private id_formulaYpStrAtt As String
    Private id_formulaY2pStrAtt As String

    Private id_formulaZStrAtt As String
    Private id_formulaZpStrAtt As String
    Private id_formulaZ2pStrAtt As String


    Private code_formulaXAtt As String
    Private code_formulaXpAtt As String
    Private code_formulaXppAtt As String

    Private code_formulaYAtt As String
    Private code_formulaYpAtt As String
    Private code_formulaYppAtt As String

    Private code_formulaZAtt As String
    Private code_formulaZpAtt As String
    Private code_formulaZppAtt As String


    Private cardNumberAtt As String
    Private convertedAtt As String

    Private isEquation15perc4201Att As Boolean
    Private isEquation15perc4201StrAtt As String
    <JsonProperty("isEquation15perc4201")>
    Property isEquation15perc4201Str() As String
        Get
            Return isEquation15perc4201StrAtt
        End Get
        Set(ByVal Value As String)
            isEquation15perc4201StrAtt = Value.Trim
        End Set

    End Property


    Private isEquation4201_180Att As Boolean
    Private noEquation4201_180StrAtt As String
    <JsonProperty("noEquation4201_180")>
    Property noEquation4201_180Str() As String
        Get
            Return noEquation4201_180StrAtt
        End Get
        Set(ByVal Value As String)
            noEquation4201_180StrAtt = Value.Trim
        End Set

    End Property

    Private movedAtt As Boolean = False
    Private dateCreModAtt As DateTime
    Private Date_cre_modAtt As String

    Property Date_cre_mod() As String
        Get
            Return Date_cre_modAtt
        End Get
        Set(ByVal Value As String)
            Date_cre_modAtt = Value.Trim
        End Set

    End Property

    <JsonIgnore>
    Property converted() As String
        Get
            Return convertedAtt
        End Get
        Set(ByVal Value As String)
            convertedAtt = Value.Trim
        End Set

    End Property

    Private tableNameAtt As String

    Property tableName() As String
        Get
            Return tableNameAtt
        End Get
        Set(ByVal Value As String)
            tableNameAtt = Value.Trim
        End Set

    End Property

    Private formulaColorAtt As FormulaColor()
    Property formulaColor() As FormulaColor()
        Get
            Return formulaColorAtt
        End Get
        Set(ByVal Value As FormulaColor())
            formulaColorAtt = Value
        End Set
    End Property

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
    Property dateCreMod() As DateTime
        Get
            Return dateCreModAtt
        End Get
        Set(ByVal Value As DateTime)
            dateCreModAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property isMoved() As Boolean
        Get
            Return movedAtt
        End Get
        Set(ByVal Value As Boolean)
            movedAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property isEquation4201_180() As Boolean
        Get
            Return isEquation4201_180Att
        End Get
        Set(ByVal Value As Boolean)
            isEquation4201_180Att = Value
        End Set
    End Property

    <JsonIgnore>
    Property isEquation15perc4201() As Boolean
        Get
            Return isEquation15perc4201Att
        End Get
        Set(ByVal Value As Boolean)
            isEquation15perc4201Att = Value
        End Set
    End Property


    Property cardNumber() As String
        Get
            Return cardNumberAtt
        End Get
        Set(ByVal Value As String)
            cardNumberAtt = Value.Trim
        End Set
    End Property

    <JsonIgnore>
    Property id_formulaXp() As Integer
        Get
            Return id_formulaXpAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaXpAtt = Value
        End Set

    End Property
    <JsonIgnore>
    Property id_formulaX2p() As Integer
        Get
            Return id_formulaX2pAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaX2pAtt = Value
        End Set

    End Property
    <JsonIgnore>
    Property id_formulaYp() As Integer
        Get
            Return id_formulaYpAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaYpAtt = Value
        End Set

    End Property
    <JsonIgnore>
    Property id_formulaY2p() As Integer
        Get
            Return id_formulaY2pAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaY2pAtt = Value
        End Set

    End Property
    <JsonIgnore>
    Property id_formulaZp() As Integer
        Get
            Return id_formulaZpAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaZpAtt = Value
        End Set
    End Property
    <JsonIgnore>
    Property id_formulaZ2p() As Integer
        Get
            Return id_formulaZ2pAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaZ2pAtt = Value
        End Set
    End Property
    <JsonIgnore>
    Property id_formulaY() As Integer
        Get
            Return id_formulaYAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaYAtt = Value
        End Set

    End Property
    <JsonIgnore>
    Property id_formulaX() As Integer
        Get
            Return id_formulaXAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaXAtt = Value
        End Set
    End Property
    <JsonIgnore>
    Property id_formulaZ() As Integer
        Get
            Return id_formulaZAtt
        End Get
        Set(ByVal Value As Integer)
            id_formulaZAtt = Value
        End Set
    End Property
    <JsonIgnore>
    Property name_car() As String
        Get
            Return name_carAtt
        End Get
        Set(ByVal Value As String)
            name_carAtt = Value.Trim
        End Set
    End Property

    Property c_year() As String
        Get
            Return c_yearAtt
        End Get
        Set(ByVal Value As String)
            c_yearAtt = Value.Trim
        End Set
    End Property

    Property colorRGB() As String
        Get
            Return colorRGBAtt
        End Get
        Set(ByVal Value As String)
            colorRGBAtt = Value.Trim
        End Set
    End Property


    Property colorCode() As String
        Get
            Return colorCodeAtt
        End Get
        Set(ByVal Value As String)
            colorCodeAtt = Value.Trim
        End Set
    End Property

    Property duplicate() As String
        Get
            Return duplicateAtt
        End Get
        Set(ByVal Value As String)
            duplicateAtt = Value.Trim
        End Set
    End Property

    Property [variant]() As String
        Get
            Return variantAtt
        End Get
        Set(ByVal Value As String)
            variantAtt = Value.Trim
        End Set
    End Property

    Property name_formula() As String
        Get
            Return name_formulaAtt
        End Get
        Set(ByVal Value As String)
            name_formulaAtt = Value.Trim
        End Set
    End Property

    Property version() As String
        Get
            Return versionAtt
        End Get
        Set(ByVal Value As String)
            versionAtt = Value.Trim
        End Set
    End Property


    Property type() As String
        Get
            Return typeAtt
        End Get
        Set(ByVal Value As String)
            typeAtt = Value.Trim
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
    Property id_car() As Integer
        Get
            Return id_carAtt
        End Get
        Set(ByVal Value As Integer)
            id_carAtt = Value
        End Set
    End Property

    Property formulaImgPath() As String
        Get
            Return formulaImgPathAtt
        End Get
        Set(ByVal Value As String)
            formulaImgPathAtt = Value.Trim
        End Set
    End Property


    <JsonIgnore>
    Property otherPrice() As Decimal
        Get
            Return otherPriceAtt
        End Get
        Set(ByVal Value As Decimal)
            otherPriceAtt = Value
        End Set
    End Property


    <JsonIgnore>
    Property id_otherCurreny() As Integer
        Get
            Return id_otherCurrenyAtt
        End Get
        Set(ByVal Value As Integer)
            id_otherCurrenyAtt = Value
        End Set
    End Property


    <JsonIgnore>
    Property id_otherUnit() As Integer
        Get
            Return id_otherUnitAtt
        End Get
        Set(ByVal Value As Integer)
            id_otherUnitAtt = Value
        End Set
    End Property



    <JsonProperty("id_formulaXp")>
    Property id_formulaXpStr() As String
        Get
            Return id_formulaXpStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaXpStrAtt = Value
        End Set

    End Property

    <JsonProperty("id_formulaX2p")>
    Property id_formulaX2pStr() As String
        Get
            Return id_formulaX2pStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaX2pStrAtt = Value
        End Set

    End Property

    <JsonProperty("id_formulaYp")>
    Property id_formulaYpStr() As String
        Get
            Return id_formulaYpStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaYpStrAtt = Value
        End Set

    End Property

    <JsonProperty("id_formulaY2p")>
    Property id_formulaY2pStr() As String
        Get
            Return id_formulaY2pStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaY2pStrAtt = Value
        End Set

    End Property

    <JsonProperty("id_formulaZp")>
    Property id_formulaZpStr() As String
        Get
            Return id_formulaZpStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaZpStrAtt = Value
        End Set
    End Property

    <JsonProperty("id_formulaZ2p")>
    Property id_formulaZ2pStr() As String
        Get
            Return id_formulaZ2pStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaZ2pStrAtt = Value
        End Set
    End Property

    <JsonProperty("id_formulaY")>
    Property id_formulaYStr() As String
        Get
            Return id_formulaYStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaYStrAtt = Value
        End Set

    End Property

    <JsonProperty("id_formulaX")>
    Property id_formulaXStr() As String
        Get
            Return id_formulaXStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaXStrAtt = Value
        End Set
    End Property

    <JsonProperty("id_formulaZ")>
    Property id_formulaZStr() As String
        Get
            Return id_formulaZStrAtt
        End Get
        Set(ByVal Value As String)
            id_formulaZStrAtt = Value
        End Set
    End Property



    Property code_formulaXp() As String
        Get
            Return code_formulaXpAtt
        End Get
        Set(ByVal Value As String)
            code_formulaXpAtt = Value
        End Set

    End Property

    Property code_formulaXpp() As String
        Get
            Return code_formulaXppAtt
        End Get
        Set(ByVal Value As String)
            code_formulaXppAtt = Value
        End Set

    End Property

    Property code_formulaYp() As String
        Get
            Return code_formulaYpAtt
        End Get
        Set(ByVal Value As String)
            code_formulaYpAtt = Value
        End Set

    End Property

    Property code_formulaYpp() As String
        Get
            Return code_formulaYppAtt
        End Get
        Set(ByVal Value As String)
            code_formulaYppAtt = Value
        End Set

    End Property

    Property code_formulaZp() As String
        Get
            Return code_formulaZpAtt
        End Get
        Set(ByVal Value As String)
            code_formulaZpAtt = Value
        End Set
    End Property

    Property code_formulaZpp() As String
        Get
            Return code_formulaZppAtt
        End Get
        Set(ByVal Value As String)
            code_formulaZppAtt = Value
        End Set
    End Property

    Property code_formulaY() As String
        Get
            Return code_formulaYAtt
        End Get
        Set(ByVal Value As String)
            code_formulaYAtt = Value
        End Set

    End Property

    Property code_formulaX() As String
        Get
            Return code_formulaXAtt
        End Get
        Set(ByVal Value As String)
            code_formulaXAtt = Value
        End Set
    End Property

    Property code_formulaZ() As String
        Get
            Return code_formulaZAtt
        End Get
        Set(ByVal Value As String)
            code_formulaZAtt = Value
        End Set
    End Property

End Class
