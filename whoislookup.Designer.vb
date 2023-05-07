<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class whoislookup
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(whoislookup))
        TextBox1 = New TextBox()
        Button1 = New Button()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 153)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(222, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(77, 186)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 52)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        RichTextBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBox1.ForeColor = Color.Silver
        RichTextBox1.Location = New Point(254, 89)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(303, 269)
        RichTextBox1.TabIndex = 8
        RichTextBox1.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label1.Location = New Point(68, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 29)
        Label1.TabIndex = 14
        Label1.Text = "Domain:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label3.Location = New Point(345, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 28)
        Label3.TabIndex = 16
        Label3.Text = "Result"
        ' 
        ' whoislookup
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
        Name = "whoislookup"
        Text = "whoislookup"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
