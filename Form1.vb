

Public Class Form1

    Public Bin, Hexa, Oct As String
    Public Numero, Dec As Integer

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim Bin, Hexa, Oct As String
        Dim Numero, Dec As Integer
        If Nombre_operacion.Text = "Decimal" Then
            Numero = Convert.ToInt32(Valor.Text)

            'decimal a binario
            Bin = Convert.ToString(Numero, 2)
            Binario.Text = Bin
            'decimal a hexadecimal
            Hexa = Hex(Numero)
            Hexadecimal.Text = Hexa
            'decimal a octal
            Oct = Convert.ToString(Numero, 8)
            Octadecimal.Text = Oct
            'Decimal a binario
            Dec = Numero
            Decima.Text = Dec

        ElseIf Nombre_operacion.Text = "Binario" Then
            Numero = Convert.ToInt32(Valor.Text)

            ' binario
            Bin = Valor.Text
            Binario.Text = Bin

            'Binario a decimal
            Dec = Convert.ToInt32(Bin, 2)
            Decima.Text = Dec

            'decimal a hexadecimal
            Hexa = Convert.ToString(Dec, 16).ToUpper()
            Hexadecimal.Text = Hexa
            'decimal a octal
            Oct = Convert.ToString(Dec, 8)
            Octadecimal.Text = Oct

        ElseIf Nombre_operacion.Text = "Hexadecimal" Then

            ' Hexadecimal
            Hexa = Valor.Text
            Hexadecimal.Text = Hexa

            'Hexadecimal a decimal
            Dec = Convert.ToInt32(Hexa, 16)
            Decima.Text = Dec

            'decimal a Binario
            Bin = Convert.ToString(Dec, 2)
            Binario.Text = Bin
            'decimal a octal
            Oct = Convert.ToString(Dec, 8)
            Octadecimal.Text = Oct

        ElseIf Nombre_operacion.Text = "Octadecimal" Then

            ' Octadecimal
            Oct = Valor.Text
            Octadecimal.Text = Oct

            'Octadecimal a decimal
            Dec = Convert.ToInt32(Oct, 8)
            Decima.Text = Dec

            'decimal a Binario
            Bin = Convert.ToString(Dec, 2)
            Binario.Text = Bin
            'decimal a Hexadecimal
            Hexa = Convert.ToString(Dec, 16).ToUpper()
            Hexadecimal.Text = Hexa

        Else
            MsgBox("Opcion no encontrada")

        End If



    End Sub
    Private Sub BinarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinarioToolStripMenuItem.Click


        If Nombre_operacion.Text = "Decimal" Then
            Numero = Convert.ToInt32(Valor.Text)

            'decimal a binario
            Bin = Convert.ToString(Numero, 2)
            Binario.Text = Bin

        ElseIf Nombre_operacion.Text = "Binario" Then

            ' binario
            Bin = Valor.Text
            Binario.Text = Bin

        ElseIf Nombre_operacion.Text = "Hexadecimal" Then

            ' Hexadecimal
            Hexa = Valor.Text
            'Hexadecimal a decimal
            Dec = Convert.ToInt32(Hexa, 16)
            'decimal a Binario
            Bin = Convert.ToString(Dec, 2)
            Binario.Text = Bin

        ElseIf Nombre_operacion.Text = "Octadecimal" Then

            ' Octadecimal
            Oct = Valor.Text
            'Octadecimal a decimal
            Dec = Convert.ToInt32(Oct, 8)
            'decimal a Binario
            Bin = Convert.ToString(Dec, 2)
            Binario.Text = Bin


        Else
            MsgBox("Opcion no encontrada")

        End If



    End Sub

    Private Sub HexadecimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HexadecimalToolStripMenuItem.Click
        'decimal a Hexadecimal


        If Nombre_operacion.Text = "Decimal" Then
            Numero = Convert.ToInt32(Valor.Text)
            'decimal a hexadecimal
            Hexa = Hex(Numero)
            Hexadecimal.Text = Hexa

        ElseIf Nombre_operacion.Text = "Binario" Then

            ' binario
            Bin = Valor.Text
            'Binario a decimal
            Dec = Convert.ToInt32(Bin, 2)
            'decimal a hexadecimal
            Hexa = Convert.ToString(Dec, 16).ToUpper()
            Hexadecimal.Text = Hexa

        ElseIf Nombre_operacion.Text = "Hexadecimal" Then

            ' Hexadecimal
            Hexa = Valor.Text
            Hexadecimal.Text = Hexa

        ElseIf Nombre_operacion.Text = "Octadecimal" Then

            ' Octadecimal
            Oct = Valor.Text
            'Octadecimal a decimal
            Dec = Convert.ToInt32(Oct, 8)
            'decimal a Hexadecimal
            Hexa = Convert.ToString(Dec, 16).ToUpper()
            Hexadecimal.Text = Hexa

        Else
            MsgBox("Opcion no encontrada")

        End If
    End Sub

    Private Sub OctadecimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OctadecimalToolStripMenuItem.Click

        If Nombre_operacion.Text = "Decimal" Then
            Numero = Convert.ToInt32(Valor.Text)
            'decimal a octal
            Oct = Convert.ToString(Numero, 8)
            Octadecimal.Text = Oct

        ElseIf Nombre_operacion.Text = "Binario" Then
            Numero = Convert.ToInt32(Valor.Text)

            ' binario
            Bin = Numero.ToString()
            'Binario a decimal
            Dec = Convert.ToInt32(Bin, 2)
            'decimal a octal
            Oct = Convert.ToString(Dec, 8)
            Octadecimal.Text = Oct

        ElseIf Nombre_operacion.Text = "Hexadecimal" Then

            ' Hexadecimal
            Hexa = Valor.Text
            'Hexadecimal a decimal
            Dec = Convert.ToInt32(Hexa, 16)
            'decimal a octal
            Oct = Convert.ToString(Dec, 8)
            Octadecimal.Text = Oct

        ElseIf Nombre_operacion.Text = "Octadecimal" Then

            ' Octadecimal
            Oct = Valor.Text
            Octadecimal.Text = Oct

        Else
            MsgBox("Opcion no encontrada")

        End If
    End Sub

    Private Sub DecimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecimalToolStripMenuItem.Click
        'decimal


        If Nombre_operacion.Text = "Decimal" Then
            Numero = Convert.ToInt32(Valor.Text)
            Dec = Numero
            Decima.Text = Dec

        ElseIf Nombre_operacion.Text = "Binario" Then
            Numero = Convert.ToInt32(Valor.Text)

            ' binario
            Bin = Numero.ToString()
            'Binario a decimal
            Dec = Convert.ToInt32(Bin, 2)
            Decima.Text = Dec


        ElseIf Nombre_operacion.Text = "Hexadecimal" Then

            ' Hexadecimal
            Hexa = Valor.Text
            'Hexadecimal a decimal
            Dec = Convert.ToInt32(Hexa, 16)
            Decima.Text = Dec

        ElseIf Nombre_operacion.Text = "Octadecimal" Then

            ' Octadecimal
            Oct = Valor.Text
            'Octadecimal a decimal
            Dec = Convert.ToInt32(Oct, 8)
            Decima.Text = Dec


        Else
            MsgBox("Opcion no encontrada")

        End If
    End Sub



    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        'limpiar espacios
        Binario.Text = ""
        Hexadecimal.Text = ""
        Octadecimal.Text = ""
        Decima.Text = ""
    End Sub


End Class
