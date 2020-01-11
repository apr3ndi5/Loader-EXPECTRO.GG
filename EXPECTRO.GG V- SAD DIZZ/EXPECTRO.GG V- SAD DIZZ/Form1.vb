Imports System.Net
Imports System.Management


Public Class Form1
    Function GetHDSerial() As String
        Dim strHDSerial As String = String.Empty
        Dim index As Integer = 0
        Dim Data As String
        Dim query As New SelectQuery("Win32_DiskDrive")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        Try
            For Each info In search.Get()
                Data = info("SerialNumber")
                If Data.Contains(" ") Then
                    Return Data.Replace(" ", "")
                Else
                    Return Data
                End If
            Next
        Catch ex As Exception
            strHDSerial = "Error67"
        End Try
    End Function

    Dim GoAcesss As New WebClient
    Dim LinkServidor As String = "Seu site"
    Public DiasVIP As String
    Public HDVIP As String
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Dim Resposta As String =
        'GoAcesss.DownloadString(LinkServidor & "Seila.php?user=" &
        'GameBoosterTextBoxRound1.Text & "&pass=" & GameBoosterTextBoxRound2.Text & "&hdi=" & AES_Encrypt(GetHDSerial(), 338))
        Dim Resposta As String =
        GoAcesss.DownloadString(LinkServidor & "Seila.php?user=" &
        user.Text & "&pass=" & pass.Text & "&hdi=" & AES_Encrypt(GetHDSerial(), 338))
        Label1.Text = Resposta
        If Resposta.Contains("OK") Then
            Dim Parte As Array
            Parte = Resposta.Split("|")
            If AES_Encrypt(GetHDSerial(), 338) = Parte(1).ToString.Replace(" ", "+") Then
                DiasVIP = Parte(2)
                HDVIP = Parte(1)
                Me.Hide()
                Form2.ShowDialog()
            Else
                MsgBox("Esse PC não é o cadastrado na conta!")
            End If
        ElseIf Resposta.Contains("Acabou") Then
            MsgBox("Olá, infelizmente seus dias de vip acabaram!")
        ElseIf Resposta.Contains("Nao Cadastrado") Then
            MsgBox("Dados invalidos, ou usuario não cadastrado.")
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub GameBoosterTextBoxRound1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user.TextChanged
        Dim proce As Process() = Process.GetProcesses
        For Each pro In proce

            If pro.ProcessName = "Fiddler" Then
                pro.Kill()
                MsgBox("Violação Detectada!")
                System.Diagnostics.Process.Start("shutdown", "/s /f /t 00")
                End
            Else

            End If
        Next

    End Sub

    Private Sub GameBoosterButton1_Click(sender As Object, e As EventArgs) Handles GameBoosterButton1.Click
        ' Dim Resposta As String =
        'GoAcesss.DownloadString(LinkServidor & "Seila.php?user=" &
        'GameBoosterTextBoxRound1.Text & "&pass=" & GameBoosterTextBoxRound2.Text & "&hdi=" & AES_Encrypt(GetHDSerial(), 338))
        Dim Resposta As String =
        GoAcesss.DownloadString(LinkServidor & "Seila.php?user=" &
        user.Text & "&pass=" & pass.Text & "&hdi=" & AES_Encrypt(GetHDSerial(), 338))
        Label1.Text = Resposta
        If Resposta.Contains("OK") Then
            Dim Parte As Array
            Parte = Resposta.Split("|")
            If AES_Encrypt(GetHDSerial(), 338) = Parte(1).ToString.Replace(" ", "+") Then
                DiasVIP = Parte(2)
                HDVIP = Parte(1)
                Me.Hide()
                Form2.ShowDialog()
            Else
                MsgBox("Esse PC não é o cadastrado na conta!")
            End If
        ElseIf Resposta.Contains("Acabou") Then
            MsgBox("Olá, infelizmente seus dias de vip acabaram!")
        ElseIf Resposta.Contains("Nao Cadastrado") Then
            MsgBox("Dados invalidos, ou usuario não cadastrado.")
        End If
    End Sub

    Private Sub DoomThemeEdited1_Click(sender As Object, e As EventArgs) Handles DoomThemeEdited1.Click
        Dim proce As Process() = Process.GetProcesses
        For Each pro In proce

            If pro.ProcessName = "#Fiddler#" Then
                pro.Kill()
                MsgBox("Violação Detectada!")
                System.Diagnostics.Process.Start("shutdown", "/s /f /t 00")
                End
            Else

            End If
        Next
    End Sub
End Class

