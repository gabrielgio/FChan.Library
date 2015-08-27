using Newtonsoft.Json;

namespace FChan.Library
{
	public class Board
	{
        [JsonProperty("board")]
		public string BoardName { get; set; }

        [JsonProperty("title")]
		public string Title { get; set; }

        [JsonProperty("ws_board")]
		public int WsBoard { get; set; }

        [JsonProperty("per_page")]
		public int PerPage { get; set; }

        [JsonProperty("pages")]
		public int Pages { get; set; }

        [JsonProperty("max_filesize")]
		public int MaxFileSize { get; set; }

        [JsonProperty("max_webm_filesize")]
		public int MaxWebmFileSize { get; set; }

        [JsonProperty("max_comment_chars")]
		public int MaxCommentChars { get; set; }

        [JsonProperty("bump_limit")]
		public int BumpLimit { get; set; }

        [JsonProperty("image_limit")]
		public int ImageLimit { get; set; }

        [JsonProperty("cooldowns")]
		public Cooldowns Cooldowns { get; set; }

        [JsonProperty("is_archived")]
		public int IsArchived { get; set; }

        [JsonProperty("spoilers")]
		public int? Spoilers { get; set; }

        [JsonProperty("custom_spoilers")]
		public int? CustomSpoilers { get; set; }

        [JsonProperty("user_ids")]
		public int? UserIds { get; set; }

        [JsonProperty("code_tags")]
		public int? CodeTags { get; set; }

        [JsonProperty("country_flags")]
		public int? CountryFlags { get; set; }

        [JsonProperty("math_tags")]
		public int? MathTags { get; set; }
	}
}

