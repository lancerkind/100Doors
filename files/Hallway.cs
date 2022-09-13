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
        ///         0     + 1 - 1;                                                                0 += 1 == 1
        ///                                                                                       1 += 1 == 2
        ///        when we get to 99   + 1 == 100
        ///                       99 + 1 <= 100
        //                                      
        //  90 + 3 = 93
        //  93 + 3 = 96
        //  96 + 3 = 99  (96 + 3 <= 100)
        //     33 * 3 = 99
        
        //   50 * 2 = 100 
        //  (door.Length / stepBy ) * stepBy < 100
        /* (knob < door.Length) && (knob + stepBy <= door.Length)*/
        for ( int knob = 0 + stepBy - 1; knob < ((door.Length / stepBy) * stepBy); knob+=stepBy) {
            Console.Writeline("knob " + knob);
            Toggle(knob);
        }
    }
    
    public bool [] ToArray()
    {
        return door;
    }
}