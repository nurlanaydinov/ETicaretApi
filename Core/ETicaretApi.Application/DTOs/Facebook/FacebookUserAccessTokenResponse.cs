using System.Text.Json.Serialization;

namespace ETicaretApi.Application.DTOs.Facebook
{
    public class FacebookUserAccessTokenResponse
    {
        [JsonPropertyName("data")]
        public FacebookUserAccessTokenResponseData Data { get; set; }
    }

    public class FacebookUserAccessTokenResponseData
    {
        [JsonPropertyName("is_valid")]
        public bool IsValid { get; set; }
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
