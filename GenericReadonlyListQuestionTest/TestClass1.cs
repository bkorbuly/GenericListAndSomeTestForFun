using GenericReadonlyListQuestion;
using Newtonsoft.Json;
using System;
using Xunit;

namespace GenericReadonlyListQuestionTest
{
    public class TestClass1
    {
        readonly Person person = new Person { Firstname = "Miksa" };

        [Fact]
        public void TestWhenOnlyGetAndNothingAdded()
        {
            GenericList<object> objectList = new GenericList<object>();
            Assert.Throws<ArgumentOutOfRangeException>(() => objectList.Get(0));
            objectList = null;
        }

        [Fact]
        public void TestWhenSomethingAddedAndGetCalled()
        {
            Person testperson = new Person() { Firstname = "Miksa" };

            GenericList<object> objectList = new GenericList<object>();
            objectList.Add(person);

            Assert.Equal(JsonConvert.SerializeObject(testperson), JsonConvert.SerializeObject(objectList.Get(0)));
            objectList = null;
        }
    }
}
