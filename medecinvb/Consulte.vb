Public Class Consulte
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
    Private Sub Consulte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connBDD()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "select * from consulte"
        conn.Open()
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        DataGridView1.DataSource = dt
        dr.Close()
        cmd2.CommandType = CommandType.Text
        cmd2.Connection = conn
        cmd2.CommandText = "select numRpps from MEDECIN"
        dr2 = cmd2.ExecuteReader()
        cb_numrpps.Items.Clear()

        While dr2.Read()
            cb_numrpps.Items.Add(dr2("numRpps"))
        End While

        dr2.Close()
        cmd3.CommandType = CommandType.Text
        cmd3.Connection = conn
        cmd3.CommandText = "select numss from patient"
        dr3 = cmd3.ExecuteReader()
        cb_numss.Items.Clear()

        While dr3.Read()
            cb_numss.Items.Add(dr3("numss"))
        End While

        dr3.Close()
        cmd4.CommandType = CommandType.Text
        cmd4.Connection = conn
        cmd4.CommandText = "select numOrd from Ordonance"
        dr4 = cmd4.ExecuteReader()
        cb_numord.Items.Clear()

        While dr4.Read()
            cb_numord.Items.Add(dr4("numOrd"))
        End While

        dr4.Close()
        conn.Close()

    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Try
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@numrpps", cb_numrpps.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@numss", cb_numss.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@date", dtpicker.Value.ToShortDateString())
            cmd.Parameters.AddWithValue("@diagnostic", diagnostic.Text)
            cmd.Parameters.AddWithValue("@numord", cb_numord.SelectedItem.ToString())
            cmd.CommandText = "insert into consulte (numrpps#,numss#,dateConsulte,diagnostic,numOrd#) values(@numrpps,@numss,@date,@diagnostic,@numord)"
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "element bien ajouté")
            conn.Close()
            Consulte_Load(sender, e)
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Try
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@numrpps", cb_numrpps.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@numss", cb_numss.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@date", dtpicker.Value.ToShortDateString())
            cmd.Parameters.AddWithValue("@diagnostic", diagnostic.Text)
            cmd.Parameters.AddWithValue("@numord", cb_numord.SelectedItem.ToString())
            cmd.CommandText = "UPDATE consulte set diagnostic=@diagnostic , numord#=@numord where numrpps#=@numrpps and numss#=@numss and dateconsulte=@date "
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "  element modifié")
            conn.Close()
            Consulte_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Try
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@numrpps", cb_numrpps.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@numss", cb_numss.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@date", dtpicker.Value.ToShortDateString())
            cmd.CommandText = "Delete consulte where numrpps#=@numrpps and numss#=@numss and dateconsulte=@date "
            MessageBox.Show(cmd.CommandText)
            conn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show(i & "  element supprimé")
            conn.Close()
            Consulte_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_precedent.Click
        If p > 0 Then
            p -= 1
            naviguer(DataGridView1, p)
        End If
    End Sub
    Private Sub naviguer(ByVal dg As DataGridView, ByVal i As Integer)
        diagnostic.Text = dg.Rows(i).Cells(3).Value.ToString()
        cb_numss.SelectedItem = dg.Rows(i).Cells(1).Value
        cb_numrpps.SelectedItem = dg.Rows(i).Cells(0).Value
        dtpicker.Value = CDate(dg.Rows(i).Cells(2).Value)
        cb_numord.SelectedItem = dg.Rows(i).Cells(4).Value
        DataGridView1.Rows(p).Selected = True
    End Sub
    Private p As Integer = 0
    Private Sub btn_premier_Click(sender As Object, e As EventArgs) Handles btn_premier.Click
        p = 0
        naviguer(DataGridView1, p)
    End Sub

    Private Sub btn_suivant_Click(sender As Object, e As EventArgs) Handles btn_suivant.Click
        If p < DataGridView1.Rows.Count - 1 Then
            p += 1
            naviguer(DataGridView1, p)
        End If
    End Sub

    Private Sub btn_dernier_Click(sender As Object, e As EventArgs) Handles btn_dernier.Click
        p = DataGridView1.Rows.Count - 2
        naviguer(DataGridView1, p)
    End Sub

    Private Sub btn_initialiser_Click(sender As Object, e As EventArgs) Handles btn_initialiser.Click

        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then c.Text = String.Empty
            If TypeOf c Is ComboBox Then c.Text = String.Empty
        Next

    End Sub
End Class