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
        Operaciones = New ToolStripMenuItem()
        BinarioToolStripMenuItem = New ToolStripMenuItem()
        HexadecimalToolStripMenuItem = New ToolStripMenuItem()
        OctadecimalToolStripMenuItem = New ToolStripMenuItem()
        DecimalToolStripMenuItem = New ToolStripMenuItem()
        InicioToolStripMenuItem1 = New ToolStripMenuItem()
        Salir = New ToolStripMenuItem()
        Calcular = New Button()
        Limpiar = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Nombre_operacion
        ' 
        Nombre_operacion.FormattingEnabled = True
        Nombre_operacion.Items.AddRange(New Object() {"Hexadecimal", "Octadecimal", "Decimal", "Binario"})
        Nombre_operacion.Location = New Point(12, 44)
        Nombre_operacion.Name = "Nombre_operacion"
        Nombre_operacion.Size = New Size(121, 23)
        Nombre_operacion.TabIndex = 0
        Nombre_operacion.Text = "Elija una opcion"
        ' 
        ' Valor
        ' 
        Valor.Location = New Point(155, 44)
        Valor.Name = "Valor"
        Valor.Size = New Size(100, 23)
        Valor.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 2
        Label1.Text = "Binario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(139, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 3
        Label2.Text = "Hexadecimal"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(268, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 15)
        Label3.TabIndex = 4
        Label3.Text = "Octadecimal"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(406, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 15)
        Label4.TabIndex = 5
        Label4.Text = "Decimal"
        ' 
        ' Binario
        ' 
        Binario.Location = New Point(12, 218)
        Binario.Name = "Binario"
        Binario.ReadOnly = True
        Binario.Size = New Size(100, 23)
        Binario.TabIndex = 6
        ' 
        ' Hexadecimal
        ' 
        Hexadecimal.Location = New Point(127, 218)
        Hexadecimal.Name = "Hexadecimal"
        Hexadecimal.ReadOnly = True
        Hexadecimal.Size = New Size(100, 23)
        Hexadecimal.TabIndex = 7
        ' 
        ' Octadecimal
        ' 
        Octadecimal.Location = New Point(256, 218)
        Octadecimal.Name = "Octadecimal"
        Octadecimal.ReadOnly = True
        Octadecimal.Size = New Size(100, 23)
        Octadecimal.TabIndex = 8
        ' 
        ' Decima
        ' 
        Decima.Location = New Point(382, 218)
        Decima.Name = "Decima"
        Decima.ReadOnly = True
        Decima.Size = New Size(100, 23)
        Decima.TabIndex = 9
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {Operaciones, InicioToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(503, 24)
        MenuStrip1.TabIndex = 10
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Operaciones
        ' 
        Operaciones.DropDownItems.AddRange(New ToolStripItem() {BinarioToolStripMenuItem, HexadecimalToolStripMenuItem, OctadecimalToolStripMenuItem, DecimalToolStripMenuItem})
        Operaciones.Name = "Operaciones"
        Operaciones.Size = New Size(85, 20)
        Operaciones.Text = "Operaciones"
        ' 
        ' BinarioToolStripMenuItem
        ' 
        BinarioToolStripMenuItem.Name = "BinarioToolStripMenuItem"
        BinarioToolStripMenuItem.Size = New Size(143, 22)
        BinarioToolStripMenuItem.Text = "Binario"
        ' 
        ' HexadecimalToolStripMenuItem
        ' 
        HexadecimalToolStripMenuItem.Name = "HexadecimalToolStripMenuItem"
        HexadecimalToolStripMenuItem.Size = New Size(143, 22)
        HexadecimalToolStripMenuItem.Text = "Hexadecimal"
        ' 
        ' OctadecimalToolStripMenuItem
        ' 
        OctadecimalToolStripMenuItem.Name = "OctadecimalToolStripMenuItem"
        OctadecimalToolStripMenuItem.Size = New Size(143, 22)
        OctadecimalToolStripMenuItem.Text = "Octadecimal"
        ' 
        ' DecimalToolStripMenuItem
        ' 
        DecimalToolStripMenuItem.Name = "DecimalToolStripMenuItem"
        DecimalToolStripMenuItem.Size = New Size(143, 22)
        DecimalToolStripMenuItem.Text = "Decimal"
        ' 
        ' InicioToolStripMenuItem1
        ' 
        InicioToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {Salir})
        InicioToolStripMenuItem1.Name = "InicioToolStripMenuItem1"
        InicioToolStripMenuItem1.Size = New Size(48, 20)
        InicioToolStripMenuItem1.Text = "inicio"
        ' 
        ' Salir
        ' 
        Salir.Name = "Salir"
        Salir.Size = New Size(96, 22)
        Salir.Text = "Salir"
        ' 
        ' Calcular
        ' 
        Calcular.Location = New Point(12, 108)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(75, 23)
        Calcular.TabIndex = 11
        Calcular.Text = "Calcular"
        Calcular.UseVisualStyleBackColor = True
        ' 
        ' Limpiar
        ' 
        Limpiar.Location = New Point(106, 108)
        Limpiar.Name = "Limpiar"
        Limpiar.Size = New Size(75, 23)
        Limpiar.TabIndex = 12
        Limpiar.Text = "Limpiar"
        Limpiar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(503, 264)
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
    Friend WithEvents Operaciones As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Salir As ToolStripMenuItem
    Friend WithEvents BinarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Calcular As Button
    Friend WithEvents HexadecimalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OctadecimalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecimalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Limpiar As Button

End Class
