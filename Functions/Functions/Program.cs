// See https://aka.ms/new-console-template for more information
using Functions;

Console.WriteLine("Hello, World!");
ClassRoom classRoom = new ClassRoom();
classRoom.FindLinq(3);

/*
 * Sayı tahmin oyunu:
 *   1. İki sayı arasında rastgele sayı seç
 *   2. Kullanıcıdan tahmin iste
 *   3. Karşılaştır ve yönlendir (Aşağı Yukarı Bildin)
 *   4. Bilemediyse 2. Adıma dön
 *   5. Bitir.
 */



//int targetNumber = getRandomNumber(min: 1, max: 100);
//string compareResult = string.Empty;
//do
//{
//    int suggestedNumber = getSuggestedNumberFromUser();
//    compareResult = compare(suggestedNumber, targetNumber);
//    Console.WriteLine(compareResult);
//} while (compareResult != "Bildin");


try
{
    Report report = new Report("C:\\x.xlsx");
    Console.WriteLine("Rapor oluştu");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}







string compare(int suggestedNumber, int targetNumber)
{
    throw new NotImplementedException();
}

int getSuggestedNumberFromUser()
{
    throw new NotImplementedException();
}

int getRandomNumber(int min, int max)
{
    throw new NotImplementedException();
}

bool isNumberEven(int number)
{
    return number % 2 == 0;
}