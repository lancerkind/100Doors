using System;

public class Hallway {

    private bool [] door = new bool[100];

    public bool IsDoorOpen(int roomNumber)  {
        return door[roomNumber];
    }

    public void Toggle(int roomNumber) {
        door[roomNumber] = door[roomNumber] ? false : true;
    }
        
    public void Traverse(int stepBy = 1) {
        

        for ( int knob = 0 + stepBy - 1; limit(knob, stepBy); knob+=stepBy) {
     //       Console.WriteLine("knob " + knob);
            Toggle(knob);
        }
    }
    
    private bool limit(int knob, int stepBy){
        return knob < ((door.Length / stepBy) * stepBy);
    }
    
    private bool limit2DontWork(int knob, int stepBy) {
        return (knob < door.Length) && (knob + stepBy <= door.Length);
    }
    
    public bool [] ToArray()
    {
        return door;
    }
}