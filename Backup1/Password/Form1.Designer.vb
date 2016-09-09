<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGen = New System.Windows.Forms.Button
        Me.txtGen = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.rd7 = New System.Windows.Forms.RadioButton
        Me.rd12 = New System.Windows.Forms.RadioButton
        Me.rd24 = New System.Windows.Forms.RadioButton
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.rdCust = New System.Windows.Forms.RadioButton
        Me.mskCust = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGen
        '
        Me.btnGen.Location = New System.Drawing.Point(12, 200)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(106, 23)
        Me.btnGen.TabIndex = 0
        Me.btnGen.Text = "&Generate"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'txtGen
        '
        Me.txtGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGen.Location = New System.Drawing.Point(12, 174)
        Me.txtGen.Name = "txtGen"
        Me.txtGen.ReadOnly = True
        Me.txtGen.Size = New System.Drawing.Size(316, 20)
        Me.txtGen.TabIndex = 1
        Me.txtGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Please choose how many characters you want for your password!"
        '
        'rd7
        '
        Me.rd7.AutoSize = True
        Me.rd7.Location = New System.Drawing.Point(12, 77)
        Me.rd7.Name = "rd7"
        Me.rd7.Size = New System.Drawing.Size(31, 17)
        Me.rd7.TabIndex = 6
        Me.rd7.TabStop = True
        Me.rd7.Text = "7"
        Me.rd7.UseVisualStyleBackColor = True
        '
        'rd12
        '
        Me.rd12.AutoSize = True
        Me.rd12.Location = New System.Drawing.Point(12, 100)
        Me.rd12.Name = "rd12"
        Me.rd12.Size = New System.Drawing.Size(37, 17)
        Me.rd12.TabIndex = 7
        Me.rd12.TabStop = True
        Me.rd12.Text = "12"
        Me.rd12.UseVisualStyleBackColor = True
        '
        'rd24
        '
        Me.rd24.AutoSize = True
        Me.rd24.Location = New System.Drawing.Point(12, 123)
        Me.rd24.Name = "rd24"
        Me.rd24.Size = New System.Drawing.Size(37, 17)
        Me.rd24.TabIndex = 8
        Me.rd24.TabStop = True
        Me.rd24.Text = "24"
        Me.rd24.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(124, 200)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(231, 200)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'rdCust
        '
        Me.rdCust.AutoSize = True
        Me.rdCust.Location = New System.Drawing.Point(12, 146)
        Me.rdCust.Name = "rdCust"
        Me.rdCust.Size = New System.Drawing.Size(60, 17)
        Me.rdCust.TabIndex = 11
        Me.rdCust.TabStop = True
        Me.rdCust.Text = "Custom"
        Me.rdCust.UseVisualStyleBackColor = True
        '
        'mskCust
        '
        Me.mskCust.Location = New System.Drawing.Point(78, 143)
        Me.mskCust.Name = "mskCust"
        Me.mskCust.Size = New System.Drawing.Size(40, 20)
        Me.mskCust.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(55, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "*Recommended*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Password Generator"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(334, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearFormToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ClearFormToolStripMenuItem
        '
        Me.ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem"
        Me.ClearFormToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ClearFormToolStripMenuItem.Text = "&Clear Form"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CloseToolStripMenuItem.Text = "&Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(247, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Save Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(247, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Copy Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 248)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskCust)
        Me.Controls.Add(Me.rdCust)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.rd24)
        Me.Controls.Add(Me.rd12)
        Me.Controls.Add(Me.rd7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGen)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Offline Password Generator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGen As System.Windows.Forms.Button
    Friend WithEvents txtGen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rd7 As System.Windows.Forms.RadioButton
    Friend WithEvents rd12 As System.Windows.Forms.RadioButton
    Friend WithEvents rd24 As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents rdCust As System.Windows.Forms.RadioButton
    Friend WithEvents mskCust As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClearFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
