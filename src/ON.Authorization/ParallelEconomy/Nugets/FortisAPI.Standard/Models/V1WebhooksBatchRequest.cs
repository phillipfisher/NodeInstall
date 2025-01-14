// <copyright file="V1WebhooksBatchRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace FortisAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using FortisAPI.Standard;
    using FortisAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// V1WebhooksBatchRequest.
    /// </summary>
    public class V1WebhooksBatchRequest : BaseModel
    {
        private int? attemptInterval;
        private string basicAuthUsername;
        private string basicAuthPassword;
        private string expands;
        private Models.FormatEnum? format;
        private string locationApiId;
        private string postbackConfigId;
        private Models.Resource12Enum? resource;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "attempt_interval", true },
            { "basic_auth_username", false },
            { "basic_auth_password", false },
            { "expands", false },
            { "format", false },
            { "location_api_id", false },
            { "postback_config_id", false },
            { "resource", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="V1WebhooksBatchRequest"/> class.
        /// </summary>
        public V1WebhooksBatchRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1WebhooksBatchRequest"/> class.
        /// </summary>
        /// <param name="isActive">is_active.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="onCreate">on_create.</param>
        /// <param name="onUpdate">on_update.</param>
        /// <param name="onDelete">on_delete.</param>
        /// <param name="productTransactionId">product_transaction_id.</param>
        /// <param name="numberOfAttempts">number_of_attempts.</param>
        /// <param name="url">url.</param>
        /// <param name="attemptInterval">attempt_interval.</param>
        /// <param name="basicAuthUsername">basic_auth_username.</param>
        /// <param name="basicAuthPassword">basic_auth_password.</param>
        /// <param name="expands">expands.</param>
        /// <param name="format">format.</param>
        /// <param name="locationApiId">location_api_id.</param>
        /// <param name="postbackConfigId">postback_config_id.</param>
        /// <param name="resource">resource.</param>
        public V1WebhooksBatchRequest(
            bool isActive,
            string locationId,
            bool onCreate,
            bool onUpdate,
            bool onDelete,
            string productTransactionId,
            int numberOfAttempts,
            string url,
            int? attemptInterval = 300,
            string basicAuthUsername = null,
            string basicAuthPassword = null,
            string expands = null,
            Models.FormatEnum? format = null,
            string locationApiId = null,
            string postbackConfigId = null,
            Models.Resource12Enum? resource = null)
        {
            this.AttemptInterval = attemptInterval;
            if (basicAuthUsername != null)
            {
                this.BasicAuthUsername = basicAuthUsername;
            }

            if (basicAuthPassword != null)
            {
                this.BasicAuthPassword = basicAuthPassword;
            }

            if (expands != null)
            {
                this.Expands = expands;
            }

            if (format != null)
            {
                this.Format = format;
            }

            this.IsActive = isActive;
            this.LocationId = locationId;
            if (locationApiId != null)
            {
                this.LocationApiId = locationApiId;
            }

            this.OnCreate = onCreate;
            this.OnUpdate = onUpdate;
            this.OnDelete = onDelete;
            if (postbackConfigId != null)
            {
                this.PostbackConfigId = postbackConfigId;
            }

            this.ProductTransactionId = productTransactionId;
            if (resource != null)
            {
                this.Resource = resource;
            }

            this.NumberOfAttempts = numberOfAttempts;
            this.Url = url;
        }

        /// <summary>
        /// Number of seconds before another retry is submitted
        /// </summary>
        [JsonProperty("attempt_interval")]
        public int? AttemptInterval
        {
            get
            {
                return this.attemptInterval;
            }

            set
            {
                this.shouldSerialize["attempt_interval"] = true;
                this.attemptInterval = value;
            }
        }

        /// <summary>
        /// The Basic authorization username for the URL, if not supplied, the postback will be submitted without Basic authorization headers
        /// </summary>
        [JsonProperty("basic_auth_username")]
        public string BasicAuthUsername
        {
            get
            {
                return this.basicAuthUsername;
            }

            set
            {
                this.shouldSerialize["basic_auth_username"] = true;
                this.basicAuthUsername = value;
            }
        }

        /// <summary>
        /// The basic authorization password
        /// </summary>
        [JsonProperty("basic_auth_password")]
        public string BasicAuthPassword
        {
            get
            {
                return this.basicAuthPassword;
            }

            set
            {
                this.shouldSerialize["basic_auth_password"] = true;
                this.basicAuthPassword = value;
            }
        }

        /// <summary>
        /// An option list of expanded data to send with base data. (i.e. set this field to “contact,account_vault” to get the contact an accountvault used to run a transaction.)
        /// </summary>
        [JsonProperty("expands")]
        public string Expands
        {
            get
            {
                return this.expands;
            }

            set
            {
                this.shouldSerialize["expands"] = true;
                this.expands = value;
            }
        }

        /// <summary>
        /// Options include: api-default
        /// </summary>
        [JsonProperty("format")]
        public Models.FormatEnum? Format
        {
            get
            {
                return this.format;
            }

            set
            {
                this.shouldSerialize["format"] = true;
                this.format = value;
            }
        }

        /// <summary>
        /// Flag to indicate whether configuration is active (in effect).
        /// </summary>
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        /// <summary>
        /// The location identifier of the resource you want to recieve postbacks from.
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        /// <summary>
        /// Location Api ID
        /// </summary>
        [JsonProperty("location_api_id")]
        public string LocationApiId
        {
            get
            {
                return this.locationApiId;
            }

            set
            {
                this.shouldSerialize["location_api_id"] = true;
                this.locationApiId = value;
            }
        }

        /// <summary>
        /// To receive postbacks on the creation of a resource
        /// </summary>
        [JsonProperty("on_create")]
        public bool OnCreate { get; set; }

        /// <summary>
        /// To receive postbacks on the updating of a resource
        /// </summary>
        [JsonProperty("on_update")]
        public bool OnUpdate { get; set; }

        /// <summary>
        /// To receive postbacks when the record is deleted
        /// </summary>
        [JsonProperty("on_delete")]
        public bool OnDelete { get; set; }

        /// <summary>
        /// Postback Config ID
        /// </summary>
        [JsonProperty("postback_config_id")]
        public string PostbackConfigId
        {
            get
            {
                return this.postbackConfigId;
            }

            set
            {
                this.shouldSerialize["postback_config_id"] = true;
                this.postbackConfigId = value;
            }
        }

        /// <summary>
        /// Required when using 'transaction' or 'transactionbatch' resource
        /// </summary>
        [JsonProperty("product_transaction_id")]
        public string ProductTransactionId { get; set; }

        /// <summary>
        /// The resource you want to subscribe the postbacks to.
        /// </summary>
        [JsonProperty("resource")]
        public Models.Resource12Enum? Resource
        {
            get
            {
                return this.resource;
            }

            set
            {
                this.shouldSerialize["resource"] = true;
                this.resource = value;
            }
        }

        /// <summary>
        /// Maximum number of attempts on failure
        /// </summary>
        [JsonProperty("number_of_attempts")]
        public int NumberOfAttempts { get; set; }

        /// <summary>
        /// The URL where the postback will be submitted
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1WebhooksBatchRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAttemptInterval()
        {
            this.shouldSerialize["attempt_interval"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBasicAuthUsername()
        {
            this.shouldSerialize["basic_auth_username"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBasicAuthPassword()
        {
            this.shouldSerialize["basic_auth_password"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpands()
        {
            this.shouldSerialize["expands"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFormat()
        {
            this.shouldSerialize["format"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationApiId()
        {
            this.shouldSerialize["location_api_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPostbackConfigId()
        {
            this.shouldSerialize["postback_config_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetResource()
        {
            this.shouldSerialize["resource"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAttemptInterval()
        {
            return this.shouldSerialize["attempt_interval"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBasicAuthUsername()
        {
            return this.shouldSerialize["basic_auth_username"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBasicAuthPassword()
        {
            return this.shouldSerialize["basic_auth_password"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpands()
        {
            return this.shouldSerialize["expands"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFormat()
        {
            return this.shouldSerialize["format"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationApiId()
        {
            return this.shouldSerialize["location_api_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePostbackConfigId()
        {
            return this.shouldSerialize["postback_config_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeResource()
        {
            return this.shouldSerialize["resource"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is V1WebhooksBatchRequest other &&                ((this.AttemptInterval == null && other.AttemptInterval == null) || (this.AttemptInterval?.Equals(other.AttemptInterval) == true)) &&
                ((this.BasicAuthUsername == null && other.BasicAuthUsername == null) || (this.BasicAuthUsername?.Equals(other.BasicAuthUsername) == true)) &&
                ((this.BasicAuthPassword == null && other.BasicAuthPassword == null) || (this.BasicAuthPassword?.Equals(other.BasicAuthPassword) == true)) &&
                ((this.Expands == null && other.Expands == null) || (this.Expands?.Equals(other.Expands) == true)) &&
                ((this.Format == null && other.Format == null) || (this.Format?.Equals(other.Format) == true)) &&
                this.IsActive.Equals(other.IsActive) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.LocationApiId == null && other.LocationApiId == null) || (this.LocationApiId?.Equals(other.LocationApiId) == true)) &&
                this.OnCreate.Equals(other.OnCreate) &&
                this.OnUpdate.Equals(other.OnUpdate) &&
                this.OnDelete.Equals(other.OnDelete) &&
                ((this.PostbackConfigId == null && other.PostbackConfigId == null) || (this.PostbackConfigId?.Equals(other.PostbackConfigId) == true)) &&
                ((this.ProductTransactionId == null && other.ProductTransactionId == null) || (this.ProductTransactionId?.Equals(other.ProductTransactionId) == true)) &&
                ((this.Resource == null && other.Resource == null) || (this.Resource?.Equals(other.Resource) == true)) &&
                this.NumberOfAttempts.Equals(other.NumberOfAttempts) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AttemptInterval = {(this.AttemptInterval == null ? "null" : this.AttemptInterval.ToString())}");
            toStringOutput.Add($"this.BasicAuthUsername = {(this.BasicAuthUsername == null ? "null" : this.BasicAuthUsername)}");
            toStringOutput.Add($"this.BasicAuthPassword = {(this.BasicAuthPassword == null ? "null" : this.BasicAuthPassword)}");
            toStringOutput.Add($"this.Expands = {(this.Expands == null ? "null" : this.Expands)}");
            toStringOutput.Add($"this.Format = {(this.Format == null ? "null" : this.Format.ToString())}");
            toStringOutput.Add($"this.IsActive = {this.IsActive}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId)}");
            toStringOutput.Add($"this.LocationApiId = {(this.LocationApiId == null ? "null" : this.LocationApiId)}");
            toStringOutput.Add($"this.OnCreate = {this.OnCreate}");
            toStringOutput.Add($"this.OnUpdate = {this.OnUpdate}");
            toStringOutput.Add($"this.OnDelete = {this.OnDelete}");
            toStringOutput.Add($"this.PostbackConfigId = {(this.PostbackConfigId == null ? "null" : this.PostbackConfigId)}");
            toStringOutput.Add($"this.ProductTransactionId = {(this.ProductTransactionId == null ? "null" : this.ProductTransactionId)}");
            toStringOutput.Add($"this.Resource = {(this.Resource == null ? "null" : this.Resource.ToString())}");
            toStringOutput.Add($"this.NumberOfAttempts = {this.NumberOfAttempts}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");

            base.ToString(toStringOutput);
        }
    }
}