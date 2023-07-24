<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_custo = New System.Windows.Forms.Label()
        Me.lbl_lucro = New System.Windows.Forms.Label()
        Me.lbl_vendas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.date_init = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.date_final = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONSULTA DE LUCRO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " DATA INICIAL: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = " DATA FINAL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "VENDAS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "LUCRO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "CUSTO COM MERCADORIAS:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column2})
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(37, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(674, 363)
        Me.DataGridView1.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "DATA"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "VENDAS"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "CUSTO COM MERCADORIA"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "LUCRO"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "QTD DE VENDAS"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 219)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 383)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                                                                     LUCRO ULTIMO" &
    "S 30 DIAS:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(781, 31)
        Me.ToolStrip1.TabIndex = 21
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(552, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 41)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "calcular intervalo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_custo
        '
        Me.lbl_custo.AutoSize = True
        Me.lbl_custo.Location = New System.Drawing.Point(480, 144)
        Me.lbl_custo.Name = "lbl_custo"
        Me.lbl_custo.Size = New System.Drawing.Size(0, 16)
        Me.lbl_custo.TabIndex = 23
        '
        'lbl_lucro
        '
        Me.lbl_lucro.AutoSize = True
        Me.lbl_lucro.Location = New System.Drawing.Point(76, 144)
        Me.lbl_lucro.Name = "lbl_lucro"
        Me.lbl_lucro.Size = New System.Drawing.Size(0, 16)
        Me.lbl_lucro.TabIndex = 26
        '
        'lbl_vendas
        '
        Me.lbl_vendas.AutoSize = True
        Me.lbl_vendas.Location = New System.Drawing.Point(205, 144)
        Me.lbl_vendas.Name = "lbl_vendas"
        Me.lbl_vendas.Size = New System.Drawing.Size(0, 16)
        Me.lbl_vendas.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(234, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(368, 29)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "CONSULTA LUCRO E CUSTO"
        '
        'date_init
        '
        Me.date_init.BaseColor = System.Drawing.Color.White
        Me.date_init.BorderColor = System.Drawing.Color.Silver
        Me.date_init.CustomFormat = Nothing
        Me.date_init.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.date_init.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.date_init.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.date_init.ForeColor = System.Drawing.Color.Black
        Me.date_init.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_init.Location = New System.Drawing.Point(112, 76)
        Me.date_init.Margin = New System.Windows.Forms.Padding(4)
        Me.date_init.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.date_init.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.date_init.Name = "date_init"
        Me.date_init.OnHoverBaseColor = System.Drawing.Color.White
        Me.date_init.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.date_init.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.date_init.OnPressedColor = System.Drawing.Color.Black
        Me.date_init.Size = New System.Drawing.Size(164, 37)
        Me.date_init.TabIndex = 31
        Me.date_init.Text = "28/05/2023"
        Me.date_init.Value = New Date(2023, 5, 28, 18, 39, 48, 36)
        '
        'date_final
        '
        Me.date_final.BaseColor = System.Drawing.Color.White
        Me.date_final.BorderColor = System.Drawing.Color.Silver
        Me.date_final.CustomFormat = Nothing
        Me.date_final.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.date_final.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.date_final.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.date_final.ForeColor = System.Drawing.Color.Black
        Me.date_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_final.Location = New System.Drawing.Point(471, 76)
        Me.date_final.Margin = New System.Windows.Forms.Padding(4)
        Me.date_final.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.date_final.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.date_final.Name = "date_final"
        Me.date_final.OnHoverBaseColor = System.Drawing.Color.White
        Me.date_final.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.date_final.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.date_final.OnPressedColor = System.Drawing.Color.Black
        Me.date_final.Size = New System.Drawing.Size(164, 37)
        Me.date_final.TabIndex = 32
        Me.date_final.Text = "28/05/2023"
        Me.date_final.Value = New Date(2023, 5, 28, 18, 39, 48, 36)
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(679, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(84, 72)
        Me.Panel1.TabIndex = 34
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(781, 601)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.date_final)
        Me.Controls.Add(Me.date_init)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_vendas)
        Me.Controls.Add(Me.lbl_lucro)
        Me.Controls.Add(Me.lbl_custo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.Text = "CONSULTA DE LUCRO E CUSTO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_custo As Label
    Friend WithEvents lbl_lucro As Label
    Friend WithEvents lbl_vendas As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents date_init As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents date_final As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Panel1 As Panel
End Class
