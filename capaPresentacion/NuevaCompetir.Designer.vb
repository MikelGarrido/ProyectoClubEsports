<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaCompetir
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodJugador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCompeticion = New System.Windows.Forms.TextBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 36)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NUEVA COMPETIDA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CÓDIGO DEL JUGADOR"
        '
        'txtCodJugador
        '
        Me.txtCodJugador.Enabled = False
        Me.txtCodJugador.Location = New System.Drawing.Point(436, 122)
        Me.txtCodJugador.Name = "txtCodJugador"
        Me.txtCodJugador.Size = New System.Drawing.Size(100, 22)
        Me.txtCodJugador.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(326, 25)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "CÓDIGO DE LA COMPETICIÓN"
        '
        'txtCompeticion
        '
        Me.txtCompeticion.Enabled = False
        Me.txtCompeticion.Location = New System.Drawing.Point(436, 242)
        Me.txtCompeticion.Name = "txtCompeticion"
        Me.txtCompeticion.Size = New System.Drawing.Size(100, 22)
        Me.txtCompeticion.TabIndex = 31
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(239, 395)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 32
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(436, 395)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 33
        Me.btnLimpiar.Text = "Atrás"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'NuevaCompetir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.txtCompeticion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodJugador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NuevaCompetir"
        Me.Text = "NuevaCompetir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodJugador As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCompeticion As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnLimpiar As Button
End Class
