using System;
using Newtonsoft.Json;

namespace App.JsonModels
{
    public class User
    {
        [JsonProperty("profile_sidebar_fill_color")]
        public String ProfileSidebarFillColor { get; set; }
        [JsonProperty("profile_sidebar_border_color")]
        public String ProfileSidebarBorderColor { get; set; }
        [JsonProperty("profile_background_tile")]
        public bool ProfileBackgroundTile { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("profile_image_url")]
        public String ProfileImageUrl { get; set; }
        [JsonProperty("created_at")]
        public String CreatedAt { get; set; }
        [JsonProperty("location")]
        public String Location { get; set; }
        [JsonProperty("follow_request_sent")]
        public bool IsFollowRequestSent { get; set; }
        [JsonProperty("profile_link_color")]
        public String ProfileLinkColor { get; set; }
        [JsonProperty("is_translator")]
        public bool IsTranslator { get; set; }
        [JsonProperty("id_str")]
        public String IdStr { get; set; }
        [JsonProperty("entities")]
        public UserEntities Entities { get; set; }
        [JsonProperty("default_profile")]
        public bool IsDefaultProfile { get; set; }
        [JsonProperty("contributors_enabled")]
        public bool IsContributorsEnabled { get; set; }
        [JsonProperty("favourites_count")]
        public int FavouritesCount { get; set; }
        [JsonProperty("url")]
        public String Url { get; set; }
        [JsonProperty("profile_image_url_https")]
        public String ProfileImageUrlHttps { get; set; }
        [JsonProperty("utc_offset")]
        public int UtcOffset { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("profile_use_background_image")]
        public bool IsProfileUseBackgroundImage { get; set; }
        [JsonProperty("listed_count")]
        public int ListedCount { get; set; }
        [JsonProperty("profile_text_color")]
        public String ProfileTextColor { get; set; }
        [JsonProperty("lang")]
        public String Lang { get; set; }
        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }
        [JsonProperty("protected")]
        public bool IsProtected { get; set; }
        [JsonProperty("notifications")]
        public String Notifications { get; set; }
        [JsonProperty("profile_background_image_url_https")]
        public String ProfileBackgroundImageUrlHttps { get; set; }
        [JsonProperty("profile_background_color")]
        public String ProfileBackgroundColor { get; set; }
        [JsonProperty("verified")]
        public bool IsVerified { get; set; }
        [JsonProperty("geo_enabled")]
        public bool IsGeoEnabled { get; set; }
        [JsonProperty("time_zone")]
        public String TimeZone { get; set; }
        [JsonProperty("description")]
        public string IsDescription { get; set; }
        [JsonProperty("default_profile_image")]
        public bool IsDefaultProfileImage { get; set; }
        [JsonProperty("profile_background_image_url")]
        public string ProfileBackgroundImageUrl { get; set; }
        [JsonProperty("statuses_count")]
        public int StatusesCount { get; set; }
        [JsonProperty("friends_count")]
        public int FriendsCount { get; set; }
        [JsonProperty("following")]
        public string Following { get; set; }
        [JsonProperty("show_all_inline_media")]
        public bool IsShowAllInlineMedia { get; set; }
        [JsonProperty("screen_name")]
        public String ScreenName { get; set; }
    }
}
