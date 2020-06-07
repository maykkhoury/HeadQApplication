Imports System.Drawing.Imaging

Public Class colorOpacity

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255)
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.BackgroundImage = SetImgOpacity(PictureBox1.BackgroundImage, 0.5)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox2.BackgroundImage = SetImgOpacity(PictureBox2.BackgroundImage, 0)
    End Sub
    Public Shared Function SetImgOpacity(ByVal imgPic As Image, ByVal imgOpac As Single) As Image

        Dim bmpPic As New Bitmap(imgPic.Width, imgPic.Height)
        Dim gfxPic As Graphics = Graphics.FromImage(bmpPic)
        Dim cmxPic As New ColorMatrix()
        Dim iaPic As New ImageAttributes()

        cmxPic.Matrix33 = imgOpac

        iaPic.SetColorMatrix(cmxPic, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        gfxPic.DrawImage(imgPic, New Rectangle(0, 0, bmpPic.Width, bmpPic.Height), 0, 0, imgPic.Width, imgPic.Height, GraphicsUnit.Pixel, iaPic)

        gfxPic.Dispose()
        iaPic.Dispose()

        Return bmpPic

    End Function
End Class