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
        for ( int knob = 0 + stepBy - 1; (knob < door.Length) && (knob + stepBy <= door.Length); knob+=stepBy) {
            Toggle(knob);
        }
    }
    
    public bool [] ToArray()
    {
        return door;
    }
}