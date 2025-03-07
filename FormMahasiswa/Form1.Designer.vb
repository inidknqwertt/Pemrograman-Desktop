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
        txtNIP.Size = New Size(125, 27)
        txtNIP.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(172, 113)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
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
        cmbJurusan.Size = New Size(151, 28)
        cmbJurusan.TabIndex = 9
        ' 
        ' cmbFakultas
        ' 
        cmbFakultas.FormattingEnabled = True
        cmbFakultas.Location = New Point(172, 255)
        cmbFakultas.Name = "cmbFakultas"
        cmbFakultas.Size = New Size(151, 28)
        cmbFakultas.TabIndex = 10
        ' 
        ' btnProses
        ' 
        btnProses.Location = New Point(38, 375)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(94, 29)
        btnProses.TabIndex = 11
        btnProses.Text = "Process"
        btnProses.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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

End Class
