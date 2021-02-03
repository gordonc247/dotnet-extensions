using System;
using NUnit.Framework;

namespace DotNet.Extensions.Tests
{
    [TestFixture]
    public class ObjectTests
    {
        [Test]
        public void SetPropertyValueTest()
        {
            var birthDate = new DateTime(1970, 1, 1);
            var person = new Person { Name = "John" };
            person.SetPropertyValue("birthdate", new DateTime(1970, 1, 1));
            person.SetPropertyValue("ISEMPLOYED", true);
            person.SetPropertyValue("Age", 40);

            Assert.AreEqual(birthDate, person.BirthDate, $"SetPropertyValue (birthdate) failed");
            Assert.AreEqual(true, person.IsEmployed, $"SetPropertyValue (ISEMPLOYED) failed");
            Assert.AreEqual(40, person.Age, $"SetPropertyValue (Age) failed");
        }

        [Test]
        public void GetPropertyValueTest()
        {
            var birthDate = new DateTime(1970, 1, 1);
            var person = new Person {
                Name = "John",
                IsEmployed = true,
                BirthDate = birthDate,
                Age = 40
            };
            Assert.AreEqual(birthDate, person.GetPropertyValue("birthdate"), $"GetPropertyValue (birthdate) failed");
            Assert.AreEqual(true, person.GetPropertyValue("ISEMPLOYED"), $"GetPropertyValue (ISEMPLOYED) failed");
            Assert.AreEqual(40, person.GetPropertyValue("Age"), $"GetPropertyValue (Age) failed");
        }

        [Test]
        public void ChangeTypeToGuidTest()
        {
            var result = "79bb57bc-4702-40f5-ad24-a4f7036427f9".ChangeType(typeof(Guid));
            var expected = new Guid("79bb57bc-4702-40f5-ad24-a4f7036427f9");

            Assert.AreEqual(expected, result, $"Failed to convert string to Guid");
        }

        [Test]
        public void ChangeTypeToNullableInt32Test()
        {
            var result = "123".ChangeType(typeof(int?));
            var expected = 123;

            Assert.AreEqual(expected, result, $"Failed to convert string to nullable Int32");
        }

        [Test]
        public void ChangeTypeToDateTimeTest()
        {
            var result = "2020/02/03".ChangeType(typeof(DateTime));
            var expected = new DateTime(2020, 2, 3);

            Assert.AreEqual(expected, result, $"Failed to convert string to DateTime");
        }
    }
}
