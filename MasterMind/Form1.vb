Public Class Form1

    Dim num_filas As Integer = 10

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        crear_Tablero()

    End Sub

    Private Sub crear_Tablero()

        Dim i, j As Integer

        For i = 0 To num_filas

            Dim lb1 As New Label
            lb1.Size = New System.Drawing.Size(25, 25)
            lb1.Location = New System.Drawing.Point(305, 15 + (25 * i))
            lb1.Text = i
            lb1.Name = "lbPosicion" & i

            Me.Controls.Add(lb1)

            Dim lb2 As New Label
            lb2.Size = New System.Drawing.Size(25, 25)
            lb2.Location = New System.Drawing.Point(485, 15 + (25 * i))
            lb2.Text = "B: - N: -"
            lb2.Name = "lbBN" & i

            Me.Controls.Add(lb2)

            For j = 0 To 5
                Dim pb As New PictureBox
                pb.Size = New System.Drawing.Size(25, 25)
                pb.Location = New System.Drawing.Point(332 + (25 * j), 12 + (25 * i))
                pb.BackColor = Color.White
                pb.Name = "pbCasilla" & i & j


                Me.Controls.Add(pb)

            Next
        Next

    End Sub

    Private Sub btmInstruciones_Click(sender As System.Object, e As System.EventArgs) Handles btmInstruciones.Click

        MsgBox("¿Puedes acertar la secuencia en solo " + CStr(num_filas) + "?" & vbCrLf & "Selecciona los colores que quieras de los botones de la parte superior" & vbCrLf & "Negro: Es el color correcto en una posicion incorrecta" & vbCrLf & "Blanco es el color correcto en una posicion correcta", , "Instrucciones")

    End Sub
End Class
