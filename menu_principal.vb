Public Class menu_principal
    Private Sub Btn_Codigo_Click(Sender As Object, e As EventArgs) Handles Btn_Codigo.Click
        Dim codBinarioForm As New cod_binario()
        codBinarioForm.Show()

        Me.Hide()
    End Sub
End Class
