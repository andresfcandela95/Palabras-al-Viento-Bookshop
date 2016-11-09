Public Class loginus

    Private Sub loginus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.Fill(Me.BDLibreriaDataSet.CLIENTES)
        'TODO: esta línea de código carga datos en la tabla 'BDLibreriaDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PEDIDO.TextBox2.Text = Me.TextBox1.Text
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Solicitud ID" Then
            Label2.Visible = False
            TextBox1.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            Button3.Visible = True
        End If
        If ComboBox1.SelectedItem = "Invitado" Then
            Label2.Visible = True
            TextBox1.Visible = True
            Button1.Visible = True
            Button2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            Button3.Visible = False
        End If
        If ComboBox1.SelectedItem = "Cliente" Then
            Label2.Visible = False
            TextBox1.Visible = False
            Button1.Visible = False
            Button2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            Button3.Visible = False
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PEDIDO.TextBox2.Text = Me.TextBox2.Text
        PEDIDO.TextBox3.Text = Me.TextBox3.Text
        PEDIDO.TextBox4.Text = Me.TextBox4.Text
        PEDIDO.TextBox2.Enabled = False
        PEDIDO.TextBox3.Enabled = False
        PEDIDO.TextBox4.Enabled = False
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ID.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        PEDIDO.Show()
    End Sub
End Class