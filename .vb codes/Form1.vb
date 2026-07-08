Public Class Form1

    Public serial As String
    Public cdkey As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Height = 600
        Me.Width = 800

        If My.Settings.first_run = True Then
            MsgBox("لطفا سریال و رمز نرم افزار را وارد نمایید" & vbNewLine &
                    "در صورت عدم تمایل به ورود به نرم افزار عبارت زیر را تایپ نمایید" & vbNewLine &
                    "exit", MsgBoxStyle.MsgBoxRight)

            Do
                serial = InputBox("Please Enter Serial Num: ", "SerialNumber")

            Loop While (serial <> "rainbow" And serial <> "exit" And serial <> "")

            Do
                cdkey = InputBox("Please Enter Cd_Key: ", "Cd Key")

            Loop While (cdkey <> "1402" And cdkey <> "exit" And cdkey <> "")

            If serial = "exit" Or cdkey = "exit" Or cdkey = "" Then
                My.Settings.first_run = True
                MsgBox("... Try Later...")
                Me.Close()

            ElseIf serial = "rainbow" And cdkey = "1402" Then
                Timer1.Enabled = True
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Me.CenterToScreen()
            Else
                My.Settings.first_run = True
                MsgBox("... Try Later...")
                Me.Close()

            End If
        Else

            Timer1.Enabled = True
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.CenterToScreen()

        End If

        Label1.ForeColor = Color.FromArgb(241, 250, 238)
        Label2.ForeColor = Color.FromArgb(241, 250, 238)

        ProgressBar1.BackColor = Color.WhiteSmoke
        ProgressBar1.ForeColor = Color.FromArgb(230, 57, 70)
        Me.BackColor = Color.FromArgb(29, 53, 87)

        ProgressBar1.Location = New Point((ClientSize.Width - ProgressBar1.ClientSize.Width) / 2,
                                          (ClientSize.Height - ProgressBar1.Height) / 2 + 50)

        PictureBox1.Location = New Point((ClientSize.Width - PictureBox1.Width) \ 2,
                                ((ClientSize.Height - PictureBox1.Height) \ 2) - 130)

        PictureBox2.Location = New Point((ClientSize.Width - PictureBox2.ClientSize.Width) / 2,
                                         ClientSize.Height - PictureBox2.ClientSize.Height)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.RightToLeft = Windows.Forms.RightToLeft.Yes
        Label2.RightToLeft = Windows.Forms.RightToLeft.Yes

        Label2.Text = ProgressBar1.Value & "%"
        ProgressBar1.Value += 1

        If ProgressBar1.Value = 20 Then

            Label1.Text = "از برنامه‌نویسان جوان حمایت کنیم"

        End If

        If ProgressBar1.Value = 80 Then

            Label1.Text = "در حال آماده سازی برنامه... "

        End If
        If ProgressBar1.Value = 101 Then

            Label1.Text = "آماده‌سازی با موفقیت انجام گرفت "

        End If

        If ProgressBar1.Value = 102 Then

            If My.Settings.first_run = True Then
                My.Settings.first_run = False
                MsgLanguage.Show()
                My.Settings.theme = "boy"
                Me.Hide()
                Timer1.Dispose()
            Else
                HomePage.Show()
                Me.Hide()
                Timer1.Dispose()
            End If

        End If

        Label1.Location = New Point(ProgressBar1.Location.X + ProgressBar1.ClientSize.Width - Label1.ClientSize.Width,
                                    ProgressBar1.Location.Y + ProgressBar1.ClientSize.Height + Label1.ClientSize.Height / 2)
        Label2.Location = New Point(ProgressBar1.Location.X, Label1.Location.Y)

    End Sub

End Class