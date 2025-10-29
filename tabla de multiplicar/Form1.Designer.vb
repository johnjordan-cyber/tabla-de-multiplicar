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
        Label1 = New Label()
        Label2 = New Label()
        txt1 = New TextBox()
        aceptar = New Button()
        BORRAR = New Button()
        Label3 = New Label()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(315, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 38)
        Label1.TabIndex = 0
        Label1.Text = "TABLAS DE MULTIPLICAR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(142, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(712, 38)
        Label2.TabIndex = 1
        Label2.Text = "INTRODUZCA EL NÚMERO DE LA TABLA A GENERAR"
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(605, 160)
        txt1.Name = "txt1"
        txt1.Size = New Size(125, 27)
        txt1.TabIndex = 2
        ' 
        ' aceptar
        ' 
        aceptar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        aceptar.Location = New Point(606, 229)
        aceptar.Name = "aceptar"
        aceptar.Size = New Size(124, 43)
        aceptar.TabIndex = 3
        aceptar.Text = "ACEPTAR"
        aceptar.UseVisualStyleBackColor = True
        ' 
        ' BORRAR
        ' 
        BORRAR.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BORRAR.Location = New Point(603, 328)
        BORRAR.Name = "BORRAR"
        BORRAR.Size = New Size(128, 41)
        BORRAR.TabIndex = 4
        BORRAR.Text = "BORRAR"
        BORRAR.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(472, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 20)
        Label3.TabIndex = 6
        Label3.Text = "ingrese numero"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(167, 167)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(285, 244)
        ListBox1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(991, 578)
        Controls.Add(ListBox1)
        Controls.Add(Label3)
        Controls.Add(BORRAR)
        Controls.Add(aceptar)
        Controls.Add(txt1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents aceptar As Button
    Friend WithEvents BORRAR As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox

End Class
