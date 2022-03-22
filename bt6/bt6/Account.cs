using System;
using System.Globalization;
using System.Threading;
class Account
{

    private long _accountNumber;
    private string _name;
    private double _balance;
    private double _RATE = 0.035;

    public long AccountNumber { get => _accountNumber; set => _accountNumber = value < 0 ? 9999999 : value; }
    public string Name { get => _name; set => _name = value.Trim() != string.Empty ? value.Trim() : "Chưa xác định"; }
    public double Balance { get => _balance; set => _balance = value < 0 ? 50000 : value; }

    public Account()
    {
        AccountNumber = 9999999;
        Name = "Chưa xác định";
        Balance = 50000;
    }


    public Account(long accountNumber, string name)
    {
        AccountNumber = accountNumber;
        Name = name;
    }

    public Account(long accountNumber, string name, double balance)
    {
        AccountNumber = accountNumber;
        Name = name;
        Balance = balance;
    }

    public void Deposit()
    {
        bool check1 = true;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (check1)
        {

            Console.Write($"So tien ban muon chuyen {AccountNumber},{Name}: ");
            double amount = double.Parse(Console.ReadLine());
            if (amount < 0)
            {
                Console.WriteLine("Moi ban nhap lai");
            }
            else 
                Console.WriteLine("Chuyen tien khong thanh cong"); check1 = false;
        }
    }
    public void Withdraw()
    {
        bool check2 = true;
        double fee = 1.50;
        while (check2)
        {
            Console.Write($"So tien ban muon rut {AccountNumber},{Name}: ");
            double amount = double.Parse(Console.ReadLine());
            if ((amount < 0) && (amount + fee <= Balance))
            {
                Console.WriteLine("Moi ban nhap lai");
            }
            else Balance = Balance - (amount + fee); 
            Console.WriteLine("Rut tien thanh cong"); check2 = false;
        }
    }
    public void AddInterest()
    {
        Balance = Balance + Balance * _RATE;
        Console.WriteLine($"Tien lai cua tai khoan {AccountNumber},{Name}: {Balance}");
    }
    public void Tranfer(ref Account account2, double amount)
    {
        Balance -= amount;
        account2.Balance += amount;
        Console.WriteLine($"Ban vua chuyen tien vao tai khoan {account2.Name}");
    }
    public override string ToString()
    {
        return $"|{AccountNumber,15}|{Name,20}|{Balance,20}|";
    }
    public static void Title()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        line();
        Console.WriteLine($"|{"So tai khoan ",-15}|{"Chu tai khoan ",-20}|{"So tien",-20}|");
        line();
    }
    public static void line()
    {
        for (int i = 0; i < 59; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}