Imports System.Linq.Expressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form4
    Dim produto_estoque, op As String
    Dim qtd_estoque, valor_estoque, valor_estoque_cmb, estoque_cmb As Double

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        estoque_admin()
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        cont = 0
        Do While cont <> 7
            If ComboBox2.Text <> "" Then
                produto_estoque = ComboBox2.Text
                estoque_cmb = CDbl(txt_5.Text)
                valor_estoque_cmb = CDbl(txt_k_5.Text)
                inserir_tabela()
                ComboBox2.Text = ""
                txt_k_5.Text = ""
                txt_5.Text = ""
            ElseIf ComboBox3.Text <> "" Then
                produto_estoque = ComboBox3.Text
                estoque_cmb = CDbl(txt_6.Text)
                valor_estoque_cmb = CDbl(txt_k_6.Text)
                inserir_tabela()
                ComboBox3.Text = ""
                txt_k_6.Text = ""
                txt_6.Text = ""
            ElseIf ComboBox5.Text <> "" Then
                produto_estoque = ComboBox5.Text
                estoque_cmb = CDbl(txt_4.Text)
                valor_estoque_cmb = CDbl(txt_k_4.Text)
                inserir_tabela()
                ComboBox5.Text = ""
                txt_k_4.Text = ""
                txt_4.Text = ""
            ElseIf ComboBox7.Text <> "" Then
                produto_estoque = ComboBox7.Text
                estoque_cmb = CDbl(txt_3.Text)
                valor_estoque_cmb = CDbl(txt_k_3.Text)
                inserir_tabela()
                ComboBox7.Text = ""
                txt_k_7.Text = ""
                txt_7.Text = ""
            ElseIf ComboBox8.Text <> "" Then
                produto_estoque = ComboBox8.Text
                estoque_cmb = CDbl(txt_2.Text)
                valor_estoque_cmb = CDbl(txt_k_2.Text)
                inserir_tabela()
                ComboBox8.Text = ""
                txt_k_2.Text = ""
                txt_2.Text = ""
            ElseIf ComboBox6.Text <> "" Then
                produto_estoque = ComboBox6.Text
                estoque_cmb = CDbl(txt_1.Text)
                valor_estoque_cmb = CDbl(txt_k_1.Text)
                inserir_tabela()
                ComboBox6.Text = ""
                txt_k_1.Text = ""
                txt_1.Text = ""
            ElseIf ComboBox1.Text <> "" Then
                produto_estoque = ComboBox6.Text
                estoque_cmb = CDbl(txt_7.Text)
                valor_estoque_cmb = CDbl(txt_k_7.Text)
                inserir_tabela()
                ComboBox6.Text = ""
                txt_k_7.Text = ""
                txt_7.Text = ""
            End If
            cont = cont + 1
        Loop
        contresp = 0
    End Sub

    Private Sub inserir_tabela()
        sql = "select * from tb_estoque where produto= '" & produto_estoque & "'"
        rs = db.Execute(sql)
        qtd_estoque = rs.Fields(2).Value
        valor_estoque = rs.Fields(3).Value
        If RadioButton1.Checked = True Then
            op = RadioButton1.Text
            qtd_estoque = qtd_estoque + estoque_cmb
            valor_estoque = valor_estoque + valor_estoque_cmb
        ElseIf RadioButton2.Checked = True Then
            op = RadioButton2.Text
            qtd_estoque = qtd_estoque - estoque_cmb
            valor_estoque = valor_estoque - valor_estoque_cmb
        Else
            MsgBox("prencha se vai adicionar ou retirar", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
        resp = MsgBox("deseja " & op & " do estoque", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
        If resp = vbYes Then
            sql = "update tb_estoque set estoque='" & qtd_estoque & "'," &
        "preco='" & valor_estoque & "' where produto='" & produto_estoque & "'"
            rs = db.Execute(sql)
            estoque()
            estoque_admin()
        End If
        Return


    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        With DataGridView2
            If .CurrentRow.Cells(4).Selected = True Then
                ComboBox6.Text = .CurrentRow.Cells(1).Value
                TabControl1.SelectTab(1)
            End If
        End With
    End Sub
End Class