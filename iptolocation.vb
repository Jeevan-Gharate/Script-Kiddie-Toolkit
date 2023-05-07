Imports System.IO
Imports System.Net
Imports System.Xml

Public Class iptolocation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim apiUrl As String = "https://api.ip2location.io/?key=584E37D413099B28743424EA995C1C8F&ip=" + TextBox1.Text + "&format=xml"
        'Dim apiUrl As String = aui
        'a-https://api.ip2location.io/?key=584E37D413099B28743424EA995C1C8F&domain=example.com
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(apiUrl), HttpWebRequest)
        request.Method = "GET"

        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream()
        'Dim reader As New StreamReader(responseStream)
        'Dim responseJson As String = reader.ReadToEnd()
        'RichTextBox1.AppendText(responseJson)
        ' Parse the XML response using XmlDocument
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(responseStream)

        ' Get the root element of the XML document
        Dim root As XmlElement = xmlDoc.DocumentElement

        Dim rootNode As XmlNode = xmlDoc.SelectSingleNode("/result")
        For Each childNode As XmlNode In rootNode.ChildNodes
            RichTextBox1.AppendText(childNode.Name & " : " & childNode.InnerText + vbNewLine)
        Next
    End Sub
End Class