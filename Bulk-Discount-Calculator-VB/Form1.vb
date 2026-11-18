Public Class Form1
    Public d, t, pf, p, a, b, c, cc As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a = 10%
        b = 20%
        c = 40%
        cc = Val(txtca.Text)
        t = cc * 5000
        txTot.Text = t


        If (cc < 5) Then
            d = t * 0.1
            txtaho.Text = d
            txtde.Text = a

        ElseIf cc < 10 Then
            d = t * 0.2
            txtaho.Text = d
            txtde.Text = b
        ElseIf cc >= 10 Then
            d = t * 0.4
            txtaho.Text = d
            txtde.Text = c

        End If
        pf = t - d
        txtpre.Text = pf
    End Sub
End Class
