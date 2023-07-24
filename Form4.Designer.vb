<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_7 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_6 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_5 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_4 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_2 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_3 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_k_2 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_k_3 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_k_6 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_k_5 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_k_4 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_k_7 = New System.Windows.Forms.MaskedTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PRODUTO = New System.Windows.Forms.Label()
        Me.txt_k_1 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_1 = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView2.Location = New System.Drawing.Point(4, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(774, 484)
        Me.DataGridView2.TabIndex = 2
        '
        'Column7
        '
        Me.Column7.HeaderText = "IDE"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "PRODUTO"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "ESTOQUE"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "VALOR TOTAL"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column11
        '
        Me.Column11.HeaderText = "EDITAR"
        Me.Column11.Image = CType(resources.GetObject("Column11.Image"), System.Drawing.Image)
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 125
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(795, 506)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(787, 477)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ESTOQUE"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(699, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(68, 79)
        Me.Panel1.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.RadioButton2)
        Me.TabPage2.Controls.Add(Me.RadioButton1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txt_7)
        Me.TabPage2.Controls.Add(Me.txt_6)
        Me.TabPage2.Controls.Add(Me.txt_5)
        Me.TabPage2.Controls.Add(Me.txt_4)
        Me.TabPage2.Controls.Add(Me.txt_2)
        Me.TabPage2.Controls.Add(Me.txt_3)
        Me.TabPage2.Controls.Add(Me.txt_k_2)
        Me.TabPage2.Controls.Add(Me.txt_k_3)
        Me.TabPage2.Controls.Add(Me.txt_k_6)
        Me.TabPage2.Controls.Add(Me.txt_k_5)
        Me.TabPage2.Controls.Add(Me.txt_k_4)
        Me.TabPage2.Controls.Add(Me.txt_k_7)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.PRODUTO)
        Me.TabPage2.Controls.Add(Me.txt_k_1)
        Me.TabPage2.Controls.Add(Me.txt_1)
        Me.TabPage2.Controls.Add(Me.ComboBox8)
        Me.TabPage2.Controls.Add(Me.ComboBox7)
        Me.TabPage2.Controls.Add(Me.ComboBox6)
        Me.TabPage2.Controls.Add(Me.ComboBox5)
        Me.TabPage2.Controls.Add(Me.ComboBox3)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(787, 477)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ALTERAR ESTOQUE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Location = New System.Drawing.Point(654, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(114, 101)
        Me.Panel2.TabIndex = 41
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"farinha de trigo", "farinha de rosca", "leite", "batata", "caldo galinha", "presunto", "queijo", "calabresa ", "carne", "frango"})
        Me.ComboBox1.Location = New System.Drawing.Point(55, 444)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 24)
        Me.ComboBox1.TabIndex = 40
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(686, 340)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(95, 20)
        Me.RadioButton2.TabIndex = 39
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RETIRAR"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(558, 340)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(110, 20)
        Me.RadioButton1.TabIndex = 38
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ADICIONAR"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 36)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "CONTROLE DE ESTOQUE"
        '
        'txt_7
        '
        Me.txt_7.Location = New System.Drawing.Point(262, 444)
        Me.txt_7.Mask = "00.000 "
        Me.txt_7.Name = "txt_7"
        Me.txt_7.Size = New System.Drawing.Size(69, 22)
        Me.txt_7.TabIndex = 36
        '
        'txt_6
        '
        Me.txt_6.Location = New System.Drawing.Point(262, 391)
        Me.txt_6.Mask = "00.000"
        Me.txt_6.Name = "txt_6"
        Me.txt_6.Size = New System.Drawing.Size(69, 22)
        Me.txt_6.TabIndex = 35
        '
        'txt_5
        '
        Me.txt_5.Location = New System.Drawing.Point(262, 339)
        Me.txt_5.Mask = "00.000"
        Me.txt_5.Name = "txt_5"
        Me.txt_5.Size = New System.Drawing.Size(69, 22)
        Me.txt_5.TabIndex = 34
        '
        'txt_4
        '
        Me.txt_4.Location = New System.Drawing.Point(262, 289)
        Me.txt_4.Mask = "00.000 "
        Me.txt_4.Name = "txt_4"
        Me.txt_4.Size = New System.Drawing.Size(69, 22)
        Me.txt_4.TabIndex = 33
        '
        'txt_2
        '
        Me.txt_2.Location = New System.Drawing.Point(262, 190)
        Me.txt_2.Mask = "00.000 "
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(69, 22)
        Me.txt_2.TabIndex = 32
        '
        'txt_3
        '
        Me.txt_3.Location = New System.Drawing.Point(262, 240)
        Me.txt_3.Mask = "00.000 "
        Me.txt_3.Name = "txt_3"
        Me.txt_3.Size = New System.Drawing.Size(69, 22)
        Me.txt_3.TabIndex = 31
        '
        'txt_k_2
        '
        Me.txt_k_2.Location = New System.Drawing.Point(416, 190)
        Me.txt_k_2.Mask = "000.00 $"
        Me.txt_k_2.Name = "txt_k_2"
        Me.txt_k_2.Size = New System.Drawing.Size(83, 22)
        Me.txt_k_2.TabIndex = 30
        '
        'txt_k_3
        '
        Me.txt_k_3.Location = New System.Drawing.Point(416, 240)
        Me.txt_k_3.Mask = "000.00 $"
        Me.txt_k_3.Name = "txt_k_3"
        Me.txt_k_3.Size = New System.Drawing.Size(83, 22)
        Me.txt_k_3.TabIndex = 29
        '
        'txt_k_6
        '
        Me.txt_k_6.Location = New System.Drawing.Point(416, 391)
        Me.txt_k_6.Mask = "000.00 $"
        Me.txt_k_6.Name = "txt_k_6"
        Me.txt_k_6.Size = New System.Drawing.Size(83, 22)
        Me.txt_k_6.TabIndex = 28
        '
        'txt_k_5
        '
        Me.txt_k_5.Location = New System.Drawing.Point(416, 342)
        Me.txt_k_5.Mask = "000.00 $"
        Me.txt_k_5.Name = "txt_k_5"
        Me.txt_k_5.Size = New System.Drawing.Size(83, 22)
        Me.txt_k_5.TabIndex = 27
        '
        'txt_k_4
        '
        Me.txt_k_4.Location = New System.Drawing.Point(416, 289)
        Me.txt_k_4.Mask = "000.00 $"
        Me.txt_k_4.Name = "txt_k_4"
        Me.txt_k_4.Size = New System.Drawing.Size(83, 22)
        Me.txt_k_4.TabIndex = 26
        '
        'txt_k_7
        '
        Me.txt_k_7.Location = New System.Drawing.Point(416, 446)
        Me.txt_k_7.Mask = "000.00 $"
        Me.txt_k_7.Name = "txt_k_7"
        Me.txt_k_7.Size = New System.Drawing.Size(83, 22)
        Me.txt_k_7.TabIndex = 25
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(608, 374)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 56)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "EFETURA"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PREÇO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "QTD/KG OU LITRO"
        '
        'PRODUTO
        '
        Me.PRODUTO.AutoSize = True
        Me.PRODUTO.Location = New System.Drawing.Point(67, 105)
        Me.PRODUTO.Name = "PRODUTO"
        Me.PRODUTO.Size = New System.Drawing.Size(82, 16)
        Me.PRODUTO.TabIndex = 4
        Me.PRODUTO.Text = "PRODUTO"
        '
        'txt_k_1
        '
        Me.txt_k_1.Location = New System.Drawing.Point(415, 139)
        Me.txt_k_1.Mask = "000.00 $"
        Me.txt_k_1.Name = "txt_k_1"
        Me.txt_k_1.Size = New System.Drawing.Size(83, 22)
        Me.txt_k_1.TabIndex = 15
        '
        'txt_1
        '
        Me.txt_1.Location = New System.Drawing.Point(262, 139)
        Me.txt_1.Mask = "00.000 "
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(69, 22)
        Me.txt_1.TabIndex = 8
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"farinha de trigo", "farinha de rosca", "leite", "batata", "caldo galinha", "presunto", "queijo", "calabresa ", "carne", "frango"})
        Me.ComboBox8.Location = New System.Drawing.Point(55, 188)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(136, 24)
        Me.ComboBox8.TabIndex = 7
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"farinha de trigo", "farinha de rosca", "leite", "batata", "caldo galinha", "presunto", "queijo", "calabresa ", "carne", "frango"})
        Me.ComboBox7.Location = New System.Drawing.Point(55, 238)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(136, 24)
        Me.ComboBox7.TabIndex = 6
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"farinha de trigo", "farinha de rosca", "leite", "batata", "caldo galinha", "presunto", "queijo", "calabresa ", "carne", "frango"})
        Me.ComboBox6.Location = New System.Drawing.Point(55, 137)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(136, 24)
        Me.ComboBox6.TabIndex = 5
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"farinha de trigo", "farinha de rosca", "leite", "batata", "caldo galinha", "presunto", "queijo", "calabresa ", "carne", "frango"})
        Me.ComboBox5.Location = New System.Drawing.Point(55, 287)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(136, 24)
        Me.ComboBox5.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"farinha de trigo", "farinha de rosca", "leite", "batata", "caldo galinha", "presunto", "queijo", "calabresa ", "carne", "frango"})
        Me.ComboBox3.Location = New System.Drawing.Point(55, 389)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(136, 24)
        Me.ComboBox3.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"farinha de trigo", "farinha de rosca", "leite", "batata", "caldo galinha", "presunto", "queijo", "calabresa ", "carne", "frango"})
        Me.ComboBox2.Location = New System.Drawing.Point(55, 340)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(136, 24)
        Me.ComboBox2.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(806, 31)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 548)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "CONTROLE DE ESTOQUE"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_k_1 As MaskedTextBox
    Friend WithEvents txt_1 As MaskedTextBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents txt_k_2 As MaskedTextBox
    Friend WithEvents txt_k_3 As MaskedTextBox
    Friend WithEvents txt_k_6 As MaskedTextBox
    Friend WithEvents txt_k_5 As MaskedTextBox
    Friend WithEvents txt_k_4 As MaskedTextBox
    Friend WithEvents txt_k_7 As MaskedTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PRODUTO As Label
    Friend WithEvents txt_7 As MaskedTextBox
    Friend WithEvents txt_6 As MaskedTextBox
    Friend WithEvents txt_5 As MaskedTextBox
    Friend WithEvents txt_4 As MaskedTextBox
    Friend WithEvents txt_2 As MaskedTextBox
    Friend WithEvents txt_3 As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
