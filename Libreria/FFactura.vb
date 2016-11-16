Public Class FFactura

    Private Sub FFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet.PEDIDO' Puede moverla o quitarla según sea necesario.
        Me.PEDIDOTableAdapter.Fill(Me.BDLibreriaDataSet.PEDIDO)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class