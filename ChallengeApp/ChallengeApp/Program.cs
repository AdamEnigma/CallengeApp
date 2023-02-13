// Tablica - przykład numer 1

using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

string[] dayOfWeek = new string[7];
dayOfWeek[0] = "poniedziałek";
dayOfWeek[1] = "wtorek";
dayOfWeek[2] = "środa";
dayOfWeek[3] = "czwartek";
dayOfWeek[4] = "piątek";
dayOfWeek[5] = "sobota";
dayOfWeek[6] = "niedziela";

// Tablica - przykład nr 2

string[] dayOfWeek2 = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };



// pętla FOR


// przykład z wykorzystaniem zmiennej "i"
//for(int i=0; i<7; i=i+1) // i=i+1 można zapisać i=++

// teraz wykorzystamy funkcję "LENGTH"

for (int i = 0; i < dayOfWeek.Length; i = i + 2)
{
    // Console.WriteLine(dayOfWeek[i]);
}

// Funkcja LISTA

List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");

for (int i = 0; i < dayOfWeeks.Count; i++)
{
    // Console.WriteLine(dayOfWeeks[i]);
}


// Jeszcze prostsze przedstawienie tablic za pomocą funkcji FOREACH

//foreach (var day in dayOfWeeks)
//{
    //  Console.WriteLine(day);
//}




    int number = 45945;
    string numberAsString = number.ToString();
    char[] letters = numberAsString.ToArray();

    int couter0 = 0;
    int couter1 = 0;
    int couter2 = 0;
    int couter3 = 0;
    int couter4 = 0;
    int couter5 = 0;
    int couter6 = 0;
    int couter7 = 0;
    int couter8 = 0;
    int couter9 = 0;

    foreach (char letter in letters)
    {
        if (letter == '0')
        {
            couter0++;
        }
        else if (letter == '1')
        {
            couter1++;
        }
        else if (letter == '2')
        {
            couter2++;
        }
        else if (letter == '3')
        {
            couter3++;
        }
        else if (letter == '4')
        {
            couter4++;
        }
        else if (letter == '5')
        {
            couter5++;
        }
        else if (letter == '6')
        {
            couter6++;
        }
        else if (letter == '7')
        {
            couter7++;
        }
        else if (letter == '8')
        {
            couter8++;
        }
        else if (letter == '9')
        {
            couter9++;
        }
        

    }
    Console.WriteLine(number);
    Console.WriteLine("liczba 0  " + "wystąpiła   " + couter0 + "razy");
    Console.WriteLine("liczba 1  " + "wystąpiła   " + couter1 + "razy");
    Console.WriteLine("liczba 2  " + "wystąpiła   " + couter2 + "razy");
    Console.WriteLine("liczba 3  " + "wystąpiła   " + couter3 + "razy");
    Console.WriteLine("liczba 4  " + "wystąpiła   " + couter4 + "razy");
    Console.WriteLine("liczba 5  " + "wystąpiła   " + couter5 + "razy");
    Console.WriteLine("liczba 6  " + "wystąpiła   " + couter6 + "razy");
    Console.WriteLine("liczba 7  " + "wystąpiła   " + couter7 + "razy");
    Console.WriteLine("liczba 8  " + "wystąpiła   " + couter8 + "razy");
    Console.WriteLine("liczba 9  " + "wystąpiła   " + couter9 + "razy");
