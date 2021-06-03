Imports System.Environment
Imports System.IO
Imports System.IO.Compression


Public Class Hauptfenster

    Dim Backupordner As String = "auto_backup"
    Dim Verzeichnis As String
    Dim Backupzahl As Integer
    Dim index As Integer = 0
    Dim config As String()
    Dim configort As String = GetFolderPath(SpecialFolder.ApplicationData) & "/HomeNosBackup/"
    Dim Standardexceptions As String = "Cabins" & vbCrLf & "Animation" & vbCrLf & "backup" & vbCrLf & "Immobilien" & vbCrLf & "Gleisstile" & vbCrLf & "Goods" & vbCrLf & "Horizon" & vbCrLf & "Lselemente" & vbCrLf & "Rollmaterial" & vbCrLf & "Technik" & vbCrLf & "Signale"
    Private Sub Hauptfenster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Datum.MinDate = DateAdd(DateInterval.Day, 1, Now.Date)

        'MsgBox("Hallo")

        If Not IO.Directory.Exists(configort) Then
            IO.Directory.CreateDirectory(configort)
        End If

        If Not My.Computer.FileSystem.FileExists(configort & "exceptions.txt") Then
            System.IO.File.AppendAllText(configort & "exceptions.txt", Standardexceptions)
        End If


        If Dir(configort & "configuration.txt") = "" Then

            Grundeinstellungen.ShowDialog()
            'MsgBox("okay")

            Verzeichnis = Grundeinstellungen.verzeichnisname
            Backupzahl = CInt(Grundeinstellungen.Backupzahl)
        Else

            config = My.Computer.FileSystem.ReadAllText(configort & "configuration.txt", System.Text.Encoding.UTF8).Split(vbCrLf)

            index = 0
            For Each x As String In config

                If index > 0 Then
                    config(index) = config(index).Substring(1, config(index).Length() - 1)

                End If
                index = index + 1
            Next

            Verzeichnis = config(0)
            Backupzahl = CInt(config(1))
            If config(2).Substring(9, 8) > Format(Now.Date, "yyyyMMdd") Then
                Datum.Value = config(2).Substring(15, 2) & "." & config(2).Substring(13, 2) & "." & config(2).Substring(9, 4)
            End If
        End If
        Projekteeinlesen()



    End Sub

    Public projekte As New List(Of String)
    Dim Ausnahmen As String()
    Dim eintragen As Boolean

    Dim backupeintraege As String()

    Sub Projekteeinlesen()

        If Not My.Computer.FileSystem.FileExists(configort & "backuplist.txt") Then
            IO.File.WriteAllText(configort & "backuplist.txt", "")
        End If
        backupeintraege = My.Computer.FileSystem.ReadAllText(configort & "backuplist.txt", System.Text.Encoding.UTF8).Split(vbCrLf)



        index = 0
        For Each x As String In backupeintraege

            If index > 0 Then
                backupeintraege(index) = backupeintraege(index).Substring(1, backupeintraege(index).Length() - 1)
            End If
            index = index + 1
        Next
        Ausnahmen = My.Computer.FileSystem.ReadAllText(configort & "exceptions.txt", System.Text.Encoding.UTF8).Split(vbCrLf)

        index = 0
        For Each x As String In Ausnahmen

            If index > 0 Then
                Ausnahmen(index) = Ausnahmen(index).Substring(1, Ausnahmen(index).Length() - 1)
            End If
            index = index + 1
        Next

        'MsgBox(Verzeichnis)
        index = 0
        If My.Computer.FileSystem.DirectoryExists(Verzeichnis) Then

            For Each foundFile As String In My.Computer.FileSystem.GetDirectories(Verzeichnis)
                'MsgBox(foundFile)

                Dim start As Integer = 1
                Dim pos As Integer
                Do While start <> 0

                    start = InStr(start + 1, foundFile, "\")

                    If start <> 0 Then
                        pos = start
                    End If

                Loop

                foundFile = foundFile.Substring(pos, foundFile.Length() - pos)

                eintragen = True

                'MsgBox()

                For Each ausnahme As String In Ausnahmen
                    If foundFile = ausnahme Then
                        eintragen = False
                        Exit For
                    End If
                Next

                If eintragen And foundFile <> Backupordner Then
                    projekte.Add(foundFile)



                    Liste.Items.Add(New ListViewItem(foundFile))
                    Liste.Items(index).SubItems.Add("")
                    For Each eintrag As String In backupeintraege

                        Dim eintraege() As String = eintrag.Split("°")


                        'MsgBox(eintraege(0))
                        If eintraege(0) = foundFile Then

                            If eintraege(1).Contains("*") Then
                                eintraege(1) = eintraege(1).Substring(0, eintraege(1).Length() - 2)
                            End If
                            'MsgBox(eintraege(1))

                            Liste.Items(index).SubItems(1).Text = eintraege(1)

                            If eintraege(2) = "true" Then

                                Liste.Items(index).Checked = True

                            Else
                                Liste.Items(index).Checked = False
                            End If
                            Exit For
                        Else

                            Liste.Items(index).SubItems(1).Text = "Kein Backup vorhanden"
                            Liste.Items(index).Checked = True

                        End If

                    Next


                    index = index + 1
                    'MsgBox(foundFile)
                End If
            Next
        Else
            MsgBox("Pfad nicht gefunden Bitte einen gültigen Pfad auswählen!")
            Exit Sub
        End If


        If My.Computer.FileSystem.DirectoryExists(Verzeichnis & "\" & Backupordner) Then

            For i As Integer = 0 To Liste.Items.Count() - 1
                Dim cnt As Integer = 0
                Dim neustes As Integer = 11111111
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Verzeichnis & "\" & Backupordner)

                    Dim start As Integer = 1
                    Dim pos As Integer
                    Do While start <> 0

                        start = InStr(start + 1, foundFile, "\")

                        If start <> 0 Then
                            pos = start
                        End If

                    Loop

                    foundFile = foundFile.Substring(pos, foundFile.Length() - pos)
                    'MsgBox(foundFile)
                    If foundFile.StartsWith(Liste.Items(i).SubItems(0).Text & "-") Then

                        cnt = cnt + 1

                        If neustes < CInt(foundFile.Substring(foundFile.Length() - 12, 8)) Then

                            neustes = CInt(foundFile.Substring(foundFile.Length() - 12, 8))

                        End If

                    End If

                Next

                'MsgBox(neustes)

                Dim DateiDatum As String = neustes.ToString.Substring(6, 2) & "." & neustes.ToString.Substring(4, 2) & "." & neustes.ToString.Substring(0, 4)
                'MsgBox(Liste.Items(i).SubItems(1).Text)
                'MsgBox(DateiDatum)
                If Liste.Items(i).SubItems(1).Text <> DateiDatum And neustes <> 11111111 Then
                    Liste.Items(i).SubItems(1).Text = DateiDatum & " *"
                ElseIf neustes = 11111111 And Liste.Items(i).SubItems(1).Text <> "Kein Backup vorhanden" Then
                    Liste.Items(i).SubItems(1).Text = "Kein Backup vorhanden *"

                End If

                Liste.Items(i).SubItems.Add("")
                If cnt <> 0 Then
                    Liste.Items(i).SubItems(2).Text = cnt
                Else Liste.Items(i).SubItems(2).Text = "-"
                End If

            Next

        End If

    End Sub

    Dim backuplisteneu As New List(Of String)
    Dim i As Integer
    Dim Configuration As String()

    Sub Reconfig(backup As Boolean)


        For i = 0 To Liste.Items.Count - 1
            'MsgBox(Liste.Items(i).SubItems(1).Text)
            If Liste.Items(i).Checked = False And Liste.Items(i).SubItems(1).Text <> "Kein Backup vorhanden" Then

                backuplisteneu.Add(Liste.Items(i).SubItems(0).Text & "°" & Liste.Items(i).SubItems(1).Text & "°false")

            ElseIf Liste.Items(i).Checked = False And Liste.Items(i).SubItems(1).Text = "Kein Backup vorhanden" Then
                backuplisteneu.Add(Liste.Items(i).SubItems(0).Text & "°" & "Kein Backup vorhanden" & "°false")
            ElseIf Liste.Items(i).Checked = True Then

                If backup Then
                    backuplisteneu.Add(Liste.Items(i).SubItems(0).Text & "°" & Format(Now.Date, "dd.MM.yyyy") & "°true")
                Else
                    backuplisteneu.Add(Liste.Items(i).SubItems(0).Text & "°" & Liste.Items(i).SubItems(1).Text & "°true")
                End If
            End If

        Next

        'MsgBox(backuplisteneu.Count())

        My.Computer.FileSystem.DeleteFile(configort & "backuplist.txt")
        IO.File.WriteAllLines(configort & "backuplist.txt", backuplisteneu)

        Configuration = My.Computer.FileSystem.ReadAllText(configort & "configuration.txt", System.Text.Encoding.UTF8).Split(vbCrLf)
        index = 0
        For Each x As String In Configuration

            If index > 0 Then
                Configuration(index) = Configuration(index).Substring(1, Configuration(index).Length() - 1)
            End If
            index = index + 1
        Next

        Configuration(2) = "nxtbckup°" & Format(Datum.Value, "yyyyMMdd")

        My.Computer.FileSystem.DeleteFile(configort & "configuration.txt")
        IO.File.WriteAllLines(configort & "configuration.txt", Configuration)




    End Sub

    Sub Backup()

        Fortschritt.Value = 0
        If Not My.Computer.FileSystem.DirectoryExists(Verzeichnis & "\" & Backupordner) Then
            My.Computer.FileSystem.CreateDirectory(Verzeichnis & "\" & Backupordner)
        End If
        Dim schritte As Integer = Liste.CheckedItems.Count

        GoButton.Enabled = False



        For i = 0 To Liste.Items.Count - 1
            Dim aeltestes As Integer = 0
            Dim aeltesteDatei As String = ""
            Dim cnt As Integer = 0
            If Liste.Items(i).Checked = True Then


                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Verzeichnis & "\" & Backupordner)

                    Dim start As Integer = 1
                    Dim pos As Integer
                    Do While start <> 0

                        start = InStr(start + 1, foundFile, "\")

                        If start <> 0 Then
                            pos = start
                        End If

                    Loop

                    foundFile = foundFile.Substring(pos, foundFile.Length() - pos)
                    'MsgBox(foundFile)

                    If foundFile.StartsWith(Liste.Items(i).SubItems(0).Text & "-") Then
                        cnt = cnt + 1
                        'MsgBox(foundFile.Substring(foundFile.Length() - 12, 8))
                        If CInt(foundFile.Substring(foundFile.Length() - 12, 8)) = CInt(Format(Now.Date, "yyyyMMdd")) Then

                            My.Computer.FileSystem.DeleteFile(Verzeichnis & "\" & Backupordner & "\" & foundFile)
                            aeltestes = 0
                            Exit For

                        ElseIf aeltestes = 0 Or aeltestes > CInt(foundFile.Substring(foundFile.Length() - 12, 8)) Then

                            aeltestes = CInt(foundFile.Substring(foundFile.Length() - 12, 8))
                            aeltesteDatei = foundFile

                        End If
                    End If


                Next

                'MsgBox(aeltesteDatei)
                'MsgBox(cnt)

                If aeltestes <> 0 And cnt >= Backupzahl Then

                    My.Computer.FileSystem.DeleteFile(Verzeichnis & "\" & Backupordner & "\" & aeltesteDatei)

                End If

                ZipFile.CreateFromDirectory(Verzeichnis & "\" & Liste.Items(i).SubItems(0).Text, Verzeichnis & "\" & Backupordner & "\" & Liste.Items(i).SubItems(0).Text & "-" & Format(Now.Date, "yyyyMMdd") & ".zip")

                If Fortschritt.Value + (100 / schritte) < 100 Then

                    Fortschritt.Value = Fortschritt.Value + (100 / schritte)

                End If
            End If


        Next
        Fortschritt.Value = 100

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        Backup()
        Reconfig(True)


    End Sub

    Private Sub AlleButton_Click(sender As Object, e As EventArgs) Handles AlleButton.Click

        For i As Integer = 0 To Liste.Items.Count() - 1

            Liste.Items(i).Checked = True

        Next

    End Sub

    Private Sub KeinButton_Click(sender As Object, e As EventArgs) Handles KeinButton.Click
        For i As Integer = 0 To Liste.Items.Count() - 1

            Liste.Items(i).Checked = False

        Next
    End Sub

    Private Sub Speichernbutton_Click(sender As Object, e As EventArgs) Handles Speichernbutton.Click

        Reconfig(False)

    End Sub

    Private Sub Configbutton_Click(sender As Object, e As EventArgs) Handles Configbutton.Click

        Grundeinstellungen.Verzeichnis.Text = config(0)
        Grundeinstellungen.Anzahleingabe.Text = config(1)
        Grundeinstellungen.nxtdatum = config(2)
        Grundeinstellungen.OKButton.Enabled = True

        Grundeinstellungen.ShowDialog()

        config(0) = Grundeinstellungen.Verzeichnis.Text
        config(1) = Grundeinstellungen.Anzahleingabe.Text

    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Reconfig(False)
        Me.Close()
    End Sub
End Class
