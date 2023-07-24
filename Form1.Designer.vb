<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.cbx_ocultar = New Guna.UI.WinForms.GunaCheckBox()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_senha_login = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_esqueceu = New Guna.UI.WinForms.GunaLinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.GunaLabel1.Location = New System.Drawing.Point(210, 81)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(491, 30)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "LOGIN DE USUÁRIO OU ADMINISTRADOR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbx_ocultar
        '
        Me.cbx_ocultar.BaseColor = System.Drawing.Color.White
        Me.cbx_ocultar.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbx_ocultar.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_ocultar.FillColor = System.Drawing.Color.White
        Me.cbx_ocultar.Location = New System.Drawing.Point(607, 263)
        Me.cbx_ocultar.Name = "cbx_ocultar"
        Me.cbx_ocultar.Size = New System.Drawing.Size(102, 20)
        Me.cbx_ocultar.TabIndex = 16
        Me.cbx_ocultar.Text = "Mostrar senha"
        '
        'txt_login
        '
        Me.txt_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.ForeColor = System.Drawing.Color.DimGray
        Me.txt_login.Location = New System.Drawing.Point(246, 187)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(325, 29)
        Me.txt_login.TabIndex = 15
        Me.txt_login.Text = "CPF ou Nome do Usuário"
        '
        'txt_senha_login
        '
        Me.txt_senha_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_login.ForeColor = System.Drawing.Color.DimGray
        Me.txt_senha_login.Location = New System.Drawing.Point(246, 259)
        Me.txt_senha_login.Name = "txt_senha_login"
        Me.txt_senha_login.Size = New System.Drawing.Size(325, 29)
        Me.txt_senha_login.TabIndex = 14
        Me.txt_senha_login.Text = "Senha"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(495, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 27)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "ENTRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl_esqueceu
        '
        Me.lbl_esqueceu.AutoSize = True
        Me.lbl_esqueceu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_esqueceu.LinkColor = System.Drawing.Color.Black
        Me.lbl_esqueceu.Location = New System.Drawing.Point(243, 334)
        Me.lbl_esqueceu.Name = "lbl_esqueceu"
        Me.lbl_esqueceu.Size = New System.Drawing.Size(118, 15)
        Me.lbl_esqueceu.TabIndex = 12
        Me.lbl_esqueceu.TabStop = True
        Me.lbl_esqueceu.Text = "Esqueci minha senha"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.prj_adsma2_cadastro.My.Resources.Resources.multiplication_sign
        Me.Button2.Location = New System.Drawing.Point(762, 8)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 22)
        Me.Button2.TabIndex = 17
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(129, 498)
        Me.Panel1.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Location = New System.Drawing.Point(12, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 96)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.Location = New System.Drawing.Point(118, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(679, 40)
        Me.Panel2.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(797, 497)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cbx_ocultar)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.txt_senha_login)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_esqueceu)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbx_ocultar As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_senha_login As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_esqueceu As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
