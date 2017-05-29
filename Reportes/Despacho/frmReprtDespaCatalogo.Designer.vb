<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReprtDespaCatalogo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportCatABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespachoCab = New SAMAD.DespachoCab()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ReportCatABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespachoCab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportCatABindingSource
        '
        Me.ReportCatABindingSource.DataMember = "ReportCatA"
        Me.ReportCatABindingSource.DataSource = Me.DespachoCab
        '
        'DespachoCab
        '
        Me.DespachoCab.DataSetName = "DespachoCab"
        Me.DespachoCab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReportCatABindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SAMAD.RepDespCatalaogo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(935, 603)
        Me.ReportViewer1.TabIndex = 0
        '
        'frmReprtDespaCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 605)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReprtDespaCatalogo"
        Me.Text = "frmReprtDespaCatalogo"
        CType(Me.ReportCatABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespachoCab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportCatABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespachoCab As SAMAD.DespachoCab
End Class
