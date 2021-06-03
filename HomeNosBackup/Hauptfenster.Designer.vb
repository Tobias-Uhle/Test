<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hauptfenster
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hauptfenster))
        Me.Liste = New System.Windows.Forms.ListView()
        Me.Spalte1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Spalte2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Anz = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Datum = New System.Windows.Forms.DateTimePicker()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.Fortschritt = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlleButton = New System.Windows.Forms.Button()
        Me.KeinButton = New System.Windows.Forms.Button()
        Me.Speichernbutton = New System.Windows.Forms.Button()
        Me.Configbutton = New System.Windows.Forms.Button()
        Me.Closebutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Liste
        '
        Me.Liste.AutoArrange = False
        Me.Liste.CheckBoxes = True
        Me.Liste.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Spalte1, Me.Spalte2, Me.Anz})
        Me.Liste.GridLines = True
        Me.Liste.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Liste.Location = New System.Drawing.Point(32, 41)
        Me.Liste.Name = "Liste"
        Me.Liste.RightToLeftLayout = True
        Me.Liste.Size = New System.Drawing.Size(580, 320)
        Me.Liste.TabIndex = 0
        Me.Liste.UseCompatibleStateImageBehavior = False
        Me.Liste.View = System.Windows.Forms.View.Details
        '
        'Spalte1
        '
        Me.Spalte1.Text = "Projektname"
        Me.Spalte1.Width = 350
        '
        'Spalte2
        '
        Me.Spalte2.Text = "Letztes Backup"
        Me.Spalte2.Width = 185
        '
        'Anz
        '
        Me.Anz.Text = ""
        Me.Anz.Width = 20
        '
        'Datum
        '
        Me.Datum.Checked = False
        Me.Datum.CustomFormat = ""
        Me.Datum.Location = New System.Drawing.Point(410, 405)
        Me.Datum.Name = "Datum"
        Me.Datum.Size = New System.Drawing.Size(200, 20)
        Me.Datum.TabIndex = 2
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(60, 392)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(75, 23)
        Me.GoButton.TabIndex = 3
        Me.GoButton.Text = "Backup!"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'Fortschritt
        '
        Me.Fortschritt.Location = New System.Drawing.Point(154, 392)
        Me.Fortschritt.Name = "Fortschritt"
        Me.Fortschritt.Size = New System.Drawing.Size(232, 23)
        Me.Fortschritt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(415, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nächste automatische Backupanfrage:"
        '
        'AlleButton
        '
        Me.AlleButton.Location = New System.Drawing.Point(32, 9)
        Me.AlleButton.Name = "AlleButton"
        Me.AlleButton.Size = New System.Drawing.Size(92, 23)
        Me.AlleButton.TabIndex = 7
        Me.AlleButton.Text = "Alle Auswählen"
        Me.AlleButton.UseVisualStyleBackColor = True
        '
        'KeinButton
        '
        Me.KeinButton.Location = New System.Drawing.Point(129, 9)
        Me.KeinButton.Name = "KeinButton"
        Me.KeinButton.Size = New System.Drawing.Size(84, 23)
        Me.KeinButton.TabIndex = 8
        Me.KeinButton.Text = "Alle Abwählen"
        Me.KeinButton.UseVisualStyleBackColor = True
        '
        'Speichernbutton
        '
        Me.Speichernbutton.Location = New System.Drawing.Point(386, 9)
        Me.Speichernbutton.Name = "Speichernbutton"
        Me.Speichernbutton.Size = New System.Drawing.Size(143, 23)
        Me.Speichernbutton.TabIndex = 9
        Me.Speichernbutton.Text = "Einstellungen speichern"
        Me.Speichernbutton.UseVisualStyleBackColor = True
        '
        'Configbutton
        '
        Me.Configbutton.Location = New System.Drawing.Point(535, 9)
        Me.Configbutton.Name = "Configbutton"
        Me.Configbutton.Size = New System.Drawing.Size(75, 23)
        Me.Configbutton.TabIndex = 10
        Me.Configbutton.Text = "Config"
        Me.Configbutton.UseVisualStyleBackColor = True
        '
        'Closebutton
        '
        Me.Closebutton.ForeColor = System.Drawing.Color.Maroon
        Me.Closebutton.Location = New System.Drawing.Point(219, 9)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(161, 23)
        Me.Closebutton.TabIndex = 11
        Me.Closebutton.Text = "Beenden"
        Me.Closebutton.UseVisualStyleBackColor = True
        '
        'Hauptfenster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Closebutton)
        Me.Controls.Add(Me.Configbutton)
        Me.Controls.Add(Me.Speichernbutton)
        Me.Controls.Add(Me.KeinButton)
        Me.Controls.Add(Me.AlleButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Fortschritt)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.Datum)
        Me.Controls.Add(Me.Liste)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Hauptfenster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeNos Projekte-Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Liste As ListView
    Friend WithEvents Spalte1 As ColumnHeader
    Friend WithEvents Spalte2 As ColumnHeader
    Friend WithEvents Datum As DateTimePicker
    Friend WithEvents GoButton As Button
    Friend WithEvents Fortschritt As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents AlleButton As Button
    Friend WithEvents KeinButton As Button
    Friend WithEvents Speichernbutton As Button
    Friend WithEvents Configbutton As Button
    Friend WithEvents Anz As ColumnHeader
    Friend WithEvents Closebutton As Button
End Class
