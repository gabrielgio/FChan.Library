using System.Collections.Generic;
using Newtonsoft.Json;

namespace FChan.Library
{
    /// <summary>
    /// Board root object.
    /// </summary>
    public class BoardRootObject
    {
        /// <summary>
        /// Gets or sets the boards.
        /// </summary>
        /// <value>The boards.</value>
        [JsonProperty("boards")]
        public List<Board> Boards { get; set; }
    }
}
