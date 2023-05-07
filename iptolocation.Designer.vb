<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iptolocation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(iptolocation))
        Label3 = New Label()
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label3.Location = New Point(345, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 28)
        Label3.TabIndex = 21
        Label3.Text = "Result"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label1.Location = New Point(99, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 29)
        Label1.TabIndex = 20
        Label1.Text = "IP:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        RichTextBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBox1.ForeColor = Color.Silver
        RichTextBox1.Location = New Point(254, 83)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(303, 269)
        RichTextBox1.TabIndex = 19
        RichTextBox1.Text = ""
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(70, 180)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 52)
        Button1.TabIndex = 18
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(28, 147)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(192, 27)
        TextBox1.TabIndex = 17
        ' 
        ' iptolocation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        ClientSize = New Size(569, 382)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "iptolocation"
        Text = "iptolocation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
