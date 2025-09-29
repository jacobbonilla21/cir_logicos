Public Class cod_binario
    Private Sub cod_binario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Limpiar campos al cargar el formulario
        LimpiarCampos()

        'Configurar el ToolTip
        ToolTip1.AutoPopDelay = 10000  '5 segundos visible
        ToolTip1.InitialDelay = 500   'Medio segundo para aparecer
        ToolTip1.ReshowDelay = 500
        ToolTip1.ShowAlways = True    'Mostrar incluso si el form no está activo

        'Establecer el mensaje inicial
        ActualizarToolTip()
    End Sub

    Private Sub ActualizarToolTip()
        Dim mensaje As String = ""

        If Radio_Gray.Checked Then
            mensaje = "Máximo 6 bits permitidos para Código Gray"
        ElseIf Radio_Paridad.Checked Then
            mensaje = "Máximo 6 bits permitidos para Bit de Paridad"
        ElseIf Radio_Hamming.Checked Then
            mensaje = "Máximo 4 bits de datos permitidos para Código Hamming"
        End If

        'Asignar el tooltip al TextBox_Entrada
        ToolTip1.SetToolTip(TextBox_Entrada, mensaje)
    End Sub

    Private Sub Btn_VolverMenu_Click(sender As Object, e As EventArgs) Handles Btn_VolverMenu.Click
        Dim menuForm As New menu_principal()
        menuForm.Show()
        Me.Close()
    End Sub

    Private Function ValidarBinario(binario As String) As Boolean
        If String.IsNullOrEmpty(binario) Then
            MessageBox.Show("Por favor ingresa un número binario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        'Verificar que solo contenga 0s y 1s
        For Each c As Char In binario
            If c <> "0" AndAlso c <> "1" Then
                MessageBox.Show("Solo se permiten números binarios (0s y 1s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next

        'Verificar longitud máxima (6 bits como dice tu diseño)
        If binario.Length > 6 Then
            MessageBox.Show("Máximo 6 bits permitidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    '=== VARIABLES PARA ALMACENAR LOS PASOS ===
    Private pasosGray As New List(Of String)()
    Private pasosParidad As New List(Of String)()
    Private pasosHamming As New List(Of String)()

    Private Function ConvertirGray(binario As String) As String
        pasosGray.Clear()
        Dim gray As String = ""

        pasosGray.Add("Símbolo XOR: ⊕ → iguales = 0, diferentes = 1")
        pasosGray.Add("")
        pasosGray.Add("Cálculos...")

        'Cambiar al control normal
        CambiarControlResultado("Gray")

        'El primer bit siempre es igual
        gray += binario(0)
        Dim posicion As Integer = binario.Length - 1
        pasosGray.Add($"G{posicion} = B{posicion} = {binario(0)}")

        'Para los bits restantes
        For i As Integer = 1 To binario.Length - 1
            Dim bit1 As Integer = Integer.Parse(binario(i - 1).ToString())
            Dim bit2 As Integer = Integer.Parse(binario(i).ToString())
            Dim resultadoXOR As Integer = bit1 Xor bit2

            gray += resultadoXOR.ToString()

            posicion = binario.Length - 1 - i
            Dim posicionAnterior = posicion + 1

            pasosGray.Add($"G{posicion} = B{posicionAnterior} ⊕ B{posicion} = {bit1} ⊕ {bit2} = {resultadoXOR}")
        Next

        TextBox_Pasos.Text = String.Join(vbCrLf, pasosGray)
        TextBox_Resultado.Text = gray

        Return gray
    End Function

    Private Function CalcularParidad(binario As String) As String
        pasosParidad.Clear()
        Dim contadorUnos As Integer = 0

        'Cambiar al control con color
        CambiarControlResultado("Paridad")

        'Determinar si es paridad par o impar
        Dim esParidadPar As Boolean = Radio_ParidadPar.Checked

        pasosParidad.Add("Contando cantidad de unos (1)...")

        'Contar cantidad de unos
        For i As Integer = 0 To binario.Length - 1
            If binario(i) = "1"c Then
                contadorUnos += 1
            End If
            pasosParidad.Add($"Bit {i + 1}: {binario(i)} → Unos = {contadorUnos}")
        Next

        'Calcular bit de paridad según el tipo seleccionado
        Dim bitParidad As String
        If esParidadPar Then
            bitParidad = If(contadorUnos Mod 2 = 0, "0", "1")
        Else
            bitParidad = If(contadorUnos Mod 2 = 0, "1", "0")
        End If

        'Agregar el bit de paridad al inicio (MSB)
        Dim resultado As String = bitParidad & binario

        pasosParidad.Add("")
        pasosParidad.Add($"Total de unos: {contadorUnos}")
        pasosParidad.Add($"Bit de paridad: {bitParidad}")

        TextBox_Pasos.Text = String.Join(vbCrLf, pasosParidad)

        'Mostrar en RichTextBox con colores
        MostrarResultadoConColor(bitParidad, binario)

        Return resultado
    End Function

    Private Sub MostrarResultadoConColor(bitParidad As String, binario As String)
        RichTextBox_Resultado.Clear()

        'Bit de paridad en rojo
        RichTextBox_Resultado.SelectionColor = Color.Red
        RichTextBox_Resultado.AppendText(bitParidad)

        'Binario en negro
        RichTextBox_Resultado.SelectionColor = Color.Black
        RichTextBox_Resultado.AppendText(binario)
    End Sub

    Private Function ConvertirHamming(binario As String) As String
        pasosHamming.Clear()

        'Cambiar al control con color
        CambiarControlResultado("Hamming")

        'Para 4 bits de datos, necesitamos 3 bits de paridad (Hamming 7,4)
        Dim m As Integer = binario.Length
        Dim r As Integer = 0

        'Calcular número de bits de paridad necesarios
        Do While Math.Pow(2, r) < m + r + 1
            r += 1
        Loop

        Dim n As Integer = m + r
        Dim hamming(n) As Char
        Dim dataIndex As Integer = 0

        'Mostrar información general en TextBox_InfoHamming
        Dim infoGeneral As String = $"Bits de información: {binario} ({m} bits)" & vbCrLf &
                               $"Bits de paridad necesarios: {r}" & vbCrLf &
                               $"Longitud total: {n} bits"

        TextBox_InfoHamming.Text = infoGeneral

        'Resto del código Hamming (colocar datos y calcular paridad)
        'Paso 1: Colocar bits de datos en posiciones que no son potencia de 2
        For i As Integer = 1 To n
            If Not EsPotenciaDeDos(i) Then
                hamming(i) = binario(dataIndex)
                dataIndex += 1
            End If
        Next

        'Paso 2: Calcular bits de paridad
        For i As Integer = 0 To r - 1
            Dim posParidad As Integer = CInt(Math.Pow(2, i))
            Dim paridad As Integer = 0

            'Calcular XOR para los bits cubiertos por esta paridad
            For j As Integer = posParidad To n Step posParidad * 2
                For k As Integer = j To Math.Min(j + posParidad - 1, n)
                    If k <= n AndAlso hamming(k) <> Nothing Then
                        paridad = paridad Xor Integer.Parse(hamming(k).ToString())
                    End If
                Next
            Next

            hamming(posParidad) = paridad.ToString()(0)
        Next

        'Construir resultado final
        Dim resultado As String = ""
        For i As Integer = 1 To n
            resultado += hamming(i)
        Next

        'GENERAR LA TABLA VISUAL
        GenerarTablaHamming(hamming, n, r)

        'Mostrar resultado final con colores
        MostrarResultadoHamming(hamming, n)

        Return resultado
    End Function

    Private Sub GenerarTablaHamming(hamming() As Char, n As Integer, r As Integer)
        RichTextBox_Tabla.Clear()
        RichTextBox_Tabla.Font = New Font("Courier New", 10)

        'Fila 1: Posiciones (mejor alineación para 569px)
        RichTextBox_Tabla.SelectionColor = Color.Black
        RichTextBox_Tabla.AppendText("Posición:    ")
        For i As Integer = 1 To n
            RichTextBox_Tabla.AppendText($"{i}".PadLeft(4))
        Next
        RichTextBox_Tabla.AppendText(vbCrLf)

        'Línea separadora
        RichTextBox_Tabla.AppendText("────────────")
        For i As Integer = 1 To n
            RichTextBox_Tabla.AppendText("────")
        Next
        RichTextBox_Tabla.AppendText(vbCrLf)

        'Fila 2: Bits info con X en rojo
        RichTextBox_Tabla.AppendText("Bits info:   ")
        For i As Integer = 1 To n
            If EsPotenciaDeDos(i) Then
                RichTextBox_Tabla.SelectionColor = Color.Red
                RichTextBox_Tabla.AppendText(" X ".PadLeft(4))
            Else
                RichTextBox_Tabla.SelectionColor = Color.Black
                RichTextBox_Tabla.AppendText($" {hamming(i)} ".PadLeft(4))
            End If
        Next
        RichTextBox_Tabla.AppendText(vbCrLf & vbCrLf)

        'Fila 3: P0 (1,3,5,7) - Primer bit en ROJO, resto en AZUL
        RichTextBox_Tabla.SelectionColor = Color.Black
        RichTextBox_Tabla.AppendText("P0 (1,3,5,7):")
        For i As Integer = 1 To n
            If i = 1 Or i = 3 Or i = 5 Or i = 7 Then
                If i = 1 Then 'Primer bit de P0 en ROJO
                    RichTextBox_Tabla.SelectionColor = Color.Red
                Else 'Resto de bits en AZUL
                    RichTextBox_Tabla.SelectionColor = Color.Blue
                End If
                RichTextBox_Tabla.AppendText($" {hamming(i)} ".PadLeft(4))
            Else
                RichTextBox_Tabla.SelectionColor = Color.Black
                RichTextBox_Tabla.AppendText(" - ".PadLeft(4))
            End If
        Next
        RichTextBox_Tabla.AppendText(vbCrLf)

        'Fila 4: P1 (2,3,6,7) - Primer bit en ROJO, resto en VERDE
        RichTextBox_Tabla.SelectionColor = Color.Black
        RichTextBox_Tabla.AppendText("P1 (2,3,6,7):")
        For i As Integer = 1 To n
            If i = 2 Or i = 3 Or i = 6 Or i = 7 Then
                If i = 2 Then 'Primer bit de P1 en ROJO
                    RichTextBox_Tabla.SelectionColor = Color.Red
                Else 'Resto de bits en VERDE
                    RichTextBox_Tabla.SelectionColor = Color.Green
                End If
                RichTextBox_Tabla.AppendText($" {hamming(i)} ".PadLeft(4))
            Else
                RichTextBox_Tabla.SelectionColor = Color.Black
                RichTextBox_Tabla.AppendText(" - ".PadLeft(4))
            End If
        Next
        RichTextBox_Tabla.AppendText(vbCrLf)

        'Fila 5: P2 (4,5,6,7) - Primer bit en ROJO, resto en PURPURA
        RichTextBox_Tabla.SelectionColor = Color.Black
        RichTextBox_Tabla.AppendText("P2 (4,5,6,7):")
        For i As Integer = 1 To n
            If i = 4 Or i = 5 Or i = 6 Or i = 7 Then
                If i = 4 Then 'Primer bit de P2 en ROJO
                    RichTextBox_Tabla.SelectionColor = Color.Red
                Else 'Resto de bits en PURPURA
                    RichTextBox_Tabla.SelectionColor = Color.Purple
                End If
                RichTextBox_Tabla.AppendText($" {hamming(i)} ".PadLeft(4))
            Else
                RichTextBox_Tabla.SelectionColor = Color.Black
                RichTextBox_Tabla.AppendText(" - ".PadLeft(4))
            End If
        Next

        'Leyenda
        RichTextBox_Tabla.AppendText(vbCrLf & vbCrLf)
        RichTextBox_Tabla.SelectionColor = Color.Red
        RichTextBox_Tabla.AppendText("Rojo: Bits de paridad (posición y primer bit de cada grupo)")
        RichTextBox_Tabla.AppendText(vbCrLf)
        RichTextBox_Tabla.SelectionColor = Color.Blue
        RichTextBox_Tabla.AppendText("Azul: Bits cubiertos por P0 (excepto primer bit)")
        RichTextBox_Tabla.AppendText(vbCrLf)
        RichTextBox_Tabla.SelectionColor = Color.Green
        RichTextBox_Tabla.AppendText("Verde: Bits cubiertos por P1 (excepto primer bit)")
        RichTextBox_Tabla.AppendText(vbCrLf)
        RichTextBox_Tabla.SelectionColor = Color.Purple
        RichTextBox_Tabla.AppendText("Púrpura: Bits cubiertos por P2 (excepto primer bit)")
    End Sub

    Private Function EsPotenciaDeDos(n As Integer) As Boolean
        Return (n And (n - 1)) = 0 AndAlso n > 0
    End Function

    Private Sub MostrarResultadoHamming(hamming() As Char, n As Integer)
        RichTextBox_Resultado.Clear()

        For i As Integer = 1 To n
            If EsPotenciaDeDos(i) Then
                'Bits de paridad en rojo
                RichTextBox_Resultado.SelectionColor = Color.Red
            Else
                'Bits de datos en negro
                RichTextBox_Resultado.SelectionColor = Color.Black
            End If
            RichTextBox_Resultado.AppendText(hamming(i))
        Next
    End Sub

    Private Sub Btn_Convertir_Click(sender As Object, e As EventArgs) Handles Btn_Convertir.Click
        'Validar entrada
        If Not ValidarBinario(TextBox_Entrada.Text) Then
            Return
        End If

        Dim binario As String = TextBox_Entrada.Text

        Try
            If Radio_Gray.Checked Then
                TextBox_Resultado.Text = ConvertirGray(binario)
            ElseIf Radio_Paridad.Checked Then
                TextBox_Resultado.Text = CalcularParidad(binario)
            ElseIf Radio_Hamming.Checked Then
                If binario.Length > 4 Then
                    MessageBox.Show("Para Hamming, máximo 4 bits de datos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
                TextBox_Resultado.Text = ConvertirHamming(binario)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Evento cuando cambia la selección del tipo de código
    Private Sub RadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Gray.CheckedChanged, Radio_Hamming.CheckedChanged, Radio_Paridad.CheckedChanged
        'Mostrar GroupBox de paridad solo cuando esté seleccionado "Bit de Paridad"
        GroupBox_Paridad.Visible = Radio_Paridad.Checked

        'LIMPIAR CAMPOS cuando se cambia el tipo de código
        LimpiarCampos()

        'ACTUALIZAR EL TOOLTIP con la información del código seleccionado
        ActualizarToolTip()

        'CONFIGURAR EL CONTROL DE RESULTADO SEGÚN EL CÓDIGO
        If Radio_Gray.Checked Then
            CambiarControlResultado("Gray")
        ElseIf Radio_Paridad.Checked Then
            CambiarControlResultado("Paridad")
        ElseIf Radio_Hamming.Checked Then
            CambiarControlResultado("Hamming")
        End If
    End Sub

    Private Sub LimpiarCampos()
        'Limpiar entrada
        TextBox_Entrada.Text = ""

        'Limpiar ambos controles de resultado
        TextBox_Resultado.Text = ""
        RichTextBox_Resultado.Clear()

        'Limpiar pasos y mostrar mensaje inicial
        TextBox_Pasos.Text = "Selecciona un tipo de código e ingresa un número binario para ver los pasos de conversión."

        'Dar foco al campo de entrada
        TextBox_Entrada.Focus()
    End Sub

    Private Sub CambiarControlResultado(tipoCodigo As String)
        If tipoCodigo = "Gray" Then
            TextBox_Resultado.Visible = True
            RichTextBox_Resultado.Visible = False
            RichTextBox_Tabla.Visible = False
            TextBox_InfoHamming.Visible = False
            TextBox_Pasos.Visible = True
        ElseIf tipoCodigo = "Paridad" Then
            TextBox_Resultado.Visible = False
            RichTextBox_Resultado.Visible = True
            RichTextBox_Tabla.Visible = False
            TextBox_InfoHamming.Visible = False
            TextBox_Pasos.Visible = True
        ElseIf tipoCodigo = "Hamming" Then
            TextBox_Resultado.Visible = False
            RichTextBox_Resultado.Visible = True
            RichTextBox_Tabla.Visible = True
            TextBox_InfoHamming.Visible = True  'Mostrar info Hamming
            TextBox_Pasos.Visible = False       'Ocultar pasos normales
        End If
    End Sub
End Class