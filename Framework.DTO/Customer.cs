using Newtonsoft.Json;
using System;

namespace Framework.DTO
{
    public class Customer
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("nationalId")]
        public string NationalId { get; set; }

    }
}
