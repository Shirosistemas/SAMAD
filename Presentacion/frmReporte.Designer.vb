<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Me.ReporteDespachoC1 = New SAMAD.ReporteDespachoC()
        Me.Viewer = New Telerik.ReportViewer.WinForms.ReportViewer()
        CType(Me.ReporteDespachoC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteDespachoC1
        '
        Me.ReporteDespachoC1.Name = "ReporteDespachoC"
        '
        'Viewer
        '
        Me.Viewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Viewer.AutoSize = True
        Me.Viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Viewer.Location = New System.Drawing.Point(1, 1)
        Me.Viewer.Margin = New System.Windows.Forms.Padding(5)
        Me.Viewer.Name = "Viewer"
        Me.Viewer.Size = New System.Drawing.Size(897, 533)
        Me.Viewer.TabIndex = 0
        Me.Viewer.ZoomMode = Telerik.ReportViewer.WinForms.ZoomMode.FullPage
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 533)
        Me.Controls.Add(Me.Viewer)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReporte"
        Me.Text = "frmReporte"
        CType(Me.ReporteDespachoC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Viewer As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents ReporteDespachoC1 As SAMAD.ReporteDespachoC
End Class
