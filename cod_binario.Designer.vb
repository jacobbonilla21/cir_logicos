<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cod_binario
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Btn_VolverMenu = New Button()
        GroupBox_Tipo = New GroupBox()
        GroupBox_Paridad = New GroupBox()
        Radio_ParidadImpar = New RadioButton()
        Radio_ParidadPar = New RadioButton()
        Radio_Hamming = New RadioButton()
        Radio_Paridad = New RadioButton()
        Radio_Gray = New RadioButton()
        Group_Conversion = New GroupBox()
        Btn_Convertir = New Button()
        TextBox_Entrada = New TextBox()
        Label2 = New Label()
        Group_Resultados = New GroupBox()
        Label3 = New Label()
        TextBox_Pasos = New TextBox()
        TextBox_Resultado = New TextBox()
        ToolTip1 = New ToolTip(components)
        GroupBox_Tipo.SuspendLayout()
        GroupBox_Paridad.SuspendLayout()
        Group_Conversion.SuspendLayout()
        Group_Resultados.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(387, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 46)
        Label1.TabIndex = 1
        Label1.Text = "Códigos Binarios"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_VolverMenu
        ' 
        Btn_VolverMenu.Location = New Point(12, 12)
        Btn_VolverMenu.Name = "Btn_VolverMenu"
        Btn_VolverMenu.Size = New Size(80, 34)
        Btn_VolverMenu.TabIndex = 2
        Btn_VolverMenu.Text = "Volver"
        Btn_VolverMenu.UseVisualStyleBackColor = True
        ' 
        ' GroupBox_Tipo
        ' 
        GroupBox_Tipo.Controls.Add(GroupBox_Paridad)
        GroupBox_Tipo.Controls.Add(Radio_Hamming)
        GroupBox_Tipo.Controls.Add(Radio_Paridad)
        GroupBox_Tipo.Controls.Add(Radio_Gray)
        GroupBox_Tipo.Font = New Font("Segoe UI", 12F)
        GroupBox_Tipo.ForeColor = SystemColors.Control
        GroupBox_Tipo.Location = New Point(63, 92)
        GroupBox_Tipo.Name = "GroupBox_Tipo"
        GroupBox_Tipo.Size = New Size(917, 146)
        GroupBox_Tipo.TabIndex = 4
        GroupBox_Tipo.TabStop = False
        GroupBox_Tipo.Text = "Tipo de código"
        ' 
        ' GroupBox_Paridad
        ' 
        GroupBox_Paridad.BackColor = Color.Transparent
        GroupBox_Paridad.BackgroundImageLayout = ImageLayout.None
        GroupBox_Paridad.Controls.Add(Radio_ParidadImpar)
        GroupBox_Paridad.Controls.Add(Radio_ParidadPar)
        GroupBox_Paridad.Font = New Font("Segoe UI", 9F)
        GroupBox_Paridad.Location = New Point(278, 82)
        GroupBox_Paridad.Name = "GroupBox_Paridad"
        GroupBox_Paridad.Size = New Size(366, 54)
        GroupBox_Paridad.TabIndex = 3
        GroupBox_Paridad.TabStop = False
        GroupBox_Paridad.Visible = False
        ' 
        ' Radio_ParidadImpar
        ' 
        Radio_ParidadImpar.AutoSize = True
        Radio_ParidadImpar.Location = New Point(220, 20)
        Radio_ParidadImpar.Name = "Radio_ParidadImpar"
        Radio_ParidadImpar.Size = New Size(123, 24)
        Radio_ParidadImpar.TabIndex = 1
        Radio_ParidadImpar.Text = "Paridad Impar"
        Radio_ParidadImpar.UseVisualStyleBackColor = True
        ' 
        ' Radio_ParidadPar
        ' 
        Radio_ParidadPar.AutoSize = True
        Radio_ParidadPar.Checked = True
        Radio_ParidadPar.Location = New Point(37, 20)
        Radio_ParidadPar.Name = "Radio_ParidadPar"
        Radio_ParidadPar.Size = New Size(104, 24)
        Radio_ParidadPar.TabIndex = 0
        Radio_ParidadPar.TabStop = True
        Radio_ParidadPar.Text = "Paridad Par"
        Radio_ParidadPar.UseVisualStyleBackColor = True
        ' 
        ' Radio_Hamming
        ' 
        Radio_Hamming.AutoSize = True
        Radio_Hamming.Location = New Point(704, 44)
        Radio_Hamming.Name = "Radio_Hamming"
        Radio_Hamming.Size = New Size(189, 32)
        Radio_Hamming.TabIndex = 2
        Radio_Hamming.TabStop = True
        Radio_Hamming.Text = "Código Hamming"
        Radio_Hamming.UseVisualStyleBackColor = True
        ' 
        ' Radio_Paridad
        ' 
        Radio_Paridad.AutoSize = True
        Radio_Paridad.Location = New Point(386, 44)
        Radio_Paridad.Name = "Radio_Paridad"
        Radio_Paridad.Size = New Size(154, 32)
        Radio_Paridad.TabIndex = 1
        Radio_Paridad.TabStop = True
        Radio_Paridad.Text = "Bit de Paridad"
        Radio_Paridad.UseVisualStyleBackColor = True
        ' 
        ' Radio_Gray
        ' 
        Radio_Gray.AutoSize = True
        Radio_Gray.Checked = True
        Radio_Gray.Location = New Point(19, 44)
        Radio_Gray.Name = "Radio_Gray"
        Radio_Gray.Size = New Size(144, 32)
        Radio_Gray.TabIndex = 0
        Radio_Gray.TabStop = True
        Radio_Gray.Text = "Código Gray"
        Radio_Gray.UseVisualStyleBackColor = True
        ' 
        ' Group_Conversion
        ' 
        Group_Conversion.Controls.Add(Btn_Convertir)
        Group_Conversion.Controls.Add(TextBox_Entrada)
        Group_Conversion.Controls.Add(Label2)
        Group_Conversion.Font = New Font("Segoe UI", 12F)
        Group_Conversion.ForeColor = SystemColors.Control
        Group_Conversion.Location = New Point(63, 244)
        Group_Conversion.Name = "Group_Conversion"
        Group_Conversion.Size = New Size(264, 274)
        Group_Conversion.TabIndex = 5
        Group_Conversion.TabStop = False
        Group_Conversion.Text = "Conversión"
        ' 
        ' Btn_Convertir
        ' 
        Btn_Convertir.BackColor = Color.CadetBlue
        Btn_Convertir.ForeColor = SystemColors.Control
        Btn_Convertir.Location = New Point(71, 204)
        Btn_Convertir.Name = "Btn_Convertir"
        Btn_Convertir.Size = New Size(125, 52)
        Btn_Convertir.TabIndex = 2
        Btn_Convertir.Text = "Convertir"
        Btn_Convertir.UseVisualStyleBackColor = False
        ' 
        ' TextBox_Entrada
        ' 
        TextBox_Entrada.Location = New Point(26, 105)
        TextBox_Entrada.MaxLength = 6
        TextBox_Entrada.Name = "TextBox_Entrada"
        TextBox_Entrada.Size = New Size(151, 34)
        TextBox_Entrada.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 28)
        Label2.TabIndex = 0
        Label2.Text = "Digite número binario:"
        ' 
        ' Group_Resultados
        ' 
        Group_Resultados.Controls.Add(Label3)
        Group_Resultados.Controls.Add(TextBox_Pasos)
        Group_Resultados.Controls.Add(TextBox_Resultado)
        Group_Resultados.Font = New Font("Segoe UI", 12F)
        Group_Resultados.ForeColor = SystemColors.Control
        Group_Resultados.Location = New Point(366, 244)
        Group_Resultados.Name = "Group_Resultados"
        Group_Resultados.Size = New Size(614, 318)
        Group_Resultados.TabIndex = 6
        Group_Resultados.TabStop = False
        Group_Resultados.Text = "Resultado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 28)
        Label3.TabIndex = 4
        Label3.Text = "Pasos de Solución:"
        ' 
        ' TextBox_Pasos
        ' 
        TextBox_Pasos.Location = New Point(21, 125)
        TextBox_Pasos.Multiline = True
        TextBox_Pasos.Name = "TextBox_Pasos"
        TextBox_Pasos.ReadOnly = True
        TextBox_Pasos.ScrollBars = ScrollBars.Vertical
        TextBox_Pasos.Size = New Size(569, 172)
        TextBox_Pasos.TabIndex = 3
        ' 
        ' TextBox_Resultado
        ' 
        TextBox_Resultado.Location = New Point(22, 41)
        TextBox_Resultado.Name = "TextBox_Resultado"
        TextBox_Resultado.ReadOnly = True
        TextBox_Resultado.Size = New Size(184, 34)
        TextBox_Resultado.TabIndex = 1
        ' 
        ' ToolTip1
        ' 
        ' 
        ' cod_binario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1046, 588)
        Controls.Add(Group_Resultados)
        Controls.Add(Group_Conversion)
        Controls.Add(GroupBox_Tipo)
        Controls.Add(Btn_VolverMenu)
        Controls.Add(Label1)
        Name = "cod_binario"
        Text = "Código Binario"
        GroupBox_Tipo.ResumeLayout(False)
        GroupBox_Tipo.PerformLayout()
        GroupBox_Paridad.ResumeLayout(False)
        GroupBox_Paridad.PerformLayout()
        Group_Conversion.ResumeLayout(False)
        Group_Conversion.PerformLayout()
        Group_Resultados.ResumeLayout(False)
        Group_Resultados.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_VolverMenu As Button
    Friend WithEvents GroupBox_Tipo As GroupBox
    Friend WithEvents Radio_Hamming As RadioButton
    Friend WithEvents Radio_Paridad As RadioButton
    Friend WithEvents Radio_Gray As RadioButton
    Friend WithEvents Group_Conversion As GroupBox
    Friend WithEvents TextBox_Entrada As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Group_Resultados As GroupBox
    Friend WithEvents TextBox_Resultado As TextBox
    Friend WithEvents Btn_Convertir As Button
    Friend WithEvents TextBox_Pasos As TextBox
    Friend WithEvents GroupBox_Paridad As GroupBox
    Friend WithEvents Radio_ParidadImpar As RadioButton
    Friend WithEvents Radio_ParidadPar As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
