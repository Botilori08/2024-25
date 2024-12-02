namespace listaGyakorlas12._02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List <int> lista = new List <int> ();

			lista.Add (1);
			lista.Add(2);
			lista.Add (6);	
			lista.Add (3);
			lista.Add (21);


			Console.WriteLine (lista.Capacity);
			Console.WriteLine (lista.Count);
            Console.WriteLine();
            Console.WriteLine(lista[2]);
            Console.WriteLine();

            for (int i = 0; i < lista.Count; i++)
			{
				Console.WriteLine(lista[i]);
            }

            Console.WriteLine();

            lista.Insert (3, 222);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }


			Console.WriteLine("\n"+lista.IndexOf(222));


        }
	}
}
