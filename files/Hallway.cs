public class Hallway {

    private bool [] door = new bool[100];

    public bool IsDoorOpen(int roomNumber)  {
        return door[roomNumber];
    }

    public void Toggle(int roomNumber) {
        door[roomNumber] = door[roomNumber] ? false : true;
    }
        
    public void Traverse(int stepBy = 1) {
        
        for ( int knob = 0; knob < door.Length; knob = knob + stepBy) { 
            
            Toggle(knob);
        }
    }
    
    public bool [] ToArray()
    {
        return door;
    }
}