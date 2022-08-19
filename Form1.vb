Public Class Login

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CanteenDataSet.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.CanteenDataSet.Admin)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim menu As New MainMenu()
        menu.Show()
    End Sub
End Class
