Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class search

    Dim araylist As New ArrayList
    Dim result As ArrayList

    Dim voiceloc As String
    Dim e1 As String
    Dim e2 As String
    Dim p1 As String
    Dim p2 As String
    Dim p3 As String
    Dim p4 As String
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & "wow_database.mdb;Jet OLEDB:Database Password=rainBOW1402!;")
    Dim lng As String = My.Settings.language
    Dim pfc As New PrivateFontCollection()

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Resources.app_icon
        '' Desigining form size

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Height = 600
        Me.Width = 800
        Me.CenterToScreen()

        '' Language Changer

        lng = My.Settings.language

        Select Case lng
            Case "eng"
                Label1.Text = "Search Your Words"
                Label2.Text = "Meaning"
                Label4.Text = "Explanation"
                e1 = "Please Search Word First"
                e2 = "Word was not found"
                p1 = "Search"
                p2 = "Pronunciation"
                p3 = "Clear"
                p4 = "Go Back"

            Case "per"
                Label1.Text = "جست و جوی کلمه"
                Label2.Text = "معنی لغت"
                Label4.Text = "توضیحات"
                e1 = "لطفا ابتدا لغت را جست و جو نمایید"
                e2 = "لغت یافت نشد"
                p1 = "جست و جو"
                p2 = "تلفظ"
                p3 = "پاک کردن"
                p4 = "بازگشت"

            Case "fra"
                Label1.Text = "Cherchez vos mots"
                Label2.Text = "Signification"
                Label4.Text = "Explication"
                e1 = "Veuillez d'abord rechercher par mot"
                e2 = "Le mot n'a pas été trouvé"
                p1 = "Recherche"
                p2 = "prononciation"
                p3 = "Claire"
                p4 = "Retourner"

        End Select

        '' Making Hints when mouse go on buttons

        ToolTip1.SetToolTip(Me.PictureBox1, p1)
        ToolTip1.SetToolTip(Me.PictureBox2, p2)
        ToolTip1.SetToolTip(Me.PictureBox3, p3)
        ToolTip1.SetToolTip(Me.PictureBox4, p4)

        '' Designing Item Sizes

        TableLayoutPanel1.Height = ClientSize.Height / 3
        TableLayoutPanel1.Width = ClientSize.Width

        TableLayoutPanel2.Height = ClientSize.Height / 3
        TableLayoutPanel2.Width = ClientSize.Width

        TableLayoutPanel3.Height = ClientSize.Height / 3
        TableLayoutPanel3.Width = ClientSize.Width

        TextBox1.Width = TableLayoutPanel1.Width - 300

        '' Designing Text Fonts
        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SweetsSmile400.otf")

        Label1.Font = New Font(pfc.Families(0), 20)
        Label2.Font = New Font(pfc.Families(0), 20)
        Label3.Font = New Font(pfc.Families(0), 16)
        Label4.Font = New Font(pfc.Families(0), 20)
        Label5.Font = New Font(pfc.Families(0), 12)

        TextBox1.Font = New Font(pfc.Families(0), 20)

        '' Desiging Items Location

        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel2.Location = New Point(0, TableLayoutPanel1.Height)
        TableLayoutPanel3.Location = New Point(0, TableLayoutPanel2.Height + TableLayoutPanel2.Location.Y)

        TextBox1.Location = New Point((TableLayoutPanel1.Width - TextBox1.Width) / 2,
                                      (TableLayoutPanel1.Height - TextBox1.Height) / 2)

        Label1.Location = New Point((TableLayoutPanel1.Width - Label1.ClientSize.Width) / 2, 40)

        PictureBox1.Location = New Point(TextBox1.Location.X + (TextBox1.ClientSize.Width / 2) - PictureBox1.ClientSize.Width,
                                         TableLayoutPanel1.Height + ((TableLayoutPanel2.Height - PictureBox1.Height) / 2))

        PictureBox2.Location = New Point(PictureBox1.Location.X - PictureBox2.ClientSize.Width,
                                         TableLayoutPanel1.Height + ((TableLayoutPanel2.Height - PictureBox2.Height) / 2))

        PictureBox4.Location = New Point(PictureBox1.Location.X + PictureBox4.ClientSize.Width,
                                         TableLayoutPanel1.Height + ((TableLayoutPanel2.Height - PictureBox4.Height) / 2))

        PictureBox3.Location = New Point(PictureBox4.Location.X + PictureBox3.ClientSize.Width,
                                         TableLayoutPanel1.Height + ((TableLayoutPanel2.Height - PictureBox3.Height) / 2))

        Label2.Location = New Point((ClientSize.Width - Label2.ClientSize.Width) / 2, TableLayoutPanel1.ClientSize.Height +
                                    TableLayoutPanel2.ClientSize.Height + 10)

        Label4.Location = New Point((ClientSize.Width - Label4.ClientSize.Width) / 2, Label2.Location.Y + Label4.ClientSize.Height + 40)

        '' Desiging Items Color

        TableLayoutPanel1.BackColor = Color.FromArgb(29, 53, 87)
        TableLayoutPanel2.BackColor = Color.FromArgb(69, 123, 157)
        TableLayoutPanel3.BackColor = Color.FromArgb(241, 250, 238)

        Label1.BackColor = Color.FromArgb(29, 53, 87)
        Label1.ForeColor = Color.White

        TextBox1.BackColor = Color.FromArgb(29, 53, 87)
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.ForeColor = Color.White

        '' Changing Theme

        Dim thememodel As String = My.Settings.theme

        Select Case thememodel
            Case "boy"
                TableLayoutPanel1.BackColor = Color.FromArgb(29, 53, 87)
                TableLayoutPanel2.BackColor = Color.FromArgb(69, 123, 157)
                TableLayoutPanel3.BackColor = Color.FromArgb(241, 250, 238)

                Label1.BackColor = Color.FromArgb(29, 53, 87)
                Label1.ForeColor = Color.White

                TextBox1.BackColor = Color.FromArgb(29, 53, 87)
                TextBox1.BorderStyle = BorderStyle.FixedSingle
                TextBox1.ForeColor = Color.White

            Case "girl"
                TableLayoutPanel1.BackColor = Color.FromArgb(205, 180, 219)
                TableLayoutPanel2.BackColor = Color.FromArgb(162, 210, 255)
                TableLayoutPanel3.BackColor = Color.FromArgb(255, 175, 204)

                Label1.BackColor = Color.FromArgb(205, 180, 219)
                Label1.ForeColor = Color.White

                TextBox1.BackColor = Color.FromArgb(205, 180, 219)
                TextBox1.BorderStyle = BorderStyle.Fixed3D
                TextBox1.ForeColor = Color.White

                Label2.ForeColor = Color.White
                Label2.BackColor = Color.FromArgb(255, 175, 204)
                Label3.ForeColor = Color.Black
                Label3.BackColor = Color.FromArgb(255, 175, 204)
                Label4.ForeColor = Color.White
                Label4.BackColor = Color.FromArgb(255, 175, 204)
                Label5.ForeColor = Color.Black
                Label5.BackColor = Color.FromArgb(255, 175, 204)

        End Select

    End Sub

    '' DataBase Search Method
    Private Function searchengine(words As String) As ArrayList

        Dim da As New OleDbDataAdapter("Select id,word,mean,expl from table1 where word = '" & words & "'", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows().Count = 0 Then
            Dim das As New OleDbDataAdapter("Select id,word,mean,expl from table1 where mean = '" & words & "'", conn)
            Dim dts As New DataTable
            das.Fill(dts)

            If dts.Rows().Count = 0 Then
                araylist.Add("")
                voiceloc = ""
            Else
                araylist.Add(dts.Rows(0).Item("word").ToString)
                araylist.Add(dts.Rows(0).Item("expl").ToString)
                voiceloc = dts.Rows(0).Item("word").ToString

            End If
        Else
            araylist.Add(dt.Rows(0).Item("mean").ToString)
            araylist.Add(dt.Rows(0).Item("expl").ToString)

            voiceloc = words

        End If

        searchengine = araylist

    End Function

    Public Sub playSound(loc As String)

        Select Case loc
            Case "event"
                loc = "_Event"
            Case "partial"
                loc = "_Partial"
            Case "preserve"
                loc = "_Preserve"
            Case "resume"
                loc = "_Resume"

            Case ""
                loc = "ding"
            Case "ding"
                loc = "ding"

        End Select

        Dim audioPath As String = Application.StartupPath & "\Audio\" & loc & ".wav"
        My.Computer.Audio.Play(audioPath, AudioPlayMode.Background)

    End Sub

    '' Desiging Buttons Clicks

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            PictureBox1.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = MouseButtons.Left Then
            PictureBox1.BorderStyle = BorderStyle.None
            TextBox1.Text = StrConv(TextBox1.Text, vbProperCase)

            result = searchengine(TextBox1.Text)

            If result(0) = "" Then
                MsgBox(e2)

                TextBox1.Clear()
            Else
                Label3.Text = result(0)
                Label3.Location = New Point((ClientSize.Width - Label3.ClientSize.Width) / 2,
                                                 Label2.Location.Y + Label3.ClientSize.Height + 15)
                Label5.Text = result(1)
                Label5.Width = TableLayoutPanel3.ClientSize.Width - 20
                Label5.Height = TableLayoutPanel3.ClientSize.Height -
                    (Label4.ClientSize.Height + Label3.ClientSize.Height + Label2.ClientSize.Height)
                Label5.Location = New Point(10, Label4.Location.Y + Label4.ClientSize.Height + 10)

            End If

            result.Clear()
            araylist.Clear()
        End If
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Left Then
            PictureBox2.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        If e.Button = MouseButtons.Left Then
            PictureBox2.BorderStyle = BorderStyle.None

            If voiceloc = "" Then

                playSound("ding")
                MsgBox(e1)
            Else
                playSound(voiceloc)

            End If

        End If
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        If e.Button = MouseButtons.Left Then
            PictureBox3.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        If e.Button = MouseButtons.Left Then
            PictureBox3.BorderStyle = BorderStyle.None
            TextBox1.Clear()
            Label3.Text = ""
            Label5.Text = ""
            araylist.Clear()
            voiceloc = ""

        End If
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        If e.Button = MouseButtons.Left Then
            PictureBox4.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    Private Sub PictureBox4_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseUp
        If e.Button = MouseButtons.Left Then
            PictureBox4.BorderStyle = BorderStyle.None
            Me.Close()
            HomePage.Show()
        End If
    End Sub

End Class