namespace UnitTests;

public class Tests
{
    Pin pin;
    [Setup]
    public void Setup ()
    {
        pin = new Pin();
        bool result = true;
    }
    
    [Test]
    public void TestExpend()
    {
    // Assert.AreEqual(4, Util.Add(1,2));
    Assert.That(pin.Expend(int 350), Is.True);
    Assert.Pass();
    }
}
