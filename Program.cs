using System;

namespace NotesApplication{
    class NotesProgram{
        static void Main(string[] args){

            // Initializing choice for option menu
            int choice = 0;

            // ID for note
            int inputId = 1;
            // Date for note
            DateTime localDateTime = DateTime.Now;
            Console.WriteLine(localDateTime);

            // Declaring variables for user input       
            string inputTopic;
            string inputContent;

            // Creating a newNote object
            Note newNote = new Note(0, localDateTime, null, null);

            // Creating a list of notes to add individual notes
            List<Note> allNotes = new List<Note>();

            while (choice <= 4){
            
            // Displaying options menu
            Menu.menu();

            // Asking user for choice
            Console.Write("Selection :: ");
            choice = Convert.ToInt32(Console.ReadLine());

                //  ADDING NEW NOTE
                if (choice == 1){
                // Taking user input for new note
                Console.WriteLine("");
                Console.Write("Topic :: ");
                inputTopic = Console.ReadLine();
                Console.Write("Content :: ");
                inputContent = Console.ReadLine();
                
                // Adding data to newNote object
                newNote.id = inputId;
                newNote.date = localDateTime;
                newNote.topic = inputTopic;
                newNote.content = inputContent;

                // Adding userinput data to the list
                allNotes.Add(newNote);

                // Incrementing input id for unique record
                inputId++;

                }

            }            
            
            foreach (Note allNote in allNotes){
                Console.WriteLine("");
                Console.WriteLine(allNote.id);
                Console.WriteLine(allNote.date);
                Console.WriteLine(allNote.topic);
                Console.WriteLine(allNote.content);
                Console.WriteLine("");

            }

            Console.WriteLine(allNotes.Count);

        }

    }
}