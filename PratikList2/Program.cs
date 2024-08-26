//Liste oluşturuldu.
List <string> coffes = new List<string>();

//kullanıcıdan 5 adet kahve isimi alınıp listeye eklendi
for  (int i = 0;i <5;i++)
{
    Console.Write($"Kahve {i+1}:");
    coffes.Add(Console.ReadLine());
}

//kahve isimleri yazdırıldı.
Console.WriteLine("--------------------------------------");
Console.WriteLine("Girilen Kahve İsimleri");
foreach(string item  in coffes)
{
    Console.WriteLine(item);
}