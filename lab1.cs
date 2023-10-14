// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
class lab1 {
static void Main1(string[] args) {
        while (true)
        {
            Console.WriteLine("Lab1:");
            Console.WriteLine("1. Sap xep 3 ki tu theo chieu nguoc lai");
            Console.WriteLine("2. Ve tam giac vuong can");
            Console.WriteLine("3. Viet truong trinh kiem tra ten dang nhap va mat khau");
            Console.WriteLine("4. Viet truong trinh kiem tra ten dang nhap va mat khau, sai ba lan thi dung lai");
            Console.WriteLine("5. Viet truong trinh tinh dien tich va the tich cua hinh cau tu ban kinh");
            Console.WriteLine("6. Viet truong trinh tinh ham y voi dau vao la khoang (a;b)");
            Console.WriteLine("7. Viet truong trinh chuyen doi thap phan sang nhi phan");
            Console.WriteLine("8. Viet truong trinh tim so nho nhat trong ba so su dung toan tu ba ngoi");
            Console.WriteLine("9. Viet truong trinh co menu tinh toan cho ba hinh khac nhau");
            Console.WriteLine("10. Viet truong trinh ve tam giac pascal");
            Console.WriteLine("11. Thoat");
            Console.Write("Chon mot tuy chon tu (1-11): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //cau1
                    cau1();
                    break;
                case 2:
                    //cau2
                    cau2();
                    break;
                case 3:
                    //cau3
                    cau3("hoan", "12345");
                    break;
                case 4:
                    //cau4
                    cau4("user", "password");
                    break;
                case 5:
                    //cau5
                    cau5();
                    break;
                case 6:
                    //cau6
                    Console.Write("Nhap gia tri a (so nguyen): ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Nhap gia tri b (so nguyen, b > a): ");
                    int b = int.Parse(Console.ReadLine());

                    if (b <= a)
                    {
                        Console.WriteLine("b phai lon hon a vui long nhap lai.");
                        return;
                    }

                    Console.WriteLine("Gia tri cua ham so y = x^2 + 4x - 3.5 trong khoang (" + a + ", " + b + "):");
                    Console.WriteLine("x \t y");
                    for (int x = a + 1; x < b; x++) // vong lap in ra gia tri cua x tu a den b
                    {
                        double y = cau6(x);
                        Console.WriteLine(x + "\t" + y);
                    }
                    break;
                case 7:
                    //cau7
                    Console.Write("Nhap mot so nguyen trong he thap phan: ");
                    int decimalNumber = int.Parse(Console.ReadLine());

                    string binaryNumber = DecimalToBinary(decimalNumber);

                    Console.WriteLine("So nhi phan tuong ung: " + binaryNumber);
                    break;
                case 8:
                    //cau8
                    cau8();
                    break;
                case 9:
                    //cau9
                    while (true)
                    {
                        Console.WriteLine("Chuong trinh tinh dien tich va chu vi:");
                        Console.WriteLine("1. Tinh dien tich va chu vi cua hinh tam giac");
                        Console.WriteLine("2. Tinh dien tich va chu vi cua hinh chu nhat");
                        Console.WriteLine("3. Tinh dien tich va chu vi cua hinh tron");
                        Console.WriteLine("4. Thoat");

                        Console.Write("Chon mot tuy chon tu (1-4): ");
                        int choices = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                CalculateTriangleAreaAndPerimeter();
                                break;
                            case 2:
                                CalculateRectangleAreaAndPerimeter();
                                break;
                            case 3:
                                CalculateCircleAreaAndPerimeter();
                                break;
                            case 4:
                                Console.WriteLine("Ket thuc chuong trinh.");
                                return;
                            default:
                                Console.WriteLine("Tuy chon khong hop le vui long chon lai.");
                                break;
                        }
                    }
                    break;
                case 10:
                    //cau10
                    Console.Write("Nhap so hang cho tam giac pascal: ");
                    int numRows = int.Parse(Console.ReadLine());
                    PrintPascalTriangle(numRows);
                    break;
                case 11:

                    Console.WriteLine("Ket thuc chuong trinh.");
                    return;
                default:
                    Console.WriteLine("Tuy chon khong hop le vui long chon lai.");
                    break;
            }














        }
}
//cau1 nhap 3 ki tu va hien thi theo chieu nguoc lai : input ABC output CBA : cmt ham lam gi, in, out la gif, cmt dong code co chuc nang gi
static void cau1()
{
    /*char c;
    c =Console.ReadKey().KeyChar;
    c =Console.ReadLine()[0];
    bool val = Char.TryParse(Console.ReadLine(),out c);
    */
    char letter1, letter2, letter3;
    Console.Write("Nhap ki tu dau tien:");
    letter1 = Convert.ToChar(Console.ReadLine());
    Console.Write("Nhap ki tu thu hai:");
    letter2 = Convert.ToChar(Console.ReadLine());
    Console.Write("Nhap ki tu thu ba:");
    letter3 = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("hien thi theo chieu nguoc lai: {0}, {1}, {2}", letter3, letter2, letter1);

}
/*2. Vẽ tam giác vuông cân tại điểm trái trên của
màn hình console với cạnh góc vuông được nhập
từ bàn phím.*/
static void cau2()
{
    Console.WriteLine("Nhap do dai canh goc vuong cua tam giac vuong: ");
    int doDaiCanh = int.Parse(Console.ReadLine());

    for (int i = 1; i <= doDaiCanh; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    Console.ReadKey(); // Dừng chương trình để xem kết quả
}
/*
3.Viết chương trình kiểm tra tên đăng nhập và mật
khẩu. Nếu nhập sai một trong hai thì cho người
dùng nhập lại đến khi đúng thì thoát chương trình.*/
static void cau3(string correctUsername, string correctPassword)
{
    //correctUsername = "hoan";
    //correctPassword = "12345";

    bool loggedIn = false;

    while (!loggedIn)
    {
        Console.Write("Nhap ten dang nhap: ");
        string username = Console.ReadLine();

        Console.Write("Nhap mat khau: ");
        string password = Console.ReadLine();

        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("Dang nhap thanh cong!");
            loggedIn = true;
        }
        else
        {
            Console.WriteLine("Ten dang nhap va mat khau khong dung. Vui long thu lai.\n");
        }
    }

    Console.WriteLine("Chuong trinh da thoat.");
}
/*4. Viết chương trình kiểm tra tên đăng nhập và mật
khẩu. Nếu nhập sai 3 lần thì in ra thông báo và
thoát chương trình.*/
static void cau4(string correctUsername = "user", string correctPassword = "password")
{


    int maxTries = 3;
    int attempts = 0;
    bool loggedIn = false;

    while (!loggedIn && attempts < maxTries)
    {
        Console.Write("Nhap ten dang nhap: ");
        string username = Console.ReadLine();

        Console.Write("Nhap mat khau: ");
        string password = Console.ReadLine();

        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("Dang nhap thanh cong!");
            loggedIn = true;
        }
        else
        {
            Console.WriteLine("Ten dang nhap hoac mat khau khong dung. Vui long thu lai.\n");
            attempts++;
        }
    }

    if (!loggedIn)
    {
        Console.WriteLine("Ban nhap sai qua " + maxTries + " lan. Chuong trinh se thoat.");
    }
}
/*
5. Viết chương trình tính diện tích và thể tích hình cầu với bán kính được nhập từ
bàn phím và số pi mặc định (pi có thể thay đổi khi gọi chương trình).
*/
static void cau5()
{



    double radius;
    double pi;
    // Nhap ban kinh tu ban phim
    Console.Write("Nhap ban kinh cua hinh cau: ");
    if (double.TryParse(Console.ReadLine(), out radius))
    {
        // Nhap gia tri cho pi
        Console.Write("Nhap gia tri cua pi (mac dinh là là 3.14159 ): ");
        string piInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(piInput))
        {
            pi = 3.14159; // Gia tri mac dinh 
        }
        else
        {
            if (double.TryParse(piInput, out pi) == false)
            {
                Console.WriteLine("Gia tri pi khong hop le. Su dung gia tri mac dinh la pi = 3.14159.");
                pi = 3.14159; // Gia tri mac dinh cho pi
            }
        }

        // Tinh dien tich va the tich
        double surfaceArea = 4 * pi * radius * radius;
        double volume = (4.0 / 3.0) * pi * radius * radius * radius;

        Console.WriteLine("Dien tich: " + surfaceArea);
        Console.WriteLine("The tich: " + volume);
    }
    else
    {
        Console.WriteLine("Ban kinh khong hop le vui long nhap lai.");
    }
}
/*8. Tìm số nhỏ nhất trong 3 số a, b, c (a, b, c có thể
có giá trị rất lớn) nhập từ bàn phím. Không dùng
câu lệnh if else, witch case.*/
static void cau8()
{
    Console.Write("Nhap so a: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("Nhap so b: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("Nhap so c: ");
    double c = double.Parse(Console.ReadLine());

    double min = (a < b) ? (a < c ? a : c) : (b < c ? b : c); // dung toan tu ba ngoi de so sanh voi bieu thuc: (a < b) ? (a < c ? a : c) : (b < c ? b : c) se so sanh a voi b và c, sau do tra ve gia tri nho nhat.

    Console.WriteLine("So nho nhat la: " + min);
}
/*cau6 Viết chương trình tính giá trị của hàm số y = x2 +
4x -3.5 với x thuộc (a, b) trong đó a và b là hai số
nguyên được nhập từ bàn phím và b luôn lớn hơn a.*/



static double cau6(int x)
{

    // Tính giá trị của hàm số y = x^2 + 4x - 3.5
    return x * x + 4 * x - 3.5;
}
/*7 Viết chương trình nhập vào một số trong hệ
thập phân và chuyển sang hệ nhị phân tương ứng.*/
static string DecimalToBinary(int decimalNumber)
{
    if (decimalNumber == 0)
    {
        return "0";
    }

    string binary = "";
    while (decimalNumber > 0) // khi số thập phân lớn hơn không thì tiếp tục vòng lặp
    {
        int remainder = decimalNumber % 2;
        binary = remainder + binary;
        decimalNumber /= 2;
    }

    return binary;
}
/*câu 9: Viết một chương trình có menu cho phép lựa
chọn tính diện tích và chu vi của một trong 3 hình:
hình tam giác, hình chữ nhật, hình tròn. Hằng số PI
là 3.1415.*/
static void CalculateTriangleAreaAndPerimeter()
{
    Console.Write("Nhap chieu cao cua tam giac: ");
    double height = double.Parse(Console.ReadLine());
    Console.Write("Nhap do dai canh day cua tam giac: ");
    double baseLength = double.Parse(Console.ReadLine());

    double area = 0.5 * height * baseLength;
    double perimeter = baseLength + 2 * Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseLength / 2, 2));

    Console.WriteLine("Dien tich hinh tam giac la: " + area);
    Console.WriteLine("Chu vi cua hinh tam giac la: " + perimeter);
}

