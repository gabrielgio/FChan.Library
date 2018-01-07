using Newtonsoft.Json;

namespace FChan.Library
{
    /// <summary>
    ///     This class is the equivlate of post object from https://github.com/4chan/4chan-API
    /// </summary>
    public class Post
    {
        /// <summary>
        ///     Get or sets the post number.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for no.
        /// </remarks>
        /// <value>The post number.</value>
        [JsonProperty("no")]
        public int PostNumber { get; set; }

        /// <summary>
        ///     Gets or sets the tag.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for tag.
        /// </remarks>
        /// <value>The tag.</value>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        ///     Gets and sets the date of creation.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for now.
        /// </remarks>
        /// <value>The date of creation.</value>
        [JsonProperty("now")]
        public string Date { get; set; }

        /// <summary>
        ///     Post name.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for name.
        /// </remarks>
        /// <value>The post name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Time when archived.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for archived_on.
        /// </remarks>
        /// <value>Time when archived.</value>
        [JsonProperty("archived_on")]
        public int ArchivedOn { get; set; }

        /// <summary>
        ///     Gets or sets the subject.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for sub.
        /// </remarks>
        /// <value>Subject.</value>
        [JsonProperty("sub")]
        public string Subject { get; set; }

        /// <summary>
        ///     Comment name.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for com.
        /// </remarks>
        /// <value>Comment.</value>
        [JsonProperty("com")]
        public string Comment { get; set; }

        /// <summary>
        ///     Gets or sets the name of the original file.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for filename.
        /// </remarks>
        /// <value>The name of the original file.</value>
        [JsonProperty("filename")]
        public string OriginalFileName { get; set; }

        /// <summary>
        ///     Gets or sets the file extension.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for ext.
        /// </remarks>
        /// <value>The file extension.</value>
        [JsonProperty("ext")]
        public string FileExtension { get; set; }

        /// <summary>
        ///     Gets or sets the width of the image.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for w.
        /// </remarks>
        /// <value>The width of the image.</value>
        [JsonProperty("w")]
        public int? ImageWidth { get; set; }

        /// <summary>
        ///     Gets or sets the height of the image.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for h.
        /// </remarks>
        /// <value>The height of the image.</value>
        [JsonProperty("h")]
        public int? ImageHeight { get; set; }

        /// <summary>
        ///     Gets or sets the width of the thumbnail.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for tn_w.
        /// </remarks>
        /// <value>The width of the thumbnail.</value>
        [JsonProperty("tn_w")]
        public int? ThumbnailWidth { get; set; }

        /// <summary>
        ///     Gets or sets the height of the thumbnail.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for tn_h.
        /// </remarks>
        /// <value>The height of the thumbnail.</value>
        [JsonProperty("tn_h")]
        public int? ThumbnailHeight { get; set; }

        /// <summary>
        ///     Gets or sets the name of the renamed file.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for tim.
        /// </remarks>
        /// <value>The name of the renamed file.</value>
        [JsonProperty("tim")]
        public long FileName { get; set; }

        /// <summary>
        ///     Gets or sets the when last modified.
        ///     Only displayed in threads.json, and includes replies, deletions, and sticky/closed changes
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for last_modified.
        /// </remarks>
        /// <value>The name of the renamed file.</value>
        [JsonProperty("last_modified")]
        public long? LastModified { get; set; }

        /// <summary>
        ///     Gets or sets the unix timestamp.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for time.
        /// </remarks>
        /// <value>The unix timestamp.</value>
        [JsonProperty("time")]
        public int UnixTimestamp { get; set; }

        /// <summary>
        ///     Gets or sets the M d5.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for md5.
        /// </remarks>
        /// <value>The M d5.</value>
        [JsonProperty("md5")]
        public string MD5 { get; set; }

        /// <summary>
        ///     Gets or sets the size of the file.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for fsize.
        /// </remarks>
        /// <value>The size of the file.</value>
        [JsonProperty("fsize")]
        public int? FileSize { get; set; }

