Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Linq.Expressions

Public Class Form5
    Dim data, data1, data_prog, data3, data2 As Date
    Dim horas As Double
    Dim total As Integer
    Dim lucro, custo, vendas As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        form3.Show()
    End Sub

    Dim nome, produto As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "select * from tb_pedido_feito order by IDE_pedido asc"
        rs = db.Execute(sql)
        If rs.EOF() = True Then
            MsgBox("errou!")
        End If
        custo = 0
        vendas = 0
        lucro = 0
        cont = 0
        data3 = date_init.Text
        data2 = date_final.Text
        data2 = data2.AddDays(+1)
        Do While rs.EOF = False
            If rs.Fields(3).Value = data2 Then
                Exit Do
            End If
            data_prog = rs.Fields(3).Value
            If data_prog = data3 Then
                custo = custo + rs.Fields(17).Value
                vendas = vendas + rs.Fields(15).Value
                lucro = lucro + (rs.Fields(15).Value - rs.Fields(17).Value)
                cont = cont + 1
            ElseIf cont <> 0 Then
                data3 = data3.AddDays(-1)
                custo = custo + rs.Fields(17).Value
                vendas = vendas + rs.Fields(15).Value
                lucro = lucro + (rs.Fields(15).Value - rs.Fields(17).Value)
                cont = cont + 1
            End If
            rs.MoveNext()
        Loop
        lbl_custo.Text = Math.Round(custo, 2)
        lbl_lucro.Text = Math.Round(lucro, 2)
        lbl_vendas.Text = Math.Round(vendas, 2)

    End Sub



    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        cont = 0
        data1 = Format(Now, "dd/MM/yyyy")
        data = Format(Now, "dd/MM/yyyy")
        sql = "select * from tb_pedido_feito order by IDE_pedido asc"
        rs = db.Execute(sql)
        data = rs.Fields(3).Value
        Do While rs.EOF = False
            If data = data1.AddDays(-30) Then
                Exit Do
            End If
            data_prog = rs.Fields(3).Value
            If data_prog <> data Then
                With DataGridView1
                    .Rows.Add(Format(data, "dd/MM/yyyy"), CStr(Math.Round(vendas, 2)) + " R$", CStr(Math.Round(custo, 2)) + " R$", CStr(Math.Round(lucro, 2)) + " R$", cont)
                End With
                data = data_prog
                custo = 0
                vendas = 0
                lucro = 0
                cont = 0
            End If
            custo = custo + rs.Fields(17).Value
            vendas = vendas + rs.Fields(15).Value
            lucro = lucro + (rs.Fields(15).Value - rs.Fields(17).Value)
            cont = cont + 1
            rs.MoveNext()
        Loop
        With DataGridView1
            .Rows.Add(Format(data, "dd/MM/yyyy"), CStr(Math.Round(vendas, 2)) + " R$", CStr(Math.Round(custo, 2)) + " R$", CStr(Math.Round(lucro, 2)) + " R$", cont)
        End With

    End Sub

End Class