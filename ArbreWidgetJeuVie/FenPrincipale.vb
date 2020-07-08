Public Class FormJeuVie
    Private Const TAILLE As Integer = 20 'Dimension d'un bouton
    Private Const NB_BOUTONS_MAX As Integer = 1000 'On donne la taille maximum d'un tableau de bouton (500 x 500 boutons au max)
    Private Const MINMORT_DFLT As Integer = 2 'Regles du jeu par defaut
    Private Const MAXMORT_DFLT As Integer = 3
    Private Const MINNAIS_DFLT As Integer = 3
    Private Const MAXNAIS_DFLT As Integer = 3
    Private nbLignes As Integer 'Stock le nombre de lignes occupées par les boutons
    Private nbcolonnes As Integer 'Stock le nombre de colonnes occupées par les boutons
    Private monMoteur As New Moteur 'Créer une instance du moteur
    Private pnlBoutons As New TableLayoutPanel 'LayoutPanel dans lequel on stock nos boutons
    Private Boutons(NB_BOUTONS_MAX - 1, NB_BOUTONS_MAX - 1) As Button 'Tableau stockant les boutons
    Private ColorsLife(NB_BOUTONS_MAX - 1, NB_BOUTONS_MAX - 1) As Color 'Tableau permettant d'assigner la couleur de l'etat vivant de chaque bouton (une coordonnée = une couleur, chaque coordonnée est la meme qu'un bouton dans le tableau de bouton)
    Private ColorsDeath(NB_BOUTONS_MAX - 1, NB_BOUTONS_MAX - 1) As Color 'Tableau permettant d'assigner la couleur de l'etat mort de chaque bouton
    Private btnligne As Integer 'Variable tampon permettant de stocker la ligne d'un bouton en particulier (recuperable grace à un calcul)
    Private btnColonne As Integer 'Variable tampon permettant de stocker la colonne d'un bouton en particulier (recuperable grace à un calcul)
    Private numBtn As Integer 'Variable tampon permettant de stocker le numero d'un bouton dans son conteneur


    'Booleans permettant de gérer les modes --> Quand un boolean est en true, il permet à sa fonction associée de fonctionner
    Private boolColorLife As Boolean 'True --> permet de modifier individuellement la couleur "vivante" de chaque bouton
    Private boolColorDeath As Boolean 'True --> permet de modifier individuellement la couleur "morte" de chaque bouton
    Private modeMotif As Boolean = False 'True --> permet d'importer des motifs d'une autre fenetre

    Private Sub FormJeuVie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boolColorDeath = False 'Par defaut le mode est désactivé
        boolColorLife = False 'Par defaut le mode est désactivé
        CreerGrille() 'On créer la grille et toutes les données nécéssaires à son fonctionnement
        'Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        'Me.AutoSize = True
    End Sub

    Private Sub CreerGrille() 'Créer la grille et toutes les données nécéssaires à sa création
        nbLignes = nudNnCasesHoriz.Value 'On récupère le nombre de lignes à créer dans le numericDropDown associé
        nbcolonnes = nudNnCasesVerti.Value 'On récupère le nombre de colonnes à créer dans le numericDropDown associé
        monMoteur.setTailleGrille(nbLignes, nbcolonnes) 'On attribue au tableau gérant les états (dans le moteur) le nombre de lignes et colonnes etabli
        With pnlBoutons 'On défini des attributs du panelLayout contenant les boutons :
            .ColumnCount = nbcolonnes
            .RowCount = nbLignes
            .AutoSize = True
            .Dock = DockStyle.Left
        End With
        Controls.Add(pnlBoutons) 'On ajoute le panelLayout au conteneur principal de la fenetre/form
        For i As Integer = 0 To nbLignes - 1 'On va créer le nombre de boutons defini par colonnes(j) x lignes(i)
            For j As Integer = 0 To nbcolonnes - 1
                Dim btn As New Button 'On crée un bouton
                With btn 'Auquel on donne des attributs
                    '.Location = New Point(i, j)
                    .Size = New Size(TAILLE, TAILLE)
                    .Margin = Padding.Empty
                    .FlatStyle = FlatStyle.Popup 'On enleve les contours des boutons
                    .BackColor = Color.Black 'Par defaut le tableau est rempli de boutons morts (donc noirs)
                End With
                'Quand on clique sur un bouton :
                AddHandler btn.Click, AddressOf ChangerEtat 'On peut changer son etat
                AddHandler btn.Click, AddressOf ChangerColorLife 'On peut changer sa couleur dans l'état vivant
                AddHandler btn.Click, AddressOf ChangerColorDeath 'On peut changer sa couleur dans l'état mort
                AddHandler btn.Click, AddressOf AppliquerMotif 'Il peut servir de position de départ d'un motif prédéfini
                Boutons(i, j) = btn 'On ajoute ce bouton au tableau de boutons
                pnlBoutons.Controls.Add(Boutons(i, j)) 'On ajoute ce bouton au layoutPanel
                ColorsLife(i, j) = Color.White 'On lui donne la couleur blanche comme couleur vivante par defaut
                ColorsDeath(i, j) = Color.Black 'On lui donne la couleur noir comme couleur morte par defaut
            Next
        Next
        monMoteur.setRegle(MINMORT_DFLT, MAXMORT_DFLT, MINNAIS_DFLT, MAXNAIS_DFLT) 'On applique au moteur des regles par defaut
    End Sub

    Private Sub ChangerColorLife(sender As Object, e As EventArgs) 'Permet sous certaines conditions que quand on clique sur bouton on puisse changer sa couleur "vivante"
        If boolColorDeath = False And boolColorLife = True And tmrPropagation.Enabled = False Then 'Si le jeu n'est pas en cours, qu'on ne modifie pas les couleurs mortes et qu'on est bien en mode de cusomisation des couleurs vivantes
            numBtn = pnlBoutons.Controls.GetChildIndex(CType(sender, Button)) 'on récupere le numero du bouton séléctionné
            'on recupere la ligne du bouton en divisant par le nombre de colonnes pour avoir l'entier inférieur,
            'tant qu'on ne depasse l'entier suivant on reste sur la meme ligne 
            btnligne = numBtn \ nbcolonnes 'Ligne du bouton
            btnColonne = numBtn Mod nbcolonnes 'Colonne du bouton
            ColorsLife(btnligne, btnColonne) = btnColorPickerLiveCusto.BackColor 'On change sa couleur vivante dans le tableau des couleurs vivantes
            MiseAJourIndiv(btnligne, btnColonne) 'On met a jour la veritable couleur du bouton dans le tableau de boutons en allant chercher la couleur dans le tableau de couleur qu'on a mis a jour juste au dessus
        End If
    End Sub

    Private Sub ChangerColorDeath(sender As Object, e As EventArgs) 'Meme principe que la fonction ci-dessus mais pour changer la couleur morte
        If boolColorLife = False And boolColorDeath = True And tmrPropagation.Enabled = False Then
            numBtn = pnlBoutons.Controls.GetChildIndex(CType(sender, Button))
            'on recupere la ligne du bouton en divisant par le nombre de colonnes pour avoir l'entier inférieur,
            'tant qu'on ne depasse l'entier suivant on reste sur la meme ligne 
            btnligne = numBtn \ nbcolonnes
            btnColonne = numBtn Mod nbcolonnes
            ColorsDeath(btnligne, btnColonne) = btnColorPickerDeadCusto.BackColor
            MiseAJourIndiv(btnligne, btnColonne)
        End If
    End Sub

    Private Sub ChangerEtat(sender As Object, e As EventArgs)
        If boolColorDeath = False And boolColorLife = False And tmrPropagation.Enabled = 0 And modeMotif = False Then 'Si on est pas en train de changer la couleur ou si on est pas en jeu
            numBtn = pnlBoutons.Controls.GetChildIndex(CType(sender, Button))
            'on recupere la ligne du bouton en divisant par le nombre de colonnes pour avoir l'entier inférieur,
            'tant qu'on ne depasse l'entier suivant on reste sur la meme ligne 
            btnligne = numBtn \ nbcolonnes 'Ligne du bouton
            btnColonne = numBtn Mod nbcolonnes 'Colonne du bouton
            If monMoteur.getEtatCellule(btnligne, btnColonne) = True Then 'Si le bouton est vivant (true)
                monMoteur.setEtatCellule(btnligne, btnColonne, False) 'On le tue (false)
                CType(sender, Button).BackColor = ColorsDeath(btnligne, btnColonne) 'Et on change sa couleur
            Else
                monMoteur.setEtatCellule(btnligne, btnColonne, True) 'Sinon il est mort et donc on le rend vivant
                CType(sender, Button).BackColor = ColorsLife(btnligne, btnColonne) 'Et on change sa couleur
            End If
        End If
    End Sub

    Private Sub MiseAJourIndiv(i As Integer, j As Integer) 'Permet de mettre a jour individuellement la couleur d'un bouton
        If monMoteur.getEtatCellule(i, j) = True Then 'Si le bouton est vivant
            Boutons(i, j).BackColor = ColorsLife(i, j) 'On lui donne sa couleur vivante associée
        Else Boutons(i, j).BackColor = ColorsDeath(i, j) 'Sinon il est mort et on lui donne sa couleur morte associée
        End If
    End Sub

    Private Sub MiseAJour() 'Meme chose que la fonction au-dessus mais on met a jour tout les boutons
        For i As Integer = 0 To nbLignes - 1
            For j As Integer = 0 To nbcolonnes - 1
                If monMoteur.getEtatCellule(i, j) = True Then
                    Boutons(i, j).BackColor = ColorsLife(i, j)
                Else Boutons(i, j).BackColor = ColorsDeath(i, j)
                End If
            Next
        Next
    End Sub

    Private Sub tmrPropagation_Tick(sender As Object, e As EventArgs) Handles tmrPropagation.Tick 'Ce qu'il se passe à chaque "tick" du timer regulant le jeu
        monMoteur.etatSuivant() 'On change les etats des boutons selon leur voisins
        MiseAJour() 'Et on met à jour leur couleur
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click 'Quand on clique sur play
        If tmrPropagation.Enabled = 0 And boolColorLife = False And boolColorDeath = False Then 'Si on est pas entrain de changer les couleur ou qu'on est pas deja en jeu
            tmrPropagation.Start() 'Le timer démarre
            lblInfo.Text = "Le jeu est en Lecture, vous ne pouvez pas modifier la grille, pour la modifier mettez le jeu en pause" 'On fait savoir a l'utilisateur que le jeu tourne et qu'il ne peut plus rien modifier sur la grille
            btnPlay.BackColor = Color.LightGreen
            btnPause.BackColor = Color.White
        Else MessageBox.Show("Vous etes encore dans un mode de customization des couleurs ou vous etes déja en jeu.")
        End If
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click 'Quand on clique sur pause
        tmrPropagation.Stop() 'Le timer est arreté
        btnPause.BackColor = Color.LightGreen
        btnPlay.BackColor = Color.White
        lblInfo.Text = "Le jeu est en Pause" 'On le fait savoir a l'utilisateur
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click 'Quand on clique sur reset
        If (MsgBox("Voulez-vous vraiment nettoyer la grille actuelle ?", MsgBoxStyle.YesNo, "Nettoyer") = MsgBoxResult.Yes) Then 'On demande de confirmer l'action
            tmrPropagation.Stop()
            btnPause.BackColor = Color.LightGreen
            btnPlay.BackColor = Color.White
            lblInfo.Text = "Le jeu est en Pause"
            reset() 'Fonction permettant de reset les données nécéssaires au fonctionnement de la grille/du jeu
        End If
    End Sub

    Private Sub btnColorPickerDeadCusto_Click(sender As Object, e As EventArgs) Handles btnColorPickerDeadCusto.Click 'Quand on clique sur le colorPicker (un bouton en soit) permettant de choisir la couleur des cases mortes à customiser
        If (cdCouleurMort.ShowDialog() = DialogResult.OK) Then
            CType(sender, Button).BackColor = cdCouleurMort.Color 'On applique AU BOUTON DU colorPicker la couleur choisi
        End If
    End Sub

    Private Sub btnColorPickerLiveCusto_Click(sender As Object, e As EventArgs) Handles btnColorPickerLiveCusto.Click 'Meme chose que au-dessus mais pour les couleurs vivantes
        If (cdCouleurVivant.ShowDialog() = DialogResult.OK) Then
            CType(sender, Button).BackColor = cdCouleurVivant.Color
        End If
    End Sub

    Private Sub btnCustoDead_Click(sender As Object, e As EventArgs) Handles btnCustoDead.Click 'Quand on clique sur le bouton "customiser" permettant d'activer/desactiver le mode de personnalisation de la couleur des cases morte
        If tmrPropagation.Enabled = False Then 'Si on est pas en jeu
            If btnCustoDead.BackColor = Color.White Then 'On change l'apparence du bouton pour montrer que le mode est actif (bouton foncé)
                lblInfo.Text = "Vous êtes en mode customisation de couleurs"
                boolColorDeath = True
                boolColorLife = False
                btnCustoLive.BackColor = Color.White
                btnCustoDead.BackColor = Color.Gray
            Else
                lblInfo.Text = "Vous avez quitter le mode customisation de couleurs" 'Bouton clair pour indiquer qu'on a quitter le mode
                boolColorDeath = False
                btnCustoDead.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub btnCustoLive_Click(sender As Object, e As EventArgs) Handles btnCustoLive.Click 'Meme chose que au-dessus mais pour l'autre customiser (cases vivantes)
        If tmrPropagation.Enabled = False Then
            If btnCustoLive.BackColor = Color.White Then
                lblInfo.Text = "Vous êtes en mode customisation de couleurs"
                boolColorDeath = False
                boolColorLife = True
                btnCustoDead.BackColor = Color.White
                btnCustoLive.BackColor = Color.Gray
            Else
                lblInfo.Text = "Vous avez quitter le mode customisation de couleurs"
                boolColorLife = False
                btnCustoLive.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub trckVitesseJeu_Scroll(sender As Object, e As EventArgs) Handles trckVitesseJeu.Scroll 'Quand on change la trackBar associée à la vitesse du jeu
        tmrPropagation.Interval = trckVitesseJeu.Value 'On applique l'intervalle des ticks voulu par l'utlisateur
        lblSpeedVal.Text = Math.Round((1 / tmrPropagation.Interval * 1000), 2).ToString + " ticks/s" 'On montre visuellement la vitesse de jeu
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click 'Quand on clique sur le bouton quitter
        If (MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.YesNo, "Quitter l'application") = MsgBoxResult.Yes) Then 'On demande de confirmer
            Me.Dispose()
        End If
    End Sub

    Private Sub reset() 'Fonction permettant de remettre les tableaux "a zero" (comme quand on lance l'application)
        For i As Integer = 0 To nbLignes - 1
            For j As Integer = 0 To nbcolonnes - 1
                ColorsLife(i, j) = Color.White 'Tout les boutons on blanc comme couleur vivante
                ColorsDeath(i, j) = Color.Black 'Tout les boutons on noir comme couleur morte
                monMoteur.EtatBoutons(i, j) = False 'Tout les boutons sont morts
                monMoteur.EtatBoutonsTemp(i, j) = False
                Boutons(i, j).BackColor = Color.Black 'Tout les boutons sont noirs
            Next
        Next
    End Sub

    Private Sub btnApplySize_Click(sender As Object, e As EventArgs) Handles btnApplySize.Click 'Quand on clique sur le bouton appliquer (pour changer les dimensions de la grille)
        If tmrPropagation.Enabled = 0 Then 'Si on est pas en jeu
            pnlBoutons.Controls.Clear() 'On vide le tableLayout des boutons
            reset() 'expliqué au dessus
            CreerGrille() 'On recréé la grille qui va prendre la nouvelle taille saisie par l'utilisateur
        End If
    End Sub

    Private Sub btnRule_Click(sender As Object, e As EventArgs) Handles btnRule.Click 'Quand on clique sur le bouton regles
        lblInfo.Text = "Vous êtes en mode selection des règles"
        btnPause.BackColor = Color.LightGreen
        btnPlay.BackColor = Color.White
        tmrPropagation.Stop()
        DlgRegle.ShowDialog() 'Affiche la fenetre des regles
        lblInfo.Text = "Vous avez quitter la selection des règles"
    End Sub

    Public Sub changerRegles(minMort As Integer, maxMort As Integer, minNaissance As Integer, maxnaissance As Integer) 'Change les regles du moteur en fonction des parametres donnés
        monMoteur.setRegle(minMort, maxMort, minNaissance, maxnaissance)
    End Sub

    Public Sub setModeMotifs(mode As Boolean) 'Permet d'activer le mode permettant d'importer des motifs
        modeMotif = mode
    End Sub

    Private Sub btnMotifs_Click(sender As Object, e As EventArgs) Handles btnMotifs.Click 'permet d'acceder à la fenêtre des motifs'
        modeMotif = True 'On active le mode
        If boolColorLife Then 'Si on etait en train de personnaliser les couleurs, on arrete les modes associés
            boolColorLife = False
            btnCustoLive.BackColor = Color.White
        ElseIf boolColorDeath Then
            boolColorDeath = False
            btnCustoDead.BackColor = Color.White
        End If
        lblInfo.Text = "Vous êtes en mode selection de motifs"
        tmrPropagation.Stop()
        btnPause.BackColor = Color.LightGreen
        btnPlay.BackColor = Color.White
        DlgMotifs.Show() ' on affiche la fenêtre'
        lblInfo.Text = "Vous avez quitter le mode sélection de motifs"
    End Sub

    Private Sub AppliquerMotif(sender As Object, e As EventArgs)
        If boolColorDeath = False And boolColorLife = False And tmrPropagation.Enabled = 0 And modeMotif Then 'Si on est pas en train de changer la couleur ou si on est pas en jeu et qu'on est bien en mode motif'

            'on récupère les coordonées du boutons où est appliqué le motif'
            numBtn = pnlBoutons.Controls.GetChildIndex(CType(sender, Button))
            btnligne = numBtn \ nbcolonnes
            btnColonne = numBtn Mod nbcolonnes

            'on verifie quel motif est selectionné'
            If DlgMotifs.RBtnMotif1.Checked Then
                If btnligne + 1 < nbLignes And btnligne - 1 >= 0 Then 'on verifie les cas ou la forme sort de la fenetre'
                    monMoteur.setEtatCellule(btnligne, btnColonne, True)
                    'on met à jour les cellules autour du bouton selectionné pour generer le motifs'
                    CType(sender, Button).BackColor = ColorsLife(btnligne, btnColonne)
                    AjouterCelluleMotif(1, 0)
                    AjouterCelluleMotif(-1, 0)
                Else
                    MessageBox.Show("Vous ne pouvez pas placer de motifs en dehors de la grille !")
                End If
            End If
            If DlgMotifs.RBtnMotif2.Checked Then
                If btnColonne - 1 >= 0 And btnligne - 2 >= 0 And btnColonne + 1 < nbcolonnes Then
                    monMoteur.setEtatCellule(btnligne, btnColonne, True)
                    CType(sender, Button).BackColor = ColorsLife(btnligne, btnColonne)
                    AjouterCelluleMotif(0, -1)
                    AjouterCelluleMotif(0, 1)
                    AjouterCelluleMotif(-1, 1)
                    AjouterCelluleMotif(-2, 0)
                Else
                    MessageBox.Show("Vous ne pouvez pas placer de motifs en dehors de la grille !")
                End If
            End If
            If DlgMotifs.RBtnMotif3.Checked Then
                If btnligne + 1 < nbLignes And btnColonne + 1 < nbcolonnes Then
                    monMoteur.setEtatCellule(btnligne, btnColonne, True)
                    CType(sender, Button).BackColor = ColorsLife(btnligne, btnColonne)
                    AjouterCelluleMotif(0, 1)
                    AjouterCelluleMotif(1, 1)
                    AjouterCelluleMotif(1, 0)
                Else
                    MessageBox.Show("Vous ne pouvez pas placer de motifs en dehors de la grille !")
                End If
            End If
        End If
    End Sub

    Private Sub AjouterCelluleMotif(offsetligne As Integer, offsetcolonne As Integer)
        'permet de mettre l'état d'une celule avec un décalage de ligne ou de colonnes'
        monMoteur.setEtatCellule(btnligne + offsetligne, btnColonne + offsetcolonne, True)
        'on met à jour la couleur'
        Boutons(btnligne + offsetligne, btnColonne + offsetcolonne).BackColor = ColorsLife(btnligne + offsetligne, btnColonne + offsetcolonne)
    End Sub

    Private Sub btnColorPickerDeadDefault_Click(sender As Object, e As EventArgs) Handles btnColorPickerDeadDefault.Click 'Quand on clique sur le colorPicker "Cases mortes"
        If (cdAllMort.ShowDialog() = DialogResult.OK) Then 'On applique A TOUTES LES CASES la couleur morte choisie le color picker
            CType(sender, Button).BackColor = cdAllMort.Color
            For i As Integer = 0 To nbLignes - 1
                For j As Integer = 0 To nbcolonnes - 1
                    ColorsDeath(i, j) = cdAllMort.Color
                    MiseAJourIndiv(i, j)
                Next
            Next
        End If
    End Sub

    Private Sub btnColorPickerLiveDefault_Click(sender As Object, e As EventArgs) Handles btnColorPickerLiveDefault.Click 'Quand on clique sur le colorPicker "Cases vivantes"
        If (cdAllVie.ShowDialog() = DialogResult.OK) Then 'On applique A TOUTES LES CASES la couleur vivante choisie dans le color picker
            CType(sender, Button).BackColor = cdAllVie.Color
            For i As Integer = 0 To nbLignes - 1
                For j As Integer = 0 To nbcolonnes - 1
                    ColorsLife(i, j) = cdAllVie.Color
                    MiseAJourIndiv(i, j)
                Next
            Next
        End If
    End Sub
End Class
