Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class Quiez

    Dim azmoon, azmoonre, pagename, p1, p2, p3, warning, resluttest As String
    Dim cloaction As Integer
    Dim dt As New DataTable
    Dim a, b, ID, rndnumber As Integer
    Dim qnumber As Integer = 0
    Dim points As Integer = 0
    Dim araylist As New ArrayList
    Dim quizlist As ArrayList
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & "wow_database.mdb;Jet OLEDB:Database Password=rainBOW1402!;")

    Private Sub Quiez_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Resources.app_icon

        '''' Changing program screen size ''''

        Me.Height = 600
        Me.Width = 800
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()

        '' Changing Language

        Dim lng As String = My.Settings.language

        Select Case lng

            Case "eng"
                warning = "Please Answer The Test"
                resluttest = "Your Score Is "
                p1 = "Next Question"
                p2 = "Home Page"
                p3 = "Start"
                pagename = "Quiez"
                azmoon = "Do You Want Race against time?"

            Case "per"
                warning = "لطفا به سوال پاسخ دهید"
                resluttest = "نمره شما:  "
                p1 = "سوال بعدی"
                p2 = "بازگشت به صفحه اصلی"
                p3 = "شروع آزمون"
                pagename = "آزمون"
                azmoon = "مسابقه با زمان؟"

            Case "fra"
                warning = "Veuillez répondre au test"
                resluttest = "Ton score est"
                p1 = "Question suivante"
                p2 = "Page d'accueil"
                p3 = "Commencer"
                pagename = "Quiez"
                azmoon = "Voulez-vous une course contre la montre ?"

        End Select

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SweetsSmile400.otf")

        Label2.Text = pagename
        Label2.ForeColor = Color.White
        Label2.Font = New Font(pfc.Families(0), 20)

        ToolTip1.SetToolTip(Me.PictureBox1, p1)
        ToolTip1.SetToolTip(Me.PictureBox2, p2)
        ToolTip1.SetToolTip(Me.PictureBox3, p3)

        '' Designing Item Sizes

        TableLayoutPanel1.Height = ClientSize.Height / 3
        TableLayoutPanel1.Width = ClientSize.Width

        TableLayoutPanel2.Height = ClientSize.Height / 3
        TableLayoutPanel2.Width = ClientSize.Width

        TableLayoutPanel3.Height = ClientSize.Height / 3
        TableLayoutPanel3.Width = ClientSize.Width

        Label1.Height = TableLayoutPanel1.ClientSize.Height
        Label1.Width = TableLayoutPanel1.ClientSize.Width

        ProgressBar1.Width = TableLayoutPanel1.ClientSize.Width
        ProgressBar1.Height = 20

        '' Desiging Items Location

        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel2.Location = New Point(0, TableLayoutPanel1.Height)
        TableLayoutPanel3.Location = New Point(0, 2 * TableLayoutPanel2.Height)

        Label2.Location = New Point((ClientSize.Width - Label2.ClientSize.Width) / 2,
                                    19)

        PictureBox3.Location = New Point((TableLayoutPanel3.ClientSize.Width - PictureBox3.ClientSize.Width) / 2,
                                         2 * TableLayoutPanel3.ClientSize.Height +
                                         (TableLayoutPanel3.ClientSize.Height - PictureBox3.ClientSize.Height) / 2)

        PictureBox1.Location = New Point(PictureBox3.Location.X + PictureBox1.ClientSize.Width + 20,
                                                PictureBox3.Location.Y)

        PictureBox2.Location = New Point(PictureBox3.Location.X - PictureBox2.ClientSize.Width - 20,
                                                PictureBox3.Location.Y)

        If PictureBox1.Visible = False Then
            PictureBox3.Location = PictureBox1.Location
        Else

            PictureBox3.Location = New Point((TableLayoutPanel3.ClientSize.Width - PictureBox3.ClientSize.Width) / 2,
                                             2 * TableLayoutPanel3.ClientSize.Height +
                                             (TableLayoutPanel3.ClientSize.Height - PictureBox3.ClientSize.Height) / 2)

        End If

        ProgressBar1.Location = New Point((ClientSize.Width - ProgressBar1.ClientSize.Width) / 2,
                                           0)

        '' Desiging Items Color

        TableLayoutPanel1.BackColor = Color.FromArgb(29, 53, 87)
        TableLayoutPanel2.BackColor = Color.FromArgb(69, 123, 157)
        TableLayoutPanel3.BackColor = Color.FromArgb(168, 218, 220)

        RadioButton1.ForeColor = Color.White
        RadioButton2.ForeColor = Color.White
        RadioButton3.ForeColor = Color.White
        RadioButton4.ForeColor = Color.White

        RadioButton1.BackColor = Color.FromArgb(69, 123, 157)
        RadioButton2.BackColor = Color.FromArgb(69, 123, 157)
        RadioButton3.BackColor = Color.FromArgb(69, 123, 157)
        RadioButton4.BackColor = Color.FromArgb(69, 123, 157)

        Label1.BackColor = Color.FromArgb(29, 53, 87)
        Label2.BackColor = Color.FromArgb(29, 53, 87)
        Label3.BackColor = Color.FromArgb(29, 53, 87)
        Label3.ForeColor = Color.White

        PictureBox1.BackColor = Color.FromArgb(168, 218, 220)
        PictureBox2.BackColor = Color.FromArgb(168, 218, 220)
        PictureBox3.BackColor = Color.FromArgb(168, 218, 220)

        ProgressBar1.ForeColor = Color.FromArgb(168, 218, 220)
        ProgressBar1.BackColor = Color.FromArgb(29, 53, 87)

        '' Changing Theme

        Dim thememodel As String = My.Settings.theme

        Select Case thememodel
            Case "boy"
                TableLayoutPanel1.BackColor = Color.FromArgb(29, 53, 87)
                TableLayoutPanel2.BackColor = Color.FromArgb(69, 123, 157)
                TableLayoutPanel3.BackColor = Color.FromArgb(168, 218, 220)
                PictureBox1.BackColor = Color.FromArgb(168, 218, 220)
                PictureBox2.BackColor = Color.FromArgb(168, 218, 220)
                PictureBox3.BackColor = Color.FromArgb(168, 218, 220)

                Label1.BackColor = Color.FromArgb(29, 53, 87)
                Label2.BackColor = Color.FromArgb(29, 53, 87)
                Label3.BackColor = Color.FromArgb(29, 53, 87)
                Label3.ForeColor = Color.White

                ProgressBar1.ForeColor = Color.FromArgb(168, 218, 220)

            Case "girl"
                TableLayoutPanel1.BackColor = Color.FromArgb(205, 180, 219)
                TableLayoutPanel2.BackColor = Color.FromArgb(162, 210, 255)
                TableLayoutPanel3.BackColor = Color.FromArgb(255, 175, 204)

                RadioButton1.BackColor = Color.FromArgb(162, 210, 255)
                RadioButton2.BackColor = Color.FromArgb(162, 210, 255)
                RadioButton3.BackColor = Color.FromArgb(162, 210, 255)
                RadioButton4.BackColor = Color.FromArgb(162, 210, 255)

                Label1.BackColor = Color.FromArgb(205, 180, 219)
                Label2.BackColor = Color.FromArgb(205, 180, 219)
                Label3.BackColor = Color.FromArgb(205, 180, 219)
                Label3.ForeColor = Color.White

                PictureBox1.BackColor = Color.FromArgb(255, 175, 204)
                PictureBox2.BackColor = Color.FromArgb(255, 175, 204)
                PictureBox3.BackColor = Color.FromArgb(255, 175, 204)

                ProgressBar1.ForeColor = Color.FromArgb(255, 175, 204)
                ProgressBar1.BackColor = Color.FromArgb(205, 180, 219)

        End Select

        '' Runing Random Number Creation

        Timer1.Enabled = True
        Timer1.Interval = 5
        azmoonre = vbCancel

    End Sub

    '' Creating Quetion Method
    Private Function test(ID As Integer) As ArrayList

        Dim da As New OleDbDataAdapter("Select id,word,mean,expl from table1 where id = '" & ID & "'", conn)
        da.Fill(dt)

        araylist.Add(dt.Rows(0).Item("word").ToString)
        araylist.Add(dt.Rows(0).Item("mean").ToString)

        test = araylist

    End Function

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Dim lng As String = My.Settings.language

        Select Case lng

            Case "eng"
                warning = "Please Answer The Test"
                resluttest = "Your Score Is "
                p1 = "Next Question"
                p2 = "Home Page"
                p3 = "Start"
                pagename = "Quiez"
                azmoon = "Do You Want Race against time?"

            Case "per"
                warning = "لطفا به سوال پاسخ دهید"
                resluttest = "نمره شما:  "
                p1 = "سوال بعدی"
                p2 = "بازگشت به صفحه اصلی"
                p3 = "شروع آزمون"
                pagename = "آزمون"
                azmoon = "مسابقه با زمان؟"

            Case "fra"
                warning = "Veuillez répondre au test"
                resluttest = "Ton score est"
                p1 = "Question suivante"
                p2 = "Page d'accueil"
                p3 = "Commencer"
                pagename = "Quiez"
                azmoon = "Voulez-vous une course contre la montre ?"

        End Select

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SweetsSmile400.otf")

        Label2.Text = pagename
        Label2.ForeColor = Color.White
        Label2.Font = New Font(pfc.Families(0), 20)

        ToolTip1.SetToolTip(Me.PictureBox1, p1)
        ToolTip1.SetToolTip(Me.PictureBox2, p2)
        ToolTip1.SetToolTip(Me.PictureBox3, p3)

        If e.Button = MouseButtons.Left Then
            PictureBox1.BorderStyle = BorderStyle.FixedSingle
            cloaction = Int((10 * Rnd()) + 1)
        End If
    End Sub

    '' Quiez Codes

    Private Sub pic1to1()
        If qnumber = 9 Then
            If RadioButton1.Checked = True Then
                points += 1
            End If

            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            Label1.Text = ""
            st()
            Dim audioPath As String = Application.StartupPath & "\Audio\" & "ding" & ".wav"
            My.Computer.Audio.Play(audioPath, AudioPlayMode.Background)

            Timer2.Dispose()

            ProgressBar1.Value = 0
            azmoonre = vbCancel
            MsgBox(resluttest & points & "/" & qnumber + 1)
            PictureBox1.Visible = False
            PictureBox3.Location = New Point(PictureBox3.Location.X + PictureBox1.ClientSize.Width + 20,
                                            PictureBox3.Location.Y)
            qnumber = 0
            points = 0
            b = 0
            dt.Clear()
            quizlist.Clear()
            araylist.Clear()
        Else
            Label3.Text = ""

            quizlist.Clear()
            araylist.Clear()
            qnumber += 1

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False

            b = 0

            a = rndnumber
            quizlist = test(rndnumber)
            Label1.Text = (qnumber + 1) & ". What is the meaning of " & quizlist(0) & " ?"

            RadioButton1.Text = quizlist(1)

            While (b <> 4)

                rndnumber = Int((504 * Rnd()) + 1)
                If rndnumber = a Then
                    rndnumber = Int((504 * Rnd()) + 1)
                Else
                    dt.Clear()
                    quizlist = test(rndnumber)
                    b += 1
                End If

            End While

            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            RadioButton4.Visible = True

            RadioButton2.Text = quizlist(3)
            RadioButton3.Text = quizlist(5)
            RadioButton4.Text = quizlist(7)

        End If

        Label1.Font = New Font("Microsoft time new romans", 24)
        Label1.ForeColor = Color.White

        Label1.Location = New Point((TableLayoutPanel1.ClientSize.Width - Label1.ClientSize.Width) / 2,
                                   (TableLayoutPanel1.ClientSize.Height - Label1.ClientSize.Height) / 2)

        RadioButton1.Font = New Font("Tahoma", 18)
        RadioButton2.Font = New Font("Tahoma", 18)
        RadioButton3.Font = New Font("Tahoma", 18)
        RadioButton4.Font = New Font("Tahoma", 18)

        cloaction = Int((10 * Rnd()) + 1)

        Select Case cloaction

            Case 1
                RadioButton1.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 2
                RadioButton4.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 3
                RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

            Case 4
                RadioButton3.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 5
                RadioButton4.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 6
                RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 7
                RadioButton3.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 8
                RadioButton1.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 9
                RadioButton1.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 10

                RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

        End Select

        rndnumber = Int((504 * Rnd()) + 1)
        quizlist.Clear()

    End Sub

    Private Sub pic1()
        Label3.Text = ""

        If qnumber = 9 Then
            If RadioButton1.Checked = True Or RadioButton2.Checked = True Or
                           RadioButton3.Checked = True Or RadioButton4.Checked = True Then

                If RadioButton1.Checked = True Then
                    points += 1
                End If

                RadioButton1.Visible = False
                RadioButton2.Visible = False
                RadioButton3.Visible = False
                RadioButton4.Visible = False
                Label1.Text = ""
                st()
                Dim audioPath As String = Application.StartupPath & "\Audio\" & "ding" & ".wav"
                My.Computer.Audio.Play(audioPath, AudioPlayMode.Background)

                Timer2.Dispose()

                ProgressBar1.Value = 0
                azmoonre = vbCancel
                MsgBox(resluttest & points & "/" & qnumber + 1)
                PictureBox1.Visible = False
                PictureBox3.Location = New Point(PictureBox3.Location.X + PictureBox1.ClientSize.Width + 20,
                                                PictureBox3.Location.Y)
                qnumber = 0
                points = 0
                b = 0
                dt.Clear()
                quizlist.Clear()
                araylist.Clear()
            Else
                MsgBox(warning)
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
            End If
        Else
            If RadioButton1.Checked = True Or RadioButton2.Checked = True Or
                            RadioButton3.Checked = True Or RadioButton4.Checked = True Then
                If RadioButton1.Checked = True Then

                    points += 1
                    qnumber += 1
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False

                    b = 0

                    a = rndnumber
                    quizlist = test(rndnumber)
                    Label1.Text = (qnumber + 1) & ". What is the meaning of " & quizlist(0) & " ?"

                    RadioButton1.Text = quizlist(1)

                    While (b <> 4)

                        rndnumber = Int((504 * Rnd()) + 1)
                        If rndnumber = a Then
                            rndnumber = Int((504 * Rnd()) + 1)
                        Else
                            dt.Clear()
                            quizlist = test(rndnumber)
                            b += 1
                        End If

                    End While

                    RadioButton2.Text = quizlist(3)
                    RadioButton3.Text = quizlist(5)
                    RadioButton4.Text = quizlist(7)

                    RadioButton1.Visible = True
                    RadioButton2.Visible = True
                    RadioButton3.Visible = True
                    RadioButton4.Visible = True
                Else
                    qnumber += 1

                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False

                    b = 0

                    a = rndnumber
                    quizlist = test(rndnumber)
                    Label1.Text = (qnumber + 1) & ". What is the meaning of " & quizlist(0) & " ?"

                    RadioButton1.Text = quizlist(1)

                    While (b <> 4)

                        rndnumber = Int((504 * Rnd()) + 1)
                        If rndnumber = a Then
                            rndnumber = Int((504 * Rnd()) + 1)
                        Else
                            dt.Clear()
                            quizlist = test(rndnumber)
                            b += 1
                        End If

                    End While

                    RadioButton1.Visible = True
                    RadioButton2.Visible = True
                    RadioButton3.Visible = True
                    RadioButton4.Visible = True

                    RadioButton2.Text = quizlist(3)
                    RadioButton3.Text = quizlist(5)
                    RadioButton4.Text = quizlist(7)

                End If
            Else

                MsgBox(warning)
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False

            End If

        End If

        Label1.Font = New Font("Microsoft time new romans", 24)
        Label1.ForeColor = Color.White

        Label1.Location = New Point((TableLayoutPanel1.ClientSize.Width - Label1.ClientSize.Width) / 2,
                                   (TableLayoutPanel1.ClientSize.Height - Label1.ClientSize.Height) / 2)
        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SLOTUS_0.ttf")
        RadioButton1.Font = New Font(pfc.Families(0), 18)
        RadioButton2.Font = New Font(pfc.Families(0), 18)
        RadioButton3.Font = New Font(pfc.Families(0), 18)
        RadioButton4.Font = New Font(pfc.Families(0), 18)

        Select Case cloaction

            Case 1
                RadioButton1.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 2
                RadioButton4.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 3
                RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

            Case 4
                RadioButton3.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 5
                RadioButton4.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 6
                RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 7
                RadioButton3.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 8
                RadioButton1.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 9
                RadioButton1.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 10

                RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

        End Select

        rndnumber = Int((504 * Rnd()) + 1)
        quizlist.Clear()

    End Sub

    Private Sub pic1by1()

        If qnumber = 9 Then
            If RadioButton1.Checked = True Or RadioButton2.Checked = True Or
                           RadioButton3.Checked = True Or RadioButton4.Checked = True Then

                If RadioButton1.Checked = True Then
                    points += 1
                End If

                RadioButton1.Visible = False
                RadioButton2.Visible = False
                RadioButton3.Visible = False
                RadioButton4.Visible = False
                Label1.Text = ""
                st()
                Dim audioPath As String = Application.StartupPath & "\Audio\" & "ding" & ".wav"
                My.Computer.Audio.Play(audioPath, AudioPlayMode.Background)

                Timer2.Dispose()

                ProgressBar1.Value = 0
                azmoonre = vbCancel
                MsgBox(resluttest & points & "/" & qnumber + 1)
                PictureBox1.Visible = False
                PictureBox3.Location = New Point(PictureBox3.Location.X + PictureBox1.ClientSize.Width + 20,
                                                PictureBox3.Location.Y)
                qnumber = 0
                points = 0
                b = 0
                dt.Clear()
                quizlist.Clear()
                araylist.Clear()
            Else
                MsgBox(warning)
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
            End If
        Else
            If RadioButton1.Checked = True Or RadioButton2.Checked = True Or
                            RadioButton3.Checked = True Or RadioButton4.Checked = True Then
                Label3.Text = ""
                If RadioButton1.Checked = True Then

                    points += 1
                    qnumber += 1
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False

                    b = 0

                    a = rndnumber
                    quizlist = test(rndnumber)
                    Label1.Text = (qnumber + 1) & ". What is the meaning of " & quizlist(0) & " ?"

                    RadioButton1.Text = quizlist(1)

                    While (b <> 4)

                        rndnumber = Int((504 * Rnd()) + 1)
                        If rndnumber = a Then
                            rndnumber = Int((504 * Rnd()) + 1)
                        Else
                            dt.Clear()
                            quizlist = test(rndnumber)
                            b += 1
                        End If

                    End While

                    RadioButton2.Text = quizlist(3)
                    RadioButton3.Text = quizlist(5)
                    RadioButton4.Text = quizlist(7)

                    RadioButton1.Visible = True
                    RadioButton2.Visible = True
                    RadioButton3.Visible = True
                    RadioButton4.Visible = True
                Else
                    qnumber += 1

                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False

                    b = 0

                    a = rndnumber
                    quizlist = test(rndnumber)
                    Label1.Text = (qnumber + 1) & ". What is the meaning of " & quizlist(0) & " ?"

                    RadioButton1.Text = quizlist(1)

                    While (b <> 4)

                        rndnumber = Int((504 * Rnd()) + 1)
                        If rndnumber = a Then
                            rndnumber = Int((504 * Rnd()) + 1)
                        Else
                            dt.Clear()
                            quizlist = test(rndnumber)
                            b += 1
                        End If

                    End While

                    RadioButton1.Visible = True
                    RadioButton2.Visible = True
                    RadioButton3.Visible = True
                    RadioButton4.Visible = True

                    RadioButton2.Text = quizlist(3)
                    RadioButton3.Text = quizlist(5)
                    RadioButton4.Text = quizlist(7)

                End If
                ProgressBar1.Value = 0
                Timer2.Dispose()
                st()
                Timer2.Enabled = True
                pl()
            Else

                MsgBox(warning)
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False

            End If

        End If

        Label1.Font = New Font("Microsoft time new romans", 24)
        Label1.ForeColor = Color.White

        Label1.Location = New Point((TableLayoutPanel1.ClientSize.Width - Label1.ClientSize.Width) / 2,
                                   (TableLayoutPanel1.ClientSize.Height - Label1.ClientSize.Height) / 2)

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SLOTUS_0.ttf")
        RadioButton1.Font = New Font(pfc.Families(0), 18)
        RadioButton2.Font = New Font(pfc.Families(0), 18)
        RadioButton3.Font = New Font(pfc.Families(0), 18)
        RadioButton4.Font = New Font(pfc.Families(0), 18)

        Select Case cloaction

            Case 1
                RadioButton1.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 2
                RadioButton4.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 3
                RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

            Case 4
                RadioButton3.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 5
                RadioButton4.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 6
                RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 7
                RadioButton3.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 8
                RadioButton1.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 9
                RadioButton1.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton2.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton2.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)
            Case 10

                RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton4.Location = New Point(30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                                   5 * TableLayoutPanel2.ClientSize.Height / 4)

                RadioButton3.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton3.ClientSize.Width - 30,
                                                 7 * TableLayoutPanel2.ClientSize.Height / 4)

        End Select

        rndnumber = Int((504 * Rnd()) + 1)
        quizlist.Clear()

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp

        Dim lng As String = My.Settings.language

        Select Case lng

            Case "eng"
                warning = "Please Answer The Test"
                resluttest = "Your Score Is "
                p1 = "Next Question"
                p2 = "Home Page"
                p3 = "Start"
                pagename = "Quiez"
                azmoon = "Do You Want Race against time?"

            Case "per"
                warning = "لطفا به سوال پاسخ دهید"
                resluttest = "نمره شما:  "
                p1 = "سوال بعدی"
                p2 = "بازگشت به صفحه اصلی"
                p3 = "شروع آزمون"
                pagename = "آزمون"
                azmoon = "مسابقه با زمان؟"

            Case "fra"
                warning = "Veuillez répondre au test"
                resluttest = "Ton score est"
                p1 = "Question suivante"
                p2 = "Page d'accueil"
                p3 = "Commencer"
                pagename = "Quiez"
                azmoon = "Voulez-vous une course contre la montre ?"

        End Select

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SweetsSmile400.otf")

        Label2.Text = pagename
        Label2.ForeColor = Color.White
        Label2.Font = New Font(pfc.Families(0), 20)

        ToolTip1.SetToolTip(Me.PictureBox1, p1)
        ToolTip1.SetToolTip(Me.PictureBox2, p2)
        ToolTip1.SetToolTip(Me.PictureBox3, p3)

        If e.Button = MouseButtons.Left Then
            PictureBox1.BorderStyle = BorderStyle.None
            If azmoonre = vbOK Then
                pic1by1()
                Select Case My.Settings.theme
                    Case "girl"
                        Label3.BackColor = Color.FromArgb(205, 180, 219)
                    Case Else
                        Label3.BackColor = Color.FromArgb(29, 53, 87)
                End Select
            Else
                pic1()

            End If

        End If
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Left Then
            PictureBox2.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    '' Back Button

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        If e.Button = MouseButtons.Left Then
            PictureBox2.BorderStyle = BorderStyle.None

            Timer1.Dispose()
            Timer2.Dispose()
            st()
            Me.Close()
            HomePage.Show()
        End If

    End Sub

    Public Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        Dim lng As String = My.Settings.language

        Select Case lng

            Case "eng"
                warning = "Please Answer The Test"
                resluttest = "Your Score Is "
                p1 = "Next Question"
                p2 = "Home Page"
                p3 = "Start"
                pagename = "Quiez"
                azmoon = "Do You Want Race against time?"

            Case "per"
                warning = "لطفا به سوال پاسخ دهید"
                resluttest = "نمره شما:  "
                p1 = "سوال بعدی"
                p2 = "بازگشت به صفحه اصلی"
                p3 = "شروع آزمون"
                pagename = "آزمون"
                azmoon = "مسابقه با زمان؟"

            Case "fra"
                warning = "Veuillez répondre au test"
                resluttest = "Ton score est"
                p1 = "Question suivante"
                p2 = "Page d'accueil"
                p3 = "Commencer"
                pagename = "Quiez"
                azmoon = "Voulez-vous une course contre la montre ?"

        End Select

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SweetsSmile400.otf")

        Label2.Text = pagename
        Label2.ForeColor = Color.White
        Label2.Font = New Font(pfc.Families(0), 20)

        ToolTip1.SetToolTip(Me.PictureBox1, p1)
        ToolTip1.SetToolTip(Me.PictureBox2, p2)
        ToolTip1.SetToolTip(Me.PictureBox3, p3)

        If e.Button = MouseButtons.Left Then

            PictureBox3.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    '' Starting Test

    Private Sub pic3(a As String)

        PictureBox1.Visible = True
        If azmoonre = vbOK Then
            ProgressBar1.Visible = True
            Timer2.Enabled = True
            pl()

            PictureBox3.Location = New Point((TableLayoutPanel3.ClientSize.Width - PictureBox3.ClientSize.Width) / 2,
                                        2 * TableLayoutPanel3.ClientSize.Height +
                                        (TableLayoutPanel3.ClientSize.Height - PictureBox3.ClientSize.Height) / 2)

            b = 0
            qnumber = 0

            a = rndnumber
            quizlist = test(rndnumber.ToString)
            Label1.Text = (qnumber + 1) & ". What is the meaning of " & quizlist(0) & " ?"

            RadioButton1.Text = quizlist(1)

            Label1.Font = New Font("Microsoft time new romans", 24)
            Label1.ForeColor = Color.White

            Label1.Location = New Point((TableLayoutPanel1.ClientSize.Width - Label1.ClientSize.Width) / 2,
                                       (TableLayoutPanel1.ClientSize.Height - Label1.ClientSize.Height) / 2)

            While (b <> 4)

                rndnumber = Int((504 * Rnd()) + 1)
                If rndnumber = a Then
                    rndnumber = Int((504 * Rnd()) + 1)
                Else
                    dt.Clear()
                    quizlist = test(rndnumber)
                    b += 1

                End If

            End While

            RadioButton2.Text = quizlist(3)
            RadioButton3.Text = quizlist(5)
            RadioButton4.Text = quizlist(7)

            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            RadioButton4.Visible = True

            Dim pfc As New PrivateFontCollection()
            pfc.AddFontFile(Application.StartupPath & "\" & "SLOTUS_0.ttf")
            RadioButton1.Font = New Font(pfc.Families(0), 18)
            RadioButton2.Font = New Font(pfc.Families(0), 18)
            RadioButton3.Font = New Font(pfc.Families(0), 18)
            RadioButton4.Font = New Font(pfc.Families(0), 18)

            RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

            RadioButton3.Location = New Point(30,
                                             7 * TableLayoutPanel2.ClientSize.Height / 4)

            RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                               5 * TableLayoutPanel2.ClientSize.Height / 4)

            RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                             7 * TableLayoutPanel2.ClientSize.Height / 4)

            quizlist.Clear()
            qnumber = 0
            points = 0
        Else
            Label3.Text = ""

            ProgressBar1.Visible = False

            PictureBox3.Location = New Point((TableLayoutPanel3.ClientSize.Width - PictureBox3.ClientSize.Width) / 2,
                                        2 * TableLayoutPanel3.ClientSize.Height +
                                        (TableLayoutPanel3.ClientSize.Height - PictureBox3.ClientSize.Height) / 2)

            b = 0
            qnumber = 0
            rndnumber = Int((504 * Rnd()) + 1)
            a = rndnumber
            quizlist = test(rndnumber)
            Label1.Text = (qnumber + 1) & ". What is the meaning of " & quizlist(0) & " ?"

            RadioButton1.Text = quizlist(1)

            Label1.Font = New Font("Microsoft time new romans", 24)
            Label1.ForeColor = Color.White

            Label1.Location = New Point((TableLayoutPanel1.ClientSize.Width - Label1.ClientSize.Width) / 2,
                                       (TableLayoutPanel1.ClientSize.Height - Label1.ClientSize.Height) / 2)

            While (b <> 4)

                rndnumber = Int((504 * Rnd()) + 1)
                If rndnumber = a Then
                    rndnumber = Int((504 * Rnd()) + 1)
                Else
                    dt.Clear()
                    quizlist = test(rndnumber)
                    b += 1

                End If

            End While

            RadioButton2.Text = quizlist(3)
            RadioButton3.Text = quizlist(5)
            RadioButton4.Text = quizlist(7)

            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            RadioButton4.Visible = True

            Dim pfc As New PrivateFontCollection()
            pfc.AddFontFile(Application.StartupPath & "\" & "SLOTUS_0.ttf")
            RadioButton1.Font = New Font(pfc.Families(0), 18)
            RadioButton2.Font = New Font(pfc.Families(0), 18)
            RadioButton3.Font = New Font(pfc.Families(0), 18)
            RadioButton4.Font = New Font(pfc.Families(0), 18)

            RadioButton2.Location = New Point(30, 5 * TableLayoutPanel2.ClientSize.Height / 4)

            RadioButton3.Location = New Point(30,
                                             7 * TableLayoutPanel2.ClientSize.Height / 4)

            RadioButton4.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton4.ClientSize.Width - 30,
                                               5 * TableLayoutPanel2.ClientSize.Height / 4)

            RadioButton1.Location = New Point(TableLayoutPanel2.ClientSize.Width - RadioButton1.ClientSize.Width - 30,
                                             7 * TableLayoutPanel2.ClientSize.Height / 4)

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False

            quizlist.Clear()
            qnumber = 0
            points = 0

        End If

    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        Dim lng As String = My.Settings.language

        Select Case lng

            Case "eng"
                warning = "Please Answer The Test"
                resluttest = "Your Score Is "
                p1 = "Next Question"
                p2 = "Home Page"
                p3 = "Start"
                pagename = "Quiez"
                azmoon = "Do You Want Race against time?"

            Case "per"
                warning = "لطفا به سوال پاسخ دهید"
                resluttest = "نمره شما:  "
                p1 = "سوال بعدی"
                p2 = "بازگشت به صفحه اصلی"
                p3 = "شروع آزمون"
                pagename = "آزمون"
                azmoon = "مسابقه با زمان؟"

            Case "fra"
                warning = "Veuillez répondre au test"
                resluttest = "Ton score est"
                p1 = "Question suivante"
                p2 = "Page d'accueil"
                p3 = "Commencer"
                pagename = "Quiez"
                azmoon = "Voulez-vous une course contre la montre ?"

        End Select

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SweetsSmile400.otf")

        Label2.Text = pagename
        Label2.ForeColor = Color.White
        Label2.Font = New Font(pfc.Families(0), 20)

        ToolTip1.SetToolTip(Me.PictureBox1, p1)
        ToolTip1.SetToolTip(Me.PictureBox2, p2)
        ToolTip1.SetToolTip(Me.PictureBox3, p3)

        If e.Button = MouseButtons.Left Then
            PictureBox3.BorderStyle = BorderStyle.None

            Timer2.Dispose()
            st()

            qnumber = 0
            points = 0
            ProgressBar1.Value = 0
            Select Case My.Settings.theme
                Case "girl"
                    Label3.BackColor = Color.FromArgb(205, 180, 219)
                Case Else
                    Label3.BackColor = Color.FromArgb(29, 53, 87)
            End Select
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False

            azmoonre = MsgBox(azmoon, vbOKCancel + vbDefaultButton2 + vbQuestion)
            pic3(azmoonre)

        End If

    End Sub

    '' Creating Random Number
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        rndnumber = Int((504 * Rnd()) + 1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Label3.Text = ProgressBar1.Value + 1
        Label3.Location = New Point((ProgressBar1.ClientSize.Width - Label3.ClientSize.Width) / 2,
                                    (ProgressBar1.ClientSize.Height - Label3.ClientSize.Height) / 2)

        If Label3.Text >= 5 Then
            Select Case My.Settings.theme
                Case "girl"
                    Label3.BackColor = Color.FromArgb(255, 175, 204)
                Case Else
                    Label3.BackColor = Color.FromArgb(168, 218, 220)

            End Select

        End If

        If ProgressBar1.Value = 10 Then
            Label3.Text = ""
            ProgressBar1.Value = 0
            pic1to1()

            Select Case My.Settings.theme
                Case "girl"
                    Label3.BackColor = Color.FromArgb(205, 180, 219)
                Case Else
                    Label3.BackColor = Color.FromArgb(29, 53, 87)
            End Select
        Else
            ProgressBar1.Value += 1

        End If

    End Sub

    Private Sub pl()
        Dim audioPath As String = Application.StartupPath & "\Audio\" & "DesktopClockTicks" & ".wav"
        My.Computer.Audio.Play(audioPath, AudioPlayMode.Background)

    End Sub

    Private Sub st()
        My.Computer.Audio.Stop()

    End Sub

End Class