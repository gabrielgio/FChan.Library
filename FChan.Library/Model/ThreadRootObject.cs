using System.Collections.Generic;
using Newtonsoft.Json;

namespace FChan.Library
{
    public class ThreadRootObject
    {
        [JsonProperty("threads")]
        public List<Thread> Threads { get; set; }
    }
}
