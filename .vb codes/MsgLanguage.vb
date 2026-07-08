Imports System.Drawing.Text

Public Class MsgLanguage

    Private Sub MsgLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SweetsSmile400.otf")

        Me.Icon = My.Resources.Resources.app_icon
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Me.CenterToScreen()

        Label1.Font = New Font(pfc.Families(0), 11)

        Label1.Location = New Point((ClientSize.Width - Label1.Width) \ 2 + 5,
                                        (ClientSize.Height - Label1.Height) \ 2 - 30)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        My.Settings.language = "eng"

        HomePage.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Settings.language = "per"

        HomePage.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Settings.language = "fra"

        HomePage.Show()
        Me.Close()

    End Sub

End Class