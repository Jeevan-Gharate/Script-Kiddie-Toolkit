<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class macchanger
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(macchanger))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        CheckBox2 = New CheckBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(54, 322)
        Label1.Name = "Label1"
        Label1.Size = New Size(416, 40)
        Label1.TabIndex = 2
        Label1.Text = "P.S: Once you close this Window using the top right button, " & vbCrLf & "                               original Mac will get restored"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label2.Location = New Point(124, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 23)
        Label2.TabIndex = 4
        Label2.Text = "Select Adapter"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(268, 148)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter Mac- 00:11:22:33:44:55"
        TextBox1.Size = New Size(202, 27)
        TextBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(250, 266)
        Button1.Name = "Button1"
        Button1.Size = New Size(67, 35)
        Button1.TabIndex = 6
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox2.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        CheckBox2.Location = New Point(198, 210)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(175, 27)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "Random Mac Addr"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Label3.Location = New Point(135, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 23)
        Label3.TabIndex = 9
        Label3.Text = "Mac Address"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(295, 69)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' macchanger
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        ClientSize = New Size(569, 382)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(CheckBox2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "macchanger"
        Text = "macchanger"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
