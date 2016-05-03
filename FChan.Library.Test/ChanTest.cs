using NUnit.Framework;
using System;

namespace FChan.Library.Test
{
    [TestFixture()]
    public class ChanTest
    {
        [Test()]
        public void GetBoard()
        {
            try
            {
                BoardRootObject board = Chan.GetBoard();
                Assert.NotNull(board);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test()]
        public async void GetBoardAync()
        {
            try
            {
                BoardRootObject board = await Chan.GetBoardAsync();
                Assert.NotNull(board);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test()]
        public void GetThreadPage()
        {
            try
            {
                ThreadRootObject thread = Chan.GetThreadPage("a",1);
                Assert.NotNull(thread);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test()]
        public async void GetThreadPageAsync()
        {
            try
            {
                ThreadRootObject thread = await Chan.GetThreadPageAsync("a",1);
                Assert.AreNotEqual(thread, null);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test()]
        public async void GetAllThreadAsync()
        {
            try
            {
                ThreadRootObject thread = await Chan.GetThreadPageAsync("a",1);

                Assert.NotNull(thread);

                foreach (var item in thread.Threads) 
                {
                    Assert.NotNull(item);

                    foreach (var post in item.Posts) 
                    {
                        Assert.NotNull(post);
                        Assert.AreNotEqual(post.PostNumber, default(int));
                    }
                }
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }


        [Test()]
        public void GetAllThread()
        {
            try
            {
                ThreadRootObject thread = Chan.GetThreadPage("a",1);

                Assert.NotNull(thread);

                foreach (var item in thread.Threads) 
                {
                    Assert.NotNull(item);

                    foreach (var post in item.Posts) 
                    {
                        Assert.NotNull(post);
                        Assert.AreNotEqual(post.PostNumber, 0);
                    }
                }
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
