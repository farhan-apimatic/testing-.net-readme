/*
 * SwaggerPetstore.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerPetstore.Standard;
using SwaggerPetstore.Standard.Utilities;

namespace SwaggerPetstore.Standard.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum OAuthScopeEnum
    {
        WRITEPETS, //modify pets in your account
        READPETS, //read your pets
    }

    /// <summary>
    /// Helper for the enum type OAuthScopeEnum
    /// </summary>
    public static class OAuthScopeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "write:pets", "read:pets" };

        /// <summary>
        /// Converts a OAuthScopeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The OAuthScopeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(OAuthScopeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case OAuthScopeEnum.WRITEPETS:
                case OAuthScopeEnum.READPETS:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of OAuthScopeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of OAuthScopeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<OAuthScopeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into OAuthScopeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed OAuthScopeEnum value</returns>
        public static OAuthScopeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type OAuthScopeEnum", value));

            return (OAuthScopeEnum) index;
        }
    }
} 