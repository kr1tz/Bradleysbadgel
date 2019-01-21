<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintBagelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveBagelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBagelTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBagelTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearBagelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BagelLabel = New System.Windows.Forms.Label()
        Me.BagelComboBox = New System.Windows.Forms.ComboBox()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(288, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBagelListToolStripMenuItem, Me.SaveBagelListToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintBagelListToolStripMenuItem
        '
        Me.PrintBagelListToolStripMenuItem.Name = "PrintBagelListToolStripMenuItem"
        Me.PrintBagelListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintBagelListToolStripMenuItem.Text = "Print Bagel List"
        '
        'SaveBagelListToolStripMenuItem
        '
        Me.SaveBagelListToolStripMenuItem.Name = "SaveBagelListToolStripMenuItem"
        Me.SaveBagelListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveBagelListToolStripMenuItem.Text = "Save Bagel List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBagelTypeToolStripMenuItem, Me.RemoveBagelTypeToolStripMenuItem, Me.ClearBagelListToolStripMenuItem, Me.ToolStripSeparator2, Me.DisplayToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddBagelTypeToolStripMenuItem
        '
        Me.AddBagelTypeToolStripMenuItem.Name = "AddBagelTypeToolStripMenuItem"
        Me.AddBagelTypeToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+A"
        Me.AddBagelTypeToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AddBagelTypeToolStripMenuItem.Text = "Add Bagel Type"
        '
        'RemoveBagelTypeToolStripMenuItem
        '
        Me.RemoveBagelTypeToolStripMenuItem.Name = "RemoveBagelTypeToolStripMenuItem"
        Me.RemoveBagelTypeToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+R"
        Me.RemoveBagelTypeToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.RemoveBagelTypeToolStripMenuItem.Text = "Remove Bagel Type"
        '
        'ClearBagelListToolStripMenuItem
        '
        Me.ClearBagelListToolStripMenuItem.Name = "ClearBagelListToolStripMenuItem"
        Me.ClearBagelListToolStripMenuItem.ShortcutKeyDisplayString = "F3"
        Me.ClearBagelListToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ClearBagelListToolStripMenuItem.Text = "Clear Bagel List"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(224, 6)
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.DisplayToolStripMenuItem.Text = "Display Bagel Type Count"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'BagelLabel
        '
        Me.BagelLabel.AutoSize = True
        Me.BagelLabel.Location = New System.Drawing.Point(87, 56)
        Me.BagelLabel.Name = "BagelLabel"
        Me.BagelLabel.Size = New System.Drawing.Size(73, 13)
        Me.BagelLabel.TabIndex = 2
        Me.BagelLabel.Text = "Type of &Bagel"
        '
        'BagelComboBox
        '
        Me.BagelComboBox.FormattingEnabled = True
        Me.BagelComboBox.Location = New System.Drawing.Point(90, 72)
        Me.BagelComboBox.Name = "BagelComboBox"
        Me.BagelComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BagelComboBox.TabIndex = 3
        '
        'PrintDocument
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 164)
        Me.Controls.Add(Me.BagelComboBox)
        Me.Controls.Add(Me.BagelLabel)
        Me.Controls.Add(Me.MenuStrip)
        Me.Name = "MainForm"
        Me.Text = "Bradley's Bagel"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintBagelListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveBagelListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBagelTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveBagelTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearBagelListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BagelLabel As System.Windows.Forms.Label
    Friend WithEvents BagelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog

End Class
