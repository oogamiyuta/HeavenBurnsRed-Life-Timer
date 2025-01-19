Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Speech.Synthesis ' テキスト読み上げ用


Public Class Form1
    ' 残り時間を保持する変数（秒単位）
    Private remainingTime As Integer
    ' 音声合成のためのSpeechSynthesizer
    Private ReadOnly synthesizer As New SpeechSynthesizer()
    ' 保存ファイルのパス
    Private Const SaveFilePath As String = "timer_data.csv"
    ' フォームロード時の初期設定
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTimer.Text = "00:00:00"
        LoadTimerData()
    End Sub

    ' フォームが閉じる際にデータを保存
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveTimerData()
    End Sub

    ' データを保存
    Private Sub SaveTimerData()
        Try
            Dim currentTime As DateTime = DateTime.Now
            Using writer As New StreamWriter(SaveFilePath)
                writer.WriteLine($"{remainingTime},{currentTime:O},{Life.Value}") ' Life.Valueも保存
            End Using
        Catch ex As Exception
            MessageBox.Show("タイマーのデータ保存中にエラーが発生しました。", "エラー")
        End Try
    End Sub

    ' データを読み込み
    Private Sub LoadTimerData()
        If File.Exists(SaveFilePath) Then
            Try
                Using reader As New StreamReader(SaveFilePath)
                    Dim line As String = reader.ReadLine()
                    If Not String.IsNullOrEmpty(line) Then
                        Dim parts As String() = line.Split(","c)
                        Dim savedRemainingTime As Integer = Integer.Parse(parts(0))
                        Dim savedTimestamp As DateTime = DateTime.Parse(parts(1))
                        Dim savedLifeValue As Integer = Integer.Parse(parts(2))

                        ' 経過時間を計算
                        Dim elapsedTime As TimeSpan = DateTime.Now - savedTimestamp
                        Dim elapsedSeconds As Integer = CInt(elapsedTime.TotalSeconds)

                        ' 閉じていた間の進行をシミュレーション
                        Dim adjustedTime = savedRemainingTime - elapsedSeconds

                        ' スタミナ更新と時間調整をシミュレート
                        While adjustedTime <= 0
                            If savedLifeValue < 4 Then
                                ' 4時間を追加し、スタミナを1増加
                                adjustedTime += 4 * 3600
                                savedLifeValue += 1
                            Else
                                ' スタミナがマックスなら停止
                                adjustedTime = 0
                                timerCountdown.Stop()
                                Exit While
                            End If
                        End While

                        ' 調整後の値を反映
                        remainingTime = adjustedTime
                        Life.Value = savedLifeValue
                        UpdateTimerLabel()
                        timerCountdown.Interval = 1000 ' 1秒間隔
                        timerCountdown.Start()
                        SpeakNotification（$"前回の情報からタイマーを再開しています。現在のライフは{Life.Value }個です。誤差がある場合は修正をお願いします。"）
                    End If
                End Using
            Catch ex As Exception
                SpeakNotification("タイマーのデータ読み込み中にエラーが発生しました。")
            End Try
        End If
    End Sub

    ' 設定ボタン
    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim hours As Integer
        Dim minutes As Integer
        Dim seconds As Integer

        ' 入力値を取得し、エラーチェックを行う
        If Not Integer.TryParse(txtHours.Text, hours) OrElse hours < 0 Then
            SpeakNotification("正しい時を入力してください。")
            Return
        End If
        If Not Integer.TryParse(txtMinutes.Text, minutes) OrElse minutes < 0 OrElse minutes >= 60 Then
            SpeakNotification("正しい分を入力してください。")
            Return
        End If
        If Not Integer.TryParse(txtSeconds.Text, seconds) OrElse seconds < 0 OrElse seconds >= 60 Then
            SpeakNotification("正しい秒を入力してください。")
            Return
        End If

        ' 秒単位で時間を計算
        remainingTime = (hours * 3600) + (minutes * 60) + seconds
        UpdateTimerLabel()
    End Sub

    ' タイマーの開始ボタン
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If remainingTime > 0 Then
            timerCountdown.Interval = 1000 ' 1秒間隔
            timerCountdown.Start()
        Else
            SpeakNotification("時間を設定してください。")
        End If
    End Sub

    ' タイマーの停止ボタン
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timerCountdown.Stop()
    End Sub

    ' タイマーの動作
    Private Sub timerCountdown_Tick(sender As Object, e As EventArgs) Handles timerCountdown.Tick
        If remainingTime >= 1 Then
            remainingTime -= 1
            UpdateTimerLabel()
        Else
            SpeakNotification($"Lifeが増加しました。現在のライフは{Life.Value + 1}個です。")
            If Life.Value = 4 Then
                Life.Value = 5
                SpeakNotification("スタミナがマックスまで回復しました。停止します。")
                timerCountdown.Stop()
            Else
                ' 0秒になった場合、自動で4時間を追加
                remainingTime += 4 * 3600 - 1 ' 4時間を秒に変換して追加
                Life.Value = Life.Value + 1
                UpdateTimerLabel()
            End If
        End If
    End Sub

    ' ラベルの更新
    Private Sub UpdateTimerLabel()
        Dim hours As Integer = remainingTime \ 3600
        Dim minutes As Integer = (remainingTime Mod 3600) \ 60
        Dim seconds As Integer = remainingTime Mod 60
        lblTimer.Text = $"{hours:00}:{minutes:00}:{seconds:00}"
        AddDate.Text = "次回ライフ追加日時" & vbCrLf & DateTime.Now.Add(New TimeSpan($"{hours:00}", $"{minutes:00}", $"{seconds:00}")) _
            & vbCrLf & "ライフMAX日時" & vbCrLf & DateTime.Now.Add(New TimeSpan((4 - Life.Value) * 4 + hours, minutes, seconds))
    End Sub

    Private Sub errorcorrection_Click(sender As Object, e As EventArgs) Handles errorcorrection.Click
        remainingTime -= 1
    End Sub



    Private Sub Life_KeyUp(sender As Object, e As KeyEventArgs) Handles Life.KeyUp
        If Life.Value = 5 Then
            timerCountdown.Stop()
            remainingTime = 14400
        ElseIf Life.Value >= 6 Then
            Life.Value = 5
        End If
    End Sub

    Private Sub Life_KeyDown(sender As Object, e As KeyEventArgs) Handles Life.KeyDown
        If Life.Value = 4 Then
            timerCountdown.Start()
        End If
    End Sub
    ' 音声通知を生成して再生
    Private Sub SpeakNotification(message As String)
        Try
            synthesizer.SpeakAsync(message)
        Catch ex As Exception
            MessageBox.Show("音声通知の生成中にエラーが発生しました。", "エラー")
        End Try
    End Sub


    '------------------------------------------
    'UI
    '------------------------------------------
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost() = True
        Else
            Me.TopMost() = False
        End If
    End Sub
End Class
