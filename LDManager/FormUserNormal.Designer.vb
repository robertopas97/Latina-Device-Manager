<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserNormal
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
        Me.PicBxRequest = New System.Windows.Forms.PictureBox()
        Me.PicBxConsult = New System.Windows.Forms.PictureBox()
        Me.PicBxEdit = New System.Windows.Forms.PictureBox()
        Me.PicBxDelete = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PicBxRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxConsult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBxRequest
        '
        Me.PicBxRequest.Location = New System.Drawing.Point(27, 105)
        Me.PicBxRequest.Name = "PicBxRequest"
        Me.PicBxRequest.Size = New System.Drawing.Size(100, 85)
        Me.PicBxRequest.TabIndex = 0
        Me.PicBxRequest.TabStop = False
        '
        'PicBxConsult
        '
        Me.PicBxConsult.Location = New System.Drawing.Point(133, 105)
        Me.PicBxConsult.Name = "PicBxConsult"
        Me.PicBxConsult.Size = New System.Drawing.Size(100, 85)
        Me.PicBxConsult.TabIndex = 1
        Me.PicBxConsult.TabStop = False
        '
        'PicBxEdit
        '
        Me.PicBxEdit.Location = New System.Drawing.Point(239, 105)
        Me.PicBxEdit.Name = "PicBxEdit"
        Me.PicBxEdit.Size = New System.Drawing.Size(100, 85)
        Me.PicBxEdit.TabIndex = 2
        Me.PicBxEdit.TabStop = False
        '
        'PicBxDelete
        '
        Me.PicBxDelete.Location = New System.Drawing.Point(345, 105)
        Me.PicBxDelete.Name = "PicBxDelete"
        Me.PicBxDelete.Size = New System.Drawing.Size(100, 85)
        Me.PicBxDelete.TabIndex = 3
        Me.PicBxDelete.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Retroceder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario"
        '
        'FormUserNormal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 272)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicBxDelete)
        Me.Controls.Add(Me.PicBxEdit)
        Me.Controls.Add(Me.PicBxConsult)
        Me.Controls.Add(Me.PicBxRequest)
        Me.Name = "FormUserNormal"
        Me.Text = "FormUserNormal"
        CType(Me.PicBxRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxConsult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicBxRequest As System.Windows.Forms.PictureBox
    Friend WithEvents PicBxConsult As System.Windows.Forms.PictureBox
    Friend WithEvents PicBxEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PicBxDelete As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
