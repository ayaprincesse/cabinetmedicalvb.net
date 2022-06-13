Public Class medecin
    Public conn As New SqlClient.SqlConnection
    Public cmd As New SqlClient.SqlCommand
    Public dt As DataTable = New DataTable()
    Public dr As SqlClient.SqlDataReader

    Public Sub connBDD()
        conn.ConnectionString = "Data Source=DESKTOP-K9REE8E\BARBIEEXPRESS;Initial Catalog=TpMedcin;Integrated Security=True"
        conn.Open()
        If conn.State = ConnectionState.Open Then
            MessageBox.Show("Connexion est réussie avec la BDD")
        Else
            MessageBox.Show("Problème de connexion avec la BDD")
        End If
        conn.Close()
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "select numRpps , nomM, prenomM, specialite,salaire from MEDECIN"
        'conn.Open()
        'dr = cmd.ExecuteReader()
        'While dr.Read()
        '    DataGridView2.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
        'End While


        'conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Try
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE medecin set nomM = '" & tb_nom.Text & "', prenomM= '" + tb_prenom.Text & "',specialite= '" + cb_specialite.SelectedItem.ToString() & "',datenaiss= '" + dt_picker.Value.ToShortDateString() & "',ville= '" + tb_ville.Text & "', adresse='" + tb_adresse.Text & "' where numrpps= " + tb_num.Text
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "  element modifié")
            conn.Close()
            medecin_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub medecin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connBDD()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from medecin"
        cmd.Connection = conn
        conn.Open()
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        DataGridView1.DataSource = dt
        dr.Close()

        cmd.CommandText = "select distinct specialite from MEDECIN"
        dr = cmd.ExecuteReader()
        cb_specialite.Items.Clear()
        While dr.Read()
            cb_specialite.Items.Add(dr("specialite"))
        End While

        conn.Close()
    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Try
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into medecin (nomm,prenomm,specialite,datenaiss,ville,adresse,tel,salaire) values('" & tb_nom.Text & "','" + tb_prenom.Text & "','" + cb_specialite.SelectedItem.ToString() & "','" + dt_picker.Value.ToShortDateString() & "','" + tb_ville.Text & "','" + tb_adresse.Text & "','" + maskedtb_tel.Text & "'," + tb_salaire.Text & ")"
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "  bien ajouté")
            conn.Close()
            medecin_Load(sender, e)
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_initialiser_Click(sender As Object, e As EventArgs) Handles btn_initialiser.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then c.Text = String.Empty
            If TypeOf c Is MaskedTextBox Then c.Text = String.Empty
        Next
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Try

            cmd.Connection = conn
            cmd.CommandText = "Delete medecin where numrpps= " & tb_num.Text
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "  element supprimé")
            conn.Close()
            medecin_Load(sender, e)
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub naviguer(ByVal dg As DataGridView, ByVal i As Integer)
        tb_num.Text = dg.Rows(i).Cells(0).Value.ToString()
        tb_nom.Text = dg.Rows(i).Cells(1).Value.ToString()
        tb_prenom.Text = dg.Rows(i).Cells(2).Value.ToString()
        cb_specialite.SelectedItem = dg.Rows(i).Cells(3).Value.ToString()
        dt_picker.Value = CDate(dg.Rows(i).Cells(4).Value)
        tb_ville.Text = dg.Rows(i).Cells(5).Value.ToString()
        tb_adresse.Text = dg.Rows(i).Cells(6).Value.ToString()
        maskedtb_tel.Text = dg.Rows(i).Cells(7).Value.ToString()
        tb_salaire.Text = dg.Rows(i).Cells(8).Value.ToString()
        DataGridView1.Rows(p).Selected = True
    End Sub
    Private p As Integer = 0
    Private Sub btnpremier_Click(sender As Object, e As EventArgs) Handles btnpremier.Click
        p = 0
        naviguer(DataGridView1, p)
    End Sub

    Private Sub btnprecedent_Click(sender As Object, e As EventArgs) Handles btnprecedent.Click
        If p > 0 Then
            p -= 1
            naviguer(DataGridView1, p)
        End If
    End Sub

    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click
        If p < DataGridView1.Rows.Count - 1 Then
            p += 1
            naviguer(DataGridView1, p)
        End If
    End Sub

    Private Sub btnDernier_Click(sender As Object, e As EventArgs) Handles btnDernier.Click
        p = DataGridView1.Rows.Count - 2
        naviguer(DataGridView1, p)
    End Sub

    Private Sub cb_specialite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_specialite.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class