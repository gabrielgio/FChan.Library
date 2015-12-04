using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;
using System.Linq;

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
                using (var client = new HttpClient())
                {
                    Task<string> response = client.GetStringAsync(url);
                    response.Wait();
                    string responseString = response.Result;
                    return JsonConvert.DeserializeObject<T>(responseString);
                }
            }
            catch
            {
                return default(T);
            }
        }

        internal static async Task<T> DownloadObjectAsync<T>(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string response = await client.GetStringAsync(url);
                    string responseString = response;
                    return JsonConvert.DeserializeObject<T>(responseString);
                }
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
        /// Gets boards info asynchronously.
        /// </summary>
        /// <returns>The board.</returns>
        public static async Task<BoardRootObject> GetBoardAsync()
        {
            return await DownloadObjectAsync<BoardRootObject>(Constants.BoardUrl);
        }

        /// <summary>
        /// Gets thead root object.
        /// </summary>
        /// <returns>The thread page.</returns>
        /// <param name="board">Board.</param>
        /// <param name="page">Page.</param>
        public static ThreadRootObject GetThreadPage(string board, int page)
        {
            ThreadRootObject thread = DownloadObject<ThreadRootObject>(Constants.GetThreadPageUrl(board, page));

            foreach (Thread item in thread.Threads)
                foreach (Post post in item.Posts) 
                    post.Board = board;

            return thread;
        }

        /// <summary>
        /// Gets thead root object asynchronously.
        /// </summary>
        /// <returns>The thread page.</returns>
        /// <param name="board">Board.</param>
        /// <param name="page">Page.</param>
        public static async Task<ThreadRootObject> GetThreadPageAsync(string board, int page)
        {
            ThreadRootObject thread = await DownloadObjectAsync<ThreadRootObject>(Constants.GetThreadPageUrl(board, page));

            foreach (Thread item in thread.Threads)
                foreach (Post post in item.Posts) 
                    post.Board = board;

            return thread;
        }

        /// <summary>
        /// Gets the thread.
        /// </summary>
        /// <returns>The thread.</returns>
        /// <param name="board">Boad.</param>
        /// <param name="threadNumber">Thread number.</param>
        public static Thread GetThread(string board, int threadNumber)
        {
            Thread thread = DownloadObject<Thread>(Constants.GetThreadUrl(board, threadNumber));
            foreach (Post item in thread.Posts)
                item.Board = board;

            return thread;
        }

        /// <summary>
        /// Gets the thread asynchronously.
        /// </summary>
        /// <returns>The thread.</returns>
        /// <param name="board">Boad.</param>
        /// <param name="threadNumber">Thread number.</param>
        public static async Task<Thread> GetThreadAsync(string board, int threadNumber)
        {
            Thread thread = await DownloadObjectAsync<Thread>(Constants.GetThreadUrl(board, threadNumber));
            foreach (Post item in thread.Posts)
                item.Board = board;

            return thread;
        }
	}
}
