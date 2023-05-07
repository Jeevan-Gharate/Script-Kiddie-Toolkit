<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class portscanner
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(portscanner))
        Button1 = New Button()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(74, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(76, 78)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        RichTextBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBox1.ForeColor = Color.Silver
        RichTextBox1.Location = New Point(254, 88)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(303, 269)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label1.Location = New Point(356, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 28)
        Label1.TabIndex = 2
        Label1.Text = "Result"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(83, 144)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Ports Amount"
        TextBox1.Size = New Size(102, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label3.Location = New Point(12, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 29)
        Label3.TabIndex = 5
        Label3.Text = "Verbose:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        CheckBox1.Location = New Point(83, 272)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(145, 27)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Service (Beta)"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(83, 177)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Start Port"
        TextBox2.Size = New Size(102, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(83, 210)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "End Port"
        TextBox3.Size = New Size(102, 27)
        TextBox3.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label2.Location = New Point(12, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 29)
        Label2.TabIndex = 3
        Label2.Text = "Ports:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label4.Location = New Point(12, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 29)
        Label4.TabIndex = 10
        Label4.Text = "IP/Domain:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(74, 84)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "IP or Domain Name"
        TextBox4.Size = New Size(154, 27)
        TextBox4.TabIndex = 11
        ' 
        ' portscanner
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        ClientSize = New Size(569, 382)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(Button1)
        ForeColor = SystemColors.ActiveBorder
        FormBorderStyle = FormBorderStyle.None
        Name = "portscanner"
        Text = "portscanner"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
