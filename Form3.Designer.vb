<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Masuk = New System.Windows.Forms.PictureBox()
        Me.Keluar = New System.Windows.Forms.PictureBox()
        CType(Me.Masuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Keluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Geometr415 Blk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SURAT MENYURAT "
        '
        'Masuk
        '
        Me.Masuk.Image = CType(resources.GetObject("Masuk.Image"), System.Drawing.Image)
        Me.Masuk.Location = New System.Drawing.Point(59, 131)
        Me.Masuk.Name = "Masuk"
        Me.Masuk.Size = New System.Drawing.Size(177, 111)
        Me.Masuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Masuk.TabIndex = 5
        Me.Masuk.TabStop = False
        '
        'Keluar
        '
        Me.Keluar.Image = CType(resources.GetObject("Keluar.Image"), System.Drawing.Image)
        Me.Keluar.Location = New System.Drawing.Point(298, 131)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(177, 111)
        Me.Keluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Keluar.TabIndex = 4
        Me.Keluar.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 308)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Masuk)
        Me.Controls.Add(Me.Keluar)
        Me.Name = "Form3"
        Me.Text = "Menu"
        CType(Me.Masuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Keluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Masuk As System.Windows.Forms.PictureBox
    Friend WithEvents Keluar As System.Windows.Forms.PictureBox
End Class
