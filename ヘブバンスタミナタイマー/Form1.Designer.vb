<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblTimer = New Label()
        btnSet = New Button()
        btnStart = New Button()
        btnStop = New Button()
        timerCountdown = New Timer(components)
        txtHours = New TextBox()
        txtMinutes = New TextBox()
        txtSeconds = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Life = New NumericUpDown()
        Label3 = New Label()
        errorcorrection = New Button()
        CheckBox1 = New CheckBox()
        AddDate = New Label()
        CType(Life, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.Font = New Font("Yu Gothic UI", 18F)
        lblTimer.Location = New Point(7, 7)
        lblTimer.Margin = New Padding(4, 0, 4, 0)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(102, 32)
        lblTimer.TabIndex = 0
        lblTimer.Text = "00:00:00"
        ' 
        ' btnSet
        ' 
        btnSet.Location = New Point(116, 123)
        btnSet.Margin = New Padding(4, 3, 4, 3)
        btnSet.Name = "btnSet"
        btnSet.Size = New Size(54, 23)
        btnSet.TabIndex = 1
        btnSet.Text = "設定"
        btnSet.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(62, 181)
        btnStart.Margin = New Padding(4, 3, 4, 3)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(75, 22)
        btnStart.TabIndex = 2
        btnStart.Text = "開始"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnStop
        ' 
        btnStop.Location = New Point(143, 181)
        btnStop.Margin = New Padding(4, 3, 4, 3)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(75, 22)
        btnStop.TabIndex = 3
        btnStop.Text = "停止"
        btnStop.UseVisualStyleBackColor = True
        ' 
        ' timerCountdown
        ' 
        ' 
        ' txtHours
        ' 
        txtHours.Location = New Point(8, 123)
        txtHours.Margin = New Padding(4, 3, 4, 3)
        txtHours.MaximumSize = New Size(19, 23)
        txtHours.Name = "txtHours"
        txtHours.Size = New Size(19, 23)
        txtHours.TabIndex = 4
        txtHours.Text = "00"
        ' 
        ' txtMinutes
        ' 
        txtMinutes.Location = New Point(48, 123)
        txtMinutes.Margin = New Padding(4, 3, 4, 3)
        txtMinutes.MaximumSize = New Size(19, 23)
        txtMinutes.Name = "txtMinutes"
        txtMinutes.Size = New Size(19, 23)
        txtMinutes.TabIndex = 5
        txtMinutes.Text = "00"
        ' 
        ' txtSeconds
        ' 
        txtSeconds.Location = New Point(89, 123)
        txtSeconds.Margin = New Padding(4, 3, 4, 3)
        txtSeconds.MaximumSize = New Size(19, 23)
        txtSeconds.Name = "txtSeconds"
        txtSeconds.Size = New Size(19, 23)
        txtSeconds.TabIndex = 6
        txtSeconds.Text = "00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 127)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(10, 15)
        Label1.TabIndex = 7
        Label1.Text = ":"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 127)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(10, 15)
        Label2.TabIndex = 8
        Label2.Text = ":"
        ' 
        ' Life
        ' 
        Life.AccessibleRole = AccessibleRole.None
        Life.Font = New Font("Yu Gothic UI", 18F)
        Life.ImeMode = ImeMode.Off
        Life.Location = New Point(222, 4)
        Life.Margin = New Padding(4, 3, 4, 3)
        Life.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Life.Name = "Life"
        Life.ReadOnly = True
        Life.Size = New Size(38, 39)
        Life.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 15F)
        Label3.Location = New Point(112, 9)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 28)
        Label3.TabIndex = 10
        Label3.Text = "現在のLIFE"
        ' 
        ' errorcorrection
        ' 
        errorcorrection.Location = New Point(178, 123)
        errorcorrection.Margin = New Padding(4, 3, 4, 3)
        errorcorrection.Name = "errorcorrection"
        errorcorrection.Size = New Size(90, 23)
        errorcorrection.TabIndex = 11
        errorcorrection.Text = "誤差修正-1秒"
        errorcorrection.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(157, 156)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(107, 19)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "常に最前面表示"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' AddDate
        ' 
        AddDate.AutoSize = True
        AddDate.Font = New Font("Yu Gothic UI", 11F)
        AddDate.Location = New Point(12, 40)
        AddDate.Name = "AddDate"
        AddDate.Size = New Size(53, 20)
        AddDate.TabIndex = 13
        AddDate.Text = "Label4"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(273, 211)
        Controls.Add(AddDate)
        Controls.Add(CheckBox1)
        Controls.Add(errorcorrection)
        Controls.Add(Label3)
        Controls.Add(Life)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSeconds)
        Controls.Add(txtMinutes)
        Controls.Add(txtHours)
        Controls.Add(btnStop)
        Controls.Add(btnStart)
        Controls.Add(btnSet)
        Controls.Add(lblTimer)
        Margin = New Padding(4, 3, 4, 3)
        MaximumSize = New Size(289, 250)
        MinimumSize = New Size(289, 250)
        Name = "Form1"
        Text = "ヘブバンライフタイマー"
        TopMost = True
        CType(Life, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTimer As Label
    Friend WithEvents btnSet As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents timerCountdown As Timer
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtMinutes As TextBox
    Friend WithEvents txtSeconds As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Life As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents errorcorrection As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents AddDate As Label

End Class
