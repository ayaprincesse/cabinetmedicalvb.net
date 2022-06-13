<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.btn_medecin = New System.Windows.Forms.Button()
        Me.btn_patient = New System.Windows.Forms.Button()
        Me.btn_consultation = New System.Windows.Forms.Button()
        Me.btn_ordonnance = New System.Windows.Forms.Button()
        Me.btn_recherche = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_medecin
        '
        Me.btn_medecin.BackColor = System.Drawing.Color.LightBlue
        Me.btn_medecin.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_medecin.Image = CType(resources.GetObject("btn_medecin.Image"), System.Drawing.Image)
        Me.btn_medecin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_medecin.Location = New System.Drawing.Point(1, 1)
        Me.btn_medecin.Name = "btn_medecin"
        Me.btn_medecin.Size = New System.Drawing.Size(161, 55)
        Me.btn_medecin.TabIndex = 0
        Me.btn_medecin.Text = "Medecin"
        Me.btn_medecin.UseVisualStyleBackColor = False
        '
        'btn_patient
        '
        Me.btn_patient.BackColor = System.Drawing.Color.LightBlue
        Me.btn_patient.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_patient.Image = CType(resources.GetObject("btn_patient.Image"), System.Drawing.Image)
        Me.btn_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient.Location = New System.Drawing.Point(1, 53)
        Me.btn_patient.Name = "btn_patient"
        Me.btn_patient.Size = New System.Drawing.Size(161, 55)
        Me.btn_patient.TabIndex = 1
        Me.btn_patient.Text = "Patient"
        Me.btn_patient.UseVisualStyleBackColor = False
        '
        'btn_consultation
        '
        Me.btn_consultation.BackColor = System.Drawing.Color.LightBlue
        Me.btn_consultation.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_consultation.Image = CType(resources.GetObject("btn_consultation.Image"), System.Drawing.Image)
        Me.btn_consultation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_consultation.Location = New System.Drawing.Point(1, 105)
        Me.btn_consultation.Name = "btn_consultation"
        Me.btn_consultation.Size = New System.Drawing.Size(161, 55)
        Me.btn_consultation.TabIndex = 2
        Me.btn_consultation.Text = "   Consultation"
        Me.btn_consultation.UseVisualStyleBackColor = False
        '
        'btn_ordonnance
        '
        Me.btn_ordonnance.BackColor = System.Drawing.Color.LightBlue
        Me.btn_ordonnance.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_ordonnance.Image = CType(resources.GetObject("btn_ordonnance.Image"), System.Drawing.Image)
        Me.btn_ordonnance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ordonnance.Location = New System.Drawing.Point(1, 157)
        Me.btn_ordonnance.Name = "btn_ordonnance"
        Me.btn_ordonnance.Size = New System.Drawing.Size(161, 55)
        Me.btn_ordonnance.TabIndex = 3
        Me.btn_ordonnance.Text = "       Ordonnance"
        Me.btn_ordonnance.UseVisualStyleBackColor = False
        '
        'btn_recherche
        '
        Me.btn_recherche.BackColor = System.Drawing.Color.LightBlue
        Me.btn_recherche.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_recherche.Image = CType(resources.GetObject("btn_recherche.Image"), System.Drawing.Image)
        Me.btn_recherche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_recherche.Location = New System.Drawing.Point(1, 209)
        Me.btn_recherche.Name = "btn_recherche"
        Me.btn_recherche.Size = New System.Drawing.Size(161, 55)
        Me.btn_recherche.TabIndex = 4
        Me.btn_recherche.Text = "  Recherche"
        Me.btn_recherche.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(525, 258)
        Me.Controls.Add(Me.btn_recherche)
        Me.Controls.Add(Me.btn_ordonnance)
        Me.Controls.Add(Me.btn_consultation)
        Me.Controls.Add(Me.btn_patient)
        Me.Controls.Add(Me.btn_medecin)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_medecin As Button
    Friend WithEvents btn_patient As Button
    Friend WithEvents btn_consultation As Button
    Friend WithEvents btn_ordonnance As Button
    Friend WithEvents btn_recherche As Button
End Class
