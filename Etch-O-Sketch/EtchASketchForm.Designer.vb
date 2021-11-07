<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketchForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtchASketchForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveFormButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 389)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.ToolTip.SetToolTip(Me.PictureBox1, "Draw in this space")
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorToolStripMenuItem, Me.ClearToolStripMenuItem, Me.PenColorToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(171, 70)
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'PenColorToolStripMenuItem
        '
        Me.PenColorToolStripMenuItem.Name = "PenColorToolStripMenuItem"
        Me.PenColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PenColorToolStripMenuItem.Text = "Pen Color"
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SelectColorButton.Location = New System.Drawing.Point(12, 422)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(93, 36)
        Me.SelectColorButton.TabIndex = 1
        Me.SelectColorButton.Text = "Select &Color"
        Me.ToolTip.SetToolTip(Me.SelectColorButton, "Select a color to draw with")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveFormButton
        '
        Me.DrawWaveFormButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DrawWaveFormButton.Location = New System.Drawing.Point(111, 422)
        Me.DrawWaveFormButton.Name = "DrawWaveFormButton"
        Me.DrawWaveFormButton.Size = New System.Drawing.Size(93, 36)
        Me.DrawWaveFormButton.TabIndex = 2
        Me.DrawWaveFormButton.Text = "&Draw Wave Form"
        Me.ToolTip.SetToolTip(Me.DrawWaveFormButton, "Draw a sinusoid!")
        Me.DrawWaveFormButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(210, 422)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(93, 36)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "&Clear Button"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Clear what is drawn")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ExitButton.Location = New System.Drawing.Point(309, 422)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(93, 36)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Close the Sketch")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Close the Sketch"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveFormsToolStripMenuItem, Me.ClearToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        Me.SelectColorToolStripMenuItem.ToolTipText = "Select a color to draw with"
        '
        'DrawWaveFormsToolStripMenuItem
        '
        Me.DrawWaveFormsToolStripMenuItem.Name = "DrawWaveFormsToolStripMenuItem"
        Me.DrawWaveFormsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DrawWaveFormsToolStripMenuItem.Text = "Draw WaveForms"
        Me.DrawWaveFormsToolStripMenuItem.ToolTipText = "Draw s sinusoid!"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        Me.ClearToolStripMenuItem1.ToolTipText = "Clear the drawing "
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HelpToolStripMenuItem.Text = "Help "
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.AboutToolStripMenuItem.ToolTipText = "Info"
        '
        'EtchASketchForm
        '
        Me.AcceptButton = Me.DrawWaveFormButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DrawWaveFormButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "EtchASketchForm"
        Me.Text = "Etch-A-Sketch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DrawWaveFormButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveFormsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
End Class
