
Public Class PEDIDO


    Private Sub formulario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet2.PEDIDO' Puede moverla o quitarla según sea necesario.
        Me.PEDIDOTableAdapter2.Fill(Me.BDLibreriaDataSet2.PEDIDO)
        TextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        inicio.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Infolibro.Show()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Introduzca sólo valores númericos")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loginus.Show()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loginus.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (BDLibreriaDataSet2.HasChanges()) Then
            Me.PEDIDOTableAdapter2.Update(BDLibreriaDataSet2.PEDIDO)
            MessageBox.Show("Base de datos actualizada")
        End If
        BindingSource1.Position = 0
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        Button4.Visible = True
        Button3.Visible = True
    End Sub
End Class