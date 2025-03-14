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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNIP = New TextBox()
        txtNama = New TextBox()
        radioLaki = New RadioButton()
        radioPerempuan = New RadioButton()
        cmbJurusan = New ComboBox()
        cmbFakultas = New ComboBox()
        btnProses = New Button()
        Label6 = New Label()
        Label7 = New Label()
        txtTugas = New TextBox()
        txtUAS = New TextBox()
        txtUTS = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        txtGrade = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 20)
        Label1.TabIndex = 0
        Label1.Text = "NIP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 3
        Label4.Text = "Fakultas"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(38, 324)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 4
        Label5.Text = "Jurusan"
        ' 
        ' txtNIP
        ' 
        txtNIP.Location = New Point(168, 50)
        txtNIP.Name = "txtNIP"
        txtNIP.Size = New Size(358, 27)
        txtNIP.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(172, 113)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(354, 27)
        txtNama.TabIndex = 6
        ' 
        ' radioLaki
        ' 
        radioLaki.AutoSize = True
        radioLaki.Location = New Point(172, 178)
        radioLaki.Name = "radioLaki"
        radioLaki.Size = New Size(96, 24)
        radioLaki.TabIndex = 7
        radioLaki.TabStop = True
        radioLaki.Text = "Laki - Laki"
        radioLaki.UseVisualStyleBackColor = True
        ' 
        ' radioPerempuan
        ' 
        radioPerempuan.AutoSize = True
        radioPerempuan.Location = New Point(322, 178)
        radioPerempuan.Name = "radioPerempuan"
        radioPerempuan.Size = New Size(104, 24)
        radioPerempuan.TabIndex = 8
        radioPerempuan.TabStop = True
        radioPerempuan.Text = "Perempuan"
        radioPerempuan.UseVisualStyleBackColor = True
        ' 
        ' cmbJurusan
        ' 
        cmbJurusan.FormattingEnabled = True
        cmbJurusan.Location = New Point(172, 321)
        cmbJurusan.Name = "cmbJurusan"
        cmbJurusan.Size = New Size(337, 28)
        cmbJurusan.TabIndex = 9
        ' 
        ' cmbFakultas
        ' 
        cmbFakultas.FormattingEnabled = True
        cmbFakultas.Location = New Point(172, 255)
        cmbFakultas.Name = "cmbFakultas"
        cmbFakultas.Size = New Size(237, 28)
        cmbFakultas.TabIndex = 10
        ' 
        ' btnProses
        ' 
        btnProses.Location = New Point(38, 486)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(94, 29)
        btnProses.TabIndex = 11
        btnProses.Text = "Process"
        btnProses.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(38, 405)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 20)
        Label6.TabIndex = 12
        Label6.Text = "Nilai"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(168, 405)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 20)
        Label7.TabIndex = 13
        Label7.Text = "Tugas"
        ' 
        ' txtTugas
        ' 
        txtTugas.Location = New Point(222, 405)
        txtTugas.Name = "txtTugas"
        txtTugas.Size = New Size(92, 27)
        txtTugas.TabIndex = 14
        ' 
        ' txtUAS
        ' 
        txtUAS.Location = New Point(571, 405)
        txtUAS.Name = "txtUAS"
        txtUAS.Size = New Size(93, 27)
        txtUAS.TabIndex = 15
        ' 
        ' txtUTS
        ' 
        txtUTS.Location = New Point(389, 405)
        txtUTS.Name = "txtUTS"
        txtUTS.Size = New Size(95, 27)
        txtUTS.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(348, 408)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 20)
        Label8.TabIndex = 17
        Label8.Text = "UTS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(528, 412)
        Label9.Name = "Label9"
        Label9.Size = New Size(37, 20)
        Label9.TabIndex = 18
        Label9.Text = "UAS"
        ' 
        ' txtGrade
        ' 
        txtGrade.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGrade.Location = New Point(731, 408)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(125, 27)
        txtGrade.TabIndex = 19
        txtGrade.Text = "-GRADE-"
        txtGrade.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(986, 552)
        Controls.Add(txtGrade)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtUTS)
        Controls.Add(txtUAS)
        Controls.Add(txtTugas)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(btnProses)
        Controls.Add(cmbFakultas)
        Controls.Add(cmbJurusan)
        Controls.Add(radioPerempuan)
        Controls.Add(radioLaki)
        Controls.Add(txtNama)
        Controls.Add(txtNIP)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents radioLaki As RadioButton
    Friend WithEvents radioPerempuan As RadioButton
    Friend WithEvents cmbJurusan As ComboBox
    Friend WithEvents cmbFakultas As ComboBox
    Friend WithEvents btnProses As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtGrade As TextBox

End Class
