﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoPatrocinio
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.txtClub = New System.Windows.Forms.TextBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NUEVO PATROCINIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CÓDIGO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 258)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "CÓDIGO DEL CLUB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "PAGO"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(336, 124)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigo.TabIndex = 14
        '
        'txtPago
        '
        Me.txtPago.Location = New System.Drawing.Point(336, 217)
        Me.txtPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(76, 20)
        Me.txtPago.TabIndex = 16
        '
        'txtClub
        '
        Me.txtClub.Location = New System.Drawing.Point(337, 262)
        Me.txtClub.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtClub.Name = "txtClub"
        Me.txtClub.Size = New System.Drawing.Size(76, 20)
        Me.txtClub.TabIndex = 17
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(357, 325)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(56, 30)
        Me.btnCrear.TabIndex = 18
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(125, 325)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(56, 30)
        Me.btnLimpiar.TabIndex = 19
        Me.btnLimpiar.Text = "Atrás"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(337, 169)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(76, 20)
        Me.txtNombre.TabIndex = 20
        '
        'NuevoPatrocinio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.txtClub)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "NuevoPatrocinio"
        Me.Text = "NuevoPatrocinio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtPago As TextBox
    Friend WithEvents txtClub As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtNombre As TextBox
End Class
