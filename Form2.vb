Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
        With Me
            .txt_cpf.Focus()
        End With
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_nome.Focus()
            Else
                txt_nome.Text = rs.Fields(1).Value
                txt_cep.Text = rs.Fields(2).Value
                txt_data.Value = rs.Fields(3).Value
                txt_endereco.Text = rs.Fields(4).Value
                txt_comp.Text = rs.Fields(5).Value
                txt_bairro.Text = rs.Fields(6).Value
                txt_cidade.Text = rs.Fields(7).Value
                txt_uf.Text = rs.Fields(8).Value
                txt_fone.Text = rs.Fields(9).Value
                txt_senha.Text = rs.Fields(10).Value
                txt_chave.Text = rs.Fields(11).Value
                cmb_tipo.Text = rs.Fields(12).Value
            End If
        Catch ex As Exception
            MsgBox("Erro ao consultar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        Try
            limpar_dados()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cadastro.CellContentClick
        Try
            With dgv_cadastro
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    TabControl1.SelectTab(0) 'Selecione a aba dados pessoais
                    sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_cep.Text = rs.Fields(2).Value
                        txt_data.Value = rs.Fields(3).Value
                        txt_endereco.Text = rs.Fields(4).Value
                        txt_comp.Text = rs.Fields(5).Value
                        txt_bairro.Text = rs.Fields(6).Value
                        txt_cidade.Text = rs.Fields(7).Value
                        txt_uf.Text = rs.Fields(8).Value
                        txt_fone.Text = rs.Fields(9).Value
                        txt_senha.Text = rs.Fields(10).Value
                        txt_chave.Text = rs.Fields(11).Value
                        cmb_tipo.Text = rs.Fields(12).Value
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                      "o CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete * from tb_cadastro where cpf='" & aux_cpf & "'"
                            rs = db.Execute(sql)
                            carregar_dados()
                        End If
                    End If

                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpf.MaskInputRejected

    End Sub

    Private Sub bnt_salvar_Click(sender As Object, e As EventArgs) Handles bnt_salvar.Click
        Try
            sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_cadastro set nome='" & txt_nome.Text & "', " &
                      "cep='" & txt_cep.Text & "', " &
                      "data_nasc='" & txt_data.Value & "', " &
                      "endereco='" & txt_endereco.Text & "', " &
                      "num_comp='" & txt_comp.Text & "', " &
                      "bairro='" & txt_bairro.Text & "', " &
                      "cidade='" & txt_cidade.Text & "', " &
                      "uf='" & txt_uf.Text & "', " &
                      "fone='" & txt_fone.Text & "', " &
                      "senha='" & txt_senha.Text & "', " &
                      "chave_acesso='" & txt_chave.Text & "', " &
                      "ADMINISTRADOR='" & cmb_tipo.Text & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_cadastro values('" & txt_cpf.Text & "', " &
                      "'" & txt_nome.Text & "','" & txt_cep.Text & "', " &
                      "'" & txt_data.Value.Date & "','" & txt_endereco.Text & "', " &
                      "'" & txt_comp.Text & "','" & txt_bairro.Text & "', " &
                      "'" & txt_cidade.Text & "','" & txt_uf.Text & "', " &
                      "'" & txt_fone.Text & "', '" & txt_senha.Text & "', '" & txt_chave.Text & "' , '" & cmb_tipo.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                'carregar_dados()
                ' limpar_dados()
            End If
            carregar_dados()
            limpar_dados()
        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_busca_cpf_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_cpf.TextChanged
        Try
            sql = "select * from tb_cadastro where cpf like '%" & txt_busca_cpf.Text & "%'"
            rs = db.Execute(sql)
            With dgv_cadastro
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripTextBox2_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox2.TextChanged
        Try
            sql = "select * from tb_cadastro where nome like '%" & ToolStripTextBox2.Text & "%'"
            rs = db.Execute(sql)
            With dgv_cadastro
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_fone_GotFocus(sender As Object, e As EventArgs) Handles txt_fone.GotFocus
        With Me
            .txt_fone.Clear()
        End With
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class