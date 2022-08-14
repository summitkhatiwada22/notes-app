namespace NotesApplication{
    public class Note{
        
        // Primary ID of the note
        public int id {set; get;}
        // Date and time the note was last modified 
        public DateTime date {set; get;}
        // Topic of the note
        public string topic {set; get;}
        // Content of the note under the topic
        public string content {set; get;}

        // Constructor of the note
        public Note(int noteId, DateTime noteDate, string noteTopic, string noteContent){
            id = noteId;
            date = noteDate;
            topic = noteTopic;
            content = noteContent;
        }
    }
}