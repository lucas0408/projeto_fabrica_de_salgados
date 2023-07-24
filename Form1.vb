Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub lbl_esqueceu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_esqueceu.LinkClicked
        user = InputBox("digite nome", "ATENÇÃO!")
        sql = "select * from tb_cadastro where nome='" & user & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            senha = rs.Fields(10).Value
            fone = rs.Fields(9).Value
            chave = rs.Fields(11).Value
            Process.Start("https://api.callmebot.com/whatsapp.php?phone=" & fone & "&text='prezado(a) " & user & " sua senha é: " & senha & "'&apikey=" & chave & " ")
        Else
            MsgBox("conta invalida", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sql = "select * from tb_cadastro where cpf='" & txt_login.Text & "' or nome='" & txt_login.Text & "' and senha='" & txt_senha_login.Text & "'"
            rs = db.Execute(sql)
            If rs.Fields(12).Value = "ADMINISTRADOR" Then
                With form3
                    .TabControl1.TabPages.Add(.TabPage4)
                End With
                Me.Hide()
                form3.Show()
                limpar_login
            ElseIf rs.EOF = False Then
                Me.Hide()
                form3.Show()
                limpar_login
            Else
                MsgBox("Senha ou usuário incorreto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Login não funcionando", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
    Private Sub cbx_ocultar_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ocultar.CheckedChanged
        If cbx_ocultar.Checked Then
            txt_senha_login.PasswordChar = ""
        Else
            txt_senha_login.PasswordChar = "•"
        End If
    End Sub
    Private Sub txt_login_GotFocus(sender As Object, e As EventArgs) Handles txt_login.GotFocus
        With form3
            .TabControl1.TabPages.Remove(.TabPage4)
        End With
        With Me
            .txt_login.Clear()
        End With
    End Sub
    Private Sub txt_senha_login_GotFocus(sender As Object, e As EventArgs) Handles txt_senha_login.GotFocus
        With Me
            .txt_senha_login.Clear()
        End With
        txt_senha_login.PasswordChar = "•"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class