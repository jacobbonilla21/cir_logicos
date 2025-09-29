Public Class Form1
    Public Bin, Hexa, Oct As String
    Public Numero, Dec As Integer
    Private toolTip As New ToolTip() ' Declarar el ToolTip correctamente

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el ToolTip
        toolTip.AutoPopDelay = 5000
        toolTip.InitialDelay = 500
        toolTip.ReshowDelay = 500
        toolTip.ShowAlways = True
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Function ValidarEntrada() As Boolean
        If String.IsNullOrEmpty(Valor.Text) Then
            MessageBox.Show("Por favor ingrese un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Try
            Select Case Nombre_operacion.Text
                Case "Decimal"
                    Dim num As Integer = Integer.Parse(Valor.Text)
                    If num < 0 Or num > 4095 Then
                        MessageBox.Show("El número decimal debe estar entre 0 y 4095 (12 bits máximo)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                Case "Binario"
                    'Validar que solo contenga 0s y 1s
                    For Each c As Char In Valor.Text
                        If c <> "0" AndAlso c <> "1" Then
                            MessageBox.Show("El número binario solo puede contener 0s y 1s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    Next
                    'Validar longitud máxima (12 bits)
                    If Valor.Text.Length > 12 Then
                        MessageBox.Show("El número binario no puede exceder 12 bits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    'Validar que no exceda 4095 en decimal
                    Dim decTemp As Integer = Convert.ToInt32(Valor.Text, 2)
                    If decTemp > 4095 Then
                        MessageBox.Show("El número binario excede el valor máximo de 12 bits (4095)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                Case "Hexadecimal"
                    'Validar formato hexadecimal
                    For Each c As Char In Valor.Text.ToUpper()
                        If Not Char.IsDigit(c) AndAlso (c < "A" Or c > "F") Then
                            MessageBox.Show("El número hexadecimal solo puede contener dígitos 0-9 y letras A-F", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    Next
                    'Validar que no exceda 12 bits
                    Dim decTempHex As Integer = Convert.ToInt32(Valor.Text, 16)
                    If decTempHex > 4095 Then
                        MessageBox.Show("El número hexadecimal excede el valor máximo de 12 bits (FFF = 4095)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                Case "Octadecimal"
                    'Validar formato octal
                    For Each c As Char In Valor.Text
                        If c < "0" Or c > "7" Then
                            MessageBox.Show("El número octal solo puede contener dígitos 0-7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    Next
                    'Validar que no exceda 12 bits
                    Dim decTempOct As Integer = Convert.ToInt32(Valor.Text, 8)
                    If decTempOct > 4095 Then
                        MessageBox.Show("El número octal excede el valor máximo de 12 bits (7777 = 4095)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                Case Else
                    MessageBox.Show("Seleccione un tipo de operación válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
            End Select

            Return True

        Catch ex As Exception
            MessageBox.Show($"Error en la validación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If Not ValidarEntrada() Then
            Return
        End If

        Try
            If Nombre_operacion.Text = "Decimal" Then
                Numero = Convert.ToInt32(Valor.Text)
                'decimal a binario (12 bits)
                Bin = Convert.ToString(Numero, 2).PadLeft(12, "0"c)
                Binario.Text = Bin
                'decimal a hexadecimal
                Hexa = Convert.ToString(Numero, 16).ToUpper()
                Hexadecimal.Text = Hexa
                'decimal a octal
                Oct = Convert.ToString(Numero, 8)
                Octadecimal.Text = Oct
                'Decimal
                Dec = Numero
                Decima.Text = Dec

            ElseIf Nombre_operacion.Text = "Binario" Then
                ' binario
                Bin = Valor.Text.PadLeft(12, "0"c)
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
                Hexa = Valor.Text.ToUpper()
                Hexadecimal.Text = Hexa
                'Hexadecimal a decimal
                Dec = Convert.ToInt32(Hexa, 16)
                Decima.Text = Dec
                'decimal a Binario (12 bits)
                Bin = Convert.ToString(Dec, 2).PadLeft(12, "0"c)
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
                'decimal a Binario (12 bits)
                Bin = Convert.ToString(Dec, 2).PadLeft(12, "0"c)
                Binario.Text = Bin
                'decimal a Hexadecimal
                Hexa = Convert.ToString(Dec, 16).ToUpper()
                Hexadecimal.Text = Hexa

            Else
                MessageBox.Show("Opción no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error en el cálculo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        'limpiar espacios
        Binario.Text = ""
        Hexadecimal.Text = ""
        Octadecimal.Text = ""
        Decima.Text = ""
        Valor.Text = ""
    End Sub

    'Evento para actualizar información cuando cambia la selección
    Private Sub Nombre_operacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nombre_operacion.SelectedIndexChanged
        'Limpiar campos al cambiar el tipo de operación
        Limpiar_Click(sender, e)

        'Mostrar información sobre restricciones usando ToolTip
        Select Case Nombre_operacion.Text
            Case "Decimal"
                toolTip.SetToolTip(Valor, "Ingrese un número entre 0 y 4095 (12 bits máximo)")
            Case "Binario"
                toolTip.SetToolTip(Valor, "Ingrese un número binario de hasta 12 bits (máximo 4095 en decimal)")
            Case "Hexadecimal"
                toolTip.SetToolTip(Valor, "Ingrese un número hexadecimal de hasta 3 dígitos (máximo FFF = 4095)")
            Case "Octadecimal"
                toolTip.SetToolTip(Valor, "Ingrese un número octal de hasta 4 dígitos (máximo 7777 = 4095)")
        End Select
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Dim menuForm As New menu_principal()
        menuForm.Show()
        Me.Close()
    End Sub
End Class