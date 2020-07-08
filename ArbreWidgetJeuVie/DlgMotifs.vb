Imports System.Windows.Forms

Public Class DlgMotifs

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        FormJeuVie.setModeMotifs(False) 'on sort du mode motif'
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub picMotif1_Click(sender As Object, e As EventArgs) Handles picMotif1.Click
        'permet de cliquer sur l'image pour mettre à jour la selection en plus des boutons radio'
        RBtnMotif1.Checked = True
    End Sub

    Private Sub picMotif2_Click(sender As Object, e As EventArgs) Handles picMotif2.Click
        RBtnMotif2.Checked = True
    End Sub

    Private Sub picMotif3_Click(sender As Object, e As EventArgs) Handles picMotif3.Click
        RBtnMotif3.Checked = True
    End Sub
End Class
