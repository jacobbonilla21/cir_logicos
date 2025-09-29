<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Nombre_operacion = New ComboBox()
        Valor = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Binario = New TextBox()
        Hexadecimal = New TextBox()
        Octadecimal = New TextBox()
        Decima = New TextBox()
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem1 = New ToolStripMenuItem()
        VolverToolStripMenuItem = New ToolStripMenuItem()
        Salir = New ToolStripMenuItem()
        Calcular = New Button()
        Limpiar = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        'ToolTip1
        ToolTip1 = New ToolTip(components)
        ' 
        ' Nombre_operacion
        ' 
        Nombre_operacion.FormattingEnabled = True
        Nombre_operacion.Items.AddRange(New Object() {"Hexadecimal", "Octadecimal", "Decimal", "Binario"})
        Nombre_operacion.Location = New Point(14, 59)
        Nombre_operacion.Margin = New Padding(3, 4, 3, 4)
        Nombre_operacion.Name = "Nombre_operacion"
        Nombre_operacion.Size = New Size(138, 28)
        Nombre_operacion.TabIndex = 0
        Nombre_operacion.Text = "Elija una opcion"
        ' 
        ' Valor
        ' 
        Valor.Location = New Point(177, 59)
        Valor.Margin = New Padding(3, 4, 3, 4)
        Valor.Name = "Valor"
        Valor.Size = New Size(114, 27)
        Valor.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 243)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 2
        Label1.Text = "Binario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(159, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 3
        Label2.Text = "Hexadecimal"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(306, 243)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 4
        Label3.Text = "Octadecimal"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(464, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 5
        Label4.Text = "Decimal"
        ' 
        ' Binario
        ' 
        Binario.Location = New Point(14, 291)
        Binario.Margin = New Padding(3, 4, 3, 4)
        Binario.Name = "Binario"
        Binario.ReadOnly = True
        Binario.Size = New Size(114, 27)
        Binario.TabIndex = 6
        ' 
        ' Hexadecimal
        ' 
        Hexadecimal.Location = New Point(145, 291)
        Hexadecimal.Margin = New Padding(3, 4, 3, 4)
        Hexadecimal.Name = "Hexadecimal"
        Hexadecimal.ReadOnly = True
        Hexadecimal.Size = New Size(114, 27)
        Hexadecimal.TabIndex = 7
        ' 
        ' Octadecimal
        ' 
        Octadecimal.Location = New Point(293, 291)
        Octadecimal.Margin = New Padding(3, 4, 3, 4)
        Octadecimal.Name = "Octadecimal"
        Octadecimal.ReadOnly = True
        Octadecimal.Size = New Size(114, 27)
        Octadecimal.TabIndex = 8
        ' 
        ' Decima
        ' 
        Decima.Location = New Point(437, 291)
        Decima.Margin = New Padding(3, 4, 3, 4)
        Decima.Name = "Decima"
        Decima.ReadOnly = True
        Decima.Size = New Size(114, 27)
        Decima.TabIndex = 9
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(575, 30)
        MenuStrip1.TabIndex = 10
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InicioToolStripMenuItem1
        ' 
        InicioToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {VolverToolStripMenuItem, Salir})
        InicioToolStripMenuItem1.Name = "InicioToolStripMenuItem1"
        InicioToolStripMenuItem1.Size = New Size(60, 24)
        InicioToolStripMenuItem1.Text = "Menu"
        ' 
        ' VolverToolStripMenuItem
        ' 
        VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        VolverToolStripMenuItem.Size = New Size(224, 26)
        VolverToolStripMenuItem.Text = "Volver"
        ' 
        ' Salir
        ' 
        Salir.Name = "Salir"
        Salir.Size = New Size(224, 26)
        Salir.Text = "Salir"
        ' 
        ' Calcular
        ' 
        Calcular.Location = New Point(14, 144)
        Calcular.Margin = New Padding(3, 4, 3, 4)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(86, 31)
        Calcular.TabIndex = 11
        Calcular.Text = "Calcular"
        Calcular.UseVisualStyleBackColor = True
        ' 
        ' Limpiar
        ' 
        Limpiar.Location = New Point(121, 144)
        Limpiar.Margin = New Padding(3, 4, 3, 4)
        Limpiar.Name = "Limpiar"
        Limpiar.Size = New Size(86, 31)
        Limpiar.TabIndex = 12
        Limpiar.Text = "Limpiar"
        Limpiar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(575, 352)
        Controls.Add(Limpiar)
        Controls.Add(Calcular)
        Controls.Add(Decima)
        Controls.Add(Octadecimal)
        Controls.Add(Hexadecimal)
        Controls.Add(Binario)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Valor)
        Controls.Add(Nombre_operacion)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Conversor de sistemas numericos"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Nombre_operacion As ComboBox
    Friend WithEvents Valor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Binario As TextBox
    Friend WithEvents Hexadecimal As TextBox
    Friend WithEvents Octadecimal As TextBox
    Friend WithEvents Decima As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Salir As ToolStripMenuItem
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip

End Class