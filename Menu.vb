Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid


Public Class Menu
   

    Private Sub Menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'CanteenDataSet.Orderitems' table. You can move, or remove it, as needed.
            Me.OrderitemsTableAdapter.Fill(Me.CanteenDataSet.Orderitems)
            'TODO: This line of code loads data into the 'CanteenDataSet.Transactionss' table. You can move, or remove it, as needed.
            Me.TransactionssTableAdapter.Fill(Me.CanteenDataSet.Transactionss)
            'TODO: This line of code loads data into the 'CanteenDataSet.TransactionItems' table. You can move, or remove it, as needed.
            Me.TransactionItemsTableAdapter.Fill(Me.CanteenDataSet.TransactionItems)


            Me.EmployeeTableAdapter.Fill(Me.CanteenDataSet.Employee)
            Me.CategoryItemTableAdapter.Fill(Me.CanteenDataSet.CategoryItem)

            Dim today As DateTime = DateTime.Now
            Dim tid As String
            Dim dt As String = today.ToString("yy")
            Dim dt3 As String = today.ToString("MM")
            Dim dt4 As String = today.ToString("dd")
            Dim y As String = today.ToString("HH")
            Dim y2 As String = today.ToString("mm")
            Dim y3 As String = today.ToString("ss")
            tid = ("MKN" + dt + dt3 + dt4 + y + y2 + y3)
            TextEdit9.Text = tid

            Dim time As DateTime = DateTime.Now
            Dim format As String = "dddddddd, d MMM yyyy HH:mm"
            Label7.Text = time.ToString(format)

            For Each row As DataRow In CanteenDataSet.CategoryItem.Rows
                '    Dim i As Integer = CanteenDataSet.CategoryItem.Rows.IndexOf(row)
                Dim ash As UserControl1 = New UserControl1(row)
                AddHandler ash.Uc1_DoubleClick, AddressOf UserControl1_DoubleClick
                ash.Label1.Text = row.Item("categoryName")
                ash.Label2.Text = row.Item("itemName")
                Panel2.Controls.Add(ash)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UserControl1_DoubleClick(row As DataRow)
        Try
            Dim i As Integer = Me.CanteenDataSet.CategoryItem.Rows.IndexOf(row)
            TextEdit1.Text = Me.CanteenDataSet.CategoryItem.Rows(i).Item("categoryID")
            TextEdit2.Text = Me.CanteenDataSet.CategoryItem.Rows(i).Item("categoryName")
            TextEdit3.Text = Me.CanteenDataSet.CategoryItem.Rows(i).Item("ItemID")
            TextEdit4.Text = Me.CanteenDataSet.CategoryItem.Rows(i).Item("ItemName")
            TextEdit5.Text = Me.CanteenDataSet.CategoryItem.Rows(i).Item("ItemPrice")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try

            If SpinEdit1.Value = 0 Then
                MessageBox.Show("Check Order", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim no As CanteenDataSet.OrderitemsRow = Me.CanteenDataSet.Orderitems.NewRow()
                Dim today2 As DateTime = DateTime.Now
                no.TID = Me.TextEdit9.Text
                no.itemName = Me.TextEdit4.Text
                no.itemID = Me.TextEdit3.Text
                no.price = Me.TextEdit5.Text
                no.quantity = Me.SpinEdit1.Text
                no.totalprice = CInt(SpinEdit1.Text) * CDec(TextEdit5.Text)
                no._Date = today2
                no.mDate = Date.Today

                Me.CanteenDataSet.Orderitems.Rows.Add(no)
                SpinEdit1.Value = 0
                Dim summaryValue = GridView1.Columns("totalprice").SummaryItem.SummaryValue
                TextEdit8.Text = "RM " & summaryValue
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim MainMenu As New MainMenu()
        MainMenu.Show()
        Threading.Thread.Sleep(100)
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Me.Controls.Clear()
        InitializeComponent()
        Menu_Load(e, e)
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Try
            Dim j As Integer = GridView1.FocusedRowHandle
            Me.CanteenDataSet.Orderitems.Rows.RemoveAt(j)
            Dim summaryValue = GridView1.Columns("totalprice").SummaryItem.SummaryValue
            TextEdit8.Text = "RM " & summaryValue
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try
            For Each dr As DataRow In Me.CanteenDataSet.Orderitems.Rows
                Me.CanteenDataSet.TransactionItems.ImportRow(dr)
            Next
            transactionitemsbindingsource.EndEdit()
            Me.TransactionItemsTableAdapter.Update(Me.CanteenDataSet)
            Dim no3 As CanteenDataSet.EmployeeRow = Me.CanteenDataSet.Employee.NewRow()
            no3.EID = TextEdit10.Text
            Dim findTheseVals1(0) As Object
            findTheseVals1(0) = TextEdit10.Text
            Dim i As DataRow = Me.CanteenDataSet.Employee.Rows.Find(findTheseVals1)
            Dim l As Integer = Me.CanteenDataSet.Employee.Rows.IndexOf(i)


            Dim today1 As DateTime = DateTime.Now
            Dim bal As Decimal = CDec(Me.CanteenDataSet.Employee.Rows(l).Item("Balance")) - CDec(TextEdit8.Text)
            Dim no2 As CanteenDataSet.TransactionssRow = Me.CanteenDataSet.Transactionss.NewRow()
            no2.Balance = bal
            no2.TID = TextEdit9.Text
            no2.EID = TextEdit10.Text
            no2.TotalAmount = TextEdit8.Text
            no2.Datec = today1
            no2.nDate = Date.Today
            Me.CanteenDataSet.Transactionss.Rows.Add(no2)

            Dim no4 As CanteenDataSet.EmployeeRow = CanteenDataSet.Employee.NewRow()
            Dim findTheseVals(0) As Object
            findTheseVals(0) = TextEdit10.Text
            Dim j As DataRow = Me.CanteenDataSet.Employee.Rows.Find(findTheseVals)
            Dim k As Integer = Me.CanteenDataSet.Employee.Rows.IndexOf(j)
            Me.CanteenDataSet.Employee.Rows(k)("Balance") = bal
            Me.EmployeeTableAdapter.Update(CanteenDataSet)
            Me.TransactionssTableAdapter.Update(CanteenDataSet)
            Dim bal2 As String = no2.Balance.ToString
            Dim eid2 As String = TextEdit10.Text
            Dim title As String = "ICanteen".ToString
            Dim b As String = eid2 & "'s Balance is RM " & no2.Balance
            MsgBox(b, MsgBoxStyle.OkOnly, title)
            Me.Controls.Clear()
            InitializeComponent()
            Menu_Load(e, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class