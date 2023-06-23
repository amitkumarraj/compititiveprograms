using CoreFtp;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_FTpClient
{
    internal class Program
    {
        static async Task Main()
        {
            try
            {
                Console.WriteLine("Hello World!");

                using (var ftpClient = new FtpClient(new FtpClientConfiguration
                {
                    Host = "ftp://ftgauk.ihs.com/",
                    Username = "srv_maruk_stratum",
                    Password = "rPetG4jMvdm6455B^5M",
                    //EncryptionType = FtpEncryption.Implicit,
                    //IgnoreCertificateErrors = true
                }))
                {
                    await ftpClient.LoginAsync();
                    var ftpFiles = await ftpClient.ListAllAsync();
                    MemoryStream memoryStream = new MemoryStream();
                    using (var ftpReadStream = await ftpClient.OpenFileReadStreamAsync(ftpFiles.First(x => x.Name.EndsWith(".zip")).Name))
                    {
                        await ftpReadStream.CopyToAsync(memoryStream);
                    }

                    var sdsd = memoryStream.ToArray();
                    //var tempFile = new FileInfo("C:\\test.png");
                    //using (var ftpReadStream = await ftpClient.ListFilesAsync())
                    //{
                    //    using (var fileWriteStream = tempFile.OpenWrite())
                    //    {
                    //        await ftpReadStream.CopyToAsync(fileWriteStream);
                    //    }
                    //}
                }

            }
            catch (Exception ex)
            {

                throw;
            }





        }
    }
}
