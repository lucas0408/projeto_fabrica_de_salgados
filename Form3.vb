Imports System.Security.AccessControl
Imports Bunifu.Framework.[Lib]

Public Class form3
    Dim num_salgado_string, nome_salgado, endereco As String
    Dim num_salgado, preco_coxinha, preco_risole, preco_kibe, preco_bolinho_queijo,
    preco_bolinho_carne, preco_esfiha_frango, preco_esfiha_carne, preco_esfiha_queijo, toatl_salgado As Double

    Private Sub validar_conta()
        resp = InputBox("DIGITE A SENHA DO ADMIN PARA CONTINUAR", "ATENÇÃO!")
        sql = "select * from tb_cadastro where senha='" & resp & "'"
        rs = db.Execute(sql)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_controle_produtos.Click
        validar_conta()
        If rs.EOF = False Then
            If rs.Fields(12).Value = "ADMINISTRADOR" Then
                Me.Hide()
                Form8.Show()
            Else
                MsgBox("APENAS O ADMINISTRADOR TEM ACESSO A ESSA FUNÇÃO SO SOFTWARE", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "AVISO")
            End If
        Else
            MsgBox("SENHA NÃO ENCONTRADA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "AVISO")
        End If
    End Sub

    Private Sub btn_controle_estoque_Click(sender As Object, e As EventArgs) Handles btn_controle_estoque.Click
        validar_conta()
        If rs.EOF = False Then
            If rs.Fields(12).Value = "ADMINISTRADOR" Then
                Me.Hide()
                Form4.Show()
            Else
                MsgBox("APENAS O ADMINISTRADOR TEM ACESSO A ESSA FUNÇÃO SO SOFTWARE", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "AVISO")
            End If
        Else
            MsgBox("SENHA NÃO ENCONTRADA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "AVISO")
        End If
    End Sub


    Private Sub btn_consulta_lucro_Click(sender As Object, e As EventArgs) Handles btn_consulta_lucro.Click
        validar_conta()
        If rs.EOF = False Then
            If rs.Fields(12).Value = "ADMINISTRADOR" Then
                Me.Hide()
                Form5.Show()
            Else
                MsgBox("APENAS O ADMINISTRADOR TEM ACESSO A ESSA FUNÇÃO SO SOFTWARE", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "AVISO")
            End If
        Else
            MsgBox("SENHA NÃO ENCONTRADA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "AVISO")
        End If
    End Sub



    Private Sub btn_cadastro_funcionario_Click(sender As Object, e As EventArgs) Handles btn_cadastro_funcionario.Click
        validar_conta()
        If rs.EOF = False Then
            If rs.Fields(12).Value = "ADMINISTRADOR" Then
                Me.Hide()
                Form2.Show()
            Else
                MsgBox("APENAS O ADMINISTRADOR TEM ACESSO A ESSA FUNÇÃO SO SOFTWARE", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "AVISO")
            End If
        Else
            MsgBox("SENHA NÃO ENCONTRADA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "AVISO")
        End If

    End Sub



    Private Sub form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        estoque()
        pedido()
        sql = "select * from tb_estoque order by IDE_produto asc"
            rs = db.Execute(sql)
            If rs.Fields(2).Value < 1 Then
                aviso()
            End If
            rs.MoveNext()
            If rs.Fields(2).Value < 1 Then
                aviso()
            End If
            rs.MoveNext()
            If rs.Fields(2).Value < 1 Then
                aviso()
            End If
            rs.MoveNext()
            If rs.Fields(2).Value < 1 Then
                aviso()
            End If
            rs.MoveNext()
        If rs.Fields(2).Value < 0.1 Then
            aviso()
        End If
        rs.MoveNext()
        If rs.Fields(2).Value < 0.5 Then
            aviso()
        End If
        rs.MoveNext()
        If rs.Fields(2).Value < 0.5 Then
            aviso()
        End If
        rs.MoveNext()
        If rs.Fields(2).Value < 0.5 Then
            aviso()
        End If
        rs.MoveNext()
            If rs.Fields(2).Value < 1 Then
                aviso()
            End If
            rs.MoveNext()
            If rs.Fields(2).Value < 1 Then
                aviso()

            End If

            If lbl_atencao.Text = "" Then
                lbl_atencao.Text = "SITUAÇÃO ESTOQUE: NORMAL"
            End If

            sql = "select * from tb_gasto_produto order by Nome asc"
        rs = db.Execute(sql)
        preco_bolinho_carne = rs.Fields(11).Value
        rs.MoveNext()
        preco_bolinho_queijo = rs.Fields(11).Value
        rs.MoveNext()
        preco_coxinha = rs.Fields(11).Value
        rs.MoveNext()
        preco_esfiha_carne = rs.Fields(11).Value
        rs.MoveNext()
        preco_esfiha_frango = rs.Fields(11).Value
        rs.MoveNext()
        preco_esfiha_queijo = rs.Fields(11).Value
        rs.MoveNext()
        preco_kibe = rs.Fields(11).Value
        rs.MoveNext()
        preco_risole = rs.Fields(11).Value
    End Sub

    Private Sub aviso()
        If contresp = 0 Then
            MsgBox("ATENÇÃO NIVEL DE ESTOQUE CRITICO", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            contresp = contresp + 1
        End If
        lbl_atencao.Text = "ATENÇÃO ESTOQUE CRITICO"

    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cont = 0 Then
            sql = "select * from tb_pedido_Nfeito order by IDE_pedido asc"
            rs = db.Execute(sql)
            With DataGridView1
                .Rows.Clear()
                cont = 1
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, FormatDateTime(rs.Fields(4).Value, DateFormat.ShortTime),
                    FormatDateTime(rs.Fields(3).Value, DateFormat.ShortDate), CStr(rs.Fields(15).Value) + "R$",
                    rs.Fields(14).Value, Nothing, Nothing)


                    rs.MoveNext()
                    cont = cont + 1
                Loop
                cont = 1
            End With
            Button1.BackColor = Color.Green
        Else
            pedido()
            Button1.BackColor = Color.White
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click


        custo_total = 0
        feito = "N"
        sql = "select * from tb_cadastro_pedido where Endereco='" & txt_endereco.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = True Then
            sql = "Insert into tb_cadastro_pedido (Nome_cliente, Endereco, Data_entrega, Horas_entrega, Forma_pagamento,Qtd_coxinha, Qtd_risole, Qtd_kibe, Qtd_bolinho_queijo, Qtd_bolinho_carne, Qtd_esfiha_frango, Qtd_esfiha_carne, Qtd_esfiha_queijo, Total_salgados, Valor_total, Feito, Custo_producao) values ( '" & txt_nome_cliente.Text & "' ," &
               "'" & txt_endereco.Text & "', '" & date_time.Text & "'," &
              "'" & txt_horario.Text & "', '" & cmb_pagamento.Text & "', '" & num_coxinha.Value & "', " &
             "'" & num_risole.Value & "', '" & num_kibe.Value & "', '" & num_bolinho_queijo.Value & "', " &
            "'" & num_bolinho_carne.Value & "', '" & num_esfiha_frango.Value & "', '" & num_esfiha_carne.Value & "', " &
            "'" & num_esfiha_queijo.Value & "', '" & lbl_total_salgados.Text & "', '" & txt_valor_total.Text & "', '" & feito & "', '" & custo_total & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("CADASTRO REALIZADO COM SUCESSO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = "update tb_cadastro_pedido set Nome_cliente='" & txt_nome_cliente.Text & "', " &
                                                "Endereco='" & txt_endereco.Text & "', " &
                                                "Data_entrega ='" & date_time.Value & "', " &
                                                "Horas_entrega='" & txt_horario.Text & "', " &
                                                "Forma_pagamento='" & cmb_pagamento.Text & "', " &
                                                "Qtd_coxinha='" & num_coxinha.Value & "', " &
                                                "Qtd_risole='" & num_risole.Value & "', " &
                                                "Qtd_kibe='" & num_kibe.Value & "', " &
                                                "Qtd_bolinho_queijo='" & num_bolinho_queijo.Value & "', " &
                                                "Qtd_bolinho_carne='" & num_bolinho_carne.Value & "', " &
                                                "Qtd_esfiha_frango='" & num_esfiha_frango.Value & "', " &
                                                "Qtd_esfiha_carne='" & num_esfiha_carne.Value & "', " &
                                                "Qtd_esfiha_queijo='" & num_esfiha_queijo.Value & "', " &
                                                "Total_salgados='" & lbl_total_salgados.Text & "', " &
                                                "Valor_total='" & txt_valor_total.Text & "', " &
                                                "Feito='" & feito & "', " &
                                                "Custo_producao='" & custo_total & "' where Endereco='" & txt_endereco.Text & "'"
            rs = db.Execute(UCase(sql))
            MsgBox("CADASTRO MUDADO COM SUCESSO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
        pedido()
        txt_endereco.Text = ""
        txt_horario.Text = ""
        txt_nome_cliente.Text = ""
        lbl_total_salgados.Text = ""
        txt_valor_total.Text = ""
        num_bolinho_carne.Value = 0
        num_bolinho_queijo.Value = 0
        num_coxinha.Value = 0
        num_esfiha_carne.Value = 0
        num_esfiha_frango.Value = 0
        num_esfiha_queijo.Value = 0
        num_kibe.Value = 0
        num_risole.Value = 0

    End Sub

    Private Sub mudar_total_salgado()
        num_salgado = num_bolinho_carne.Value + num_bolinho_queijo.Value + num_coxinha.Value + num_esfiha_carne.Value + num_esfiha_frango.Value + num_esfiha_queijo.Value + num_kibe.Value + num_risole.Value
        num_salgado_string = CStr(num_salgado)
        lbl_total_salgados.Text = num_salgado_string
        toatl_salgado = preco_risole / 100 * num_risole.Value + preco_coxinha / 100 * num_coxinha.Value + preco_kibe / 100 * num_kibe.Value +
            preco_bolinho_carne / 100 * num_bolinho_carne.Value + preco_bolinho_queijo / 100 * num_bolinho_queijo.Value + preco_esfiha_carne / 100 * num_esfiha_carne.Value +
            preco_esfiha_frango / 100 * num_esfiha_frango.Value + preco_esfiha_queijo / 100 * num_esfiha_queijo.Value
        txt_valor_total.Text = CStr(toatl_salgado) + " R$"
    End Sub
    Private Sub num_risole_ValueChanged(sender As Object, e As EventArgs) Handles num_risole.ValueChanged
        mudar_total_salgado()
    End Sub

    Private Sub num_kibe_ValueChanged(sender As Object, e As EventArgs) Handles num_kibe.ValueChanged

        mudar_total_salgado()
    End Sub

    Private Sub num_bolinho_queijo_ValueChanged(sender As Object, e As EventArgs) Handles num_bolinho_queijo.ValueChanged

        mudar_total_salgado()
    End Sub


    Private Sub num_bolinho_carne_ValueChanged(sender As Object, e As EventArgs) Handles num_bolinho_carne.ValueChanged

        mudar_total_salgado()
    End Sub

    Private Sub num_esfiha_frango_ValueChanged(sender As Object, e As EventArgs) Handles num_esfiha_frango.ValueChanged
        mudar_total_salgado()
    End Sub

    Private Sub num_esfiha_carne_ValueChanged(sender As Object, e As EventArgs) Handles num_esfiha_carne.ValueChanged
        mudar_total_salgado()
    End Sub

    Private Sub num_esfiha_queijo_ValueChanged(sender As Object, e As EventArgs) Handles num_esfiha_queijo.ValueChanged
        mudar_total_salgado()
    End Sub

    Private Sub num_coxinha_ValueChanged(sender As Object, e As EventArgs) Handles num_coxinha.ValueChanged
        mudar_total_salgado()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            If .CurrentRow.Cells(8).Selected = True Then
                resp = MsgBox("DESEJA EXCLUIR PEDIDO DE NUERO:" & .CurrentRow.Cells(0).Value & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_cadastro_pedido where (Endereco='" & .CurrentRow.Cells(0).Value & "')"
                    rs = db.Execute(sql)
                    Call pedido()
                    Exit Sub
                End If
            End If
                If .CurrentRow.Cells(6).Selected = True Then
                IDE_pedido = .CurrentRow.Cells(1).Value
                Form9.Show()
                Me.Hide()
                Exit Sub
            ElseIf .CurrentRow.Cells(7).Selected = True Then
                endereco = .CurrentRow.Cells(1).Value
                sql = "select * from tb_pedido_Nfeito where Endereco='" & endereco & "'"
                rs = db.Execute(sql)
                Call preencher()
            End If
        End With
    End Sub

End Class