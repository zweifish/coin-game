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
        Me.components = New System.ComponentModel.Container()
        Me.coin1 = New System.Windows.Forms.PictureBox()
        Me.coin2 = New System.Windows.Forms.PictureBox()
        Me.coin5 = New System.Windows.Forms.PictureBox()
        Me.coin4 = New System.Windows.Forms.PictureBox()
        Me.coin3 = New System.Windows.Forms.PictureBox()
        Me.coin6 = New System.Windows.Forms.PictureBox()
        Me.enterBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resultLbl = New System.Windows.Forms.Label()
        Me.startBtn = New System.Windows.Forms.Button()
        Me.testlbl = New System.Windows.Forms.Label()
        Me.inputTxt = New System.Windows.Forms.NumericUpDown()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timelbl = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        CType(Me.coin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'coin1
        '
        Me.coin1.Image = Global.WindowsApp6.My.Resources.Resources.quarter
        Me.coin1.Location = New System.Drawing.Point(107, 222)
        Me.coin1.Name = "coin1"
        Me.coin1.Size = New System.Drawing.Size(95, 93)
        Me.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.coin1.TabIndex = 10
        Me.coin1.TabStop = False
        '
        'coin2
        '
        Me.coin2.Image = Global.WindowsApp6.My.Resources.Resources.quarter
        Me.coin2.Location = New System.Drawing.Point(157, 123)
        Me.coin2.Name = "coin2"
        Me.coin2.Size = New System.Drawing.Size(95, 93)
        Me.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.coin2.TabIndex = 9
        Me.coin2.TabStop = False
        '
        'coin5
        '
        Me.coin5.Image = Global.WindowsApp6.My.Resources.Resources.quarter
        Me.coin5.Location = New System.Drawing.Point(107, 24)
        Me.coin5.Name = "coin5"
        Me.coin5.Size = New System.Drawing.Size(95, 93)
        Me.coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.coin5.TabIndex = 8
        Me.coin5.TabStop = False
        '
        'coin4
        '
        Me.coin4.Image = Global.WindowsApp6.My.Resources.Resources.quarter
        Me.coin4.Location = New System.Drawing.Point(208, 24)
        Me.coin4.Name = "coin4"
        Me.coin4.Size = New System.Drawing.Size(95, 93)
        Me.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.coin4.TabIndex = 7
        Me.coin4.TabStop = False
        '
        'coin3
        '
        Me.coin3.Image = Global.WindowsApp6.My.Resources.Resources.quarter
        Me.coin3.Location = New System.Drawing.Point(56, 123)
        Me.coin3.Name = "coin3"
        Me.coin3.Size = New System.Drawing.Size(95, 93)
        Me.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.coin3.TabIndex = 6
        Me.coin3.TabStop = False
        '
        'coin6
        '
        Me.coin6.Image = Global.WindowsApp6.My.Resources.Resources.quarter
        Me.coin6.Location = New System.Drawing.Point(6, 24)
        Me.coin6.Name = "coin6"
        Me.coin6.Size = New System.Drawing.Size(95, 93)
        Me.coin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.coin6.TabIndex = 5
        Me.coin6.TabStop = False
        '
        'enterBtn
        '
        Me.enterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterBtn.Location = New System.Drawing.Point(401, 254)
        Me.enterBtn.Name = "enterBtn"
        Me.enterBtn.Size = New System.Drawing.Size(120, 39)
        Me.enterBtn.TabIndex = 12
        Me.enterBtn.Text = "Enter"
        Me.enterBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 45)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Coin Counting"
        '
        'resultLbl
        '
        Me.resultLbl.AutoSize = True
        Me.resultLbl.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultLbl.Location = New System.Drawing.Point(379, 129)
        Me.resultLbl.Name = "resultLbl"
        Me.resultLbl.Size = New System.Drawing.Size(173, 46)
        Me.resultLbl.TabIndex = 14
        Me.resultLbl.Text = "Enter the coin amount " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and press enter."
        Me.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'startBtn
        '
        Me.startBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startBtn.Location = New System.Drawing.Point(6, 323)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(153, 39)
        Me.startBtn.TabIndex = 15
        Me.startBtn.Text = "New Game"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'testlbl
        '
        Me.testlbl.AutoSize = True
        Me.testlbl.Location = New System.Drawing.Point(12, 271)
        Me.testlbl.Name = "testlbl"
        Me.testlbl.Size = New System.Drawing.Size(0, 13)
        Me.testlbl.TabIndex = 16
        '
        'inputTxt
        '
        Me.inputTxt.DecimalPlaces = 2
        Me.inputTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTxt.Location = New System.Drawing.Point(401, 199)
        Me.inputTxt.Name = "inputTxt"
        Me.inputTxt.Size = New System.Drawing.Size(120, 38)
        Me.inputTxt.TabIndex = 11
        '
        'saveBtn
        '
        Me.saveBtn.Enabled = False
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(563, 25)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(71, 28)
        Me.saveBtn.TabIndex = 17
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'timelbl
        '
        Me.timelbl.AutoSize = True
        Me.timelbl.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timelbl.Location = New System.Drawing.Point(412, 322)
        Me.timelbl.Name = "timelbl"
        Me.timelbl.Size = New System.Drawing.Size(89, 37)
        Me.timelbl.TabIndex = 18
        Me.timelbl.Text = "Time"
        Me.timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(563, 323)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(71, 28)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.enterBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 374)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.timelbl)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.testlbl)
        Me.Controls.Add(Me.startBtn)
        Me.Controls.Add(Me.resultLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.enterBtn)
        Me.Controls.Add(Me.inputTxt)
        Me.Controls.Add(Me.coin1)
        Me.Controls.Add(Me.coin2)
        Me.Controls.Add(Me.coin5)
        Me.Controls.Add(Me.coin4)
        Me.Controls.Add(Me.coin3)
        Me.Controls.Add(Me.coin6)
        Me.Name = "Form1"
        Me.Text = "Coin Counting"
        CType(Me.coin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents coin6 As PictureBox
    Friend WithEvents coin3 As PictureBox
    Friend WithEvents coin4 As PictureBox
    Friend WithEvents coin5 As PictureBox
    Friend WithEvents coin2 As PictureBox
    Friend WithEvents coin1 As PictureBox
    Friend WithEvents enterBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents resultLbl As Label
    Friend WithEvents startBtn As Button
    Friend WithEvents testlbl As Label
    Friend WithEvents inputTxt As NumericUpDown
    Friend WithEvents saveBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timelbl As Label
    Friend WithEvents cmdExit As Button
End Class
