<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJeuVie
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
        Me.components = New System.ComponentModel.Container()
        Me.gboParamètres = New System.Windows.Forms.GroupBox()
        Me.btnApplySize = New System.Windows.Forms.Button()
        Me.lblSpeedVal = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblGridSize = New System.Windows.Forms.Label()
        Me.lblNbY = New System.Windows.Forms.Label()
        Me.lblNbX = New System.Windows.Forms.Label()
        Me.trckVitesseJeu = New System.Windows.Forms.TrackBar()
        Me.nudNnCasesVerti = New System.Windows.Forms.NumericUpDown()
        Me.nudNnCasesHoriz = New System.Windows.Forms.NumericUpDown()
        Me.btnMotifs = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCustoLive = New System.Windows.Forms.Button()
        Me.btnCustoDead = New System.Windows.Forms.Button()
        Me.btnRule = New System.Windows.Forms.Button()
        Me.lblColorDefDead = New System.Windows.Forms.Label()
        Me.lblColorDefLive = New System.Windows.Forms.Label()
        Me.lblColorCustDead = New System.Windows.Forms.Label()
        Me.lblColorCustLive = New System.Windows.Forms.Label()
        Me.btnColorPickerLiveDefault = New System.Windows.Forms.Button()
        Me.btnColorPickerDeadDefault = New System.Windows.Forms.Button()
        Me.btnColorPickerDeadCusto = New System.Windows.Forms.Button()
        Me.btnColorPickerLiveCusto = New System.Windows.Forms.Button()
        Me.tmrPropagation = New System.Windows.Forms.Timer(Me.components)
        Me.cdCouleurVivant = New System.Windows.Forms.ColorDialog()
        Me.cdCouleurMort = New System.Windows.Forms.ColorDialog()
        Me.PnlConteneur = New System.Windows.Forms.Panel()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.cdAllMort = New System.Windows.Forms.ColorDialog()
        Me.cdAllVie = New System.Windows.Forms.ColorDialog()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.gboParamètres.SuspendLayout()
        CType(Me.trckVitesseJeu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNnCasesVerti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNnCasesHoriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlConteneur.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboParamètres
        '
        Me.gboParamètres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gboParamètres.Controls.Add(Me.btnApplySize)
        Me.gboParamètres.Controls.Add(Me.lblSpeedVal)
        Me.gboParamètres.Controls.Add(Me.lblSpeed)
        Me.gboParamètres.Controls.Add(Me.lblGridSize)
        Me.gboParamètres.Controls.Add(Me.lblNbY)
        Me.gboParamètres.Controls.Add(Me.lblNbX)
        Me.gboParamètres.Controls.Add(Me.trckVitesseJeu)
        Me.gboParamètres.Controls.Add(Me.nudNnCasesVerti)
        Me.gboParamètres.Controls.Add(Me.nudNnCasesHoriz)
        Me.gboParamètres.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboParamètres.Location = New System.Drawing.Point(3, 67)
        Me.gboParamètres.Name = "gboParamètres"
        Me.gboParamètres.Size = New System.Drawing.Size(299, 177)
        Me.gboParamètres.TabIndex = 0
        Me.gboParamètres.TabStop = False
        Me.gboParamètres.Text = "Paramètres"
        '
        'btnApplySize
        '
        Me.btnApplySize.Location = New System.Drawing.Point(211, 49)
        Me.btnApplySize.Name = "btnApplySize"
        Me.btnApplySize.Size = New System.Drawing.Size(88, 26)
        Me.btnApplySize.TabIndex = 7
        Me.btnApplySize.Text = "Appliquer"
        Me.btnApplySize.UseVisualStyleBackColor = True
        '
        'lblSpeedVal
        '
        Me.lblSpeedVal.AutoSize = True
        Me.lblSpeedVal.Location = New System.Drawing.Point(114, 105)
        Me.lblSpeedVal.Name = "lblSpeedVal"
        Me.lblSpeedVal.Size = New System.Drawing.Size(57, 18)
        Me.lblSpeedVal.TabIndex = 6
        Me.lblSpeedVal.Text = "3 ticks/s"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(114, 83)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(64, 18)
        Me.lblSpeed.TabIndex = 5
        Me.lblSpeed.Text = "Vitesse  :"
        '
        'lblGridSize
        '
        Me.lblGridSize.AutoSize = True
        Me.lblGridSize.Location = New System.Drawing.Point(104, 16)
        Me.lblGridSize.Name = "lblGridSize"
        Me.lblGridSize.Size = New System.Drawing.Size(116, 18)
        Me.lblGridSize.TabIndex = 4
        Me.lblGridSize.Text = "Taille de la grille :"
        '
        'lblNbY
        '
        Me.lblNbY.AutoSize = True
        Me.lblNbY.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbY.Location = New System.Drawing.Point(98, 54)
        Me.lblNbY.Name = "lblNbY"
        Me.lblNbY.Size = New System.Drawing.Size(67, 14)
        Me.lblNbY.TabIndex = 3
        Me.lblNbY.Text = "Colonnes ="
        '
        'lblNbX
        '
        Me.lblNbX.AutoSize = True
        Me.lblNbX.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbX.Location = New System.Drawing.Point(0, 54)
        Me.lblNbX.Name = "lblNbX"
        Me.lblNbX.Size = New System.Drawing.Size(51, 14)
        Me.lblNbX.TabIndex = 1
        Me.lblNbX.Text = "Lignes ="
        '
        'trckVitesseJeu
        '
        Me.trckVitesseJeu.Location = New System.Drawing.Point(49, 121)
        Me.trckVitesseJeu.Maximum = 3000
        Me.trckVitesseJeu.Minimum = 100
        Me.trckVitesseJeu.Name = "trckVitesseJeu"
        Me.trckVitesseJeu.Size = New System.Drawing.Size(188, 45)
        Me.trckVitesseJeu.TabIndex = 1
        Me.trckVitesseJeu.Value = 333
        '
        'nudNnCasesVerti
        '
        Me.nudNnCasesVerti.Location = New System.Drawing.Point(166, 49)
        Me.nudNnCasesVerti.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudNnCasesVerti.Name = "nudNnCasesVerti"
        Me.nudNnCasesVerti.Size = New System.Drawing.Size(39, 26)
        Me.nudNnCasesVerti.TabIndex = 2
        Me.nudNnCasesVerti.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nudNnCasesHoriz
        '
        Me.nudNnCasesHoriz.Location = New System.Drawing.Point(57, 49)
        Me.nudNnCasesHoriz.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudNnCasesHoriz.Name = "nudNnCasesHoriz"
        Me.nudNnCasesHoriz.Size = New System.Drawing.Size(39, 26)
        Me.nudNnCasesHoriz.TabIndex = 1
        Me.nudNnCasesHoriz.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'btnMotifs
        '
        Me.btnMotifs.Location = New System.Drawing.Point(20, 489)
        Me.btnMotifs.Name = "btnMotifs"
        Me.btnMotifs.Size = New System.Drawing.Size(126, 39)
        Me.btnMotifs.TabIndex = 0
        Me.btnMotifs.Text = "Motifs Prédéfinis"
        Me.btnMotifs.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Red
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(166, 24)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 37)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnCustoLive
        '
        Me.btnCustoLive.BackColor = System.Drawing.Color.White
        Me.btnCustoLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustoLive.Location = New System.Drawing.Point(108, 426)
        Me.btnCustoLive.Name = "btnCustoLive"
        Me.btnCustoLive.Size = New System.Drawing.Size(91, 39)
        Me.btnCustoLive.TabIndex = 4
        Me.btnCustoLive.Text = "Customiser"
        Me.btnCustoLive.UseVisualStyleBackColor = False
        '
        'btnCustoDead
        '
        Me.btnCustoDead.BackColor = System.Drawing.Color.White
        Me.btnCustoDead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustoDead.Location = New System.Drawing.Point(108, 342)
        Me.btnCustoDead.Name = "btnCustoDead"
        Me.btnCustoDead.Size = New System.Drawing.Size(91, 39)
        Me.btnCustoDead.TabIndex = 5
        Me.btnCustoDead.Text = "Customiser"
        Me.btnCustoDead.UseVisualStyleBackColor = False
        '
        'btnRule
        '
        Me.btnRule.Location = New System.Drawing.Point(196, 489)
        Me.btnRule.Name = "btnRule"
        Me.btnRule.Size = New System.Drawing.Size(88, 39)
        Me.btnRule.TabIndex = 6
        Me.btnRule.Text = "Règles"
        Me.btnRule.UseVisualStyleBackColor = True
        '
        'lblColorDefDead
        '
        Me.lblColorDefDead.AutoSize = True
        Me.lblColorDefDead.Location = New System.Drawing.Point(26, 253)
        Me.lblColorDefDead.Name = "lblColorDefDead"
        Me.lblColorDefDead.Size = New System.Drawing.Size(178, 18)
        Me.lblColorDefDead.TabIndex = 7
        Me.lblColorDefDead.Text = "Couleurs des cases mortes :"
        '
        'lblColorDefLive
        '
        Me.lblColorDefLive.AutoSize = True
        Me.lblColorDefLive.Location = New System.Drawing.Point(26, 283)
        Me.lblColorDefLive.Name = "lblColorDefLive"
        Me.lblColorDefLive.Size = New System.Drawing.Size(186, 18)
        Me.lblColorDefLive.TabIndex = 8
        Me.lblColorDefLive.Text = "Couleurs des cases vivantes :"
        '
        'lblColorCustDead
        '
        Me.lblColorCustDead.AutoSize = True
        Me.lblColorCustDead.Location = New System.Drawing.Point(26, 313)
        Me.lblColorCustDead.Name = "lblColorCustDead"
        Me.lblColorCustDead.Size = New System.Drawing.Size(155, 18)
        Me.lblColorCustDead.TabIndex = 9
        Me.lblColorCustDead.Text = "Cases mortes (custom) :"
        '
        'lblColorCustLive
        '
        Me.lblColorCustLive.AutoSize = True
        Me.lblColorCustLive.Location = New System.Drawing.Point(24, 396)
        Me.lblColorCustLive.Name = "lblColorCustLive"
        Me.lblColorCustLive.Size = New System.Drawing.Size(163, 18)
        Me.lblColorCustLive.TabIndex = 10
        Me.lblColorCustLive.Text = "Cases vivantes (custom) :"
        '
        'btnColorPickerLiveDefault
        '
        Me.btnColorPickerLiveDefault.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnColorPickerLiveDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnColorPickerLiveDefault.Location = New System.Drawing.Point(264, 277)
        Me.btnColorPickerLiveDefault.Name = "btnColorPickerLiveDefault"
        Me.btnColorPickerLiveDefault.Size = New System.Drawing.Size(27, 24)
        Me.btnColorPickerLiveDefault.TabIndex = 11
        Me.btnColorPickerLiveDefault.UseVisualStyleBackColor = False
        '
        'btnColorPickerDeadDefault
        '
        Me.btnColorPickerDeadDefault.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnColorPickerDeadDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnColorPickerDeadDefault.Location = New System.Drawing.Point(265, 247)
        Me.btnColorPickerDeadDefault.Name = "btnColorPickerDeadDefault"
        Me.btnColorPickerDeadDefault.Size = New System.Drawing.Size(27, 24)
        Me.btnColorPickerDeadDefault.TabIndex = 12
        Me.btnColorPickerDeadDefault.UseVisualStyleBackColor = False
        '
        'btnColorPickerDeadCusto
        '
        Me.btnColorPickerDeadCusto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnColorPickerDeadCusto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnColorPickerDeadCusto.Location = New System.Drawing.Point(264, 307)
        Me.btnColorPickerDeadCusto.Name = "btnColorPickerDeadCusto"
        Me.btnColorPickerDeadCusto.Size = New System.Drawing.Size(27, 24)
        Me.btnColorPickerDeadCusto.TabIndex = 13
        Me.btnColorPickerDeadCusto.UseVisualStyleBackColor = False
        '
        'btnColorPickerLiveCusto
        '
        Me.btnColorPickerLiveCusto.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnColorPickerLiveCusto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnColorPickerLiveCusto.Location = New System.Drawing.Point(264, 393)
        Me.btnColorPickerLiveCusto.Name = "btnColorPickerLiveCusto"
        Me.btnColorPickerLiveCusto.Size = New System.Drawing.Size(27, 24)
        Me.btnColorPickerLiveCusto.TabIndex = 14
        Me.btnColorPickerLiveCusto.UseVisualStyleBackColor = False
        '
        'tmrPropagation
        '
        Me.tmrPropagation.Interval = 1000
        '
        'cdCouleurMort
        '
        Me.cdCouleurMort.FullOpen = True
        '
        'PnlConteneur
        '
        Me.PnlConteneur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlConteneur.Controls.Add(Me.btnColorPickerLiveCusto)
        Me.PnlConteneur.Controls.Add(Me.BtnQuit)
        Me.PnlConteneur.Controls.Add(Me.lblColorCustDead)
        Me.PnlConteneur.Controls.Add(Me.btnColorPickerDeadCusto)
        Me.PnlConteneur.Controls.Add(Me.gboParamètres)
        Me.PnlConteneur.Controls.Add(Me.btnColorPickerDeadDefault)
        Me.PnlConteneur.Controls.Add(Me.btnMotifs)
        Me.PnlConteneur.Controls.Add(Me.btnColorPickerLiveDefault)
        Me.PnlConteneur.Controls.Add(Me.btnPlay)
        Me.PnlConteneur.Controls.Add(Me.btnPause)
        Me.PnlConteneur.Controls.Add(Me.lblColorCustLive)
        Me.PnlConteneur.Controls.Add(Me.btnReset)
        Me.PnlConteneur.Controls.Add(Me.lblColorDefLive)
        Me.PnlConteneur.Controls.Add(Me.btnCustoLive)
        Me.PnlConteneur.Controls.Add(Me.lblColorDefDead)
        Me.PnlConteneur.Controls.Add(Me.btnCustoDead)
        Me.PnlConteneur.Controls.Add(Me.btnRule)
        Me.PnlConteneur.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlConteneur.Location = New System.Drawing.Point(626, 12)
        Me.PnlConteneur.Name = "PnlConteneur"
        Me.PnlConteneur.Size = New System.Drawing.Size(305, 610)
        Me.PnlConteneur.TabIndex = 15
        '
        'BtnQuit
        '
        Me.BtnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnQuit.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(196, 559)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(88, 39)
        Me.BtnQuit.TabIndex = 16
        Me.BtnQuit.Text = "Quitter"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.White
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.ForeColor = System.Drawing.Color.Transparent
        Me.btnPlay.Image = Global.ArbreWidgetJeuVie.My.Resources.Resources.play
        Me.btnPlay.Location = New System.Drawing.Point(80, 24)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(37, 37)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.White
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.ForeColor = System.Drawing.Color.Transparent
        Me.btnPause.Image = Global.ArbreWidgetJeuVie.My.Resources.Resources.pause
        Me.btnPause.Location = New System.Drawing.Point(123, 24)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(37, 37)
        Me.btnPause.TabIndex = 2
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoEllipsis = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 625)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(785, 93)
        Me.lblInfo.TabIndex = 16
        Me.lblInfo.Text = "Bienvenue dans le Jeu de la vie"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormJeuVie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 727)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.PnlConteneur)
        Me.Name = "FormJeuVie"
        Me.Text = "Jeu de la vie"
        Me.gboParamètres.ResumeLayout(False)
        Me.gboParamètres.PerformLayout()
        CType(Me.trckVitesseJeu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNnCasesVerti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNnCasesHoriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlConteneur.ResumeLayout(False)
        Me.PnlConteneur.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gboParamètres As GroupBox
    Friend WithEvents btnMotifs As Button
    Friend WithEvents nudNnCasesVerti As NumericUpDown
    Friend WithEvents nudNnCasesHoriz As NumericUpDown
    Friend WithEvents trckVitesseJeu As TrackBar
    Friend WithEvents lblNbY As Label
    Friend WithEvents lblNbX As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents lblSpeedVal As Label
    Friend WithEvents lblSpeed As Label
    Friend WithEvents lblGridSize As Label
    Friend WithEvents btnCustoLive As Button
    Friend WithEvents btnCustoDead As Button
    Friend WithEvents btnRule As Button
    Friend WithEvents lblColorDefDead As Label
    Friend WithEvents lblColorDefLive As Label
    Friend WithEvents lblColorCustDead As Label
    Friend WithEvents lblColorCustLive As Label
    Friend WithEvents btnColorPickerLiveDefault As Button
    Friend WithEvents btnColorPickerDeadDefault As Button
    Friend WithEvents btnColorPickerDeadCusto As Button
    Friend WithEvents btnColorPickerLiveCusto As Button
    Friend WithEvents tmrPropagation As Timer
    Friend WithEvents cdCouleurVivant As ColorDialog
    Friend WithEvents cdCouleurMort As ColorDialog
    Friend WithEvents btnApplySize As Button
    Friend WithEvents PnlConteneur As Panel
    Friend WithEvents cdAllMort As ColorDialog
    Friend WithEvents cdAllVie As ColorDialog
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents lblInfo As Label
End Class
