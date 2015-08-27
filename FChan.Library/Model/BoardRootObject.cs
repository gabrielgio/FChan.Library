using System.Collections.Generic;
using Newtonsoft.Json;

namespace FChan.Library
{
    public class BoardRootObject
    {
        [JsonProperty("boards")]
        public List<Board> Boards { get; set; }
    }
}
