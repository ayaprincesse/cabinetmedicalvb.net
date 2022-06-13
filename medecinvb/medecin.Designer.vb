<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medecin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medecin))
        Me.tb_num = New System.Windows.Forms.TextBox()
        Me.tb_nom = New System.Windows.Forms.TextBox()
        Me.tb_prenom = New System.Windows.Forms.TextBox()
        Me.tb_ville = New System.Windows.Forms.TextBox()
        Me.tb_adresse = New System.Windows.Forms.TextBox()
        Me.tb_salaire = New System.Windows.Forms.TextBox()
        Me.dt_picker = New System.Windows.Forms.DateTimePicker()
        Me.cb_specialite = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_initialiser = New System.Windows.Forms.Button()
        Me.btnpremier = New System.Windows.Forms.Button()
        Me.btnprecedent = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnDernier = New System.Windows.Forms.Button()
        Me.maskedtb_tel = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_num
        '
        Me.tb_num.Location = New System.Drawing.Point(150, 22)
        Me.tb_num.Name = "tb_num"
        Me.tb_num.Size = New System.Drawing.Size(100, 23)
        Me.tb_num.TabIndex = 0
        '
        'tb_nom
        '
        Me.tb_nom.Location = New System.Drawing.Point(150, 64)
        Me.tb_nom.Name = "tb_nom"
        Me.tb_nom.Size = New System.Drawing.Size(100, 23)
        Me.tb_nom.TabIndex = 1
        '
        'tb_prenom
        '
        Me.tb_prenom.Location = New System.Drawing.Point(150, 111)
        Me.tb_prenom.Name = "tb_prenom"
        Me.tb_prenom.Size = New System.Drawing.Size(100, 23)
        Me.tb_prenom.TabIndex = 2
        '
        'tb_ville
        '
        Me.tb_ville.Location = New System.Drawing.Point(150, 215)
        Me.tb_ville.Name = "tb_ville"
        Me.tb_ville.Size = New System.Drawing.Size(100, 23)
        Me.tb_ville.TabIndex = 3
        '
        'tb_adresse
        '
        Me.tb_adresse.Location = New System.Drawing.Point(150, 256)
        Me.tb_adresse.Name = "tb_adresse"
        Me.tb_adresse.Size = New System.Drawing.Size(100, 23)
        Me.tb_adresse.TabIndex = 4
        '
        'tb_salaire
        '
        Me.tb_salaire.Location = New System.Drawing.Point(150, 342)
        Me.tb_salaire.Name = "tb_salaire"
        Me.tb_salaire.Size = New System.Drawing.Size(100, 23)
        Me.tb_salaire.TabIndex = 6
        '
        'dt_picker
        '
        Me.dt_picker.Location = New System.Drawing.Point(150, 186)
        Me.dt_picker.Name = "dt_picker"
        Me.dt_picker.Size = New System.Drawing.Size(179, 23)
        Me.dt_picker.TabIndex = 7
        '
        'cb_specialite
        '
        Me.cb_specialite.FormattingEnabled = True
        Me.cb_specialite.Location = New System.Drawing.Point(150, 157)
        Me.cb_specialite.Name = "cb_specialite"
        Me.cb_specialite.Size = New System.Drawing.Size(100, 23)
        Me.cb_specialite.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(69, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NumRpps"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(74, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Prenom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(69, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(69, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Specialite"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(28, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Date de naissance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(74, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ville"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(74, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Adresse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(74, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(74, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Salaire"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(335, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(399, 238)
        Me.DataGridView1.TabIndex = 19
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.PowderBlue
        Me.btn_ajouter.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_ajouter.Image = CType(resources.GetObject("btn_ajouter.Image"), System.Drawing.Image)
        Me.btn_ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ajouter.Location = New System.Drawing.Point(22, 389)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(108, 43)
        Me.btn_ajouter.TabIndex = 21
        Me.btn_ajouter.Text = "   Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.PowderBlue
        Me.btn_modifier.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_modifier.Image = CType(resources.GetObject("btn_modifier.Image"), System.Drawing.Image)
        Me.btn_modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_modifier.Location = New System.Drawing.Point(169, 389)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(102, 45)
        Me.btn_modifier.TabIndex = 22
        Me.btn_modifier.Text = "    Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.PowderBlue
        Me.btn_supprimer.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_supprimer.Image = CType(resources.GetObject("btn_supprimer.Image"), System.Drawing.Image)
        Me.btn_supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_supprimer.Location = New System.Drawing.Point(318, 391)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(120, 43)
        Me.btn_supprimer.TabIndex = 23
        Me.btn_supprimer.Text = "     Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'btn_initialiser
        '
        Me.btn_initialiser.BackColor = System.Drawing.Color.PowderBlue
        Me.btn_initialiser.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_initialiser.Image = CType(resources.GetObject("btn_initialiser.Image"), System.Drawing.Image)
        Me.btn_initialiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_initialiser.Location = New System.Drawing.Point(477, 391)
        Me.btn_initialiser.Name = "btn_initialiser"
        Me.btn_initialiser.Size = New System.Drawing.Size(114, 43)
        Me.btn_initialiser.TabIndex = 24
        Me.btn_initialiser.Text = "      Initialiser"
        Me.btn_initialiser.UseVisualStyleBackColor = False
        '
        'btnpremier
        '
        Me.btnpremier.BackColor = System.Drawing.Color.PowderBlue
        Me.btnpremier.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnpremier.Location = New System.Drawing.Point(346, 283)
        Me.btnpremier.Name = "btnpremier"
        Me.btnpremier.Size = New System.Drawing.Size(76, 40)
        Me.btnpremier.TabIndex = 25
        Me.btnpremier.Text = "<<"
        Me.btnpremier.UseVisualStyleBackColor = False
        '
        'btnprecedent
        '
        Me.btnprecedent.BackColor = System.Drawing.Color.PowderBlue
        Me.btnprecedent.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnprecedent.Location = New System.Drawing.Point(452, 283)
        Me.btnprecedent.Name = "btnprecedent"
        Me.btnprecedent.Size = New System.Drawing.Size(63, 40)
        Me.btnprecedent.TabIndex = 26
        Me.btnprecedent.Text = "<"
        Me.btnprecedent.UseVisualStyleBackColor = False
        '
        'btnSuivant
        '
        Me.btnSuivant.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSuivant.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSuivant.Location = New System.Drawing.Point(561, 283)
        Me.btnSuivant.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(65, 40)
        Me.btnSuivant.TabIndex = 27
        Me.btnSuivant.Text = ">"
        Me.btnSuivant.UseVisualStyleBackColor = False
        '
        'btnDernier
        '
        Me.btnDernier.BackColor = System.Drawing.Color.PowderBlue
        Me.btnDernier.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDernier.Location = New System.Drawing.Point(653, 283)
        Me.btnDernier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDernier.Name = "btnDernier"
        Me.btnDernier.Size = New System.Drawing.Size(69, 40)
        Me.btnDernier.TabIndex = 28
        Me.btnDernier.Text = ">>"
        Me.btnDernier.UseVisualStyleBackColor = False
        '
        'maskedtb_tel
        '
        Me.maskedtb_tel.Location = New System.Drawing.Point(150, 290)
        Me.maskedtb_tel.Mask = "0000-00-00-00"
        Me.maskedtb_tel.Name = "maskedtb_tel"
        Me.maskedtb_tel.Size = New System.Drawing.Size(100, 23)
        Me.maskedtb_tel.TabIndex = 30
        '
        'medecin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(827, 437)
        Me.Controls.Add(Me.maskedtb_tel)
        Me.Controls.Add(Me.btnDernier)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnprecedent)
        Me.Controls.Add(Me.btnpremier)
        Me.Controls.Add(Me.btn_initialiser)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_specialite)
        Me.Controls.Add(Me.dt_picker)
        Me.Controls.Add(Me.tb_salaire)
        Me.Controls.Add(Me.tb_adresse)
        Me.Controls.Add(Me.tb_ville)
        Me.Controls.Add(Me.tb_prenom)
        Me.Controls.Add(Me.tb_nom)
        Me.Controls.Add(Me.tb_num)
        Me.Name = "medecin"
        Me.Text = "medecin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_num As TextBox
    Friend WithEvents tb_nom As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents tb_cville As TextBox
    Friend WithEvents tb_adresse As TextBox
    Friend WithEvents tb_salaire As TextBox
    Friend WithEvents dt_picker As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_initialiser As Button
    Friend WithEvents btnpremier As Button
    Friend WithEvents btnprecedent As Button
    Friend WithEvents btnSuivant As Button
    Friend WithEvents btnDernier As Button
    Friend WithEvents tb_prenom As TextBox
    Friend WithEvents cb_specialite As ComboBox
    Friend WithEvents tb_ville As TextBox
    Friend WithEvents maskedtb_tel As MaskedTextBox
End Class
