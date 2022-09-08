


























[Test]
public void ToggleDoorOne()
{
    hallway.toggle();
    Assert.AreEqual(true, hallway.IsDoorOpen1));    
}

[Test]
public void DoorNumbmer2Status()
{
    hallway.Toggle(1);
    Assert.AreEqual(true, hallway.IsDoorOpen(1));
    Assert.AreEqual(false, hallway.IsDoorOpen(0));
}

[Test]
public void ToggleTwice()
{
    hallway.Toggle(0);
    hallway.Toggle(0);
    Assert.AreEqual(false, hallway.IsDoorOpen(0));
}
[Test]
public void ToArray()
{
    CollectionAssert.AreEqual(Enumerable.Repeat(false, 100).ToArray(), hallway.ToArray());
}


    