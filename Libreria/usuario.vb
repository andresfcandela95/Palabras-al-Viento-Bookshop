Public Class usuario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Los campos se encuentran vacios")
        Else
            If TextBox1.Text = "" Then
                MsgBox("El campo USUARIO se encuentra vacio")
            Else
                If TextBox2.Text = "" Then
                    MsgBox("El campo CONTRASEÑA se encuentra vacio")
                Else
                    If TextBox1.Text = "admin" And TextBox2.Text = "123456" Then
                        Me.Hide()
                        admin.Show()
                    Else
                        MsgBox("Los datos son incorrectos")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Administrador" Then
            Label2.Visible = True
            Label3.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            Button1.Visible = True
            Button2.Visible = False
            Button9.Visible = True
        End If
        If ComboBox1.SelectedItem = "Cliente" Then
            Button2.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            Button1.Visible = False
            Button9.Visible = True

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        inicio.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub
End Class