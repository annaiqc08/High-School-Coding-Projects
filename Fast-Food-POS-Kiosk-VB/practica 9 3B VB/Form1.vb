Public Class Form1
    Public suma, a, ultimo, ultimo2, seleccionado As Integer
    Public Function totalizar()
        For a = 0 To lvalor.Items.Count - 1
            suma = suma + lvalor.Items(a)
        Next
        txttotal.Text = suma
        suma = 0
    End Function

    Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.Click
        ldescripcion.Items.Add("Hamburguesa Simple")
        lvalor.Items.Add(10)
        totalizar()
    End Sub

    Private Sub bt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2.Click
        ldescripcion.Items.Add("Quesoburguesa")
        lvalor.Items.Add(20)
        totalizar()
    End Sub

    Private Sub bt3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt3.Click
        ldescripcion.Items.Add("Cuarto de Libra")
        lvalor.Items.Add(25)
        totalizar()
    End Sub

    Private Sub bt4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt4.Click
        ldescripcion.Items.Add("De Pollo")
        lvalor.Items.Add(20)
        totalizar()
    End Sub

    Private Sub bt10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt10.Click
        ldescripcion.Items.Add("Pie de Queso")
        lvalor.Items.Add(10)
        totalizar()
    End Sub

    Private Sub bt11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt11.Click
        ldescripcion.Items.Add("Helado")
        lvalor.Items.Add(15)
        totalizar()
    End Sub

    Private Sub bt5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt5.Click
        If rbp1.Checked = True Then
            ldescripcion.Items.Add("Papas Pequeñas")
            lvalor.Items.Add(8)
            totalizar()
        Else
            If rbm1.Checked = True Then
                ldescripcion.Items.Add("Papas Medianas")
                lvalor.Items.Add(10)
                totalizar()
            Else
                If rbg1.Checked = True Then
                    ldescripcion.Items.Add("Papas Grandes")
                    lvalor.Items.Add(12)
                    totalizar()
                End If
            End If
        End If
    End Sub

    Private Sub bt6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt6.Click
        If rbp2.Checked = True Then
            ldescripcion.Items.Add("Papas Pequeñas con Queso")
            lvalor.Items.Add(10)
            totalizar()
        Else
            If rbm2.Checked = True Then
                ldescripcion.Items.Add("Papas Medianas con Queso")
                lvalor.Items.Add(15)
                totalizar()
            Else
                If rbg2.Checked = True Then
                    ldescripcion.Items.Add("Papas Grandes con Queso")
                    lvalor.Items.Add(20)
                    totalizar()
                End If
            End If
        End If
    End Sub

    Private Sub bt7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt7.Click
        If rbp3.Checked = True Then
            ldescripcion.Items.Add("Coca Cola Pequeña")
            lvalor.Items.Add(7)
            totalizar()
        Else
            If rbm3.Checked = True Then
                ldescripcion.Items.Add("Coca Cola Mediana")
                lvalor.Items.Add(9)
                totalizar()
            Else
                If rbg3.Checked = True Then
                    ldescripcion.Items.Add("Coca Cola Grande")
                    lvalor.Items.Add(11)
                    totalizar()
                End If
            End If
        End If
    End Sub

    Private Sub bt8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt8.Click
        If rbp3.Checked = True Then
            ldescripcion.Items.Add("Fanta Pequeña")
            lvalor.Items.Add(7)
            totalizar()
        Else
            If rbm3.Checked = True Then
                ldescripcion.Items.Add("Fanta Mediana")
                lvalor.Items.Add(9)
                totalizar()
            Else
                If rbg3.Checked = True Then
                    ldescripcion.Items.Add("Fanta Grande")
                    lvalor.Items.Add(11)
                    totalizar()
                End If
            End If
        End If
    End Sub

    Private Sub bt9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt9.Click
        If rbp3.Checked = True Then
            ldescripcion.Items.Add("Sprite Pequeña")
            lvalor.Items.Add(7)
            totalizar()
        Else
            If rbm3.Checked = True Then
                ldescripcion.Items.Add("Sprite Mediana")
                lvalor.Items.Add(9)
                totalizar()
            Else
                If rbg3.Checked = True Then
                    ldescripcion.Items.Add("Sprite Grande")
                    lvalor.Items.Add(11)
                    totalizar()
                End If
            End If
        End If
    End Sub

    Private Sub bt12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt12.Click
        ultimo = ldescripcion.Items.Count - 1
        ldescripcion.Items.RemoveAt(ultimo)
        ultimo = lvalor.Items.Count - 1
        lvalor.Items.RemoveAt(ultimo)
        totalizar()
    End Sub

    Private Sub bt13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt13.Click
        seleccionado = ldescripcion.SelectedIndex
        ldescripcion.Items.RemoveAt(seleccionado)
        lvalor.Items.RemoveAt(seleccionado)
        totalizar()
    End Sub

    Private Sub bt14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt14.Click
        ldescripcion.Items.Clear()
        lvalor.Items.Clear()
        txttotal.Text = ""
    End Sub

    Private Sub bt15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt15.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class