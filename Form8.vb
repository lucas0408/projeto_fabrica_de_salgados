Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "update tb_gasto_produto set Farinha_trigo='" & txt_farinha_trigo.Text & "', " &
                    "Farinha_rosca='" & txt_farinha_rosca.Text & "', " &
                    "Leite='" & txt_leite.Text & "', " &
                    "Caldo_galinha='" & txt_caldo.Text & "', " &
                    "Batata='" & txt_batata.Text & "', " &
                    "Frango='" & txt_frango.Text & "', " &
                    "Carne='" & txt_carne.Text & "', " &
                    "Presunto='" & txt_presunto.Text & "', " &
                    "Queijo='" & txt_queijo.Text & "', " &
                    "Calabresa='" & txt_calabresa.Text & "', " &
                    "preco= '" & txt_preco_cento.Text & "'  where Nome='" & lbl_nome_salgado.Text & "'"
        rs = db.Execute(UCase(sql))
        MsgBox("INFORMAÇÕES ALTERADAS COM SUCESSO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        txt_farinha_trigo.Text = ""
        txt_farinha_rosca.Text = ""
        txt_leite.Text = ""
        txt_caldo.Text = ""
        txt_batata.Text = ""
        txt_frango.Text = ""
        txt_carne.Text = ""
        txt_presunto.Text = ""
        txt_queijo.Text = ""
        txt_calabresa.Text = ""
        txt_preco_cento.Text = ""
    End Sub

    Private Sub btn_bolinho_carne_CheckedChanged(sender As Object, e As EventArgs) Handles btn_bolinho_carne.CheckedChanged
        lbl_nome_salgado.Text = "bolinho de carne"
        busca_banco()
    End Sub

    Private Sub btn_bolinho_queijo_CheckedChanged(sender As Object, e As EventArgs) Handles btn_bolinho_queijo.CheckedChanged
        lbl_nome_salgado.Text = "bolinho de queijo"
        busca_banco()
    End Sub

    Private Sub btn_risole_CheckedChanged(sender As Object, e As EventArgs) Handles btn_risole.CheckedChanged
        lbl_nome_salgado.Text = "risole"
        busca_banco()
    End Sub

    Private Sub btn_coxinha_CheckedChanged(sender As Object, e As EventArgs) Handles btn_coxinha.CheckedChanged
        lbl_nome_salgado.Text = "coxinha"
        busca_banco()
    End Sub

    Private Sub btn_kibe_CheckedChanged(sender As Object, e As EventArgs) Handles btn_kibe.CheckedChanged
        lbl_nome_salgado.Text = "kibe"
        busca_banco()
    End Sub

    Private Sub btn_esfiha_carne_CheckedChanged(sender As Object, e As EventArgs) Handles btn_esfiha_carne.CheckedChanged
        lbl_nome_salgado.Text = "esfiha de carne"
        busca_banco()
    End Sub

    Private Sub btn_esfiha_frango_CheckedChanged(sender As Object, e As EventArgs) Handles btn_esfiha_frango.CheckedChanged
        lbl_nome_salgado.Text = "esfiha de frango"
        busca_banco()
    End Sub

    Private Sub btn_esfiha_queijo_CheckedChanged(sender As Object, e As EventArgs) Handles btn_esfiha_queijo.CheckedChanged
        lbl_nome_salgado.Text = "esfiha de queijo"
        busca_banco()

    End Sub

    Private Sub busca_banco()
        sql = "select * from tb_gasto_produto where Nome= '" & lbl_nome_salgado.Text & "'"
        rs = db.Execute(sql)
        txt_farinha_trigo.Text = rs.Fields(1).Value
        txt_farinha_rosca.Text = rs.Fields(2).Value
        txt_leite.Text = rs.Fields(3).Value
        txt_caldo.Text = rs.Fields(4).Value
        txt_batata.Text = rs.Fields(5).Value
        txt_frango.Text = rs.Fields(6).Value
        txt_carne.Text = rs.Fields(7).Value
        txt_presunto.Text = rs.Fields(8).Value
        txt_queijo.Text = rs.Fields(9).Value
        txt_calabresa.Text = rs.Fields(10).Value
        txt_preco_cento.Text = rs.Fields(11).Value
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Close()
    End Sub
End Class


