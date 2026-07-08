Imports System.Data.OleDb

Public Class Book

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & "wow_database.mdb;Jet OLEDB:Database Password=rainBOW1402!;")

    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Resources.app_icon

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Height = 600
        Me.Width = 800
        Me.CenterToScreen()

        Me.BackColor = Color.FromArgb(29, 53, 87)

        PictureBox1.Location = New Point((ClientSize.Width - PictureBox1.ClientSize.Width) / 2, 0)

        Dim da As New OleDbDataAdapter("Select id,word,mean,expl from table1", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        DataGridView1.DataSource = dt

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AllowDrop = False
        DataGridView1.AllowUserToOrderColumns = False
        DataGridView1.AllowUserToOrderColumns = False
        DataGridView1.Columns("id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("word").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("mean").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("expl").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGridView1.ScrollBars = ScrollBars.Both

        DataGridView1.Width = ClientSize.Width
        DataGridView1.Height = ClientSize.Height - PictureBox1.ClientSize.Height

        DataGridView1.Location = New Point(0, PictureBox1.ClientSize.Height)

        DataGridView1.BackgroundColor = Color.FromArgb(69, 123, 157)

        Dim thememodel As String = My.Settings.theme
        Select Case thememodel
            Case "boy"

                Me.BackColor = Color.FromArgb(29, 53, 87)
                DataGridView1.BackgroundColor = Color.FromArgb(69, 123, 157)

            Case "girl"

                Me.BackColor = Color.FromArgb(255, 175, 204)
                DataGridView1.BackgroundColor = Color.FromArgb(255, 200, 221)

        End Select

        Me.KeyPreview = True

    End Sub

    Private Sub Book_KeyPress(sender As System.Object, e As System.EventArgs) Handles Me.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e

        If tmp.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
            HomePage.Show()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        HomePage.Show()
    End Sub

End Class