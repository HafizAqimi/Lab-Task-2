<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sparepartsdisplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sparepartsdisplay))
        Me.headLine = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.buySidemirror = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNBuy1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNBuy2 = New System.Windows.Forms.Button()
        Me.BTNBuy3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headLine
        '
        Me.headLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.headLine.Font = New System.Drawing.Font("Sitka Banner", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.headLine.ForeColor = System.Drawing.SystemColors.Window
        Me.headLine.Location = New System.Drawing.Point(12, 12)
        Me.headLine.Multiline = True
        Me.headLine.Name = "headLine"
        Me.headLine.Size = New System.Drawing.Size(640, 78)
        Me.headLine.TabIndex = 1
        Me.headLine.Text = "Do You Need Spare Parts?"
        Me.headLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 136)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(33, 298)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(151, 136)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(33, 466)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(151, 136)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'buySidemirror
        '
        Me.buySidemirror.Location = New System.Drawing.Point(12, 106)
        Me.buySidemirror.Name = "buySidemirror"
        Me.buySidemirror.Size = New System.Drawing.Size(640, 166)
        Me.buySidemirror.TabIndex = 5
        Me.buySidemirror.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(640, 166)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 453)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(640, 166)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Sitka Banner", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(215, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 35)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Side Mirror"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Sitka Banner", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(532, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 35)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "RM 89.00"
        '
        'BTNBuy1
        '
        Me.BTNBuy1.BackColor = System.Drawing.Color.IndianRed
        Me.BTNBuy1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNBuy1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNBuy1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNBuy1.Location = New System.Drawing.Point(504, 220)
        Me.BTNBuy1.Name = "BTNBuy1"
        Me.BTNBuy1.Size = New System.Drawing.Size(137, 37)
        Me.BTNBuy1.TabIndex = 10
        Me.BTNBuy1.Text = "Buy Now"
        Me.BTNBuy1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Sitka Banner", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(215, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 35)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Bumper"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Sitka Banner", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(524, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 35)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "RM 120.00"
        '
        'BTNBuy2
        '
        Me.BTNBuy2.BackColor = System.Drawing.Color.IndianRed
        Me.BTNBuy2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNBuy2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNBuy2.Location = New System.Drawing.Point(504, 397)
        Me.BTNBuy2.Name = "BTNBuy2"
        Me.BTNBuy2.Size = New System.Drawing.Size(137, 37)
        Me.BTNBuy2.TabIndex = 13
        Me.BTNBuy2.Text = "Buy Now"
        Me.BTNBuy2.UseVisualStyleBackColor = False
        '
        'BTNBuy3
        '
        Me.BTNBuy3.BackColor = System.Drawing.Color.IndianRed
        Me.BTNBuy3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNBuy3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNBuy3.Location = New System.Drawing.Point(504, 565)
        Me.BTNBuy3.Name = "BTNBuy3"
        Me.BTNBuy3.Size = New System.Drawing.Size(137, 37)
        Me.BTNBuy3.TabIndex = 14
        Me.BTNBuy3.Text = "Buy Now"
        Me.BTNBuy3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Sitka Banner", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(532, 513)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 35)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "RM 89.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Sitka Banner", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(215, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 35)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Tail Light"
        '
        'sparepartsdisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(664, 632)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTNBuy3)
        Me.Controls.Add(Me.BTNBuy2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNBuy1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.headLine)
        Me.Controls.Add(Me.buySidemirror)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "sparepartsdisplay"
        Me.Text = "Spare Parts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headLine As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents buySidemirror As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNBuy1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNBuy2 As Button
    Friend WithEvents BTNBuy3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
