using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using AuthenticationResult = Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult;
using ClientCredential = Microsoft.IdentityModel.Clients.ActiveDirectory.ClientCredential;

namespace SendMailBy_GraphAPI
{

    public class AzureAdAuthentication : IAuthenticationProvider
    {
        private string ClientId = "66ed43df-f566-48da-9d51-43529d83f27a";//ConfigurationManager.AppSettings["aad:ClientId"];
        private string AppKey = "R467Q~C4j8_F1tIe.ThpQtdu_eB1qTbZkowj9";// ConfigurationManager.AppSettings["aad:AppKey"];
        private string Tenant = "9caf8e19-5059-420c-a652-c314718c4ba1"; //ConfigurationManager.AppSettings["aad:Tenant"];
        private string AADInstance = "https://login.microsoftonline.com/{0}"; // ConfigurationManager.AppSettings["ida:AADInstance"];

        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            string authContextURL = "https://login.windows.net/9caf8e19-5059-420c-a652-c314718c4ba1";// + tenantId;
            var authenticationContext = new AuthenticationContext(authContextURL);
            var credential = new ClientCredential(ClientId, AppKey);
            var result = authenticationContext.AcquireTokenAsync("https://graph.microsoft.com/", credential).Result;

            //string Authority = String.Format(CultureInfo.InvariantCulture, AADInstance, Tenant);
            //ClientCredential creds = new ClientCredential(ClientId, AppKey);
            //AuthenticationContext authenticationContext = new AuthenticationContext(Authority, false);
            //AuthenticationResult authResult = await authenticationContext.AcquireTokenAsync("https://graph.microsoft.com/v1.0/", creds);
            request.Headers.Add("Authorization", "Bearer " + result.AccessToken);
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {

            var scopes = new string[] { "https://graph.microsoft.com/.default", "https://graph.microsoft.com/Mail.Send" };
            //var scopes = new[] { "Mail.Send" };
            var authorizationCode = "AUTH_CODE_FROM_REDIRECT";

            var options = new TokenCredentialOptions
            {
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
            };
            var authCodeCredential = new ClientSecretCredential("9caf8e19-5059-420c-a652-c314718c4ba1", " 66ed43df-f566-48da-9d51-43529d83f27a", "R467Q~C4j8_F1tIe.ThpQtdu_eB1qTbZkowj9", options);
            //GraphServiceClient graphClient = new GraphServiceClient(authCodeCredential, scopes);
            GraphServiceClient graphClient = new GraphServiceClient(new AzureAdAuthentication());


            var user = await graphClient.Users["alanichatman01@icloud.com"].Request().GetAsync();



            string body = $"<p><img src='https://chancelight.com/wp-content/themes/newesa/img/chancelight-logo-adapted-r.svg' alt='' width='200' height='64' /></p>  <p>&nbsp;</p><p>$$contactName$$,</p><p>A ChanceLight Information System (CISTEM) account has been created for you at your request.&nbsp; Please click the link below to setup your account and login to view your student&#039;s data.</p>  <p>&nbsp;</p><p><a href='$$invitationUrl$$'>Setup your CISTEM account</a></p><p>&nbsp;</p><p>Thank you,</p><p>CISTEM team</p>";

            var message = new Message
            {
                Subject = "Meet for lunch?",
                Body = new ItemBody
                {
                    ContentType = BodyType.Text,
                    Content = "The new cafeteria is open."
                },
                ToRecipients = new List<Recipient>()
                    {
                        new Recipient
                        {
                            EmailAddress = new EmailAddress
                            {
                                Address = "amitkkumar902@gmail.com"
                            }
                        }
                    },
                CcRecipients = new List<Recipient>()
                    {
                        new Recipient
                        {
                            EmailAddress = new EmailAddress
                            {
                                Address = "amit.kumar1@successive.tech"
                            }
                        }
                    }
            };

            var saveToSentItems = true;

            var sdsd =  await graphClient.Users["a57663cc-4188-432c-9eda-e2acb3f733a5"]
                .SendMail(message, saveToSentItems)
                .Request()
                .PostResponseAsync();
        }
    }
}
