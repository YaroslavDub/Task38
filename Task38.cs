// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
double[] array = new double [i];
double Diff = 0;
for (int count = 0; count < i; count++) {
    Console.WriteLine($"Введите {count + 1} элемнет массива");
    array[count] = Convert.ToDouble(Console.ReadLine());
}
double max = array[0];
double min = array[0];
for (int count = 0; count < i; count ++) {
    if (max < array[count]) {
        max = array[count];
    }
    else if (min > array [count]) {
        min = array[count];
    }
}
Diff = max - min;
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine(Diff);