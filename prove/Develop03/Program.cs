// ***********************************************
// Rosy Bertacchini
// Unit 06 Develop: Scripture Program
// Abstraction and Encapsulation
// ***********************************************

using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

class Program {
 static void Main(string[] args)
    {
        // Initialized and create class instances
        Reference reference = new Reference();
        Scripture scripture = new Scripture();
        List<Word> scripture_wordByword = new List<Word>();




        string rndReference = "";
        string rndScriture = "";

        getRandomScriture();
        scripture_wordByword = PassTheRandomScriptureToWordByWord(rndScriture);

        String userInput = "";
        Console.Clear();
        
        Console.Write(rndReference+" ");
        foreach(Word w  in scripture_wordByword) {
                if (w.GetWordVisibility()) {
                    Console.Write(w.GetWord()+" ");
                }

        }


        
        while (userInput != "Quit") {

            DisplayMenu();
            userInput = Console.ReadLine();
           
            switch(userInput) 
            {
                case "": // Enter
                   Console.Clear();
                   Console.Write(rndReference+" ");
                   HideTheRandomScriptureToWordByWord(scripture_wordByword);
                   foreach(Word w  in scripture_wordByword) {
                        if (w.GetWordVisibility()) {
                            Console.Write(w.GetWord()+" ");
                        } 
                        else
                        {
                            foreach (char c in w.GetWord())
                            {
                                if ( c.Equals(",") || c.Equals("_") ) {
                                     Console.Write(c);
                                }
                                else
                                {
                                    Console.Write("_" );
                                }
                           }
                            Console.Write(" ");
                        }
                    }
                   
                   break;

                case "quit": // quit
                     Environment.Exit(0);
                    break;
                    
                default:
                    Console.WriteLine("Please select the one option ");
                    break;
            }
        }// loop to ask
     



        void getRandomScriture(){
                string theScripture = scripture.GetScriptureFromFile("List_Of_Scriptures.txt");
                string[] parts = theScripture.Split("*");
  
                reference.SetReference( parts[0], parts[1], parts[2], parts[3] );
                scripture.SetScripture(parts[4]);

                rndReference =  reference.GetReferenceBook() + reference.GetReferenceChapter() + reference.GetReferenceIniVerse() + reference.GetReferenceEndVerse()  ;
                rndScriture = " " + scripture.GetScripture();

                // // Can be done also like this:
                // reference.SetReferenceBook(parts[0]);
                // reference.SetReferenceChapter(parts[1]);
                // reference.SetReferenceIniVerse(parts[2]);
                // reference.SetReferenceEndVerse(parts[3]);

        }        

        void DisplayMenu()
        {
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Press Enter to continue or type 'quit' to finish:");       
                Console.WriteLine("----------------------------------");
        }

        List<Word> PassTheRandomScriptureToWordByWord(string scripture){

            string[] words = scripture.Split(' '); 
            
            foreach(string  word in words)
            {
                Word w = new Word(); 
                w.SetWord(word);
                w.SetVisibility(true);
                scripture_wordByword.Add(w);
            }
            return scripture_wordByword;
        }


        void HideTheRandomScriptureToWordByWord(List<Word> scripture_wordByword){
            //for(int x=0; x< scripture_wordByword.Count()-1 ; x++){
                int i = 0;
                while (i < 5 ) {
                   
                        Random rnd = new Random();
                        int pos = rnd.Next(scripture_wordByword.Count() ) ;
                        if (scripture_wordByword[pos].GetWordVisibility()) {
                            scripture_wordByword[pos].SetVisibility(false);
                           
                        }
                        i++;
                    }

            //}
        }


    }



}