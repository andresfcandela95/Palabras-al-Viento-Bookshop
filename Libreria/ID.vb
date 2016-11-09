Public Class ID

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        loginus.Show()
    End Sub

    Private Sub ID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet.CREATEUSER' Puede moverla o quitarla según sea necesario.
        Me.CREATEUSERTableAdapter.Fill(Me.BDLibreriaDataSet.CREATEUSER)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (BDLibreriaDataSet.HasChanges()) Then
            Me.CREATEUSERTableAdapter.Update(BDLibreriaDataSet.CREATEUSER)
            MessageBox.Show("Su solicitud a sido exitosa, recuerde que a su correo llegara la informacion solicitada en un lapso de 2 a 3 días.")
            Me.Hide()
            inicio.Show()
        End If
        BindingSource1.Position = 0
    End Sub


    Private Sub BindingNavigatorAddNewItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
    End Sub
End Class