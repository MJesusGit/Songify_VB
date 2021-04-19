﻿Imports System.IO
Imports System.Net

Public Class Artists
    Public SelectedArtist As Artist
    Public Artists As Collection
    Public EmailUser As String
    Public path As String
    Private Sub Artists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aName.Text = ""
        aName.Visible = False
        country.Text = ""
        country.Visible = False
        EmailLog.Text = EmailUser
        Dim ArtistDAO As Artist
        ArtistDAO = New Artist()
        Artists = ArtistDAO.ReadAllArtists(path)
        For Each artist In Artists
            lsb_artist.Items.Add(artist.GetName())
        Next
        btnFav.Enabled = False




    End Sub
    Public Sub New(EmailUser As String, path As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.EmailUser = EmailUser
        Me.path = path
    End Sub

    Private Sub loadData(sender As Object, e As EventArgs) Handles lsb_artist.SelectedIndexChanged
        lst_album.Items.Clear()
        Dim Albums As Collection : Dim AlbumDAO As Album : Dim ArtistName As String : Dim wc As New WebClient()

        AlbumDAO = New Album()
        Albums = AlbumDAO.ReadAllAlbums(path)
        ArtistName = lsb_artist.SelectedItem
        For Each artist In Artists
            If artist.GetName() = ArtistName Then
                SelectedArtist = artist
            End If
        Next
        For Each album In Albums
            If SelectedArtist.GetIdArtist() = album.GetArtist() Then
                lst_album.Items.Add(album.GetName())
            End If
        Next

        Dim datos As Byte() = wc.DownloadData(SelectedArtist.GetImage())
        Dim ms As New MemoryStream(datos)
        aName.Visible = True
        aName.Text = SelectedArtist.GetName()
        country.Visible = True
        country.Text = SelectedArtist.GetCountry()
        im_artists.Image = Image.FromStream(ms)

        btnFav.Enabled = True
    End Sub

    Private Sub CovertArtistToFav(sender As Object, e As EventArgs) Handles btnFav.Click
        lsb_favArtist.Items.Clear()
        Dim ArtistsCollection As Collection : Dim Selected_Artist As String : Dim ArtistDAO As Artist : Dim Fav_Artists As Collection : Dim Fav_Artist As String
        ArtistDAO = New Artist()
        ArtistsCollection = ArtistDAO.ReadAllArtists(path)
        Selected_Artist = lsb_artist.SelectedItem
        For Each Artist In ArtistsCollection
            If Selected_Artist = Artist.GetName() Then
                SelectedArtist = Artist
            End If
        Next
        Dim FavArtist As Fav_Artist
        FavArtist = New Fav_Artist()
        FavArtist.setUser(EmailUser)
        FavArtist.setArtist(SelectedArtist.GetIdArtist())
        FavArtist.setFavDate(Date.Today())
        FavArtist.InsertFavArtist()
    End Sub

    Private Sub ReadAllFavArtists 

    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow(EmailUser, path)
        f2.Show()
        Me.Hide()
    End Sub


End Class