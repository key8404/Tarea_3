Module Module1
    Public TCDOLAR = 7.69
    Public TCPM = 0.38
    Public TCEURO = 7.89
    Public TCCCR = 0.012
    Const COMISIONCOMPRA = 2.5 / 100
    Const COMISIONVENTA = 3 / 100
    Dim total_parcial = 0
    Dim total
    Sub limpiar()
        FORM1.TextCOMPRA.Clear()
        FORM1.TextVENTA.Clear()
        FORM1.CBCOMPRA.Checked = False
        FORM1.CBVENTA.Checked = False
        Form2.Label1.Text = "LIMPIO"

    End Sub
    Function calcularcompra(cantidadCOMPRA As Double, tipoCOMPRA As Double) As Double
        If cantidadCOMPRA > 0 Then
            total_parcial = cantidadCOMPRA / tipoCOMPRA
            total = total_parcial * COMISIONCOMPRA + total_parcial

        End If
        Return Math.Round(total, 2)


    End Function
    Function calcularventa(cantidadVENTA As Double, tipoVENTA As Double) As Double
        If cantidadVENTA > 0 Then
            total_parcial = cantidadVENTA * tipoVENTA
            total = total_parcial * COMISIONVENTA + total_parcial

        End If
        Return Math.Round(total, 2)


    End Function
End Module
