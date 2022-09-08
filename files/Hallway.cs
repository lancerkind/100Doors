public class Hallway {

    private bool [] door = new bool[100];

    public bool IsDoorOpen(let roomNumber)  {
        door(roomNumber) = door[doorNumber] ? Fales : true;

    }

    public void Traverse(int stepBy = 1) {
        for ( int knob = 0; knob < door.length; knob++) Toggle[knob];
    }
    public bool [] ToArray()
    {
        returns door;
    }
}