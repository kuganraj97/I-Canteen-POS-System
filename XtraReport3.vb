Public Class XtraReport3
    Public Sub New(startdate1 As DateTime, enddate1 As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        startdate = startdate1
        enddate = enddate1
        ' Add any initialization after the InitializeComponent() call.
        Me.TransactionItemsTableAdapter.FillByDate(Me.CanteenDataSet1.TransactionItems, startdate, enddate)
    End Sub
    Public enddate As DateTime
    Public startdate As DateTime

    Private Sub XtraReport2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.DesignerLoaded

    End Sub
End Class