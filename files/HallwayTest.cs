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
    public void TraveseOpensEvery3rdDoor()
    {
        hallway.Traverse(3);
        
        for(int i= 0; i < 99; i+=3) {
            Assert.False(hallway.ToArray()[i], "\n i=" + i);
            Assert.False(hallway.ToArray()[i+1], "\n i=" + (i+1));
            Assert.True(hallway.ToArray()[i+2], "\n i=" + (i+2));
        }
    }
    
    [Test]
    public void Traverse_ToggleEveryDoorThenToggleEveryOtherDoor(){
        hallway.Traverse(1);
        hallway.Traverse(2);
        //   1234
        //   FFFF
        // 1 TTTT
        // 2 TFTF
        
        for(int i= 0; i < 99; i+=2) {
            Assert.True(hallway.ToArray()[i], "\n i=" + i);
            Assert.False(hallway.ToArray()[i+1], "\n i=" + (i+1));
        }
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
    public void learnIntegerDivision() {
        int length = 100; int stepBy =3;
        
        int product = (length / stepBy) * stepBy;
        
        Assert.AreEqual(99, product);
    }
  
    [Test]
    public void HunderedthDoorIsToggled(){
        hallway.Traverse(100);
        Assert.False(hallway.ToArray()[98]);
        Assert.True(hallway.ToArray()[99]);
    }
    
    [Test]
    public void Traverse33(){
        hallway.Traverse(33);
        Assert.True(hallway.ToArray()[33 - 1]);
        Assert.True(hallway.ToArray()[66 - 1]);
        Assert.False(hallway.ToArray()[97]);
        Assert.True(hallway.ToArray()[98]);
        Assert.False(hallway.ToArray()[99]);
    }


    
    [Test]
    public void learnWhatToggling100DoorsLooksLike(){
        for(int stepBy = 1; stepBy <= hallway.ToArray().Length; stepBy++) hallway.Traverse(stepBy);
        PrintArray(hallway.ToArray());            
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