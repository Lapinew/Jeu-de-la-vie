Public Class Moteur
    Private nbLignes As Integer 'Permet de definir la limite des boucles
    Private nbColonnes As Integer 'Permet de definir la limite des boucles
    Private Const NB_BOUTONS_MAX As Integer = 1000 'On donne la taille maximum de tableau d'etat (500 x 500 "cellules" au max)
    Public EtatBoutons(NB_BOUTONS_MAX - 1, NB_BOUTONS_MAX - 1) As Boolean 'Tableau contenant le réel état des boutons
    Public EtatBoutonsTemp(NB_BOUTONS_MAX - 1, NB_BOUTONS_MAX - 1) As Boolean 'Tableau permettant de de stocker temporairement les etats lors de la mise a jour pour ne pas fausser les suivants dans le vrai tableau

    Private minMort As Integer
    Private maxMort As Integer
    Private minNaissance As Integer
    Private maxNaissance As Integer

    Public Sub setRegle(minMort As Integer, maxMort As Integer, minNaissance As Integer, maxNaissance As Integer) 'Change les regles du moteur en fonction des parametres donnés
        Me.minMort = minMort
        Me.maxMort = maxMort
        Me.minNaissance = minNaissance
        Me.maxNaissance = maxNaissance
    End Sub

    Public Sub setTailleGrille(n As Integer, m As Integer) 'Change la taille du tableau de etats en fonction des parametres donnés
        nbLignes = n
        nbColonnes = m
    End Sub

    Public Sub getTailleGrille(ByRef n As Integer, ByRef m As Integer) 'Get la taille du tableau de etats
        n = nbLignes
        m = nbColonnes
    End Sub

    'Changer l'etat d'une cellule précise
    Public Sub setEtatCellule(ligne As Integer, colonne As Integer, etat As Boolean) 'etat : vrai si vivant, faux sinon
        EtatBoutons(ligne, colonne) = etat
    End Sub

    'Get l'etat d'une cellule précise
    Public Function getEtatCellule(ligne As Integer, colonne As Integer) As Boolean 'retourne vrai si vivant, faux sinon
        Return EtatBoutons(ligne, colonne)
    End Function

    Public Sub etatSuivant() 'Pour chaque bouton on compte le nombre de vivants autour de lui (variable vie) et on change (ou pas) son état en conséquence (dépend des règles).
        'Dans cette premiere double boucle, on change l'etat de chaque bouton dans le tableau TEMPORAIRE pour éviter que le changement d'un bouton n'influe sur les boutons suivants.
        Dim vie As Integer = 0 'Variable pour stocker le nombre de vivants autour du bouton actuel
        Dim liBtn As Integer = 0 'Tampon pour stocker la ligne d'un bouton
        Dim colBtn As Integer = 0 'Tampon pour stocker la colonne d'un bouton
        For ligne As Integer = 0 To nbLignes - 1
            For colonne As Integer = 0 To nbColonnes - 1
                vie = 0 'On remet vie à zéro.

                'calcul si le bouton en haut à gauche est vivant ou mort meme si il est de l'autre cote de la grille
                liBtn = ligne - 1
                colBtn = colonne - 1
                If liBtn < 0 Then
                    liBtn = nbLignes - 1
                End If
                If colBtn < 0 Then
                    colBtn = nbColonnes - 1
                End If
                If EtatBoutons(liBtn, colBtn) = True Then
                    vie += 1
                End If

                'calcul si le bouton à gauche est vivant ou mort meme si il est de l'autre cote de la grille
                liBtn = ligne
                colBtn = colonne - 1
                If colBtn < 0 Then
                    colBtn = nbColonnes - 1
                End If
                If EtatBoutons(liBtn, colBtn) = True Then
                    vie += 1
                End If

                'calcul si le bouton en bas à gauche est vivant ou mort meme si il est de l'autre cote de la grille
                liBtn = ligne + 1
                colBtn = colonne - 1
                If liBtn > nbLignes - 1 Then
                    liBtn = 0
                End If
                If colBtn < 0 Then
                    colBtn = nbColonnes - 1
                End If
                If EtatBoutons(liBtn, colBtn) = True Then
                    vie += 1
                End If

                'calcul si le bouton en haut est vivant ou mort meme si il est de l'autre cote de la grille
                liBtn = ligne - 1
                colBtn = colonne
                If liBtn < 0 Then
                    liBtn = nbLignes - 1
                End If
                If EtatBoutons(liBtn, colBtn) = True Then
                    vie += 1
                End If

                'calcul si le bouton en bas est vivant ou mort meme si il est de l'autre cote de la grille
                liBtn = ligne + 1
                colBtn = colonne
                If liBtn > nbLignes - 1 Then
                    liBtn = 0
                End If
                If EtatBoutons(liBtn, colBtn) = True Then
                    vie += 1
                End If

                'calcul si le bouton en haut à droite est vivant ou mort meme si il est de l'autre cote de la grille
                liBtn = ligne - 1
                colBtn = colonne + 1
                If liBtn < 0 Then
                    liBtn = nbLignes - 1
                End If
                If colBtn > nbColonnes - 1 Then
                    colBtn = 0
                End If
                If EtatBoutons(liBtn, colBtn) = True Then
                    vie += 1
                End If

                'calcul si le bouton à droite est vivant ou mort meme si il est de l'autre cote de la grille
                liBtn = ligne
                colBtn = colonne + 1
                If colBtn > nbColonnes - 1 Then
                    colBtn = 0
                End If
                If EtatBoutons(liBtn, colBtn) = True Then
                    vie += 1
                End If

                'calcul si le bouton en bas à droite est vivant ou mort meme si il est de l'autre cote de la grille
                liBtn = ligne + 1
                colBtn = colonne + 1
                If liBtn > nbLignes - 1 Then
                    liBtn = 0
                End If
                If colBtn > nbColonnes - 1 Then
                    colBtn = 0
                End If
                If EtatBoutons(liBtn, colBtn) = True Then
                    vie += 1
                End If

                If EtatBoutons(ligne, colonne) = False Then 'Si le bouton est acuellement mort
                    If vie >= minNaissance And vie <= maxNaissance Then 'Et qu'il est entouré d'exactement 3 vivants
                        EtatBoutonsTemp(ligne, colonne) = True 'Alors il prend vie
                    End If
                ElseIf vie < minMort Or vie > maxMort Then 'Si le bouton est actuellement vivant et qu'il a un nombre de vivants autour de lui différent de 2 ou 3
                    EtatBoutonsTemp(ligne, colonne) = False 'Alors il meurt
                Else EtatBoutonsTemp(ligne, colonne) = True 'Sinon il reste vivant. Etrangement, cette ligne est obligatoire sinon le bouton meurt à tous les coups.
                End If
            Next
        Next
        'Dans cette double boucle, on met a jour le vrai tableau de boutons (maintenant qu'on a mis a jour proprement dans le tableau temporaire).
        For ligne As Integer = 0 To nbLignes - 1
            For colonne As Integer = 0 To nbColonnes - 1
                EtatBoutons(ligne, colonne) = EtatBoutonsTemp(ligne, colonne)
            Next
        Next
    End Sub
End Class



