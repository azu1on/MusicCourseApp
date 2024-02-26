using System.Text.Json.Serialization;

namespace MusicCourseApplication.Dtos
{
    public class CouponDto
    {
        [JsonPropertyName("couponstring")]
        public string? CouponString { get; set; }

    }
}
