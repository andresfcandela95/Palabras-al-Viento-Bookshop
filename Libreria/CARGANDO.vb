Public Class CARGANDO

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vistaFilaActual As DataRowView
        Dim NL As String = Environment.NewLine
        If (MessageBox.Show("¿Generar factura?" & NL, "Borrar",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
         DialogResult.Yes) Then
            vistaFilaActual = BindingSource1.Current
            vistaFilaActual.Row.Delete()
            BindingSource1.Position = BindingSource1.Count - 1
        End If
    End Sub

    Private Sub CARGANDO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet.PEDIDO' Puede moverla o quitarla según sea necesario.
        Me.PEDIDOTableAdapter.Fill(Me.BDLibreriaDataSet.PEDIDO)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (BDLibreriaDataSet.HasChanges()) Then
            Me.PEDIDOTableAdapter.Update(BDLibreriaDataSet.PEDIDO)
            MessageBox.Show("Su solicitud a sido exitosa, a continuacion se generara su factura.")
            Me.Hide()
            FFactura.Show()
        End If
        BindingSource1.Position = 0
    End Sub
End Class