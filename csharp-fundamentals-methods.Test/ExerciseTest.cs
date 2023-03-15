using csharp_fundamentals_methods.Main;
using NUnit.Framework;

namespace csharp_fundamentals_methods.Test
{
    public class ExerciseTest
    {
        Exercise exercise;

        public ExerciseTest()
        {
            this.exercise = new Exercise();
        }

        [Test]
    public void shouldGreetName()
        {
            Assert.AreEqual("Hello Nathan!", this.exercise.greet("Nathan"));
        }

        [Test]
        public void shouldIncrementNumber()
        {
            Assert.AreEqual(1, this.exercise.increment(0));
            Assert.AreEqual(6, this.exercise.increment(5));
        }

        [Test]
        public void shouldFriendlyGreet()
        {
            Assert.AreEqual("Hi, Nathan :)", this.exercise.happilyGreet("Nathan"));
            Assert.AreEqual("Hi, Edward :)", this.exercise.happilyGreet("Edward"));
            Assert.AreEqual("Hi, Lewis :)", this.exercise.happilyGreet("Lewis"));
        }

        [Test]
        public void shouldConstructNumberArray()
        {
            int[] nums = this.exercise.constructNumberArray(10, 13);
            Assert.AreEqual(4, nums.Length);
            Assert.AreEqual(10, nums[0]);
            Assert.AreEqual(11, nums[1]);
            Assert.AreEqual(12, nums[2]);
            Assert.AreEqual(13, nums[3]);
        }

        [Test]
        public void shouldShout()
        {
            Assert.AreEqual("DISASTER!!!!!", this.exercise.shout("disaster", 5));
            Assert.AreEqual("ERROR!!!!!!!!!!", this.exercise.shout("error", 10));
        }

        [Test]
        public void bakingTime()
        {
            Assert.AreEqual(50, this.exercise.bakingTime());
        }

        [Test]
        public void remainingBakeTime()
        {
            Assert.AreEqual(30, this.exercise.remainingBakeTime(20));
            Assert.AreEqual(40, this.exercise.remainingBakeTime(10));
            Assert.AreEqual(0, this.exercise.remainingBakeTime(50));
        }

        [Test]
        public void calculatePrepTime()
        {
            Assert.AreEqual(6, this.exercise.calculatePrepTime(2));
            Assert.AreEqual(9, this.exercise.calculatePrepTime(3));
            Assert.AreEqual(3, this.exercise.calculatePrepTime(1));
        }

        [Test]
        public void totalTimeSpent()
        {
            Assert.AreEqual(26, this.exercise.totalTimeSpent(2, 20));
            Assert.AreEqual(49, this.exercise.totalTimeSpent(3, 40));
            Assert.AreEqual(15, this.exercise.totalTimeSpent(0, 15));
            Assert.AreEqual(0, this.exercise.totalTimeSpent(0, 0));
        }
    }
}