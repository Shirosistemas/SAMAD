Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rCargos
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Dim db As New samadEntities
        Me.DataSource = db.cargos.ToList()
    End Sub
End Class