// See https://aka.ms/new-console-template for more information


using FTPClient;
using System.Net;

Console.WriteLine("Hello, World!");

try
{





    FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftgauk.ihs.com/");
    request.Method = WebRequestMethods.Ftp.ListDirectory;
    request.Credentials = new NetworkCredential("srv_maruk_stratum", "rPetG4jMvdm6455B^5M");
    request.KeepAlive = false;
    request.UseBinary = true;
    request.UsePassive = true;
    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
    Stream responseStream = response.GetResponseStream();
    StreamReader reader = new StreamReader(responseStream);
    string names = reader.ReadToEnd();
    reader.Close();
    response.Close();
    var filelist = names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).OrderByDescending(x => x).ToList();

    var fileByteArrayWithName = GetByteArray(filelist);

    Console.WriteLine(reader.ReadToEnd());
    Console.WriteLine("Directory List Complete, status {0}", response.StatusDescription);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}

List<FtpDetails> GetByteArray(List<string> filelist)
{
    WebClient request = new WebClient();
    string ftpBaseUrl = "ftp://ftgauk.ihs.com/";
    var obj = new List<FtpDetails>();
    request.Credentials = new NetworkCredential("srv_maruk_stratum", "rPetG4jMvdm6455B^5M");
    foreach (var fileData in filelist)
    {
        string filePath = Path.Combine(ftpBaseUrl, fileData);
        byte[] newFileData = request.DownloadData(filePath);
        obj.Add(new FtpDetails() { FileName = fileData, FilesBinaryData = newFileData });
    }
    return obj;
}