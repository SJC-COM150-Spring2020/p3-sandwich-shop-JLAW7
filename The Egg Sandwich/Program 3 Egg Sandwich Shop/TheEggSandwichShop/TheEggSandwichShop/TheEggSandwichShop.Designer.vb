<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheEggSandwichShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheEggSandwichShop))
        Me.grpBeverages = New System.Windows.Forms.GroupBox()
        Me.chkJuice = New System.Windows.Forms.CheckBox()
        Me.chkMilk = New System.Windows.Forms.CheckBox()
        Me.chkHotChocolate = New System.Windows.Forms.CheckBox()
        Me.chkTea = New System.Windows.Forms.CheckBox()
        Me.chkCoffee = New System.Windows.Forms.CheckBox()
        Me.grpSandwiches = New System.Windows.Forms.GroupBox()
        Me.radPoached = New System.Windows.Forms.RadioButton()
        Me.radSunnySideUp = New System.Windows.Forms.RadioButton()
        Me.radOverEasy = New System.Windows.Forms.RadioButton()
        Me.radScrambled = New System.Windows.Forms.RadioButton()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.chkVeggies = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lstOrder = New System.Windows.Forms.ListBox()
        Me.lblBread = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblScroll = New System.Windows.Forms.Label()
        Me.grpBeverages.SuspendLayout()
        Me.grpSandwiches.SuspendLayout()
        Me.grpExtras.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBeverages
        '
        Me.grpBeverages.Controls.Add(Me.chkJuice)
        Me.grpBeverages.Controls.Add(Me.chkMilk)
        Me.grpBeverages.Controls.Add(Me.chkHotChocolate)
        Me.grpBeverages.Controls.Add(Me.chkTea)
        Me.grpBeverages.Controls.Add(Me.chkCoffee)
        Me.grpBeverages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpBeverages.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBeverages.Location = New System.Drawing.Point(21, 108)
        Me.grpBeverages.Name = "grpBeverages"
        Me.grpBeverages.Size = New System.Drawing.Size(448, 210)
        Me.grpBeverages.TabIndex = 0
        Me.grpBeverages.TabStop = False
        Me.grpBeverages.Text = "BEVERAGES - $2.25 EACH (Choose Any)"
        '
        'chkJuice
        '
        Me.chkJuice.AutoSize = True
        Me.chkJuice.Location = New System.Drawing.Point(7, 172)
        Me.chkJuice.Name = "chkJuice"
        Me.chkJuice.Size = New System.Drawing.Size(87, 31)
        Me.chkJuice.TabIndex = 4
        Me.chkJuice.Text = "Juice"
        Me.chkJuice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkJuice.UseVisualStyleBackColor = True
        '
        'chkMilk
        '
        Me.chkMilk.AutoSize = True
        Me.chkMilk.Location = New System.Drawing.Point(7, 137)
        Me.chkMilk.Name = "chkMilk"
        Me.chkMilk.Size = New System.Drawing.Size(83, 31)
        Me.chkMilk.TabIndex = 3
        Me.chkMilk.Text = "Milk"
        Me.chkMilk.UseVisualStyleBackColor = True
        '
        'chkHotChocolate
        '
        Me.chkHotChocolate.AutoSize = True
        Me.chkHotChocolate.Location = New System.Drawing.Point(7, 102)
        Me.chkHotChocolate.Name = "chkHotChocolate"
        Me.chkHotChocolate.Size = New System.Drawing.Size(198, 31)
        Me.chkHotChocolate.TabIndex = 2
        Me.chkHotChocolate.Text = "Hot Chocolate"
        Me.chkHotChocolate.UseVisualStyleBackColor = True
        '
        'chkTea
        '
        Me.chkTea.AutoSize = True
        Me.chkTea.Location = New System.Drawing.Point(7, 67)
        Me.chkTea.Name = "chkTea"
        Me.chkTea.Size = New System.Drawing.Size(69, 31)
        Me.chkTea.TabIndex = 1
        Me.chkTea.Text = "Tea"
        Me.chkTea.UseVisualStyleBackColor = True
        '
        'chkCoffee
        '
        Me.chkCoffee.AutoSize = True
        Me.chkCoffee.Location = New System.Drawing.Point(7, 32)
        Me.chkCoffee.Name = "chkCoffee"
        Me.chkCoffee.Size = New System.Drawing.Size(104, 31)
        Me.chkCoffee.TabIndex = 0
        Me.chkCoffee.Text = "Coffee"
        Me.chkCoffee.UseVisualStyleBackColor = True
        '
        'grpSandwiches
        '
        Me.grpSandwiches.Controls.Add(Me.radPoached)
        Me.grpSandwiches.Controls.Add(Me.radSunnySideUp)
        Me.grpSandwiches.Controls.Add(Me.radOverEasy)
        Me.grpSandwiches.Controls.Add(Me.radScrambled)
        Me.grpSandwiches.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSandwiches.Location = New System.Drawing.Point(21, 324)
        Me.grpSandwiches.Name = "grpSandwiches"
        Me.grpSandwiches.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpSandwiches.Size = New System.Drawing.Size(448, 210)
        Me.grpSandwiches.TabIndex = 1
        Me.grpSandwiches.TabStop = False
        Me.grpSandwiches.Text = "SANDWICHES - $6.95 (Select One)"
        '
        'radPoached
        '
        Me.radPoached.AutoSize = True
        Me.radPoached.Location = New System.Drawing.Point(7, 137)
        Me.radPoached.Name = "radPoached"
        Me.radPoached.Size = New System.Drawing.Size(127, 31)
        Me.radPoached.TabIndex = 3
        Me.radPoached.TabStop = True
        Me.radPoached.Text = "Poached"
        Me.radPoached.UseVisualStyleBackColor = True
        '
        'radSunnySideUp
        '
        Me.radSunnySideUp.AutoSize = True
        Me.radSunnySideUp.Location = New System.Drawing.Point(7, 102)
        Me.radSunnySideUp.Name = "radSunnySideUp"
        Me.radSunnySideUp.Size = New System.Drawing.Size(179, 31)
        Me.radSunnySideUp.TabIndex = 2
        Me.radSunnySideUp.TabStop = True
        Me.radSunnySideUp.Text = "Sunny Side Up"
        Me.radSunnySideUp.UseVisualStyleBackColor = True
        '
        'radOverEasy
        '
        Me.radOverEasy.AutoSize = True
        Me.radOverEasy.Location = New System.Drawing.Point(7, 67)
        Me.radOverEasy.Name = "radOverEasy"
        Me.radOverEasy.Size = New System.Drawing.Size(140, 31)
        Me.radOverEasy.TabIndex = 1
        Me.radOverEasy.TabStop = True
        Me.radOverEasy.Text = "Over Easy"
        Me.radOverEasy.UseVisualStyleBackColor = True
        '
        'radScrambled
        '
        Me.radScrambled.AutoSize = True
        Me.radScrambled.Location = New System.Drawing.Point(7, 32)
        Me.radScrambled.Name = "radScrambled"
        Me.radScrambled.Size = New System.Drawing.Size(151, 31)
        Me.radScrambled.TabIndex = 0
        Me.radScrambled.TabStop = True
        Me.radScrambled.Text = "Scrambled"
        Me.radScrambled.UseVisualStyleBackColor = True
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.chkVeggies)
        Me.grpExtras.Controls.Add(Me.chkHam)
        Me.grpExtras.Controls.Add(Me.chkSausage)
        Me.grpExtras.Controls.Add(Me.chkBacon)
        Me.grpExtras.Controls.Add(Me.chkCheese)
        Me.grpExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpExtras.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExtras.Location = New System.Drawing.Point(21, 540)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpExtras.Size = New System.Drawing.Size(448, 215)
        Me.grpExtras.TabIndex = 2
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "EXTRAS - $1.50 EACH (Choose Any)"
        '
        'chkVeggies
        '
        Me.chkVeggies.AutoSize = True
        Me.chkVeggies.Location = New System.Drawing.Point(7, 172)
        Me.chkVeggies.Name = "chkVeggies"
        Me.chkVeggies.Size = New System.Drawing.Size(115, 31)
        Me.chkVeggies.TabIndex = 4
        Me.chkVeggies.Text = "Veggies"
        Me.chkVeggies.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(7, 137)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(79, 31)
        Me.chkHam.TabIndex = 3
        Me.chkHam.Text = "Ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Location = New System.Drawing.Point(7, 102)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(120, 31)
        Me.chkSausage.TabIndex = 2
        Me.chkSausage.Text = "Sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Location = New System.Drawing.Point(7, 67)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(98, 31)
        Me.chkBacon.TabIndex = 1
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(7, 32)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(106, 31)
        Me.chkCheese.TabIndex = 0
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.Black
        Me.btnConfirm.Location = New System.Drawing.Point(200, 778)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 30)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lstOrder
        '
        Me.lstOrder.BackColor = System.Drawing.Color.White
        Me.lstOrder.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrder.FormattingEnabled = True
        Me.lstOrder.ItemHeight = 30
        Me.lstOrder.Location = New System.Drawing.Point(538, 511)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(256, 214)
        Me.lstOrder.TabIndex = 4
        '
        'lblBread
        '
        Me.lblBread.AutoSize = True
        Me.lblBread.BackColor = System.Drawing.Color.Orange
        Me.lblBread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBread.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBread.Location = New System.Drawing.Point(315, 29)
        Me.lblBread.Name = "lblBread"
        Me.lblBread.Size = New System.Drawing.Size(235, 42)
        Me.lblBread.TabIndex = 5
        Me.lblBread.Text = "BREAD N EGGS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(484, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 325)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(538, 778)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(694, 778)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(66, 86)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(341, 19)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Please select from the following below"
        '
        'lblScroll
        '
        Me.lblScroll.AutoSize = True
        Me.lblScroll.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScroll.Location = New System.Drawing.Point(509, 491)
        Me.lblScroll.Name = "lblScroll"
        Me.lblScroll.Size = New System.Drawing.Size(313, 17)
        Me.lblScroll.TabIndex = 10
        Me.lblScroll.Text = "Please Use Scroll bar to view total order"
        '
        'TheEggSandwichShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(860, 833)
        Me.Controls.Add(Me.lblScroll)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBread)
        Me.Controls.Add(Me.lstOrder)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.grpSandwiches)
        Me.Controls.Add(Me.grpBeverages)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "TheEggSandwichShop"
        Me.Text = "The Egg Sandwich Shop"
        Me.grpBeverages.ResumeLayout(False)
        Me.grpBeverages.PerformLayout()
        Me.grpSandwiches.ResumeLayout(False)
        Me.grpSandwiches.PerformLayout()
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBeverages As GroupBox
    Friend WithEvents grpSandwiches As GroupBox
    Friend WithEvents grpExtras As GroupBox
    Friend WithEvents chkJuice As CheckBox
    Friend WithEvents chkMilk As CheckBox
    Friend WithEvents chkHotChocolate As CheckBox
    Friend WithEvents chkTea As CheckBox
    Friend WithEvents chkCoffee As CheckBox
    Friend WithEvents radPoached As RadioButton
    Friend WithEvents radSunnySideUp As RadioButton
    Friend WithEvents radOverEasy As RadioButton
    Friend WithEvents radScrambled As RadioButton
    Friend WithEvents chkVeggies As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkSausage As CheckBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lstOrder As ListBox
    Friend WithEvents lblBread As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblScroll As Label
End Class
