// See https://aka.ms/new-console-template for more information
using Limilabs.FTP.Client;
using System.Security.Authentication;

Console.WriteLine("Hello, World!");







using (Ftp ftp = new Ftp())
{
    ftp.Connect("ftgauk.ihs.com");  // or ConnectSSL for SSL
    ftp.SSLConfiguration.EnabledSslProtocols = SslProtocols.Tls12;


    ftp.Login("srv_maruk_stratum", "rPetG4jMvdm6455B^5M");

    var sdd = ftp.GetList();
    var sdsd = ftp.Download($"{sdd.FirstOrDefault().Name}");
    ftp.Close();
}

