using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWorkTasks
{
	enum NormalWorkHours
	{
		Manager = 195,
		Developer = 200,
		Worker=210,
		Secretary=183
	}

	struct Accountant
	{
		public void calculateOvertime(NormalWorkHours hours1, int realWorkHour)
		{
			int compareWorkHours = 0;

			switch (hours1)
			{
				case NormalWorkHours.Manager:
					{
						compareWorkHours = (int)NormalWorkHours.Manager;
						Console.WriteLine($"Position is : {NormalWorkHours.Manager}, Normal Hours are {compareWorkHours}");
					}
					break;
				case NormalWorkHours.Developer:
					{
						compareWorkHours = (int)NormalWorkHours.Developer;
						Console.WriteLine($"Position is : {NormalWorkHours.Developer}, Normal Hours are {compareWorkHours}");
					}
					break;
				case NormalWorkHours.Worker:
					{
						compareWorkHours = (int)NormalWorkHours.Worker;
						Console.WriteLine($"Position is : {NormalWorkHours.Worker}, Normal Hours are {compareWorkHours}");
					}
					break;
				case NormalWorkHours.Secretary:
					{
						compareWorkHours = (int)NormalWorkHours.Secretary;
						Console.WriteLine($"Position is : {NormalWorkHours.Secretary}, Normal Hours are {compareWorkHours}");
					}
					break;

				default:
					break;
			}

			if (realWorkHour > compareWorkHours)
			{

				Console.Clear();
				Console.WriteLine();
				Console.WriteLine($"Your OVERTIME is : {realWorkHour - compareWorkHours}, " +
					$"you will get Bonus");
				Console.WriteLine();
			}
			else
			{

				Console.Clear();
				Console.WriteLine();
				Console.WriteLine($"Your OVERTIME is : {realWorkHour - compareWorkHours}, " +
					$"you will get normal salary");
				Console.WriteLine();
			}

		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				PositionChoice();
			}
			catch (Exception ex)
			{
				Console.WriteLine("My Exception---"); Console.WriteLine(ex.Message);
			}
			


		}
		public static void PositionChoice()
		{
			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("Please ENTER the position to make calculation");
				Console.WriteLine();
				Console.WriteLine("List of position : Manager , Developer , Worker , Secretary");
				Console.WriteLine();

				NormalWorkHours hours = new NormalWorkHours();

				string positions;
				int realWorkHour = 0;

				positions = Console.ReadLine();
				

				if (positions == "Manager")
				{
					hours = NormalWorkHours.Manager;
				}
				else if (positions == "Developer")
				{
					hours = NormalWorkHours.Developer;
				}
				else if (positions == "Worker")
				{
					hours = NormalWorkHours.Worker;
				}
				else if (positions == "Secretary")
				{
					hours = NormalWorkHours.Secretary;
				}
				else
				{
					Console.WriteLine("WRONG CHOICE");
					break;
				}

				Console.WriteLine();
				Console.WriteLine("Please ENTER Real Work Hous of the employee");
				realWorkHour = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();

				Accountant acc = new Accountant();

				acc.calculateOvertime(hours, realWorkHour);

				Console.WriteLine();
				Console.WriteLine("Please PRESS  \"G\" to GO ON  or PRESS  \"C\" to CANCEL");
				string choice = (Console.ReadLine());
				string choice1 = choice.ToUpper();

				if (choice1 == "G")
				{
					continue;
				}

				else if (choice1 == "C")
				{
					break;
				}

				else
				{
					Console.WriteLine("Wrong choice");
					break;
				}

			}
		}
	}
	
}
