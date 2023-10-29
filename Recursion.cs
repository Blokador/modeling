class Modeling {



	// Перше завдання
	void Recursion1(string i, int j) {

		Console.Write(i[j]);

		if (j != 0) Recursion1(i, j-1);

	}


	void Recursion2(int[] i, int index) {

		if (index <= i.Length - 1) {
			if (index % 2 == 0) {
				if (index + 1 <= i.Length - 1) {
					int replica = i[index];
					i[index] = i[index + 1];
					i[index + 1] = replica;
				}
			}
			Console.Write(i[index] + " ");
			index++;
			Recursion2(i, index);
		}
	}

	int Recursion3(int i) {
		if (i <= 1) {
			return 1;
		}
		else return i + Recursion3(i - 1);
	}

	int Recursion4(int i) {

		
		int Fact(int f) {
			if (f > 1) {
				return f * Fact(f - 1);
			}
			else return 1; 
		}

		return Fact(i) / (Fact(2) * Fact(i - 2));

	}

	double Recursion5(double x, int n) {
		if (n > 1) {
			return x * Recursion5(x, n - 1);
		}
		else return x;
	}

	static public void Main(){
		string first = "tiger";
		int[] second = new int[] {1, 2, 3, 4};
		int third = Convert.ToInt32(Console.ReadLine());
		int fourth = Convert.ToInt32(Console.ReadLine());


		var model = new Modeling();

		model.Recursion1(first , first.Length - 1);
		Console.WriteLine();

		model.Recursion2(second, 0);
		Console.WriteLine();

		Console.WriteLine(model.Recursion3(third));
		Console.WriteLine();
		
		Console.WriteLine(model.Recursion4(fourth));
		Console.WriteLine();

		Console.WriteLine(model.Recursion5(5.3, 2));
		Console.WriteLine();
	}


}
