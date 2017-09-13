<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.portlabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.barV = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.barmA = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TrueV = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TruemA = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.AVoltbar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.AVoltlab = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.closebtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Stromlabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.spannlabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.portscan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.start_stop = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.mAbox = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Vbox = New Bunifu.Framework.UI.BunifuTextbox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'portlabel
        '
        Me.portlabel.AutoSize = True
        Me.portlabel.BackColor = System.Drawing.Color.Transparent
        Me.portlabel.Location = New System.Drawing.Point(828, 391)
        Me.portlabel.Name = "portlabel"
        Me.portlabel.Size = New System.Drawing.Size(118, 13)
        Me.portlabel.TabIndex = 8
        Me.portlabel.Text = "Kein Arduino gefunden!"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'barV
        '
        Me.barV.BackColor = System.Drawing.Color.Silver
        Me.barV.BorderRadius = 5
        Me.barV.Location = New System.Drawing.Point(368, 274)
        Me.barV.MaximumValue = 30
        Me.barV.Name = "barV"
        Me.barV.ProgressColor = System.Drawing.Color.Teal
        Me.barV.Size = New System.Drawing.Size(262, 29)
        Me.barV.TabIndex = 11
        Me.barV.Value = 0
        '
        'barmA
        '
        Me.barmA.BackColor = System.Drawing.Color.Silver
        Me.barmA.BorderRadius = 5
        Me.barmA.Location = New System.Drawing.Point(658, 274)
        Me.barmA.MaximumValue = 1000
        Me.barmA.Name = "barmA"
        Me.barmA.ProgressColor = System.Drawing.Color.Teal
        Me.barmA.Size = New System.Drawing.Size(262, 29)
        Me.barmA.TabIndex = 13
        Me.barmA.Value = 0
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(365, 306)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(23, 13)
        Me.BunifuCustomLabel4.TabIndex = 14
        Me.BunifuCustomLabel4.Text = "0 V"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(601, 306)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(29, 13)
        Me.BunifuCustomLabel5.TabIndex = 15
        Me.BunifuCustomLabel5.Text = "30 V"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(655, 306)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(31, 13)
        Me.BunifuCustomLabel6.TabIndex = 16
        Me.BunifuCustomLabel6.Text = "0 mA"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(871, 306)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(49, 13)
        Me.BunifuCustomLabel7.TabIndex = 17
        Me.BunifuCustomLabel7.Text = "1000 mA"
        '
        'TrueV
        '
        Me.TrueV.AutoSize = True
        Me.TrueV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TrueV.Location = New System.Drawing.Point(480, 251)
        Me.TrueV.Name = "TrueV"
        Me.TrueV.Size = New System.Drawing.Size(33, 20)
        Me.TrueV.TabIndex = 18
        Me.TrueV.Text = "0 V"
        '
        'TruemA
        '
        Me.TruemA.AutoSize = True
        Me.TruemA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TruemA.Location = New System.Drawing.Point(770, 251)
        Me.TruemA.Name = "TruemA"
        Me.TruemA.Size = New System.Drawing.Size(46, 20)
        Me.TruemA.TabIndex = 19
        Me.TruemA.Text = "0 mA"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(364, 207)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(158, 20)
        Me.BunifuCustomLabel1.TabIndex = 20
        Me.BunifuCustomLabel1.Text = "Eingestellter Wert:"
        '
        'AVoltbar
        '
        Me.AVoltbar.BackColor = System.Drawing.Color.Silver
        Me.AVoltbar.BorderRadius = 5
        Me.AVoltbar.Location = New System.Drawing.Point(514, 133)
        Me.AVoltbar.MaximumValue = 30
        Me.AVoltbar.Name = "AVoltbar"
        Me.AVoltbar.ProgressColor = System.Drawing.Color.Teal
        Me.AVoltbar.Size = New System.Drawing.Size(262, 29)
        Me.AVoltbar.TabIndex = 21
        Me.AVoltbar.Value = 0
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(364, 81)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(128, 20)
        Me.BunifuCustomLabel2.TabIndex = 22
        Me.BunifuCustomLabel2.Text = "Aktueller Wert:"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(511, 165)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(23, 13)
        Me.BunifuCustomLabel3.TabIndex = 23
        Me.BunifuCustomLabel3.Text = "0 V"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(747, 165)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(29, 13)
        Me.BunifuCustomLabel8.TabIndex = 24
        Me.BunifuCustomLabel8.Text = "30 V"
        '
        'AVoltlab
        '
        Me.AVoltlab.AutoSize = True
        Me.AVoltlab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AVoltlab.Location = New System.Drawing.Point(626, 110)
        Me.AVoltlab.Name = "AVoltlab"
        Me.AVoltlab.Size = New System.Drawing.Size(33, 20)
        Me.AVoltlab.TabIndex = 25
        Me.AVoltlab.Text = "0 V"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Gray
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(349, 13)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(120, 28)
        Me.BunifuCustomLabel10.TabIndex = 26
        Me.BunifuCustomLabel10.Text = "Stromsenke"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = Global.Kriwan_Stromsenke.My.Resources.Resources.tzw1
        Me.PictureBox1.Location = New System.Drawing.Point(676, 368)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'closebtn
        '
        Me.closebtn.BackColor = System.Drawing.Color.Transparent
        Me.closebtn.Image = CType(resources.GetObject("closebtn.Image"), System.Drawing.Image)
        Me.closebtn.ImageActive = Nothing
        Me.closebtn.Location = New System.Drawing.Point(896, 12)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(50, 50)
        Me.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closebtn.TabIndex = 9
        Me.closebtn.TabStop = False
        Me.closebtn.Zoom = 10
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.Stromlabel)
        Me.BunifuGradientPanel2.Controls.Add(Me.spannlabel)
        Me.BunifuGradientPanel2.Controls.Add(Me.portscan)
        Me.BunifuGradientPanel2.Controls.Add(Me.start_stop)
        Me.BunifuGradientPanel2.Controls.Add(Me.mAbox)
        Me.BunifuGradientPanel2.Controls.Add(Me.Vbox)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Teal
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Blue
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Cyan
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(327, 413)
        Me.BunifuGradientPanel2.TabIndex = 4
        '
        'Stromlabel
        '
        Me.Stromlabel.AutoSize = True
        Me.Stromlabel.BackColor = System.Drawing.Color.Transparent
        Me.Stromlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stromlabel.Location = New System.Drawing.Point(12, 113)
        Me.Stromlabel.Name = "Stromlabel"
        Me.Stromlabel.Size = New System.Drawing.Size(40, 15)
        Me.Stromlabel.TabIndex = 8
        Me.Stromlabel.Text = "Strom"
        '
        'spannlabel
        '
        Me.spannlabel.AutoSize = True
        Me.spannlabel.BackColor = System.Drawing.Color.Transparent
        Me.spannlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spannlabel.Location = New System.Drawing.Point(12, 35)
        Me.spannlabel.Name = "spannlabel"
        Me.spannlabel.Size = New System.Drawing.Size(108, 15)
        Me.spannlabel.TabIndex = 7
        Me.spannlabel.Text = "Spannungsgrenze"
        '
        'portscan
        '
        Me.portscan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.portscan.BackColor = System.Drawing.Color.Transparent
        Me.portscan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.portscan.BorderRadius = 5
        Me.portscan.ButtonText = "Port Scan"
        Me.portscan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.portscan.DisabledColor = System.Drawing.Color.Gray
        Me.portscan.Iconcolor = System.Drawing.Color.Transparent
        Me.portscan.Iconimage = CType(resources.GetObject("portscan.Iconimage"), System.Drawing.Image)
        Me.portscan.Iconimage_right = Nothing
        Me.portscan.Iconimage_right_Selected = Nothing
        Me.portscan.Iconimage_Selected = Nothing
        Me.portscan.IconMarginLeft = 0
        Me.portscan.IconMarginRight = 0
        Me.portscan.IconRightVisible = True
        Me.portscan.IconRightZoom = 0R
        Me.portscan.IconVisible = True
        Me.portscan.IconZoom = 70.0R
        Me.portscan.IsTab = False
        Me.portscan.Location = New System.Drawing.Point(0, 288)
        Me.portscan.Name = "portscan"
        Me.portscan.Normalcolor = System.Drawing.Color.Transparent
        Me.portscan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.portscan.OnHoverTextColor = System.Drawing.Color.White
        Me.portscan.selected = False
        Me.portscan.Size = New System.Drawing.Size(327, 31)
        Me.portscan.TabIndex = 6
        Me.portscan.Text = "Port Scan"
        Me.portscan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.portscan.Textcolor = System.Drawing.Color.White
        Me.portscan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'start_stop
        '
        Me.start_stop.Activecolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.start_stop.BackColor = System.Drawing.Color.Transparent
        Me.start_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.start_stop.BorderRadius = 5
        Me.start_stop.ButtonText = "Start"
        Me.start_stop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.start_stop.DisabledColor = System.Drawing.Color.Gray
        Me.start_stop.Iconcolor = System.Drawing.Color.Transparent
        Me.start_stop.Iconimage = Global.Kriwan_Stromsenke.My.Resources.Resources.icons8_Play_50
        Me.start_stop.Iconimage_right = Nothing
        Me.start_stop.Iconimage_right_Selected = Nothing
        Me.start_stop.Iconimage_Selected = Nothing
        Me.start_stop.IconMarginLeft = 0
        Me.start_stop.IconMarginRight = 0
        Me.start_stop.IconRightVisible = True
        Me.start_stop.IconRightZoom = 0R
        Me.start_stop.IconVisible = True
        Me.start_stop.IconZoom = 80.0R
        Me.start_stop.IsTab = False
        Me.start_stop.Location = New System.Drawing.Point(0, 251)
        Me.start_stop.Name = "start_stop"
        Me.start_stop.Normalcolor = System.Drawing.Color.Transparent
        Me.start_stop.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.start_stop.OnHoverTextColor = System.Drawing.Color.White
        Me.start_stop.selected = False
        Me.start_stop.Size = New System.Drawing.Size(327, 31)
        Me.start_stop.TabIndex = 5
        Me.start_stop.Text = "Start"
        Me.start_stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.start_stop.Textcolor = System.Drawing.Color.White
        Me.start_stop.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'mAbox
        '
        Me.mAbox.BackColor = System.Drawing.Color.DodgerBlue
        Me.mAbox.BackgroundImage = CType(resources.GetObject("mAbox.BackgroundImage"), System.Drawing.Image)
        Me.mAbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mAbox.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.mAbox.Icon = CType(resources.GetObject("mAbox.Icon"), System.Drawing.Image)
        Me.mAbox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mAbox.Location = New System.Drawing.Point(0, 131)
        Me.mAbox.Name = "mAbox"
        Me.mAbox.Size = New System.Drawing.Size(327, 31)
        Me.mAbox.TabIndex = 4
        Me.mAbox.text = ""
        '
        'Vbox
        '
        Me.Vbox.BackColor = System.Drawing.Color.DodgerBlue
        Me.Vbox.BackgroundImage = CType(resources.GetObject("Vbox.BackgroundImage"), System.Drawing.Image)
        Me.Vbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Vbox.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Vbox.Icon = CType(resources.GetObject("Vbox.Icon"), System.Drawing.Image)
        Me.Vbox.Location = New System.Drawing.Point(0, 53)
        Me.Vbox.Name = "Vbox"
        Me.Vbox.Size = New System.Drawing.Size(327, 31)
        Me.Vbox.TabIndex = 3
        Me.Vbox.text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 413)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.AVoltlab)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.AVoltbar)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.TruemA)
        Me.Controls.Add(Me.TrueV)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.barmA)
        Me.Controls.Add(Me.barV)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.portlabel)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Vbox As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents mAbox As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents portscan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents start_stop As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents portlabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Stromlabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents spannlabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents closebtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents barV As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents TruemA As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TrueV As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents barmA As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents AVoltlab As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents AVoltbar As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
