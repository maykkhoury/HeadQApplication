Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO.Compression

Module GlobalVariables
    Public languages() As Language
    Public units() As Unit
    Public colors() As Color
    Public currencies() As Currency
    'Public formulas() As Formula
    ' Public formulaColor() As FormulaColor
    Public curFormulas() As Formula
    Public curFamily() As Formula
    Public curFamilyInEditSync() As Formula
    Public curFamilyInDeleteSync() As Formula
    ' Public curSubFamily() As Formula
    Public labels() As Label
    Public chosenGarage As Garage
    Public chosenLanguage As Language
    Public chosenUnit As Unit
    Public chosenCurrency As Currency
    Public selectedFormulaColors() As FormulaColor
    Public ratio As Decimal
    Public idLangTranslate As Long
    Public imageToPreview As Image
    Public fromAddFormula As Boolean = False
    Public fromEditFormula As Boolean = False
    Public addDuplicate As Boolean = False
    Public variants(10) As FormulaVariants
    Public chosenFormula As Formula = Nothing
    Public chosenPrintTransaction As Transaction = Nothing
    Public chosenPrintFormula As Formula = Nothing
    Public encryptionActive As Integer = 1
    Public currentLastSyncVersion As Integer = -1
    Public currentDbUpdatesFile As String = Nothing

    Public syncFormulasToEdit As Hashtable = Nothing
    Public syncFormulasToDelete As Hashtable = Nothing

    Public syncGaragesToEdit As Hashtable = Nothing
    Public syncGaragesToDelete As Hashtable = Nothing

    Public syncColorsToEdit As Hashtable = Nothing
    Public syncColorsToDelete As Hashtable = Nothing

    Public syncCarsToEdit As Hashtable = Nothing
    Public syncCarsToDelete As Hashtable = Nothing
    Public ftp_mobile_uri As String = "FTP://ftp.amazonapaints.com/"
    Public ftp_mobile_username As String = "amazona001_mk@amazonapaints.com"
    Public ftp_mobile_password As String = "k<Yd*C$.2"

    Public ftp_garageupload_uri As String = "FTP://ftp.amazonapaints.com/"
    Public ftp_garageupload_username As String = "amazona002_mk@amazonapaints.com"
    Public ftp_garageupload_password As String = "k<Yd*C$.2"


