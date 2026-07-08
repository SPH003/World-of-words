Imports System.Drawing.Text

Public Class ThemeChanger

    Private Sub ThemeChanger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Resources.app_icon
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()

        Dim lng As String = My.Settings.language

        Select Case lng
            Case "eng"
                Button2.Text = "Theme 2"
                Button1.Text = "Theme 1"

            Case "per"

                Button1.Text = "پوسته اول"

                Button2.Text = "پوسته دوم"

            Case "fra"

                Button1.Text = "Thème 1"

                Button2.Text = "Thème 2"

        End Select

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SweetsSmile400.otf")

        Button1.Width = ClientSize.Width
        Button1.Height = ClientSize.Height / 2
        Button2.Width = ClientSize.Width
        Button2.Height = ClientSize.Height / 2

        Button1.Location = New Point(0, 0)
        Button2.Location = New Point(0, Button1.ClientSize.Height)

        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.BackColor = Color.FromArgb(69, 123, 157)
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 53, 87)
        Button1.ForeColor = Color.White
        Button1.Font = New Font(pfc.Families(0), 30)

        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.BackColor = Color.FromArgb(255, 175, 204)
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 180, 219)
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 180, 219)
        Button2.ForeColor = Color.White
        Button2.Font = New Font(pfc.Families(0), 30)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.theme = "boy"
        HomePage.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.theme = "girl"
        HomePage.Show()
        Me.Close()

    End Sub

End Class