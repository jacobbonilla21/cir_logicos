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
        For Each form As Form In Application.OpenForms
            If TypeOf form Is menu_principal Then
                form.Show()
                Me.Close()
                Return
            End If
        Next

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

        pasosGray.Add($"Binario original: {binario}")
        pasosGray.Add("")

        'El primer bit siempre es igual
        gray += binario(0)
        pasosGray.Add($"Paso 1: Primer bit = {binario(0)}")

        'Para los bits restantes: Gray[i] = Binario[i-1] XOR Binario[i]
        For i As Integer = 1 To binario.Length - 1
            Dim bit1 As Integer = Integer.Parse(binario(i - 1).ToString())
            Dim bit2 As Integer = Integer.Parse(binario(i).ToString())
            Dim resultadoXOR As Integer = bit1 Xor bit2

            gray += resultadoXOR.ToString()
            pasosGray.Add($"Paso {i + 1}: {bit1} ⊕ {bit2} = {resultadoXOR}")
        Next

        pasosGray.Add("")
        pasosGray.Add($"Código Gray: {gray}")

        'Siempre mostrar los pasos
        TextBox_Pasos.Text = String.Join(vbCrLf, pasosGray)

        Return gray
    End Function

    Private Function CalcularParidad(binario As String) As String
        pasosParidad.Clear()
        Dim contadorUnos As Integer = 0

        'Determinar si es paridad par o impar
        Dim esParidadPar As Boolean = Radio_ParidadPar.Checked
        Dim tipoParidad As String = If(esParidadPar, "Par", "Impar")

        pasosParidad.Add($"Binario: {binario}")
        pasosParidad.Add($"Tipo de paridad: {tipoParidad}")
        pasosParidad.Add("Contando unos...")

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

        pasosParidad.Add($"")
        pasosParidad.Add($"Total de unos: {contadorUnos}")
        pasosParidad.Add($"{contadorUnos} Mod 2 = {contadorUnos Mod 2}")

        If esParidadPar Then
            pasosParidad.Add($"Paridad Par: bit = {(contadorUnos Mod 2)}")
        Else
            pasosParidad.Add($"Paridad Impar: bit = {If((contadorUnos Mod 2) = 0, 1, 0)}")
        End If

        pasosParidad.Add($"Bit de paridad (MSB): {bitParidad}")
        pasosParidad.Add($"Resultado: {resultado}")

        'Siempre mostrar los pasos
        TextBox_Pasos.Text = String.Join(vbCrLf, pasosParidad)

        Return resultado
    End Function

    Private Function ConvertirHamming(binario As String) As String
        pasosHamming.Clear()

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

        pasosHamming.Add($"Datos: {binario} ({m} bits)")
        pasosHamming.Add($"Bits de paridad necesarios: {r}")
        pasosHamming.Add($"Longitud total: {n} bits")
        pasosHamming.Add("")

        'Colocar bits de datos
        For i As Integer = 1 To n
            If Not EsPotenciaDeDos(i) Then
                hamming(i) = binario(dataIndex)
                dataIndex += 1
                pasosHamming.Add($"Posición {i}: Dato → {hamming(i)}")
            End If
        Next

        'Calcular bits de paridad
        For i As Integer = 0 To r - 1
            Dim posParidad As Integer = CInt(Math.Pow(2, i))
            Dim paridad As Integer = 0

            pasosHamming.Add($"")
            pasosHamming.Add($"Calculando paridad P{i + 1} (posición {posParidad}):")

            For j As Integer = posParidad To n Step posParidad * 2
                For k As Integer = j To Math.Min(j + posParidad - 1, n)
                    If k <= n AndAlso hamming(k) <> Nothing Then
                        paridad = paridad Xor Integer.Parse(hamming(k).ToString())
                        pasosHamming.Add($"  Posición {k}: {hamming(k)} → Paridad temporal = {paridad}")
                    End If
                Next
            Next

            hamming(posParidad) = paridad.ToString()(0)
            pasosHamming.Add($"Paridad P{i + 1} = {paridad}")
        Next

        'Construir resultado final
        Dim resultado As String = ""
        For i As Integer = 1 To n
            resultado += hamming(i)
        Next

        pasosHamming.Add($"")
        pasosHamming.Add($"Código Hamming: {resultado}")

        'Siempre mostrar los pasos
        TextBox_Pasos.Text = String.Join(vbCrLf, pasosHamming)

        Return resultado
    End Function

    Private Function EsPotenciaDeDos(n As Integer) As Boolean
        Return (n And (n - 1)) = 0 AndAlso n > 0
    End Function

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
    End Sub

    Private Sub LimpiarCampos()
        'Limpiar entrada
        TextBox_Entrada.Text = ""

        'Limpiar resultado
        TextBox_Resultado.Text = ""

        'Limpiar pasos y mostrar mensaje inicial
        TextBox_Pasos.Text = "Selecciona un tipo de código e ingresa un número binario para ver los pasos de conversión."

        'Dar foco al campo de entrada
        TextBox_Entrada.Focus()
    End Sub
End Class