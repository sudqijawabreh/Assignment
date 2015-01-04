Public Class Frm

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Dim choice As String
        choice = MsgBox("Are you really sure you want to exit Rock, Paper, Scissors?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Quit?")
        If choice = MsgBoxResult.Yes Then
            End

        End If
    End Sub


    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        Dim choice As String
        choice = MsgBox("Are you sure you want to reset the game?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Quit?")

        If choice = MsgBoxResult.Yes Then

            LblPlayerPoints1.Text = 0
            LblPlayerPoints2.Text = 0

        End If

    End Sub

    Private Sub BtnDeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeal.Click
        Dim entry1 As Integer
        Dim entry2 As Integer

        entry1 = InputBox("PLAYER ONE: Insert a number from 1-3!", "Draw!")
        entry2 = InputBox("PLAYER TWO: Insert a number from 1-3!", "Draw!")


        If entry1 = 1 And entry2 = 1 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\rock.png"
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\rock.png"

            PicOne.Visible = True
            PicTwo.Visible = True

        ElseIf entry1 = 2 And entry2 = 2 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\Paper.png"
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\Paper.png"

            PicOne.Visible = True
            PicTwo.Visible = True


        ElseIf entry1 = 3 And entry2 = 3 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\Scissors.png"
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\Scissors.png"

            PicOne.Visible = True
            PicTwo.Visible = True


        ElseIf entry1 = 1 And entry2 = 2 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\rock.png"
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\Paper.png"

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints2.Text = +1

        ElseIf entry1 = 2 And entry2 = 1 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\Paper.png"
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\rock.png"

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints1.Text = +1
        ElseIf entry1 = 1 And entry2 = 3 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\rock.png"
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\Scissors.png"

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints1.Text = +1
        ElseIf entry1 = 3 And entry2 = 1 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\Scissors.png"
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\rock.png"

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints2.Text = +1
        ElseIf entry1 = 2 And entry2 = 3 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\Paper.png"
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\Scissors.png"

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints2.Text = +1
        ElseIf entry1 = 3 And entry2 = 2 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\Scissors.png"
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\Paper.png"

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints1.Text = +1



        End If

       

    End Sub

    Private Sub FrmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim name1 As String = InputBox("Welcome to Rock Paper Scissors! Enter Player One in the Box below!")
        Dim name2 As String = InputBox("Welcome to Rock Paper Scissors! Enter Player One in the Box below!")
        LblPlayer1.Text = name1
        LblPlayer2.Text = name2
        LblPlayerPoints1.Text = 0
        LblPlayerPoints2.Text = 0
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        send() 'Send function



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TrackBar1.visible = True

        Dim choice As String
      

        LblPlayerPoints1.Text = 0
        LblPlayerPoints2.Text = 0
        Timer1.Start()


        Dim p1 As Integer = Val(LblPlayerPoints1.Text)
        Dim p2 As Integer = Val(LblPlayerPoints2.Text)
        If p1 = 100 Then choice = MsgBox("Congratulations " + LblPlayer1.Text + " ! You Win! Would you like to keep playing?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Winner!")
        If choice = MsgBoxResult.No Then
            Application.Exit()
        End If
        If p2 = 100 Then choice = MsgBox("Congratulations " + LblPlayer2.Text + "! You Win! Would you like to keep playing?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Winner!")
        If choice = MsgBoxResult.No Then
            Application.Exit()
        End If
    End Sub
    Public Function send() As Integer ' Computes who is the winner then returns an integer number
        'Declare variable
        Dim winner As Integer
        Dim RandomObject As New Random
        Dim PlayerPic1 As Integer
        Dim PlayerPic2 As Integer

        PlayerPic1 = 1 + RandomObject.Next(3)
        PlayerPic2 = 1 + RandomObject.Next(3)

        If PlayerPic1 = 1 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\Rock.PNG"
            PicOne.Visible = True
        ElseIf PlayerPic1 = 2 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\Paper.PNG"
            PicOne.Visible = True
        ElseIf PlayerPic1 = 3 Then
            PicOne.ImageLocation = "C:\Users\Paro\Downloads\Scissors.PNG"
            PicOne.Visible = True
        End If

        If PlayerPic2 = 1 Then
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\Rock.PNG"
            PicTwo.Visible = True
        ElseIf PlayerPic2 = 2 Then
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\Paper.PNG"
            PicTwo.Visible = True
        ElseIf PlayerPic2 = 3 Then
            PicTwo.ImageLocation = "C:\Users\Paro\Downloads\Scissors.PNG"
            PicTwo.Visible = True

        End If

        If PlayerPic1 = 1 And PlayerPic2 = 1 Then

            PicOne.Visible = True
            PicTwo.Visible = True
            winner = -1
            ' MsgBox("You Tied! Click the Deal Button!", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "TIE!")

        ElseIf PlayerPic1 = 2 And PlayerPic2 = 2 Then
            ' MsgBox("You Tied! Click the Deal Button!", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "TIE!")

            PicOne.Visible = True
            PicTwo.Visible = True
            winner = -1


        ElseIf PlayerPic1 = 3 And PlayerPic2 = 3 Then
            'MsgBox("You Tied! Click the Deal Button!", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "TIE!")
            PicOne.Visible = True
            PicTwo.Visible = True
            winner = -1

        ElseIf PlayerPic1 = 1 And PlayerPic2 = 2 Then

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints2.Text += 1
            winner = 2 'Winner is Player2

        ElseIf PlayerPic1 = 2 And PlayerPic2 = 1 Then

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints1.Text += 1
            winner = 1
        ElseIf PlayerPic1 = 1 And PlayerPic2 = 3 Then


            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints1.Text += 1
            winner = 1
        ElseIf PlayerPic1 = 3 And PlayerPic2 = 1 Then

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints2.Text += 1
            winner = 2
        ElseIf PlayerPic1 = 2 And PlayerPic2 = 3 Then

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints2.Text += 1
            winner = 2
        ElseIf PlayerPic1 = 3 And PlayerPic2 = 2 Then

            PicOne.Visible = True
            PicTwo.Visible = True
            LblPlayerPoints1.Text += 1
            winner = 1
        Else
            winner = -1


        End If

        Return winner ' Returns value of winner
    End Function

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim p1 As Integer
        Dim p2 As Integer
        Dim winner As Integer
        Dim choice As String

        p1 = Val(LblPlayerPoints1.Text)
        p2 = Val(LblPlayerPoints2.Text)
        If p1 = 100 Or p2 = 100 Then
            Timer1.Stop()
            If p1 = 100 Then choice = MsgBox("Congratulations " + LblPlayer1.Text + " ! You Win! Would you like to keep playing?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Winner!")
            If choice = MsgBoxResult.No Then
                Application.Exit()
            End If
            If p2 = 100 Then choice = MsgBox("Congratulations " + LblPlayer2.Text + "! You Win! Would you like to keep playing?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Winner!")
            If choice = MsgBoxResult.No Then
                Application.Exit()
            End If
            TrackBar1.visible = False
            Return
        End If


        winner = send()
        If winner = 1 Then
            LstPlayer1.Items.Add("Win!")
            LstPlayer2.Items.Add("Lose!")


        End If
        If winner = 2 Then
            LstPlayer2.Items.Add("Win!")
            LstPlayer1.Items.Add("Lose!")


        End If

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Timer1.Interval = TrackBar1.Value
        hi()
        ToolTip1.Show(Timer1.Interval.ToString, Me)

    End Sub

  
End Class
