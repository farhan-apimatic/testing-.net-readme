/*
 * SwaggerPetstore.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerPetstore.Standard;
using SwaggerPetstore.Standard.Utilities;


namespace SwaggerPetstore.Standard.Models
{
    public class Order : BaseModel 
    {
        // These fields hold the values for the public properties.
        private long? id;
        private long? petId;
        private int? quantity;
        private DateTime? shipDate;
        private Models.StatusEnum? status;
        private bool? complete = false;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public long? Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("petId")]
        public long? PetId 
        { 
            get 
            {
                return this.petId; 
            } 
            set 
            {
                this.petId = value;
                onPropertyChanged("PetId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("shipDate")]
        public DateTime? ShipDate 
        { 
            get 
            {
                return this.shipDate; 
            } 
            set 
            {
                this.shipDate = value;
                onPropertyChanged("ShipDate");
            }
        }

        /// <summary>
        /// Order Status
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.StatusEnum? Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("complete")]
        public bool? Complete 
        { 
            get 
            {
                return this.complete; 
            } 
            set 
            {
                this.complete = value;
                onPropertyChanged("Complete");
            }
        }
    }
} 