using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;

namespace ParseEml
{
    internal class ClientInfo
    {
        public List<ClientMetaData> Clients { get; set; }
    }

    public class ClientMetaData
    {
        public string ClientName { get; set; }
        public string Sender { get; set; }
        public string[] ProcessFileName { get; set; }
        public string Subfolder { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var clients = new ClientInfo();
            //clients.Clients = new List<ClientMetaData>();
            //clients.Clients.Add(new ClientMetaData()
            //{
            //    ClientName = "TMS",
            //    Sender = "Tms@shipment.io",
            //    ProcessFileName = new string[] { "telegram.json", "telegram1.jon" },
            //    Subfolder = "tms"
            //});
            //clients.Clients.Add(new ClientMetaData()
            //{
            //    ClientName = "Griodorid",
            //    Sender = "Griodorid@shipment.io",
            //    ProcessFileName = new string[] { "telegram.json", "telegram1.jon" },
            //    Subfolder = "Griodorid"
            //});

            //string json = JsonConvert.SerializeObject(clients);


            var message = MimeMessage.Load("C:\\Users\\amitk\\Downloads\\f5j2ra4vmm9giol0b4ujk9n5ld5fevnql0uat401");
            var body = message.TextBody;
            string path = "C:\\Users\\amitk\\Downloads";

            if (message.Attachments != null)
            {
                foreach (MimeEntity att in message.Attachments)
                {
                    if (att.IsAttachment)
                    {

                        var content = ((MimeKit.MimeContent)((MimeKit.MimePart)att).Content).Stream;
                        StreamReader reader = new StreamReader(content);
                        string attchmentData = reader.ReadToEndAsync().Result;
                        reader.Close();

                        if (IsBase64String(attchmentData))
                        {
                            //return Base64Decode(attchmentData);
                        }
                        else
                        {

                        }

                    }

                }

                //var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;

                //using (var stream = File.Create(fileName))
                //{
                //    var content = ((MimeKit.MimeContent)((MimeKit.MimePart)attachment).Content).Stream;


                //    if (attachment is MessagePart)
                //    {
                //        var rfc822 = (MessagePart)attachment;

                //        rfc822.Message.WriteTo(stream);
                //    }
                //    else if (attachment is MimeContent)
                //    {
                //        System.Console.WriteLine();
                //    }
                //    else
                //    {
                //        var part = (MimePart)attachment;

                //        part.Content.DecodeTo(stream);


                //    }
                //    StreamReader reader = new StreamReader(content);
                //    string attachmentcontent = reader.ReadToEnd();
                //}
            }
        }

        private static bool IsBase64String(string base64)
        {
            Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out int bytesParsed);

        }
    }
}

