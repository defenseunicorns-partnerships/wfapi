using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace wfapi.V1
{
   /// <summary>
   /// Builder for the bucket prefix based on the roleClaim type
   /// </summary>
   /// <param name="claims">User.Claims object from controller</param>
   public class PrefixBuilder(IEnumerable<Claim> claims)
   {
      private const string RoleType = "roles";
      /// <summary>
      /// Buidls the string prefix based on the roleClaim type
      /// </summary>
      /// <param name="claims">User.Claims object from the controller</param>
      /// <returns>String value of the roleClaim type (should be the bucket prefix)</returns>
      public static string New(IEnumerable<Claim> claims)
      {
         Claim claim = claims.Where(x => x.Type == RoleType).FirstOrDefault();
         return claim.Value;
      }
   }
}
