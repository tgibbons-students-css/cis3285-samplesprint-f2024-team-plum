namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        public RoomRecord(string name, int roomId)
        {
            Name = name;
            RoomId1 = roomId;
            // Changes Sprint 1 --As a message posting user, I want to create rooms for categorizing conversations -- Omar Sami
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            get;
            private set;
        }
        // Changes Sprint 1 -- Add userLimit property to specify the maximum number of users allowed in the room -- Omar Sami

    }
}
