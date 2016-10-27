<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btmAmarillo = New System.Windows.Forms.Button()
        Me.btmRojo = New System.Windows.Forms.Button()
        Me.btmAzulClaro = New System.Windows.Forms.Button()
        Me.btmVerde = New System.Windows.Forms.Button()
        Me.btmRosa = New System.Windows.Forms.Button()
        Me.btmGris = New System.Windows.Forms.Button()
        Me.btmPurpura = New System.Windows.Forms.Button()
        Me.btmAzulOscuro = New System.Windows.Forms.Button()
        Me.pb0 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb4 = New System.Windows.Forms.PictureBox()
        Me.lbResultado = New System.Windows.Forms.Label()
        Me.btmBorrar = New System.Windows.Forms.Button()
        Me.btmInstruciones = New System.Windows.Forms.Button()
        Me.btmComprobar = New System.Windows.Forms.Button()
        CType(Me.pb0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btmAmarillo
        '
        Me.btmAmarillo.BackColor = System.Drawing.Color.Yellow
        Me.btmAmarillo.Location = New System.Drawing.Point(12, 12)
        Me.btmAmarillo.Name = "btmAmarillo"
        Me.btmAmarillo.Size = New System.Drawing.Size(25, 25)
        Me.btmAmarillo.TabIndex = 0
        Me.btmAmarillo.Tag = "1"
        Me.btmAmarillo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btmAmarillo.UseVisualStyleBackColor = False
        '
        'btmRojo
        '
        Me.btmRojo.BackColor = System.Drawing.Color.Red
        Me.btmRojo.Location = New System.Drawing.Point(43, 12)
        Me.btmRojo.Name = "btmRojo"
        Me.btmRojo.Size = New System.Drawing.Size(25, 25)
        Me.btmRojo.TabIndex = 1
        Me.btmRojo.Tag = "2"
        Me.btmRojo.UseVisualStyleBackColor = False
        '
        'btmAzulClaro
        '
        Me.btmAzulClaro.BackColor = System.Drawing.Color.Cyan
        Me.btmAzulClaro.Location = New System.Drawing.Point(105, 12)
        Me.btmAzulClaro.Name = "btmAzulClaro"
        Me.btmAzulClaro.Size = New System.Drawing.Size(25, 25)
        Me.btmAzulClaro.TabIndex = 3
        Me.btmAzulClaro.Tag = "4"
        Me.btmAzulClaro.UseVisualStyleBackColor = False
        '
        'btmVerde
        '
        Me.btmVerde.BackColor = System.Drawing.Color.Lime
        Me.btmVerde.Location = New System.Drawing.Point(74, 12)
        Me.btmVerde.Name = "btmVerde"
        Me.btmVerde.Size = New System.Drawing.Size(25, 25)
        Me.btmVerde.TabIndex = 2
        Me.btmVerde.Tag = "3"
        Me.btmVerde.UseVisualStyleBackColor = False
        '
        'btmRosa
        '
        Me.btmRosa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btmRosa.Location = New System.Drawing.Point(229, 12)
        Me.btmRosa.Name = "btmRosa"
        Me.btmRosa.Size = New System.Drawing.Size(25, 25)
        Me.btmRosa.TabIndex = 7
        Me.btmRosa.Tag = "8"
        Me.btmRosa.UseVisualStyleBackColor = False
        '
        'btmGris
        '
        Me.btmGris.BackColor = System.Drawing.Color.Silver
        Me.btmGris.Location = New System.Drawing.Point(198, 12)
        Me.btmGris.Name = "btmGris"
        Me.btmGris.Size = New System.Drawing.Size(25, 25)
        Me.btmGris.TabIndex = 6
        Me.btmGris.Tag = "7"
        Me.btmGris.UseVisualStyleBackColor = False
        '
        'btmPurpura
        '
        Me.btmPurpura.BackColor = System.Drawing.Color.Fuchsia
        Me.btmPurpura.Location = New System.Drawing.Point(167, 12)
        Me.btmPurpura.Name = "btmPurpura"
        Me.btmPurpura.Size = New System.Drawing.Size(25, 25)
        Me.btmPurpura.TabIndex = 5
        Me.btmPurpura.Tag = "6"
        Me.btmPurpura.UseVisualStyleBackColor = False
        '
        'btmAzulOscuro
        '
        Me.btmAzulOscuro.BackColor = System.Drawing.Color.Blue
        Me.btmAzulOscuro.Location = New System.Drawing.Point(136, 12)
        Me.btmAzulOscuro.Name = "btmAzulOscuro"
        Me.btmAzulOscuro.Size = New System.Drawing.Size(25, 25)
        Me.btmAzulOscuro.TabIndex = 4
        Me.btmAzulOscuro.Tag = "5"
        Me.btmAzulOscuro.UseVisualStyleBackColor = False
        '
        'pb0
        '
        Me.pb0.Location = New System.Drawing.Point(43, 198)
        Me.pb0.Name = "pb0"
        Me.pb0.Size = New System.Drawing.Size(25, 25)
        Me.pb0.TabIndex = 8
        Me.pb0.TabStop = False
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(74, 198)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(25, 25)
        Me.pb1.TabIndex = 9
        Me.pb1.TabStop = False
        '
        'pb3
        '
        Me.pb3.Location = New System.Drawing.Point(136, 198)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(25, 25)
        Me.pb3.TabIndex = 11
        Me.pb3.TabStop = False
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(105, 198)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(25, 25)
        Me.pb2.TabIndex = 10
        Me.pb2.TabStop = False
        '
        'pb4
        '
        Me.pb4.Location = New System.Drawing.Point(167, 198)
        Me.pb4.Name = "pb4"
        Me.pb4.Size = New System.Drawing.Size(25, 25)
        Me.pb4.TabIndex = 12
        Me.pb4.TabStop = False
        '
        'lbResultado
        '
        Me.lbResultado.AutoSize = True
        Me.lbResultado.Location = New System.Drawing.Point(102, 167)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(0, 13)
        Me.lbResultado.TabIndex = 83
        '
        'btmBorrar
        '
        Me.btmBorrar.Location = New System.Drawing.Point(198, 45)
        Me.btmBorrar.Name = "btmBorrar"
        Me.btmBorrar.Size = New System.Drawing.Size(56, 25)
        Me.btmBorrar.TabIndex = 84
        Me.btmBorrar.Text = "Borrar"
        Me.btmBorrar.UseVisualStyleBackColor = True
        '
        'btmInstruciones
        '
        Me.btmInstruciones.Location = New System.Drawing.Point(12, 45)
        Me.btmInstruciones.Name = "btmInstruciones"
        Me.btmInstruciones.Size = New System.Drawing.Size(87, 25)
        Me.btmInstruciones.TabIndex = 85
        Me.btmInstruciones.Text = "Instrucciones"
        Me.btmInstruciones.UseVisualStyleBackColor = True
        '
        'btmComprobar
        '
        Me.btmComprobar.Location = New System.Drawing.Point(117, 45)
        Me.btmComprobar.Name = "btmComprobar"
        Me.btmComprobar.Size = New System.Drawing.Size(75, 25)
        Me.btmComprobar.TabIndex = 86
        Me.btmComprobar.Text = "Comprobar"
        Me.btmComprobar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 325)
        Me.Controls.Add(Me.btmComprobar)
        Me.Controls.Add(Me.btmInstruciones)
        Me.Controls.Add(Me.btmBorrar)
        Me.Controls.Add(Me.lbResultado)
        Me.Controls.Add(Me.pb4)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.pb0)
        Me.Controls.Add(Me.btmRosa)
        Me.Controls.Add(Me.btmGris)
        Me.Controls.Add(Me.btmPurpura)
        Me.Controls.Add(Me.btmAzulOscuro)
        Me.Controls.Add(Me.btmAzulClaro)
        Me.Controls.Add(Me.btmVerde)
        Me.Controls.Add(Me.btmRojo)
        Me.Controls.Add(Me.btmAmarillo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterMind"
        CType(Me.pb0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btmAmarillo As System.Windows.Forms.Button
    Friend WithEvents btmRojo As System.Windows.Forms.Button
    Friend WithEvents btmAzulClaro As System.Windows.Forms.Button
    Friend WithEvents btmVerde As System.Windows.Forms.Button
    Friend WithEvents btmRosa As System.Windows.Forms.Button
    Friend WithEvents btmGris As System.Windows.Forms.Button
    Friend WithEvents btmPurpura As System.Windows.Forms.Button
    Friend WithEvents btmAzulOscuro As System.Windows.Forms.Button
    Friend WithEvents pb0 As System.Windows.Forms.PictureBox
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents pb3 As System.Windows.Forms.PictureBox
    Friend WithEvents pb2 As System.Windows.Forms.PictureBox
    Friend WithEvents pb4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbResultado As System.Windows.Forms.Label
    Friend WithEvents btmBorrar As System.Windows.Forms.Button
    Friend WithEvents btmInstruciones As System.Windows.Forms.Button
    Friend WithEvents btmComprobar As System.Windows.Forms.Button

End Class
