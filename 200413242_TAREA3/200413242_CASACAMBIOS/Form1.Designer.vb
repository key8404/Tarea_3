<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBCOMPRA = New System.Windows.Forms.CheckBox()
        Me.CBVENTA = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextCOMPRA = New System.Windows.Forms.TextBox()
        Me.TextVENTA = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.COMPRADOLAR = New System.Windows.Forms.RadioButton()
        Me.COMPRAPM = New System.Windows.Forms.RadioButton()
        Me.COMPRAEURO = New System.Windows.Forms.RadioButton()
        Me.COMPRACCR = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.VENTACCR = New System.Windows.Forms.RadioButton()
        Me.VENTAEURO = New System.Windows.Forms.RadioButton()
        Me.VENTAPM = New System.Windows.Forms.RadioButton()
        Me.VENTADOLAR = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Controls.Add(Me.CBVENTA)
        Me.GroupBox1.Controls.Add(Me.CBCOMPRA)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSACCIONES"
        '
        'CBCOMPRA
        '
        Me.CBCOMPRA.AutoSize = True
        Me.CBCOMPRA.Location = New System.Drawing.Point(18, 20)
        Me.CBCOMPRA.Name = "CBCOMPRA"
        Me.CBCOMPRA.Size = New System.Drawing.Size(72, 17)
        Me.CBCOMPRA.TabIndex = 0
        Me.CBCOMPRA.Text = "COMPRA"
        Me.CBCOMPRA.UseVisualStyleBackColor = True
        '
        'CBVENTA
        '
        Me.CBVENTA.AutoSize = True
        Me.CBVENTA.Location = New System.Drawing.Point(18, 44)
        Me.CBVENTA.Name = "CBVENTA"
        Me.CBVENTA.Size = New System.Drawing.Size(62, 17)
        Me.CBVENTA.TabIndex = 1
        Me.CBVENTA.Text = "VENTA"
        Me.CBVENTA.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.OliveDrab
        Me.GroupBox2.Controls.Add(Me.TextVENTA)
        Me.GroupBox2.Controls.Add(Me.TextCOMPRA)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INGRESE CANTIDAD "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPRA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VENTA"
        '
        'TextCOMPRA
        '
        Me.TextCOMPRA.Enabled = False
        Me.TextCOMPRA.Location = New System.Drawing.Point(68, 17)
        Me.TextCOMPRA.Name = "TextCOMPRA"
        Me.TextCOMPRA.Size = New System.Drawing.Size(47, 20)
        Me.TextCOMPRA.TabIndex = 2
        '
        'TextVENTA
        '
        Me.TextVENTA.Enabled = False
        Me.TextVENTA.Location = New System.Drawing.Point(68, 48)
        Me.TextVENTA.Name = "TextVENTA"
        Me.TextVENTA.Size = New System.Drawing.Size(47, 20)
        Me.TextVENTA.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.MediumTurquoise
        Me.GroupBox3.Controls.Add(Me.COMPRACCR)
        Me.GroupBox3.Controls.Add(Me.COMPRAEURO)
        Me.GroupBox3.Controls.Add(Me.COMPRAPM)
        Me.GroupBox3.Controls.Add(Me.COMPRADOLAR)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 183)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COMPRA"
        '
        'COMPRADOLAR
        '
        Me.COMPRADOLAR.AutoSize = True
        Me.COMPRADOLAR.Location = New System.Drawing.Point(7, 20)
        Me.COMPRADOLAR.Name = "COMPRADOLAR"
        Me.COMPRADOLAR.Size = New System.Drawing.Size(62, 17)
        Me.COMPRADOLAR.TabIndex = 0
        Me.COMPRADOLAR.TabStop = True
        Me.COMPRADOLAR.Text = "DOLAR"
        Me.COMPRADOLAR.UseVisualStyleBackColor = True
        '
        'COMPRAPM
        '
        Me.COMPRAPM.AutoSize = True
        Me.COMPRAPM.Location = New System.Drawing.Point(7, 44)
        Me.COMPRAPM.Name = "COMPRAPM"
        Me.COMPRAPM.Size = New System.Drawing.Size(127, 17)
        Me.COMPRAPM.TabIndex = 1
        Me.COMPRAPM.TabStop = True
        Me.COMPRAPM.Text = "PESOS MEXICANOS"
        Me.COMPRAPM.UseVisualStyleBackColor = True
        '
        'COMPRAEURO
        '
        Me.COMPRAEURO.AutoSize = True
        Me.COMPRAEURO.Location = New System.Drawing.Point(7, 68)
        Me.COMPRAEURO.Name = "COMPRAEURO"
        Me.COMPRAEURO.Size = New System.Drawing.Size(63, 17)
        Me.COMPRAEURO.TabIndex = 2
        Me.COMPRAEURO.TabStop = True
        Me.COMPRAEURO.Text = "EUROS"
        Me.COMPRAEURO.UseVisualStyleBackColor = True
        '
        'COMPRACCR
        '
        Me.COMPRACCR.AutoSize = True
        Me.COMPRACCR.Location = New System.Drawing.Point(7, 92)
        Me.COMPRACCR.Name = "COMPRACCR"
        Me.COMPRACCR.Size = New System.Drawing.Size(88, 17)
        Me.COMPRACCR.TabIndex = 3
        Me.COMPRACCR.TabStop = True
        Me.COMPRACCR.Text = "COLONO CR"
        Me.COMPRACCR.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Blue
        Me.GroupBox4.Controls.Add(Me.VENTACCR)
        Me.GroupBox4.Controls.Add(Me.VENTAEURO)
        Me.GroupBox4.Controls.Add(Me.VENTAPM)
        Me.GroupBox4.Controls.Add(Me.VENTADOLAR)
        Me.GroupBox4.Location = New System.Drawing.Point(263, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 183)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "VENTA"
        '
        'VENTACCR
        '
        Me.VENTACCR.AutoSize = True
        Me.VENTACCR.Location = New System.Drawing.Point(7, 92)
        Me.VENTACCR.Name = "VENTACCR"
        Me.VENTACCR.Size = New System.Drawing.Size(88, 17)
        Me.VENTACCR.TabIndex = 3
        Me.VENTACCR.TabStop = True
        Me.VENTACCR.Text = "COLONO CR"
        Me.VENTACCR.UseVisualStyleBackColor = True
        '
        'VENTAEURO
        '
        Me.VENTAEURO.AutoSize = True
        Me.VENTAEURO.Location = New System.Drawing.Point(7, 68)
        Me.VENTAEURO.Name = "VENTAEURO"
        Me.VENTAEURO.Size = New System.Drawing.Size(63, 17)
        Me.VENTAEURO.TabIndex = 2
        Me.VENTAEURO.TabStop = True
        Me.VENTAEURO.Text = "EUROS"
        Me.VENTAEURO.UseVisualStyleBackColor = True
        '
        'VENTAPM
        '
        Me.VENTAPM.AutoSize = True
        Me.VENTAPM.Location = New System.Drawing.Point(7, 44)
        Me.VENTAPM.Name = "VENTAPM"
        Me.VENTAPM.Size = New System.Drawing.Size(127, 17)
        Me.VENTAPM.TabIndex = 1
        Me.VENTAPM.TabStop = True
        Me.VENTAPM.Text = "PESOS MEXICANOS"
        Me.VENTAPM.UseVisualStyleBackColor = True
        '
        'VENTADOLAR
        '
        Me.VENTADOLAR.AutoSize = True
        Me.VENTADOLAR.Location = New System.Drawing.Point(7, 20)
        Me.VENTADOLAR.Name = "VENTADOLAR"
        Me.VENTADOLAR.Size = New System.Drawing.Size(62, 17)
        Me.VENTADOLAR.TabIndex = 0
        Me.VENTADOLAR.TabStop = True
        Me.VENTADOLAR.Text = "DOLAR"
        Me.VENTADOLAR.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "COMFIRMAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(34, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Red
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Location = New System.Drawing.Point(512, 157)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 158)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "QUE DESA HACER"
        '
        'FORM1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FORM1"
        Me.Text = "CASA CAMBIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBVENTA As CheckBox
    Friend WithEvents CBCOMPRA As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextVENTA As TextBox
    Friend WithEvents TextCOMPRA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents COMPRACCR As RadioButton
    Friend WithEvents COMPRAEURO As RadioButton
    Friend WithEvents COMPRAPM As RadioButton
    Friend WithEvents COMPRADOLAR As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents VENTACCR As RadioButton
    Friend WithEvents VENTAEURO As RadioButton
    Friend WithEvents VENTAPM As RadioButton
    Friend WithEvents VENTADOLAR As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox5 As GroupBox
End Class
