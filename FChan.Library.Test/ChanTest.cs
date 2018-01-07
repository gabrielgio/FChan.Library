using Xunit;

namespace FChan.Library.Test
{
    public class ChanTest
    {
        [Fact]
        public void GetAllThread()
        {
            var thread = Chan.GetThreadPage("a", 1);

            Assert.NotNull(thread);

            foreach (var item in thread.Threads)
            {
                Assert.NotNull(item);

                foreach (var post in item.Posts)
                {
                    Assert.NotNull(post);
                    Assert.NotEqual(post.PostNumber, 0);
                }
            }
        }

        [Fact]
        public async void GetAllThreadAsync()
        {
            var thread = await Chan.GetThreadPageAsync("a", 1);

            Assert.NotNull(thread);

            foreach (var item in thread.Threads)
            {
                Assert.NotNull(item);

                foreach (var post in item.Posts)
                {
                    Assert.NotNull(post);
                    Assert.NotEqual(post.PostNumber, default(int));
                }
            }
        }

        [Fact]
        public void GetBoard()
        {
            var board = Chan.GetBoard();
            Assert.NotNull(board);
        }

        [Fact]
        public async void GetBoardAync()
        {
            var board = await Chan.GetBoardAsync();
            Assert.NotNull(board);
        }

        [Fact]
        public void GetThreadPage()
        {
            var thread = Chan.GetThreadPage("a", 1);
            Assert.NotNull(thread);
        }

        [Fact]
        public async void GetThreadPageAsync()
        {
            var thread = await Chan.GetThreadPageAsync("a", 1);
            Assert.NotEqual(thread, null);
        }
    }
}