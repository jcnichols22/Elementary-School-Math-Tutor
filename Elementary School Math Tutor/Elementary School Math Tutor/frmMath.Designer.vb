<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMath
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddition = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMultiplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.radEarly = New System.Windows.Forms.RadioButton()
        Me.radUpper = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstMath = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OperationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "Exit"
        '
        'OperationToolStripMenuItem
        '
        Me.OperationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddition, Me.mnuMultiplication})
        Me.OperationToolStripMenuItem.Name = "OperationToolStripMenuItem"
        Me.OperationToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.OperationToolStripMenuItem.Text = "Operation"
        '
        'mnuAddition
        '
        Me.mnuAddition.Name = "mnuAddition"
        Me.mnuAddition.Size = New System.Drawing.Size(180, 22)
        Me.mnuAddition.Text = "Addition"
        '
        'mnuMultiplication
        '
        Me.mnuMultiplication.Name = "mnuMultiplication"
        Me.mnuMultiplication.Size = New System.Drawing.Size(180, 22)
        Me.mnuMultiplication.Text = "Multiplication"
        '
        'radEarly
        '
        Me.radEarly.AutoSize = True
        Me.radEarly.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEarly.Location = New System.Drawing.Point(30, 100)
        Me.radEarly.Name = "radEarly"
        Me.radEarly.Size = New System.Drawing.Size(186, 28)
        Me.radEarly.TabIndex = 1
        Me.radEarly.TabStop = True
        Me.radEarly.Text = "Early Elementary"
        Me.radEarly.UseVisualStyleBackColor = True
        '
        'radUpper
        '
        Me.radUpper.AutoSize = True
        Me.radUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUpper.Location = New System.Drawing.Point(246, 100)
        Me.radUpper.Name = "radUpper"
        Me.radUpper.Size = New System.Drawing.Size(196, 28)
        Me.radUpper.TabIndex = 2
        Me.radUpper.TabStop = True
        Me.radUpper.Text = "Upper Elementary"
        Me.radUpper.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(137, 159)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(175, 62)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstMath
        '
        Me.lstMath.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMath.FormattingEnabled = True
        Me.lstMath.ItemHeight = 24
        Me.lstMath.Location = New System.Drawing.Point(494, 100)
        Me.lstMath.Name = "lstMath"
        Me.lstMath.Size = New System.Drawing.Size(275, 292)
        Me.lstMath.TabIndex = 4
        '
        'frmMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 450)
        Me.Controls.Add(Me.lstMath)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.radUpper)
        Me.Controls.Add(Me.radEarly)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMath"
        Me.Text = "Elementary School Math Tutor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents radEarly As RadioButton
    Friend WithEvents radUpper As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lstMath As ListBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents OperationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAddition As ToolStripMenuItem
    Friend WithEvents mnuMultiplication As ToolStripMenuItem
End Class
