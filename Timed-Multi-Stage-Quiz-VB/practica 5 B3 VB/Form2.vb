Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbr4_1.Checked = False
        rbr4_2.Checked = False
        rbr4_3.Checked = False
        rbr5_1.Checked = False
        rbr5_2.Checked = False
        rbr5_3.Checked = False
        rbr6_1.Checked = False
        rbr6_2.Checked = False
        rbr6_3.Checked = False
        tiempo2.Interval = 100
        tiempo2.Start()
        Form1.tiempos2 = 30
    End Sub

    Private Sub rbr4_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr4_1.Click
        If Form1.pulsar = 6 Then
            btsiguiente2.Visible = True
        End If
        rbr4_2.Enabled = False
        rbr4_3.Enabled = False
        lblincorrecta4_1.Visible = True
    End Sub

    Private Sub rbr4_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr4_2.Click
        If Form1.pulsar = 6 Then
            btsiguiente2.Visible = True
        End If
        rbr4_1.Enabled = False
        rbr4_3.Enabled = False
        lblcorrecta4_2.Visible = True
    End Sub

    Private Sub rbr4_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr4_3.Click
        If Form1.pulsar = 6 Then
            btsiguiente2.Visible = True
        End If
        rbr4_1.Enabled = False
        rbr4_2.Enabled = False
        lblincorrecta4_3.Visible = True
    End Sub

    Private Sub rbr5_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr5_1.Click
        If Form1.pulsar = 6 Then
            btsiguiente2.Visible = True
        End If
        rbr5_2.Enabled = False
        rbr5_3.Enabled = False
        lblcorrecta5_1.Visible = True
    End Sub

    Private Sub rbr5_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr5_2.Click
        If Form1.pulsar = 6 Then
            btsiguiente2.Visible = True
        End If
        rbr5_1.Enabled = False
        rbr5_3.Enabled = False
        lblincorrecta5_2.Visible = True
    End Sub

    Private Sub rbr5_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr5_3.Click
        If Form1.pulsar = 6 Then
            btsiguiente2.Visible = True
        End If
        rbr5_1.Enabled = False
        rbr5_2.Enabled = False
        lblincorrecta5_3.Visible = True
    End Sub

    Private Sub rbr6_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr6_1.Click
        If Form1.pulsar = 6 Then
            btsiguiente2.Visible = True
        End If
        rbr6_2.Enabled = False
        rbr6_3.Enabled = False
        lblincorrecta6_1.Visible = True
    End Sub

    Private Sub rbr6_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr6_2.Click
        If Form1.pulsar = 6 Then
            btsiguiente2.Visible = True
        End If
        rbr6_1.Enabled = False
        rbr6_3.Enabled = False
        lblcorrecta6_2.Visible = True
    End Sub

    Private Sub rbr6_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr6_3.Click
        If Form1.pulsar = 6 Then
            btsiguiente2.Visible = True
        End If
        rbr6_1.Enabled = False
        rbr6_2.Enabled = False
        lblincorrecta6_3.Visible = True
    End Sub

    Private Sub btsiguiente2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsiguiente2.Click
        If rbr4_2.Checked = True Then
            Form1.punteo = Form1.punteo + 5
        End If
        If rbr5_1.Checked = True Then
            Form1.punteo = Form1.punteo + 5
        End If
        If rbr6_2.Checked = True Then
            Form1.punteo = Form1.punteo + 5
        End If
        Form1.conteo = Form1.punteo + Form1.punteo
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub tiempo2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo2.Tick
        If Form1.tiempos2 > -1 Then
            Label4.Text = Form1.tiempos2
            Form1.tiempos2 = Form1.tiempos2 - 1
        Else
            For a = 1 To 3
                gbrespuesta4.Controls("rbr4_" & a).Enabled = False
                gbrespuesta5.Controls("rbr5_" & a).Enabled = False
                gbrespuesta6.Controls("rbr6_" & a).Enabled = False
            Next
            tiempo2.Stop()
            Form1.tiempos2 = 30
            MsgBox("Tiempo Expirado")
        End If
    End Sub
End Class