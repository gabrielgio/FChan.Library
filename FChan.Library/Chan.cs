using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static FChan.Library.Constants;

namespace FChan.Library
{
    /// <summary>
    ///     Chan.
    /// </summary>
    public static class Chan
    {
        private static T DownloadObject<T>(string url)
        {
            var task = DownloadObjectAsync<T>(url);
            task.Wait();
            return task.Result;
        }

        private static async Task<T> DownloadObjectAsync<T>(string url)
        {
            try
            {
                var response = await GetStringAsync(url);
                var responseString = response;
                return JsonConvert.DeserializeObject<T>(responseString);
            }
            catch
            {
                return default(T);
            }
        }

        private static async Task<string> GetStringAsync(string url)
        {
            var request = WebRequest.CreateHttp(url);
            request.Method = "GET";

            var task = new TaskCompletionSource<WebResponse>();

            request.BeginGetResponse(ac =>
            {
                try
                {
                    task.SetResult(request.EndGetResponse(ac));
                }
                catch (Exception e)
                {
                    task.SetException(e);
                }
            }, null);

            using (var response = await task.Task)
            using (var stream = response.GetResponseStream())
            using (var output = new MemoryStream())
            {
                if (stream != null) await stream.CopyToAsync(output);
                var array = output.ToArray();
                return Encoding.UTF8.GetString(array, 0, array.Length);
            }
        }

        /// <summary>
        ///     Gets boards info.
        /// </summary>
        /// <returns>The board.</returns>
        public static BoardRootObject GetBoard() => DownloadObject<BoardRootObject>(BoardUrl);

        /// <summary>
        ///     Gets boards info asynchronously.
        /// </summary>
        /// <returns>The board.</returns>
        public static Task<BoardRootObject> GetBoardAsync() => DownloadObjectAsync<BoardRootObject>(BoardUrl);

        /// <summary>
        ///     Gets thead root object.
        /// </summary>
        /// <returns>The thread page.</returns>
        /// <param name="board">Board.</param>
        /// <param name="page">Page.</param>
        public static ThreadRootObject GetThreadPage(string board, int page)
        {
            var thread = DownloadObject<ThreadRootObject>(GetThreadPageUrl(board, page));

            foreach (var post in thread.Threads.SelectMany(item => item.Posts))
                post.Board = board;

            return thread;
        }

        /// <summary>
        ///     Gets thead root object asynchronously.
        /// </summary>
        /// <returns>The thread page.</returns>
        /// <param name="board">Board.</param>
        /// <param name="page">Page.</param>
        public static async Task<ThreadRootObject> GetThreadPageAsync(string board, int page)
        {
            var thread = await DownloadObjectAsync<ThreadRootObject>(GetThreadPageUrl(board, page));

            foreach (var post in thread.Threads.SelectMany(item => item.Posts))
                post.Board = board;

            return thread;
        }

        /// <summary>
        ///     Gets the thread.
        /// </summary>
        /// <returns>The thread.</returns>
        /// <param name="board">Boad.</param>
        /// <param name="threadNumber">Thread number.</param>
        public static Thread GetThread(string board, int threadNumber)
        {
            var thread = DownloadObject<Thread>(GetThreadUrl(board, threadNumber));
            foreach (var item in thread.Posts)
                item.Board = board;

            return thread;
        }

        /// <summary>
        ///     Gets the thread asynchronously.
        /// </summary>
        /// <returns>The thread.</returns>
        /// <param name="board">Board.</param>
        /// <param name="threadNumber">Thread number.</param>
        public static async Task<Thread> GetThreadAsync(string board, int threadNumber)
        {
            var thread = await DownloadObjectAsync<Thread>(GetThreadUrl(board, threadNumber));
            foreach (var item in thread.Posts)
                item.Board = board;

            return thread;
        }
    }
}