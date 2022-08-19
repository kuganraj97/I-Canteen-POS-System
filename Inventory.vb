Public Class Inventory 

    Private Sub Inventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CanteenDataSet.CategoryItem' table. You can move, or remove it, as needed.
        Me.WindowState = FormWindowState.Maximized
        Me.CategoryItemTableAdapter.Fill(Me.CanteenDataSet.CategoryItem)
        Dim time As DateTime = DateTime.Now
        Dim format As String = "dddddddd, d MMM yyyy HH:mm"
        Label6.Text = time.ToString(format)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            CategoryItemBindingSource.ResetAllowNew()
            CategoryItemBindingSource.AddNew()
            Me.CategoryItemTableAdapter.Update(CanteenDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try
            CategoryItemBindingSource.EndEdit()
            Me.CategoryItemTableAdapter.Update(CanteenDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Try
            CategoryItemBindingSource.RemoveCurrent()
            Me.CategoryItemTableAdapter.Update(CanteenDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Controls.Clear()
        InitializeComponent()
        Inventory_Load(e, e)
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim MainMenu As New MainMenu
        MainMenu.Show()
        Threading.Thread.Sleep(100)
        Me.Close()
    End Sub

End Class

