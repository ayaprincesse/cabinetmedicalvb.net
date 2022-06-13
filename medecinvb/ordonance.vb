Public Class ordonance
    Public conn As New SqlClient.SqlConnection
    Public cmd As New SqlClient.SqlCommand
    Public dt As DataTable = New DataTable()
    Public dr As SqlClient.SqlDataReader

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
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

    Private Sub ordonance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = ""
        connBDD()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from ordonance"
        cmd.Connection = conn
        conn.Open()
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        DataGridView1.DataSource = dt
        dr.Close()


        cmd.CommandText = "select distinct numRpps from MEDECIN"
        dr = cmd.ExecuteReader()
        cb_numord.Items.Clear()
        While dr.Read()
            cb_numrpps.Items.Add(dr("numRpps"))
        End While
        dr.Close()

        cmd.CommandText = "select distinct numOrd from ordonance"
        dr = cmd.ExecuteReader()
        cb_numord.Items.Clear()
        While dr.Read()
            cb_numord.Items.Add(dr("numOrd"))
        End While
        dr.Close()

        conn.Close()
    End Sub

    Private Sub btn_initialiser_Click(sender As Object, e As EventArgs) Handles btn_initialiser.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then c.Text = String.Empty
            If TypeOf c Is ComboBox Then c.Text = String.Empty
        Next

    End Sub
    Private Sub naviguer(ByVal dg As DataGridView, ByVal i As Integer)
        txt_description.Text = dg.Rows(i).Cells(2).Value.ToString()
        cb_numord.SelectedItem = dg.Rows(i).Cells(0).Value
        cb_numrpps.SelectedItem = dg.Rows(i).Cells(4).Value
        dtpicker.Value = CDate(dg.Rows(i).Cells(3).Value)
        txt_nom.Text = dg.Rows(i).Cells(1).Value.ToString()
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

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Try
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@numrpps", cb_numrpps.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@nom", txt_nom.Text)
            cmd.Parameters.AddWithValue("@date", dtpicker.Value.ToShortDateString())
            cmd.Parameters.AddWithValue("@description", txt_description.Text)
            cmd.CommandText = "insert into ordonance (nom,descriptionn,dateOrd,numrpps) values(@nom,@description,@date,@numrpps)"
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "element bien ajouté")
            conn.Close()
            ordonance_Load(sender, e)
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Try
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@numord", cb_numord.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@numrpps", cb_numrpps.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@nom", txt_nom.Text)
            cmd.Parameters.AddWithValue("@date", dtpicker.Value.ToShortDateString())
            cmd.Parameters.AddWithValue("@description", txt_description.Text)
            cmd.CommandText = "UPDATE Ordonance set nom=@nom , numrpps=@numrpps , descriptionn=@description, dateord=@date where numord=@numord "
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "element bien modifié")
            conn.Close()
            ordonance_Load(sender, e)
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click

        Try
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@numord", cb_numord.SelectedItem.ToString())
            cmd.CommandText = "Delete ordonance where numord=@numord "
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "element bien supprimé")
            conn.Close()
            ordonance_Load(sender, e)
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class