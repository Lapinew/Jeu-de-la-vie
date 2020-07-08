<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DlgRegle
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DlgRegle))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.LblRegle = New System.Windows.Forms.Label()
        Me.NumMinMort = New System.Windows.Forms.NumericUpDown()
        Me.NumMaxMort = New System.Windows.Forms.NumericUpDown()
        Me.NumMinNaissance = New System.Windows.Forms.NumericUpDown()
        Me.NumMaxNaissance = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumMinMort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMaxMort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMinNaissance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMaxNaissance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(420, 181)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'LblRegle
        '
        Me.LblRegle.AutoSize = True
        Me.LblRegle.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegle.Location = New System.Drawing.Point(22, 22)
        Me.LblRegle.Name = "LblRegle"
        Me.LblRegle.Size = New System.Drawing.Size(524, 108)
        Me.LblRegle.TabIndex = 1
        Me.LblRegle.Text = resources.GetString("LblRegle.Text")
        '
        'NumMinMort
        '
        Me.NumMinMort.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMinMort.Location = New System.Drawing.Point(395, 20)
        Me.NumMinMort.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumMinMort.Name = "NumMinMort"
        Me.NumMinMort.Size = New System.Drawing.Size(29, 26)
        Me.NumMinMort.TabIndex = 2
        Me.NumMinMort.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NumMaxMort
        '
        Me.NumMaxMort.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMaxMort.Location = New System.Drawing.Point(118, 38)
        Me.NumMaxMort.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumMaxMort.Name = "NumMaxMort"
        Me.NumMaxMort.Size = New System.Drawing.Size(29, 26)
        Me.NumMaxMort.TabIndex = 3
        Me.NumMaxMort.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'NumMinNaissance
        '
        Me.NumMinNaissance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMinNaissance.Location = New System.Drawing.Point(305, 91)
        Me.NumMinNaissance.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumMinNaissance.Name = "NumMinNaissance"
        Me.NumMinNaissance.Size = New System.Drawing.Size(29, 26)
        Me.NumMinNaissance.TabIndex = 4
        Me.NumMinNaissance.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'NumMaxNaissance
        '
        Me.NumMaxNaissance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMaxNaissance.Location = New System.Drawing.Point(365, 91)
        Me.NumMaxNaissance.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumMaxNaissance.Name = "NumMaxNaissance"
        Me.NumMaxNaissance.Size = New System.Drawing.Size(29, 26)
        Me.NumMaxNaissance.TabIndex = 5
        Me.NumMaxNaissance.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'DlgRegle
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(578, 222)
        Me.Controls.Add(Me.NumMaxNaissance)
        Me.Controls.Add(Me.NumMinNaissance)
        Me.Controls.Add(Me.NumMaxMort)
        Me.Controls.Add(Me.NumMinMort)
        Me.Controls.Add(Me.LblRegle)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgRegle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Règles du jeu de la vie"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.NumMinMort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMaxMort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMinNaissance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMaxNaissance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LblRegle As Label
    Friend WithEvents NumMinMort As NumericUpDown
    Friend WithEvents NumMaxMort As NumericUpDown
    Friend WithEvents NumMinNaissance As NumericUpDown
    Friend WithEvents NumMaxNaissance As NumericUpDown
End Class
