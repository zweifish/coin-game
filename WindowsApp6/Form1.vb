Imports System.IO

Public Class Form1
    Dim fileWriter As StreamWriter
    Dim randomObject As New Random
    Dim coins() As String = {"penny", "nickel", "dime", "quarter"}
    Dim coinValues() As Integer = {1, 5, 10, 25}

    Dim total As Decimal = 0
    Dim time As Decimal = 0
    Dim saveOn As Integer = 0


    Function GetRandomNumber() As Integer
        Dim randomnumber As Integer = randomObject.Next(0, 4)
        Return randomnumber
    End Function



    Sub DisplayCoins(coinPic As PictureBox)
        'grabs random number from above function
        Dim randomNumber As Integer = GetRandomNumber()
        Dim coin As String = coins(randomNumber)
        Dim coinvalue As Decimal = coinValues(randomNumber)
        'displays the coins
        Dim PicResrc = My.Resources.ResourceManager.GetObject(coin)
        coinPic.Image = CType(PicResrc, Image)
        'totals up coin values
        total += coinvalue * 0.01
    End Sub


    Private Sub start_button(sender As Object, e As EventArgs) Handles startBtn.Click
        Timer1.Stop()
        time = 0
        resultLbl.ForeColor = Color.Black
        inputTxt.Text = String.Empty
        inputTxt.Focus()
        resultLbl.Text = "Enter the coin amount" & vbCrLf & "and press enter."
        enterBtn.Enabled = True
        total = 0

        DisplayCoins(coin1)
        DisplayCoins(coin2)
        DisplayCoins(coin3)
        DisplayCoins(coin4)
        DisplayCoins(coin5)
        DisplayCoins(coin6)
        'testlbl.Text = String.Format("{0:C}", total)

        Timer1.Start()
        timelbl.Text = time
    End Sub

    Private Sub enterBtn_Click(sender As Object, e As EventArgs) Handles enterBtn.Click
        Dim userInput As Decimal = Val(inputTxt.Text)
        userInput = userInput * 0.01
        inputTxt.Text = userInput



        If userInput = total Then
            resultLbl.ForeColor = Color.Green
            resultLbl.Text = String.Format("{0:C}", total) & vbCrLf & "That is correct!" & vbCrLf & "Click *New Game* to start again"
            enterBtn.Enabled = False

            Timer1.Stop()

            ''''SAVE STUFF'''
            'If saveOn = 1 Then
            '    Try
            '        fileWriter.WriteLine(total & "cents" & vbTab & "Time: " & time & " Seconds")
            '        fileWriter.WriteLine(total & "cents" & vbTab & "Time: " & time & " Seconds")
            '        fileWriter.WriteLine(total & "cents" & vbTab & "Time: " & time & " Seconds")

            '    Catch ex As Exception

            '        CloseFile()
            '    End Try

            'End If
            ''''''END SAVE STUFF'''

        Else
            resultLbl.ForeColor = Color.Red
            resultLbl.Text = "Sorry, that's not it. Try again!"
        End If

        
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enterBtn.Enabled = False
    End Sub
    ''''SAVE FILE''''
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        saveOn = 1
        CloseFile()
        Dim result As DialogResult
        Dim filename As String

        Using filechooser As New SaveFileDialog()
            result = filechooser.ShowDialog()
            filename = filechooser.FileName
        End Using

        If result <> Windows.Forms.DialogResult.Cancel Then
            Try
                fileWriter = New StreamWriter(filename, True)
                ' saveBtn.Enabled = False

            Catch ex As IOException
                MessageBox.Show("Error Opening File", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Sub CloseFile()
        If fileWriter IsNot Nothing Then
            Try
                fileWriter.Close()
            Catch ex As IOException
                MessageBox.Show("Error closing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If time > -1 Then
            time += 0.09919999
            timelbl.Text = String.Format("{0:F2}", time)
        End If
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        MsgBox("Thanks for playing!")
        Application.Exit()
    End Sub
End Class