static void CalculateRectangleAreaAndPerimeter()
{
    Console.Write("Nhap chieu dai cua hinh chu nhat: ");
    double length = double.Parse(Console.ReadLine());
    Console.Write("Nhap chieu rong cua hinh chu nhat: ");
    double width = double.Parse(Console.ReadLine());

    double area = length * width;
    double perimeter = 2 * (length + width);

    Console.WriteLine("Dien tich cua hinh chu nhat la: " + area);
    Console.WriteLine("Chu vi cua hinh chu nhat la: " + perimeter);
}

static void CalculateCircleAreaAndPerimeter()
{
    Console.Write("Nhap ban kinh hinh tron: ");
    double radius = double.Parse(Console.ReadLine());

    double area = Math.PI * Math.Pow(radius, 2);
    double perimeter = 2 * Math.PI * radius;

    Console.WriteLine("Dien tich cua hinh tron la: " + area);
    Console.WriteLine("Chu vi cua hinh tron la: " + perimeter);
}
/*10.Vẽ tam giác Pascal với số hàng nhập từ bàn
phím*/
static void PrintPascalTriangle(int numRows)
{
    for (int i = 0; i < numRows; i++)
    {
        int currentValue = 1;

        // Tạo khoảng trống để căn lề
        for (int j = 0; j < numRows - i; j++)
        {
            Console.Write("  ");
        }

        for (int j = 0; j <= i; j++)
        {
            Console.Write(currentValue.ToString().PadLeft(4)); // In giá trị và căn lề
            currentValue = currentValue * (i - j) / (j + 1);
        }

        Console.WriteLine();
    }
}
}
