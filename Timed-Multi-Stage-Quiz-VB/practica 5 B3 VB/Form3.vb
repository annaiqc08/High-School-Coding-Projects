Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbr7_1.Checked = False
        rbr7_2.Checked = False
        rbr7_3.Checked = False
        rbr8_1.Checked = False
        rbr8_2.Checked = False
        rbr8_3.Checked = False
        rbr9_1.Checked = False
        rbr9_2.Checked = False
        rbr9_3.Checked = False
        tiempo3.Interval = 100
        tiempo3.Start()
        Form1.tiempos3 = 30
    End Sub

    Private Sub rbr7_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr7_1.Click
        If Form1.pulsar = 9 Then
            btsiguiente3.Visible = True
        End If
        rbr7_2.Enabled = False
        rbr7_3.Enabled = False
        lblcorrecta7_1.Visible = True
    End Sub

    Private Sub rbr7_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr7_2.Click
        If Form1.pulsar = 9 Then
            btsiguiente3.Visible = True
        End If
        rbr7_1.Enabled = False
        rbr7_3.Enabled = False
        lblincorrecta7_2.Visible = True
    End Sub

    Private Sub rbr7_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr7_3.Click
        If Form1.pulsar = 9 Then
            btsiguiente3.Visible = True
        End If
        rbr7_1.Enabled = False
        rbr7_2.Enabled = False
        lblincorrecta7_3.Visible = True
    End Sub

    Private Sub rbr8_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr8_1.Click
        If Form1.pulsar = 9 Then
            btsiguiente3.Visible = True
        End If
        rbr8_2.Enabled = False
        rbr8_3.Enabled = False
        lblcorrecta8_1.Visible = True
    End Sub

    Private Sub rbr8_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr8_2.Click
        If Form1.pulsar = 9 Then
            btsiguiente3.Visible = True
        End If
        rbr8_1.Enabled = False
        rbr8_3.Enabled = False
        lblincorrecta8_2.Visible = True
    End Sub

    Private Sub rbr8_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr8_3.Click
        If Form1.pulsar = 9 Then
            btsiguiente3.Visible = True
        End If
        rbr8_1.Enabled = False
        rbr8_2.Enabled = False
        lblincorrecta8_3.Visible = True
    End Sub

    Private Sub rbr9_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr9_1.Click
        If Form1.pulsar = 9 Then
            btsiguiente3.Visible = True
        End If
        rbr9_2.Enabled = False
        rbr9_3.Enabled = False
        lblcorrecta9_1.Visible = True
    End Sub

    Private Sub rbr9_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr9_2.Click
        rbr9_1.Enabled = False
        rbr9_3.Enabled = False
        lblincorrecta9_2.Visible = True
    End Sub

    Private Sub rbr9_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr9_3.Click
        If Form1.pulsar = 9 Then
            btsiguiente3.Visible = True
        End If
        rbr9_1.Enabled = False
        rbr9_3.Enabled = False
        lblincorrecta9_3.Visible = True
    End Sub

    Private Sub btsiguiente3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsiguiente3.Click
        If rbr7_1.Checked = True Then
            Form1.punteo = Form1.punteo + 5
        End If
        If rbr8_1.Checked = True Then
            Form1.punteo = Form1.punteo + 5
        End If
        If rbr9_1.Checked = True Then
            Form1.punteo = Form1.punteo + 5
        End If
        Form1.conteo = Form1.punteo + Form1.punteo
        Me.Hide()
        form4.Show()
    End Sub

    Private Sub tiempo3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo3.Tick
        If Form1.tiempos3 > -1 Then
            Label4.Text = Form1.tiempos3
            Form1.tiempos3 = Form1.tiempos3 - 1
        Else
            For b = 1 To 3
                gbrespuesta7.Controls("rbr7_" & b).Enabled = False
                gbrespuesta8.Controls("rbr8_" & b).Enabled = False
                gbrespuesta9.Controls("rbr9_" & b).Enabled = False
            Next
            tiempo3.Stop()
            Form1.tiempos3 = 30
            MsgBox("Tiempo Expirado")
        End If
    End Sub
End Class