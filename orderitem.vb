Public Class orderitem
    Private itemID As String, itemName As String, TID As String, orderID As Integer, price As Decimal, quantity As Integer, totalprice As Decimal, Dates As DateTime


        Public Property aitemID As String

            Get

                Return itemID

            End Get

            Set(ByVal value As String)

                itemID = value

            End Set

        End Property

        Public Property aitemName As String

            Get

                Return itemName

            End Get

            Set(ByVal value As String)

                itemName = value

            End Set

        End Property

        Public Property aprice As Decimal

            Get

                Return price

            End Get

            Set(ByVal value As Decimal)

                price = value

            End Set

        End Property

    Public Property aTID As String

        Get

            Return TID

        End Get

        Set(ByVal value As String)

            TID = value

        End Set

    End Property

    Public Property aorderID As String

        Get

            Return orderID

        End Get

        Set(ByVal value As String)

            orderID = value

        End Set

    End Property

    Public Property aquantity As Integer

        Get

            Return quantity

        End Get

        Set(ByVal value As Integer)

            quantity = value

        End Set

    End Property

    Public Property atotalprice As Decimal

        Get

            Return totalprice

        End Get

        Set(ByVal value As Decimal)

            totalprice = value

        End Set

    End Property

    Public Property aDate As DateTime

        Get

            Return Dates

        End Get

        Set(ByVal value As DateTime)

            Dates = value

        End Set

    End Property
    End Class
