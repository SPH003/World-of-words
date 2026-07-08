Imports System.Drawing.Text

Public Class HomePage

    Private borderForm As New Form
    Public xcolor As Color
    Dim p1, p2, p3, p4, p5, p6, p7, p8 As String
    Dim locrndx, locrndy As Integer

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Resources.app_icon

        '''' changing program screen size ''''

        Me.Height = 600
        Me.Width = 800
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()

        '' changing colors

        Me.BackColor = Color.FromArgb(29, 53, 87)

        TableLayoutPanel2.BackColor = Color.FromArgb(69, 123, 157)
        TableLayoutPanel1.BackColor = Color.FromArgb(69, 123, 157)

        PictureBox1.BackColor = Color.FromArgb(69, 123, 157)
        PictureBox2.BackColor = Color.FromArgb(69, 123, 157)
        PictureBox3.BackColor = Color.FromArgb(69, 123, 157)
        PictureBox4.BackColor = Color.FromArgb(69, 123, 157)
        PictureBox5.BackColor = Color.FromArgb(69, 123, 157)

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SweetsSmile400.otf")

        Button1.BackColor = Color.FromArgb(241, 250, 238)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
        Button1.ForeColor = Color.FromArgb(69, 123, 157)
        Button1.Font = New Font(pfc.Families(0), 20)

        Button2.BackColor = Color.FromArgb(241, 250, 238)
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
        Button2.ForeColor = Color.FromArgb(69, 123, 157)
        Button2.Font = New Font(pfc.Families(0), 20)

        Button3.BackColor = Color.FromArgb(241, 250, 238)
        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
        Button3.ForeColor = Color.FromArgb(69, 123, 157)
        Button3.Font = New Font(pfc.Families(0), 20)

        Button4.BackColor = Color.FromArgb(241, 250, 238)
        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
        Button4.ForeColor = Color.FromArgb(69, 123, 157)
        Button4.Font = New Font(pfc.Families(0), 20)

        Button5.BackColor = Color.FromArgb(241, 250, 238)
        Button5.FlatStyle = FlatStyle.Flat
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
        Button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
        Button5.ForeColor = Color.FromArgb(69, 123, 157)
        Button5.Font = New Font(pfc.Families(0), 20)

        Button7.BackColor = Color.FromArgb(241, 250, 238)
        Button7.FlatStyle = FlatStyle.Flat
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
        Button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
        Button7.ForeColor = Color.FromArgb(69, 123, 157)
        Button7.Font = New Font(pfc.Families(0), 20)

        '' changing item sizes

        Button1.Height = (ClientSize.Height / 10)
        Button1.Width = (ClientSize.Width / 5)
        Button2.Height = (ClientSize.Height / 10)
        Button2.Width = (ClientSize.Width / 5)
        Button3.Height = (ClientSize.Height / 10)
        Button3.Width = (ClientSize.Width / 5)
        Button4.Height = (ClientSize.Height / 10)
        Button4.Width = (ClientSize.Width / 5)
        Button5.Height = (ClientSize.Height / 10)
        Button5.Width = (ClientSize.Width / 5)
        Button7.Height = (ClientSize.Height / 10)
        Button7.Width = (ClientSize.Width / 5)

        TableLayoutPanel2.Height = ClientSize.Height - 40
        TableLayoutPanel2.Width = ClientSize.Width - 40

        Label1.Font = New Font(pfc.Families(0), 40)
        Label2.Font = New Font(pfc.Families(0), 12)
        Label1.BackColor = Color.FromArgb(69, 123, 157)
        Label2.BackColor = Color.FromArgb(69, 123, 157)
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White

        '' changing language

        Dim lng As String = My.Settings.language

        Select Case lng
            Case "eng"

                Button7.Text = "Let's Play"
                Button5.Text = "Book"
                Button2.Text = "Quiz"
                Button3.Text = "About Us"
                Button4.Text = "Exit"
                Button1.Text = "Search"
                p1 = "Settings"
                p2 = "Theme"
                p3 = "Laws"
                p4 = "Help"
                p5 = "Catch Me If You Can!!"
                p6 = "You Won"
                p7 = " Ha Ha Ha" & vbNewLine & "Maybe Next Time"
                p8 = "Stop the game"

            Case "per"

                Button7.Text = "وقت بازیه"
                Button5.Text = "کتاب"
                Button2.Text = "آزمون"
                Button3.Text = "درباره نرم‌افزار"
                Button4.Text = "خروج"
                Button1.Text = "واژه‌یاب"
                p1 = "زبان برنامه"
                p2 = "پوسته"
                p3 = "قوانین"
                p4 = "راهنما"
                p5 = "طعمه رو بگیر"
                p6 = "بردی"
                p7 = "ها ها ها" & vbNewLine & "دفعه بعد میبینمت"
                p8 = "پایان بازی"

            Case "fra"

                Button7.Text = "Jouons"
                Button5.Text = "Livre"
                Button2.Text = "Questionnaire"
                Button3.Text = "À propos de nous"
                Button4.Text = "Sortie"
                Button1.Text = "Recherche"
                p1 = "Paramètres"
                p2 = "Thème"
                p3 = "Lois"
                p4 = "Aider"
                p5 = "Attrape-moi si tu peux!!"
                p6 = "Tu as gagné"
                p7 = " Ha Ha Ha" & vbNewLine & "La prochaine fois peut-être"
                p8 = "Arrêter le jeu"

        End Select

        ToolTip1.SetToolTip(PictureBox1, p1)
        ToolTip1.SetToolTip(PictureBox2, p2)
        ToolTip1.SetToolTip(PictureBox3, p3)
        ToolTip1.SetToolTip(PictureBox4, p4)

        Button1.Width = Button3.ClientSize.Width
        Button2.Width = Button3.ClientSize.Width
        Button4.Width = Button3.ClientSize.Width
        Button5.Width = Button3.ClientSize.Width
        Button7.Width = Button3.ClientSize.Width

        '' changing location of items

        TableLayoutPanel2.Location = New Point((ClientSize.Width - TableLayoutPanel2.Width) \ 2,
                                 (ClientSize.Height - TableLayoutPanel2.Height) \ 2)

        TableLayoutPanel1.Location = New Point((ClientSize.Width - TableLayoutPanel1.Width) \ 2,
                                 (ClientSize.Height - TableLayoutPanel1.Height) \ 2 + 30)

        Label1.Location = New Point((ClientSize.Width - Label1.ClientSize.Width) / 2,
                                     25)
        Label2.Location = New Point((ClientSize.Width - Label2.ClientSize.Width) / 2,
                                     Label1.Location.Y + Label1.ClientSize.Height +
                                     2)

        '' Changing Theme

        Dim thememodel As String = My.Settings.theme

        Select Case thememodel
            Case "boy"

                Me.BackColor = Color.FromArgb(29, 53, 87)
                TableLayoutPanel2.BackColor = Color.FromArgb(69, 123, 157)
                TableLayoutPanel1.BackColor = Color.FromArgb(69, 123, 157)
                xcolor = Color.FromArgb(29, 53, 87)

                Button1.BackColor = Color.FromArgb(241, 250, 238)
                Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
                Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
                Button1.ForeColor = Color.FromArgb(69, 123, 157)

                Button2.BackColor = Color.FromArgb(241, 250, 238)
                Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
                Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
                Button2.ForeColor = Color.FromArgb(69, 123, 157)

                Button3.BackColor = Color.FromArgb(241, 250, 238)
                Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
                Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
                Button3.ForeColor = Color.FromArgb(69, 123, 157)

                Button4.BackColor = Color.FromArgb(241, 250, 238)
                Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
                Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
                Button4.ForeColor = Color.FromArgb(69, 123, 157)

                Button5.BackColor = Color.FromArgb(241, 250, 238)
                Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
                Button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
                Button5.ForeColor = Color.FromArgb(69, 123, 157)

                Button7.BackColor = Color.FromArgb(241, 250, 238)
                Button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220)
                Button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 123, 157)
                Button7.ForeColor = Color.FromArgb(69, 123, 157)

                Label1.BackColor = Color.FromArgb(69, 123, 157)
                Label2.BackColor = Color.FromArgb(69, 123, 157)

            Case "girl"

                Me.BackColor = Color.FromArgb(255, 175, 204)
                TableLayoutPanel2.BackColor = Color.FromArgb(255, 200, 221)
                TableLayoutPanel1.BackColor = Color.FromArgb(255, 200, 221)
                PictureBox1.BackColor = Color.FromArgb(255, 200, 221)
                PictureBox2.BackColor = Color.FromArgb(255, 200, 221)
                PictureBox3.BackColor = Color.FromArgb(255, 200, 221)
                PictureBox4.BackColor = Color.FromArgb(255, 200, 221)
                PictureBox5.BackColor = Color.FromArgb(255, 200, 221)
                xcolor = Color.FromArgb(255, 175, 204)

                Button1.BackColor = Color.FromArgb(255, 175, 204)
                Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 180, 219)
                Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 200, 221)
                Button1.ForeColor = Color.White

                Button2.BackColor = Color.FromArgb(255, 175, 204)
                Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 180, 219)
                Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 200, 221)
                Button2.ForeColor = Color.White

                Button3.BackColor = Color.FromArgb(255, 175, 204)
                Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 180, 219)
                Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 200, 221)
                Button3.ForeColor = Color.White

                Button4.BackColor = Color.FromArgb(255, 175, 204)
                Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 180, 219)
                Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 200, 221)
                Button4.ForeColor = Color.White

                Button5.BackColor = Color.FromArgb(255, 175, 204)
                Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 180, 219)
                Button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 200, 221)
                Button5.ForeColor = Color.White

                Button7.BackColor = Color.FromArgb(255, 175, 204)
                Button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 180, 219)
                Button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 200, 221)
                Button7.ForeColor = Color.White

                Label1.BackColor = Color.FromArgb(255, 200, 221)
                Label2.BackColor = Color.FromArgb(255, 200, 221)

        End Select

        '' Rounded Corners Of Form

        With Me
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
        With borderForm
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .StartPosition = FormStartPosition.Manual
            .BackColor = Color.Black
            .Opacity = 0.2
            Dim r As Rectangle = Me.Bounds
            r.Inflate(2, 2)
            .Bounds = r
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
            r = New Rectangle(3, 3, Me.Width - 4, Me.Height - 4)
            .Region.Exclude(RoundedRectangle(r, 48))
            .Show(Me)
        End With

    End Sub

    '' Creating Rounded form

    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    ''Coloring Form

    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(xcolor, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    '' Search Page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        search.Show()
        Me.Close()

    End Sub

    '' Quiez Page
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Quiez.Show()

    End Sub

    '' AboutUs Page
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Us.Show()
    End Sub

    '' Exit Page
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Close()
    End Sub

    '' Book Page
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Book.Show()
    End Sub

    '' Language Page
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        MsgLanguage.Close()
        MsgLanguage.Show()
    End Sub

    '' Theme Page
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ThemeChanger.Show()
        Me.Close()
    End Sub

    ''Law Page
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Privacy.Show()
    End Sub

    '' Help Page
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Help.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Timer1.Dispose()
        MsgBox(p6)
        Label3.Visible = False
        TableLayoutPanel1.Visible = True
        ToolTip1.SetToolTip(Label4, "")
        Label4.Visible = False
        If (Timer1.Interval > 90) Then
            Timer1.Interval = Timer1.Interval - 90
        Else
            Timer1.Interval = 800
        End If

    End Sub

    Private Sub label(sender As Object, e As EventArgs) Handles Label3.MouseHover
        locrndx = Int((400 * Rnd()) + 100)
        locrndy = Int((400 * Rnd()) + 100)
        Windows.Forms.Cursor.Position = New Point(locrndx - 20, locrndy - 40)

        Label3.Location = New Point(locrndx, locrndy)
        Label3.BringToFront()

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover

        If FlowLayoutPanel1.Visible = False Then

            FlowLayoutPanel1.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        Else

            FlowLayoutPanel1.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim h As MsgBoxResult = MsgBox(p5, vbOKCancel, "Game")

        If h = vbOK Then
            Label3.Visible = True
            Timer1.Enabled = True
            TableLayoutPanel1.Visible = False
            ToolTip1.SetToolTip(Label4, p8)
            Label4.Visible = True
            Label4.Location = New Point(750, 10)
        Else

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        locrndx = Int((400 * Rnd()) + 100)
        locrndy = Int((400 * Rnd()) + 100)
        Label3.Location = New Point(locrndx, locrndy)
        Label3.BringToFront()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Timer1.Dispose()
        Timer1.Interval = 1000
        MsgBox(p7)
        Label3.Visible = False
        TableLayoutPanel1.Visible = True
        ToolTip1.SetToolTip(Label4, "")
        Label4.Visible = False

    End Sub

End Class