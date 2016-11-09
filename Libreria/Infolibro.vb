Public Class Infolibro

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Infolibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet.LIBRO' Puede moverla o quitarla según sea necesario.
        Me.LIBROTableAdapter.Fill(Me.BDLibreriaDataSet.LIBRO)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PEDIDO.TextBox10.Text = Me.TextBox2.Text
        PEDIDO.TextBox6.Text = Me.TextBox5.Text
        Me.Hide()
    End Sub

End Class