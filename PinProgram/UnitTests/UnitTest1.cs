public class UnitTest1
{
    Pin pin;
    [SetUp]
    public void Setup ()
    {
        pin = new Pin();
        bool result = true;
    }
    
    [Test]
    public void TestExpend1()
    {
    // Assert.AreEqual(4, Util.Add(1,2));
    Assert.That(pin.Expend(351), Is.True);
    Assert.Pass();
    }

    [Test]
    public void TestExpend2()
    {
    // Assert.AreEqual(4, Util.Add(1,2));
    Assert.That(pin.Expend(350), Is.False);
    Assert.Pass();
    }
    
    [Test]
    public void TestExpend3()
    {
    // Assert.AreEqual(4, Util.Add(1,2));
    Assert.That(pin.Expend(350), Is.False);
    Assert.Pass();
    }

    [Test]
    public void TestExpend4()
    {
    // Assert.AreEqual(4, Util.Add(1,2));
    Assert.That(pin.Expend(350), Is.False);
    Assert.Pass();
    }
    
    [Test]
    public void TestExpend5()
    {
    // Assert.AreEqual(4, Util.Add(1,2));
    Assert.That(pin.Expend(350), Is.False);
    Assert.That(pin.Expend(350), Is.False);
    Assert.That(pin.Expend(350), Is.False);
    Assert.That(pin.Expend(350), Is.True);
    Assert.That(pin.Expend(350), Is.False);
    Assert.Pass();
    }
}
