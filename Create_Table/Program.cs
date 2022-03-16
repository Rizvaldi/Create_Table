using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Table
{
        class Program
        {
            static void Main(string[] args)
            {
                new Program().CreateTabel();
            }

            public void Connecting()
            {
                using (
                    SqlConnection con = new SqlConnection("data source=MSI\\MSSQLSERVER02;Database=ProdiTI;User ID=sa;Password=123")
                    )

                {
                    con.Open();
                    Console.WriteLine("Berhasil Terhubung ke Database");
                }
            }
            public void CreateTabel()
            {
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection("data source=MSI\\MSSQLSERVER02;Database=ProdiTI; Integrated Security = TRUE");
                    con.Open();

                    SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba (NIM char(12) not null primary key, Nama varchar(50), " +
                    "Alamat varchar(255), Jenis_Kelamin char(1))", con);
                    cm.ExecuteNonQuery();

                    Console.WriteLine("Tabel sukses dibuat");
                    Console.ReadKey();
                } catch (Exception e)
                {
                    Console.WriteLine("Oops, sepertinya ada yang salah.  " + e);
                    Console.ReadKey();
                }finally
                {
                    con.Close();
                }
            }
        }
    }
