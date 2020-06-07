Imports Newtonsoft.Json

Public Class Garage
    Private id_garageAtt As Integer
    Private id_garageStrAtt As String

    Private id_languageAtt As Integer
    Private id_languageStrAtt As String

    Private name_responsibleAtt As String

    Private garage_nameAtt As String
    Private locationAtt As String
    Private logoAtt As String

    Private key1Att As String
    Private usernameAtt As String

    Private chosenAtt As Boolean
    Private chosenStrAtt As String

    Private apply_equationDBValueAtt As String

    Private apply_equationAtt As Boolean
    Private apply_equation2Att As Boolean
    Private apply_equation3Att As Boolean
    Private apply_equation4Att As Boolean
    Private apply_equation5Att As Boolean
    Private apply_equation6Att As Boolean

    Private versionAtt As String
    Private telAtt As String
    Private keyAtt As String
    Private coatAtt As String
    
    Private showAlternativeNameDBValueAtt As String
    Private showAlternativeNameAtt As Boolean
    Private showAlternativeNameAtt2 As Boolean
    Private themeColorAtt As String
    Private actionTypeAtt As String

    Property actionType() As String
        Get
            Return actionTypeAtt
        End Get
        Set(ByVal Value As String)
            actionTypeAtt = Value
        End Set
    End Property

    <JsonProperty("apply_equation")>
    Property apply_equationDBValue() As String
        Get
            Return apply_equationDBValueAtt
        End Get
        Set(ByVal Value As String)
            apply_equationDBValueAtt = Value
        End Set
    End Property

    <JsonProperty("showAlternativeName")>
    Property showAlternativeNameDBValue() As String
        Get
            Return showAlternativeNameDBValueAtt
        End Get
        Set(ByVal Value As String)
            showAlternativeNameDBValueAtt = Value
        End Set
    End Property


    Property key1() As String
        Get
            Return key1Att
        End Get
        Set(ByVal Value As String)
            key1Att = Value
        End Set
    End Property

    <JsonProperty("theme_color")>
    Property themeColor() As String
        Get
            Return themeColorAtt
        End Get
        Set(ByVal Value As String)
            themeColorAtt = Value
        End Set
    End Property


    Property tel() As String
        Get
            Return telAtt
        End Get
        Set(ByVal Value As String)
            telAtt = Value
        End Set
    End Property


    Property key() As String
        Get
            Return keyAtt
        End Get
        Set(ByVal Value As String)
            keyAtt = Value
        End Set
    End Property


    Property username() As String
        Get
            Return usernameAtt
        End Get
        Set(ByVal Value As String)
            usernameAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property showAlternativeName() As Boolean
        Get
            Return showAlternativeNameAtt
        End Get
        Set(ByVal Value As Boolean)
            showAlternativeNameAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property showAlternativeName2() As Boolean
        Get
            Return showAlternativeNameAtt2
        End Get
        Set(ByVal Value As Boolean)
            showAlternativeNameAtt2 = Value
        End Set
    End Property


    Property coat() As String
        Get
            Return coatAtt
        End Get
        Set(ByVal Value As String)
            coatAtt = Value
        End Set
    End Property


    Property version() As String
        Get
            Return versionAtt
        End Get
        Set(ByVal Value As String)
            versionAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property apply_equation6() As Boolean
        Get
            Return apply_equation6Att
        End Get
        Set(ByVal Value As Boolean)
            apply_equation6Att = Value
        End Set

    End Property

    <JsonIgnore>
    Property apply_equation5() As Boolean
        Get
            Return apply_equation5Att
        End Get
        Set(ByVal Value As Boolean)
            apply_equation5Att = Value
        End Set

    End Property

    <JsonIgnore>
    Property apply_equation3() As Boolean
        Get
            Return apply_equation3Att
        End Get
        Set(ByVal Value As Boolean)
            apply_equation3Att = Value
        End Set
    End Property

    <JsonIgnore>
    Property apply_equation4() As Boolean
        Get
            Return apply_equation4Att
        End Get
        Set(ByVal Value As Boolean)
            apply_equation4Att = Value
        End Set
    End Property

    <JsonIgnore>
    Property apply_equation() As Boolean
        Get
            Return apply_equationAtt
        End Get
        Set(ByVal Value As Boolean)
            apply_equationAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property apply_equation2() As Boolean
        Get
            Return apply_equation2Att
        End Get
        Set(ByVal Value As Boolean)
            apply_equation2Att = Value
        End Set
    End Property

    Property garage_name() As String
        Get
            Return garage_nameAtt
        End Get
        Set(ByVal Value As String)
            garage_nameAtt = Value
        End Set
    End Property


    Property location() As String
        Get
            Return locationAtt
        End Get
        Set(ByVal Value As String)
            locationAtt = Value
        End Set
    End Property


    Property logo() As String
        Get
            Return logoAtt
        End Get
        Set(ByVal Value As String)
            logoAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property chosen() As Boolean
        Get
            Return chosenAtt
        End Get
        Set(ByVal Value As Boolean)
            chosenAtt = Value
        End Set
    End Property

    <JsonProperty("chosen")>
    Property chosenStr() As String
        Get
            Return chosenStrAtt
        End Get
        Set(ByVal Value As String)
            chosenStrAtt = Value
        End Set
    End Property


    <JsonIgnore>
    Property id_garage() As Integer
        Get
            Return id_garageAtt
        End Get
        Set(ByVal Value As Integer)
            id_garageAtt = Value
        End Set
    End Property

    <JsonProperty("id_garage")>
    Property id_garageStr() As String
        Get
            Return id_garageStrAtt
        End Get
        Set(ByVal Value As String)
            id_garageStrAtt = Value
        End Set
    End Property

    <JsonIgnore>
    Property id_language() As Integer
        Get
            Return id_languageAtt
        End Get
        Set(ByVal Value As Integer)
            id_languageAtt = Value
        End Set
    End Property

    <JsonProperty("id_language")>
    Property id_languageStr() As String
        Get
            Return id_languageStrAtt
        End Get
        Set(ByVal Value As String)
            id_languageStrAtt = Value
        End Set
    End Property

    Property name_responsible() As String
        Get
            Return name_responsibleAtt
        End Get
        Set(ByVal Value As String)
            name_responsibleAtt = Value
        End Set
    End Property


End Class
