Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FORM1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FORM1.COMPRADOLAR.Checked Then
            Label1.Text = "la cantidad de tu compra es: " + Str(calcularcompra(FORM1.TextCOMPRA.Text, TCDOLAR)) + "DÒLARES"
        End If
        If FORM1.COMPRAEURO.Checked Then
            Label1.Text = "la cantidad de tu compra es: " + Str(calcularcompra(FORM1.TextCOMPRA.Text, TCEURO)) + "EUROS"
        End If
        If FORM1.COMPRACCR.Checked Then
            Label1.Text = "la cantidad de tu compra es: " + Str(calcularcompra(FORM1.TextCOMPRA.Text, TCCCR)) + "COLONOS"
        End If
        If FORM1.COMPRAPM.Checked Then
            Label1.Text = "la cantidad de tu compra es: " + Str(calcularcompra(FORM1.TextCOMPRA.Text, TCPM)) + "PESOS MEXICANOS"
        End If
        'OTRO IF QUE VERIFIQUE QUE TIPO DE CAMBIO SE ESTA VENDIENDO

    End Sub
End Class