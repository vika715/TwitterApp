using Newtonsoft.Json;
using System;

namespace App.JsonModels
{
    public class Tweet
    {
        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }
        [JsonProperty("favorited")]
        public bool IsFavorited { get; set; }
        [JsonProperty("truncated")]
        public bool IsTruncated { get; set; }
        [JsonProperty("created_at")]
        public string CreatedTime { get; set; }
        [JsonProperty("id_str")]
        public string IdStr { get; set; }
        [JsonProperty("entities")]
        public Entities Entitites { get; set; }
        [JsonProperty("in_reply_to_user_id_str")]
        public string InReplyToUserIdStr { get; set; }
        [JsonProperty("contributors")]
        public string Contributors { get; set; }
        [JsonProperty("text")]
        public String Text { get; set; }
        [JsonProperty("retweet_count")]
        public int RetweetCount { get; set; }
        [JsonProperty("in_reply_to_status_id_str")]
        public string InReplyToStatusIdStr { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("geo")]
        public string Geo { get; set; }
        [JsonProperty("retweeted")]
        public bool IsRetweeted { get; set; }
        [JsonProperty("possibly_sensitive")]
        public bool IsPossibleSensitive { get; set; }
        [JsonProperty("in_reply_to_user_id")]
        public String InReplyToUserId { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("in_reply_to_screen_name")]
        public String InReplyToScreenName { get; set; }
        [JsonProperty("source")]
        public String Source { get; set; }
        [JsonProperty("in_reply_to_status_id")]
        public String InReplyToStatusId { get; set; }
    }
}