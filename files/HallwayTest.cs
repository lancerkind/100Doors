using NUnit.Framework;
using System.Collections;
using System.Linq;
using System;

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
        Assert.AreEqual(false, hallway.IsDoorOpen(0));
    }
            
    [Test]
    public void Traverse()
    {
        hallway.Traverse();
        CollectionAssert.AreEqual(BuildHallwayOfDoors(true), hallway.ToArray());
    }


    [Test]
    public void TraverseTwice() 
    {
        hallway.Traverse();
        hallway.Traverse();

        CollectionAssert.AreEqual(BuildHallwayOfDoors(false), hallway.ToArray() );
    }
    
    [Test]
    public void TraverseOpensEveryOtherDoor() 
    {
        hallway.Traverse(2);

        Assert.False(hallway.ToArray()[0], "hallway.ToArray()[0]");
        Assert.True(hallway.ToArray()[1]);
        Assert.False(hallway.ToArray()[2]);
        Assert.True(hallway.ToArray()[3]);
        //... and so on
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

    private bool[] BuildHallwayOfDoors(bool doorAjar = true) {
        return Enumerable.Repeat(doorAjar, 100).ToArray();
    }

    private void PrintArray(bool [] door) {
        for (int doorNumber = 0; doorNumber < 100; doorNumber ++) {
            Console.WriteLine(String.Join(",", door[doorNumber]));
        }
    }
}