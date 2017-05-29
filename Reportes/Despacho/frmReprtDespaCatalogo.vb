Public Class frmReprtDespaCatalogo

    Private Sub frmReprtDespaCatalogo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Function CrystalReportViewer1() As Object
        Throw New NotImplementedException
    End Function

End Class