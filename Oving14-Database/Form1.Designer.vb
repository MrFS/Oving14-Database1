<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConnectToDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertIntoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeDatabasenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEpost = New System.Windows.Forms.TextBox()
        Me.txtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SlettTabellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToDatabaseToolStripMenuItem, Me.CreateTableToolStripMenuItem, Me.InsertIntoToolStripMenuItem, Me.SeDatabasenToolStripMenuItem, Me.SlettTabellToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConnectToDatabaseToolStripMenuItem
        '
        Me.ConnectToDatabaseToolStripMenuItem.Name = "ConnectToDatabaseToolStripMenuItem"
        Me.ConnectToDatabaseToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.ConnectToDatabaseToolStripMenuItem.Text = "Connect to database"
        '
        'CreateTableToolStripMenuItem
        '
        Me.CreateTableToolStripMenuItem.Name = "CreateTableToolStripMenuItem"
        Me.CreateTableToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.CreateTableToolStripMenuItem.Text = "Create table"
        '
        'InsertIntoToolStripMenuItem
        '
        Me.InsertIntoToolStripMenuItem.Name = "InsertIntoToolStripMenuItem"
        Me.InsertIntoToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.InsertIntoToolStripMenuItem.Text = "Insert Into"
        '
        'SeDatabasenToolStripMenuItem
        '
        Me.SeDatabasenToolStripMenuItem.Name = "SeDatabasenToolStripMenuItem"
        Me.SeDatabasenToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.SeDatabasenToolStripMenuItem.Text = "Se databasen"
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(668, 282)
        Me.ListBox1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(682, 317)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(674, 288)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Se Databasen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.dtp1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtEpost)
        Me.TabPage2.Controls.Add(Me.txtEtternavn)
        Me.TabPage2.Controls.Add(Me.txtFornavn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 288)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registrer ny person"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 30)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Value"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Registrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(193, 158)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(218, 22)
        Me.dtp1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Burs&dag:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Epos&t:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Etter&navn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "F&ornavn:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Registrer ny person i databasen"
        '
        'txtEpost
        '
        Me.txtEpost.Location = New System.Drawing.Point(193, 128)
        Me.txtEpost.Name = "txtEpost"
        Me.txtEpost.Size = New System.Drawing.Size(218, 22)
        Me.txtEpost.TabIndex = 2
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(193, 100)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(218, 22)
        Me.txtEtternavn.TabIndex = 1
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(193, 72)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(218, 22)
        Me.txtFornavn.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(544, 288)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Søk etter person"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SlettTabellToolStripMenuItem
        '
        Me.SlettTabellToolStripMenuItem.Name = "SlettTabellToolStripMenuItem"
        Me.SlettTabellToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.SlettTabellToolStripMenuItem.Text = "Slett tabell"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 345)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConnectToDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertIntoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeDatabasenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEpost As TextBox
    Friend WithEvents txtEtternavn As TextBox
    Friend WithEvents txtFornavn As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SlettTabellToolStripMenuItem As ToolStripMenuItem
End Class
