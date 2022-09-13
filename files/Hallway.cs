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
        
        /* (knob < door.Length) && (knob + stepBy <= door.Length)*/
        for ( int knob = 0 + stepBy - 1; (knob < door.Length) && (knob + stepBy <= door.Length); knob+=stepBy) {
     //       Console.WriteLine("knob " + knob);
            Toggle(knob);
        }
    }
    
    private bool limit(int knob, int stepBy){
        return knob < ((door.Length / stepBy) * stepBy);
    }
    
    public bool [] ToArray()
    {
        return door;
    }
}