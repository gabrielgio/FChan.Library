using System;
using Newtonsoft.Json;

namespace FChan.Library
{
	public class Cooldowns
	{
        [JsonProperty("threads")]
		public int Threads { get; set; }

        [JsonProperty("replies")]
		public int Replies { get; set; }

        [JsonProperty("images")]
		public int Images { get; set; }

        [JsonProperty("replies_intra")]
		public int RepliesIntra { get; set; }

        [JsonProperty("images_intra")]
		public int ImagesIntra { get; set; }
	}
}

