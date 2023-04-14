using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class DangNhap
{
	public const int ID = 1;
	private string userName;
	private string passWord;
	Account acc = new Account();



	public DangNhap()
	{
		userName = "";
		passWord = "";

	}

	public void Nhap()
	{
		Console.Write("Nhap Tai Khoan : ");
		userName = Console.ReadLine();
		Console.Write("Nhap Mat Khau : ");
		passWord = Console.ReadLine();
		acc.UserName = userName;
		acc.Password = passWord;

	}

	public void KiemTra(string tk, string mk)
	{
		if (acc.UserName == tk && acc.Password == mk)
		{
			Console.WriteLine("Dang Nhap Thanh Cong");
		}
		else
		{
			Console.WriteLine("Tai Khoan Hoac Mat Khau Khong Chinh Xac !");
		}
	}
}

