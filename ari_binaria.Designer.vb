<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ari_binaria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Btn_VolverMenu = New Button()
        gbConversion = New GroupBox()
        lblResultado = New Label()
        btnCalcular = New Button()
        txtBinarioB = New TextBox()
        Label4 = New Label()
        txtBinarioA = New TextBox()
        Label3 = New Label()
        gbTipoComplemento = New GroupBox()
        rbComplemento2 = New RadioButton()
        rbComplemento1 = New RadioButton()
        btnSalir = New Button()
        lblInfo = New Label()
        gbConversion.SuspendLayout()
        gbTipoComplemento.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(241, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(309, 46)
        Label1.TabIndex = 2
        Label1.Text = "Aritmética Binaria"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_VolverMenu
        ' 
        Btn_VolverMenu.Location = New Point(12, 12)
        Btn_VolverMenu.Name = "Btn_VolverMenu"
        Btn_VolverMenu.Size = New Size(80, 34)
        Btn_VolverMenu.TabIndex = 3
        Btn_VolverMenu.Text = "Volver"
        Btn_VolverMenu.UseVisualStyleBackColor = True
        ' 
        ' gbConversion
        ' 
        gbConversion.Controls.Add(lblResultado)
        gbConversion.Controls.Add(btnCalcular)
        gbConversion.Controls.Add(txtBinarioB)
        gbConversion.Controls.Add(Label4)
        gbConversion.Controls.Add(txtBinarioA)
        gbConversion.Controls.Add(Label3)
        gbConversion.Font = New Font("Segoe UI", 12.0F)
        gbConversion.ForeColor = SystemColors.Control
        gbConversion.Location = New Point(12, 200)
        gbConversion.Name = "gbConversion"
        gbConversion.Size = New Size(776, 238)
        gbConversion.TabIndex = 4
        gbConversion.TabStop = False
        gbConversion.Text = "Operación de Resta Binaria"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblResultado.ForeColor = Color.LightGreen
        lblResultado.Location = New Point(21, 150)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(97, 23)
        lblResultado.TabIndex = 7
        lblResultado.Text = "Resultado: "
        ' 
        ' btnCalcular
        ' 
        btnCalcular.ForeColor = SystemColors.ActiveCaptionText
        btnCalcular.Location = New Point(21, 100)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(200, 40)
        btnCalcular.TabIndex = 6
        btnCalcular.Text = "Calcular Resta"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' txtBinarioB
        ' 
        txtBinarioB.Font = New Font("Courier New", 10.0F)
        txtBinarioB.Location = New Point(450, 60)
        txtBinarioB.MaxLength = 5
        txtBinarioB.Name = "txtBinarioB"
        txtBinarioB.PlaceholderText = "Ej: 10101"
        txtBinarioB.Size = New Size(150, 27)
        txtBinarioB.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(450, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 28)
        Label4.TabIndex = 4
        Label4.Text = "Número B (5 bits)"
        ' 
        ' txtBinarioA
        ' 
        txtBinarioA.Font = New Font("Courier New", 10.0F)
        txtBinarioA.Location = New Point(21, 60)
        txtBinarioA.MaxLength = 5
        txtBinarioA.Name = "txtBinarioA"
        txtBinarioA.PlaceholderText = "Ej: 11011"
        txtBinarioA.Size = New Size(150, 27)
        txtBinarioA.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 28)
        Label3.TabIndex = 2
        Label3.Text = "Número A (5 bits)"
        ' 
        ' gbTipoComplemento
        ' 
        gbTipoComplemento.Controls.Add(rbComplemento2)
        gbTipoComplemento.Controls.Add(rbComplemento1)
        gbTipoComplemento.Font = New Font("Segoe UI", 12.0F)
        gbTipoComplemento.ForeColor = SystemColors.Control
        gbTipoComplemento.Location = New Point(12, 90)
        gbTipoComplemento.Name = "gbTipoComplemento"
        gbTipoComplemento.Size = New Size(776, 90)
        gbTipoComplemento.TabIndex = 5
        gbTipoComplemento.TabStop = False
        gbTipoComplemento.Text = "Seleccione el Tipo de Complemento"
        ' 
        ' rbComplemento2
        ' 
        rbComplemento2.AutoSize = True
        rbComplemento2.Location = New Point(400, 40)
        rbComplemento2.Name = "rbComplemento2"
        rbComplemento2.Size = New Size(350, 32)
        rbComplemento2.TabIndex = 1
        rbComplemento2.TabStop = True
        rbComplemento2.Text = "Complemento a 2 (Más utilizado)"
        rbComplemento2.UseVisualStyleBackColor = True
        ' 
        ' rbComplemento1
        ' 
        rbComplemento1.AutoSize = True
        rbComplemento1.Location = New Point(21, 40)
        rbComplemento1.Name = "rbComplemento1"
        rbComplemento1.Size = New Size(300, 32)
        rbComplemento1.TabIndex = 0
        rbComplemento1.TabStop = True
        rbComplemento1.Text = "Complemento a 1 (Clásico)"
        rbComplemento1.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(708, 12)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(80, 34)
        btnSalir.TabIndex = 6
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        lblInfo.ForeColor = Color.LightYellow
        lblInfo.Location = New Point(12, 450)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(776, 20)
        lblInfo.TabIndex = 7
        lblInfo.Text = "Restricción: Trabajar con números de 5 bits (0-31 en decimal). Ingrese solo 0s y 1s."
        lblInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ari_binaria
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 480)
        Controls.Add(lblInfo)
        Controls.Add(btnSalir)
        Controls.Add(gbTipoComplemento)
        Controls.Add(gbConversion)
        Controls.Add(Btn_VolverMenu)
        Controls.Add(Label1)
        Name = "ari_binaria"
        Text = "Aritmética Binaria - Resta con Complementos"
        gbConversion.ResumeLayout(False)
        gbConversion.PerformLayout()
        gbTipoComplemento.ResumeLayout(False)
        gbTipoComplemento.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_VolverMenu As Button
    Friend WithEvents gbConversion As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBinarioA As TextBox
    Friend WithEvents txtBinarioB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents gbTipoComplemento As GroupBox
    Friend WithEvents rbComplemento2 As RadioButton
    Friend WithEvents rbComplemento1 As RadioButton
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblInfo As Label
End Class
