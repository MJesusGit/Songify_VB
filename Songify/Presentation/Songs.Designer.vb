﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Songs
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Songs))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.songNametxt = New System.Windows.Forms.Label()
        Me.AlbumSongtxt = New System.Windows.Forms.Label()
        Me.SongLengthtxt = New System.Windows.Forms.Label()
        Me.GoBackBtn = New System.Windows.Forms.Button()
        Me.lbl_profile = New System.Windows.Forms.Label()
        Me.EmailLog = New System.Windows.Forms.Label()
        Me.Songtxt = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.historytxt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_fav = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(60, 143)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(231, 500)
        Me.ListBox1.TabIndex = 0
        '
        'songNametxt
        '
        Me.songNametxt.AutoSize = True
        Me.songNametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.songNametxt.Location = New System.Drawing.Point(645, 143)
        Me.songNametxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.songNametxt.Name = "songNametxt"
        Me.songNametxt.Size = New System.Drawing.Size(95, 31)
        Me.songNametxt.TabIndex = 1
        Me.songNametxt.Text = "Label1"
        '
        'AlbumSongtxt
        '
        Me.AlbumSongtxt.AutoSize = True
        Me.AlbumSongtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.AlbumSongtxt.Location = New System.Drawing.Point(645, 281)
        Me.AlbumSongtxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AlbumSongtxt.Name = "AlbumSongtxt"
        Me.AlbumSongtxt.Size = New System.Drawing.Size(95, 31)
        Me.AlbumSongtxt.TabIndex = 2
        Me.AlbumSongtxt.Text = "Label2"
        '
        'SongLengthtxt
        '
        Me.SongLengthtxt.AutoSize = True
        Me.SongLengthtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.SongLengthtxt.Location = New System.Drawing.Point(645, 436)
        Me.SongLengthtxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SongLengthtxt.Name = "SongLengthtxt"
        Me.SongLengthtxt.Size = New System.Drawing.Size(95, 31)
        Me.SongLengthtxt.TabIndex = 3
        Me.SongLengthtxt.Text = "Label3"
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.Location = New System.Drawing.Point(47, 798)
        Me.GoBackBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(137, 52)
        Me.GoBackBtn.TabIndex = 12
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'lbl_profile
        '
        Me.lbl_profile.AutoSize = True
        Me.lbl_profile.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_profile.Location = New System.Drawing.Point(16, 22)
        Me.lbl_profile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_profile.Name = "lbl_profile"
        Me.lbl_profile.Size = New System.Drawing.Size(159, 29)
        Me.lbl_profile.TabIndex = 13
        Me.lbl_profile.Text = "Logged as:"
        '
        'EmailLog
        '
        Me.EmailLog.AutoSize = True
        Me.EmailLog.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmailLog.Location = New System.Drawing.Point(192, 22)
        Me.EmailLog.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailLog.Name = "EmailLog"
        Me.EmailLog.Size = New System.Drawing.Size(78, 29)
        Me.EmailLog.TabIndex = 14
        Me.EmailLog.Text = "rfjpe"
        '
        'Songtxt
        '
        Me.Songtxt.AutoSize = True
        Me.Songtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Songtxt.ForeColor = System.Drawing.Color.White
        Me.Songtxt.Location = New System.Drawing.Point(983, 517)
        Me.Songtxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Songtxt.Name = "Songtxt"
        Me.Songtxt.Size = New System.Drawing.Size(86, 29)
        Me.Songtxt.TabIndex = 16
        Me.Songtxt.Text = "Label1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(844, 615)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(353, 28)
        Me.ProgressBar1.TabIndex = 17
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(343, 143)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(231, 500)
        Me.ListBox2.TabIndex = 19
        '
        'historytxt
        '
        Me.historytxt.AutoSize = True
        Me.historytxt.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historytxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.historytxt.Location = New System.Drawing.Point(20, 62)
        Me.historytxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.historytxt.Name = "historytxt"
        Me.historytxt.Size = New System.Drawing.Size(154, 29)
        Me.historytxt.TabIndex = 20
        Me.historytxt.Text = "History of:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(192, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "rfjpe"
        '
        'Play
        '
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Play.Image = Global.Songify.My.Resources.Resources.jugar1
        Me.Play.Location = New System.Drawing.Point(977, 754)
        Me.Play.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(93, 60)
        Me.Play.TabIndex = 18
        Me.Play.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(821, 79)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(412, 389)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(467, 670)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(108, 70)
        Me.btn_delete.TabIndex = 24
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Image = Global.Songify.My.Resources.Resources.actualizar
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update.Location = New System.Drawing.Point(184, 670)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(108, 70)
        Me.btn_update.TabIndex = 23
        Me.btn_update.Text = "Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.Color.Black
        Me.btn_insert.Image = CType(resources.GetObject("btn_insert.Image"), System.Drawing.Image)
        Me.btn_insert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insert.Location = New System.Drawing.Point(60, 670)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(108, 70)
        Me.btn_insert.TabIndex = 22
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_fav
        '
        Me.btn_fav.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fav.ForeColor = System.Drawing.Color.Black
        Me.btn_fav.Image = Global.Songify.My.Resources.Resources.estrella
        Me.btn_fav.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_fav.Location = New System.Drawing.Point(343, 670)
        Me.btn_fav.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_fav.Name = "btn_fav"
        Me.btn_fav.Size = New System.Drawing.Size(108, 70)
        Me.btn_fav.TabIndex = 25
        Me.btn_fav.Text = "Favorite"
        Me.btn_fav.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_fav.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 32)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Songs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(321, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 32)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Favourite songs"
        '
        'Songs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1268, 879)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_fav)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.historytxt)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Songtxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EmailLog)
        Me.Controls.Add(Me.lbl_profile)
        Me.Controls.Add(Me.GoBackBtn)
        Me.Controls.Add(Me.SongLengthtxt)
        Me.Controls.Add(Me.AlbumSongtxt)
        Me.Controls.Add(Me.songNametxt)
        Me.Controls.Add(Me.ListBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Songs"
        Me.Text = "Songs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents songNametxt As Label
    Friend WithEvents AlbumSongtxt As Label
    Friend WithEvents SongLengthtxt As Label
    Friend WithEvents GoBackBtn As Button
    Friend WithEvents lbl_profile As Label
    Friend WithEvents EmailLog As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Songtxt As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Play As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents historytxt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_fav As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