        /// <summary>
        ///     Gets or sets the reply to.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for resto.
        /// </remarks>
        /// <value>The reply to.</value>
        [JsonProperty("resto")]
        public int ReplyTo { get; set; }

        /// <summary>
        ///     Gets or sets the file deleted. Only displays when image uploaded
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for filedeleted.
        /// </remarks>
        /// <value>The file deleted.</value>
        [JsonProperty("filedeleted")]
        public int? FileDeleted { get; set; }

        /// <summary>
        ///     Gets a value indicating whether this instance is file deleted. Only displays when image uploaded
        /// </summary>
        /// <remarks>
        ///     This property is a wrapper of <see cref="FileDeleted" /> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if the file has been deleted; otherwise, <c>false</c>.</value>
        public bool? IsFileDeleted
        {
            get
            {
                if (FileDeleted.HasValue)
                    return FileDeleted.Value != 0;
                return null;
            }
        }

        /// <summary>
        ///     Gets or sets the bump limit.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for bumblimit.
        /// </remarks>
        /// <value>The bump limit.</value>
        [JsonProperty("bumplimit")]
        public int BumpLimit { get; set; }

        /// <summary>
        ///     Gets a value indicating whether this <see cref="FChan.Library.Post" /> bump limit met.
        /// </summary>
        /// <remarks>
        ///     This property is a wrapper of <see cref="BumpLimit" /> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if bump limit has been met; otherwise, <c>false</c>.</value>
        public bool BumpLimitMet => BumpLimit != 0;

        /// <summary>
        ///     Gets or sets the image limit.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for imagelimit.
        /// </remarks>
        /// <value>The image limit.</value>
        [JsonProperty("imagelimit")]
        public int ImageLimit { get; set; }

        /// <summary>
        ///     Gets a value indicating whether this <see cref="FChan.Library.Post" /> image limit met.
        /// </summary>
        /// <remarks>
        ///     This property is a wrapper of <see cref="ImageLimit" /> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if image limit has been met; otherwise, <c>false</c>.</value>
        public bool ImageLimitMet => ImageLimit != 0;

        /// <summary>
        ///     Gets or sets the sticky.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for sticky.
        /// </remarks>
        /// <value>The sticky.</value>
        [JsonProperty("sticky")]
        public int Sticky { get; set; }

        /// <summary>
        ///     Gets a value indicating whether this <see cref="FChan.Library.Post" /> is a stickied thread.
        /// </summary>
        /// <remarks>
        ///     This property is a wrapper of <see cref="Sticky" /> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if image limit has been met; otherwise, <c>false</c>.</value>
        public bool IsStickied => Sticky != 0;

        /// <summary>
        ///     Gets or sets the thread URL slug.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for semantic_url.
        /// </remarks>
        /// <value>The thread URL slug.</value>
        [JsonProperty("semantic_url")]
        public string ThreadUrlSlug { get; set; }

        /// <summary>
        ///     Gets or sets the sticky.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for closed.
        /// </remarks>
        /// <value>The sticky.</value>
        [JsonProperty("closed")]
        public int Closed { get; set; }

        /// <summary>
        ///     Gets a value indicating whether this <see cref="FChan.Library.Post" /> is closed.
        /// </summary>
        /// <remarks>
        ///     This property is a wrapper of <see cref="Closed" /> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if image limit has been met; otherwise, <c>false</c>.</value>
        public bool IsClosed => Closed != 0;

        /// <summary>
        ///     Gets or sets the archived.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for archived.
        /// </remarks>
        /// <value>The sticky.</value>
        [JsonProperty("archived")]
        public int Archived { get; set; }

        /// <summary>
        ///     Gets a value indicating whether this <see cref="FChan.Library.Post" /> is archived.
        /// </summary>
        /// <remarks>
        ///     This property is a wrapper of <see cref="Archived" /> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if image limit has been met; otherwise, <c>false</c>.</value>
        public bool IsArchived => Archived != 0;

