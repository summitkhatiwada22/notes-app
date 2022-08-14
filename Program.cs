using System;

namespace NotesApplication{
    class NotesProgram{
        static void Main(string[] args){

            // Creating a list of notes to add individual notes
            List<Note> allNotes = new List<Note>();

            // Date for note - TODO : Fix date issue
            DateTime noteDate = DateTime.Now;
            Console.WriteLine(noteDate);

            // Initializing choice for option menu
            int selection = 0;
            // ID for note
            int noteId = 1;

            while (selection <= 4){
            
                // Displaying options menu
                Menu.menu();

                // Asking user for choice
                Console.Write("Selection :: ");
                selection = Convert.ToInt32(Console.ReadLine());

                //  ADDING NEW NOTE
                if (selection == 1){
                    // Taking user input for new note
                    Console.WriteLine("");
                    Console.Write("Topic :: ");
                    string noteTopic = Console.ReadLine();
                    Console.Write("Content :: ");
                    string noteContent = Console.ReadLine();

                    allNotes.Add(new Note (noteId, noteDate, noteTopic, noteContent));

                    // Incrementing input id for unique record
                    noteId++;
                }

                // VIEW ALL NOTES
                if (selection == 2){
                    for (int i=0; i < allNotes.Count; i++){
                        Console.WriteLine("");
                        Console.WriteLine(allNotes[i].id);
                        Console.WriteLine(allNotes[i].date);
                        Console.WriteLine(allNotes[i].topic);
                        Console.WriteLine(allNotes[i].content);
                    }
                }

                // EDIT NOTES
                if (selection == 3){
                    // Displaying the date, note id and topic only for selestion
                    for (int i=0; i < allNotes.Count; i++){
                        Console.WriteLine("");
                        Console.WriteLine(allNotes[i].date + " " + allNotes[i].id + " " + allNotes[i].topic);
                    }
                    Console.WriteLine("");
                    Console.Write("Note ID you would like to EDIT :: ");
                    
                    // Taking user input for the note they want to edit
                    int editSelection = Convert.ToInt32(Console.ReadLine());

                    // Editing the topic of selected note
                    Console.WriteLine("");
                    Console.Write("Topic :: ");
                    string noteTopic = Console.ReadLine();
                    Console.Write("Content :: ");
                    string noteContent = Console.ReadLine();

                    // Inserting the edited note
                    allNotes[editSelection - 1].topic = noteTopic;
                    allNotes[editSelection - 1].content = noteContent;
                }

                // DELETE NOTE
                if (selection == 4){
                    // Displaying the date, note id and topic only for selestion
                    for (int i=0; i < allNotes.Count; i++){
                        Console.WriteLine("");
                        Console.WriteLine(allNotes[i].date + " " + allNotes[i].id + " " + allNotes[i].topic);
                    }
                    Console.WriteLine("");
                    Console.Write("Note ID you would like to DELETE :: ");
                    
                    // Taking user input for the note they want to edit
                    int deleteSelection = Convert.ToInt32(Console.ReadLine());

                    // Removing the note
                    allNotes.Remove(allNotes[deleteSelection - 1]);

                }



            }            

        }

    }
}