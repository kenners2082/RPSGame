using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPSWebAPI.Models
{

    public class GameResult
    {
        //public string compResponse { get; set; } = "Sample String"

        public int userTally { get; set; }
        public int compTally { get; set; }
        public string roundWinner { get; set; }
        public DateTime date { get; set; }

    }

    public class CompResponseandResult
    {
        //public string compResponse { get; set; } = "Sample String"

        public string compResponse { get; set; }
        public string result { get; set; }

    }


    public class GameService
    {
           
        public object[] PlayerSelections(){
        Object[] signs = new object[]
        { (value: 0, viewValue: "Rock", icon: "faHandRock"),
            (value: 1, viewValue: "Paper", icon: "faPaperPlane"),
            (value: 2, viewValue: "Scissors", icon: "faHandScissors") };

            return signs;

        }

        public string CompRandomizer()
        {
            Random rnd = new Random();
            int randomSign = rnd.Next(3);

            dynamic compResponse = (dynamic)(PlayerSelections()[randomSign]);

            return compResponse.Item2;
        }

        //add userResponse back as a parameter after static testing
        public CompResponseandResult PlayGame(string userResponse)
        {
            CompResponseandResult results = new CompResponseandResult();

            results.compResponse = CompRandomizer();

          
            string responses = userResponse + "&" + results.compResponse;

            //return responses;

            results.result = "";

            //logic for switch case
                      switch (responses)
                    {
                        case "Rock&Paper":
                        case "Paper&Scissors":
                        case "Scissors&Rock":
                        results.result= "Hooray, You win!";
                            //userTally++;
                            Console.WriteLine(results.result + " You have " +  "100 point(s)");
                            break;
                        case "Rock&Scissors":
                        case "Paper&Rock":
                        case "Scissors&Paper":
                        results.result = "Sorry, You Lose";
                            //compTally++;
                            Console.WriteLine(results.result + " Computer has " + "500 point(s)");
                            break;
                        default:
                        results.result = "Tie Game!";
                            Console.WriteLine(results.result);
                            break;
                    }

                       return results;
                }

     

    }
}
