<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jugadores
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "JUGADORES"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 129)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "LISTADO JUGADORES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(513, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 129)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "BORRAR JUGADOR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(89, 291)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 129)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "CREAR NUEVO JUGADOR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(513, 291)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 129)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "MODIFICAR JUGADOR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(325, 359)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 79)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "VOLVER AL MENÚ"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Jugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Jugadores"
        Me.Text = "Jugadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
