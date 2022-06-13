<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txt_nummedcin2 = New System.Windows.Forms.TextBox()
        Me.txt_nummedcin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cb_numrpps = New System.Windows.Forms.ComboBox()
        Me.dtpicker = New System.Windows.Forms.DateTimePicker()
        Me.cb_sexe = New System.Windows.Forms.ComboBox()
        Me.tb_prenom = New System.Windows.Forms.TextBox()
        Me.tb_nom = New System.Windows.Forms.TextBox()
        Me.tb_numss = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_recherche = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(399, 285)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(373, 164)
        Me.DataGridView2.TabIndex = 39
        '
        'txt_nummedcin2
        '
        Me.txt_nummedcin2.Location = New System.Drawing.Point(73, 369)
        Me.txt_nummedcin2.Name = "txt_nummedcin2"
        Me.txt_nummedcin2.Size = New System.Drawing.Size(132, 23)
        Me.txt_nummedcin2.TabIndex = 38
        '
        'txt_nummedcin
        '
        Me.txt_nummedcin.Location = New System.Drawing.Point(73, 311)
        Me.txt_nummedcin.Name = "txt_nummedcin"
        Me.txt_nummedcin.Size = New System.Drawing.Size(132, 23)
        Me.txt_nummedcin.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(284, 15)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Recherche de patient par num de medcin (numrpps)"
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Location = New System.Drawing.Point(330, 205)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(86, 23)
        Me.btn_supprimer.TabIndex = 35
        Me.btn_supprimer.Text = "SUPPRIMER"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'btn_modifier
        '
        Me.btn_modifier.Location = New System.Drawing.Point(177, 205)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(75, 23)
        Me.btn_modifier.TabIndex = 34
        Me.btn_modifier.Text = "MODIFIER"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Location = New System.Drawing.Point(29, 205)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(75, 23)
        Me.btn_ajouter.TabIndex = 33
        Me.btn_ajouter.Text = "AJOUTER"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(399, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(373, 168)
        Me.DataGridView1.TabIndex = 32
        '
        'cb_numrpps
        '
        Me.cb_numrpps.FormattingEnabled = True
        Me.cb_numrpps.Location = New System.Drawing.Point(177, 163)
        Me.cb_numrpps.Name = "cb_numrpps"
        Me.cb_numrpps.Size = New System.Drawing.Size(121, 23)
        Me.cb_numrpps.TabIndex = 31
        '
        'dtpicker
        '
        Me.dtpicker.Location = New System.Drawing.Point(177, 130)
        Me.dtpicker.Name = "dtpicker"
        Me.dtpicker.Size = New System.Drawing.Size(200, 23)
        Me.dtpicker.TabIndex = 30
        '
        'cb_sexe
        '
        Me.cb_sexe.FormattingEnabled = True
        Me.cb_sexe.Location = New System.Drawing.Point(177, 94)
        Me.cb_sexe.Name = "cb_sexe"
        Me.cb_sexe.Size = New System.Drawing.Size(121, 23)
        Me.cb_sexe.TabIndex = 29
        '
        'tb_prenom
        '
        Me.tb_prenom.Location = New System.Drawing.Point(177, 60)
        Me.tb_prenom.Name = "tb_prenom"
        Me.tb_prenom.Size = New System.Drawing.Size(100, 23)
        Me.tb_prenom.TabIndex = 28
        '
        'tb_nom
        '
        Me.tb_nom.Location = New System.Drawing.Point(177, 31)
        Me.tb_nom.Name = "tb_nom"
        Me.tb_nom.Size = New System.Drawing.Size(100, 23)
        Me.tb_nom.TabIndex = 27
        '
        'tb_numss
        '
        Me.tb_numss.Location = New System.Drawing.Point(177, 1)
        Me.tb_numss.Name = "tb_numss"
        Me.tb_numss.Size = New System.Drawing.Size(100, 23)
        Me.tb_numss.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "#NUMRPPS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "DATE DE NAISSANCE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "SEXE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "PRENOM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "NOM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "NUMSS"
        '
        'btn_recherche
        '
        Me.btn_recherche.Location = New System.Drawing.Point(271, 343)
        Me.btn_recherche.Name = "btn_recherche"
        Me.btn_recherche.Size = New System.Drawing.Size(75, 23)
        Me.btn_recherche.TabIndex = 40
        Me.btn_recherche.Text = "Rechercher"
        Me.btn_recherche.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_recherche)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txt_nummedcin2)
        Me.Controls.Add(Me.txt_nummedcin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cb_numrpps)
        Me.Controls.Add(Me.dtpicker)
        Me.Controls.Add(Me.cb_sexe)
        Me.Controls.Add(Me.tb_prenom)
        Me.Controls.Add(Me.tb_nom)
        Me.Controls.Add(Me.tb_numss)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txt_nummedcin2 As TextBox
    Friend WithEvents txt_nummedcin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cb_numrpps As ComboBox
    Friend WithEvents dtpicker As DateTimePicker
    Friend WithEvents cb_sexe As ComboBox
    Friend WithEvents tb_prenom As TextBox
    Friend WithEvents tb_nom As TextBox
    Friend WithEvents tb_numss As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_recherche As Button
End Class
