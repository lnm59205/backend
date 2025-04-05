//Bai 1:Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào[tên], bạn[tuổi] tuổi!".
/*
//Nhập tên người dùng từ bàn phím
Console.Write("Nhap ten cua ban: ");
string name = Console.ReadLine()??"";

//Nhập tuổi người dùng từ bàn phím
Console.Write("Nhap tuoi cua ban: ");
int age = int.Parse(Console.ReadLine()??"");

//In ra tên và tuổi người dùng
Console.WriteLine($"Xin chao {name}, ban {age} tuoi!");
Console.ReadLine();
*/

/*
//Bai 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng
//Người dùng nhập chiều dài
Console.Write("Nhap chieu dai cua hinh chu nhat: ");
int length = int.Parse(Console.ReadLine() ?? "");

// Người dùng nhập chiều rộng
Console.Write("Nhap chieu rong cua hinh chu nhat: ");
int width = int.Parse(Console.ReadLine() ?? "");

//Diện tích
int area = length * width;

//Kết quả
Console.WriteLine($"Dien tich cua hinh chu nhat la: {area}");
Console.ReadLine();
*/

/*
//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
Console.Write("Nhap do C: ");
double celsius = double.Parse(Console.ReadLine() ?? "");
//Công thức chuyển đổi
double fahrenheit = (celsius * 9 / 5) + 32;
//Kết quả
Console.WriteLine($"{celsius} do C = {fahrenheit} do F");
Console.ReadLine();
*/

/*
//Bai 4: Viet chuong trinh nhap vao mot so nguyen va kiem tra xem so do co phai la so chan hay khong.
Console.Write("Nhap vao mot so nguyen: ");
int num = int.Parse(Console.ReadLine() ?? "");
// Kiem tra so chan hay le
if (num % 2 == 0)
{
    Console.WriteLine("So nhap vao la so chan.");
}
else
{
    Console.WriteLine("So nhap vao la so le.");
}
Console.ReadLine();
*/

/*
//Bai 5: Viet chuong trinh tinh tong va tich cua hai so nhap tu ban phim.
Console.Write("Nhap vao so thu nhat: ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Nhap vao so thu hai: ");
int num2 = int.Parse(Console.ReadLine() ?? "");

// Tinh tong va tich
int sum = num1 + num2;
int product = num1 * num2;

// Ket qua
Console.WriteLine($"Tong cua hai so la: {sum}");
Console.WriteLine($"Tich cua hai so la: {product}");
Console.ReadLine();
*/

/*
//Bai 6: Viet chuong trinh kiem tra xem mot so nhap vao co phai la so duong, so am hay so khong.
Console.Write("Nhap vao mot so: ");
int number = int.Parse(Console.ReadLine() ?? "");
// Kiem tra so duong, am hay khong
if (number > 0)
{
    Console.WriteLine("So nhap vao la so duong.");
}
else if (number < 0)
{
    Console.WriteLine("So nhap vao la so am.");
}
else
{
    Console.WriteLine("So nhap vao la so khong.");
}
Console.ReadLine();
*/

/*
//Bai 7: Viet chuong trinh kiem tra xem mot nam nhap vao co phai la nam nhuan hay khong.
Console.Write("Nhap vao mot nam: ");
int year = int.Parse(Console.ReadLine() ?? "");
// Kiem tra nam nhuan
if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine($"{year} la nam nhuan.");
}
else
{
    Console.WriteLine($"{year} khong phai la nam nhuan.");
}
Console.ReadLine();
*/

/*
//Bai 8: Viet chuong trinh in ra bang cuu chuong tu 1 den 10.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Bang cuu chuong {i}:");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
Console.ReadLine();
*/

/*
//Bai 9: Viet chuong trinh tinh giai thua cua mot so nguyen duong n.
Console.Write("Nhap vao mot so nguyen duong: ");
int n = int.Parse(Console.ReadLine() ?? "");

// Tinh giai thua
long factorial = 1;
for (int i = 1; i <= n; i++)
{
    factorial *= i;
}

// Ket qua
Console.WriteLine($"Giai thua cua {n} la: {factorial}");
Console.ReadLine();
*/

/*
//Bai 10: Viet chuong trinh kiem tra xem mot so co phai la so nguyen to hay khong.
Console.Write("Nhap vao mot so nguyen: ");
int number = int.Parse(Console.ReadLine() ?? "");

// Kiem tra so nguyen to
bool isPrime = true;
if (number <= 1)
{
    isPrime = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

// Ket qua
if (isPrime)
{
    Console.WriteLine($"{number} la so nguyen to.");
}
else
{
    Console.WriteLine($"{number} khong phai la so nguyen to.");
}
Console.ReadLine();
*/



