Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices


Module Module1

    Public main_ps As portscanner
    Public dom As String

    Sub Main(ByVal ps_main As portscanner, ByVal pts As Integer, ByVal sp As Integer, ByVal ep As Integer)
        main_ps = ps_main
        dom = ps_main.TextBox4.Text

        Dim numPorts As Integer = pts

        Dim startPort As Integer = sp

        Dim endPort As Integer = ep

        Dim threads(numPorts - 1) As Thread
        Dim portNumbers(numPorts - 1) As Integer

        For i As Integer = 0 To numPorts - 1
            portNumbers(i) = startPort + i
            threads(i) = New Thread(AddressOf ScanPort)

            threads(i).Start(portNumbers(i))
        Next

        For Each t As Thread In threads
            t.Join()
        Next
    End Sub
    'Dim ps_mainn As portscanner
    Public Async Sub ScanPort(ByVal port As Object)

        Dim portNumber As Integer = CInt(port)
        Dim client As New TcpClient
        Try
            Await client.ConnectAsync(dom, portNumber)



            main_ps.RichTextBox1.Invoke(Sub()
                                            main_ps.RichTextBox1.AppendText(portNumber & vbTab & "open" & Environment.NewLine)
                                        End Sub)
            'Console.WriteLine("Port {0} is open", portNumber)
            'main_ps.RichTextBox1.Text &= portNumber & Environment.NewLine
            '''main_ps.RichTextBox1.AppendText(portNumber)
            'main_ps.Label4.Text = portNumber

            'MessageBox.Show(main_ps.Label3.Text)
        Catch ex As SocketException
            'If ex.GetType() Is GetType(SocketException) Then
            'Dim sockEx As SocketException = CType(ex, SocketException)
            'If sockEx.ErrorCode = 10060 Then
            'main_ps.RichTextBox1.Invoke(Sub()
            'main_ps.RichTextBox1.AppendText(portNumber & vbTab & "filtered" & Environment.NewLine)
            'End Sub)
            '       ElseIf sockEx.ErrorCode = 10061 Then
            '      'Console.WriteLine("Port 80 is closed")
            '     End If
            '    End If
        End Try
    End Sub


End Module

Public Class portscanner
    Private Sub portscanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As String = TextBox1.Text
        Dim intValue As Integer
        Dim start_port As Integer
        Dim end_port As Integer



        If Integer.TryParse(userInput, intValue) Then
            Dim ptss As Integer = Integer.Parse(userInput)
            If Integer.TryParse(TextBox2.Text, start_port) And Integer.TryParse(TextBox3.Text, end_port) Then
                'Me.Refresh()
                'MessageBox.Show("ok good: " & portsToScan)
                RichTextBox1.Text = ""
                Module1.Main(Me, ptss, sp:=start_port, ep:=end_port)
                Me.Refresh()
            Else
                'Me.Refresh()
                MessageBox.Show("invalid starting or Ending port, Using Default: Start=1 && End=PortsAmount.")
                Module1.Main(Me, ptss, sp:=1, ep:=intValue)
                Me.Refresh()
            End If
        Else
            ' The input is not a valid integer
            MessageBox.Show("Please enter a valid port Limit Number.")
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class