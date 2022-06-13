<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ordonance
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
        Me.numOrd = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.cb_numord = New System.Windows.Forms.ComboBox()
        Me.cb_numrpps = New System.Windows.Forms.ComboBox()
        Me.dtpicker = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_initialiser = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnpremier = New System.Windows.Forms.Button()
        Me.btnprecedent = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnDernier = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numOrd
        '
        Me.numOrd.AutoSize = True
        Me.numOrd.Location = New System.Drawing.Point(34, 50)
        Me.numOrd.Name = "numOrd"
        Me.numOrd.Size = New System.Drawing.Size(52, 15)
        Me.numOrd.TabIndex = 0
        Me.numOrd.Text = "numOrd"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "dateord"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "numrpps"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(93, 101)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(129, 23)
        Me.txt_nom.TabIndex = 5
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(93, 159)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(228, 51)
        Me.txt_description.TabIndex = 6
        '
        'cb_numord
        '
        Me.cb_numord.FormattingEnabled = True
        Me.cb_numord.Location = New System.Drawing.Point(93, 50)
        Me.cb_numord.Name = "cb_numord"
        Me.cb_numord.Size = New System.Drawing.Size(121, 23)
        Me.cb_numord.TabIndex = 7
        '
        'cb_numrpps
        '
        Me.cb_numrpps.FormattingEnabled = True
        Me.cb_numrpps.Location = New System.Drawing.Point(93, 283)
        Me.cb_numrpps.Name = "cb_numrpps"
        Me.cb_numrpps.Size = New System.Drawing.Size(121, 23)
        Me.cb_numrpps.TabIndex = 8
        '
        'dtpicker
        '
        Me.dtpicker.Location = New System.Drawing.Point(93, 238)
        Me.dtpicker.Name = "dtpicker"
        Me.dtpicker.Size = New System.Drawing.Size(200, 23)
        Me.dtpicker.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(470, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(297, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Location = New System.Drawing.Point(326, 58)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(101, 34)
        Me.btn_ajouter.TabIndex = 11
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_modifier
        '
        Me.btn_modifier.Location = New System.Drawing.Point(326, 118)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(101, 34)
        Me.btn_modifier.TabIndex = 12
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Location = New System.Drawing.Point(326, 176)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(101, 34)
        Me.btn_supprimer.TabIndex = 13
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'btn_initialiser
        '
        Me.btn_initialiser.Location = New System.Drawing.Point(326, 238)
        Me.btn_initialiser.Name = "btn_initialiser"
        Me.btn_initialiser.Size = New System.Drawing.Size(101, 34)
        Me.btn_initialiser.TabIndex = 14
        Me.btn_initialiser.Text = "Initialiser"
        Me.btn_initialiser.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(326, 297)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 40)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Imprimer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnpremier
        '
        Me.btnpremier.Location = New System.Drawing.Point(456, 238)
        Me.btnpremier.Name = "btnpremier"
        Me.btnpremier.Size = New System.Drawing.Size(68, 34)
        Me.btnpremier.TabIndex = 16
        Me.btnpremier.Text = "<<"
        Me.btnpremier.UseVisualStyleBackColor = True
        '
        'btnprecedent
        '
        Me.btnprecedent.Location = New System.Drawing.Point(545, 238)
        Me.btnprecedent.Name = "btnprecedent"
        Me.btnprecedent.Size = New System.Drawing.Size(61, 34)
        Me.btnprecedent.TabIndex = 17
        Me.btnprecedent.Text = "<"
        Me.btnprecedent.UseVisualStyleBackColor = True
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(630, 238)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(61, 34)
        Me.btnSuivant.TabIndex = 18
        Me.btnSuivant.Text = ">"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'btnDernier
        '
        Me.btnDernier.Location = New System.Drawing.Point(716, 238)
        Me.btnDernier.Name = "btnDernier"
        Me.btnDernier.Size = New System.Drawing.Size(63, 34)
        Me.btnDernier.TabIndex = 19
        Me.btnDernier.Text = ">>"
        Me.btnDernier.UseVisualStyleBackColor = True
        '
        'ordonance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 392)
        Me.Controls.Add(Me.btnDernier)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnprecedent)
        Me.Controls.Add(Me.btnpremier)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_initialiser)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtpicker)
        Me.Controls.Add(Me.cb_numrpps)
        Me.Controls.Add(Me.cb_numord)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numOrd)
        Me.Name = "ordonance"
        Me.Text = "Imprimer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numOrd As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents cb_numord As ComboBox
    Friend WithEvents cb_numrpps As ComboBox
    Friend WithEvents dtpicker As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btnDernier As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_initialiser As Button
    Friend WithEvents btnpremier As Button
    Friend WithEvents btnprecedent As Button
    Friend WithEvents btnSuivant As Button
End Class
