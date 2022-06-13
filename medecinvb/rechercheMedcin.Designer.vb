<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rechercheMedcin
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ck_nom = New System.Windows.Forms.CheckBox()
        Me.ck_prenom = New System.Windows.Forms.CheckBox()
        Me.ck_ville = New System.Windows.Forms.CheckBox()
        Me.ck_specialite = New System.Windows.Forms.CheckBox()
        Me.ck_salaire = New System.Windows.Forms.CheckBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.txt_salaire = New System.Windows.Forms.TextBox()
        Me.cb_ville = New System.Windows.Forms.ComboBox()
        Me.cb_specialite = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(89, 285)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(624, 185)
        Me.DataGridView1.TabIndex = 0
        '
        'ck_nom
        '
        Me.ck_nom.AutoSize = True
        Me.ck_nom.Location = New System.Drawing.Point(36, 43)
        Me.ck_nom.Name = "ck_nom"
        Me.ck_nom.Size = New System.Drawing.Size(71, 19)
        Me.ck_nom.TabIndex = 1
        Me.ck_nom.Text = "Par nom"
        Me.ck_nom.UseVisualStyleBackColor = True
        '
        'ck_prenom
        '
        Me.ck_prenom.AutoSize = True
        Me.ck_prenom.Location = New System.Drawing.Point(36, 89)
        Me.ck_prenom.Name = "ck_prenom"
        Me.ck_prenom.Size = New System.Drawing.Size(88, 19)
        Me.ck_prenom.TabIndex = 2
        Me.ck_prenom.Text = "Par prenom"
        Me.ck_prenom.UseVisualStyleBackColor = True
        '
        'ck_ville
        '
        Me.ck_ville.AutoSize = True
        Me.ck_ville.Location = New System.Drawing.Point(39, 124)
        Me.ck_ville.Name = "ck_ville"
        Me.ck_ville.Size = New System.Drawing.Size(67, 19)
        Me.ck_ville.TabIndex = 3
        Me.ck_ville.Text = "Par ville"
        Me.ck_ville.UseVisualStyleBackColor = True
        '
        'ck_specialite
        '
        Me.ck_specialite.AutoSize = True
        Me.ck_specialite.Location = New System.Drawing.Point(39, 168)
        Me.ck_specialite.Name = "ck_specialite"
        Me.ck_specialite.Size = New System.Drawing.Size(95, 19)
        Me.ck_specialite.TabIndex = 4
        Me.ck_specialite.Text = "Par specialite"
        Me.ck_specialite.UseVisualStyleBackColor = True
        '
        'ck_salaire
        '
        Me.ck_salaire.AutoSize = True
        Me.ck_salaire.Location = New System.Drawing.Point(41, 214)
        Me.ck_salaire.Name = "ck_salaire"
        Me.ck_salaire.Size = New System.Drawing.Size(79, 19)
        Me.ck_salaire.TabIndex = 5
        Me.ck_salaire.Text = "Par salaire"
        Me.ck_salaire.UseVisualStyleBackColor = True
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(202, 39)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(131, 23)
        Me.txt_nom.TabIndex = 6
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(202, 89)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(131, 23)
        Me.txt_prenom.TabIndex = 7
        '
        'txt_salaire
        '
        Me.txt_salaire.Location = New System.Drawing.Point(202, 214)
        Me.txt_salaire.Name = "txt_salaire"
        Me.txt_salaire.Size = New System.Drawing.Size(131, 23)
        Me.txt_salaire.TabIndex = 8
        '
        'cb_ville
        '
        Me.cb_ville.FormattingEnabled = True
        Me.cb_ville.Location = New System.Drawing.Point(202, 124)
        Me.cb_ville.Name = "cb_ville"
        Me.cb_ville.Size = New System.Drawing.Size(131, 23)
        Me.cb_ville.TabIndex = 9
        '
        'cb_specialite
        '
        Me.cb_specialite.FormattingEnabled = True
        Me.cb_specialite.Location = New System.Drawing.Point(202, 168)
        Me.cb_specialite.Name = "cb_specialite"
        Me.cb_specialite.Size = New System.Drawing.Size(131, 23)
        Me.cb_specialite.TabIndex = 10
        '
        'rechercheMedcin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 494)
        Me.Controls.Add(Me.cb_specialite)
        Me.Controls.Add(Me.cb_ville)
        Me.Controls.Add(Me.txt_salaire)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.ck_salaire)
        Me.Controls.Add(Me.ck_specialite)
        Me.Controls.Add(Me.ck_ville)
        Me.Controls.Add(Me.ck_prenom)
        Me.Controls.Add(Me.ck_nom)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "rechercheMedcin"
        Me.Text = "rechercheMedcin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ck_nom As CheckBox
    Friend WithEvents ck_prenom As CheckBox
    Friend WithEvents ck_ville As CheckBox
    Friend WithEvents ck_specialite As CheckBox
    Friend WithEvents ck_salaire As CheckBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents txt_salaire As TextBox
    Friend WithEvents cb_specialite As ComboBox
    Friend WithEvents cb_ville As ComboBox
End Class
