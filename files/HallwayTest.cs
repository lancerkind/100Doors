














[Test]
Public void TraverseTwice() 
{
    hallway.Traverse();
    hallway.Traverse();

    Collection.AreEqual(BuildHallwayOfOpenDoors(false), hallway.ToArray() );
}
[Test]
Public void TraverseWithCountOf2() 
{
    hallway.Traverse(2);

    Collection.AreEqual(BuildHallwayOfOpenDoors(false), hallway.ToArray() );
}

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

[Test]
Public void Traverse() 
{
    hallway.Traverse();

    Collection.AreEqual(BuildHallwayOfOpenDoors(), hallway.ToArray());
}

[Test]
Public void TraverseTwice() 
{
    hallway.Traverse();
    hallway.Traverse();

    Collection.AreEqual(BuildHallwayOfOpenDoors(false), hallway.ToArray() );
}

private bool[] BulidHallwayOfOpenDoors(bool open =true) {
    return Enumerable.Repeat(true, 100).ToArray();
}
}