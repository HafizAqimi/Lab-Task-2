<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymenttransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paymenttransaction))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buyanddone = New System.Windows.Forms.Button()
        Me.addtocart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BTNCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 303)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Sitka Banner", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(376, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 35)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Side Mirror"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Sitka Banner", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(376, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 53)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "RM 89.00"
        '
        'buyanddone
        '
        Me.buyanddone.BackColor = System.Drawing.Color.IndianRed
        Me.buyanddone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyanddone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buyanddone.Location = New System.Drawing.Point(521, 278)
        Me.buyanddone.Name = "buyanddone"
        Me.buyanddone.Size = New System.Drawing.Size(77, 37)
        Me.buyanddone.TabIndex = 11
        Me.buyanddone.Text = "Buy Now"
        Me.buyanddone.UseVisualStyleBackColor = False
        '
        'addtocart
        '
        Me.addtocart.BackColor = System.Drawing.Color.RosyBrown
        Me.addtocart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.addtocart.ForeColor = System.Drawing.Color.IndianRed
        Me.addtocart.Location = New System.Drawing.Point(368, 278)
        Me.addtocart.Name = "addtocart"
        Me.addtocart.Size = New System.Drawing.Size(137, 37)
        Me.addtocart.TabIndex = 12
        Me.addtocart.Text = "Add To Cart"
        Me.addtocart.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Shipping"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(490, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Free Shipping"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Shape"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(463, 113)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 24)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(463, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 30)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Rounded"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(564, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 30)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Pointy"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Quantity"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(463, 231)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDown1.TabIndex = 20
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BTNCancel
        '
        Me.BTNCancel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BTNCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCancel.Location = New System.Drawing.Point(734, 281)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(108, 30)
        Me.BTNCancel.TabIndex = 21
        Me.BTNCancel.Text = "Cancel"
        Me.BTNCancel.UseVisualStyleBackColor = False
        '
        'paymenttransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 348)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addtocart)
        Me.Controls.Add(Me.buyanddone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "paymenttransaction"
        Me.Text = "Payment Transaction"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents buyanddone As Button
    Friend WithEvents addtocart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BTNCancel As Button
End Class
