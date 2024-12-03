namespace Dictionary12._03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Dictionary<string, string> dict = new Dictionary<string, string>();

			dict.Add("Ádám", "Fortnite");
			dict.Add("Zolika", "Wrum-wrum");
			dict.Add("Bazsi", "PHP SQL Király");

			Console.WriteLine(dict["Ádám"]);
            

        }
	}
}
