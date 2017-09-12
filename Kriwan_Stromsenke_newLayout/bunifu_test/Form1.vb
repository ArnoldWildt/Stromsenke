Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class Form1


    Dim WithEvents SerialPort As New Ports.SerialPort
    Dim selPort As String
    Dim PortRec As String
    Dim Volt As String
    Dim Curr As String
    Dim Started As Boolean
    Dim dot As Char = "."

    Private _Encoding As System.Text.Encoding

    'Encoding
    Public Sub New()
        InitializeComponent()
        _Encoding = System.Text.Encoding.Default
    End Sub

    ' On Load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SerialPort.BaudRate = 9600
        SerialPort.DataBits = 8
        SerialPort.StopBits = StopBits.One
        SerialPort.Handshake = Handshake.None
        SerialPort.Parity = Parity.None

        SPSetup()
    End Sub

    'On DataReceived
    Public Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived

        Dim ToRead As Integer = SerialPort.BytesToRead
        If ToRead > 0 Then
            Dim Buffer(ToRead - 1) As Byte
            SerialPort.Read(Buffer, 0, ToRead)
            PortRec &= _Encoding.GetString(Buffer)

        End If
    End Sub
    ' Button Play / Stop
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles start_stop.Click
        btnpress()
    End Sub

    ' Button Port Scan
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles portscan.Click
        SPSetup()
    End Sub

    ' Button X Close
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        If Started Then
            If MessageBox.Show("Das Programm läuft noch! Wirklich schließen?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                SerialPort.Open()
                SerialPort.Write("C$")
                Application.Exit()
            End If
        Else
            Application.Exit()
        End If
    End Sub

    Public Sub SPSetup()
        start_stop.Enabled = False
        start_stop.OnHovercolor = Color.Gray
        For Each Port As String In My.Computer.Ports.SerialPortNames
            If SerialPort.IsOpen = True Then
                SerialPort.Close()
            End If

            PortRec = Nothing
            SerialPort.PortName = Port
            SerialPort.Open()
            SerialPort.Write("A$")
            Threading.Thread.Sleep(100)

            If Not PortRec = Nothing Then
                'ListBox1.Items.Add(PortRec) ' Debugging
                If PortRec.Contains("Arduino") Then
                    portlabel.Text = "Arduino Port: " + Port
                    start_stop.Enabled = True
                    start_stop.OnHovercolor = Color.FromArgb(36, 129, 77)
                    start_stop.Activecolor = Color.FromArgb(36, 129, 77)
                    start_stop.Iconimage = My.Resources.icons8_Play_50
                    SerialPort.Close()
                    Return
                End If
            End If
        Next
    End Sub

    Public Sub checkempty(str)
        If String.IsNullOrEmpty(str) Then
            MessageBox.Show("Keine Daten von dem Arduino bekommen! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'tacho
        End If
        PortRec = Nothing
    End Sub

    Private Sub mAbox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mAbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnpress()
        End If
    End Sub
    Private Sub Vbox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Vbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnpress()
        End If
    End Sub

    Private Sub btnpress()

        Dim countdotV As Integer = 0
        Dim countdotmA As Integer = 0

        If Started Then
            SerialPort.Open()

            SerialPort.Write("C$")
            start_stop.Text = "Start"

            TrueV.Text = "0 V"
            TruemA.Text = "0 mA"
            barV.Value = 0
            barmA.Value = 0
            start_stop.OnHovercolor = Color.FromArgb(36, 129, 77)
            start_stop.Activecolor = Color.FromArgb(36, 129, 77)
            start_stop.Iconimage = My.Resources.icons8_Play_50
            SerialPort.Close()

            Vbox.Enabled = True
            mAbox.Enabled = True
            Started = False


        Else

            If mAbox.text.Contains(".") Then
                mAbox.text = mAbox.text.Replace(".", ",")
            End If
            If Vbox.text.Contains(".") Then
                Vbox.text = Vbox.text.Replace(".", ",")
            End If

            For Each textchar In Vbox.text
                If textchar = dot Then
                    countdotV += 1
                End If
            Next

            For Each textchar In mAbox.text
                If textchar = dot Then
                    countdotmA += 1
                End If
            Next

            If String.IsNullOrEmpty(Vbox.text) Or String.IsNullOrEmpty(mAbox.text) Then
                MessageBox.Show("Die Zeile darf nicht Leer sein!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf countdotV > 0 Or countdotmA > 0 Then
                MessageBox.Show("Zu viele Trennungen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf Not IsNumeric(Vbox.text) Or Not IsNumeric(mAbox.text) Then
                MessageBox.Show("Nur Ziffern erlaubt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf Vbox.text < 5 Or Vbox.text > 30 Then
                MessageBox.Show("Spannungsgrenze muss zwischen 5V - 30V liegen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf mAbox.text < 10 Or mAbox.text > 1000 Then
                MessageBox.Show("Strom muss zwischen 10mA - 1000mA liegen! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                SerialPort.Open()
                PortRec = Nothing

                Dim cont_mabox = mAbox.text
                Dim doub_mabox = System.Convert.ToDouble(cont_mabox)
                doub_mabox = Math.Round(doub_mabox, 1)
                Dim str_mabox = doub_mabox.ToString


                Dim cont_vbox = Vbox.text
                Dim doub_vbox = System.Convert.ToDouble(cont_vbox)
                doub_vbox = Math.Round(doub_vbox, 1)
                Dim str_vbox = doub_vbox.ToString


                Volt = "V " + str_vbox + "$"
                Curr = "I " + str_mabox + "$"

                str_vbox = str_vbox.Replace(".", ",")
                str_mabox = str_mabox.Replace(".", ",")

                TrueV.Text = str_vbox + " V"
                TruemA.Text = str_mabox + " mA"

                barV.Value = str_vbox
                barmA.Value = str_mabox

                SerialPort.Write(Volt)
                Threading.Thread.Sleep(100)
                checkempty(PortRec)

                SerialPort.Write(Curr)
                Threading.Thread.Sleep(100)
                checkempty(PortRec)

                Vbox.text = ""
                mAbox.text = ""

                SerialPort.Close()
                portscan.Enabled = False
                Vbox.Enabled = False
                mAbox.Enabled = False
                start_stop.Text = "Stop"
                start_stop.OnHovercolor = Color.FromArgb(255, 51, 51)
                start_stop.Activecolor = Color.FromArgb(255, 51, 51)
                start_stop.Iconimage = My.Resources.icons8_Delete_50
                Started = True
            End If
        End If
    End Sub
End Class


