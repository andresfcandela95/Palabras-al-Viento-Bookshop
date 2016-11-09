Public Class admin

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PEDIDOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BDLibreriaDataSet)

    End Sub

    Private Sub admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet1.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.Fill(Me.BDLibreriaDataSet1.CLIENTES)
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet1.CREATEUSER' Puede moverla o quitarla según sea necesario.
        Me.CREATEUSERTableAdapter.Fill(Me.BDLibreriaDataSet1.CREATEUSER)
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet1.CREATEUSER' Puede moverla o quitarla según sea necesario.
        Me.CREATEUSERTableAdapter.Fill(Me.BDLibreriaDataSet1.CREATEUSER)
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet1.LIBRO' Puede moverla o quitarla según sea necesario.
        Me.LIBROTableAdapter.Fill(Me.BDLibreriaDataSet1.LIBRO)
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet1.PEDIDO' Puede moverla o quitarla según sea necesario.
        Me.PEDIDOTableAdapter1.Fill(Me.BDLibreriaDataSet1.PEDIDO)
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet1.PEDIDO' Puede moverla o quitarla según sea necesario.
        Me.PEDIDOTableAdapter1.Fill(Me.BDLibreriaDataSet1.PEDIDO)
       

    End Sub

    Private Sub PEDIDOBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PEDIDOBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.BDLibreriaDataSet1)

    End Sub

    Private Sub PEDIDOBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEDIDOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PEDIDOBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.BDLibreriaDataSet1)

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosToolStripMenuItem.Click
        BindingNavigator2.Visible = False
        BindingNavigator1.Visible = False
        PEDIDODataGridView.Visible = True
        CREATEUSERDataGridView.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        Button2.Visible = False

        Button1.Visible = False
    End Sub

    Private Sub AñadirLibrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirLibrosToolStripMenuItem.Click
        BindingNavigator2.Visible = False
        BindingNavigator1.Visible = True
        PEDIDODataGridView.Visible = False
        CREATEUSERDataGridView.Visible = False
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        Button1.Visible = True
        Button2.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (BDLibreriaDataSet1.HasChanges()) Then
            Me.LIBROTableAdapter.Update(BDLibreriaDataSet1.LIBRO)
            MessageBox.Show("Base de datos actualizada")
        End If
        BindingSource1.Position = 0
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        usuario.Show()
        Me.Hide()
    End Sub

    Private Sub SolicitudIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudIDToolStripMenuItem.Click
        BindingNavigator2.Visible = False
        BindingNavigator1.Visible = False
        CREATEUSERDataGridView.Visible = True
        PEDIDODataGridView.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        Button1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub CreacionIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreacionIDToolStripMenuItem.Click
        BindingNavigator2.Visible = True
        BindingNavigator1.Visible = False
        CREATEUSERDataGridView.Visible = False
        PEDIDODataGridView.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox11.Visible = True
        TextBox12.Visible = True
        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (BDLibreriaDataSet1.HasChanges()) Then
            Me.CLIENTESTableAdapter.Update(BDLibreriaDataSet1.CLIENTES)
            MessageBox.Show("Usuario creado con exito")
        End If
        BindingSource1.Position = 0
    End Sub

    Private Sub BindingNavigatorAddNewItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem2.Click
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        TextBox11.Enabled = True
        TextBox12.Enabled = True
    End Sub
End Class