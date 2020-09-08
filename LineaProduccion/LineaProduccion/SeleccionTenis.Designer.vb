<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionTenis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxModelo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTalla = New System.Windows.Forms.ComboBox()
        Me.EtiquetaPrecio = New System.Windows.Forms.Label()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Linea de produccion de tenis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Talla"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio"
        '
        'ComboBoxModelo
        '
        Me.ComboBoxModelo.FormattingEnabled = True
        Me.ComboBoxModelo.Location = New System.Drawing.Point(405, 110)
        Me.ComboBoxModelo.Name = "ComboBoxModelo"
        Me.ComboBoxModelo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxModelo.TabIndex = 4
        '
        'ComboBoxTalla
        '
        Me.ComboBoxTalla.FormattingEnabled = True
        Me.ComboBoxTalla.Location = New System.Drawing.Point(405, 164)
        Me.ComboBoxTalla.Name = "ComboBoxTalla"
        Me.ComboBoxTalla.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTalla.TabIndex = 5
        '
        'EtiquetaPrecio
        '
        Me.EtiquetaPrecio.AutoSize = True
        Me.EtiquetaPrecio.Location = New System.Drawing.Point(405, 214)
        Me.EtiquetaPrecio.Name = "EtiquetaPrecio"
        Me.EtiquetaPrecio.Size = New System.Drawing.Size(39, 13)
        Me.EtiquetaPrecio.TabIndex = 6
        Me.EtiquetaPrecio.Text = "Label5"
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Location = New System.Drawing.Point(337, 287)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(138, 72)
        Me.ButtonEnviar.TabIndex = 7
        Me.ButtonEnviar.Text = "Siguiente"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'SeleccionTenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 434)
        Me.Controls.Add(Me.ButtonEnviar)
        Me.Controls.Add(Me.EtiquetaPrecio)
        Me.Controls.Add(Me.ComboBoxTalla)
        Me.Controls.Add(Me.ComboBoxModelo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SeleccionTenis"
        Me.Text = "Seleccion Tenis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EtiquetaPrecio As Label
    Friend WithEvents ButtonEnviar As Button
    Public WithEvents ComboBoxModelo As ComboBox
    Public WithEvents ComboBoxTalla As ComboBox
End Class
