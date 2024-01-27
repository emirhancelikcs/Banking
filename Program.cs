bool exit = false;
float totalMoney = 199.99F;

Console.WriteLine("Welcome to Banking App!");

while (!exit)
{
	Console.WriteLine("\n\nChoose option");
	Console.Write("1. Add Money\n2. Draw Money\n3. See Money\nq|4. Exit\n>");
	string? selectedOption = Console.ReadLine();

	switch (selectedOption)
	{
		case "1":
			Console.WriteLine($"Your total money is {totalMoney}");
			Console.Write("How much money do you add?\n>");
			float addMoney = (float)Convert.ToDecimal(Console.ReadLine().Replace(".", ","));

			totalMoney += addMoney;
			Console.WriteLine($"Your new total money is {totalMoney}");
			break;

		case "2":
			Console.WriteLine("Hom much money do you want to draw?");
			float drawMoney = (float)Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
			if (drawMoney > totalMoney || drawMoney < 0)
				Console.WriteLine($"You can not draw money more than your account! Your total money is {totalMoney}");
			else
			{
				totalMoney -= drawMoney;
				Console.WriteLine($"Your new total money is {totalMoney}");
			}
			break;

		case "3":
			Console.WriteLine($"Your total money is {totalMoney}");
			break;

		case "4":
		case "q":
			exit = true;
			break;

		default:
			exit = true;
			break;
	}
}
