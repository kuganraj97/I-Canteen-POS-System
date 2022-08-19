<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CanteenDataSet = New canteenTestUpdated.CanteenDataSet()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdminTableAdapter = New canteenTestUpdated.CanteenDataSetTableAdapters.AdminTableAdapter()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CanteenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Password", True))
        Me.TextEdit2.Location = New System.Drawing.Point(119, 86)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(167, 20)
        Me.TextEdit2.TabIndex = 14
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.CanteenDataSet
        '
        'CanteenDataSet
        '
        Me.CanteenDataSet.DataSetName = "CanteenDataSet"
        Me.CanteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Username", True))
        Me.TextEdit1.Location = New System.Drawing.Point(119, 33)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(167, 20)
        Me.TextEdit1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(130, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 184)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CanteenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CanteenDataSet As canteenTestUpdated.CanteenDataSet
    Friend WithEvents AdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminTableAdapter As canteenTestUpdated.CanteenDataSetTableAdapters.AdminTableAdapter

End Class
