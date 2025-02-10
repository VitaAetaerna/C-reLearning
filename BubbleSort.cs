
public static class Program{

	public static int[] array = {10, 25, 32, 2, 11, 349, 0, 23};

	public static void Main(){
		foreach (var item in array) {
			Console.Write(item + ", ");
		}
		Console.WriteLine();

		int tmp; 

		for (int i = 0; i < array.Length - 1; i++){ 

		for (int j = 0; j < array.Length - i - 1; j++){
			if (array[j] > array[j + 1]){
				tmp = array[j];
				array[j] = array[j + 1];
				array[j + 1] = tmp;
			}
		}
	}
		foreach (var item in array) {
			Console.Write(item + ",  ");
		}
		Console.WriteLine();
		}
	
}
