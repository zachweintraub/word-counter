using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void RepeatCounter_CallConstructor_NewInstanceOfRepeatCounter()
    {
      RepeatCounter myCounter = new RepeatCounter("mom", "hi mom", false);
      Assert.AreEqual(typeof(RepeatCounter), myCounter.GetType());
    }

    [TestMethod]
    public void GetPhrase_CallConstructor_GetPhraseReturnsPhrase()
    {
      RepeatCounter myCounter = new RepeatCounter("mom", "hi mom", false);
      Assert.AreEqual("hi mom", myCounter.GetPhrase());
    }

  }
}
