<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.推送消息测试ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开文件夹ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.打开BangumiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(4, 42)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(225, 277)
        Me.ListBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.MenuStrip2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(233, 323)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(4, 22)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.MenuStrip2.Size = New System.Drawing.Size(225, 20)
        Me.MenuStrip2.TabIndex = 9
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripMenuItem1.Text = "刷新订阅"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 348)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1002, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 287)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(199, 3)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(559, 287)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "BgmReminder"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(233, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(769, 323)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.RichTextBox2)
        Me.TabPage2.Controls.Add(Me.MenuStrip3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(761, 293)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "日志信息"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(755, 267)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = ""
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(761, 293)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "播放信息"
        '
        '推送消息测试ToolStripMenuItem
        '
        Me.推送消息测试ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.推送消息测试ToolStripMenuItem.Name = "推送消息测试ToolStripMenuItem"
        Me.推送消息测试ToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.推送消息测试ToolStripMenuItem.Text = "推送消息测试"
        '
        '打开文件夹ToolStripMenuItem
        '
        Me.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem"
        Me.打开文件夹ToolStripMenuItem.Size = New System.Drawing.Size(80, 21)
        Me.打开文件夹ToolStripMenuItem.Text = "打开文件夹"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.推送消息测试ToolStripMenuItem, Me.打开文件夹ToolStripMenuItem, Me.打开BangumiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1002, 25)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '打开BangumiToolStripMenuItem
        '
        Me.打开BangumiToolStripMenuItem.Name = "打开BangumiToolStripMenuItem"
        Me.打开BangumiToolStripMenuItem.Size = New System.Drawing.Size(95, 21)
        Me.打开BangumiToolStripMenuItem.Text = "打开Bangumi"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.AutoSize = False
        Me.MenuStrip3.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip3.Location = New System.Drawing.Point(3, 270)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.MenuStrip3.Size = New System.Drawing.Size(755, 20)
        Me.MenuStrip3.TabIndex = 10
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripMenuItem2.Text = "清空日志"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 370)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1018, 409)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents 推送消息测试ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开文件夹ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 打开BangumiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
