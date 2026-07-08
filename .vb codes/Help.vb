Imports System.Drawing.Text

Public Class Help
    Dim p1, p2, p3, p4 As String

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Resources.app_icon

        '''' changing program screen size ''''

        Me.Height = 600
        Me.Width = 800
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.FromArgb(29, 53, 87)

        '' Designing Texts
        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "SLOTUS_0.ttf")

        TextBox1.RightToLeft = Windows.Forms.RightToLeft.Inherit

        TextBox1.Multiline = True
        TextBox1.ReadOnly = True
        TextBox1.BackColor = Color.FromArgb(168, 218, 220)

        TextBox1.SelectionStart = 0
        TextBox1.ShortcutsEnabled = False
        TextBox1.Font = New Font(pfc.Families(0), 14)
        TextBox1.Width = ClientSize.Width - 3
        TextBox1.AutoScrollOffset() = New Point(0, 0)
        TextBox1.Height = ClientSize.Height / 1.3

        TextBox1.Location = New Point((ClientSize.Width - TextBox1.ClientSize.Width) / 2 - 8,
                                      ClientSize.Height - TextBox1.ClientSize.Height - 20)

        '' changing language

        Dim lng As String = My.Settings.language

        Select Case lng
            Case "eng"
                TextBox1.TextAlign = HorizontalAlignment.Left
                TextBox1.Text = My.Resources.Resources.Help_Eng
                p1 = "Home Button"
                p2 = "World OF Words"
                p3 = "Think Persian, Learn English"
                p4 = "Copyright © 2022 - 2026 WorldOfWords®. All rights reserved."

            Case "per"
                TextBox1.TextAlign = HorizontalAlignment.Right
                TextBox1.Text = My.Resources.Resources.Help_Per
                p1 = "بازگشت به خانه"
                p2 = "World OF Words"
                p3 = "Think Persian, Learn English"
                p4 = "Copyright © 2022 - 2026 WorldOfWords®. All rights reserved."

            Case "fra"
                TextBox1.TextAlign = HorizontalAlignment.Left
                TextBox1.Text = My.Resources.Resources.Help_Fr
                p1 = "Bouton d'accueil"
                p2 = "World OF Words"
                p3 = "Think Persian, Learn English"
                p4 = "Copyright © 2022 - 2026 WorldOfWords®. All rights reserved."

        End Select

        Label1.Font = New Font(pfc.Families(0), 30)
        Label2.Font = New Font(pfc.Families(0), 12)
        Label3.Font = New Font(pfc.Families(0), 7)

        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White

        Label1.Text = p2
        Label2.Text = p3
        Label3.Text = p4

        ToolTip1.SetToolTip(Me.Label1, p1)

        Label1.Location = New Point((ClientSize.Width - Label1.ClientSize.Width) / 2,
                                         20)
        Label2.Location = New Point((ClientSize.Width - Label2.ClientSize.Width) / 2,
                                        Label1.ClientSize.Height + 20)
        Label3.Location = New Point((ClientSize.Width - Label3.ClientSize.Width) / 2,
                                       TextBox1.Location.Y + TextBox1.ClientSize.Height +
                                       Label3.ClientSize.Height / 2)

        '' Changing Theme

        Dim thememodel As String = My.Settings.theme

        Select Case thememodel
            Case "boy"

                Me.BackColor = Color.FromArgb(29, 53, 87)

            Case "girl"

                Me.BackColor = Color.FromArgb(255, 175, 204)

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        HomePage.Show()
    End Sub

End Class