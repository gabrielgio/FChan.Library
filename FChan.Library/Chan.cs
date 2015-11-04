using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;

namespace FChan.Library
{
    /// <summary>
    /// Chan.
    /// </summary>
    public static class Chan
    {
        internal static T DownloadObject<T>(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);

                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();

                reader.Close();
                response.Close();

                return JsonConvert.DeserializeObject<T>(responseFromServer);
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// Gets boards info.
        /// </summary>
        /// <returns>The board.</returns>
        public static BoardRootObject GetBoard()
        {
            return DownloadObject<BoardRootObject>(Constants.BoardUrl);
        }

        /// <summary>
        /// Gets thead root object.
        /// </summary>
        /// <returns>The thread page.</returns>
        /// <param name="board">Board.</param>
        /// <param name="page">Page.</param>
        public static ThreadRootObject GetThreadPage(string board, int page)
        {
            return DownloadObject<ThreadRootObject>(Constants.GetThreadPageUrl(board, page));
        }

        /// <summary>
        /// Gets the thread.
        /// </summary>
        /// <returns>The thread.</returns>
        /// <param name="boad">Boad.</param>
        /// <param name="threadNumber">Thread number.</param>
        public static Thread GetThread(string boad, int threadNumber)
        {
            return DownloadObject<Thread>(Constants.GetThreadUrl(boad, threadNumber));
        }
    }
}