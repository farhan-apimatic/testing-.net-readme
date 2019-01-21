using System.Collections.Generic;
using System.Text;
using SwaggerPetstore.Standard.Utilities;
using SwaggerPetstore.Standard.Models;
namespace SwaggerPetstore.Standard
{
    public partial class Configuration
    {


        public enum Environments
        {
            PRODUCTION,
        }
        public enum Servers
        {
            SERVER1,
            SERVER2,
            AUTH_SERVER,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //OAuth 2 Client ID
        //TODO: Replace the OAuthClientId with an appropriate value
        public static string OAuthClientId = "";

        //OAuth 2 Redirection endpoint or Callback Uri
        //TODO: Replace the OAuthRedirectUri with an appropriate value
        public static string OAuthRedirectUri = "";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.SERVER1,"https://petstore.swagger.io/v2" },
                        { Servers.SERVER2,"http://petstore.swagger.io/v2" },
                        { Servers.AUTH_SERVER,"https://petstore.swagger.io/oauth" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:SERVER1</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.SERVER1)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}