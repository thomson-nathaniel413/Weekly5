<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComic
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
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblComic = New System.Windows.Forms.Label()
        Me.lblGroupIndicator = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.grpBadgeSelect = New System.Windows.Forms.GroupBox()
        Me.lblCostIndicator = New System.Windows.Forms.Label()
        Me.lblCostOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.radExperience = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComic
        '
        Me.picComic.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picComic.Location = New System.Drawing.Point(1, 0)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(680, 212)
        Me.picComic.TabIndex = 0
        Me.picComic.TabStop = False
        '
        'lblComic
        '
        Me.lblComic.AutoSize = True
        Me.lblComic.Location = New System.Drawing.Point(216, 231)
        Me.lblComic.Name = "lblComic"
        Me.lblComic.Size = New System.Drawing.Size(227, 20)
        Me.lblComic.TabIndex = 1
        Me.lblComic.Text = "Comic Convention Registration"
        '
        'lblGroupIndicator
        '
        Me.lblGroupIndicator.AutoSize = True
        Me.lblGroupIndicator.Location = New System.Drawing.Point(216, 288)
        Me.lblGroupIndicator.Name = "lblGroupIndicator"
        Me.lblGroupIndicator.Size = New System.Drawing.Size(90, 20)
        Me.lblGroupIndicator.TabIndex = 2
        Me.lblGroupIndicator.Text = "Group size:"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Location = New System.Drawing.Point(343, 288)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(100, 26)
        Me.txtGroupSize.TabIndex = 3
        '
        'grpBadgeSelect
        '
        Me.grpBadgeSelect.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.grpBadgeSelect.Controls.Add(Me.radConvention)
        Me.grpBadgeSelect.Controls.Add(Me.radAutographs)
        Me.grpBadgeSelect.Controls.Add(Me.radExperience)
        Me.grpBadgeSelect.Location = New System.Drawing.Point(126, 331)
        Me.grpBadgeSelect.Name = "grpBadgeSelect"
        Me.grpBadgeSelect.Size = New System.Drawing.Size(431, 143)
        Me.grpBadgeSelect.TabIndex = 4
        Me.grpBadgeSelect.TabStop = False
        Me.grpBadgeSelect.Text = "Select Badge Type:"
        '
        'lblCostIndicator
        '
        Me.lblCostIndicator.AutoSize = True
        Me.lblCostIndicator.Location = New System.Drawing.Point(206, 549)
        Me.lblCostIndicator.Name = "lblCostIndicator"
        Me.lblCostIndicator.Size = New System.Drawing.Size(133, 20)
        Me.lblCostIndicator.TabIndex = 5
        Me.lblCostIndicator.Text = "Registration cost:"
        '
        'lblCostOutput
        '
        Me.lblCostOutput.AutoSize = True
        Me.lblCostOutput.Location = New System.Drawing.Point(387, 549)
        Me.lblCostOutput.Name = "lblCostOutput"
        Me.lblCostOutput.Size = New System.Drawing.Size(76, 20)
        Me.lblCostOutput.TabIndex = 6
        Me.lblCostOutput.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(126, 656)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(129, 52)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(428, 656)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 52)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(190, 600)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(292, 20)
        Me.lblError.TabIndex = 9
        Me.lblError.Text = "Input was invalid; please enter a number"
        '
        'radExperience
        '
        Me.radExperience.AutoSize = True
        Me.radExperience.Location = New System.Drawing.Point(20, 26)
        Me.radExperience.Name = "radExperience"
        Me.radExperience.Size = New System.Drawing.Size(289, 24)
        Me.radExperience.TabIndex = 0
        Me.radExperience.TabStop = True
        Me.radExperience.Text = "Convention + Superhero Experience"
        Me.radExperience.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Location = New System.Drawing.Point(20, 57)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(214, 24)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(20, 88)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(114, 24)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'frmComic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 744)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostOutput)
        Me.Controls.Add(Me.lblCostIndicator)
        Me.Controls.Add(Me.grpBadgeSelect)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupIndicator)
        Me.Controls.Add(Me.lblComic)
        Me.Controls.Add(Me.picComic)
        Me.Name = "frmComic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comic Convention Registration"
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeSelect.ResumeLayout(False)
        Me.grpBadgeSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblComic As Label
    Friend WithEvents lblGroupIndicator As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents grpBadgeSelect As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radExperience As RadioButton
    Friend WithEvents lblCostIndicator As Label
    Friend WithEvents lblCostOutput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblError As Label
End Class
