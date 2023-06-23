using Microsoft.Graph;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace AddUserAzureAD
{

    public class AzureAdAuthentication : IAuthenticationProvider
    {
        private string ClientId = "2f9afe1e-be0f-43e5-aaa9-45bf5e054502";//ConfigurationManager.AppSettings["aad:ClientId"];
        private string AppKey = "n7w~l57zP_2qs7S2Qfi-Ei67hz7ydPd-GA";// ConfigurationManager.AppSettings["aad:AppKey"];
        private string Tenant = "9caf8e19-5059-420c-a652-c314718c4ba1"; //ConfigurationManager.AppSettings["aad:Tenant"];
        private string AADInstance = "https://login.microsoftonline.com/{0}"; // ConfigurationManager.AppSettings["ida:AADInstance"];

        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            string Authority = String.Format(CultureInfo.InvariantCulture, AADInstance, Tenant);
            ClientCredential creds = new ClientCredential(ClientId, AppKey);
            AuthenticationContext authenticationContext = new AuthenticationContext(Authority, false);
            AuthenticationResult authResult = await authenticationContext.AcquireTokenAsync("https://graph.microsoft.com/", creds);
            request.Headers.Add("Authorization", "Bearer " + authResult.AccessToken);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GraphServiceClient graphClient = new GraphServiceClient(new AzureAdAuthentication());

            //var user = new User
            //{
            //    AccountEnabled = true,
            //    DisplayName = "Amit",
            //    MailNickname = "Kumar",
            //    UserPrincipalName = "amit.kumar1@chancelightedu.com",
            //    PasswordProfile = new PasswordProfile
            //    {
            //        ForceChangePasswordNextSignIn = true,
            //        Password = "Abc@12345"
            //    },

            //};

            #region Create Invitation
            //var invitation = new Invitation
            //{
            //    InvitedUserEmailAddress = "amitkkumar902@gmail.com",
            //    InviteRedirectUrl = "https://parentportal.cistem.app",

            //};

            //var invitaion = graphClient.Invitations
            //    .Request()
            //    .AddAsync(invitation).Result;
            #endregion

            #region Update JobTitle

            //invitaion.InvitedUser.JobTitle = "cistemContact_Test";

            //var updateUse = graphClient.Users[invitaion.InvitedUser.Id].Request().UpdateAsync(invitaion.InvitedUser).Result;

            #endregion



            #region Send Mail

            string body = $"<p><img src='https://chancelight.com/wp-content/themes/newesa/img/chancelight-logo-adapted-r.svg' alt='' width='200' height='64' /></p>  <p>&nbsp;</p><p>$$contactName$$,</p><p>A ChanceLight Information System (CISTEM) account has been created for you at your request.&nbsp; Please click the link below to setup your account and login to view your student&#039;s data.</p>  <p>&nbsp;</p><p><a href='$$invitationUrl$$'>Setup your CISTEM account</a></p><p>&nbsp;</p><p>Thank you,</p><p>CISTEM team</p>";
            //var message = new Message
            //{
            //    Subject = "CISTEM Welcome Email",
            //    Body = new ItemBody
            //    {
            //        ContentType = BodyType.Html,
            //        Content = body
            //    },
            //    ToRecipients = new List<Recipient>()
            //    {
            //        new Recipient
            //        {
            //            EmailAddress = new EmailAddress
            //            {
            //                Address = invitaion.InvitedUserEmailAddress
            //            }
            //        }
            //    }

            //};


            //graphClient.Users["a57663cc-4188-432c-9eda-e2acb3f733a5"]
            //          .SendMail(message, false)
            //          .Request()
            //          .PostAsync().Wait();
            #endregion


            #region Account disable 


            var findUser = graphClient.Users["16fd9614-c177-446b-93bb-db722e098a8a"].Request().GetAsync().Result;
            findUser.AccountEnabled = true;
            var accountDisable = graphClient.Users["16fd9614-c177-446b-93bb-db722e098a8a"].Request().UpdateAsync(findUser).Result;


            #endregion



            //var sdsds = graphClient.Invitations[invitaion.InvitedUser.Id].Request().DeleteResponseAsync().Result;//.get

            //var user_re = graphClient.Users.Request().GetAsync().Result;

            ////var ss = graphClient.Users
            ////   .Request()
            ////   .AddAsync(user).Result;

            //var sdsd = graphClient.Users["2653d0b4-7233-4474-b130-c2dda5d6d681"].Request().DeleteResponseAsync().Result;
            //Console.WriteLine("Hello World!");
        }
    }
}
