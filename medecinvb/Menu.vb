Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Medecin_Click(sender As Object, e As EventArgs) Handles btn_medecin.Click
        medecin.ShowDialog()
    End Sub

    Private Sub btn_patient_Click(sender As Object, e As EventArgs) Handles btn_patient.Click
        Form1.ShowDialog()
    End Sub

    Private Sub btn_consultation_Click(sender As Object, e As EventArgs) Handles btn_consultation.Click
        Consulte.ShowDialog()
    End Sub

    Private Sub btn_ordonnance_Click(sender As Object, e As EventArgs) Handles btn_ordonnance.Click
        ordonance.ShowDialog()
    End Sub

    Private Sub btn_recherche_Click(sender As Object, e As EventArgs) Handles btn_recherche.Click
        rechercheMedcin.ShowDialog()
    End Sub
End Class