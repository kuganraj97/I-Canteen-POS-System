Public Class transaction
    Private EID As String, TID As String, Balance As Decimal, totalAmount As Decimal


    Public Property aEID As String

        Get

            Return EID

        End Get

        Set(ByVal value As String)

            EID = value

        End Set

    End Property

    Public Property bTID As String

        Get

            Return TID

        End Get

        Set(ByVal value As String)

            TID = value

        End Set

    End Property

    Public Property aBalance As Decimal

        Get

            Return Balance

        End Get

        Set(ByVal value As Decimal)

            Balance = value

        End Set

    End Property

    Public Property agtotalprice As Decimal

        Get

            Return totalAmount

        End Get

        Set(ByVal value As Decimal)

            totalAmount = value

        End Set

    End Property
End Class
