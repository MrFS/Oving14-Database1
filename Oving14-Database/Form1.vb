Imports MySql.Data.MySqlClient

Public Class Form1

    Dim server As String = "localhost"
    Dim port As String = "8089"
    Dim db As String = "Oving14"

    Dim user As String = "root"
    Dim pass As String = "root"

    Dim myData As New DataTable

    Dim connect As New MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateTableToolStripMenuItem.Visible = 0

        InsertIntoToolStripMenuItem.Visible = 0

        SeDatabasenToolStripMenuItem.Visible = 0

        SlettTabellToolStripMenuItem.Visible = 0

    End Sub

    Private Sub ConnectToDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToDatabaseToolStripMenuItem.Click

        connect.ConnectionString = "Server=" & server & ";" &
                                   "Database=" & db & ";" &
                                   "Uid=" & user & ";" &
                                   "Port=" & port & ";" &
                                   "Pwd=" & pass & ";"
        Try
            connect.Open()
            MsgBox("Koblet til database " & server)
            connect.Close()

            ConnectToDatabaseToolStripMenuItem.Visible = 0

            CreateTableToolStripMenuItem.Visible = 1

            InsertIntoToolStripMenuItem.Visible = 1

            SeDatabasenToolStripMenuItem.Visible = 1

            SlettTabellToolStripMenuItem.Visible = 1

        Catch ex As Exception
            MsgBox("Feil: " & ex.Message)
        Finally
            connect.Dispose()
        End Try

    End Sub

    Private Function sporring(ByVal sql As String)

        Try

            connect.Open()

            Dim kommando As New MySqlCommand(sql, connect)

            Dim da As New MySqlDataAdapter

            da.SelectCommand = kommando

            da.Fill(myData)

            connect.Close()
        Catch ex As Exception
            MsgBox("Newb:" & ex.Message)
        Finally
            connect.Dispose()
        End Try

        Return myData
    End Function


    Private Sub CreateTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateTableToolStripMenuItem.Click



        Try
            sporring("CREATE TABLE Person(ID int NOT NULL auto_increment, Person_Fornavn char(25), Person_Etternavn char(25), Person_Epost char(35), Person_Bursdag DATE)")
            MsgBox("Table ""Personer""Laget")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub InsertIntoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertIntoToolStripMenuItem.Click
        Try

            sporring("INSERT INTO Person(ID, Person_Fornavn, Person_Etternavn, Person_Epost, Person_Bursdag) VALUES (1, 'Karii', 'Jensen', 'epost@epost1.no', '1994-12-24')")
            sporring("INSERT INTO Person(ID, Person_Fornavn, Person_Etternavn, Person_Epost, Person_Bursdag) VALUES (2, 'Kar1i', 'Jensen', 'epost@epos2t.no', '1994-12-25')")
            sporring("INSERT INTO Person(ID, Person_Fornavn, Person_Etternavn, Person_Epost, Person_Bursdag) VALUES (3, 'Kari2', 'Jensen', 'epost@ep2ost.no', '1994-12-26')")
            sporring("INSERT INTO Person(ID, Person_Fornavn, Person_Etternavn, Person_Epost, Person_Bursdag) VALUES (4, 'Kari4', 'Jensen', 'epost@epo2st.no', '1994-12-27')")
            sporring("INSERT INTO Person(ID, Person_Fornavn, Person_Etternavn, Person_Epost, Person_Bursdag) VALUES (5, 'Kari5', 'Jensen', 'epost@epos2t.no', '1994-12-28')")
            sporring("INSERT INTO Person(ID, Person_Fornavn, Person_Etternavn, Person_Epost, Person_Bursdag) VALUES (6, 'Kari6', 'Jensen', 'epost@epost2.no', '1994-12-29')")

            MsgBox("La til info")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SeDatabasenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeDatabasenToolStripMenuItem.Click
        ListBox1.Items.Clear()
        sporring("SELECT * FROM Person ORDER BY Person_Fornavn")

        Dim temprad As DataRow

        Dim pid, fornavn, etternavn, epost, bursdag As String

        ListBox1.Items.Clear()

        ListBox1.Items.Add("ID" & vbTab & "Fornavn" & vbTab & "Etternavn" & vbTab & "Epost" & vbTab & vbTab & "Bursdag")

        ListBox1.Items.Add("")

        For Each temprad In myData.Rows

            pid = temprad("ID")

            fornavn = temprad("Person_Fornavn")

            etternavn = temprad("Person_Etternavn")

            epost = temprad("Person_Epost")

            bursdag = temprad("Person_Bursdag")

            ListBox1.Items.Add(pid & vbTab & fornavn & vbTab & etternavn & vbTab & epost & vbTab & bursdag)

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim sporring As String
            sporring = "INSERT INTO Person(Person_Fornavn, Person_Etternavn, Person_Epost, Person_Bursdag)"
            sporring = sporring & "VALUES "
            sporring &= "('" & txtFornavn.Text & "', '" & txtEtternavn.Text & "', '" &
                        txtEpost.Text & "', '" & dtp1.Value.Date & "')"


            Dim insertsql As New MySqlCommand(sporring, connect)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = insertsql
            da.Fill(interntabell)
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Dataene er lagt til i databasen")
            connect.Close()
            txtFornavn.Clear()
            txtEtternavn.Clear()
            txtEpost.Clear()


        Catch ex As MySqlException
            MsgBox("Feil ved registrering: " & ex.Message)
        Finally
            connect.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(dtp1.Value.Date)
    End Sub

    Private Sub SlettTabellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettTabellToolStripMenuItem.Click

        Try
            sporring("TRUNCATE TABLE Person")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
