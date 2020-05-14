<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuInicio
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
        Me.btnClubes = New System.Windows.Forms.Button()
        Me.btnAfiliados = New System.Windows.Forms.Button()
        Me.btnPatrocinios = New System.Windows.Forms.Button()
        Me.btnProyectos = New System.Windows.Forms.Button()
        Me.btnTrofeos = New System.Windows.Forms.Button()
        Me.btnEntrenadores = New System.Windows.Forms.Button()
        Me.btnEntrenamientos = New System.Windows.Forms.Button()
        Me.btnJugadores = New System.Windows.Forms.Button()
        Me.btnCompetidas = New System.Windows.Forms.Button()
        Me.btnCompeticiones = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClubes
        '
        Me.btnClubes.Location = New System.Drawing.Point(114, 105)
        Me.btnClubes.Name = "btnClubes"
        Me.btnClubes.Size = New System.Drawing.Size(133, 136)
        Me.btnClubes.TabIndex = 0
        Me.btnClubes.Text = "Clubes"
        Me.btnClubes.UseVisualStyleBackColor = True
        '
        'btnAfiliados
        '
        Me.btnAfiliados.Location = New System.Drawing.Point(336, 116)
        Me.btnAfiliados.Name = "btnAfiliados"
        Me.btnAfiliados.Size = New System.Drawing.Size(147, 115)
        Me.btnAfiliados.TabIndex = 1
        Me.btnAfiliados.Text = "Afiliados"
        Me.btnAfiliados.UseVisualStyleBackColor = True
        '
        'btnPatrocinios
        '
        Me.btnPatrocinios.Location = New System.Drawing.Point(597, 132)
        Me.btnPatrocinios.Name = "btnPatrocinios"
        Me.btnPatrocinios.Size = New System.Drawing.Size(145, 83)
        Me.btnPatrocinios.TabIndex = 2
        Me.btnPatrocinios.Text = "Patrocinios"
        Me.btnPatrocinios.UseVisualStyleBackColor = True
        '
        'btnProyectos
        '
        Me.btnProyectos.Location = New System.Drawing.Point(842, 192)
        Me.btnProyectos.Name = "btnProyectos"
        Me.btnProyectos.Size = New System.Drawing.Size(157, 78)
        Me.btnProyectos.TabIndex = 3
        Me.btnProyectos.Text = "Proyectos"
        Me.btnProyectos.UseVisualStyleBackColor = True
        '
        'btnTrofeos
        '
        Me.btnTrofeos.Location = New System.Drawing.Point(157, 320)
        Me.btnTrofeos.Name = "btnTrofeos"
        Me.btnTrofeos.Size = New System.Drawing.Size(155, 92)
        Me.btnTrofeos.TabIndex = 4
        Me.btnTrofeos.Text = "TROFEOS"
        Me.btnTrofeos.UseVisualStyleBackColor = True
        '
        'btnEntrenadores
        '
        Me.btnEntrenadores.Location = New System.Drawing.Point(372, 300)
        Me.btnEntrenadores.Name = "btnEntrenadores"
        Me.btnEntrenadores.Size = New System.Drawing.Size(166, 133)
        Me.btnEntrenadores.TabIndex = 5
        Me.btnEntrenadores.Text = "ENTRENADORES"
        Me.btnEntrenadores.UseVisualStyleBackColor = True
        '
        'btnEntrenamientos
        '
        Me.btnEntrenamientos.Location = New System.Drawing.Point(597, 345)
        Me.btnEntrenamientos.Name = "btnEntrenamientos"
        Me.btnEntrenamientos.Size = New System.Drawing.Size(181, 78)
        Me.btnEntrenamientos.TabIndex = 6
        Me.btnEntrenamientos.Text = "ENTRENAMIENTOS"
        Me.btnEntrenamientos.UseVisualStyleBackColor = True
        '
        'btnJugadores
        '
        Me.btnJugadores.Location = New System.Drawing.Point(842, 355)
        Me.btnJugadores.Name = "btnJugadores"
        Me.btnJugadores.Size = New System.Drawing.Size(142, 124)
        Me.btnJugadores.TabIndex = 7
        Me.btnJugadores.Text = "JUGADORES"
        Me.btnJugadores.UseVisualStyleBackColor = True
        '
        'btnCompetidas
        '
        Me.btnCompetidas.Location = New System.Drawing.Point(114, 465)
        Me.btnCompetidas.Name = "btnCompetidas"
        Me.btnCompetidas.Size = New System.Drawing.Size(170, 66)
        Me.btnCompetidas.TabIndex = 8
        Me.btnCompetidas.Text = "COMPETIDORES"
        Me.btnCompetidas.UseVisualStyleBackColor = True
        '
        'btnCompeticiones
        '
        Me.btnCompeticiones.Location = New System.Drawing.Point(398, 487)
        Me.btnCompeticiones.Name = "btnCompeticiones"
        Me.btnCompeticiones.Size = New System.Drawing.Size(178, 44)
        Me.btnCompeticiones.TabIndex = 9
        Me.btnCompeticiones.Text = "COMPETICIONES"
        Me.btnCompeticiones.UseVisualStyleBackColor = True
        '
        'MenuInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 567)
        Me.Controls.Add(Me.btnCompeticiones)
        Me.Controls.Add(Me.btnCompetidas)
        Me.Controls.Add(Me.btnJugadores)
        Me.Controls.Add(Me.btnEntrenamientos)
        Me.Controls.Add(Me.btnEntrenadores)
        Me.Controls.Add(Me.btnTrofeos)
        Me.Controls.Add(Me.btnProyectos)
        Me.Controls.Add(Me.btnPatrocinios)
        Me.Controls.Add(Me.btnAfiliados)
        Me.Controls.Add(Me.btnClubes)
        Me.Name = "MenuInicio"
        Me.Text = "MenuInicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClubes As Button
    Friend WithEvents btnAfiliados As Button
    Friend WithEvents btnPatrocinios As Button
    Friend WithEvents btnProyectos As Button
    Friend WithEvents btnTrofeos As Button
    Friend WithEvents btnEntrenadores As Button
    Friend WithEvents btnEntrenamientos As Button
    Friend WithEvents btnJugadores As Button
    Friend WithEvents btnCompetidas As Button
    Friend WithEvents btnCompeticiones As Button
End Class
