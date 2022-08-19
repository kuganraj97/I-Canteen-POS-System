Public Class UserControl1


    Public Sub New(arow As DataRow)

        ' This call is required by the designer.
        InitializeComponent()
        row = arow
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public row As DataRow
    Private categoryName As String, itemName As String

    Public Property ucategoryName As String

        Get

            Return categoryName

        End Get

        Set(ByVal value As String)

            Label1.Text = value

        End Set

    End Property

   

    Public Property uitemName As String

        Get

            Return Label2.Text

        End Get

        Set(ByVal value As String)

            Label2.Text = value

        End Set

    End Property

    Public Event Uc1_DoubleClick(row As DataRow)

    Private Sub UserControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles MyBase.DoubleClick
        RaiseEvent Uc1_DoubleClick(row)
    End Sub


End Class
