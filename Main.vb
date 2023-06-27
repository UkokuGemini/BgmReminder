Imports System.IO
Imports System.Net
Imports System.Net.WebRequestMethods
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Main
    Dim BgmId As String
    Dim PushUrl As String
    Friend WithEvents FreshTimer As New System.Windows.Forms.Timer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.AssemblyName & "[" & My.Application.Info.Version.ToString & "]"
        Me.CenterToScreen()
        If IO.Directory.Exists(System.Environment.CurrentDirectory & "\ImageTempPath\") = False Then
            IO.Directory.CreateDirectory(System.Environment.CurrentDirectory & "\ImageTempPath\")
        End If '//创建图片暂存文件夹
        ReadSettingXml()
        If BgmId.Length > 0 Then
            GroupBox1.Text = BgmId
            SubjectRead(GetData("https://api.bgm.tv/v0/users/" & BgmId & "/collections?subject_type=2&type=3&limit=30&offset=0"))
        Else
            GroupBox1.Text = "null"
        End If
        FreshTimer.Interval = 1000
        FreshTimer.Enabled = True
    End Sub
    Private Sub FreshTimerE(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreshTimer.Tick
        If Now.Second = 0 AndAlso Now.Minute = 0 Then
            For i = 0 To SubjectArrList.Count - 1
                Dim CompareSubject As Subject = SubjectArrList(i)
                If EpRead(SubjectArrList(i)).epDates <> CompareSubject.epDates Then
                    ToolStripStatusLabel1.Text = PostData(PushUrl, CompareSubject.Name)
                End If
            Next
        End If
    End Sub '刷新计时器
    Public Function PostData(ByVal Url As String, ByVal MessageStr As String) As String
        Dim ResStr As String = ""
        If Url.Length > 0 Then
            ServicePointManager.Expect100Continue = False
            Dim request As HttpWebRequest
            Dim Encoding As New UTF8Encoding()
            request = WebRequest.Create(Url)
            request.ContentType = "application/json"
            MessageStr &= "\r\r" & "[" & Format(Now, "yyyy-MM-dd HH:mm") & "] Push From @Bark"
            MessageStr = Replace(MessageStr, "<", "《")
            MessageStr = Replace(MessageStr, ">", "》")
            MessageStr = Replace(MessageStr, "/", "\\")
            MessageStr = Replace(MessageStr, vbCrLf, "\r")
            MessageStr = Replace(MessageStr, vbLf, "\r")
            MessageStr = Replace(MessageStr, Chr(13), "\r")
            MessageStr = Replace(MessageStr, Chr(34), "'")
            MessageStr = "{" & Chr(34) & "title" & Chr(34) & ":" & Chr(34) & Application.ProductName & "" & Chr(34) & "," & Chr(34) & "body" & Chr(34) & ":" & Chr(34) & "\r" & MessageStr & Chr(34) & "}"
            request.Method = "POST"
            Dim Bytes_Temp As Byte() = Encoding.GetBytes(MessageStr)
            '设置请求的 ContentLength 
            request.ContentLength = Bytes_Temp.Length
            '获得请 求流
            Try
                Dim newStream As Stream = request.GetRequestStream()
                newStream.Write(Bytes_Temp, 0, Bytes_Temp.Length)
                newStream.Close()
                '获得响应流
                Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
                ResStr = sr.ReadToEnd()
            Catch ex As Exception
                ResStr = "发送失败！{" & ex.Message.ToString & "}"
            End Try
        Else
            resstr = "空白推送地址"
        End If
        Return ResStr
    End Function
    Sub ReadSettingXml()
        Dim SettingPath As String = Directory.GetCurrentDirectory & "\BgmReminderSetting.Xml"
        Try
            Dim SettingXml As String = ""
            If IO.File.Exists(SettingPath) Then
                SettingXml = IO.File.ReadAllText(SettingPath)
            End If
            If SettingXml.Length > 0 Then
                Dim xmlDoc As New XmlDocument()
                xmlDoc.Load(SettingPath)
                'Dim NodeList_Version As XmlNodeList = xmlDoc.SelectSingleNode("KavSetting").SelectSingleNode("UpdateLog").ChildNodes '获取节点的所有子节点
                BgmId = CType(xmlDoc.SelectSingleNode("BgmReminderSetting").SelectSingleNode("BgmId"), XmlElement).InnerText
                PushUrl = CType(xmlDoc.SelectSingleNode("BgmReminderSetting").SelectSingleNode("PushUrl"), XmlElement).InnerText
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Function GetData(ByVal url As String) As String
        ServicePointManager.Expect100Continue = False
        Dim request As HttpWebRequest = WebRequest.Create(url)
        request.UserAgent = "UkokuGemini/BgmReminder"
        request.Method = "GET"
        Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
        Return sr.ReadToEnd
    End Function
    Structure Subject
        Dim Name As String
        Dim SubId As Integer
        Dim Picurl As String
        Dim epName As String
        Dim epDates As Date
        Dim epName_Next As String
        Dim epDates_Next As Date
        Dim epnum As Integer
    End Structure
    Dim SubjectArrList As New ArrayList
    Dim json As JObject
    Dim jt As JToken
    Sub SubjectRead(ByVal JsonStr As String)
        ListBox1.Items.Clear()
        SubjectArrList.Clear()
        Dim res As String = ""
        Try
            json = JsonConvert.DeserializeObject(JsonStr)
            jt = json("data")
            Dim jarray As JArray = JsonConvert.DeserializeObject(jt.ToString)
            For i = 0 To jarray.Count - 1
                Dim SubjectInfo As Subject
                json = JsonConvert.DeserializeObject(jarray(i).ToString)
                SubjectInfo.SubId = json("subject_id").ToString
                jt = json("subject").ToString
                json = JsonConvert.DeserializeObject(jt.ToString)
                SubjectInfo.Name = json("name_cn").ToString
                ListBox1.Items.Add(SubjectInfo.Name)
                jt = json("images").ToString
                json = JsonConvert.DeserializeObject(jt.ToString)
                SubjectInfo.Picurl = json("small").ToString
                SubjectInfo = EpRead(SubjectInfo)
                SubjectArrList.Add(SubjectInfo)
            Next
            ToolStripStatusLabel1.Text = "【" & SubjectArrList.Count & "】个动漫监控中…"
        Catch ex As Exception
        End Try
    End Sub
    Function EpRead(ByVal SubjectInfo_ep As Subject) As Subject
        json = JsonConvert.DeserializeObject(GetData("https://api.bgm.tv/v0/episodes?subject_id=" & SubjectInfo_ep.SubId & "&type=0&limit=100&offset=0"))
        jt = json("data")
        Dim jarray As JArray = JsonConvert.DeserializeObject(jt.ToString)
        Dim epName_temp As String
        Dim epDates_temp As String
        Dim epNum_temp As Integer
        Dim NextFlag As Boolean = False
        For i = 0 To jarray.Count - 1
            json = JsonConvert.DeserializeObject(jarray(i).ToString)
            epDates_temp = json("airdate").ToString
            epName_temp = json("name").ToString
            epNum_temp = json("ep")
            If epName_temp.Length > 0 AndAlso epDates_temp < Now Then
                SubjectInfo_ep.epName = epName_temp
                SubjectInfo_ep.epDates = epDates_temp
                SubjectInfo_ep.epnum = epNum_temp
            ElseIf NextFlag = False AndAlso epDates_temp > Now Then
                NextFlag = True
                SubjectInfo_ep.epName_Next = epName_temp
                SubjectInfo_ep.epDates_Next = epDates_temp
            End If
        Next
        Return SubjectInfo_ep
    End Function
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        RichTextBox1.Text = ""
        If ListBox1.SelectedIndex >= 0 AndAlso ListBox1.SelectedIndex < ListBox1.Items.Count Then
            'PictureBox1.Image =
            Dim ShowSubject As Subject = SubjectArrList(ListBox1.SelectedIndex)
            RichTextBox1.Text &= ShowSubject.Name & "(Id" & ShowSubject.SubId & ")" & vbCrLf
            RichTextBox1.Text &= "近期播放：[ep." & ShowSubject.epnum & "]" & vbCrLf
            RichTextBox1.Text &= "@" & ShowSubject.epDates & "【" & ShowSubject.epName & "】" & vbCrLf
            RichTextBox1.Text &= "下次播放" & vbCrLf & "@" & ShowSubject.epDates_Next & "【" & ShowSubject.epName_Next & "】"
            Try
                Dim ImageTempPath As String = System.Environment.CurrentDirectory & "\ImageTempPath\" & ShowSubject.SubId & ".jpg"
                If IO.File.Exists(ImageTempPath) Then
                    Me.PictureBox1.Image = New Bitmap(ImageTempPath)
                Else
                    Dim wr As WebRequest = WebRequest.Create(ShowSubject.Picurl)
                Dim res As WebResponse = wr.GetResponse
                Me.PictureBox1.Image = New Bitmap(res.GetResponseStream)
                Me.PictureBox1.Image.Save(ImageTempPath)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            NotifyIcon1.Visible = True
        Else
            Me.ShowInTaskbar = True
            NotifyIcon1.Visible = False
        End If
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class
