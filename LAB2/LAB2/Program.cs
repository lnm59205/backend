/*
// Bai 1: Tinh tong cua tat ca cac so chan trong mot mang
Console.Write("Nhap so luong phan tu cua mang: ");
int n = int.Parse(Console.ReadLine()??"");
int[] arr = new int[n];

Console.WriteLine("Nhap cac phan tu trong mang:");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine()??"");
}

int SumEven(int[] array)
{
    int sum = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0)
            sum += num;
    }
    return sum;
}

Console.WriteLine($"Tong cac so chan trong mang la: {SumEven(arr)}");
*/

/*
// Bai 2: Kiem tra cac so nguyen to trong mang
// Nhap so luong phan tu cua mang
Console.Write("Nhap so luong phan tu cua mang: ");
int n = int.Parse(Console.ReadLine() ?? "");

// Khoi tao mang
int[] arr = new int[n];

// Nhap cac phan tu trong mang
Console.WriteLine("Nhap cac phan tu trong mang:");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine() ?? "");
}

// Ham kiem tra so nguyen to
bool IsPrime(int num)
{
    if (num <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}

// In ra cac so nguyen to trong mang
Console.WriteLine("Cac so nguyen to trong mang:");
for (int i = 0; i < n; i++)
{
    if (IsPrime(arr[i]))
        Console.WriteLine($"Chi so {i}: {arr[i]}");
}
*/

/*
// Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập từ bàn phím.
Console.Write("Nhap so luong phan tu cua mang: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[] arr = new int[n];

Console.WriteLine("Nhap cac phan tu trong mang:");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine() ?? "");
}

// Hàm đếm số lượng số âm và số dương
void CountPositiveNegative(int[] arr)
{
    int positiveCount = 0;
    int negativeCount = 0;
    foreach (int num in arr)
    {
        if (num > 0) positiveCount++;
        else if (num < 0) negativeCount++;
    }
    Console.WriteLine($"So luong so duong: {positiveCount}");
    Console.WriteLine($"So luong so am: {negativeCount}");
}

// In kết quả
CountPositiveNegative(arr);
*/

/*
// Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
Console.Write("Nhap so luong phan tu cua mang: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[] arr = new int[n];

Console.WriteLine("Nhap cac phan tu trong mang:");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine() ?? "");
}

// Hàm tìm số lớn thứ hai
int FindSecondLargest(int[] arr)
{
    int largest = int.MinValue;
    int secondLargest = int.MinValue;
    foreach (int num in arr)
    {
        if (num > largest)
        {
            secondLargest = largest;
            largest = num;
        }
        else if (num > secondLargest && num != largest)
        {
            secondLargest = num;
        }
    }
    return secondLargest;
}

// In kết quả
Console.WriteLine($"So lon thu hai trong mang la: {FindSecondLargest(arr)}");
*/

/*
// Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
Console.Write("Nhap so a: ");
int a = int.Parse(Console.ReadLine() ?? "");

Console.Write("Nhap so b: ");
int b = int.Parse(Console.ReadLine() ?? "");

// Hàm hoán vị
void Swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}

Swap(ref a, ref b);
Console.WriteLine($"Sau khi hoan vi, a = {a}, b = {b}");
*/

/*
// Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
Console.Write("Nhap so luong phan tu cua mang: ");
int n = int.Parse(Console.ReadLine() ?? "");
double[] arr = new double[n];

Console.WriteLine("Nhap cac phan tu trong mang:");
for (int i = 0; i < n; i++)
{
    arr[i] = double.Parse(Console.ReadLine() ?? "");
}

// Hàm sắp xếp mảng
void SortArray(double[] arr)
{
    Array.Sort(arr);
}

// Sắp xếp và in kết quả
SortArray(arr);
Console.WriteLine("Mang sau khi sap xep theo chieu tang dan:");
foreach (double num in arr)
{
    Console.WriteLine(num);
}
*/