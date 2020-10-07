<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnheroe = New System.Windows.Forms.Button()
        Me.txtalien = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar alien"
        '
        'btnheroe
        '
        Me.btnheroe.Location = New System.Drawing.Point(152, 95)
        Me.btnheroe.Name = "btnheroe"
        Me.btnheroe.Size = New System.Drawing.Size(110, 26)
        Me.btnheroe.TabIndex = 1
        Me.btnheroe.Text = "Hora de ser heroe"
        Me.btnheroe.UseVisualStyleBackColor = True
        '
        'txtalien
        '
        Me.txtalien.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtalien.Location = New System.Drawing.Point(152, 53)
        Me.txtalien.Name = "txtalien"
        Me.txtalien.Size = New System.Drawing.Size(129, 20)
        Me.txtalien.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(444, 171)
        Me.Controls.Add(Me.txtalien)
        Me.Controls.Add(Me.btnheroe)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Omnitrix"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnheroe As Button
    Friend WithEvents txtalien As TextBox
End Class
