Imports System.Windows.Forms

Public Class DlgRegle

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'on verifie si les règles que l'utilisateur applique sont correct, sans incohérence avec le texte affiché'
        If (NumMinMort.Value <= NumMaxMort.Value) And (NumMinNaissance.Value <= NumMaxNaissance.Value) Then
            FormJeuVie.changerRegles(NumMinMort.Value, NumMaxMort.Value, NumMinNaissance.Value, NumMaxNaissance.Value)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Vous avez sélectionné des règles incorrectes")
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class
