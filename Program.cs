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

                allNotes.Add(new Note (inputId, localDateTime, inputTopic, inputContent));

                // Incrementing input id for unique record
                inputId++;
                }

            }            

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