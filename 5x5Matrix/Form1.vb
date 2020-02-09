Public Class Form1
    Dim a, b, c, d As Boolean

    Private counter As Byte
    Private bin As Byte


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
    End Sub

    Private Sub TurnOn(i As Boolean, LED As PictureBox)
        If i Then
            LED.Image = My.Resources._on
        Else
            LED.Image = My.Resources.off
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        bin = counter

        a = Convert.ToBoolean(bin >= 8)

        If a Then
            bin -= 8
        End If

        b = Convert.ToBoolean(bin >= 4)

        If b Then
            bin -= 4
        End If

        c = Convert.ToBoolean(bin >= 2)

        If c Then
            bin -= 2
        End If

        d = Convert.ToBoolean(bin >= 1)

        If d Then
            bin -= 1
        End If


        TurnOn(Convert.ToBoolean((c And (Not b Or d)) Or (b And Not c)), PictureBox1)
        TurnOn(Convert.ToBoolean(c Or a Or Not (b Xor d)), PictureBox2)
        TurnOn(Convert.ToBoolean(Not b Or d Or c), PictureBox3)
        TurnOn(Convert.ToBoolean(c Or a Or Not (b Xor d)), PictureBox4)
        TurnOn(b, PictureBox5)
        TurnOn(Convert.ToBoolean(a Or (Not c And Not d) Or (b And (Not c Or Not d))), PictureBox6)
        TurnOn(Convert.ToBoolean(Not a And Not b And Not c And d), PictureBox7)
        TurnOn(Convert.ToBoolean(Not a And Not b And Not c And d), PictureBox8)
        TurnOn(Convert.ToBoolean(a Or (Not b And Not d) Or Not (c Xor d)), PictureBox10)
        TurnOn(Convert.ToBoolean((Not a And Not b And Not c And Not d) Or (b And (c Xor d))), PictureBox11)
        TurnOn(Convert.ToBoolean(a Or (c And Not d) Or (b And Not c)), PictureBox12)
        TurnOn(Convert.ToBoolean(Not b Or Not c Or Not d), PictureBox13)
        TurnOn(Convert.ToBoolean(a Or b Or c), PictureBox14)
        TurnOn(Convert.ToBoolean((Not a And Not c And Not d) Or (a And d)), PictureBox15)
        TurnOn(Convert.ToBoolean(Not d And (Not b Or c)), PictureBox16)
        TurnOn(Convert.ToBoolean(Not a And Not b And Not c And Not d), PictureBox18)
        TurnOn(Convert.ToBoolean(d And b And c), PictureBox19)
        TurnOn(Convert.ToBoolean(a Or (Not c And Not d) Or (Not b And c And d) Or (b And (Not c Or Not d))), PictureBox20)
        'TurnOn(Convert.ToBoolean((Not b And Not c) Or (b And Not c And d)), PictureBox21)



        If counter = 9 Then
            counter = 0
        Else
            counter += 1
        End If
    End Sub
End Class
