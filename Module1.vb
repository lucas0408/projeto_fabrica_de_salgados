Module Module1
    Public cont, contresp As Integer
    Public diretorio, feito, sql, aux_cpf, resp, chave, fone, user, senha, produto, nome_salgado, IDE_pedido As String
    Public db As New ADODB.Connection
    Public valor_farinha_trigo, valor_farinha_rosca, valor_leite, valor_carne, valor_frango, valor_caldo_galinha, valor_batata,
        valor_presunto, valor_queijo, valor_calabresa, qtd_farinha_trigo, qtd_farinha_rosca, qtd_leite, qtd_carne, qtd_frango, qtd_caldo_galinha, qtd_batata,
        qtd_presunto, qtd_queijo, qtd_calabresa, custo, custo_risole, custo_coxinha, custo_kibe, custo_bolinho_queijo, custo_bolinho_carne,
        custo_esfiha_queijo, custo_esfiha_carne, custo_esfiha_frango, custo_total As Double
    'variavel pra abrir a conexao
    Public rs As New ADODB.Recordset
    Public dir_banco = Application.StartupPath & "\Banco\Database4.mdb"

    Sub conectar_banco()
        Try

            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dir_banco) 'padrao do acess
            ' MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Catch ex As Exception

            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub


    Sub estoque()
        sql = "select * from tb_estoque order by IDE_produto asc"
        rs = db.Execute(sql)
        With form3.DataGridView2
            .Rows.Clear()
            Do While rs.EOF = False
                If rs.Fields(1).Value = "leite" Then
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, CStr(rs.Fields(2).Value) + " L")
                Else
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, CStr(rs.Fields(2).Value) + " kg")
                End If
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub pedido()
        sql = "select * from tb_pedido_Nfeito order by IDE_pedido asc"
        rs = db.Execute(sql)
        With form3.DataGridView1
            .Rows.Clear()
            Dim agora As Date
            agora = Format(Now, "dd/MM/yyyy")
            Do While rs.EOF = False
                If rs.Fields(3).Value = agora Then
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, FormatDateTime(rs.Fields(4).Value, DateFormat.ShortTime),
                FormatDateTime(rs.Fields(3).Value, DateFormat.ShortDate), CStr(rs.Fields(15).Value) + "R$",
                rs.Fields(14).Value, Nothing, Nothing)
                End If
                rs.MoveNext()
            Loop
            cont = 0
        End With
    End Sub

    Sub estoque_admin()
        sql = "select * from tb_estoque order by IDE_produto asc"
        rs = db.Execute(sql)

        With Form4.DataGridView2
            .Rows.Clear()
            Do While rs.EOF = False
                If rs.Fields(1).Value = "leite" Then
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, CStr(rs.Fields(2).Value) + " L", rs.Fields(3).Value, Nothing)

                Else
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, CStr(rs.Fields(2).Value) + " KG/L", rs.Fields(3).Value, Nothing)

                End If
                rs.MoveNext()

            Loop
        End With
    End Sub
    Sub limpar_dados()
        Try
            With Form2
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_cep.Clear()
                .txt_data.Value = Now
                .txt_endereco.Clear()
                .txt_comp.Clear()
                .txt_bairro.Clear()
                .txt_cidade.Clear()
                .txt_uf.Clear()
                .txt_fone.Clear()
                .txt_senha.Clear()
                .txt_chave.Clear()
                .cmb_tipo.ResetText()
                .txt_cpf.Focus()
            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub carregar_dados()
        Try
            sql = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(sql)
            With Form2.dgv_cadastro
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

    Sub limpar_login()
        With Form1
            .txt_login.Clear()
            .txt_senha_login.Clear()
        End With
    End Sub
    Sub preencher()
        form3.txt_nome_cliente.Text = rs.Fields(1).Value
        form3.txt_endereco.Text = rs.Fields(2).Value
        form3.date_time.Value = rs.Fields(3).Value
        form3.txt_horario.Text = rs.Fields(4).Value
        form3.cmb_pagamento.Text = rs.Fields(5).Value
        form3.num_coxinha.Value = rs.Fields(6).Value
        form3.num_risole.Value = rs.Fields(7).Value
        form3.num_kibe.Value = rs.Fields(8).Value
        form3.num_bolinho_queijo.Value = rs.Fields(9).Value
        form3.num_bolinho_carne.Value = rs.Fields(10).Value
        form3.num_esfiha_frango.Value = rs.Fields(11).Value
        form3.num_esfiha_carne.Value = rs.Fields(12).Value
        form3.num_esfiha_queijo.Value = rs.Fields(13).Value
        form3.lbl_total_salgados.Text = rs.Fields(14).Value
        form3.txt_valor_total.Text = rs.Fields(15).Value
        form3.TabControl1.SelectTab(1)
    End Sub
End Module



