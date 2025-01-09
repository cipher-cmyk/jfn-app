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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblAttempts = New System.Windows.Forms.Label()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(9, 20)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(356, 21)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = "Guess a number between 1 and 100:"
        '
        'lblAttempts
        '
        Me.lblAttempts.AutoSize = True
        Me.lblAttempts.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttempts.Location = New System.Drawing.Point(370, 102)
        Me.lblAttempts.Name = "lblAttempts"
        Me.lblAttempts.Size = New System.Drawing.Size(170, 21)
        Me.lblAttempts.TabIndex = 1
        Me.lblAttempts.Text = "Attempts Left: 10"
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.Location = New System.Drawing.Point(9, 226)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(103, 22)
        Me.lblFeedback.TabIndex = 2
        Me.lblFeedback.Text = "Feedback"
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(12, 49)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(464, 20)
        Me.txtGuess.TabIndex = 3
        '
        'btnGuess
        '
        Me.btnGuess.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.Location = New System.Drawing.Point(27, 111)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(87, 49)
        Me.btnGuess.TabIndex = 4
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(108, 111)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(87, 49)
        Me.btnRestart.TabIndex = 5
        Me.btnRestart.Text = "Restart Game"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 287)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblFeedback)
        Me.Controls.Add(Me.lblAttempts)
        Me.Controls.Add(Me.lblInstruction)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblAttempts As Label
    Friend WithEvents lblFeedback As Label
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents btnGuess As Button
    Friend WithEvents btnRestart As Button
End Class
