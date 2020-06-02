Public Class Form1
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
        CheckBox7.Checked = True
        CheckBox8.Checked = True
        CheckBox9.Checked = True
        CheckBox23.Checked = True
        CheckBox31.Checked = True
        CheckBox32.Checked = True
        CheckBox33.Checked = True
        CheckBox34.Checked = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call main1()
    End Sub

    Sub main1()
        Dim sr As New System.IO.StreamReader("musiclist.txt", System.Text.Encoding.GetEncoding("utf-8"))
        Dim tmp() As String    '戻り配列
        Dim Data(,) As String  'データ
        Dim i As Integer       '配列添え字
        Dim n As Integer       '配列添え字
        Dim Exhibitor1 As String, Exhibitor2 As String, Exhibitor3 As String, Exhibitor4 As String, Exhibitor5 As String, Exhibitor6 As String, Exhibitor7 As String, Exhibitor8 As String, Exhibitor9 As String
        Dim BUTTON1 As String, BUTTON2 As String, BUTTON3 As String, BUTTON4 As String
        Dim Difficulty1 As String, Difficulty2 As String, Difficulty3 As String, Difficulty4 As String
        Dim star1 As Long, star2 As Long, star3 As Long

        'チェックボックスの処理
        If CheckBox1.Checked = True Then Exhibitor1 = "PORTABLE1"
        If CheckBox2.Checked = True Then Exhibitor2 = "PORTABLE2"
        If CheckBox3.Checked = True Then Exhibitor3 = "RESPECT"
        If CheckBox4.Checked = True Then Exhibitor4 = "TRILOGY"
        If CheckBox5.Checked = True Then Exhibitor5 = "CLAZZIQUAI"
        If CheckBox6.Checked = True Then Exhibitor6 = "BLACK SQUARE"
        If CheckBox7.Checked = True Then Exhibitor7 = "V EXTENSION"
        If CheckBox8.Checked = True Then Exhibitor8 = "EMOTIONAL SENSE"
        If CheckBox9.Checked = True Then Exhibitor9 = "COLLABORATION"
        If CheckBox21.Checked = True Then BUTTON1 = "4BUTTON"
        If CheckBox22.Checked = True Then BUTTON2 = "5BUTTON"
        If CheckBox23.Checked = True Then BUTTON3 = "6BUTTON"
        If CheckBox24.Checked = True Then BUTTON4 = "8BUTTON"
        If CheckBox31.Checked = True Then Difficulty1 = "Nomal"
        If CheckBox32.Checked = True Then Difficulty2 = "Hard"
        If CheckBox33.Checked = True Then Difficulty3 = "Maximum"
        If CheckBox34.Checked = True Then Difficulty4 = "Super Crazy"
        If Label101.Text = "★" Then star1 = star1 + 1
        If Label102.Text = "★" Then star1 = star1 + 1
        If Label103.Text = "★" Then star1 = star1 + 1
        If Label104.Text = "★" Then star1 = star1 + 1
        If Label105.Text = "★" Then star1 = star1 + 1
        If Label106.Text = "★" Then star1 = star1 + 1
        If Label107.Text = "★" Then star1 = star1 + 1
        If Label108.Text = "★" Then star1 = star1 + 1
        If Label109.Text = "★" Then star1 = star1 + 1
        If Label110.Text = "★" Then star1 = star1 + 1
        If Label111.Text = "★" Then star1 = star1 + 1
        If Label112.Text = "★" Then star1 = star1 + 1
        If Label113.Text = "★" Then star1 = star1 + 1
        If Label114.Text = "★" Then star1 = star1 + 1
        If Label115.Text = "★" Then star1 = star1 + 1
        If Label121.Text = "★" Then star2 = star2 + 1
        If Label122.Text = "★" Then star2 = star2 + 1
        If Label123.Text = "★" Then star2 = star2 + 1
        If Label124.Text = "★" Then star2 = star2 + 1
        If Label125.Text = "★" Then star2 = star2 + 1
        If Label126.Text = "★" Then star2 = star2 + 1
        If Label127.Text = "★" Then star2 = star2 + 1
        If Label128.Text = "★" Then star2 = star2 + 1
        If Label129.Text = "★" Then star2 = star2 + 1
        If Label130.Text = "★" Then star2 = star2 + 1
        If Label131.Text = "★" Then star2 = star2 + 1
        If Label132.Text = "★" Then star2 = star2 + 1
        If Label133.Text = "★" Then star2 = star2 + 1
        If Label134.Text = "★" Then star2 = star2 + 1
        If Label135.Text = "★" Then star2 = star2 + 1






        While (sr.Peek() >= 0)  '最終行までループ


            ReDim Preserve Data(4, n)
            tmp = Split(sr.ReadLine(), vbTab) 'カンマで分割
            If tmp(4) = 1 Then star3 = 1
            If tmp(4) = 2 Then star3 = 2
            If tmp(4) = 3 Then star3 = 3
            If tmp(4) = 4 Then star3 = 4
            If tmp(4) = 5 Then star3 = 5
            If tmp(4) = 6 Then star3 = 6
            If tmp(4) = 7 Then star3 = 7
            If tmp(4) = 8 Then star3 = 8
            If tmp(4) = 9 Then star3 = 9
            If tmp(4) = 10 Then star3 = 10
            If tmp(4) = 11 Then star3 = 11
            If tmp(4) = 12 Then star3 = 12
            If tmp(4) = 13 Then star3 = 13
            If tmp(4) = 14 Then star3 = 14
            If tmp(4) = 15 Then star3 = 15


            If tmp(0) = (Exhibitor1) Or tmp(0) = (Exhibitor2) Or tmp(0) = (Exhibitor3) Or tmp(0) = (Exhibitor4) Or tmp(0) = (Exhibitor5) Or tmp(0) = (Exhibitor6) Or tmp(0) = (Exhibitor7) Or tmp(0) = (Exhibitor8) or tmp(0) = (Exhibitor9) Then
                If tmp(2) = (BUTTON1) Or tmp(2) = (BUTTON2) Or tmp(2) = (BUTTON3) Or tmp(2) = (BUTTON4) Then
                    If tmp(3) = (Difficulty1) Or tmp(3) = (Difficulty2) Or tmp(3) = (Difficulty3) Or tmp(3) = (Difficulty4) Then
                        If star3 >= star1 And star3 <= star2 Then

                            For i = 0 To 4 '項目数ぶんループ
                                Data(i, n) = tmp(i) '分割した内容を配列の項目へ入れる（0→ID, 1→名称, 2→値）
                            Next i

                            n = n + 1 '配列の次の行へ
                        End If
                    End If
                End If
            End If
        End While

        'ファイルのクローズ
        sr.Close()

        Dim rnd = New System.Random        ' インスタンスを生成
        Dim intResult = rnd.Next(n)       ' 0～9の乱数を取得


        Label7.Text = Data(0, intResult)
        Label9.Text = Data(2, intResult)
        Label11.Text = Data(3, intResult)
        Label13.Text = Data(4, intResult)
        Label15.Text = Data(1, intResult)

        'OBS簡易連携
        If CheckBox51.Checked = True Then
            Dim sw1 As New System.IO.StreamWriter(TextBox3.Text & "\Exhibitor.txt", False, System.Text.Encoding.GetEncoding("utf-8"))
            sw1.WriteLine(Label7.Text)
            sw1.Close()

            Dim sw2 As New System.IO.StreamWriter(TextBox3.Text & "\Button.txt", False, System.Text.Encoding.GetEncoding("utf-8"))
            sw2.WriteLine(Label9.Text)
            sw2.Close()

            Dim sw3 As New System.IO.StreamWriter(TextBox3.Text & "\Difficulty.txt", False, System.Text.Encoding.GetEncoding("utf-8"))
            sw3.WriteLine(Label11.Text)
            sw3.Close()

            Dim sw4 As New System.IO.StreamWriter(TextBox3.Text & "\Star.txt", False, System.Text.Encoding.GetEncoding("utf-8"))
            sw4.WriteLine(Label13.Text)
            sw4.Close()

            Dim sw5 As New System.IO.StreamWriter(TextBox3.Text & "\song.txt", False, System.Text.Encoding.GetEncoding("utf-8"))
            sw5.WriteLine(Label15.Text)
            sw5.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = "自動更新中"
        Button2.BackColor = Color.LightCoral
        Timer1.Interval = CInt(TextBox1.Text) * 60000 + CInt(TextBox2.Text) * 1000
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Text = "自動更新開始"
        Button2.BackColor = Color.FromArgb(&HC6, &HFF, &HC6)
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call main1()
    End Sub

    Private Sub Label101_Click(sender As Object, e As EventArgs) Handles Label101.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "☆"
        Label102.ForeColor = Color.Black
        Label103.Text = "☆"
        Label103.ForeColor = Color.Black
        Label104.Text = "☆"
        Label104.ForeColor = Color.Black
        Label105.Text = "☆"
        Label105.ForeColor = Color.Black
        Label106.Text = "☆"
        Label106.ForeColor = Color.Black
        Label107.Text = "☆"
        Label107.ForeColor = Color.Black
        Label108.Text = "☆"
        Label108.ForeColor = Color.Black
        Label109.Text = "☆"
        Label109.ForeColor = Color.Black
        Label110.Text = "☆"
        Label110.ForeColor = Color.Black
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label102_Click(sender As Object, e As EventArgs) Handles Label102.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "☆"
        Label103.ForeColor = Color.Black
        Label104.Text = "☆"
        Label104.ForeColor = Color.Black
        Label105.Text = "☆"
        Label105.ForeColor = Color.Black
        Label106.Text = "☆"
        Label106.ForeColor = Color.Black
        Label107.Text = "☆"
        Label107.ForeColor = Color.Black
        Label108.Text = "☆"
        Label108.ForeColor = Color.Black
        Label109.Text = "☆"
        Label109.ForeColor = Color.Black
        Label110.Text = "☆"
        Label110.ForeColor = Color.Black
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label103_Click(sender As Object, e As EventArgs) Handles Label103.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "☆"
        Label104.ForeColor = Color.Black
        Label105.Text = "☆"
        Label105.ForeColor = Color.Black
        Label106.Text = "☆"
        Label106.ForeColor = Color.Black
        Label107.Text = "☆"
        Label107.ForeColor = Color.Black
        Label108.Text = "☆"
        Label108.ForeColor = Color.Black
        Label109.Text = "☆"
        Label109.ForeColor = Color.Black
        Label110.Text = "☆"
        Label110.ForeColor = Color.Black
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label104_Click(sender As Object, e As EventArgs) Handles Label104.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "☆"
        Label105.ForeColor = Color.Black
        Label106.Text = "☆"
        Label106.ForeColor = Color.Black
        Label107.Text = "☆"
        Label107.ForeColor = Color.Black
        Label108.Text = "☆"
        Label108.ForeColor = Color.Black
        Label109.Text = "☆"
        Label109.ForeColor = Color.Black
        Label110.Text = "☆"
        Label110.ForeColor = Color.Black
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label105_Click(sender As Object, e As EventArgs) Handles Label105.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "☆"
        Label106.ForeColor = Color.Black
        Label107.Text = "☆"
        Label107.ForeColor = Color.Black
        Label108.Text = "☆"
        Label108.ForeColor = Color.Black
        Label109.Text = "☆"
        Label109.ForeColor = Color.Black
        Label110.Text = "☆"
        Label110.ForeColor = Color.Black
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label106_Click(sender As Object, e As EventArgs) Handles Label106.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "★"
        Label106.ForeColor = Color.Orange
        Label107.Text = "☆"
        Label107.ForeColor = Color.Black
        Label108.Text = "☆"
        Label108.ForeColor = Color.Black
        Label109.Text = "☆"
        Label109.ForeColor = Color.Black
        Label110.Text = "☆"
        Label110.ForeColor = Color.Black
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label107_Click(sender As Object, e As EventArgs) Handles Label107.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "★"
        Label106.ForeColor = Color.Orange
        Label107.Text = "★"
        Label107.ForeColor = Color.Orange
        Label108.Text = "☆"
        Label108.ForeColor = Color.Black
        Label109.Text = "☆"
        Label109.ForeColor = Color.Black
        Label110.Text = "☆"
        Label110.ForeColor = Color.Black
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label108_Click(sender As Object, e As EventArgs) Handles Label108.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "★"
        Label106.ForeColor = Color.Orange
        Label107.Text = "★"
        Label107.ForeColor = Color.Orange
        Label108.Text = "★"
        Label108.ForeColor = Color.Orange
        Label109.Text = "☆"
        Label109.ForeColor = Color.Black
        Label110.Text = "☆"
        Label110.ForeColor = Color.Black
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label109_Click(sender As Object, e As EventArgs) Handles Label109.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "★"
        Label106.ForeColor = Color.Orange
        Label107.Text = "★"
        Label107.ForeColor = Color.Orange
        Label108.Text = "★"
        Label108.ForeColor = Color.Orange
        Label109.Text = "★"
        Label109.ForeColor = Color.Orange
        Label110.Text = "☆"
        Label110.ForeColor = Color.Black
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label110_Click(sender As Object, e As EventArgs) Handles Label110.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "★"
        Label106.ForeColor = Color.Orange
        Label107.Text = "★"
        Label107.ForeColor = Color.Orange
        Label108.Text = "★"
        Label108.ForeColor = Color.Orange
        Label109.Text = "★"
        Label109.ForeColor = Color.Orange
        Label110.Text = "★"
        Label110.ForeColor = Color.Orange
        Label111.Text = "☆"
        Label111.ForeColor = Color.Black
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label111_Click(sender As Object, e As EventArgs) Handles Label111.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "★"
        Label106.ForeColor = Color.Orange
        Label107.Text = "★"
        Label107.ForeColor = Color.Orange
        Label108.Text = "★"
        Label108.ForeColor = Color.Orange
        Label109.Text = "★"
        Label109.ForeColor = Color.Orange
        Label110.Text = "★"
        Label110.ForeColor = Color.Orange
        Label111.Text = "★"
        Label111.ForeColor = Color.Red
        Label112.Text = "☆"
        Label112.ForeColor = Color.Black
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label112_Click(sender As Object, e As EventArgs) Handles Label112.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "★"
        Label106.ForeColor = Color.Orange
        Label107.Text = "★"
        Label107.ForeColor = Color.Orange
        Label108.Text = "★"
        Label108.ForeColor = Color.Orange
        Label109.Text = "★"
        Label109.ForeColor = Color.Orange
        Label110.Text = "★"
        Label110.ForeColor = Color.Orange
        Label111.Text = "★"
        Label111.ForeColor = Color.Red
        Label112.Text = "★"
        Label112.ForeColor = Color.Red
        Label113.Text = "☆"
        Label113.ForeColor = Color.Black
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label113_Click(sender As Object, e As EventArgs) Handles Label113.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "★"
        Label106.ForeColor = Color.Orange
        Label107.Text = "★"
        Label107.ForeColor = Color.Orange
        Label108.Text = "★"
        Label108.ForeColor = Color.Orange
        Label109.Text = "★"
        Label109.ForeColor = Color.Orange
        Label110.Text = "★"
        Label110.ForeColor = Color.Orange
        Label111.Text = "★"
        Label111.ForeColor = Color.Red
        Label112.Text = "★"
        Label112.ForeColor = Color.Red
        Label113.Text = "★"
        Label113.ForeColor = Color.Red
        Label114.Text = "☆"
        Label114.ForeColor = Color.Black
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label114_Click(sender As Object, e As EventArgs) Handles Label114.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Green
        Label102.Text = "★"
        Label102.ForeColor = Color.Green
        Label103.Text = "★"
        Label103.ForeColor = Color.Green
        Label104.Text = "★"
        Label104.ForeColor = Color.Green
        Label105.Text = "★"
        Label105.ForeColor = Color.Green
        Label106.Text = "★"
        Label106.ForeColor = Color.Orange
        Label107.Text = "★"
        Label107.ForeColor = Color.Orange
        Label108.Text = "★"
        Label108.ForeColor = Color.Orange
        Label109.Text = "★"
        Label109.ForeColor = Color.Orange
        Label110.Text = "★"
        Label110.ForeColor = Color.Orange
        Label111.Text = "★"
        Label111.ForeColor = Color.Red
        Label112.Text = "★"
        Label112.ForeColor = Color.Red
        Label113.Text = "★"
        Label113.ForeColor = Color.Red
        Label114.Text = "★"
        Label114.ForeColor = Color.Red
        Label115.Text = "☆"
        Label115.ForeColor = Color.Black
    End Sub

    Private Sub Label115_Click(sender As Object, e As EventArgs) Handles Label115.Click
        Label101.Text = "★"
        Label101.ForeColor = Color.Fuchsia
        Label102.Text = "★"
        Label102.ForeColor = Color.Fuchsia
        Label103.Text = "★"
        Label103.ForeColor = Color.Fuchsia
        Label104.Text = "★"
        Label104.ForeColor = Color.Fuchsia
        Label105.Text = "★"
        Label105.ForeColor = Color.Fuchsia
        Label106.Text = "★"
        Label106.ForeColor = Color.Fuchsia
        Label107.Text = "★"
        Label107.ForeColor = Color.Fuchsia
        Label108.Text = "★"
        Label108.ForeColor = Color.Fuchsia
        Label109.Text = "★"
        Label109.ForeColor = Color.Fuchsia
        Label110.Text = "★"
        Label110.ForeColor = Color.Fuchsia
        Label111.Text = "★"
        Label111.ForeColor = Color.Fuchsia
        Label112.Text = "★"
        Label112.ForeColor = Color.Fuchsia
        Label113.Text = "★"
        Label113.ForeColor = Color.Fuchsia
        Label114.Text = "★"
        Label114.ForeColor = Color.Fuchsia
        Label115.Text = "★"
        Label115.ForeColor = Color.Fuchsia
    End Sub

    Private Sub Label121_Click(sender As Object, e As EventArgs) Handles Label121.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "☆"
        Label122.ForeColor = Color.Black
        Label123.Text = "☆"
        Label123.ForeColor = Color.Black
        Label124.Text = "☆"
        Label124.ForeColor = Color.Black
        Label125.Text = "☆"
        Label125.ForeColor = Color.Black
        Label126.Text = "☆"
        Label126.ForeColor = Color.Black
        Label127.Text = "☆"
        Label127.ForeColor = Color.Black
        Label128.Text = "☆"
        Label128.ForeColor = Color.Black
        Label129.Text = "☆"
        Label129.ForeColor = Color.Black
        Label130.Text = "☆"
        Label130.ForeColor = Color.Black
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label122_Click(sender As Object, e As EventArgs) Handles Label122.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "☆"
        Label123.ForeColor = Color.Black
        Label124.Text = "☆"
        Label124.ForeColor = Color.Black
        Label125.Text = "☆"
        Label125.ForeColor = Color.Black
        Label126.Text = "☆"
        Label126.ForeColor = Color.Black
        Label127.Text = "☆"
        Label127.ForeColor = Color.Black
        Label128.Text = "☆"
        Label128.ForeColor = Color.Black
        Label129.Text = "☆"
        Label129.ForeColor = Color.Black
        Label130.Text = "☆"
        Label130.ForeColor = Color.Black
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label123_Click(sender As Object, e As EventArgs) Handles Label123.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "☆"
        Label124.ForeColor = Color.Black
        Label125.Text = "☆"
        Label125.ForeColor = Color.Black
        Label126.Text = "☆"
        Label126.ForeColor = Color.Black
        Label127.Text = "☆"
        Label127.ForeColor = Color.Black
        Label128.Text = "☆"
        Label128.ForeColor = Color.Black
        Label129.Text = "☆"
        Label129.ForeColor = Color.Black
        Label130.Text = "☆"
        Label130.ForeColor = Color.Black
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black

    End Sub

    Private Sub Label124_Click(sender As Object, e As EventArgs) Handles Label124.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "☆"
        Label125.ForeColor = Color.Black
        Label126.Text = "☆"
        Label126.ForeColor = Color.Black
        Label127.Text = "☆"
        Label127.ForeColor = Color.Black
        Label128.Text = "☆"
        Label128.ForeColor = Color.Black
        Label129.Text = "☆"
        Label129.ForeColor = Color.Black
        Label130.Text = "☆"
        Label130.ForeColor = Color.Black
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black

    End Sub

    Private Sub Label125_Click(sender As Object, e As EventArgs) Handles Label125.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "☆"
        Label126.ForeColor = Color.Black
        Label127.Text = "☆"
        Label127.ForeColor = Color.Black
        Label128.Text = "☆"
        Label128.ForeColor = Color.Black
        Label129.Text = "☆"
        Label129.ForeColor = Color.Black
        Label130.Text = "☆"
        Label130.ForeColor = Color.Black
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label126_Click(sender As Object, e As EventArgs) Handles Label126.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "★"
        Label126.ForeColor = Color.Orange
        Label127.Text = "☆"
        Label127.ForeColor = Color.Black
        Label128.Text = "☆"
        Label128.ForeColor = Color.Black
        Label129.Text = "☆"
        Label129.ForeColor = Color.Black
        Label130.Text = "☆"
        Label130.ForeColor = Color.Black
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label127_Click(sender As Object, e As EventArgs) Handles Label127.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "★"
        Label126.ForeColor = Color.Orange
        Label127.Text = "★"
        Label127.ForeColor = Color.Orange
        Label128.Text = "☆"
        Label128.ForeColor = Color.Black
        Label129.Text = "☆"
        Label129.ForeColor = Color.Black
        Label130.Text = "☆"
        Label130.ForeColor = Color.Black
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label128_Click(sender As Object, e As EventArgs) Handles Label128.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "★"
        Label126.ForeColor = Color.Orange
        Label127.Text = "★"
        Label127.ForeColor = Color.Orange
        Label128.Text = "★"
        Label128.ForeColor = Color.Orange
        Label129.Text = "☆"
        Label129.ForeColor = Color.Black
        Label130.Text = "☆"
        Label130.ForeColor = Color.Black
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label129_Click(sender As Object, e As EventArgs) Handles Label129.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "★"
        Label126.ForeColor = Color.Orange
        Label127.Text = "★"
        Label127.ForeColor = Color.Orange
        Label128.Text = "★"
        Label128.ForeColor = Color.Orange
        Label129.Text = "★"
        Label129.ForeColor = Color.Orange
        Label130.Text = "☆"
        Label130.ForeColor = Color.Black
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label130_Click(sender As Object, e As EventArgs) Handles Label130.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "★"
        Label126.ForeColor = Color.Orange
        Label127.Text = "★"
        Label127.ForeColor = Color.Orange
        Label128.Text = "★"
        Label128.ForeColor = Color.Orange
        Label129.Text = "★"
        Label129.ForeColor = Color.Orange
        Label130.Text = "★"
        Label130.ForeColor = Color.Orange
        Label131.Text = "☆"
        Label131.ForeColor = Color.Black
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label131_Click(sender As Object, e As EventArgs) Handles Label131.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "★"
        Label126.ForeColor = Color.Orange
        Label127.Text = "★"
        Label127.ForeColor = Color.Orange
        Label128.Text = "★"
        Label128.ForeColor = Color.Orange
        Label129.Text = "★"
        Label129.ForeColor = Color.Orange
        Label130.Text = "★"
        Label130.ForeColor = Color.Orange
        Label131.Text = "★"
        Label131.ForeColor = Color.Red
        Label132.Text = "☆"
        Label132.ForeColor = Color.Black
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label132_Click(sender As Object, e As EventArgs) Handles Label132.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "★"
        Label126.ForeColor = Color.Orange
        Label127.Text = "★"
        Label127.ForeColor = Color.Orange
        Label128.Text = "★"
        Label128.ForeColor = Color.Orange
        Label129.Text = "★"
        Label129.ForeColor = Color.Orange
        Label130.Text = "★"
        Label130.ForeColor = Color.Orange
        Label131.Text = "★"
        Label131.ForeColor = Color.Red
        Label132.Text = "★"
        Label132.ForeColor = Color.Red
        Label133.Text = "☆"
        Label133.ForeColor = Color.Black
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label133_Click(sender As Object, e As EventArgs) Handles Label133.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "★"
        Label126.ForeColor = Color.Orange
        Label127.Text = "★"
        Label127.ForeColor = Color.Orange
        Label128.Text = "★"
        Label128.ForeColor = Color.Orange
        Label129.Text = "★"
        Label129.ForeColor = Color.Orange
        Label130.Text = "★"
        Label130.ForeColor = Color.Orange
        Label131.Text = "★"
        Label131.ForeColor = Color.Red
        Label132.Text = "★"
        Label132.ForeColor = Color.Red
        Label133.Text = "★"
        Label133.ForeColor = Color.Red
        Label134.Text = "☆"
        Label134.ForeColor = Color.Black
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label134_Click(sender As Object, e As EventArgs) Handles Label134.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Green
        Label122.Text = "★"
        Label122.ForeColor = Color.Green
        Label123.Text = "★"
        Label123.ForeColor = Color.Green
        Label124.Text = "★"
        Label124.ForeColor = Color.Green
        Label125.Text = "★"
        Label125.ForeColor = Color.Green
        Label126.Text = "★"
        Label126.ForeColor = Color.Orange
        Label127.Text = "★"
        Label127.ForeColor = Color.Orange
        Label128.Text = "★"
        Label128.ForeColor = Color.Orange
        Label129.Text = "★"
        Label129.ForeColor = Color.Orange
        Label130.Text = "★"
        Label130.ForeColor = Color.Orange
        Label131.Text = "★"
        Label131.ForeColor = Color.Red
        Label132.Text = "★"
        Label132.ForeColor = Color.Red
        Label133.Text = "★"
        Label133.ForeColor = Color.Red
        Label134.Text = "★"
        Label134.ForeColor = Color.Red
        Label135.Text = "☆"
        Label135.ForeColor = Color.Black
    End Sub

    Private Sub Label135_Click(sender As Object, e As EventArgs) Handles Label135.Click
        Label121.Text = "★"
        Label121.ForeColor = Color.Fuchsia
        Label122.Text = "★"
        Label122.ForeColor = Color.Fuchsia
        Label123.Text = "★"
        Label123.ForeColor = Color.Fuchsia
        Label124.Text = "★"
        Label124.ForeColor = Color.Fuchsia
        Label125.Text = "★"
        Label125.ForeColor = Color.Fuchsia
        Label126.Text = "★"
        Label126.ForeColor = Color.Fuchsia
        Label127.Text = "★"
        Label127.ForeColor = Color.Fuchsia
        Label128.Text = "★"
        Label128.ForeColor = Color.Fuchsia
        Label129.Text = "★"
        Label129.ForeColor = Color.Fuchsia
        Label130.Text = "★"
        Label130.ForeColor = Color.Fuchsia
        Label131.Text = "★"
        Label131.ForeColor = Color.Fuchsia
        Label132.Text = "★"
        Label132.ForeColor = Color.Fuchsia
        Label133.Text = "★"
        Label133.ForeColor = Color.Fuchsia
        Label134.Text = "★"
        Label134.ForeColor = Color.Fuchsia
        Label135.Text = "★"
        Label135.ForeColor = Color.Fuchsia
    End Sub

    Private Sub CheckBox52_CheckedChanged(sender As Object, e As EventArgs) 
        If CheckBox34.Checked = True Then
            Dim bOpen As Boolean = False
            '既にフォーム２が開かれているか確認
            For Each fSh As Form In Application.OpenForms
                If fSh.Name = Form2.Name Then
                    bOpen = True
                    Exit For
                End If
            Next
            'フォーム２が開かれていない場合のみ、フォーム２を開く
            If bOpen = False Then
                Form2 = Nothing
                'フォーム２を開く
                Form2 = New Form2
                Form2.Show()
            End If
        End If
    End Sub

End Class