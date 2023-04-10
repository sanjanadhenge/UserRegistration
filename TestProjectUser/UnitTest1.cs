using UserMethod;

namespace TestProjectUser
{
    public class Tests
    {

        [Test]
        public void GivenFirstName_WhenAnalyze_ShouldReturnValid()
        {
            string name = "Sanjana";
             UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidateFirstName(name);
            Assert.AreEqual(result, "valid");
        }
        [Test]
        public void GivenFirstName_WhenAnalyze_ShouldReturnInValid()
        {
            string name = "sanjana";
            UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidateFirstName(name);
            Assert.AreEqual(result, "Invalid");
        }
        [Test]
        public void GivenLastName_WhenAnalyze_ShouldReturnValid()
        {
            string name = "Dhenge";
            UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidateLastName(name);
            Assert.AreEqual(result, "valid");
        }
        [Test]
        public void GivenLastName_WhenAnalyze_ShouldReturnInValid()
        {
            string name = "dhenge";
            UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidateLastName(name);
            Assert.AreEqual(result, "Invalid");
        }
        [Test]
        public void GivenMail_WhenAnalyze_ShouldReturnValid()
        {
            string mail = "abc.xyz@brizdgelabz.co.in";
            UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidateMailID(mail);
            Assert.AreEqual(result, "valid");
        }
        [Test]
        public void GivenMail_WhenAnalyze_ShouldReturnInValid()
        {
            string mail = "abcxyzbrizdgelabz.co.in";
            UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidateMailID(mail);
            Assert.AreEqual(result, "Invalid");
        }

        [Test]
        public void GivenMobileNumber_WhenAnalyze_ShouldReturnValid()
        {
            string mobile = "9135624879";
            UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidateMobile(mobile);
            Assert.AreEqual(result, "valid");
        }
        [Test]
        public void GivenMobileNumber_WhenAnalyze_ShouldReturnInValid()
        {
            string mobile = "35624879";
            UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidateMobile(mobile);
            Assert.AreEqual(result, "Invalid");
        }
        [Test]
        public void GivenPassword_WhenAnalyze_ShouldReturnValid()
        {
            string pass = "Abcdef@2023";
            UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidatePass(pass);
            Assert.AreEqual(result, "valid");
        }
        [Test]
        public void GivenPassword_WhenAnalyze_ShouldReturnInValid()
        {
            string pass = "Abcdef";
            UserFunctions userFunctions = new UserFunctions();
            string result = userFunctions.ValidatePass(pass);
            Assert.AreEqual(result, "Invalid");
        }
    }
}