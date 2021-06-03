<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Grundeinstellungen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grundeinstellungen))
        Me.Verzeichnis = New System.Windows.Forms.TextBox()
        Me.Anzahleingabe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Verzeichniswahl = New System.Windows.Forms.Button()
        Me.Verzeichnisdialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.WinStart = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Verzeichnis
        '
        Me.Verzeichnis.Location = New System.Drawing.Point(130, 27)
        Me.Verzeichnis.Name = "Verzeichnis"
        Me.Verzeichnis.Size = New System.Drawing.Size(217, 20)
        Me.Verzeichnis.TabIndex = 0
        '
        'Anzahleingabe
        '
        Me.Anzahleingabe.Location = New System.Drawing.Point(152, 66)
        Me.Anzahleingabe.Name = "Anzahleingabe"
        Me.Anzahleingabe.Size = New System.Drawing.Size(34, 20)
        Me.Anzahleingabe.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Projektverzeichnis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Anzahl der Backups"
        '
        'OKButton
        '
        Me.OKButton.Enabled = False
        Me.OKButton.Location = New System.Drawing.Point(238, 69)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(96, 36)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Verzeichniswahl
        '
        Me.Verzeichniswahl.Location = New System.Drawing.Point(347, 27)
        Me.Verzeichniswahl.Name = "Verzeichniswahl"
        Me.Verzeichniswahl.Size = New System.Drawing.Size(27, 20)
        Me.Verzeichniswahl.TabIndex = 5
        Me.Verzeichniswahl.Text = "..."
        Me.Verzeichniswahl.UseVisualStyleBackColor = True
        '
        'WinStart
        '
        Me.WinStart.AutoSize = True
        Me.WinStart.Location = New System.Drawing.Point(152, 102)
        Me.WinStart.Name = "WinStart"
        Me.WinStart.Size = New System.Drawing.Size(15, 14)
        Me.WinStart.TabIndex = 6
        Me.WinStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mit Windows starten"
        '
        'Grundeinstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 138)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WinStart)
        Me.Controls.Add(Me.Verzeichniswahl)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Anzahleingabe)
        Me.Controls.Add(Me.Verzeichnis)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Grundeinstellungen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grundeinstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Verzeichnis As TextBox
    Friend WithEvents Anzahleingabe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents Verzeichniswahl As Button
    Friend WithEvents Verzeichnisdialog As FolderBrowserDialog
    Friend WithEvents WinStart As CheckBox
    Friend WithEvents Label3 As Label
End Class
