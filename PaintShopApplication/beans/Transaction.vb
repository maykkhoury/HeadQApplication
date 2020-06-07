Public Class Transaction
    Private id_transactionAtt As Integer

    Private transactionDateAtt As Date

    Private discountAtt As Decimal

    Private amountAtt As Decimal

    Private id_currenyAtt As Integer


    Property id_transaction() As Integer
        Get
            Return id_transactionAtt
        End Get
        Set(ByVal Value As Integer)
            id_transactionAtt = Value
        End Set
    End Property


    Property transactionDate() As Date
        Get
            Return transactionDateAtt
        End Get
        Set(ByVal Value As Date)
            transactionDateAtt = Value
        End Set
    End Property


    Property discount() As Decimal
        Get
            Return discountAtt
        End Get
        Set(ByVal Value As Decimal)
            discountAtt = Value
        End Set
    End Property


    Property amount() As Decimal
        Get
            Return amountAtt
        End Get
        Set(ByVal Value As Decimal)
            amountAtt = Value
        End Set
    End Property


    Property id_curreny() As Integer
        Get
            Return id_currenyAtt
        End Get
        Set(ByVal Value As Integer)
            id_currenyAtt = Value
        End Set
    End Property


End Class
