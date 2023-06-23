using Microsoft.Graph;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using AuthenticationResult = Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult;
using ClientCredential = Microsoft.IdentityModel.Clients.ActiveDirectory.ClientCredential;

namespace FindUserFromAD
{
    public class AzureAdAuthentication : IAuthenticationProvider
    {
        private string ClientId = "2f9afe1e-be0f-43e5-aaa9-45bf5e054502";//ConfigurationManager.AppSettings["aad:ClientId"];
        private string AppKey = "n7w~l57zP_2qs7S2Qfi-Ei67hz7ydPd-GA";// ConfigurationManager.AppSettings["aad:AppKey"];
        private string Tenant = "esaeducation.onmicrosoft.com"; //ConfigurationManager.AppSettings["aad:Tenant"];
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
        static async Task Main(string[] args)
        {
            string filterString = $"Identities/any(id:id/Mail eq 'alanichatman01@icloud.com')"; ;

            GraphServiceClient graphClient = new GraphServiceClient(new AzureAdAuthentication());

            //var contactStudentBridg = _d

            var response = await graphClient.Users.Request().Filter("mail eq 'alanichatman01@icloud.com'").GetAsync();

        }
    }
}
