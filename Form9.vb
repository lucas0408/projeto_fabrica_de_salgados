Imports System.Security.Cryptography

Public Class Form9
    Dim calc, total_desconto, calc1, calc2, calc3, calc4, calc5, calc6, calc7, calc8, calc9, calc10 As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Close()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        sql = "select * from tb_pedido_Nfeito where Endereco='" & IDE_pedido & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            lbl_nome.Text = rs.Fields(1).Value
            lbl_endereco.Text = rs.Fields(2).Value
            lbl_data.Text = rs.Fields(3).Value
            lbl_horas.Text = rs.Fields(4).Value
            lbl_pagamento.Text = rs.Fields(5).Value
            lbl_coxinha.Text = rs.Fields(6).Value
            lbl_risole.Text = rs.Fields(7).Value
            lbl_kibe.Text = rs.Fields(8).Value
            lbl_bolinho_queijo.Text = rs.Fields(9).Value
            lbl_bolinho_carne.Text = rs.Fields(10).Value
            lbl_esfiha_frango.Text = rs.Fields(11).Value
            lbl_esfiha_carne.Text = rs.Fields(12).Value
            lbl_esfiha_queijo.Text = rs.Fields(13).Value
            lbl_valor_total.Text = rs.Fields(15).Value
        Else
            MsgBox("erro")
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data As Date
        data = Date.Now
        FormatDateTime(data, DateFormat.ShortDate)
        If FormatDateTime(rs.Fields(3).Value, DateFormat.ShortTime) <> data Then
            resp = MsgBox("ESTE PEDIDO FOI REALIZADO NO DIA:" & rs.Fields(3).Value & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
            If resp = MsgBoxResult.No Then
                Call preencher()
                form3.date_time.Focus()
                form3.Show()
                MsgBox("MUDE DATA PARA A DATA DE ENTREGA E PRECIONE CADASTRAR", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
                Exit Sub
            End If
        End If
        feito = "S"
            sql = "select * from tb_estoque order by IDE_produto asc"
            rs = db.Execute(sql)
            qtd_leite = rs.Fields(2).Value
            calc3 = qtd_leite
            valor_leite = rs.Fields(3).Value
            rs.MoveNext()
            qtd_farinha_rosca = rs.Fields(2).Value
            calc2 = qtd_farinha_rosca
            valor_farinha_rosca = rs.Fields(3).Value
            rs.MoveNext()
            qtd_farinha_trigo = rs.Fields(2).Value
            calc1 = qtd_farinha_trigo
            valor_farinha_trigo = rs.Fields(3).Value
            rs.MoveNext()
            qtd_batata = rs.Fields(2).Value
            calc5 = qtd_batata
            valor_batata = rs.Fields(3).Value
            rs.MoveNext()
            qtd_caldo_galinha = rs.Fields(2).Value
            calc4 = qtd_caldo_galinha
            valor_caldo_galinha = rs.Fields(3).Value
            rs.MoveNext()
            qtd_presunto = rs.Fields(2).Value
            calc8 = qtd_presunto
            valor_presunto = rs.Fields(3).Value
            rs.MoveNext()
            qtd_queijo = rs.Fields(2).Value
            calc9 = qtd_queijo
            valor_queijo = rs.Fields(3).Value
            rs.MoveNext()
            qtd_calabresa = rs.Fields(2).Value
            calc10 = qtd_calabresa
            valor_calabresa = rs.Fields(3).Value
            rs.MoveNext()
            qtd_carne = rs.Fields(2).Value
            calc7 = qtd_carne
            valor_carne = rs.Fields(3).Value
            rs.MoveNext()
            qtd_frango = rs.Fields(2).Value
            calc6 = qtd_frango
            valor_frango = rs.Fields(3).Value


            sql = "select * from tb_gasto_produto order by Nome asc"
            rs = db.Execute(sql)

            cont = CInt(lbl_bolinho_carne.Text)
            calculo()

            rs.MoveNext()
            cont = CInt(lbl_bolinho_queijo.Text)
            calculo()

            rs.MoveNext()
            cont = CInt(lbl_coxinha.Text)
            calculo()

            rs.MoveNext()
            cont = CInt(lbl_esfiha_carne.Text)
            calculo()

            rs.MoveNext()
            cont = CInt(lbl_esfiha_frango.Text)
            calculo()

            rs.MoveNext()
            cont = CInt(lbl_esfiha_queijo.Text)
            calculo()

            rs.MoveNext()
            cont = CInt(lbl_kibe.Text)
            calculo()

            rs.MoveNext()
            cont = CInt(lbl_risole.Text)
            calculo()

            If calc1 > qtd_farinha_trigo Or calc2 > qtd_farinha_rosca Or calc3 > qtd_leite Or calc4 > qtd_caldo_galinha Or
                calc5 > qtd_batata Or calc6 > qtd_frango Or calc7 > qtd_carne Or calc8 > qtd_presunto Or
                calc9 > qtd_queijo Or calc10 > qtd_calabresa Then
                Me.Close()
                form3.Show()
                MsgBox("REPONHA O ESTOQUE COM A ULTIMA COMPRA PARA CONCLUIR O PEDIDO", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End If
            total_desconto = calc3 * valor_leite / qtd_leite
            custo_total = valor_leite - total_desconto
            sql = "update tb_estoque set Estoque='" & calc3 & "', " &
            " Preco='" & total_desconto & "' where produto= 'leite'"
            rs = db.Execute(UCase(sql))

            total_desconto = calc1 * valor_farinha_trigo / qtd_farinha_trigo
            custo_total = custo_total + valor_farinha_trigo - total_desconto
            sql = "update tb_estoque set Estoque='" & calc1 & "', " &
            " Preco='" & total_desconto & "' where produto= 'farinha de trigo'"
            rs = db.Execute(UCase(sql))

            total_desconto = calc2 * valor_farinha_rosca / qtd_farinha_rosca
            custo_total = custo_total + valor_farinha_rosca - total_desconto
            sql = "update tb_estoque set Estoque='" & calc2 & "', " &
            " Preco='" & total_desconto & "' where produto= 'farinha de rosca'"
            rs = db.Execute(UCase(sql))

            total_desconto = calc4 * valor_caldo_galinha / qtd_caldo_galinha
            custo_total = custo_total + valor_caldo_galinha - total_desconto
            sql = "update tb_estoque set Estoque='" & calc4 & "', " &
            " Preco='" & total_desconto & "' where produto= 'caldo de galinha'"
            rs = db.Execute(UCase(sql))

            total_desconto = calc5 * valor_batata / qtd_batata
            custo_total = custo_total + valor_batata - total_desconto
            sql = "update tb_estoque set Estoque='" & calc5 & "', " &
            " Preco='" & total_desconto & "' where produto= 'batata'"
            rs = db.Execute(UCase(sql))

            total_desconto = calc6 * valor_frango / qtd_frango
            custo_total = custo_total + valor_frango - total_desconto
            sql = "update tb_estoque set Estoque='" & calc6 & "', " &
            " Preco='" & total_desconto & "' where produto= 'frango'"
            rs = db.Execute(UCase(sql))

            total_desconto = calc7 * valor_carne / qtd_carne
            custo_total = custo_total + valor_carne - total_desconto
            sql = "update tb_estoque set Estoque='" & calc7 & "', " &
            " Preco='" & total_desconto & "' where produto= 'carne'"
            rs = db.Execute(UCase(sql))

            total_desconto = calc8 * valor_presunto / qtd_presunto
            custo_total = custo_total + valor_presunto - total_desconto
            sql = "update tb_estoque set Estoque='" & calc8 & "', " &
            " Preco='" & total_desconto & "' where produto= 'presunto'"
            rs = db.Execute(UCase(sql))

            total_desconto = calc9 * valor_queijo / qtd_queijo
            custo_total = custo_total + valor_queijo - total_desconto
            sql = "update tb_estoque set Estoque='" & calc9 & "', " &
            " Preco='" & total_desconto & "' where produto= 'queijo'"
            rs = db.Execute(UCase(sql))

            total_desconto = calc10 * valor_calabresa / qtd_calabresa
            custo_total = custo_total + valor_calabresa - total_desconto
            sql = "update tb_estoque set Estoque='" & calc10 & "', " &
            " Preco='" & total_desconto & "' where produto= 'calabresa'"
            rs = db.Execute(UCase(sql))

            sql = "update tb_cadastro_pedido set Feito='" & feito & "', " &
            "Custo_producao='" & custo_total & "' where Endereco='" & lbl_endereco.Text & "'"
            rs = db.Execute(UCase(sql))

            pedido()
            Me.Close()
            form3.Show()
    End Sub
    Sub calculo()


        calc1 = calc1 - (rs.Fields(1).Value / 100 * cont) 'farinha trigo
        calc2 = calc2 - (rs.Fields(2).Value / 100 * cont)  'farinha de rosca
        calc3 = calc3 - (rs.Fields(3).Value / 100 * cont)   'leite
        calc4 = calc4 - (rs.Fields(4).Value / 100 * cont)   'caldo de galinha
        calc5 = calc5 - (rs.Fields(5).Value / 100 * cont)    'batata
        calc6 = calc6 - (rs.Fields(6).Value / 100 * cont)    'frango
        calc7 = calc7 - (rs.Fields(7).Value / 100 * cont)     'carne
        calc8 = calc8 - (rs.Fields(8).Value / 100 * cont)     'presunto
        calc9 = calc9 - (rs.Fields(9).Value / 100 * cont)      'queijo
        calc10 = calc10 - (rs.Fields(10).Value / 100 * cont)    'calabresa 

        Return
    End Sub

End Class