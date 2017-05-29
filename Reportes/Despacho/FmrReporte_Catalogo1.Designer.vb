<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrReporte_Catalogo1
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Prueba_Nuevo_Catalogo2 = New SAMAD.Prueba_Nuevo_Catalogo()
        Me.CatalogoReporte_012 = New SAMAD.CatalogoReporte_01()
        Me.CatalogoReporte_011 = New SAMAD.CatalogoReporte_01()
        Me.Prueba_Nuevo_Catalogo1 = New SAMAD.Prueba_Nuevo_Catalogo()
        Me.CatalogoReporte_013 = New SAMAD.CatalogoReporte_01()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CatalogoReporte_013
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(926, 581)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FmrReporte_Catalogo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 581)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FmrReporte_Catalogo1"
        Me.Text = "FmrReporte_Catalogo1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CatalogoReporte_011 As SAMAD.CatalogoReporte_01
    Friend WithEvents Prueba_Nuevo_Catalogo1 As SAMAD.Prueba_Nuevo_Catalogo
    Friend WithEvents CatalogoReporte_012 As SAMAD.CatalogoReporte_01
    Friend WithEvents Prueba_Nuevo_Catalogo2 As SAMAD.Prueba_Nuevo_Catalogo
    Friend WithEvents CatalogoReporte_013 As SAMAD.CatalogoReporte_01
End Class
