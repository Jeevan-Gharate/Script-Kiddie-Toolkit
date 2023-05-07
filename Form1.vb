Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Form1
    Dim un As String
    Private mouseDownn As Boolean
    Private lastLocation As Point
    Private GRANTED_USER As String = "zyro"
    Private GRANTED_PASSWORD As String = "123"

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouseDownn = True
        lastLocation = e.Location
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If mouseDownn Then
            Me.Location = New Point(
        (Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)

            Me.Update()
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mouseDownn = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        un = uname.Text
        Dim pwd As String = passwd.Text

        Dim isUser As Integer = String.Compare(un, GRANTED_USER)
        Dim isPasswd As Integer = String.Compare(pwd, GRANTED_PASSWORD)

        If (isUser = 0 And isPasswd = 0) Then
            Dim frm2 As New Form2
            frm2.session_username = un
            'frm2.Parent = Me
            frm2.Show()
            Me.Hide()
            'Me.Panel1.Controls.Clear()
            'Dim main1 As New Form2
            'main1.TopLevel = False
            'main1.FormBorderStyle = FormBorderStyle.None
            'main1.Dock = DockStyle.Fill
            'main1.Width = Panel1.Width
            'main1.Height = Panel1.Height
            'Panel1.Controls.Add(main1)
            'main1.Show()
        Else
            MessageBox.Show("Access Denied!")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
