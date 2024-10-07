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
      /// creates either the files client prefix or the client prefix for workflows
      /// </summary>
      /// <param name="claims">User.Claims object from http context</param>
      /// <param name="FilesPrefix">Optional string of FilesPrefix if building an S3 prefix</param>
      /// <returns>client_id if FilesPrefix=null, else client_id/FilesPrefix </returns>
      private static string _new(IEnumerable<Claim> claims, string? FilesPrefix)
      {
         string ClaimValue = "";

         if (claims.Count() > 0) {
            Claim claim = claims.Where(x => x.Type == RoleType).FirstOrDefault();
            if (claim is not null) ClaimValue = claim.Value;
         }
         if (FilesPrefix is null) return ClaimValue;
         else return $"{ClaimValue}/{FilesPrefix}";
      }

      /// <summary>
      /// Buidls the string prefix based on the roleClaim type
      /// </summary>
      /// <param name="claims">User.Claims object from the controller</param>
      /// <param name="FilesPrefix">files prefix to save files into</param>
      /// <returns>String value of the roleClaim type (should be the bucket prefix)</returns>
      public static string New(IEnumerable<Claim> claims, string FilesPrefix)
      {
         return _new(claims, FilesPrefix);
      }

      /// <summary>
      /// Buidls the string prefix based on the roleClaim type
      /// </summary>
      /// <param name="claims">User.Claims object from the controller</param>
      /// <returns>String value of the roleClaim type (should be the client_id)</returns>
      public static string New(IEnumerable<Claim> claims)
      {
         return _new(claims, null);
      }
   }
}
