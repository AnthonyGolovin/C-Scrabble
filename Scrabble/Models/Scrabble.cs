using System;
using System.Threading;
using System.Collections.Generic;

namespace ScrabbleBack {

    public class ScrabbleLogic
    {
       public string UserInput { get; set; }
       public int TotalScore { get; set; }

        public ScrabbleLogic(string userInput, int totalScore)
        {
          UserInput = userInput;
          TotalScore = ScrabbleScore(userInput, totalScore);
        }

         public int ScrabbleScore(string UserInput, int TotalScore)
        {
            string onePoint = "aeioulnrst";
            string twoPoint = "dg";
            string threePoint = "bcmp";
            string fourPoint = "fhvwy";
            string fivePoint = "k";
            string eightPoint = "jx";
            string tenPoint = "qz";
            int counter;

            for(int i = 0; i < UserInput.Length; i++)
            {
                counter = 0;
                if(onePoint.Contains(UserInput[i]))
                {
                    counter ++;
                }
                if(twoPoint.Contains(UserInput[i]))
                {
                    counter += 2;
                }
                if(threePoint.Contains(UserInput[i]))
                {
                    counter += 3;
                }
                if(fourPoint.Contains(UserInput[i]))
                {
                    counter += 4;
                }
                if(fivePoint.Contains(UserInput[i]))
                {
                    counter += 5;
                }
                if(eightPoint.Contains(UserInput[i]))
                {
                    counter += 8;
                }
                if(tenPoint.Contains(UserInput[i]))
                {
                    counter += 10;
                }
            }
            return TotalScore;
        }
    }
}