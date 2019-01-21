/*
 * SwaggerPetstore.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using SwaggerPetstore.Standard.Controllers;
using SwaggerPetstore.Standard.Http.Client;
using SwaggerPetstore.Standard.Utilities;

namespace SwaggerPetstore.Standard
{
    public partial class SwaggerPetstoreClient
    {

        /// <summary>
        /// Singleton access to Pet controller
        /// </summary>
        public PetController Pet
        {
            get
            {
                return PetController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Store controller
        /// </summary>
        public StoreController Store
        {
            get
            {
                return StoreController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to User controller
        /// </summary>
        public UserController User
        {
            get
            {
                return UserController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Authorization instance

        public AuthManager Auth
        {
            get { return AuthManager.Instance; }
        }

        #endregion
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public SwaggerPetstoreClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public SwaggerPetstoreClient(string oAuthClientId, string oAuthRedirectUri)
        {
            Configuration.OAuthClientId = oAuthClientId;
            Configuration.OAuthRedirectUri = oAuthRedirectUri;
        }
        #endregion
    }
}