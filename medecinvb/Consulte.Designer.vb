<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulte
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_numss = New System.Windows.Forms.ComboBox()
        Me.cb_numrpps = New System.Windows.Forms.ComboBox()
        Me.cb_numord = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.diagnostic = New System.Windows.Forms.TextBox()
        Me.dtpicker = New System.Windows.Forms.DateTimePicker()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_suivant = New System.Windows.Forms.Button()
        Me.btn_precedent = New System.Windows.Forms.Button()
        Me.btn_premier = New System.Windows.Forms.Button()
        Me.btn_dernier = New System.Windows.Forms.Button()
        Me.btn_initialiser = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUMSS#"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NUMRPPS#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "diagnostic"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date Consultation"
        '
        'cb_numss
        '
        Me.cb_numss.FormattingEnabled = True
        Me.cb_numss.Location = New System.Drawing.Point(127, 21)
        Me.cb_numss.Name = "cb_numss"
        Me.cb_numss.Size = New System.Drawing.Size(121, 23)
        Me.cb_numss.TabIndex = 4
        '
        'cb_numrpps
        '
        Me.cb_numrpps.FormattingEnabled = True
        Me.cb_numrpps.Location = New System.Drawing.Point(127, 67)
        Me.cb_numrpps.Name = "cb_numrpps"
        Me.cb_numrpps.Size = New System.Drawing.Size(121, 23)
        Me.cb_numrpps.TabIndex = 5
        '
        'cb_numord
        '
        Me.cb_numord.FormattingEnabled = True
        Me.cb_numord.Location = New System.Drawing.Point(127, 197)
        Me.cb_numord.Name = "cb_numord"
        Me.cb_numord.Size = New System.Drawing.Size(121, 23)
        Me.cb_numord.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "#NUMORD"
        '
        'diagnostic
        '
        Me.diagnostic.Location = New System.Drawing.Point(127, 108)
        Me.diagnostic.Name = "diagnostic"
        Me.diagnostic.Size = New System.Drawing.Size(100, 23)
        Me.diagnostic.TabIndex = 8
        '
        'dtpicker
        '
        Me.dtpicker.Location = New System.Drawing.Point(127, 158)
        Me.dtpicker.Name = "dtpicker"
        Me.dtpicker.Size = New System.Drawing.Size(200, 23)
        Me.dtpicker.TabIndex = 9
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Location = New System.Drawing.Point(443, 45)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(75, 23)
        Me.btn_ajouter.TabIndex = 10
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_modifier
        '
        Me.btn_modifier.Location = New System.Drawing.Point(443, 99)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(75, 23)
        Me.btn_modifier.TabIndex = 11
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Location = New System.Drawing.Point(443, 158)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(75, 23)
        Me.btn_supprimer.TabIndex = 12
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(618, 137)
        Me.DataGridView1.TabIndex = 13
        '
        'btn_suivant
        '
        Me.btn_suivant.Location = New System.Drawing.Point(410, 390)
        Me.btn_suivant.Name = "btn_suivant"
        Me.btn_suivant.Size = New System.Drawing.Size(75, 23)
        Me.btn_suivant.TabIndex = 16
        Me.btn_suivant.Text = ">"
        Me.btn_suivant.UseVisualStyleBackColor = True
        '
        'btn_precedent
        '
        Me.btn_precedent.Location = New System.Drawing.Point(252, 390)
        Me.btn_precedent.Name = "btn_precedent"
        Me.btn_precedent.Size = New System.Drawing.Size(75, 23)
        Me.btn_precedent.TabIndex = 15
        Me.btn_precedent.Text = "<"
        Me.btn_precedent.UseVisualStyleBackColor = True
        '
        'btn_premier
        '
        Me.btn_premier.Location = New System.Drawing.Point(87, 390)
        Me.btn_premier.Name = "btn_premier"
        Me.btn_premier.Size = New System.Drawing.Size(75, 23)
        Me.btn_premier.TabIndex = 14
        Me.btn_premier.Text = "<<"
        Me.btn_premier.UseVisualStyleBackColor = True
        '
        'btn_dernier
        '
        Me.btn_dernier.Location = New System.Drawing.Point(544, 390)
        Me.btn_dernier.Name = "btn_dernier"
        Me.btn_dernier.Size = New System.Drawing.Size(75, 23)
        Me.btn_dernier.TabIndex = 17
        Me.btn_dernier.Text = ">>"
        Me.btn_dernier.UseVisualStyleBackColor = True
        '
        'btn_initialiser
        '
        Me.btn_initialiser.Location = New System.Drawing.Point(439, 197)
        Me.btn_initialiser.Name = "btn_initialiser"
        Me.btn_initialiser.Size = New System.Drawing.Size(79, 34)
        Me.btn_initialiser.TabIndex = 25
        Me.btn_initialiser.Text = "Initialiser"
        Me.btn_initialiser.UseVisualStyleBackColor = True
        '
        'Consulte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 425)
        Me.Controls.Add(Me.btn_initialiser)
        Me.Controls.Add(Me.btn_dernier)
        Me.Controls.Add(Me.btn_suivant)
        Me.Controls.Add(Me.btn_precedent)
        Me.Controls.Add(Me.btn_premier)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.dtpicker)
        Me.Controls.Add(Me.diagnostic)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_numord)
        Me.Controls.Add(Me.cb_numrpps)
        Me.Controls.Add(Me.cb_numss)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Consulte"
        Me.Text = "Consulte"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_numss As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents diagnostic As TextBox
    Friend WithEvents dtpicker As DateTimePicker
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cb_numrpps As ComboBox
    Friend WithEvents cb_numord As ComboBox
    Friend WithEvents btn_suivant As Button
    Friend WithEvents btn_precedent As Button
    Friend WithEvents btn_premier As Button
    Friend WithEvents btn_dernier As Button
    Friend WithEvents btn_initialiser As Button
End Class
