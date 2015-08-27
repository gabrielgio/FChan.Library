using System.Collections.Generic;
using Newtonsoft.Json;

namespace FChan.Library
{
	public class Thread
	{
        [JsonProperty("posts")]
        public List<Post> Posts { get; set; }
	}
}

