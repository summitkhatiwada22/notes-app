using System;

namespace NotesApplication{
    class NotesProgram{
        static void Main(string[] args){

            // Creating a list of notes to add individual notes
            List<Note> allNotes = new List<Note>();

            // Date for note
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

            }            

        }

    }
}