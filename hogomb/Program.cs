namespace hogomb
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> elemek = new List<string>();
			List<int> mennyisegek = new List<int>();
			bool fut = true;
            while (fut)
            {
                Console.WriteLine("\t1. Elemek hozzáadása\n\t2. Tartalom megtekintése\n\t 3. Elem eltávolítása\n\t4. Terminado");
                Console.Write("Add meg a választásod: ");
				int valasz=Convert.ToInt32(Console.ReadLine());
				switch (valasz)
				{
					case 1:
						bool futas=true;
                        while (futas)
                        {
							try
							{
								Console.Write("Mi az elem neve: ");
								string beker = Console.ReadLine();
								if (beker == "")
								{
									throw new Exception("A bemenet nem lehet üres.");
								}
								Console.Write("Hány darab: ");
								int menny = Convert.ToInt32(Console.ReadLine);
								Console.Write("Van még elem(i/n): ");
								char vane = Convert.ToChar(Console.ReadLine);
                                if (vane=='n')
                                {
									futas = false;
                                }
								elemek.Add(beker);
								mennyisegek.Add(menny);
                            }
							catch (OverflowException)
							{
								Console.WriteLine("Túllépted a határt.");
							}
							catch (FormatException)
							{
								Console.WriteLine("Hiba: Rossz bemeneti formátum.");
							}
							catch (Exception ex)
							{
								Console.WriteLine($"Hiba: {ex.Message}");
							}
						}
						break;
					case 2:
                        Console.WriteLine("Lista tartalma:");
						Console.WriteLine(string.Format("Elemek a hógömbben: ({0}).", string.Join(", ", elemek)));
						Console.WriteLine(string.Format("Elemek mennyisége: ({0}).", string.Join(", ", mennyisegek)));
						break;
					case 3:

				}

			}
        }
	}
}
