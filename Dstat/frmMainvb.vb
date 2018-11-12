Imports System.Net
Imports System.Threading

Public Class frmMainvb
    Dim th1 As Thread

    Private Sub LD(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wc As New WebClient()
        Me.Graph1.OverrideMaxValue = 10000000
        Me.Graph1.OverrideMax = 10000000

        Me.Graph1.AddValue(Convert.ToSingle(wc.DownloadString("http://68.**.***.**/swf.php")))
        th1 = New Thread(AddressOf DN)
        th1.IsBackground = True
        th1.Start()
    End Sub

    Public Function Atualiza()

    End Function
    Public Function GetFileSize(ByVal TheSize As ULong) As String

        Dim SizeType As String = ""

        Dim DoubleBytes As Double
        Try
            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " Tbps"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " Gbps"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " Mbps"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " Kbps"
                Case 0 To 1023
                    DoubleBytes = TheSize ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function
    Sub DN()
        Try
            Dim wc As New WebClient()

            Me.Graph1.AddValue(Convert.ToSingle(wc.DownloadString("http://68.**.***.**/swf.php")))

        Catch ex As Exception
            Graph1.AddValue(Convert.ToSingle(0))
        End Try




        '    Me.BeginInvoke(Sub() Me.LogInLabel1.Text = GetFileSize(wc.DownloadString("http://68.**.***.**/swf.php")))

        th1 = New Thread(AddressOf DN)
        th1.IsBackground = True
        th1.Start()
        Thread.Sleep(100)
    End Sub

    Dim DoubleBytes As Double

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim wc As New WebClient()
        '    // Me.LogInLabel1.Text = GetFileSize(wc.DownloadString("http://68.**.***.**/swf.php"))
        '//      Me.EarnButton1.Text Clck = GetFileSize(wc.DownloadString("http://68.**.***.**/swf.php"))

    End Sub

    Private Sub EarnTheme1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Function SizC(ByVal TheSize As ULong) As String

        Dim SizeType As String = ""

        Dim DoubleBytes As Double
        Try
            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " Tbps"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " Gbps"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " Mbps"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " Kbps"
                Case 0 To 1023
                    DoubleBytes = TheSize ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function
    Private Sub EarnTheme1_Click_1(sender As Object, e As EventArgs) Handles EarnTheme1.Click

    End Sub

    Private Sub EarnButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EarnButton1_Click_1(sender As Object, e As EventArgs) Handles EarnButton1.Click
        Clipboard.Clear()
        Clipboard.SetText("68.**.***.**")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Graph1.Clear()
    End Sub

    Private Sub EarnButton3_Click(sender As Object, e As EventArgs) Handles EarnButton3.Click
        Graph1.Clear()
    End Sub

    Private Sub Graph1_Click(sender As Object, e As EventArgs) Handles Graph1.Click

    End Sub

    Private Sub EarnButton2_Click(sender As Object, e As EventArgs)

    End Sub
End Class