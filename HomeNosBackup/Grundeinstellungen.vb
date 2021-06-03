Imports System.Environment

Public Class Grundeinstellungen

    Dim configort As String = GetFolderPath(SpecialFolder.ApplicationData) & "/HomeNosBackup/"
    Dim Startmenuort As String = GetFolderPath(SpecialFolder.Startup) & "/HomeNosBackupListener.lnk"


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Dim ausgabe As String
    Public Backupzahl As String
    Public nxtdatum As String
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        ausgabe = verzeichnisname & vbCrLf & Anzahleingabe.Text & vbCrLf & "nxtbckup°"

        If Not My.Computer.FileSystem.FileExists(configort & "config.txt") Then
            System.IO.File.AppendAllText(configort & "config.txt", ausgabe)
        Else
            My.Computer.FileSystem.DeleteFile(configort & "config.txt")
            System.IO.File.AppendAllText(configort & "config.txt", Verzeichnis.Text & vbCrLf & Anzahleingabe.Text & vbCrLf & nxtdatum)
        End If



        Backupzahl = Anzahleingabe.Text

        If Not My.Computer.FileSystem.FileExists(Startmenuort) And WinStart.Checked Then

            Dim WshShell As Object = CreateObject("WScript.Shell")
            Dim NewShortcut As Object = WshShell.CreateShortcut(Startmenuort)
            NewShortcut.TargetPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) & "\HomeNosBackupListener.exe"
            NewShortcut.WindowStyle = 1
            NewShortcut.IconLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6) & "\HomeNosBackupListener.exe"
            NewShortcut.WorkingDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6)
            NewShortcut.Save()



        End If

        If My.Computer.FileSystem.FileExists(Startmenuort) And Not WinStart.Checked Then
            My.Computer.FileSystem.DeleteFile(Startmenuort)
        End If

        Me.Close()

    End Sub

    Public verzeichnisname As String
    Private Sub Verzeichnis_Click(sender As Object, e As EventArgs) Handles Verzeichnis.TextChanged

    End Sub

    Private Sub Anzahleingabe_TextChanged(sender As Object, e As EventArgs) Handles Anzahleingabe.TextChanged
        If Verzeichnis.Text <> "" Then
            OKButton.Enabled = True
        End If
    End Sub

    Private Sub Verzeichniswahl_Click(sender As Object, e As EventArgs) Handles Verzeichniswahl.Click

        Verzeichnisdialog.ShowDialog()

        verzeichnisname = Verzeichnisdialog.SelectedPath

        Verzeichnis.Text = verzeichnisname

        If Anzahleingabe.Text <> "" Then
            OKButton.Enabled = True
        End If

    End Sub

    Private Sub Grundeinstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists(Startmenuort) Then
            WinStart.Checked = True
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles WinStart.CheckedChanged

    End Sub


End Class