using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class QueueTests
    {
        [Test]
        public void Dequeue_EmptyEqueue_ThrowsQuequeIsEmptyException()
        {
            Queue<int> queue=new Queue<int>();
            Assert.Catch<QueueIsEmptyException>(() => queue.Dequeue());
        }
    }
}
