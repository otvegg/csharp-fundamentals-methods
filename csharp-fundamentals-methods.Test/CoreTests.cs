using csharp_fundamentals_methods.Main;
using NUnit.Framework;

namespace csharp_fundamentals_methods.Test
{
    public class CoreTests
    {      

        [Test, Order(1)]
        public void shouldGreetName()
        {
            Core exercise = new Core();
            Assert.AreEqual("Hello Nathan!", exercise.greet("Nathan"));
        }

        [Test, Order(2)]
        public void shouldIncrementNumber()
        {
            Core exercise = new Core();
            Assert.AreEqual(1, exercise.increment(0));
            Assert.AreEqual(6, exercise.increment(5));
        }

        [Test, Order(3)]
        public void shouldFriendlyGreet()
        {
            Core exercise = new Core();
            Assert.AreEqual("Hi, Nathan :)", exercise.happilyGreet("Nathan"));
            Assert.AreEqual("Hi, Edward :)", exercise.happilyGreet("Edward"));
            Assert.AreEqual("Hi, Lewis :)",  exercise.happilyGreet("Lewis"));
        }

        [Test, Order(4)]
        public void shouldConstructNumberArray()
        {
            Core exercise = new Core();
            int[] nums = exercise.constructNumberArray(10, 13);
            Assert.AreEqual(4, nums.Length);
            Assert.AreEqual(10, nums[0]);
            Assert.AreEqual(11, nums[1]);
            Assert.AreEqual(12, nums[2]);
            Assert.AreEqual(13, nums[3]);
        }

        [Test, Order(5)]
        public void shouldShout()
        {
            Core exercise = new Core();
            Assert.AreEqual("DISASTER!!!!!", exercise.shout("disaster", 5));
            Assert.AreEqual("ERROR!!!!!!!!!!", exercise.shout("error", 10));
        }

        
    }
}