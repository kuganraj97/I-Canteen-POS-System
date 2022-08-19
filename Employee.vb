Public Class Employee 

    Private Sub Employee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CanteenDataSet.Employee' table. You can move, or remove it, as needed.
        Me.WindowState = FormWindowState.Maximized
        Me.EmployeeTableAdapter.Fill(Me.CanteenDataSet.Employee)
        Dim time As DateTime = DateTime.Now
        Dim format As String = "dddddddd, d MMM yyyy HH:mm"
        Label6.Text = time.ToString(format)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            Me.EmployeeBindingSource.AddNew()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try
            EmployeeBindingSource.RemoveCurrent()


            Me.GridView1.PostEditor()
            EmployeeBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.CanteenDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Try


            Me.GridView1.PostEditor()
            EmployeeBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.CanteenDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        Employee_Load(e, e)

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim MainMenu As New MainMenu
        MainMenu.Show()
        Threading.Thread.Sleep(100)
        Me.Close()
    End Sub

    
End Class