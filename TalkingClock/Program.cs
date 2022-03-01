using System;

namespace TalkingClock
{
    public class Program
    {
        static void Main(string[] args)
        {
			if (args.Length == 0)
			{				
				//objective 1
				Console.WriteLine(HumanFriendlyTime(DateTime.Now));
				return;
            }
            else
            {
				//objective 2
				var argTime = args[0];
				DateTime dateValue;
				
				if (DateTime.TryParse(argTime, out dateValue))
                {
					Console.WriteLine(HumanFriendlyTime(dateValue));
				}
                else
                {
					Console.WriteLine("Argument must be in DateTme format 'hh:mm'");
				}
					return;
			}

		}

		
		public static string HumanFriendlyTime(DateTime dt)
        {
			var roundedmin = RoundMinutes(dt.Minute, 5);
			
			//Manage double O'Clock Occurence
			if(roundedmin == 60)
            {
				dt = dt.AddHours(1);
            }

			var friendlymin = FriendlyMinutes(roundedmin);

			var friendlyhour = FriendlyHour(dt.Hour, friendlymin);

			return FormatFriendlyTime(friendlyhour, friendlymin);

        }

		static string FormatFriendlyTime(string hour, string min)
        {
			return min.Contains("O'Clock") ? hour + " " + min : min + " " + hour;
        }
				

		static string FriendlyHour(int hour, string min)
        {
			//set correct hour dependent on Past / To
            if (!min.Contains("O'Clock"))
            {
					hour = min.Contains("Past") ? hour :hour + 1;
            }
            
			switch (hour)
            {
				case 1:
				case 13:
					return "One";
				case 2:
				case 14:
					return "Two";
				case 3:
				case 15:
					return "Three";
				case 4:
				case 16:
					return "four";
				case 5:
				case 17:
					return "Five";
				case 6:
				case 18:
					return "Six";
				case 7:
				case 19:
					return "Seven";
				case 8:
				case 20:
					return "Eight";
				case 9:
				case 21:
					return "Nine";
				case 10:
				case 22:
					return "Ten";
				case 11:
				case 23:
					return "Eleven";
				default:
					return "Twelve";
            }
        }

		static string FriendlyMinutes(int roundedmin)
        {
			
            switch (roundedmin)
            {
				case 5:
					return "Five Past";
				case 10:
					return "Ten Past";
				case 15:
					return "Quarter Past";
				case 20:
					return "Twenty Past";
				case 25:
					return "Twenty-Five Past";
				case 30:
					return "Half Past";
				case 35:
					return "Twenty-Five to";
				case 40:
					return "Twenty to";
				case 45:
					return "Quarter to";
				case 50:
					return "Ten to";
				case 55:
					return "Five to";				
				default:
					return "O'Clock";

			}
        }

	
		static int RoundMinutes(double i, int v)
		{
			return (int)(Math.Round(i / v) * v);
		}
	}
}
