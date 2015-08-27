using System;

namespace FChan.Library
{
	public class Constants
	{
		public const string BoardUrl = "https://a.4cdn.org/boards.json";

		public const string ThreadPageUrl = "https://a.4cdn.org/{0}/{1}.json";

		public const string ThreadUrl = "https://a.4cdn.org/{0}/thread/{1}.json";

        public const string ImageUrl = "https://i.4cdn.org/{0}/{1}{2}";

        public const string ThumbnailUrl = "https://i.4cdn.org/{0}/{1}s.jpg";

        public const string SpoilerImageUrl = "https://s.4cdn.org/image/spoiler.png";

        public const string ClosedThreadIconUrl = "https://s.4cdn.org/image/closed.gif";

        public const string StickyThreadIconUrl = "https://s.4cdn.org/image/sticky.gif";

        public const string ModCapcodeIconUrl = "https://s.4cdn.org/image/modicon.gif";

        public const string DeveloperCapcodeIconUrl = "https://s.4cdn.org/image/developericon.gif";

        public const string OpFileDeletedIconUrl = "https://s.4cdn.org/image/filedeleted.gif";

        public const string RepliedFileDeletedIconUrl = "https://s.4cdn.org/image/filedeleted-res.gif";

        public const string CountryFlagUrl = "https://s.4cdn.org/image/country/{0}.gif";

        public static string GetCountryFlagUrl(string country)
        {
            return string.Format (CountryFlagUrl, country);
        }

		public static string GetThreadPageUrl(string board, int page)
		{
			return string.Format (ThreadPageUrl, board, page);
		}

		public static string GetThreadUrl(string board, int threadNumber)
		{
			return string.Format (ThreadUrl, board, threadNumber);
		}

        public static string GetThumbnail(string board, double tim)
        {
            return string.Format (ThumbnailUrl, board, tim);
        }

		public static string GetImageUrl(string board, double tim, string extension)
		{
			return string.Format (ImageUrl, board, tim, extension);
		}
	}
}

