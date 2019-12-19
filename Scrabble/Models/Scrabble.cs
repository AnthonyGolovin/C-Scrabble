using System;
using System.Threading;
using System.Collections.Generic;

namespace ScrabbleBack {

    public class ScrabbleLogic
    {
        public string UserInput = { get; set;}

        public ScrabbleLogic(string userInput)
        {
          UserInput = userInput;
          totalScore = ScrabbleScore();
        }
        //  string onePoint = "aeioulnrst";
        //  string twoPoint = "dg";
        //  string threePoint = "bcmp";
        //  string fourPoint = "fhvwy";
        //  string fivePoint = "k";
        //  string eightPoint = "jx";
        //  string tenPoint = "qz";
        //  int counter;

         public int ScrabbleScore(string userInput)
        {
            string onePoint = "aeioulnrst";
            string twoPoint = "dg";
            string threePoint = "bcmp";
            string fourPoint = "fhvwy";
            string fivePoint = "k";
            string eightPoint = "jx";
            string tenPoint = "qz";
            int counter;

            for(int i = 0; i < userInput; i++)
            {
                counter = 0;
                if(onePoint.Contains(userInput[i]))
                {
                    counter ++;
                }
                if(twoPoint.Contains(userInput[i]))
                {
                    counter += 2;
                }
                if(threePoint.Contains(userInput[i]))
                {
                    counter += 3;
                }
                if(fourPoint.Contains(userInput[i]))
                {
                    counter += 4;
                }
                if(fivePoint.Contains(userInput[i]))
                {
                    counter += 5;
                }
                if(eightPoint.Contains(userInput[i]))
                {
                    counter += 8;
                }
                if(tenPoint.Contains(userInput[i]))
                {
                    count += 10;
                }
            }
            return counter;
        }
    }
}