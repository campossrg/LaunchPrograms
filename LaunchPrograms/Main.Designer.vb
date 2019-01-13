<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.gbxCargar = New System.Windows.Forms.GroupBox()
        Me.btnResetLista = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.lbProgramas = New System.Windows.Forms.ListBox()
        Me.btnLanzar = New System.Windows.Forms.Button()
        Me.gbxCargar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCargar
        '
        Me.gbxCargar.BackgroundImage = CType(resources.GetObject("gbxCargar.BackgroundImage"), System.Drawing.Image)
        Me.gbxCargar.Controls.Add(Me.btnResetLista)
        Me.gbxCargar.Controls.Add(Me.btneliminar)
        Me.gbxCargar.Controls.Add(Me.btnCargar)
        Me.gbxCargar.Location = New System.Drawing.Point(13, 13)
        Me.gbxCargar.Name = "gbxCargar"
        Me.gbxCargar.Size = New System.Drawing.Size(454, 50)
        Me.gbxCargar.TabIndex = 0
        Me.gbxCargar.TabStop = False
        Me.gbxCargar.Text = "Cargar programas"
        '
        'btnResetLista
        '
        Me.btnResetLista.Location = New System.Drawing.Point(359, 19)
        Me.btnResetLista.Name = "btnResetLista"
        Me.btnResetLista.Size = New System.Drawing.Size(89, 23)
        Me.btnResetLista.TabIndex = 7
        Me.btnResetLista.Text = "Resetear lista"
        Me.btnResetLista.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(87, 19)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 6
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(6, 19)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 3
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'lbProgramas
        '
        Me.lbProgramas.FormattingEnabled = True
        Me.lbProgramas.Location = New System.Drawing.Point(13, 82)
        Me.lbProgramas.Name = "lbProgramas"
        Me.lbProgramas.Size = New System.Drawing.Size(454, 459)
        Me.lbProgramas.TabIndex = 1
        '
        'btnLanzar
        '
        Me.btnLanzar.Location = New System.Drawing.Point(390, 553)
        Me.btnLanzar.Name = "btnLanzar"
        Me.btnLanzar.Size = New System.Drawing.Size(75, 23)
        Me.btnLanzar.TabIndex = 7
        Me.btnLanzar.Text = "Lanzar"
        Me.btnLanzar.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(477, 588)
        Me.Controls.Add(Me.btnLanzar)
        Me.Controls.Add(Me.lbProgramas)
        Me.Controls.Add(Me.gbxCargar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Lanzar aplicaciones"
        Me.gbxCargar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxCargar As GroupBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents lbProgramas As ListBox
    Friend WithEvents btnLanzar As Button
    Friend WithEvents btnResetLista As Button
End Class
