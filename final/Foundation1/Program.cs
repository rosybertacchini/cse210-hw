/* ************************************************************************************* */
/* Rosy Bertacchini
/* Final Project: ABSTRACTION
/*
/* This program apply ONLY the concept of ABSTRACTION in their classes
/* ************************************************************************************* */

using System;

class Program {
    static void Main(string[] args)
    {
        // Initialized and create class instances
        List<Video> videos  = new List<Video>{};
       
        // create data to test program
        AddSomeVideosToTheList();
        
        // display list of videos
        Console.Clear();
        foreach (Video v in videos){
            Console.WriteLine("------------------------------------------------------------------------");
            v.DisplayVideoDetails();
        }
        Console.WriteLine("------------------------------------------------------------------------");




        // ************************************     CREATE DATA  ( 3 videos )    ***********************************************
        void AddSomeVideosToTheList(){

            Video v1 = new Video();
            v1._title = "Game Over! Orca Just Reinvented PREFAB HOMES on the West Coast!!";
            v1._author = "Kerry Tarnow";
            v1._lenghtInSeconds = 14.04;

            v1._comments.Add(new Comment { _personName = "KJ", _textComment = "Red Flag: Not owning the land that your home is attached to is high risk in the long term. The landowner usually continues to raise lot fees as time goes on, and if they choose to sell, it could be devastating." });
            v1._comments.Add(new Comment { _personName = "Emmy Smith", _textComment = "It’s crazy to think developers are considering that “affordable” housing between 300k-400k with land you don’t own. 😢" });
            v1._comments.Add(new Comment { _personName = "Johanna Tangonan", _textComment = "My thought was that a pop-up factory like Orca's would be a great solution after an area experienced a natural disaster." });
            v1._comments.Add(new Comment { _personName = "So-U Say", _textComment = "More 'live' visitation tours of prefab homes and manufacturing sites, please!" });
             videos.Add(v1);
            /* - - - - - - - - - - - - - - - - - - */
            Video v2 = new Video();
            v2._title = "Celestial Training in a Telestial World” by Sheri L. Dew | BYU Women's Conference, 2023";
            v2._author = "Sheri L Dew";
            v2._lenghtInSeconds = 38.24;

            v2._comments.Add(new Comment { _personName= "B.J.", _textComment= "Sister Dew has a way with words. So grateful to her for sharing her gift in such a down to earth, relatable way." });
            v2._comments.Add(new Comment { _personName= "Tina Carvalho" , _textComment= "So glad we who are far away from BYU  can still eventually get Women Conference!"  });
            v2._comments.Add(new Comment { _personName= "Tondrea Jackson" , _textComment= "I am so happy to see Sheri Dew's talk was uploaded again. The volume is much better. In my opinion, this is an epic talk. I soooo agree that listening to our prophets and Temple attendance (more than once weekly) is a powerful combination to withstand the wiles of the adversary. 🌼🌻" });
            v2._comments.Add(new Comment { _personName= "Victoria" , _textComment= "I was there when this happened. Love her spiritual poise and calmness." });
            v2._comments.Add(new Comment { _personName= "Rosy Bertacchini" , _textComment= "I admired Sheri L. Dew." });
            videos.Add(v2);
            /* - - - - - - - - - - - - - - - - - - */
            Video v3 = new Video();
            v3._title = "Judge drops hammer on Trump: Gags entire legal team";
            v3._author = "MSNBC";
            v3._lenghtInSeconds = 11.57;

            v3._comments.Add(new Comment { _personName= "jodinsan" , _textComment= "The 'Law and order' party sure doesn't believe in following either. 'Rules for thee but not for me.'" });
            v3._comments.Add(new Comment { _personName= "Adrian b Cozad", _textComment= "Trump's lawyers know they are losing and they are desperate to find answers.😅 for Trump's family  business."  });
            v3._comments.Add(new Comment { _personName= "Citizen Sane", _textComment= "I for one do not care what Donald trump says on truth, or on Twitter, or on fox, or on tucker Carlson’s show, or at a rally, or in front of reporters as he’s walking out the court room. I care about what he says UNDER OATH. That is when it all gets real. " });
            
            videos.Add(v3);
        }


        // ********************************************************************************************************************
    }
} // End of program