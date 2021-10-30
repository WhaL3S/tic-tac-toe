using System;
					
public class Program
{
	public static void Print(string[,] a)
	{
		Console.Clear();
		for(int i = 0; i < 3; i++)
		{
			for(int j = 0; j < 3; j++)
			{
				Console.Write(" | " + a[i, j]);
			}
			Console.Write(" | ");
			Console.WriteLine();
		}
	}
	public static int WinnerChecker(string[,] a, int winner)
	{
		if(a[0,0] == a[0,1] && a[0,1] == a[0,2] && a[0,0] != " ")
			{
				if(a[0, 0] == "x")
				{
					winner = 1;
				}	
				else if(a[0,0] == "o")
				{
					winner = 2;
				}
			}
			else if(a[1,0] == a[1,1] && a[1,1] == a[1,2] && a[1,0] != " ")
			{
				if(a[1, 0] == "x")
				{
					winner = 1;
				}	
				else if(a[1,0] == "o")
				{
					winner = 2;
				}
			}
			else if(a[2,0] == a[2,1] && a[2,1] == a[2,2] && a[2,0] != " ")
			{
				if(a[2, 0] == "x")
				{
					winner = 1;
				}	
				else if(a[2,0] == "o")
				{
					winner = 2;
				}
			}
			else if(a[0,0] == a[1,0] && a[1,0] == a[2,0] && a[0,0] != " ")
			{
				if(a[0, 0] == "x")
				{
					winner = 1;
				}	
				else if(a[0,0] == "o")
				{
					winner = 2;
				}
			}
			else if(a[0,1] == a[1,1] && a[1,1] == a[2,1] && a[0,1] != " ")
			{
				if(a[0, 1] == "x")
				{
					winner = 1;
				}	
				else if(a[0, 1] == "o")
				{
					winner = 2;
				}
			}
			else if(a[0,2] == a[1,2] && a[1,2] == a[2,2] && a[0,2] != " ")
			{
				if(a[0, 2] == "x")
				{
					winner = 1;
				}	
				else if(a[0, 2] == "o")
				{
					winner = 2;
				}
			}
			else if(a[0,0] == a[1,1] && a[1,1] == a[2,2] && a[0,0] != " ")
			{
				if(a[0, 0] == "x")
				{
					winner = 1;
				}	
				else if(a[0, 0] == "o")
				{
					winner = 2;
				}
			}
			else if(a[0,2] == a[1,1] && a[1,1] == a[2,0] && a[0,2] != " ")
			{
				if(a[0, 2] == "x")
				{
					winner = 1;
				}	
				else if(a[0, 2] == "o")
				{
					winner = 2;
				}
			}
		return winner; 
	}
	public static void Main()
	{
		Console.WriteLine("Type 1, 2, 3, 4, 5, 6, 7, 8, 9");
		string[,] a = new string[3, 3];
		for(int i = 0; i < 3; i++)
		{
			for(int j = 0; j < 3; j++)
			{
				a[i, j] = " ";
			}
		}
		int counter = 1;
		int winner = 0;
		while(winner == 0)
		{
			int counter_holder = counter;
			if(counter % 2 == 1)
			{
				while(counter_holder == counter)
				{
					Console.WriteLine("First player's turn");
					int turn = int.Parse(Console.ReadLine());
					if (turn == 1 && a[2,0] == " ")
					{ 
						a[2,0] = "x";
						counter++;
					}
					else if(turn == 2 && a[2,1] == " ")
					{
						a[2,1] = "x";
						counter++;
					}
					else if(turn == 3 && a[2,2] == " ")
					{
						a[2,2] = "x";
						counter++;
					}
					else if(turn == 4 && a[1,0] == " ")
					{
						a[1, 0] = "x";
						counter++;
					}
					else if(turn == 5 && a[1,1] == " ")
					{
						a[1,1] = "x";
						counter++;
					}
					else if(turn == 6 && a[1,2] == " ")
					{
						a[1,2] = "x";
						counter++;
					}
					else if(turn == 7 && a[0,0] == " ")
					{
						a[0,0] = "x";
						counter++;
					}
					else if(turn == 8 && a[0,1] == " ")
					{
						a[0,1] = "x";
						counter++;
					}
					else if(turn == 9 && a[0,2] == " ")
					{
						a[0,2] = "x";
						counter++;
					}
					else
					{
						Console.WriteLine("Invalid");
					}
				}
				
			}
			else
			{
				while(counter_holder == counter)
				{
					Console.WriteLine("Second player's turn");
					int turn = int.Parse(Console.ReadLine());
					if (turn == 1 && a[2,0] == " ")
					{ 
						a[2,0] = "o";
						counter++;
					}
					else if(turn == 2 && a[2,1] == " ")
					{
						a[2,1] = "o";
						counter++;
					}
					else if(turn == 3 && a[2,2] == " ")
					{
						a[2,2] = "o";
						counter++;
					}
					else if(turn == 4 && a[1,0] == " ")
					{
						a[1,0] = "o";
						counter++;
					}
					else if(turn == 5 && a[1,1] == " ")
					{
						a[1,1] = "o";
						counter++;
					}
					else if(turn == 6 && a[1, 2] == " ")
					{
						a[1,2] = "o";
						counter++;
					}
					else if(turn == 7 && a[0,0] == " ")
					{
						a[0,0] = "o";
						counter++;
					}
					else if(turn == 8 && a[0,1] == " ")
					{
						a[0,1] = "o";
						counter++;
					}
					else if(turn == 9 && a[0,2] == " ")
					{
						a[0,2] = "o";
						counter++;
					}
					else
					{
						Console.WriteLine("Invalid");
					}
				}
			}
			Print(a);
			winner = WinnerChecker(a, winner);
			if(winner == 1)
			{
				Console.WriteLine("\nFirst Player won");
			}
			else if (winner == 2)
			{
				Console.WriteLine("\nSecond Player won");
			}
		}
	}
}
