using System;

public class Scripture {

        private Reference _scriptureReference = new Reference();
        private string _scripture;
        private List<Word> _scripture_wordByword = new List<Word>();

      
        // constructors
        public Scripture(){

        }

 
 
         // setters and getters
        public string GetScripture(){
            return _scripture;
        }
        public void SetScripture(string scripture){
            _scripture = scripture;
        }


        // accesibility problem - can be done using this:
        // public  void SetScripture_wordByword(List<Word> ScriptureWordByWord ){
        //          _scripture_wordByword = ScriptureWordByWord;
        // }
        // public  List<Word> GetScripture_wordByword( ){
        //         return _scripture_wordByword
        // }


  
        public string GetScriptureFromFile(string filename) {
  
                int n_random = getRandomNumbre();
                int x = 0;
                string rndScripture = "";

                string[] lines = System.IO.File.ReadAllLines(filename);
                {
                    foreach (string line in lines)
                        {
                            string[] parts = line.Split("*");
                            if (n_random == x) {

                                 rndScripture = line;
                                //  insted of this lie (rndScripture = line;) , I tried to call the setters  of the reference class here, but in 
                                //  the program it is not pposible to obtain the values of the reference 
                                // 
                                
                                // AL FINAL PRUEBA ESTA LINEA DE DE ABAJO
                                // _scriptureReference.SetReferenceBook(parts[0]);
                                // reference.SetReferenceChapter(parts[1]);
                                // reference.SetReferenceIniVerse(parts[2]);
                                // reference.SetReferenceEndVerse(parts[3]);
                                                
                                 SetScripture(parts[4]);
     
                            }

                            x += 1;
                        }
                }
                return rndScripture;
        }
     


        int getRandomNumbre(){
            Random rnd = new Random();
            int num = rnd.Next(5) ;
            return num;
        }


}

