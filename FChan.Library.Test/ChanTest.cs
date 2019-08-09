using System.Linq;
using Xunit;
using static FChan.Library.Chan;
using static Xunit.Assert;

namespace FChan.Library.Test
{
    public class ChanTest
    {
        [Fact]
        public void GetAllThread()
        {
            var thread = Chan.GetThreadPage("a", 1);

            NotNull(thread);

            foreach (var item in thread.Threads)
            {
                NotNull(item);

                foreach (var post in item.Posts)
                {
                    NotNull(post);
                    NotEqual(0, post.PostNumber);
                }
            }
        }

        [Fact]
        public async void GetAllThreadAsync()
        {
            var thread = await Chan.GetThreadPageAsync("a", 1);

            NotNull(thread);

            foreach (var item in thread.Threads)
            {
                NotNull(item);

                foreach (var post in item.Posts)
                {
                    NotNull(post);
                    NotEqual(default(int), post.PostNumber);
                }
            }
        }

        [Fact]
        public void GetBoard()
        {
            var board = Chan.GetBoard();
            NotNull(board);
        }

        [Fact]
        public async void GetBoardAsync()
        {
            var board = await Chan.GetBoardAsync();
            NotNull(board);
        }

        [Fact]
        public void GetThreadPage()
        {
            var thread = Chan.GetThreadPage("a", 1);
            NotNull(thread);
        }

        [Fact]
        public async void GetThreadPageAsync()
        {
            var thread = await Chan.GetThreadPageAsync("a", 1);
            NotNull(thread);
        }

        [Fact]
        public async void GetThread()
        {
            var threadPage = await Chan.GetThreadPageAsync("a", 1);
            var threadNumber = threadPage.Threads.First().Posts.First().PostNumber;


            var thread = await Chan.GetThreadAsync("a", threadNumber);

            NotNull(thread);
        }
        
        [Fact]
        public void GetThreadAsync()
        {
            var threadPage = Chan.GetThreadPage("a", 1);
            var threadNumber = threadPage.Threads.First().Posts.First().PostNumber;


            var thread = Chan.GetThread("a", threadNumber);

            NotNull(thread);
        }
    }
}