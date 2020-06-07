Imports System
Imports System.IO
Imports System.IO.Packaging
Imports System.Text

Public Class MyFileCompression
    Private Shared Sub Main(ByVal args As String())
        Dim zipFileName As String = "c:\temp\test.zip"

        Using package As Package = ZipPackage.Open(zipFileName, FileMode.Create)
            Dim startFolder As String = "C:\temp\ephortedata"

            For Each currentFile As String In Directory.GetFiles(startFolder, "*.*", SearchOption.AllDirectories)
                Console.WriteLine("Packing " & currentFile)
                Dim relUri As Uri = GetRelativeUri(currentFile)
                Dim packagePart As PackagePart = package.CreatePart(relUri, System.Net.Mime.MediaTypeNames.Application.Octet, CompressionOption.Maximum)

                Using fileStream As FileStream = New FileStream(currentFile, FileMode.Open, FileAccess.Read)
                    CopyStream(fileStream, packagePart.GetStream())
                End Using
            Next
        End Using
    End Sub

    Public Sub compressFile(ByVal filePath As String, ByVal fileName As String)




        Dim destinationFileName As String = fileName & "." & Now.Year & Now.Month & Now.Day & "-" & Now.Hour & "." & Now.Minute & "." & Now.Second

        Dim zipFileName As String = filePath & "\" & destinationFileName & ".zip"


        File.Copy(filePath & "\" & fileName, filePath & "\" & destinationFileName)

        Dim fileToZip As String = filePath & "\" & destinationFileName

        Using package As Package = ZipPackage.Open(zipFileName, FileMode.Create)
            'Dim startFolder As String = "C:\temp\ephortedata"

            'For Each currentFile As String In Directory.GetFiles(startFolder, "*.*", SearchOption.AllDirectories)
            Console.WriteLine("Packing " & fileToZip)
            Dim relUri As Uri = GetRelativeUri(fileToZip)
            Dim packagePart As PackagePart = package.CreatePart(relUri, System.Net.Mime.MediaTypeNames.Application.Octet, CompressionOption.Maximum)

            Using fileStream As FileStream = New FileStream(fileToZip, FileMode.Open, FileAccess.Read)
                CopyStream(fileStream, packagePart.GetStream())
            End Using
            ' Next
        End Using

        File.Delete(filePath & "\" & destinationFileName)
    End Sub

    Private Shared Sub CopyStream(ByVal source As Stream, ByVal target As Stream)
        Const bufSize As Integer = 16384
        Dim buf As Byte() = New Byte(16383) {}
        Dim bytesRead As Integer = 0

        While (CSharpImpl.__Assign(bytesRead, source.Read(buf, 0, bufSize))) > 0
            target.Write(buf, 0, bytesRead)
        End While
    End Sub

    Private Shared Function GetRelativeUri(ByVal currentFile As String) As Uri
        Dim relPath As String = currentFile.Substring(currentFile.IndexOf("\"c)).Replace("\"c, "/"c).Replace(" "c, "_"c)
        Return New Uri(RemoveAccents(relPath), UriKind.Relative)
    End Function

    Private Shared Function RemoveAccents(ByVal input As String) As String
        Dim normalized As String = input.Normalize(NormalizationForm.FormKD)
        Dim removal As Encoding = Encoding.GetEncoding(Encoding.ASCII.CodePage, New EncoderReplacementFallback(""), New DecoderReplacementFallback(""))
        Dim bytes As Byte() = removal.GetBytes(normalized)
        Return Encoding.ASCII.GetString(bytes)
    End Function

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
