' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

Imports System.Net.Http
''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    '    Dim aRozdz(200) As Integer  ' kolejne rozdzialy, jest ich (psalmy!) duzo

    Private Sub uiGrid_SizeChanged(sender As Object, e As SizeChangedEventArgs)
        ' moze Vertical Stretched wystarczy
    End Sub

    Private Sub uiPrev_Click(sender As Object, e As RoutedEventArgs) Handles uiPrev.Click
        Dim iRozdz = uiRozdz.Text
        If iRozdz > 1 Then uiRozdz.Text = iRozdz - 1
    End Sub

    Private Sub uiRozdz_Changed(sender As Object, e As TextChangedEventArgs) Handles uiRozdz.TextChanged
        ZmianaStrony()
    End Sub

    Private Sub uiLang_Changed(sender As Object, e As SelectionChangedEventArgs) Handles uiLang.SelectionChanged
        ZmianaStrony()
    End Sub

    Private Sub uiNext_Click(sender As Object, e As RoutedEventArgs) Handles uiNext.Click
        Dim iRozdz = uiRozdz.Text
        uiRozdz.Text = iRozdz + 1
    End Sub

    Private Sub uiGrid_Loaded(sender As Object, e As RoutedEventArgs)
        uiKsiega.Items.Clear()

        uiKsiega.Items.Add("Rdz")
        uiKsiega.Items.Add("Wj")
        uiKsiega.Items.Add("Kpł")
        uiKsiega.Items.Add("Lb")
        uiKsiega.Items.Add("Pwt")
        uiKsiega.Items.Add("Joz")
        uiKsiega.Items.Add("Sdz")
        uiKsiega.Items.Add("Rt")
        uiKsiega.Items.Add("1 Sm")
        uiKsiega.Items.Add("2 Sm")
        uiKsiega.Items.Add("1 Krl")
        uiKsiega.Items.Add("2 Krl")
        uiKsiega.Items.Add("1 Krn")
        uiKsiega.Items.Add("2 Krn")
        uiKsiega.Items.Add("Ezd")
        uiKsiega.Items.Add("Ne")
        uiKsiega.Items.Add("Tb")
        uiKsiega.Items.Add("Jdt")
        uiKsiega.Items.Add("Est")
        uiKsiega.Items.Add("1 Mch")
        uiKsiega.Items.Add("2 Mch")
        uiKsiega.Items.Add("Hi")
        uiKsiega.Items.Add("Ps")
        uiKsiega.Items.Add("Prz")
        uiKsiega.Items.Add("Koh")
        uiKsiega.Items.Add("Pnp")
        uiKsiega.Items.Add("Mdr")
        uiKsiega.Items.Add("Syr")
        uiKsiega.Items.Add("Iz")
        uiKsiega.Items.Add("Jr")
        uiKsiega.Items.Add("Lm")
        uiKsiega.Items.Add("Ba")
        uiKsiega.Items.Add("Ez")
        uiKsiega.Items.Add("Dn")
        uiKsiega.Items.Add("Oz")
        uiKsiega.Items.Add("Jl")
        uiKsiega.Items.Add("Am")
        uiKsiega.Items.Add("Ab")
        uiKsiega.Items.Add("Jon")
        uiKsiega.Items.Add("Mi")
        uiKsiega.Items.Add("Na")
        uiKsiega.Items.Add("Ha")
        uiKsiega.Items.Add("So")
        uiKsiega.Items.Add("Ag")
        uiKsiega.Items.Add("Za")
        uiKsiega.Items.Add("Ml")
        uiKsiega.Items.Add("Mt")
        uiKsiega.Items.Add("Mk")
        uiKsiega.Items.Add("Łk")
        uiKsiega.Items.Add("J")
        uiKsiega.Items.Add("Dz")
        uiKsiega.Items.Add("Rz")
        uiKsiega.Items.Add("1 Kor")
        uiKsiega.Items.Add("2 Kor")
        uiKsiega.Items.Add("Ga")
        uiKsiega.Items.Add("Ef")
        uiKsiega.Items.Add("Flp")
        uiKsiega.Items.Add("Kol")
        uiKsiega.Items.Add("1 Tes")
        uiKsiega.Items.Add("2 Tes")
        uiKsiega.Items.Add("1 Tm")
        uiKsiega.Items.Add("2 Tm")
        uiKsiega.Items.Add("Tt")
        uiKsiega.Items.Add("Flm")
        uiKsiega.Items.Add("Hbr")
        uiKsiega.Items.Add("Jk")
        uiKsiega.Items.Add("1 P")
        uiKsiega.Items.Add("2 P")
        uiKsiega.Items.Add("1 J")
        uiKsiega.Items.Add("2 J")
        uiKsiega.Items.Add("3 J")
        uiKsiega.Items.Add("Jud")
        uiKsiega.Items.Add("Ap")


        uiLang.Items.Clear()
        uiLang.Items.Add("Tysiąclecia IV") ' deon.pl
        uiLang.Items.Add("Vulgata")     ' VULGATA
        uiLang.Items.Add("Westminister leningradzki")   ' WLC
        uiLang.Items.Add("King James")      ' KJV
        uiLang.Items.Add("Uwsp. Gdańska")   ' UBG
        uiLang.Items.Add("SBL Greek NT")   ' SBLGNT

    End Sub

    Private Function NamePl2En(sBookName As String) As String
        Select Case sBookName
            Case "Rdz"
                Return "Genesis"
            Case "Wj"
                Return "Exodus"
            Case "Kpł"
                Return "Leviticus"
            Case "Lb"
                Return "Numbers"
            Case "Pwt"
                Return "Deuteronomy"
            Case "Joz"
                Return "Joshua"
            Case "Sdz"
                Return "Judges"
            Case "Rt"
                Return "Ruth"
            Case "1 Sm"
                Return "1 Samuel"
            Case "2 Sm"
                Return "2 Samuel"
            Case "1 Krl"
                Return "1 Kings"
            Case "2 Krl"
                Return "2 Kings"
            Case "1 Krn"
                Return "1 Chronicles"
            Case "2 Krn"
                Return "2 Chronicles"
            Case "Ezd"
                Return "Ezra"
            Case "Ne"
                Return "Nehemiah"
            Case "Tb"
                Return ""
            Case "Jdt"
                Return ""
            Case "Est"
                Return "Esther"
            Case "1 Mch"
                Return ""
            Case "2 Mch"
                Return ""
            Case "Hi"
                Return "Job"
            Case "Ps"
                Return "Psalm"
            Case "Prz"
                Return "Proverbs"
            Case "Koh"
                Return "Ecclesiastes"
            Case "Pnp"
                Return "Song of Songs"
            Case "Mdr"
                Return ""
            Case "Syr"
                Return ""
            Case "Iz"
                Return "Isaiah"
            Case "Jr"
                Return "Jeremiah"
            Case "Lm"
                Return "Lamentations"
            Case "Ba"
                Return ""
            Case "Ez"
                Return "Ezekiel"
            Case "Dn"
                Return "Daniel"
            Case "Oz"
                Return "Hosea"
            Case "Jl"
                Return "Joel"
            Case "Am"
                Return "Amos"
            Case "Ab"
                Return "Obadiah"
            Case "Jon"
                Return "Jonah"
            Case "Mi"
                Return "Micah"
            Case "Na"
                Return "Nahum"
            Case "Ha"
                Return "Habakkuk"
            Case "So"
                Return "Zephaniah"
            Case "Ag"
                Return "Haggai"
            Case "Za"
                Return "Zechariah"
            Case "Ml"
                Return "Malachi"
            Case "Mt"
                Return "Matthew"
            Case "Mk"
                Return "Mark"
            Case "Łk"
                Return "Luke"
            Case "J"
                Return "John"
            Case "Dz"
                Return "Acts"
            Case "Rz"
                Return "Romans"
            Case "1 Kor"
                Return "1 Corinthians"
            Case "2 Kor"
                Return "2 Corinthians"
            Case "Ga"
                Return "Galatians"
            Case "Ef"
                Return "Ephesians"
            Case "Flp"
                Return "Philippians"
            Case "Kol"
                Return "Colossians"
            Case "1 Tes"
                Return "1 Thessalonians"
            Case "2 Tes"
                Return "2 Thessalonians"
            Case "1 Tm"
                Return "1 Timothy"
            Case "2 Tm"
                Return "2 Timothy"
            Case "Tt"
                Return "Titus"
            Case "Flm"
                Return "Philemon"
            Case "Hbr"
                Return "Hebrews"
            Case "Jk"
                Return "James"
            Case "1 P"
                Return "1 Peter"
            Case "2 P"
                Return "2 Peter"
            Case "1 J"
                Return "1 John"
            Case "2 J"
                Return "2 John"
            Case "3 J"
                Return "3 John"
            Case "Jud"
                Return "Jude"
            Case "Ap"
                Return "Revelation"
        End Select

    End Function

    Private Function ZnajdzUrl(sLang As String, sBook As String, iRozdz As Integer) As String
        If sLang = "Tysiąclecia IV" Then
            Return "http://biblia.deon.pl/otworz.php?skrot=" & uiKsiega.SelectedValue & " " & iRozdz
        Else
            Dim sLink = "https://www.biblegateway.com/passage/?search=" & NamePl2En(sBook) &
                "+" & iRozdz.ToString & "&version="
            Select Case sLang
                Case "Vulgata"
                    sLink = sLink & "VULGATA"
                Case "Westminister leningradzki"
                    sLink = sLink & "WLC"
                Case "King James"
                    sLink = sLink & "KJV"
                Case "Uwsp. Gdańska"
                    sLink = sLink & "UBG"
                Case "SBL Greek NT"
                    sLink = sLink & "SBLGNT"
            End Select

            Return sLink
        End If
        Return "ERROR"
    End Function

    Private Sub ZmianaStrony()
        If uiRozdz.Text = "" Then uiRozdz.Text = "1"
        'If aRozdz(uiRozdz.Text) = 0 Then uiRozdz.Text = "1"
        Dim sUri = ZnajdzUrl(uiLang.SelectedValue, uiKsiega.SelectedValue, uiRozdz.Text)
        If sUri.Length < 10 Then Exit Sub
        uiWeb.Navigate(New Uri(sUri))
    End Sub

    Private Async Sub uiKsiega_Changed(sender As Object, e As SelectionChangedEventArgs) Handles uiKsiega.SelectionChanged
        'Dim sUrl = "http://biblia.deon.pl/ksiega.php?id=1"
        '' ContentType:  application/x-www-form-urlencoded; charset=UTF-8
        ''action: ksiega_change
        ''book: 16

        'Dim oHttp = New HttpClient
        'Dim sTmp = Await oHttp.GetStringAsync(New Uri(sUrl))

        'Dim iInd = sTmp.IndexOf("<select name=""rozdzial")
        'If iInd < 10 Then Exit Sub
        'sTmp = sTmp.Substring(iInd)
        'iInd = sTmp.IndexOf("</select")
        'If iInd < 10 Then Exit Sub
        'sTmp = sTmp.Substring(0, iInd)

        'Dim i As Integer
        'For i = 1 To 190
        '    aRozdz(i) = 0
        'Next

        'i = 1
        'iInd = sTmp.IndexOf("value")
        'Do While iInd > 0
        '    sTmp = sTmp.Substring(iInd + 7)
        '    iInd = sTmp.IndexOf("""")
        '    aRozdz(i) = sTmp.Substring(0, iInd)
        '    i += 1
        'Loop

        ''Dim oHttpCont = New StringContent("action=ksiega_change&book=" & uiKsiega.SelectedIndex + 1, Text.Encoding.UTF8, "application/x-www-form-urlencoded")
        ''Dim oResp = Await oHttp.PostAsync(sUrl, oHttpCont)
        '' ["1388","1382","1391","1389","1385","1392","1383","1386","1390","1384","1387"]
        ''oResp.r
        ''If oResp.su Then
    End Sub
End Class