        /// <summary>
        ///     Gets or sets the spoiler.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for spoiler. Only displays when image uploaded
        /// </remarks>
        /// <value>The custom spoilers.</value>
        [JsonProperty("spoiler")]
        public int? Spoiler { get; set; }

        /// <summary>
        ///     Gets a value indicating whether this <see cref="FChan.Library.Post" /> has or not spoilers.
        ///     Only displays when image uploaded
        /// </summary>
        /// <remarks>
        ///     This property is a wrapper of <see cref="Spoiler" /> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if this post has spoilers; otherwise it is, <c>false</c>.</value>
        public bool? HasSpoiler
        {
            get
            {
                if (Spoiler.HasValue)
                    return Spoiler.Value != 0;
                return null;
            }
        }

        /// <summary>
        ///     Gets or sets the custom spoilers.
        ///     Only display on OPs, Only displays when board has custom spoiler images
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for custom_spoiler.
        /// </remarks>
        /// <value>The custom spoilers.</value>
        [JsonProperty("custom_spoiler")]
        public int? CustomSpoilers { get; set; }

        /// <summary>
        ///     Gets or sets the replies.
        ///     Only displays on OPs
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for replies.
        /// </remarks>
        /// <value>The replies.</value>
        [JsonProperty("replies")]
        public int? Replies { get; set; }

        /// <summary>
        ///     Gets or sets the images.
        ///     Only displays on OPs
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for images.
        /// </remarks>
        /// <value>The images.</value>
        [JsonProperty("images")]
        public int? Images { get; set; }

        /// <summary>
        ///     Gets or sets the replies omitted.
        ///     Only displays on OPs on index pages
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for ommited_posts.
        /// </remarks>
        /// <value>The replies omitted.</value>
        [JsonProperty("omitted_posts")]
        public int? RepliesOmitted { get; set; }

        /// <summary>
        ///     Gets or sets the image replies omitted.
        ///     Only displays on OPs on index pages
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for omitted_images.
        /// </remarks>
        /// <value>The image replies omitted.</value>
        [JsonProperty("omitted_images")]
        public int? ImageRepliesOmitted { get; set; }

        /// <summary>
        ///     Gets or sets the trip code.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for trip.
        /// </remarks>
        /// <value>The trip code.</value>
        [JsonProperty("trip")]
        public string TripCode { get; set; }

        /// <summary>
        ///     Gets or sets the capcode.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for capcode.
        /// </remarks>
        /// <value>The trip code.</value>
        [JsonProperty("capcode")]
        public string Capcode { get; set; }

        /// <summary>
        ///     Gets or sets the country.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for country.
        /// </remarks>
        /// <value>The trip code.</value>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        ///     Gets or sets the country name.
        /// </summary>
        /// <remarks>
        ///     This property is the equivalent for country_name.
        /// </remarks>
        /// <value>The trip code.</value>
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        ///     Gets or sets the identifier. (none, mod, admin, admin_highlight, developer, founder)
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the board which this post belongs to.
        /// </summary>
        /// <value>The board.</value>
        public string Board { get; set; }

        /// <summary>
        ///     Gets a value indicating whether this instance has image.
        /// </summary>
        /// <value><c>true</c> if this instance has image; otherwise, <c>false</c>.</value>
        public bool HasImage => !string.IsNullOrEmpty(OriginalFileName);

        /// <summary>
        ///     Convert this post into a json string.
        /// </summary>
        /// <returns>The json.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Convert this post into a json string.
        /// </summary>
        /// <returns>The json.</returns>
        /// <param name="indented">If set to <c>true</c> indented.</param>
        public string ToJson(bool indented)
        {
            return JsonConvert.SerializeObject(this, indented ? Formatting.Indented : Formatting.None);
        }

        /// <summary>
        ///     Convert this post back to a Post.
        /// </summary>
        /// <returns>The json.</returns>
        /// <param name="json">Json.</param>
        public static Post FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Post>(json);
        }
    }
}