#Region "Application start"
    Public Sub setVariables()
        'MsgBox("conString:" & conString, MsgBoxStyle.Information)

        languages = getLanguages()
        units = getUnits()
        colors = getColors()
        currencies = getCurrencies()
        'formulas = getFormulas()
        labels = getLabels()
        'formulaColor = getFormulaColor()
        chosenGarage = getChosenGarage()
        If Not chosenGarage Is Nothing Then
            chosenLanguage = getLanguage(chosenGarage.id_language)
        End If
        If Not units Is Nothing And chosenUnit Is Nothing Then
            chosenUnit = getChosenUnit()
        End If
        If Not currencies Is Nothing And chosenCurrency Is Nothing Then
            chosenCurrency = getChosenCurreny()
        End If
        setVariants()

        initSyncObject()
        setCurrentLastSyncedVersionFTP()

    End Sub

    Public Function isInternetAccessEnabled() As Boolean
        Dim checkinternet As Boolean = True
        Try
            Dim fileContent As String = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory() & "//checkinternet.txt", Encoding.UTF8)
            If fileContent.ToLower.Trim = "false" Then
                checkinternet = False
            End If
        Catch ex As Exception
        End Try
        Return checkinternet
    End Function

    Private Sub FtpUploadFile(ByVal filetoupload As Byte(), ByVal filenameToupload As String, ByVal ftpuri As String,
                              ByVal ftpusername As String, ByVal ftppassword As String)
        If Not isInternetAccessEnabled() Then
            Return
        End If
        ' Create a web request that will be used to talk with the server and set the request method to upload a file by ftp.
        Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri & filenameToupload), FtpWebRequest)

        Try
            'ftpRequest.UsePassive = False
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile
            ftpRequest.KeepAlive = False
            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True

            ftpRequest.Timeout = 10000000
            ftpRequest.ReadWriteTimeout = 10000000
            ' Confirm the Network credentials based on the user name and password passed in.
            ftpRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)

            ' Read into a Byte array the contents of the file to be uploaded 
            Dim bytes() As Byte = filetoupload

            ' Transfer the byte array contents into the request stream, write and then close when done.
            ftpRequest.ContentLength = bytes.Length
            Using UploadStream As Stream = ftpRequest.GetRequestStream()
                UploadStream.Write(bytes, 0, bytes.Length)
                UploadStream.Close()
            End Using
        Catch ex As Exception
            'ExceptionInfo = ex
            Dim webex As WebException = CType(ex, WebException)
            Dim ftpRes As FtpWebResponse = CType(webex.Response, FtpWebResponse)
            Dim status As String = ftpRes.StatusDescription
            MessageBox.Show(ex.Message & vbNewLine & status)
            Exit Sub
        End Try
    End Sub
    Public Sub FtpUploadFileForDesktop(ByVal filetoupload As Byte(), ByVal filenameToupload As String)
        FtpUploadFile(filetoupload, filenameToupload, ftp_garageupload_uri, ftp_garageupload_username, ftp_garageupload_password)
    End Sub


    Private Sub FtpUploadFileForMobileApp(ByVal filetoupload As Byte(), ByVal filenameToupload As String)
        FtpUploadFile(filetoupload, filenameToupload, ftp_mobile_uri, ftp_mobile_username, ftp_mobile_password)
    End Sub

    Private Sub deleteFileFTP_mobile(ByVal filenameToDelete As String)
        deleteFileFTP(filenameToDelete, ftp_mobile_uri, ftp_mobile_username, ftp_mobile_password)
    End Sub

    Private Sub deleteFileFTP(ByVal filenameToDelete As String, ByVal ftpuri As String,
                              ByVal ftpusername As String, ByVal ftppassword As String)
        If Not isInternetAccessEnabled() Then
            Return
        End If
        ' Create a web request that will be used to talk with the server and set the request method to upload a file by ftp.
        Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri & filenameToDelete), FtpWebRequest)

        Try
            'ftpRequest.UsePassive = False
            ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile

            ' Confirm the Network credentials based on the user name and password passed in.
            ftpRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)

            ftpRequest.GetResponse()

        Catch ex As Exception
            'ExceptionInfo = ex
            Dim webex As WebException = CType(ex, WebException)
            Dim ftpRes As FtpWebResponse = CType(webex.Response, FtpWebResponse)
            Dim status As String = ftpRes.StatusDescription
            MessageBox.Show(ex.Message & vbNewLine & status)
            Exit Sub
        End Try

    End Sub
    Private Function downloadFileFTP_mobile(ByVal filenameToDownload As String) As String
        downloadFileFTP_mobile = downloadFileFTP(filenameToDownload, ftp_mobile_uri, ftp_mobile_username, ftp_mobile_password)
    End Function

    Private Function downloadFileFTP(ByVal filenameToDownload As String, ByVal ftpuri As String,
                              ByVal ftpusername As String, ByVal ftppassword As String) As String
        If Not isInternetAccessEnabled() Then
            Return Nothing
        End If
        downloadFileFTP = Nothing
        ' Create a web request that will be used to talk with the server and set the request method to upload a file by ftp.
        Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri & filenameToDownload), FtpWebRequest)

        Try
            'ftpRequest.UsePassive = False
            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile

            ' Confirm the Network credentials based on the user name and password passed in.
            ftpRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)


            Dim response As FtpWebResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)

            Dim responseStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(responseStream)
            downloadFileFTP = reader.ReadToEnd()
        Catch ex As Exception
            'ExceptionInfo = ex
            Dim webex As WebException = CType(ex, WebException)
            Dim ftpRes As FtpWebResponse = CType(webex.Response, FtpWebResponse)
            Dim status As String = ftpRes.StatusDescription
            MessageBox.Show(ex.Message & vbNewLine & status)
            Exit Function
        End Try

    End Function


    Public Function appendVersionToUpdateFile(ByVal updatesJSON As String) As String

        Dim versionJsonObject As JObject = JObject.Parse(updatesJSON)
        Dim returnRes As String = Nothing
        Dim ser As JObject = Nothing
        If Not currentDbUpdatesFile Is Nothing Then
            ser = JObject.Parse(currentDbUpdatesFile)
        Else
            ser = JObject.Parse("{ ""updates"":[]}")
        End If

        Dim updatesArray As JArray = ser("updates")

        updatesArray.Add(versionJsonObject)


        returnRes = JsonConvert.SerializeObject(ser)

        Return returnRes
    End Function


    Public Sub putSyncFileFTP(ByVal postData As String)
        Try
            Dim data As Byte() = Encoding.UTF8.GetBytes(postData)
            FtpUploadFileForMobileApp(data, "dbSync.txt")


        Catch ex As Exception
            'MsgBox("Make sure you have internet connection, to be able to do the mobile sync", MsgBoxStyle.Exclamation)
        End Try



    End Sub

    Public Sub putSyncFileREST_notUsedNow(ByVal postData As String)
        Try
            Dim myHttpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://amazonapaintsrest.restlet.net/v1/main/dbSync.txt"), HttpWebRequest)

            'Dim myHttpWebResponse As HttpWebResponse

            myHttpWebRequest.Method = "PUT"

            myHttpWebRequest.KeepAlive = True

            myHttpWebRequest.Accept = "application/json"

            myHttpWebRequest.Headers("Authorization") = "Basic ZmYwYTJhNTQtYjA3ZS00YTI4LWIyOTUtYzI3NzU4NDRjMTc4OjNlMmUyMGEyLTM4ZDItNGZiZC1hZjQ5LTBiOGVmMWNiM2FmYg=="

            myHttpWebRequest.ContentLength = postData.Length

            Dim data As Byte() = Encoding.UTF8.GetBytes(postData)

            Dim stream As Stream = myHttpWebRequest.GetRequestStream()
            stream.Write(data, 0, data.Length)


            stream.Close()


        Catch ex As Exception
            'MsgBox("Make sure you have internet connection, to be able to do the mobile sync", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Public Sub deleteSyncFileFTP()
        Try

            deleteFileFTP_mobile("dbSync.txt")

        Catch ex As Exception
            'MsgBox("Make sure you have internet connection, to be able to do the mobile sync", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Public Sub deleteSyncFileREST_notUsedNow()
        Try
            Dim myHttpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://amazonapaintsrest.restlet.net/v1/main/dbSync.txt"), HttpWebRequest)

            Dim myHttpWebResponse As HttpWebResponse

            myHttpWebRequest.Method = "DELETE"

            myHttpWebRequest.KeepAlive = True

            myHttpWebRequest.Accept = "application/json"

            myHttpWebRequest.Headers("Authorization") = "Basic ZmYwYTJhNTQtYjA3ZS00YTI4LWIyOTUtYzI3NzU4NDRjMTc4OjNlMmUyMGEyLTM4ZDItNGZiZC1hZjQ5LTBiOGVmMWNiM2FmYg=="


            myHttpWebResponse = myHttpWebRequest.GetResponse


            myHttpWebResponse.Close()


        Catch ex As Exception
            'MsgBox("Make sure you have internet connection, to be able to do the mobile sync", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Public Sub setCurrentLastSyncedVersionREST_notUsedNow()

        Try
            Dim myHttpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://amazonapaintsrest.restlet.net/v1/main/dbSync.txt"), HttpWebRequest)

            Dim myHttpWebResponse As HttpWebResponse

            myHttpWebRequest.Method = "GET"

            myHttpWebRequest.KeepAlive = True

            myHttpWebRequest.Accept = "application/json"

            myHttpWebRequest.Headers("Authorization") = "Basic ZmYwYTJhNTQtYjA3ZS00YTI4LWIyOTUtYzI3NzU4NDRjMTc4OjNlMmUyMGEyLTM4ZDItNGZiZC1hZjQ5LTBiOGVmMWNiM2FmYg=="

            Try
                myHttpWebResponse = myHttpWebRequest.GetResponse
            Catch ex As WebException
                currentLastSyncVersion = 1
                'MsgBox("No sync file found, so this will be the first sync data")
                Exit Sub
            End Try

            Dim streamRead As New StreamReader(myHttpWebResponse.GetResponseStream())

            Dim readBuff(256) As [Char]

            Dim count As Integer = streamRead.Read(readBuff, 0, 256)
            currentDbUpdatesFile = ""
            While count > 0
                Dim outputData As New [String](readBuff, 0, count)
                currentDbUpdatesFile = currentDbUpdatesFile & outputData
                count = streamRead.Read(readBuff, 0, 256)
            End While


            myHttpWebResponse.Close()

            ' currentDbUpdatesFile = ""
            Dim ser As JObject = JObject.Parse(currentDbUpdatesFile)
            Dim data As List(Of JToken) = ser.Children().ToList

            For Each item As JProperty In data
                item.CreateReader()
                Select Case item.Name
                    Case "updates"

                        For Each update As JObject In item.Values
                            Dim tmp As Integer = update("version")
                            If tmp > currentLastSyncVersion Then
                                currentLastSyncVersion = tmp
                            End If
                        Next
                End Select
            Next
            currentLastSyncVersion += 1
            If currentLastSyncVersion = 0 Then
                'MsgBox("No sync version found", MsgBoxStyle.Exclamation)
            End If


        Catch ex As Exception
            'MsgBox("Make sure you have internet connection, to be able to do the mobile sync", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Public Sub setCurrentLastSyncedVersionFTP()

        Try

            currentDbUpdatesFile = downloadFileFTP_mobile("dbSync.txt")
            If currentDbUpdatesFile Is Nothing Then
                currentLastSyncVersion = 1
                Exit Sub
            End If
            ' currentDbUpdatesFile = ""
            Dim ser As JObject = JObject.Parse(currentDbUpdatesFile)
            Dim data As List(Of JToken) = ser.Children().ToList

            For Each item As JProperty In data
                item.CreateReader()
                Select Case item.Name
                    Case "updates"

                        For Each update As JObject In item.Values
                            Dim tmp As Integer = update("version")
                            If tmp > currentLastSyncVersion Then
                                currentLastSyncVersion = tmp
                            End If
                        Next
                End Select
            Next
            currentLastSyncVersion += 1
            If currentLastSyncVersion = 0 Then
                'MsgBox("No sync version found", MsgBoxStyle.Exclamation)
            End If


        Catch ex As Exception
            'MsgBox("Make sure you have internet connection, to be able to do the mobile sync", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub setCurrentLastSyncedVersionOld()

        Try

            Dim tempCookies As New CookieContainer
            Dim encoding As New UTF8Encoding
            Dim byteData As Byte() = encoding.GetBytes("test") 'means nothing, just to simulate a POST content

            Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create("https://amazonapaintsrest.restlet.net/v1/main/dbSync.txt"), HttpWebRequest)
            postReq.Method = "POST"
            postReq.KeepAlive = True
            postReq.CookieContainer = tempCookies
            postReq.ContentType = "application/x-www-form-urlencoded"
            postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
            postReq.ContentLength = byteData.Length


            Dim postreqstream As Stream = postReq.GetRequestStream()
            postreqstream.Write(byteData, 0, byteData.Length)
            postreqstream.Close()
            Dim postresponse As HttpWebResponse = Nothing
            Try
                postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
            Catch ex As WebException
                currentLastSyncVersion = 1
                'MsgBox("No sync file found, so this will be the first sync data")
                Exit Sub
            End Try

            tempCookies.Add(postresponse.Cookies)
            Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

            currentDbUpdatesFile = postreqreader.ReadToEnd
            Dim ser As JObject = JObject.Parse(currentDbUpdatesFile)
            Dim data As List(Of JToken) = ser.Children().ToList

            For Each item As JProperty In data
                item.CreateReader()
                Select Case item.Name
                    Case "updates"

                        For Each update As JObject In item.Values
                            Dim tmp As Integer = update("version")
                            If tmp > currentLastSyncVersion Then
                                currentLastSyncVersion = tmp
                            End If
                        Next
                End Select
            Next
            currentLastSyncVersion += 1
            If currentLastSyncVersion = 0 Then
                'MsgBox("No sync version found", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            'MsgBox("Make sure you have internet connection, to be able to do the mobile sync", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Public Sub initSyncObject()
        syncFormulasToEdit = New Hashtable()

        syncFormulasToDelete = New Hashtable()

        syncGaragesToEdit = New Hashtable()
        syncGaragesToDelete = New Hashtable()

        syncColorsToEdit = New Hashtable()
        syncColorsToDelete = New Hashtable()

        syncCarsToEdit = New Hashtable()
        syncCarsToDelete = New Hashtable()
    End Sub

    Private Sub setVariants()

        variants(0) = New FormulaVariants
        variants(0).variantName = "D"
        variants(0).variantColor = Drawing.Color.Black
        variants(0).variantDescription = "Darker"

        Dim imageD As Image
        Dim imgPathD As String = My.Application.Info.DirectoryPath & "//variants//variantD.jpg"
        imageD = Image.FromFile(imgPathD)
        variants(0).variantImage = imageD

        variants(1) = New FormulaVariants
        variants(1).variantName = "F"
        variants(1).variantColor = Drawing.Color.Fuchsia
        variants(1).variantDescription = "Finer"
        Dim imageF As Image
        Dim imgPathF As String = My.Application.Info.DirectoryPath & "//variants//variantF.jpg"
        imageF = Image.FromFile(imgPathF)
        variants(1).variantImage = imageF

        variants(2) = New FormulaVariants
        variants(2).variantName = "DRT"
        variants(2).variantColor = Drawing.Color.DarkTurquoise
        variants(2).variantDescription = "Dirtier"
        Dim imageDRT As Image
        Dim imgPathDRT As String = My.Application.Info.DirectoryPath & "//variants//variantDRT.jpg"
        imageDRT = Image.FromFile(imgPathDRT)
        variants(2).variantImage = imageDRT

        variants(3) = New FormulaVariants
        variants(3).variantName = "L"
        variants(3).variantColor = Drawing.Color.Lime
        variants(3).variantDescription = "Lighter"
        Dim imageL As Image
        Dim imgPathL As String = My.Application.Info.DirectoryPath & "//variants//variantL.jpg"
        imageL = Image.FromFile(imgPathL)
        variants(3).variantImage = imageL

        variants(4) = New FormulaVariants
        variants(4).variantName = "R"
        variants(4).variantColor = Drawing.Color.Red
        variants(4).variantDescription = "Red"
        Dim imageR As Image
        Dim imgPathR As String = My.Application.Info.DirectoryPath & "//variants//variantR.jpg"
        imageR = Image.FromFile(imgPathR)
        variants(4).variantImage = imageR

        variants(5) = New FormulaVariants
        variants(5).variantName = "Y"
        variants(5).variantColor = Drawing.Color.Yellow
        variants(5).variantDescription = "Yellow"
        Dim imageY As Image
        Dim imgPathY As String = My.Application.Info.DirectoryPath & "//variants//variantY.jpg"
        imageY = Image.FromFile(imgPathY)
        variants(5).variantImage = imageY

        variants(6) = New FormulaVariants
        variants(6).variantName = "B"
        variants(6).variantColor = Drawing.Color.Blue
        variants(6).variantDescription = "Blue"
        Dim imageB As Image
        Dim imgPathB As String = My.Application.Info.DirectoryPath & "//variants//variantB.jpg"
        imageB = Image.FromFile(imgPathB)
        variants(6).variantImage = imageB

        variants(7) = New FormulaVariants
        variants(7).variantName = "CO"
        variants(7).variantColor = Drawing.Color.Coral
        variants(7).variantDescription = "Coarser"
        Dim imageCO As Image
        Dim imgPathCO As String = My.Application.Info.DirectoryPath & "//variants//variantCO.jpg"
        imageCO = Image.FromFile(imgPathCO)
        variants(7).variantImage = imageCO

        variants(8) = New FormulaVariants
        variants(8).variantName = "G"
        variants(8).variantColor = Drawing.Color.Green
        variants(8).variantDescription = "Green"
        Dim imageG As Image
        Dim imgPathG As String = My.Application.Info.DirectoryPath & "//variants//variantG.jpg"
        imageG = Image.FromFile(imgPathG)
        variants(8).variantImage = imageG

        variants(9) = New FormulaVariants
        variants(9).variantName = "CL"
        variants(9).variantColor = Drawing.Color.Chocolate
        variants(9).variantDescription = "Cleaner"
        Dim imageCL As Image
        Dim imgPathCL As String = My.Application.Info.DirectoryPath & "//variants//variantCL.jpg"
        imageCL = Image.FromFile(imgPathCL)
        variants(9).variantImage = imageCL

    End Sub

    Private Sub setVariantsTest()

        variants(0) = New FormulaVariants
        variants(0).variantName = "D"
        variants(0).variantColor = Drawing.Color.Black
        variants(0).variantDescription = "Darker"

        variants(1) = New FormulaVariants
        variants(1).variantName = "F"
        variants(1).variantColor = Drawing.Color.Transparent
        variants(1).variantDescription = "::::"

        variants(2) = New FormulaVariants
        variants(2).variantName = "DRT"
        variants(2).variantColor = Drawing.Color.Transparent
        variants(2).variantDescription = "◙"

        variants(3) = New FormulaVariants
        variants(3).variantName = "L"
        variants(3).variantColor = Drawing.Color.White
        variants(3).variantDescription = ""

        variants(4) = New FormulaVariants
        variants(4).variantName = "R"
        variants(4).variantColor = Drawing.Color.Red
        variants(4).variantDescription = "Red"

        variants(5) = New FormulaVariants
        variants(5).variantName = "Y"
        variants(5).variantColor = Drawing.Color.Yellow
        variants(5).variantDescription = "Yellow"

        variants(6) = New FormulaVariants
        variants(6).variantName = "B"
        variants(6).variantColor = Drawing.Color.Blue
        variants(6).variantDescription = "Blue"

        variants(7) = New FormulaVariants
        variants(7).variantName = "CO"
        variants(7).variantColor = Drawing.Color.Transparent
        variants(7).variantDescription = "= = ="

        variants(8) = New FormulaVariants
        variants(8).variantName = "G"
        variants(8).variantColor = Drawing.Color.Green
        variants(8).variantDescription = "Green"

        variants(9) = New FormulaVariants
        variants(9).variantName = "CL"
        variants(9).variantColor = Drawing.Color.Transparent
        variants(9).variantDescription = "○"

    End Sub


#End Region

    Public Function getLanguage(ByVal id) As Language
        Dim whereStr As String = " WHERE id_language=" & id

        getLanguage = getLanguages(whereStr)(0)

    End Function

    Public Function getCurrency(ByVal id As Integer) As Currency
        Dim i As Integer
        For i = 0 To currencies.Length - 1
            If currencies(i).id_currency = id Then
                getCurrency = currencies(i)
                Exit For
            End If
        Next i
    End Function

    Public Function getUnit(ByVal id) As Unit
        Dim i As Integer
        For i = 0 To units.Length - 1
            If units(i).id_unit = id Then
                getUnit = units(i)
                Exit For
            End If
        Next i
    End Function

    Public Function getGarageById(ByVal id) As Garage

        Dim whereStr As String = " WHERE id_garage=" & id

        getGarageById = getGarages(whereStr)(0)

    End Function

    Public Function getGarageByKey(ByVal key As String) As Garage()

        Dim whereStr As String = " WHERE [key]='" & key.ToLower & "'"

        getGarageByKey = getGarages(whereStr)

    End Function


    Public Function getColorById(ByVal id, Optional ByVal specificConString = Nothing) As Color

        Dim whereStr As String = " WHERE id_color=" & id
        Dim colorTab() As Color = getColors(whereStr, specificConString)
        Dim color As Color = Nothing
        If Not colorTab Is Nothing Then
            If colorTab.Length > 0 Then
                color = colorTab(0)
            End If
        End If

        Return color
    End Function

    Public Function getFormulaById(ByVal id) As Formula

        Dim whereStr As String = " AND id_formula=" & id
        Dim formulaTab() As Formula = getFormulas(whereStr)

        Dim formula As Formula = Nothing

        If Not formulaTab Is Nothing Then
            If formulaTab.Length > 0 Then
                formula = formulaTab(0)
            End If
        End If

        Return formula

    End Function
    Public Function getLanguageById(ByVal id) As Language

        Dim whereStr As String = " WHERE id_language=" & id

        getLanguageById = getLanguages(whereStr)(0)

    End Function


End Module
