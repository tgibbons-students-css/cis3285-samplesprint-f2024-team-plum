namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
            // Changes Sprint 1 --As a message reading user, I want to view a list of rooms that represent conversations -- Omar Sami
        }

        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
        }

        public string AuthorName
        {
            get;
            private set;
            // Changes Sprint 1 --As a message reading user, I want to view a list of rooms that represent conversations -- Omar Sami
        }
    }
}
