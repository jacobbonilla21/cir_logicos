Public Class ari_binaria
    Private Sub Btn_VolverMenu_Click(sender As Object, e As EventArgs) Handles Btn_VolverMenu.Click
        Dim menuForm As New menu_principal()
        menuForm.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' Validar entrada
        If Not ValidarEntrada() Then
            Return
        End If

        ' Obtener números binarios
        Dim A As String = txtBinarioA.Text.PadLeft(5, "0"c)
        Dim B As String = txtBinarioB.Text.PadLeft(5, "0"c)

        ' Convertir a decimal para mostrar
        Dim numA As Integer = BinADec(A)
        Dim numB As Integer = BinADec(B)

        ' Realizar cálculo según el complemento seleccionado
        If rbComplemento1.Checked Then
            CalcularComplemento1(A, B, numA, numB)
        ElseIf rbComplemento2.Checked Then
            CalcularComplemento2(A, B, numA, numB)
        Else
            MessageBox.Show("Seleccione un tipo de complemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidarEntrada() As Boolean
        ' Validar que se haya seleccionado un complemento
        If Not rbComplemento1.Checked And Not rbComplemento2.Checked Then
            MessageBox.Show("Seleccione un tipo de complemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(txtBinarioA.Text) Or String.IsNullOrEmpty(txtBinarioB.Text) Then
            MessageBox.Show("Ingrese ambos números binarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validar longitud máxima
        If txtBinarioA.Text.Length > 5 Or txtBinarioB.Text.Length > 5 Then
            MessageBox.Show("Los números no pueden exceder 5 bits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validar que solo contengan 0s y 1s
        If Not EsBinarioValido(txtBinarioA.Text) Or Not EsBinarioValido(txtBinarioB.Text) Then
            MessageBox.Show("Los números deben contener solo 0s y 1s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub CalcularComplemento1(A As String, B As String, numA As Integer, numB As Integer)
        Dim resultado As String = ""
        Dim explicacion As String = ""

        ' Calcular complemento a 1 de B
        Dim complB As String = CalcularComplemento1Bin(B)
        explicacion += $"Complemento a 1 de {B}: {complB}" & vbCrLf

        ' Realizar suma A + complemento a 1 de B
        Dim suma As String = SumarBinarios(A, complB)
        explicacion += $"Suma: {A} + {complB} = {suma}" & vbCrLf

        ' Verificar acarreo final
        If suma.Length > 5 Then
            ' Hay acarreo (end-around carry)
            Dim acarreo As String = suma.Substring(0, 1)
            Dim resultadoSinAcarreo As String = suma.Substring(1)
            explicacion += $"Acarreo final: {acarreo}" & vbCrLf
            explicacion += $"Resultado sin acarreo: {resultadoSinAcarreo}" & vbCrLf

            ' Sumar el acarreo (end-around carry)
            resultado = SumarBinarios(resultadoSinAcarreo, acarreo)
            explicacion += $"Resultado final (sumando acarreo): {resultado}" & vbCrLf
        Else
            ' No hay acarreo, resultado es negativo en complemento
            resultado = suma.PadLeft(5, "0"c)
            explicacion += $"No hay acarreo - Resultado negativo: {resultado}" & vbCrLf
            explicacion += "(El resultado está en complemento a 1)" & vbCrLf
        End If

        ' Calcular resultado decimal
        Dim resultadoDecimal As Integer
        If suma.Length > 5 Or resultado.StartsWith("1") Then
            ' Resultado positivo
            resultadoDecimal = numA - numB
        Else
            ' Resultado negativo
            resultadoDecimal = -(CalcularComplemento1Dec(BinADec(resultado)))
        End If

        explicacion += $"Resultado decimal: {resultadoDecimal}" & vbCrLf

        ' Mostrar resultado
        MostrarResultado($"Resta con Complemento a 1: {A} - {B}", resultado, resultadoDecimal, explicacion)
    End Sub

    Private Sub CalcularComplemento2(A As String, B As String, numA As Integer, numB As Integer)
        Dim resultado As String = ""
        Dim explicacion As String = ""

        ' Calcular complemento a 2 de B
        Dim complB As String = CalcularComplemento2Bin(B)
        explicacion += $"Complemento a 2 de {B}: {complB}" & vbCrLf

        ' Realizar suma A + complemento a 2 de B
        Dim suma As String = SumarBinarios(A, complB)
        explicacion += $"Suma: {A} + {complB} = {suma}" & vbCrLf

        ' Manejar el acarreo final
        If suma.Length > 5 Then
            ' Ignorar el acarreo (es normal en complemento a 2)
            resultado = suma.Substring(1)
            explicacion += $"Ignorando acarreo - Resultado: {resultado}" & vbCrLf
        Else
            resultado = suma.PadLeft(5, "0"c)
            explicacion += $"Resultado: {resultado}" & vbCrLf
        End If

        ' Calcular resultado decimal
        Dim resultadoDecimal As Integer
        If resultado.StartsWith("1") Then
            ' Resultado negativo (en complemento a 2)
            resultadoDecimal = -(CalcularComplemento2Dec(resultado))
            explicacion += $"Resultado negativo: {resultadoDecimal}" & vbCrLf
        Else
            ' Resultado positivo
            resultadoDecimal = BinADec(resultado)
            explicacion += $"Resultado positivo: {resultadoDecimal}" & vbCrLf
        End If

        ' Mostrar resultado
        MostrarResultado($"Resta con Complemento a 2: {A} - {B}", resultado, resultadoDecimal, explicacion)
    End Sub

    Private Sub MostrarResultado(operacion As String, binario As String, decimalResult As Integer, explicacion As String)
        lblResultado.Text = $"{operacion}" & vbCrLf &
                           $"Binario: {binario}" & vbCrLf &
                           $"Decimal: {decimalResult}" & vbCrLf &
                           $"Explicación: {explicacion}"
    End Sub

    ' Funciones auxiliares para cálculos binarios
    Private Function EsBinarioValido(cadena As String) As Boolean
        For Each c As Char In cadena
            If c <> "0"c And c <> "1"c Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function BinADec(bin As String) As Integer
        Dim decVal As Integer = 0
        For i As Integer = 0 To bin.Length - 1
            If bin(i) = "1"c Then
                decVal += CInt(2 ^ (bin.Length - 1 - i))
            End If
        Next
        Return decVal
    End Function

    Private Function CalcularComplemento1Bin(bin As String) As String
        Dim compl As String = ""
        For Each bit As Char In bin
            If bit = "0"c Then
                compl &= "1"
            Else
                compl &= "0"
            End If
        Next
        Return compl.PadLeft(5, "1"c)
    End Function

    Private Function CalcularComplemento2Bin(bin As String) As String
        Dim compl1 As String = CalcularComplemento1Bin(bin)
        Return SumarBinarios(compl1, "00001")
    End Function

    Private Function SumarBinarios(a As String, b As String) As String
        Dim longitud As Integer = Math.Max(a.Length, b.Length)
        a = a.PadLeft(longitud, "0"c)
        b = b.PadLeft(longitud, "0"c)

        Dim result As String = ""
        Dim acarreo As Integer = 0

        For i As Integer = longitud - 1 To 0 Step -1
            Dim bitA As Integer = Integer.Parse(a(i).ToString())
            Dim bitB As Integer = Integer.Parse(b(i).ToString())
            Dim sum As Integer = bitA + bitB + acarreo
            result = (sum Mod 2).ToString() & result
            acarreo = sum \ 2
        Next

        If acarreo > 0 Then
            result = acarreo.ToString() & result
        End If

        Return result
    End Function

    Private Function CalcularComplemento1Dec(binDec As Integer) As Integer
        Return 31 - binDec
    End Function

    Private Function CalcularComplemento2Dec(bin As String) As Integer
        Dim compl1 As String = CalcularComplemento1Bin(bin)
        Return BinADec(compl1) + 1
    End Function

    Private Sub ari_binaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Seleccionar complemento a 2 por defecto
        rbComplemento2.Checked = True
    End Sub
End Class