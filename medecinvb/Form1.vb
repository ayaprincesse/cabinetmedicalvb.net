Public Class Form1
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

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Try

            cmd.Connection = conn
            cmd.CommandText = "insert into patient (nomP,prenomP,sexe,dateNaiss,numRPPS#) values('" & tb_nom.Text & "','" + tb_prenom.Text & "','" + cb_sexe.SelectedItem.ToString() & "','" + dtpicker.Value.ToShortDateString() & "'," + cb_numrpps.SelectedItem & ")"
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "element bien ajouté")
            conn.Close()
            Form1_Load(sender, e)
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connBDD()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from patient"
        cmd.Connection = conn
        conn.Open()
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        DataGridView1.DataSource = dt
        dr.Close()

        cmd.CommandText = "select numRpps from MEDECIN"
        dr = cmd.ExecuteReader()
        cb_numrpps.Items.Clear()
        While dr.Read()
            cb_numrpps.Items.Add(dr("numRpps"))
        End While

        dr.Close()
        conn.Close()
    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Try
            cmd.Connection = conn
            cmd.CommandText = "UPDATE patient set nomp = '" & tb_nom.Text & "', prenomp= '" + tb_prenom.Text & "', sexe= '" + cb_sexe.SelectedItem.ToString() & "', datenaiss= '" + dtpicker.Value.ToShortDateString() & "', numrpps#= '" + cb_numrpps.SelectedItem.ToString() & "' where numss= " + tb_numss.Text
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "  element modifié")
            conn.Close()
            Form1_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Try
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@numss", tb_numss.Text)
            cmd.CommandText = "Delete patient where numss=@numss "
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "  element supprimé")
            conn.Close()

            Form1_Load(sender, e)
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub tb_numss_TextChanged(sender As Object, e As EventArgs) Handles tb_numss.TextChanged

    End Sub

    Private Sub txt_nummedcin_TextChanged(sender As Object, e As EventArgs) Handles txt_nummedcin.TextChanged
        Try
            cmd.CommandText = "select * from patient where numRPPS# = " & txt_nummedcin.Text
            cmd.Connection = conn
            conn.Open()
            dr = cmd.ExecuteReader()
            Dim dt2 As DataTable = New DataTable()
            dt2.Load(dr)
            DataGridView2.DataSource = dt2
        Catch exp1 As Exception
            MessageBox.Show(exp1.Message, "SQL ERROR")

        End Try

        conn.Close()
    End Sub

    Private Sub btn_recherche_Click(sender As Object, e As EventArgs) Handles btn_recherche.Click
        If txt_nummedcin2.Text <> String.Empty Then

            Try
                cmd.Connection = conn
                cmd.CommandText = "select * from patient where numRPPS# = " & txt_nummedcin2.Text
                conn.Open()

                dr = cmd.ExecuteReader()
                Dim dt3 As DataTable = New DataTable()
                dt3.Load(dr)

                If dt3.Rows.Count = 0 Then
                    MessageBox.Show("patient n'existe pas")
                Else
                    DataGridView2.DataSource = dt3
                End If


            Catch exp2 As Exception
                MessageBox.Show(exp2.Message)
            End Try

            conn.Close()
        Else
            MessageBox.Show("espace de text vide")
        End If
    End Sub

    Private Sub cb_numrpps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_numrpps.SelectedIndexChanged
        Try
            cmd.Connection = conn
            cmd.CommandText = "select * from patient where numRPPS# = " & cb_numrpps.SelectedItem
            conn.Open()
            dr = cmd.ExecuteReader()
            Dim dt4 As DataTable = New DataTable()
            dt4.Load(dr)

            If dt4.Rows.Count = 0 Then
                MessageBox.Show("patient n'existe pas")
            Else
                DataGridView2.DataSource = dt
            End If

        Catch exp1 As Exception

            MessageBox.Show(exp1.Message, "SQL ERROR")

        End Try

        conn.Close()
    End Sub
End Class
