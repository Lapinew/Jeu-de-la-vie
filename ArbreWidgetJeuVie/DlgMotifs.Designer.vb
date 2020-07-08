<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgMotifs
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DlgMotifs))
        Me.RBtnMotif1 = New System.Windows.Forms.RadioButton()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.RBtnMotif2 = New System.Windows.Forms.RadioButton()
        Me.RBtnMotif3 = New System.Windows.Forms.RadioButton()
        Me.picMotif3 = New System.Windows.Forms.PictureBox()
        Me.picMotif2 = New System.Windows.Forms.PictureBox()
        Me.picMotif1 = New System.Windows.Forms.PictureBox()
        Me.lblMotifs = New System.Windows.Forms.Label()
        CType(Me.picMotif3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMotif2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMotif1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RBtnMotif1
        '
        Me.RBtnMotif1.AutoSize = True
        Me.RBtnMotif1.Location = New System.Drawing.Point(25, 238)
        Me.RBtnMotif1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBtnMotif1.Name = "RBtnMotif1"
        Me.RBtnMotif1.Size = New System.Drawing.Size(85, 22)
        Me.RBtnMotif1.TabIndex = 2
        Me.RBtnMotif1.TabStop = True
        Me.RBtnMotif1.Text = "le moulin"
        Me.RBtnMotif1.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitter.Location = New System.Drawing.Point(553, 307)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(89, 32)
        Me.btnQuitter.TabIndex = 0
        Me.btnQuitter.Text = "QUITTER"
        '
        'RBtnMotif2
        '
        Me.RBtnMotif2.AutoSize = True
        Me.RBtnMotif2.Location = New System.Drawing.Point(275, 238)
        Me.RBtnMotif2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBtnMotif2.Name = "RBtnMotif2"
        Me.RBtnMotif2.Size = New System.Drawing.Size(97, 22)
        Me.RBtnMotif2.TabIndex = 5
        Me.RBtnMotif2.TabStop = True
        Me.RBtnMotif2.Text = "le planneur"
        Me.RBtnMotif2.UseVisualStyleBackColor = True
        '
        'RBtnMotif3
        '
        Me.RBtnMotif3.AutoSize = True
        Me.RBtnMotif3.Location = New System.Drawing.Point(497, 237)
        Me.RBtnMotif3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBtnMotif3.Name = "RBtnMotif3"
        Me.RBtnMotif3.Size = New System.Drawing.Size(74, 22)
        Me.RBtnMotif3.TabIndex = 6
        Me.RBtnMotif3.TabStop = True
        Me.RBtnMotif3.Text = "le block"
        Me.RBtnMotif3.UseVisualStyleBackColor = True
        '
        'picMotif3
        '
        Me.picMotif3.Image = Global.ArbreWidgetJeuVie.My.Resources.Resources.motif3
        Me.picMotif3.Location = New System.Drawing.Point(504, 175)
        Me.picMotif3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMotif3.Name = "picMotif3"
        Me.picMotif3.Size = New System.Drawing.Size(58, 55)
        Me.picMotif3.TabIndex = 4
        Me.picMotif3.TabStop = False
        '
        'picMotif2
        '
        Me.picMotif2.Image = Global.ArbreWidgetJeuVie.My.Resources.Resources.motif2
        Me.picMotif2.Location = New System.Drawing.Point(284, 161)
        Me.picMotif2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMotif2.Name = "picMotif2"
        Me.picMotif2.Size = New System.Drawing.Size(73, 69)
        Me.picMotif2.TabIndex = 3
        Me.picMotif2.TabStop = False
        '
        'picMotif1
        '
        Me.picMotif1.Image = Global.ArbreWidgetJeuVie.My.Resources.Resources.motif1
        Me.picMotif1.Location = New System.Drawing.Point(44, 151)
        Me.picMotif1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMotif1.Name = "picMotif1"
        Me.picMotif1.Size = New System.Drawing.Size(46, 79)
        Me.picMotif1.TabIndex = 1
        Me.picMotif1.TabStop = False
        '
        'lblMotifs
        '
        Me.lblMotifs.AutoSize = True
        Me.lblMotifs.Location = New System.Drawing.Point(41, 18)
        Me.lblMotifs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMotifs.Name = "lblMotifs"
        Me.lblMotifs.Size = New System.Drawing.Size(562, 90)
        Me.lblMotifs.TabIndex = 7
        Me.lblMotifs.Text = resources.GetString("lblMotifs.Text")
        Me.lblMotifs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DlgMotifs
        '
        Me.AcceptButton = Me.btnQuitter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 350)
        Me.Controls.Add(Me.lblMotifs)
        Me.Controls.Add(Me.RBtnMotif3)
        Me.Controls.Add(Me.RBtnMotif2)
        Me.Controls.Add(Me.picMotif3)
        Me.Controls.Add(Me.picMotif2)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.RBtnMotif1)
        Me.Controls.Add(Me.picMotif1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgMotifs"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DlgMotifs"
        Me.TopMost = True
        CType(Me.picMotif3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMotif2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMotif1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMotif1 As PictureBox
    Friend WithEvents RBtnMotif1 As RadioButton
    Friend WithEvents btnQuitter As Button
    Friend WithEvents picMotif2 As PictureBox
    Friend WithEvents picMotif3 As PictureBox
    Friend WithEvents RBtnMotif2 As RadioButton
    Friend WithEvents RBtnMotif3 As RadioButton
    Friend WithEvents lblMotifs As Label
End Class
