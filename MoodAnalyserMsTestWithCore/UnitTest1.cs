using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using MoodAnalyserMsTestWithCore;

namespace MoodAnalyserMsTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD() 
        {
            string expected = "SAD";
            string message = "I am In Sad Mood";
            AMoodAnalyser moodAnalyser = new AMoodAnalyser(message);
            var mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
            
        }
        [TestMethod]
        [DataRow(null)]

        public void GivenHappyMoodShouldReturnHappy(string message) 
        {
            string expected = "Happy";

            AMoodAnalyser moodAnalyser = new AMoodAnalyser(message);
            var mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);

        }
        
    }
}