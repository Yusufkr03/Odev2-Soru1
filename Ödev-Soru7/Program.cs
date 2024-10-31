// See https://aka.ms/new-console-template for more information
Console.WriteLine("Çift mi Tek mi olduğunu öğrenmek istediğiniz sayıyıy giriniz");
int sayi = int.Parse(Console.ReadLine());
int kontrol = sayi % 2;
if (kontrol == 0)
{
    Console.WriteLine("Girdiğiniz sayı çift");
}
else
{
    Console.WriteLine("Girdiğiniz Sayı Tek");
}
Console.ReadKey();