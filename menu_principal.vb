Public Class menu_principal
    Private Sub Btn_Codigo_Click(Sender As Object, e As EventArgs) Handles Btn_Codigo.Click
        Dim codBinarioForm As New cod_binario()
        codBinarioForm.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Aritmetica_Click(sender As Object, e As EventArgs) Handles Btn_Aritmetica.Click
        Dim ariBinariaForm As New ari_binaria()
        ariBinariaForm.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Sistemas_Click(sender As Object, e As EventArgs) Handles Btn_Sistemas.Click
        Dim sisBinarioForm As New Form1()
        sisBinarioForm.Show()
        Me.Hide()
    End Sub
End Class
