using System.Collections.Generic;
using Newtonsoft.Json;

namespace FChan.Library
{
    /// <summary>
    /// Thread root object.
    /// </summary>
    public class ThreadRootObject
    {
        /// <summary>
        /// Gets or sets the threads.
        /// </summary>
        /// <value>The threads.</value>
        [JsonProperty("threads")]
        public List<Thread> Threads { get; set; }
    }
}
