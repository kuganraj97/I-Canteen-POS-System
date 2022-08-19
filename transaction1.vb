Imports DevExpress.XtraReports.UI
Imports DevExpress.LookAndFeel
Public Class transaction1

    Private Sub transaction1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TransactionssTableAdapter.Fill(Me.CanteenDataSet.Transactionss)
        Me.TransactionItemsTableAdapter.Fill(Me.CanteenDataSet.TransactionItems)
        Me.EmployeeTableAdapter.Fill(Me.CanteenDataSet.Employee)
        Me.DataTable2TableAdapter.Fill(Me.CanteenDataSet.DataTable2)
        Me.DataTable3TableAdapter1.Fill(Me.CanteenDataSet.DataTable3)


        DateEdit2.EditValue = DateTime.Now
        DateEdit5.EditValue = DateTime.Now
        DateEdit3.EditValue = DateTime.Now
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Controls.Clear()
        InitializeComponent()
        transaction1_Load(e, e)
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim back As New MainMenu()
        back.Show()
        Threading.Thread.Sleep(100)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim DateEdit4 As DateTime = New DateTime(DateEdit4.Year, DateEdit4.Month, DateEdit4.Day, 0, 0, 0)
        Dim DateEdit3 As DateTime = New DateTime(DateEdit3.Year, DateEdit3.Month, DateEdit3.Day, 23, 59, 59)
        Me.DataTable2TableAdapter.FillByDate(Me.CanteenDataSet.DataTable2, Me.DateEdit4.DateTime, Me.DateEdit3.DateTime)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim DateEdit1 As DateTime = New DateTime(DateEdit1.Year, DateEdit1.Month, DateEdit1.Day, 0, 0, 0)
        Dim DateEdit2 As DateTime = New DateTime(DateEdit2.Year, DateEdit2.Month, DateEdit2.Day, 23, 59, 59)
        Me.TransactionItemsTableAdapter.FillByDate(Me.CanteenDataSet.TransactionItems, Me.DateEdit1.DateTime, Me.DateEdit2.DateTime)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim DateEdit5 As DateTime = New DateTime(DateEdit5.Year, DateEdit5.Month, DateEdit5.Day, 23, 59, 59)
        Dim DateEdit6 As DateTime = New DateTime(DateEdit6.Year, DateEdit6.Month, DateEdit6.Day, 0, 0, 0)
        Me.DataTable3TableAdapter1.FillBy(Me.CanteenDataSet.DataTable3, Me.DateEdit6.DateTime, Me.DateEdit5.DateTime)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim report As New XtraReport3(DateEdit1.DateTime, DateEdit2.DateTime)
        Dim report1 As New XtraReport1(DateEdit6.DateTime, DateEdit5.DateTime)
        Dim report2 As New XtraReport2(DateEdit4.DateTime, DateEdit3.DateTime)
        If TabControl1.SelectedIndex = 1 Then

            report.ShowPreview()
        End If
        If TabControl1.SelectedIndex = 2 Then

            report1.ShowPreview()
        End If
        If TabControl1.SelectedIndex = 0 Then

            report2.ShowPreview()
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim report As New XtraReport3(DateEdit1.DateTime, DateEdit2.DateTime)
        Dim report1 As New XtraReport1(DateEdit6.DateTime, DateEdit5.DateTime)
        Dim report2 As New XtraReport2(DateEdit4.DateTime, DateEdit3.DateTime)
        If TabControl1.SelectedIndex = 1 Then

            report.Print()
        End If
        If TabControl1.SelectedIndex = 2 Then

            report1.Print()
        End If
        If TabControl1.SelectedIndex = 0 Then

            report2.Print()
        End If
    End Sub

    Private Sub DateEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateEdit1.EditValueChanged

    End Sub

    Private Sub RibbonControl1_Click(sender As System.Object, e As System.EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub TabPage2_Click(sender As System.Object, e As System.EventArgs) Handles TabPage2.Click

    End Sub
End Class