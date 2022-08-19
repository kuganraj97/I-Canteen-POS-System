<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CanteenDataSet = New canteenTestUpdated.CanteenDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmployeeTableAdapter = New canteenTestUpdated.CanteenDataSetTableAdapters.EmployeeTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CanteenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        '
        '
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1604, 142)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "New"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Delete"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Save"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Refresh"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.LargeGlyph = CType(resources.GetObject("BarButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Home"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.LargeGlyph = CType(resources.GetObject("BarButtonItem5.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup4, Me.RibbonPageGroup5, Me.RibbonPageGroup6, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Employee"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "                                 "
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "                              "
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "                               "
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "                               "
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "                              "
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EmployeeBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 139)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1604, 690)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.CanteenDataSet
        '
        'CanteenDataSet
        '
        Me.CanteenDataSet.DataSetName = "CanteenDataSet"
        Me.CanteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEID, Me.colName, Me.colBalance, Me.colDepartment})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colEID
        '
        Me.colEID.FieldName = "EID"
        Me.colEID.Name = "colEID"
        Me.colEID.Visible = True
        Me.colEID.VisibleIndex = 0
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        '
        'colBalance
        '
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 2
        '
        'colDepartment
        '
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 3
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1420, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Label6"
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 827)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Employee"
        Me.Text = "Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CanteenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CanteenDataSet As canteenTestUpdated.CanteenDataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As canteenTestUpdated.CanteenDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents colEID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
