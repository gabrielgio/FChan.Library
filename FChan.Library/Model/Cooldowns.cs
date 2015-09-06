using System;
using Newtonsoft.Json;

namespace FChan.Library
{
    /// <summary>
    /// Cooldowns.
    /// </summary>
    public class Cooldowns
    {
        /// <summary>
        /// Gets or sets the threads.
        /// </summary>
        /// <value>The threads.</value>
        [JsonProperty("threads")]
        public int Threads { get; set; }

        /// <summary>
        /// Gets or sets the replies.
        /// </summary>
        /// <value>The replies.</value>
        [JsonProperty("replies")]
        public int Replies { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>The images.</value>
        [JsonProperty("images")]
        public int Images { get; set; }

        /// <summary>
        /// Gets or sets the replies intra.
        /// </summary>
        /// <value>The replies intra.</value>
        [JsonProperty("replies_intra")]
        public int RepliesIntra { get; set; }

        /// <summary>
        /// Gets or sets the images intra.
        /// </summary>
        /// <value>The images intra.</value>
        [JsonProperty("images_intra")]
        public int ImagesIntra { get; set; }
    }
}
