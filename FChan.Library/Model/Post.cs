using System;
using Newtonsoft.Json;

namespace FChan.Library
{
    /// <summary>
    /// This class is the equivlate of post object from https://github.com/4chan/4chan-API
    /// </summary>
	public class Post
	{
        /// <summary>
        /// Get or sets the post number.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of no.
        /// </remarks>
        /// <value>The post number.</value>
        [JsonProperty("no")]
        public int PostNumber { get; set; }

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of tag.
        /// </remarks>
        /// <value>The tag.</value>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Gets and sets the date of creation.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of now.
        /// </remarks>
        /// <value>The date of creation.</value>
        [JsonProperty("now")]
        public string Date { get; set; }

        /// <summary>
        /// Post name.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of name.
        /// </remarks>
        /// <value>The post name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the post name.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of name.
        /// </remarks>
        /// <value>The post name.</value>
        [JsonProperty("sub")]
        public string Subject { get; set; }

        /// <summary>
        /// Post name.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of name.
        /// </remarks>
        /// <value>The post name.</value>
        [JsonProperty("com")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the name of the original file.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of filename.
        /// </remarks>
        /// <value>The name of the original file.</value>
        [JsonProperty("filename")]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of ext.
        /// </remarks>
        /// <value>The file extension.</value>
        [JsonProperty("ext")]
        public string FileExtension { get; set; }

        /// <summary>
        /// Gets or sets the width of the image.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of w.
        /// </remarks>
        /// <value>The width of the image.</value>
        [JsonProperty("w")]
        public int ImageWidth { get; set; }

        /// <summary>
        /// Gets or sets the height of the image.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of h.
        /// </remarks>
        /// <value>The height of the image.</value>
        [JsonProperty("h")]
        public int ImageHeight { get; set; }

        /// <summary>
        /// Gets or sets the width of the thumbnail.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of tn_w.
        /// </remarks>
        /// <value>The width of the thumbnail.</value>
        [JsonProperty("tn_w")]
        public int ThumbnailWidth { get; set; }

        /// <summary>
        /// Gets or sets the height of the thumbnail.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of tn_h.
        /// </remarks>
        /// <value>The height of the thumbnail.</value>
        [JsonProperty("tn_h")]
        public int ThumbnailHeight { get; set; }

        /// <summary>
        /// Gets or sets the name of the renamed file.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of tim.
        /// </remarks>
        /// <value>The name of the renamed file.</value>
        [JsonProperty("tim")]
        public long RenamedFileName { get; set; }


        /// <summary>
        /// Gets or sets the unix timestamp.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of time.
        /// </remarks>
        /// <value>The unix timestamp.</value>
        [JsonProperty("time")]
        public int UnixTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the M d5.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of md5.
        /// </remarks>
        /// <value>The M d5.</value>
        [JsonProperty("md5")]
        public string MD5 { get; set; }

        /// <summary>
        /// Gets or sets the size of the file.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of fsize.
        /// </remarks>
        /// <value>The size of the file.</value>
        [JsonProperty("fsize")]
        public int FileSize { get; set; }

        /// <summary>
        /// Gets or sets the reply to.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of resto.
        /// </remarks>
        /// <value>The reply to.</value>
        [JsonProperty("resto")]
        public int ReplyTo { get; set; }

        /// <summary>
        /// Gets or sets the file deleted.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of filedeleted.
        /// </remarks>
        /// <value>The file deleted.</value>
        [JsonProperty("filedeleted")]
        public int FileDeleted { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is file deleted.
        /// </summary>
        /// <remarks>
        /// This property is a wrapper of <see cref="FileDeleted"/> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if the file has been deleted; otherwise, <c>false</c>.</value>
        public bool IsFileDeleted { get { return FileDeleted != 0; } }

        /// <summary>
        /// Gets or sets the bump limit.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of bumblimit.
        /// </remarks>
        /// <value>The bump limit.</value>
        [JsonProperty("bumplimit")]
        public int BumpLimit { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="FChan.Library.Post"/> bump limit met.
        /// </summary>
        /// <remarks>
        /// This property is a wrapper of <see cref="BumpLimit"/> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if bump limit has been met; otherwise, <c>false</c>.</value>
        public bool BumpLimitMet{ get { return BumpLimit != 0; } }

        /// <summary>
        /// Gets or sets the image limit.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of imagelimit.
        /// </remarks>
        /// <value>The image limit.</value>
        [JsonProperty("imagelimit")]
        public int ImageLimit { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="FChan.Library.Post"/> image limit met.
        /// </summary>
        /// <remarks>
        /// This property is a wrapper of <see cref="BumpLimit"/> since it may be 1 or 0.
        /// </remarks>
        /// <value><c>true</c> if image limit has been met; otherwise, <c>false</c>.</value>
        public bool ImageLimitMet { get { return ImageLimit != 0; } }

        /// <summary>
        /// Gets or sets the thread URL slug.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of semantic_url.
        /// </remarks>
        /// <value>The thread URL slug.</value>
        [JsonProperty("semantic_url")]
        public string ThreadUrlSlug { get; set; }

        /// <summary>
        /// Gets or sets the custom spoilers.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of custom_spoiler.
        /// </remarks>
        /// <value>The custom spoilers.</value>
        [JsonProperty("custom_spoiler")]
        public int CustomSpoilers { get; set; }

        /// <summary>
        /// Gets or sets the replies.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of replies.
        /// </remarks>
        /// <value>The replies.</value>
        [JsonProperty("replies")]
        public int Replies { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of images.
        /// </remarks>
        /// <value>The images.</value>
        [JsonProperty("images")]
        public int Images { get; set; }

        /// <summary>
        /// Gets or sets the replies omitted.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of ommited_posts.
        /// </remarks>
        /// <value>The replies omitted.</value>
        [JsonProperty("omitted_posts")]
        public int RepliesOmitted { get; set; }

        /// <summary>
        /// Gets or sets the image replies omitted.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of omitted_images.
        /// </remarks>
        /// <value>The image replies omitted.</value>
        [JsonProperty("omitted_images")]
        public int ImageRepliesOmitted { get; set; }

        /// <summary>
        /// Gets or sets the trip code.
        /// </summary>
        /// <remarks>
        /// This property is the equivalent of trip.
        /// </remarks>
        /// <value>The trip code.</value>
        [JsonProperty("trip")]
        public string TripCode { get; set; }

        /// <summary>
        /// Convert it to a json string.
        /// </summary>
        /// <returns>The json.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Convert it back from a json string.
        /// </summary>
        /// <returns>The json.</returns>
        /// <param name="json">Json.</param>
        public static Post FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Post>(json);
        }
	}
}