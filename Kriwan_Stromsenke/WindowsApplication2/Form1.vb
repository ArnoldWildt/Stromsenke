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

    Private _Encoding As System.Text.Encoding

    Public Sub New()
        InitializeComponent()
        _Encoding = System.Text.Encoding.Default
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SerialPort.BaudRate = 9600
        SerialPort.DataBits = 8
        SerialPort.StopBits = StopBits.One
        SerialPort.Handshake = Handshake.None
        SerialPort.Parity = Parity.None

        SPSetup()
    End Sub

    Private Sub closemsg_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Started Then
            If MessageBox.Show("Das Programm läuft noch! Wirklich schließen?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                SerialPort.Open()
                SerialPort.Write("C$")
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Public Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived

        Dim ToRead As Integer = SerialPort.BytesToRead
        If ToRead > 0 Then
            Dim Buffer(ToRead - 1) As Byte
            SerialPort.Read(Buffer, 0, ToRead)
            PortRec &= _Encoding.GetString(Buffer)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Started Then
            SerialPort.Open()

            SerialPort.Write("C$")
            Button1.Text = "Start"
            Button1.BackColor = Color.Green
            SerialPort.Close()

            TextBox1.Enabled = True
            TextBox2.Enabled = True
            Started = False
        Else
            If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Then
                MessageBox.Show("Zeile Leer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf Not IsNumeric(TextBox1.Text) Or Not IsNumeric(TextBox2.Text) Then
                MessageBox.Show("Keine Nummer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf TextBox1.Text < 5 Or TextBox1.Text > 30 Then
                MessageBox.Show("Spannungsgrenze muss zwischen 5V - 30V liegen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf TextBox2.Text < 10 Or TextBox2.Text > 1000 Then
                MessageBox.Show("Strom muss zwischen 10mA - 1000mA liegen! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                SerialPort.Open()
                PortRec = Nothing
                ListBox1.Items.Clear()

                Volt = "V " + TextBox1.Text + "$"
                Curr = "I " + TextBox2.Text + "$"

                SerialPort.Write(Volt)
                Threading.Thread.Sleep(100)
                checkempty(PortRec)

                SerialPort.Write(Curr)
                Threading.Thread.Sleep(100)
                checkempty(PortRec)

                TextBox1.Clear()
                TextBox2.Clear()

                SerialPort.Close()
                Button2.Enabled = False
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                Button1.Text = "Stop"
                Button1.BackColor = Color.Red
                Started = True
            End If
        End If
    End Sub

    Public Sub SPSetup()
        Button1.Enabled = False
        Button1.BackColor = Color.Gray
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
                ListBox1.Items.Add(PortRec) ' Debugging
                If PortRec.Contains("Arduino") Then
                    Label3.Text = "Arduino Port: " + Port
                    Button1.Enabled = True
                    Button1.BackColor = Color.Green
                    SerialPort.Close()
                    Return
                End If
            End If

        Next
    End Sub

    Public Sub checkempty(str)
        If String.IsNullOrEmpty(str) Then
            ListBox1.Items.Add("Empty")
        Else
            ListBox1.Items.Add(PortRec)
        End If
        PortRec = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SPSetup()
    End Sub


End Class
