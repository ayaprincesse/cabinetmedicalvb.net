Imports System.Data.SqlClient

Public Class rechercheMedcin
    Public conn As New SqlClient.SqlConnection
    Public cmd As New SqlClient.SqlCommand
    Public cmd2 As New SqlClient.SqlCommand
    Public cmd3 As New SqlClient.SqlCommand
    Public cmd4 As New SqlClient.SqlCommand
    Public dt As DataTable = New DataTable()
    Public dr As SqlClient.SqlDataReader
    Public dr2 As SqlClient.SqlDataReader
    Public dr3 As SqlClient.SqlDataReader
    Public dr4 As SqlClient.SqlDataReader
    Private t As DataTable = New DataTable()
    Private nm As SqlParameter = New SqlParameter("@nom", "")
    Private pn As SqlParameter = New SqlParameter("@prenom", "")
    Private sp As SqlParameter = New SqlParameter("@sp", "")
    Private vl As SqlParameter = New SqlParameter("@ville", "")
    Private sl As SqlParameter = New SqlParameter("@sl", "")

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
    Private Sub rechercheMedcin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connBDD()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "select * from medecin"
        conn.Open()
        t.Load(cmd.ExecuteReader())
        DataGridView1.DataSource = t


        cmd.CommandText = "select distinct ville from MEDECIN"
        dr = cmd.ExecuteReader()
        cb_ville.Items.Clear()
        While dr.Read()
            cb_ville.Items.Add(dr("ville"))
        End While
        dr.Close()

        cmd.CommandText = "select distinct specialite from MEDECIN"
        dr = cmd.ExecuteReader()
        cb_specialite.Items.Clear()
        While dr.Read()
            cb_specialite.Items.Add(dr("specialite"))
        End While
        dr.Close()

        cmd.CommandText = "select * from medecin where numrpps is not null "

        conn.Close()
    End Sub

    Private Sub txt_nom_TextChanged(sender As Object, e As EventArgs) Handles txt_nom.TextChanged
        Try

            If ck_nom.Checked Then
                nm.Value = txt_nom.Text
                cmd.CommandText += "and nomM=@nom "
                conn.Open()
                t.Clear()
                t.Load(cmd.ExecuteReader())
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "ERREUR NOM")
        End Try

        conn.Close()
    End Sub

    Private Sub txt_prenom_TextChanged(sender As Object, e As EventArgs) Handles txt_prenom.TextChanged
        Try

            If ck_prenom.Checked Then
                pn.Value = txt_prenom.Text
                cmd.CommandText += "and prenomM=@prenom "
                conn.Open()
                t.Clear()
                t.Load(cmd.ExecuteReader())
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERREUR PRENOM")
        End Try

        conn.Close()
    End Sub

    Private Sub ck_prenom_CheckedChanged(sender As Object, e As EventArgs) Handles ck_prenom.CheckedChanged
        If ck_prenom.Checked Then
            txt_prenom.Enabled = True
            cmd.Parameters.Add(pn)
        Else
            txt_prenom.Clear()
            txt_prenom.Enabled = False
            If cmd.Parameters.Contains(pn) Then cmd.Parameters.Remove(pn)
            cmd.CommandText = cmd.CommandText.Replace("and prenomM=@prenom", " ")
        End If
    End Sub

    Private Sub ck_nom_CheckedChanged(sender As Object, e As EventArgs) Handles ck_nom.CheckedChanged
        If ck_nom.Checked Then
            txt_nom.Enabled = True
            cmd.Parameters.Add(nm)
        Else
            txt_nom.Clear()
            txt_nom.Enabled = False
            If cmd.Parameters.Contains(nm) Then cmd.Parameters.Remove(nm)
            cmd.CommandText = cmd.CommandText.Replace("and nomM=@nom", " ")
        End If
    End Sub

    Private Sub ck_ville_CheckedChanged(sender As Object, e As EventArgs) Handles ck_ville.CheckedChanged
        If ck_ville.Checked Then
            cb_ville.Enabled = True
            cmd.Parameters.Add(vl)
        Else
            cb_ville.SelectedItem = Nothing
            cb_ville.Enabled = False
            If cmd.Parameters.Contains(vl) Then cmd.Parameters.Remove(vl)
            cmd.CommandText = cmd.CommandText.Replace("and ville=@ville", " ")
        End If
    End Sub

    Private Sub cb_ville_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_ville.SelectedIndexChanged
        Try

            If ck_ville.Checked Then
                vl.Value = cb_ville.SelectedItem.ToString()
                cmd.CommandText += "and ville=@ville "
                conn.Open()
                t.Clear()
                t.Load(cmd.ExecuteReader())
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "ERREUR Ville")
        End Try

        conn.Close()
    End Sub

    Private Sub ck_specialite_CheckedChanged(sender As Object, e As EventArgs) Handles ck_specialite.CheckedChanged
        If ck_specialite.Checked Then
            ck_specialite.Enabled = True
            cmd.Parameters.Add(sp)
        Else
            cb_specialite.SelectedItem = Nothing
            ck_specialite.Enabled = False
            If cmd.Parameters.Contains(sp) Then cmd.Parameters.Remove(sp)
            cmd.CommandText = cmd.CommandText.Replace("and specialite=@sp", " ")
        End If
    End Sub

    Private Sub cb_specialite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_specialite.SelectedIndexChanged
        Try

            If ck_specialite.Checked Then
                sp.Value = cb_specialite.SelectedItem.ToString()
                cmd.CommandText += "and specialite=@sp "
                conn.Open()
                t.Clear()
                t.Load(cmd.ExecuteReader())
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "ERREUR SPACIALITE")
        End Try

        conn.Close()
    End Sub

    Private Sub ck_salaire_CheckedChanged(sender As Object, e As EventArgs) Handles ck_salaire.CheckedChanged
        If ck_salaire.Checked Then
            txt_salaire.Enabled = True
            cmd.Parameters.Add(sl)
        Else
            txt_salaire.Clear()
            txt_salaire.Enabled = False
            If cmd.Parameters.Contains(sl) Then cmd.Parameters.Remove(sl)
            cmd.CommandText = cmd.CommandText.Replace("and salaire=@sl", " ")
        End If
    End Sub

    Private Sub txt_salaire_TextChanged(sender As Object, e As EventArgs) Handles txt_salaire.TextChanged
        Try

            If ck_salaire.Checked Then
                sl.Value = txt_salaire.Text
                cmd.CommandText += "and salaire=@sl "
                conn.Open()
                t.Clear()
                t.Load(cmd.ExecuteReader())
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "ERREUR SALAIRE")
        End Try

        conn.Close()
    End Sub

End Class