using Newtonsoft.Json;

namespace FChan.Library
{
    /// <summary>
    /// Board.
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Gets or sets the name of the board.
        /// </summary>
        /// <value>The name of the board.</value>
        [JsonProperty("board")]
        public string BoardName { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ws board.
        /// </summary>
        /// <value>The ws board.</value>
        [JsonProperty("ws_board")]
        public int WsBoard { get; set; }

        /// <summary>
        /// Gets or sets the per page.
        /// </summary>
        /// <value>The per page.</value>
        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        /// <summary>
        /// Gets or sets the pages.
        /// </summary>
        /// <value>The pages.</value>
        [JsonProperty("pages")]
        public int Pages { get; set; }

        /// <summary>
        /// Gets or sets the size of the max file.
        /// </summary>
        /// <value>The size of the max file.</value>
        [JsonProperty("max_filesize")]
        public int MaxFileSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the max webm file.
        /// </summary>
        /// <value>The size of the max webm file.</value>
        [JsonProperty("max_webm_filesize")]
        public int MaxWebmFileSize { get; set; }

        /// <summary>
        /// Gets or sets the max comment chars.
        /// </summary>
        /// <value>The max comment chars.</value>
        [JsonProperty("max_comment_chars")]
        public int MaxCommentChars { get; set; }

        /// <summary>
        /// Gets or sets the bump limit.
        /// </summary>
        /// <value>The bump limit.</value>
        [JsonProperty("bump_limit")]
        public int BumpLimit { get; set; }

        /// <summary>
        /// Gets or sets the image limit.
        /// </summary>
        /// <value>The image limit.</value>
        [JsonProperty("image_limit")]
        public int ImageLimit { get; set; }

        /// <summary>
        /// Gets or sets the cooldowns.
        /// </summary>
        /// <value>The cooldowns.</value>
        [JsonProperty("cooldowns")]
        public Cooldowns Cooldowns { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is archived.
        /// </summary>
        /// <value><c>true</c> if this instance is archived; otherwise, <c>false</c>.</value>
        [JsonProperty("is_archived")]
        public int IsArchived { get; set; }

        /// <summary>
        /// Gets or sets the spoilers.
        /// </summary>
        /// <value>The spoilers.</value>
        [JsonProperty("spoilers")]
        public int? Spoilers { get; set; }

        /// <summary>
        /// Gets or sets the custom spoilers.
        /// </summary>
        /// <value>The custom spoilers.</value>
        [JsonProperty("custom_spoilers")]
        public int? CustomSpoilers { get; set; }

        /// <summary>
        /// Gets or sets the user identifiers.
        /// </summary>
        /// <value>The user identifiers.</value>
        [JsonProperty("user_ids")]
        public int? UserIds { get; set; }

        /// <summary>
        /// Gets or sets the code tags.
        /// </summary>
        /// <value>The code tags.</value>
        [JsonProperty("code_tags")]
        public int? CodeTags { get; set; }

        /// <summary>
        /// Gets or sets the country flags.
        /// </summary>
        /// <value>The country flags.</value>
        [JsonProperty("country_flags")]
        public int? CountryFlags { get; set; }

        /// <summary>
        /// Gets or sets the math tags.
        /// </summary>
        /// <value>The math tags.</value>
        [JsonProperty("math_tags")]
        public int? MathTags { get; set; }

        /// <summary>
        /// Returns the full title of the board, like on the actual website
        /// </summary>
        public override string ToString()
        {
            return string.Format("/{0}/{1}[{2}]", BoardName, Title, Pages);
        }
    }
}
