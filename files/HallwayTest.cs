using NUnit.Framework;
using System.Collections;
using System.Linq;

[TestFixture]
public class HallwayTest
{
    Hallway hallway;

    [SetUp]
    public void SetUp(){
        hallway = new Hallway();
    }
    
    [Test]
    public void DoorStatus()
    {
        Assert.AreEqual(false, hallway.IsDoorOpen(0));
    }

    [Test]
    public void ToggleToggleDoorZero()
    {
        hallway.Toggle(0);
        Assert.AreEqual(true, hallway.IsDoorOpen(0));
    }
    
    [Test]
    public void ToggleDoorOne()
    {
        hallway.Toggle(1);
        Assert.AreEqual(true, hallway.IsDoorOpen(1));
    }
    
    [Test]
    public void DoorNumber2Status()
    {
        hallway.Toggle(1);
        Assert.AreEqual(true, hallway.IsDoorOpen(1));
        Assert.AreEqual(false, hallway.IsDoorOpen(1));
    }
            
    [Test]
    public void Traverse()
    {
        hallway.traverse();
        CollectionAssert.AreEqual(BuildHallwayOfOpenDoors(true), hallway.ToArray());
    }


    [Test]
    public void TraverseTwice() 
    {
        hallway.Traverse();
        hallway.Traverse();

        Collection.AreEqual(BuildHallwayOfOpenDoors(false), hallway.ToArray() );
    }
    [Test]
    public void TraverseWithCountOf2() 
    {
        hallway.Traverse(2);

        Collection.AreEqual(BuildHallwayOfOpenDoors(false), hallway.ToArray() );
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
    public void Traverse() 
    {
        hallway.Traverse();

        Collection.AreEqual(BuildHallwayOfOpenDoors(), hallway.ToArray());
    }

    [Test]
    public void TraverseTwice() 
    {
        hallway.Traverse();
        hallway.Traverse();

        Collection.AreEqual(BuildHallwayOfOpenDoors(false), hallway.ToArray() );
    }

    private bool[] BulidHallwayOfOpenDoors(bool open =true) {
        return Enumerable.Repeat(true, 100).ToArray();
    }
}