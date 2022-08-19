Public Class items
    Private itemID As String, categoryName As String, categoryID As String, itemName As String, itemPrice As Decimal, orderID As Integer


    Public Property uitemID As String

        Get

            Return itemID

        End Get

        Set(ByVal value As String)

            itemID = value

        End Set

    End Property

    Public Property ucategoryName As String

        Get

            Return categoryName

        End Get

        Set(ByVal value As String)

            categoryName = value

        End Set

    End Property

    Public Property ucategoryID As String

        Get

            Return categoryID

        End Get

        Set(ByVal value As String)

            categoryID = value

        End Set

    End Property

    Public Property uitemName As String

        Get

            Return itemName

        End Get

        Set(ByVal value As String)

            itemName = value

        End Set

    End Property

    Public Property uitemPrice As String

        Get

            Return itemPrice

        End Get

        Set(ByVal value As String)

            itemPrice = value

        End Set

    End Property

 
End Class

