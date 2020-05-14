<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrenamiento
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoJugador = New System.Windows.Forms.TextBox()
        Me.txtCodigoEntrenador = New System.Windows.Forms.TextBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ASIGNAR ENTRENADOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CÓDIGO DE JUGADOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CÓDIGO DE ENTRENADOR"
        '
        'txtCodigoJugador
        '
        Me.txtCodigoJugador.Enabled = False
        Me.txtCodigoJugador.Location = New System.Drawing.Point(470, 164)
        Me.txtCodigoJugador.Name = "txtCodigoJugador"
        Me.txtCodigoJugador.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigoJugador.TabIndex = 9
        '
        'txtCodigoEntrenador
        '
        Me.txtCodigoEntrenador.Location = New System.Drawing.Point(470, 247)
        Me.txtCodigoEntrenador.Name = "txtCodigoEntrenador"
        Me.txtCodigoEntrenador.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigoEntrenador.TabIndex = 10
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(331, 368)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 30
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'Entrenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.txtCodigoEntrenador)
        Me.Controls.Add(Me.txtCodigoJugador)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Entrenamiento"
        Me.Text = "Entrenamiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoJugador As TextBox
    Friend WithEvents txtCodigoEntrenador As TextBox
    Friend WithEvents btnCrear As Button
End Class
