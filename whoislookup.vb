Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Web.Script.Serialization
Imports System.Runtime.CompilerServices

'ja.kse.n.dan.m.ark@gmail.com:ja.kse.n.dan.m.ark@A1
Public Class whoislookup
    Private Sub whoislookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Create a web request to the API endpoint
        Dim apiUrl As String = "https://api.ip2whois.com/?key=584E37D413099B28743424EA995C1C8F&domain=" + TextBox1.Text + "&format=xml"
        'Dim apiUrl As String = aui
        'a-https://api.ip2location.io/?key=584E37D413099B28743424EA995C1C8F&domain=example.com
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(apiUrl), HttpWebRequest)
        request.Method = "GET"

        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream()

        ' Parse the XML response using XmlDocument
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(responseStream)

        ' Get the root element of the XML document
        Dim root As XmlElement = xmlDoc.DocumentElement

        Dim rootNode As XmlNode = xmlDoc.SelectSingleNode("/response")
        For Each childNode As XmlNode In rootNode.ChildNodes
            RichTextBox1.AppendText(childNode.Name & " : " & childNode.InnerText + vbNewLine)
        Next

    End Sub
End Class