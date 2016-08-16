using System.Collections.Generic;
using NFluent;
using NUnit.Framework;

namespace MutationTesting.Tests
{
    [TestFixture]
    public class SequenceShouldCase3
    {
        [Test]
        public void ReturnFalseWhenHaveSingleItemForEmptySequence()
        {
            var sequence = new Sequence(new List<object>());

            Check.That(sequence.HaveSingleItem()).IsFalse();
        }

        [Test]
        public void ReturnTrueWhenHaveSingleItemForSequenceWithSingleItem()
        {
            var sequence = new Sequence(new List<object> { new object() });

            Check.That(sequence.HaveSingleItem()).IsTrue();
        }

        [Test]
        public void ReturnFalseWhenHaveSingleItemForSequenceWithTwoItems()
        {
            var sequence = new Sequence(new List<object>
            {
                new object(), new object()
            });

            Check.That(sequence.HaveSingleItem()).IsFalse();
        }

        [Test]
        public void ReturnFalseWhenHaveSingleItemForSequenceWithMoreThanTwoItems()
        {
            var sequence = new Sequence(new List<object>
            {
                new object(), new object(), new object()
            });

            Check.That(sequence.HaveSingleItem()).IsFalse();
        } 
    }
}