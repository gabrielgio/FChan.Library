using System;

namespace FChan.Library
{
    /// <summary>
    /// Constants.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The board URL.
        /// </summary>
        public const string BoardUrl = "https://a.4cdn.org/boards.json";

        /// <summary>
        /// The thread page URL.
        /// </summary>
        public const string ThreadPageUrl = "https://a.4cdn.org/{0}/{1}.json";

        /// <summary>
        /// The thread URL.
        /// </summary>
        public const string ThreadUrl = "https://a.4cdn.org/{0}/thread/{1}.json";
        
        /// <summary>
        /// The image URL.
        /// </summary>
        public const string ImageUrl = "https://i.4cdn.org/{0}/{1}{2}";

        /// <summary>
        /// The thumbnail URL.
        /// </summary>
        public const string ThumbnailUrl = "https://i.4cdn.org/{0}/{1}s.jpg";
        
        /// <summary>
        /// The spoiler image URL.
        /// </summary>
        public const string SpoilerImageUrl = "https://s.4cdn.org/image/spoiler.png";

        /// <summary>
        /// The closed thread icon URL.
        /// </summary>
        public const string ClosedThreadIconUrl = "https://s.4cdn.org/image/closed.gif";

        /// <summary>
        /// The sticky thread icon URL.
        /// </summary>
        public const string StickyThreadIconUrl = "https://s.4cdn.org/image/sticky.gif";

        /// <summary>
        /// The mod capcode icon URL.
        /// </summary>
        public const string ModCapcodeIconUrl = "https://s.4cdn.org/image/modicon.gif";

        /// <summary>
        /// The developer capcode icon URL.
        /// </summary>
        public const string DeveloperCapcodeIconUrl = "https://s.4cdn.org/image/developericon.gif";

        /// <summary>
        /// The op file deleted icon URL.
        /// </summary>
        public const string OpFileDeletedIconUrl = "https://s.4cdn.org/image/filedeleted.gif";

        /// <summary>
        /// The replied file deleted icon URL.
        /// </summary>
        public const string RepliedFileDeletedIconUrl = "https://s.4cdn.org/image/filedeleted-res.gif";

        /// <summary>
        /// The country flag URL.
        /// </summary>
        public const string CountryFlagUrl = "https://s.4cdn.org/image/country/{0}.gif";

        /// <summary>
        /// Gets the country flag URL.
        /// </summary>
        /// <returns>The country flag URL.</returns>
        /// <param name="country">Country.</param>
        public static string GetCountryFlagUrl(string country)
        {
            return string.Format(CountryFlagUrl, country);
        }

        /// <summary>
        /// Gets the thread page URL.
        /// </summary>
        /// <returns>The thread page URL.</returns>
        /// <param name="board">Board.</param>
        /// <param name="page">Page.</param>
        public static string GetThreadPageUrl(string board, int page)
        {
            return string.Format(ThreadPageUrl, board, page);
        }

        /// <summary>
        /// Gets the thread URL.
        /// </summary>
        /// <returns>The thread URL.</returns>
        /// <param name="board">Board.</param>
        /// <param name="threadNumber">Thread number.</param>
        public static string GetThreadUrl(string board, int threadNumber)
        {
            return string.Format(ThreadUrl, board, threadNumber);
        }

        /// <summary>
        /// Gets the thumbnail.
        /// </summary>
        /// <returns>The thumbnail.</returns>
        /// <param name="board">Board.</param>
        /// <param name="tim">Tim.</param>
        public static string GetThumbnail(string board, double tim)
        {
            return string.Format(ThumbnailUrl, board, tim);
        }

        /// <summary>
        /// Gets the image URL.
        /// </summary>
        /// <returns>The image URL.</returns>
        /// <param name="board">Board.</param>
        /// <param name="tim">Tim.</param>
        /// <param name="extension">Extension.</param>
        public static string GetImageUrl(string board, double tim, string extension)
        {
            return string.Format(ImageUrl, board, tim, extension);
        }
    }
}

