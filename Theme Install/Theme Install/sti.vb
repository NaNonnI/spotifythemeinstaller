Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text

Public Class sti

    Private Sub installb_Click(sender As Object, e As EventArgs) Handles installb.Click
        If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("appdata") + "\Spotify\sti.ako") Then

            txtOutput.Clear()
            progressBar.Value = 0

            If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("homepath") + "\spicetify-cli\spicetify.exe") Then
                txtCommand.Text = "Invoke-WebRequest -UseBasicParsing ""https://raw.githubusercontent.com/khanhas/spicetify-cli/master/install.ps1"" | Invoke-Expression"
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ spicetify-cli Installed ✔️""")
                progressBar.Value = progressBar.Value + 8.33
            Else
                txtOutput.Text = RunScript("echo ""✔️ spicetify-cli Already Installed ✔️""")
                progressBar.Value = progressBar.Value + 8.33
            End If

            If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("homepath") + "\.spicetify\Extensions\dribbblish.js") Then
                txtCommand.Text = "New-Item -ItemType directory -Path $env:HOMEPATH\.spicetify\Extensions"
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ Extensions Dir Created ✔️""")
                progressBar.Value = progressBar.Value + 8.33

                txtCommand.Text = "Invoke-WebRequest -OutFile $env:HOMEPATH\.spicetify\Extensions\dribbblish.js ""https://sideria.fr/scripts/sti/dribbblish.js"""
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ Extension Downloaded ✔️""")
                progressBar.Value = progressBar.Value + 8.33
            Else
                txtOutput.Text = RunScript("echo ""✔️ Extensions Already Installed ✔️""")
                progressBar.Value = progressBar.Value + 16.66
            End If

            If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("homepath") + "\.spicetify\Theme\Dribbblish") Then
                txtCommand.Text = "New-Item -ItemType directory -Path $env:HOMEPATH\.spicetify\Themes"
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ Themes Dir Created ✔️""")
                progressBar.Value = progressBar.Value + 8.33

                txtCommand.Text = "Invoke-WebRequest -OutFile $env:HOMEPATH\.spicetify\Themes\theme.zip ""https://sideria.fr/scripts/sti/theme.zip"""
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ Theme Archive Downloaded ✔️""")
                progressBar.Value = progressBar.Value + 8.33

                txtCommand.Text = "Expand-Archive $env:HOMEPATH\.spicetify\Themes\theme.zip -DestinationPath $env:HOMEPATH\.spicetify\Themes\"
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ Theme Archive Extracted ✔️""")
                progressBar.Value = progressBar.Value + 8.33

                txtCommand.Text = "Remove-Item –path $env:HOMEPATH\.spicetify\Themes\theme.zip"
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ Theme Archive Deleted ✔️""")
                progressBar.Value = progressBar.Value + 8.33
            Else
                txtOutput.Text = RunScript("echo ""✔️ Theme Already Installed ✔️""")
                progressBar.Value = progressBar.Value + 33.32
            End If

            txtCommand.Text = "spicetify backup apply"
            txtOutput.Text = RunScript(txtCommand.Text)
            txtOutput.Text = RunScript("echo ""✔️ Spotify Backuped ✔️""")
            progressBar.Value = progressBar.Value + 8.33

            If downgradecb.Checked = True Then
                If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("appdata") + "\Spotify\stid.ako") Then
                    txtCommand.Text = "Invoke-WebRequest -OutFile $env:TEMP\downgrade.bat ""https://sideria.fr/scripts/sti/downgrade.bat"""
                    txtOutput.Text = RunScript(txtCommand.Text)
                    txtCommand.Text = "Start-Process ""cmd.exe"" ""/c %TEMP%\downgrade.bat"""
                    txtOutput.Text = RunScript(txtCommand.Text)
                    txtCommand.Text = "Remove-Item –path $env:TEMP\downgrade.bat"
                    txtOutput.Text = RunScript(txtCommand.Text)
                    txtCommand.Text = "New-Item -Path ""$env:APPDATA\Spotify"" -Name ""stid.ako"" -ItemType ""file"" -Value ""This is a checker, if it is here, Spotify has been downgraded. DO NOT DELETE."""
                    txtOutput.Text = RunScript(txtCommand.Text)
                    txtOutput.Text = RunScript("echo ""✔️ Downgraded ✔️""")
                    progressBar.Value = progressBar.Value + 8.33
                Else
                    txtOutput.Text = RunScript("echo ""✔️ Already Downgraded ✔️""")
                    progressBar.Value = progressBar.Value + 8.33
                End If
            End If

            txtCommand.Text = "spicetify config extensions dribbblish.js"
            txtOutput.Text = RunScript(txtCommand.Text)
            txtOutput.Text = RunScript("echo ""✔️ Extension Initialisez ✔️""")
            progressBar.Value = progressBar.Value + 8.33

            txtCommand.Text = "spicetify config current_theme dribbblish color_scheme " + tc.Text
            txtOutput.Text = RunScript(txtCommand.Text)
            txtOutput.Text = RunScript("echo ""✔️ Extension Configured ✔️""")
            progressBar.Value = progressBar.Value + 8.33

            txtCommand.Text = "spicetify config inject_css 1 replace_colors 1 overwrite_assets 1"
            txtOutput.Text = RunScript(txtCommand.Text)
            txtOutput.Text = RunScript("echo ""✔️ Extension Injected ✔️""")
            progressBar.Value = progressBar.Value + 8.33

            txtCommand.Text = "spicetify apply"
            txtOutput.Text = RunScript(txtCommand.Text)
            txtCommand.Text = "New-Item -Path ""$env:APPDATA\Spotify"" -Name ""sti.ako"" -ItemType ""file"" -Value ""This is a checker, if it is here, the theme is installed. DO NOT DELETE."""
            txtOutput.Text = RunScript(txtCommand.Text)
            txtOutput.Text = RunScript("echo ""✔️ Spotify is now Spiced Up ! ✔️""")
            progressBar.Value = 100
            MsgBox("(｡◕‿◕｡) Done!")
        Else
            txtOutput.Clear()
            progressBar.Value = 0

            If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("homepath") + "\.spicetify\Extensions\dribbblish.js") Then
                txtOutput.Text = RunScript("echo ""✔️ Extension Already Uninstalled ✔️""")
                progressBar.Value = progressBar.Value + 16.66
            Else
                txtCommand.Text = "Remove-Item –path $env:HOMEPATH\.spicetify\Extensions -Recurse"
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ Extension Dir Unistalled ✔️""")
                progressBar.Value = progressBar.Value + 16.66
            End If

            If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("homepath") + "\.spicetify\Theme\Dribbblish") Then
                txtOutput.Text = RunScript("echo ""✔️ Theme Already Uninstalled ✔️""")
                progressBar.Value = progressBar.Value + 16.66
            Else
                txtCommand.Text = "Remove-Item –path $env:HOMEPATH\.spicetify\Themes -Recurse"
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ Themes Dir Unistalled ✔️""")
                progressBar.Value = progressBar.Value + 16.66
            End If

            If downgradecb.Checked = True Then
                If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("appdata") + "\Spotify\stid.ako") Then
                    txtOutput.Text = RunScript("echo ""✔️ Not Downgraded ✔️""")
                    dl.Text = "Downgrade : No"
                    progressBar.Value = progressBar.Value + 16.66
                Else
                    MsgBox("Warning ! Spotify can't be upgraded (future update), you have to reinstall it!")
                    txtCommand.Text = "Invoke-WebRequest -OutFile $env:APPDATA\Spotify\SpotifySetup.exe ""https://sideria.fr/scripts/sti/SpWebInst0.exe"""
                    txtOutput.Text = RunScript(txtCommand.Text)
                    txtCommand.Text = "Start-Process $env:APPDATA\Spotify\SpotifySetup.exe"
                    txtOutput.Text = RunScript(txtCommand.Text)
                    txtCommand.Text = "Remove-Item –path $env:APPDATA\Spotify\SpotifySetup.exe"
                    txtOutput.Text = RunScript(txtCommand.Text)
                    txtCommand.Text = "Remove-Item –path $env:APPDATA\Spotify\netutils.dll"
                    txtOutput.Text = RunScript(txtCommand.Text)
                    txtCommand.Text = "Remove-Item –path $env:APPDATA\Spotify\stid.ako"
                    txtOutput.Text = RunScript(txtCommand.Text)
                    txtOutput.Text = RunScript("echo ""✔️ Upgraded! ✔️""")
                    dl.Text = "Upgraded : Yes"
                    progressBar.Value = progressBar.Value + 16.66
                End If
            End If

            txtCommand.Text = "spicetify restore backup"
            txtOutput.Text = RunScript(txtCommand.Text)
            txtOutput.Text = RunScript("echo ""✔️ Spotify Backup Restored ✔️""")
            progressBar.Value = progressBar.Value + 16.66

            If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("homepath") + "\spicetify-cli\spicetify.exe") Then
                txtOutput.Text = RunScript("echo ""✔️ spicetify-cli Already Uninstalled ✔️""")
                progressBar.Value = 100
            Else
                txtCommand.Text = "Remove-Item –path $env:HOMEPATH\spicetify-cli -Recurse"
                txtOutput.Text = RunScript(txtCommand.Text)
                txtCommand.Text = "Remove-Item –path $env:APPDATA\Spotify\sti.ako"
                txtOutput.Text = RunScript(txtCommand.Text)
                txtOutput.Text = RunScript("echo ""✔️ spicetify-cli Uninstalled ✔️""")
                progressBar.Value = 100
            End If

            MsgBox("(｡◕‿◕｡) Done!")
        End If
        Me.Close()
    End Sub

    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Private Sub Closeb_Click(sender As System.Object, e As System.EventArgs) Handles closeb.Click
        Me.Close()
    End Sub

    Private Sub panel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles panel.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub panel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles panel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub sti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baserb.Checked = True
        Colors.Enabled = True
        If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("appdata") + "\Spotify\stid.ako") Then
            If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("appdata") + "\Spotify\sti.ako") Then
                installb.Text = "Install"
                downgradecb.Text = "Downgrade"
                MsgBox("This only work with the Spotify software, not with the Microsoft one.")
            Else
                installb.Text = "Unistall"
                baserb.Checked = False
                baserb.Enabled = False
                darkrb.Enabled = False
                dracularb.Enabled = False
                gruvboxrb.Enabled = False
                horizonrb.Enabled = False
                norddarkrb.Enabled = False
                nordlightrb.Enabled = False
                purplerb.Enabled = False
                samourairb.Enabled = False
                whiterb.Enabled = False
                downgradecb.Enabled = False
                downgradecb.Text = "Not downgraded"
                tc.Text = "N/A"
                dl.Text = "As been downgraded"
                MsgBox("Theme already installed. To reinstall the theme (If deleted it by an update) please unistall And install.")
            End If
        Else
            installb.Text = "Unistall"
            baserb.Checked = False
            baserb.Enabled = False
            darkrb.Enabled = False
            dracularb.Enabled = False
            gruvboxrb.Enabled = False
            horizonrb.Enabled = False
            norddarkrb.Enabled = False
            nordlightrb.Enabled = False
            purplerb.Enabled = False
            samourairb.Enabled = False
            whiterb.Enabled = False
            tc.Text = "N/A"
            downgradecb.Text = "Upgrade"
            dl.Text = "Downgraded : Yes"
            MsgBox("Theme already installed. To reinstall the theme (If deleted it by an update) please unistall And install. Spotify can NOW be upgraded! :)")
        End If
    End Sub

    Private Sub credit_Click(sender As Object, e As EventArgs) Handles credit.Click
        System.Diagnostics.Process.Start("https://github.com/khanhas/spicetify-cli")
    End Sub

    Dim Red, Blue, Green As String

    Private Sub baserb_CheckedChanged(sender As Object, e As EventArgs) Handles baserb.CheckedChanged
        tc.Text = "base"
    End Sub

    Private Sub darkrb_CheckedChanged(sender As Object, e As EventArgs) Handles darkrb.CheckedChanged
        tc.Text = "dark"
    End Sub

    Private Sub dracularb_CheckedChanged(sender As Object, e As EventArgs) Handles dracularb.CheckedChanged
        tc.Text = "dracula"
    End Sub

    Private Sub gruvboxrb_CheckedChanged(sender As Object, e As EventArgs) Handles gruvboxrb.CheckedChanged
        tc.Text = "gruvbox"
    End Sub

    Private Sub horizonrb_CheckedChanged(sender As Object, e As EventArgs) Handles horizonrb.CheckedChanged
        tc.Text = "horizon"
    End Sub

    Private Sub norddarkrb_CheckedChanged(sender As Object, e As EventArgs) Handles norddarkrb.CheckedChanged
        tc.Text = "nord-dark"
    End Sub

    Private Sub nordlightrb_CheckedChanged(sender As Object, e As EventArgs) Handles nordlightrb.CheckedChanged
        tc.Text = "nord-light"
    End Sub

    Private Sub purplerb_CheckedChanged(sender As Object, e As EventArgs) Handles purplerb.CheckedChanged
        tc.Text = "purple"
    End Sub
    Private Sub samourairb_CheckedChanged(sender As Object, e As EventArgs) Handles samourairb.CheckedChanged
        tc.Text = "samourai"
    End Sub

    Private Sub downgradecb_CheckedChanged(sender As Object, e As EventArgs) Handles downgradecb.CheckedChanged
        If downgradecb.Checked = True Then
            dl.Text = "Downgrade : Yes"
        Else
            dl.Text = "Downgrade : No"
        End If
    End Sub

    Private Sub whiterb_CheckedChanged(sender As Object, e As EventArgs) Handles whiterb.CheckedChanged
        tc.Text = "white"
    End Sub

    Private Sub Colors_Tick(sender As Object, e As EventArgs) Handles Colors.Tick
        Red = Int(Rnd() * 255)
        Blue = Int(Rnd() * 255)
        Green = Int(Rnd() * 255)

        credit.ForeColor = Color.FromArgb(Red, Blue, Green)
    End Sub

    Private Function RunScript(ByVal script As String) As String
        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()
        Dim pipeline As Pipeline = runspace.CreatePipeline
        pipeline.Commands.AddScript(script)
        pipeline.Commands.Add("Out-String")
        Dim results As Collection(Of PSObject) = pipeline.Invoke
        runspace.Close()
        Dim stringBuilder As StringBuilder = New StringBuilder()
        For Each ps As PSObject In results
            stringBuilder.AppendLine(ps.ToString())
        Next
        Return stringBuilder.ToString()
    End Function

End Class

' powershell.exe -Command "Invoke-WebRequest -OutFile ./file-name https://location/file-name