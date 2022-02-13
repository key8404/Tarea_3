Public Class FORM1
    Private Sub CBCOMPRA_CheckedChanged(sender As Object, e As EventArgs) Handles CBVENTA.TextChanged, CBCOMPRA.CheckedChanged
        If CBCOMPRA.Checked = True Then
            TextCOMPRA.Enabled = True
        Else
            TextCOMPRA.Enabled = False

        End If
    End Sub

    Private Sub CBVENTA_CheckedChanged(sender As Object, e As EventArgs) Handles CBVENTA.CheckedChanged
        If CBVENTA.Checked = True Then
            TextVENTA.Enabled = True
        Else
            TextVENTA.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿desea salir de la aplicacion?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End

        End If
    End Sub



End Class
