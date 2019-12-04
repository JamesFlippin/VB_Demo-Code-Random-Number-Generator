<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lbxNumbers = New System.Windows.Forms.ListBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.lblLow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbxNumbers
        '
        Me.lbxNumbers.FormattingEnabled = True
        Me.lbxNumbers.ItemHeight = 16
        Me.lbxNumbers.Location = New System.Drawing.Point(72, 43)
        Me.lbxNumbers.Name = "lbxNumbers"
        Me.lbxNumbers.Size = New System.Drawing.Size(232, 196)
        Me.lbxNumbers.TabIndex = 0
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(128, 319)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'lblHigh
        '
        Me.lblHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHigh.Location = New System.Drawing.Point(38, 275)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(100, 23)
        Me.lblHigh.TabIndex = 2
        Me.lblHigh.Text = " "
        '
        'lblLow
        '
        Me.lblLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLow.Location = New System.Drawing.Point(204, 275)
        Me.lblLow.Name = "lblLow"
        Me.lblLow.Size = New System.Drawing.Size(100, 23)
        Me.lblLow.TabIndex = 3
        Me.lblLow.Text = " "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 373)
        Me.Controls.Add(Me.lblLow)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.lbxNumbers)
        Me.Name = "frmMain"
        Me.Text = "Random Number Generator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbxNumbers As ListBox
    Friend WithEvents btnRun As Button
    Friend WithEvents lblHigh As Label
    Friend WithEvents lblLow As Label
End Class
