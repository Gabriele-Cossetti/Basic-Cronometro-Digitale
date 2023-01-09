Imports System.Threading

Public Class Form1
    Dim Ore As Integer
    Dim Minuti As Integer
    Dim Secondi As Integer
    Dim Centesimi As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer1.Interval = 10     'in millisecondi con 1000 = 1 secondo, 100 decimi di secondo, 10 centesimi di secondo
        Ore = 0
        Minuti = 0
        Secondi = 0
        Centesimi = 0
        Label1.Text = Ore
        Label3.Text = Minuti
        Label5.Text = Secondi
        Label6.Text = Centesimi
        If Timer1.Enabled = False Then
            Button3.Enabled = False
            Button2.Enabled = False
            Button1.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Centesimi += 1
        If Centesimi = "100" Then
            Centesimi = 0
            Secondi += 1
        End If
        If Secondi = "60" Then
            Secondi = 0
            Minuti += 1
        End If
        If Minuti = "60" Then
            Minuti = 0
            Ore += 1
        End If
        If Ore = "24" Then
            Ore = 0
        End If
        Me.Invalidate()
        Label1.Text = Ore
        Label3.Text = Minuti
        Label5.Text = Secondi
        Label6.Text = Centesimi
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Start()
        If Timer1.Enabled = True Then
            Button1.Enabled = False
            Button2.Enabled = True
            Button3.Enabled = False
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Timer1.Stop()
        If Timer1.Enabled = False Then
            Button3.Enabled = True
            Button2.Enabled = False
            Button1.Enabled = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = False
        Timer1.Stop()
        Ore = 0
        Minuti = 0
        Secondi = 0
        Centesimi = 0
        Label1.Text = Ore
        Label3.Text = Minuti
        Label5.Text = Secondi
        Label6.Text = Centesimi
        Me.Invalidate()
        If Timer1.Enabled = False Then
            Button3.Enabled = False
            Button2.Enabled = False
            Button1.Enabled = True
        End If
    End Sub
End Class
