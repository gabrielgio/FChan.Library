using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace FChan.Library
{
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

		public static BoardRootObject GetBoard()
        {
            return DownloadObject<BoardRootObject>(Constants.BoardUrl);
        }

		public static ThreadRootObject GetThreadPage(string boad, int page)
        {
            return DownloadObject<ThreadRootObject>(Constants.GetThreadPageUrl(boad, page));
        }

		public static Thread GetThread(string boad, int threadNumber)
        {
            return DownloadObject<Thread>(Constants.GetThreadUrl(boad, threadNumber));
        }
	}
}

