Imports DevExpress.XtraCharts

Public Class MainMenu

    Private Sub MainMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CanteenDataSet.CatTrans2' table. You can move, or remove it, as needed.
        Me.CatTrans2TableAdapter.Fill(Me.CanteenDataSet.CatTrans2)
        'TODO: This line of code loads data into the 'CanteenDataSet.CatTrans' table. You can move, or remove it, as needed.
        Me.CatTransTableAdapter.Fill(Me.CanteenDataSet.CatTrans)
        'TODO: This line of code loads data into the 'CanteenDataSet.TransactionItems' table. You can move, or remove it, as needed.
        Me.TransactionItemsTableAdapter.Fill(Me.CanteenDataSet.TransactionItems)
        'TODO: This line of code loads data into the 'CanteenDataSet.Transactionss' table. You can move, or remove it, as needed.
        Me.TransactionssTableAdapter.Fill(Me.CanteenDataSet.Transactionss)


        Dim time As DateTime = DateTime.Now
        Dim format As String = "dddddddd, d MMM yyyy HH:mm"
        Label2.Text = time.ToString(format)

    

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim Menu As New Menu
        Menu.Show()
        Threading.Thread.Sleep(100)
        Me.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim Employee As New Employee
        Employee.Show()
        Threading.Thread.Sleep(100)
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim Inventory As New Inventory
        Inventory.Show()
        Threading.Thread.Sleep(100)
        Me.Close()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MainMenu_Load(e, e) '

    End Sub



    Private Sub BarButtonItem6_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim result As DialogResult = MessageBox.Show("Confirm Close?", _
                              "I-Canteen", _
                              MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (result = DialogResult.OK) Then
            Application.Exit()
            End
        End If

    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim Transaction As New transaction1
        Transaction.Show()
        Threading.Thread.Sleep(100)
        Me.Close()
    End Sub

  
    Private Sub ChartControl1_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class