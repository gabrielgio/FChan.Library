using NUnit.Framework;
using System;

namespace FChan.Library.Test
{
    [TestFixture()]
    public class ChanTest
    {
        [Test()]
        public void GetBoardTest()
        {
            try
            {
                BoardRootObject board = Chan.GetBoard();
                Assert.AreEqual(board, null);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test()]
        public async void GetBoardAyncTest()
        {
            try
            {
                BoardRootObject board = await Chan.GetBoardAsync();
                Assert.AreNotEqual(board, null);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test()]
        public void GetThreadPageTest()
        {
            try
            {
                ThreadRootObject thread = Chan.GetThreadPage("a",1);
                Assert.AreNotEqual(thread, null);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test()]
        public async void GetThreadPageAsyncTest()
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
        public async void GetAllThread()
        {
            try
            {
                ThreadRootObject thread = await Chan.GetThreadPageAsync("a",1);

                foreach (var item in thread.Threads) 
                {
                    Assert.AreNotEqual(item, null);

                    foreach (var post in item.Posts) 
                    {
                        Assert.AreNotEqual(post, null);
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
