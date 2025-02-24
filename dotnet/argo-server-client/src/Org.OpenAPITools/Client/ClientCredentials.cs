using Duende.IdentityModel.Client;
using System.Net.Http;
using System.Threading.Tasks;

namespace Org.OpenAPITools.Client;

/// <summary>
/// A class to handle ClientCredential grants
/// </summary>
public class ClientCredentials{

   private string IdentityPath { get; set; }
   private string ClientId { get; set; }
   private string ClientSecret{ get; set; }

/// <summary>
/// Default constructor, needs identity provider url, client id and client secret
/// </summary>
/// <param name="IdentityPath"></param>
/// <param name="clientId"></param>
/// <param name="clientSecret"></param>
   public ClientCredentials(string IdentityPath, string clientId, string clientSecret)
   {

      this.IdentityPath = IdentityPath;
      this.ClientId = clientId;
      this.ClientSecret = clientSecret;
   }

/// <summary>
/// Gets a JWT from the IdP's Client Credentials Grant
/// </summary>
/// <returns>raw JWT String</returns>
/// <exception cref="ApiException"></exception>
   public async Task<string> GetClientCredentialToken()
   {
      var client = new HttpClient();
      var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
        {
            Address = this.IdentityPath,
            ClientId = this.ClientId,
            ClientSecret = this.ClientSecret,
            Scope = "openid"
        });

      if (tokenResponse.IsError)
      {
         throw new ApiException(500, tokenResponse.Error);
      }

      return tokenResponse.AccessToken;
   }

}
