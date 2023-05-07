<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Button5 = New Button()
        Label4 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel3 = New Panel()
        Button4 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(2, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(224, 444)
        Panel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(-1, 327)
        Button5.Name = "Button5"
        Button5.Size = New Size(221, 49)
        Button5.TabIndex = 5
        Button5.Text = "IP2Location"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Silver
        Label4.Location = New Point(10, 404)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 25)
        Label4.TabIndex = 4
        Label4.Text = "V1.0"
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(3, 261)
        Button3.Name = "Button3"
        Button3.Size = New Size(221, 49)
        Button3.TabIndex = 3
        Button3.Text = "WHOIS Lookup"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(3, 196)
        Button2.Name = "Button2"
        Button2.Size = New Size(221, 49)
        Button2.TabIndex = 2
        Button2.Text = "Mac Changer"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(3, 131)
        Button1.Name = "Button1"
        Button1.Size = New Size(221, 49)
        Button1.TabIndex = 1
        Button1.Text = "Port Scanner"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(221, 107)
        Panel2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.LawnGreen
        Label3.Location = New Point(97, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 18)
        Label3.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.LawnGreen
        Label1.Location = New Point(41, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 18)
        Label1.TabIndex = 1
        Label1.Text = "Hello,"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(41, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 51)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.AppWorkspace
        Label2.Location = New Point(399, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 38)
        Label2.TabIndex = 1
        Label2.Text = "Welcome"
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(228, 65)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(569, 382)
        Panel3.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.Red
        Button4.Location = New Point(752, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(45, 37)
        Button4.TabIndex = 3
        Button4.Text = "X"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Panel3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
End Class
