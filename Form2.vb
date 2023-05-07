Public Class Form2
    Public original_mac As String
    Private mouseDownn As Boolean
    Private lastLocation As Point
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        mouseDownn = True
        lastLocation = e.Location
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If mouseDownn Then
            Me.Location = New Point(
        (Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)

            Me.Update()
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mouseDownn = False
    End Sub
    Public Property session_username As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = session_username
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Simple IP Scanner"

        Button2.BackColor = Color.FromArgb(24, 30, 54)
        Button3.BackColor = Color.FromArgb(24, 30, 54)
        Button1.BackColor = Color.FromArgb(46, 51, 73)
        Button5.BackColor = Color.FromArgb(24, 30, 54)

        'Me.Panel3.Dock = DockStyle.Fill
        'Me.Panel3.Controls.Clear()
        Me.Panel3.Controls.Clear()
        Dim ps As New portscanner
        ps.TopLevel = False
        ps.FormBorderStyle = FormBorderStyle.None
        ps.Dock = DockStyle.Fill
        ps.Width = Panel3.Width
        ps.Height = Panel3.Height
        Panel3.Controls.Add(ps)
        ps.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label2.Text = "Mac Changer"
        Button1.BackColor = Color.FromArgb(24, 30, 54)
        Button3.BackColor = Color.FromArgb(24, 30, 54)
        Button2.BackColor = Color.FromArgb(46, 51, 73)
        Button5.BackColor = Color.FromArgb(24, 30, 54)

        Me.Panel3.Controls.Clear()
        Dim mc As New macchanger
        mc.TopLevel = False
        mc.FormBorderStyle = FormBorderStyle.None
        mc.Dock = DockStyle.Fill
        mc.Width = Panel3.Width
        mc.Height = Panel3.Height
        Panel3.Controls.Add(mc)
        mc.Show()
    End Sub

    'Private Sub Form2_FormClosing(ByVal sender As Object,
    '   ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '
    'Parent.Close()
    '
    'End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "WHOIS LookUp"
        Button1.BackColor = Color.FromArgb(24, 30, 54)
        Button2.BackColor = Color.FromArgb(24, 30, 54)
        Button3.BackColor = Color.FromArgb(46, 51, 73)
        Button5.BackColor = Color.FromArgb(24, 30, 54)

        Me.Panel3.Controls.Clear()
        Dim wl As New whoislookup
        wl.TopLevel = False
        wl.FormBorderStyle = FormBorderStyle.None
        wl.Dock = DockStyle.Fill
        wl.Width = Panel3.Width
        wl.Height = Panel3.Height
        Panel3.Controls.Add(wl)
        wl.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label2.Text = "IP2Location"
        Button1.BackColor = Color.FromArgb(24, 30, 54)
        Button2.BackColor = Color.FromArgb(24, 30, 54)
        Button3.BackColor = Color.FromArgb(24, 30, 54)
        Button5.BackColor = Color.FromArgb(46, 51, 73)

        Me.Panel3.Controls.Clear()
        Dim ipl As New iptolocation
        ipl.TopLevel = False
        ipl.FormBorderStyle = FormBorderStyle.None
        ipl.Dock = DockStyle.Fill
        ipl.Width = Panel3.Width
        ipl.Height = Panel3.Height
        Panel3.Controls.Add(ipl)
        ipl.Show()
    End Sub
End Class