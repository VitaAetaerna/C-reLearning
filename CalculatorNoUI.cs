public class Program{
	public static void Main(){
		Input();
	}
	public static void Input(){
		int n1;
		int n2;
		string operation;


		Console.WriteLine("Please enter your First Number: ");
		n1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Please enter your desired Operation: ");
		operation = Console.ReadLine();

		Console.WriteLine("Please enter your Second Number: ");
		n2 = Convert.ToInt32(Console.ReadLine());

		// Check for 0 Divide
		if (operation == "/" && n2 == 0){
			Console.Clear();
			Console.WriteLine("Dividing by 0 is not possible");
			Console.WriteLine();
			Input();
		}

		switch(operation){
			case "+":
				Console.WriteLine("The Result of the Addition is: ");
				Console.WriteLine(n1 + n2);
				break;
			case "-":
				Console.WriteLine("The Result of the Substraction is: ");
				Console.WriteLine(n1 - n2);
				break;

			case "*":
				Console.WriteLine("The Result of the Multiplication is: ");
				Console.WriteLine(n1 * n2);
				break;
			case "/":
				Console.WriteLine("The Result of the Division is: ");
				Console.WriteLine(n1 / n2);
				break;

			case "%":
				Console.WriteLine("The Result of the Modulo is: ");
				Console.WriteLine(n1 % n2);
				break;
		}
		Console.WriteLine("Clear Console Y/N");
		if (Console.ReadLine() == "Y" || Console.ReadLine() == "N") Console.Clear();
		Input();

	}
}
