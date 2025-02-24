using Microsoft.IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Http;

namespace Org.OpenAPITools.Client;

public class ClientCredentials{
   /// <summary>
   /// Handles getting the client credential grant from the OIDC Provider
   /// </summary>
   /// <param name="configuration"></param>

   public ClientCrednetials(Configuration configuration)
   {
      this.Configuration = configuration;
   }

   public async string GetClientCredentialToken()
   {
      var client = new HttpClient();
      var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
        {
            Address = this.Configuration.IdentityPath,
            ClientId = this.Configuration.ClientId,
            ClientSecret = this.Configuration.ClientSecret,
            Scope = "openid"
        });

      if (tokenResponse.IsError)
      {
         throw new ApiException(tokenResponse.StatusCode, tokenResponse.StatusDescription);
      }

      return tokenResponse.AccessToken;
   }

}
