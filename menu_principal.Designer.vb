<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu_principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_principal))
        Label1 = New Label()
        Label2 = New Label()
        Btn_Aritmetica = New Button()
        Btn_Codigo = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(280, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 46)
        Label1.TabIndex = 0
        Label1.Text = "BIENVENIDO"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(216, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(347, 32)
        Label2.TabIndex = 1
        Label2.Text = "Seleccione una de las opciones"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_Aritmetica
        ' 
        Btn_Aritmetica.Font = New Font("Segoe UI", 12F)
        Btn_Aritmetica.Location = New Point(295, 198)
        Btn_Aritmetica.Name = "Btn_Aritmetica"
        Btn_Aritmetica.Size = New Size(197, 59)
        Btn_Aritmetica.TabIndex = 2
        Btn_Aritmetica.Text = "Aritmética Binaria"
        Btn_Aritmetica.UseVisualStyleBackColor = True
        ' 
        ' Btn_Codigo
        ' 
        Btn_Codigo.Font = New Font("Segoe UI", 12F)
        Btn_Codigo.Location = New Point(295, 314)
        Btn_Codigo.Name = "Btn_Codigo"
        Btn_Codigo.Size = New Size(197, 59)
        Btn_Codigo.TabIndex = 3
        Btn_Codigo.Text = "Código Binario"
        Btn_Codigo.UseVisualStyleBackColor = True
        ' 
        ' menu_principal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_Codigo)
        Controls.Add(Btn_Aritmetica)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "menu_principal"
        Text = "Menú Principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Aritmetica As Button
    Friend WithEvents Btn_Codigo As Button

End Class
