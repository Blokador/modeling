class ArrayTask {

	int[] Sort(int[] i) {
		for (int x = 1; x < i.Length; x++) {
			int key = i[x];
			int j = x - 1;

			while (j >= 0 && i[j] > key) {
				i[j + 1] = i[j];
				j -= 1;
			}
			i[j + 1] = key;
		}
		return i;
	}

	int ArrayTask2(int[] n) {
		int Count = 0, quant = 0;


		foreach (var item in n) {

			int number = item, tick = 0;
			
			while (number != 0) {
				Count++;
				number /= 10;
				tick++;
			}

			if (Count % 2 == 0) {
				quant++;
			}

			Count = 0;
		}

		return quant;
	}

	void ArrayTask3(ref int[] i) {
		
		for(int x = 0; x < i.Length; x++) {
			i[x] *= i[x];
		}

		i = Sort(i);

		for (int x = 0; x < i.Length; x++) {
			Console.Write(i[x] + "  ");
		}
	}

	
	void ArrayTask4(ref int[] n) { 
		
		for(int i = 0; i < n.Length;) { 
			if (n[i] != 0) 	i++;
			else {
				for(int x = n.Length - 1; x > i; x--) {
					n[x] = n[x - 1];
				}
				i += 2;
			}
		}

		for (int x = 0; x < n.Length; x++) {
			Console.Write(n[x] + "  ");
		}

	}

	void ArrayTask5(ref int[] i, int[] j) {
		int lastIndex = i.Length;

		Array.Resize(ref i, i.Length + j.Length);

		for (int x = 0; x < j.Length; x++) {
			i[x + lastIndex] = j[x];
		}

		i = Sort(i);


		for (int x = 0; x < i.Length; x++) {
			Console.Write(i[x] + "  ");
		}
		
	}

	void ArrayTask6(ref int[] i) {
		
		int[] temp = new int[0];
		int checkValue = i[0];
		
		temp = temp.Append(i[0]).ToArray();

		for(int x = 1; x < i.Length; x++) {
			if (i[x] != checkValue) {
				checkValue = i[x];
				temp = temp.Append(i[x]).ToArray();
			}
		}

		Array.Resize(ref i, temp.Length);

		i = (int[])temp.Clone();

		for (int x = 0; x < i.Length; x++) {
			Console.Write(i[x] + "  ");
		}

	}

	bool ArrayTask7(int[] n) {
		for (int i = 0; i < n.Length; i++) {
			for (int j = i + 1; j < n.Length; j++)
				if (n[i] == 2 * n[j]) return true;
		}
		return false;
	}

	bool ArrayTask8(int[] n) {

		int index = -1, temp = -1;

		for(int i = 0; i < n.Length; i++) {
			
			if (temp < n[i]) {
				index = i;
				temp = n[i];
			}
		}
		
		if (index >= -1 && n.Length > 2) {
			if (index > 1) 

				if (n[index] == n[index - 1] + 1 && n[index - 1] == n[index - 2] + 1) return true;

			else if (index <= n.Length - 2) 

				if (n[index] == n[index + 1] - 1 && n[index + 1] == n[index + 2] - 1) return true;
			else return false;
		}
		return false;
	}

	void ArrayTask9(ref int[] n) {

		int max = -1, temp;

		for (int i = n.Length - 1; i >= 0; i--) {
			if (n[i] > max) {
				temp = n[i];
				n[i] = max;
				max = temp;
			}
			else n[i] = max;
		}

		for (int x = 0; x < n.Length; x++) {
			Console.Write(n[x] + "  ");
		}
	}

	void ArrayTask10(ref int[] n) {

		int temp;

		for (int i = 0; i < n.Length; i++) {
			for (int j = i + 1; j < n.Length; j++) {
				if (n[j] % 2 == 0) {
					temp = n[i];
					n[i] = n[j];
					n[j] = temp;
					break;
				}
			}
		}

		for (int x = 0; x < n.Length; x++) {
			Console.Write(n[x] + "  ");
		}
	}

	static void Main() {
		var Task = new ArrayTask();
		
		
		int[] numbers = new int[] { 12, 35, 2, 6, 7896 }; // 2
		
		int[] nums = new int[] { -4, -1, 0, 3, 10 }; // 3
		
		int[] arr = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }; // 4
		
		int[] n = new int[] { 2, 5, 6};// 5
		int[] m = new int[] { 1, 2, 3};//

		int[] ints = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

		int[] checkD = new int[] { 10, 2, 5, 3};

		int[] mountain = new int[] { 0, 1, 2 };

		int[] biggie = new int[] { 17, 18, 5, 4, 6, 1 };

		int[] shuffled = new int[] { 3, 1, 2, 4 };


		Console.WriteLine("2 завдання: " + Task.ArrayTask2(numbers));

		
		
		Console.Write("3 Питання: ");
		Task.ArrayTask3(ref nums);


		Console.WriteLine();

		Console.Write("4 Питання: ");
		Task.ArrayTask4(ref arr);

		Console.WriteLine();
		
		Console.Write("5 Питання: ");
		Task.ArrayTask5(ref m, n);

		Console.WriteLine();

		Console.Write("6 Питання: ");
		Task.ArrayTask6(ref ints);
		Console.WriteLine();

		Console.WriteLine("7 Питання: " + Task.ArrayTask7(checkD));

		Console.WriteLine("8 Питання: " + Task.ArrayTask8(mountain));

		Console.Write("9 Питання: ");
		Task.ArrayTask9(ref biggie);
		Console.WriteLine();


		Console.Write("10 Питання: ");
		Task.ArrayTask10(ref shuffled);

	}

}



