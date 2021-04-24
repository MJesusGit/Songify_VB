﻿Public Class Queries
    Public path As String
    Public Email As String
    Private Sub GoBackBtn_Click(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow(Email, path)
        f2.Show()
        Me.Hide()
    End Sub
    Public Sub New(path As String, Email As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.path = path
        Me.Email = Email
    End Sub
    Private Sub firstQuerie_Click(sender As Object, e As EventArgs) Handles firstQuerie.Click
        ListBox1.Items.Clear()
        ListBox1.Visible = True
        ListBox2.Visible = False
        ListBox3.Visible = False
        ListBox4.Visible = False
        playbackTime.Visible = False
        lblSeconds.Visible = False
        Dim ArtistDAO As New Artist : Dim ListQuery1 As Collection
        ListQuery1 = ArtistDAO.Query1(path)
        For Each aName In ListQuery1
            ListBox1.Items.Add(aName)
        Next


    End Sub

    Private Sub firstQuerieCountry_Click(sender As Object, e As EventArgs) Handles firstquerieCountry.Click
        ListBox1.Items.Clear()
        ListBox1.Visible = True
        ListBox2.Visible = False
        ListBox3.Visible = False
        ListBox4.Visible = False
        playbackTime.Visible = False
        lblSeconds.Visible = False
        Dim country As String
        country = TextBox1.Text
        If country IsNot "" Then
            Dim ArtistDAO As New Artist : Dim ListQuery1Country As Collection
            Try
                ListQuery1Country = ArtistDAO.Query2(path, country)
                For Each aName In ListQuery1Country
                    ListBox1.Items.Add(aName)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            MsgBox("You must write a country to filter")
        End If

    End Sub

    Private Sub SecondQuerie_Click(sender As Object, e As EventArgs) Handles SecondQuerie.Click
        ListBox2.Items.Clear()
        ListBox1.Visible = False
        ListBox2.Visible = True
        ListBox3.Visible = False
        ListBox4.Visible = False
        playbackTime.Visible = False
        lblSeconds.Visible = False
        Dim SongDAO As New Song : Dim ListQuery2 As Collection
        ListQuery2 = SongDAO.Query2(path)
        For Each sName In ListQuery2
            ListBox2.Items.Add(sName)
        Next
    End Sub

    Private Sub thirdQuerie_Click(sender As Object, e As EventArgs) Handles thirdQuerie.Click
        ListBox3.Items.Clear()
        ListBox1.Visible = False
        ListBox2.Visible = False
        ListBox3.Visible = True
        ListBox4.Visible = False
        playbackTime.Visible = False
        lblSeconds.Visible = False
        Dim Date1 As Date : Dim Date2 As Date : Dim fecha1 As String : Dim fecha2 As String
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("You must write 2 dates")
        Else
            Date1 = TextBox2.Text
            Date2 = TextBox3.Text
            fecha1 = Format(Date1, "dd/MM/yyyy")
            fecha2 = Format(Date2, "dd/MM/yyyy")
            If fecha1 IsNot Nothing And fecha2 IsNot Nothing Then
                If Date1 > Date2 Then
                    MsgBox("The end date must be higher than the start date")
                Else
                    Dim ArtistDAO As New Artist : Dim ListQuery3 As Collection
                    Try
                        ListQuery3 = ArtistDAO.Query3(path, CDate(fecha1), CDate(fecha2), Email)
                        For Each aName In ListQuery3
                            ListBox3.Items.Add(aName)
                        Next
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                End If

            Else
                MsgBox("You must write 2 dates for the interval")
            End If
        End If

    End Sub

    Private Sub fourthQuerie_Click(sender As Object, e As EventArgs) Handles fourthQuerie.Click
        ListBox4.Items.Clear()
        ListBox1.Visible = False
        ListBox2.Visible = False
        ListBox3.Visible = False
        ListBox4.Visible = True
        playbackTime.Visible = False
        lblSeconds.Visible = False
        Dim SongDAO As New Song : Dim ListQuery4 As Collection
        ListQuery4 = SongDAO.Query4(path)
        For Each sName In ListQuery4
            ListBox4.Items.Add(sName)
        Next

    End Sub

    Private Sub fifthQuerie_Click(sender As Object, e As EventArgs) Handles fifthQuerie.Click
        playbackTime.Visible = True
        lblSeconds.Visible = True
        ListBox1.Visible = False
        ListBox2.Visible = False
        ListBox3.Visible = False
        ListBox4.Visible = False
        Dim ArtistDAO As New Artist : Dim ListQuery5 As Collection
        ListQuery5 = ArtistDAO.Query5(path, Email)
        Dim length As String
        length = CalcularTiempo(ListQuery5(1))
        lblSeconds.Text = length
        playbackTime.Text = Email
    End Sub
    Private Function CalcularTiempo(length As Integer)
        Dim horas As Integer : Dim minutos As Integer : Dim segundos As Integer : Dim horatotal As String
        horas = Math.Floor(length / 3600)
        minutos = Math.Floor((length - horas * 3600) / 60)
        segundos = length - (horas * 3600 + minutos * 60)
        horatotal = horas & ":" & minutos & ":" & segundos
        Return horatotal
    End Function

    Private Sub Queries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class