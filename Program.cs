using System.Net.Mail;
using System.Reflection.Metadata;
using modul4_103022300107;

while (true)
{
    Console.WriteLine("Pilih Menu");
    Console.WriteLine("1.Kode Produk");
    Console.WriteLine("2.Fan Laptop");
    Console.WriteLine("3.Keluar");
    Console.Write("Masukan Pilihan :");
    string pilihan = Console.ReadLine();

    switch (pilihan)
    {
        case "1":

            HandleKodeProduk();
            break;
        case "2":
            HandleFanLaptop();
            break;
        default:
            Console.WriteLine("Pilihan Tidak Valid");
            break;
    }

}
static void HandleKodeProduk()
{
    KodeProduk kodeProduk = new KodeProduk();
    Console.Write("Masukan Nama Produk :");
    string produk = Console.ReadLine();
    string kode = kodeProduk.getKodeProduk(produk);
    Console.WriteLine($"Kode produk untuk {produk} adalah {kode}");
}
static void HandleFanLaptop()
{
    FanLaptop laptop = new FanLaptop();
    laptop.ShowState();

    string command = Console.ReadLine();
    switch (command)
    {
        case "Turbo":
            laptop.Turbo();
            break;
        case "Quite":
            laptop.Quite();
            break;
        case "Performance":
            laptop.Performance();
            break;
        case "Balanced":
            laptop.Balanced();
            break;
        default:
            Console.WriteLine("Perintah tidak valid Silahkan coba lagi");
            break;
    }
    laptop.ShowState();
}