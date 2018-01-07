using System.Collections.Generic;
using Newtonsoft.Json;

namespace FChan.Library
{
    /// <summary>
    ///     Thread.
    /// </summary>
    public class Thread
    {
        /// <summary>
        ///     Gets or sets the posts.
        /// </summary>
        /// <value>The posts.</value>
        [JsonProperty("posts")]
        public List<Post> Posts { get; set; }
    }
}