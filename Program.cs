using System.Net.Mail;
using System.Reflection.Metadata;
using modul4_103022300107;

while (true)
{
    Console.WriteLine("Pilih Menu");
    Console.WriteLine("1.Kode Produk");
    Console.WriteLine("2.Keluar");

    //string pilihan = Console.ReadLine();

    //switch (pilihan)
    //{
    //    case "1":

    //        HandleKodeProduk();
    //    default:
    //        Console.WriteLine("Pilihan Tidak Valid");
    //        break;
    //}
    HandleKodeProduk();
}
static void HandleKodeProduk()
{
    KodeProduk kodeProduk = new KodeProduk();
    Console.Write("Masukan Nama Produk :");
    string produk = Console.ReadLine();
    string kode = kodeProduk.getKodeProduk(produk);
    Console.WriteLine($"Kode produk untuk {produk} adalah {kode}");
}
