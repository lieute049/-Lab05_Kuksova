// Console.WriteLine("vvedite number: ");
// int number = int.Parse(Console.ReadLine());

// if (number > 0)
//     Console.WriteLine("number polozitelnoe.");
// else if (number < 0)
//     Console.WriteLine("number otrisat.");
// else
//     Console.WriteLine("number pavno zero.");


// Console.WriteLine("vvedite ball (0-100): ");
// int score = int.Parse(Console.ReadLine());

// if (score >= 91)
//     Console.WriteLine("osenka: otlisnio (5)");
// else if (score >= 71)
//     Console.WriteLine("osenka: good (4)");
// else if (score >= 51)
//     Console.WriteLine("osenka: ydovlet. (3)");
// else
//     Console.WriteLine("osenka: noydovlet. (2)");

// Console.WriteLine("vvedite kolvo posesenii (is 19): ");
// int attendance = int.Parse(Console.ReadLine());

// Console.WriteLine("vvedite sredni ball po praktike: ");
// double practiceGpa = double.Parse(Console.ReadLine());

// bool goodAttendance = attendance >= 14;
// bool goodGrades = practiceGpa >= 3.0;

// if (goodAttendance && goodGrades)
//     Console.WriteLine("+ exam razreson.");
// else if (!goodAttendance && goodGrades)
//     Console.WriteLine("- posesenii. nyzno otpabotat propysk.");
// else if (goodAttendance && !goodGrades)
//     Console.WriteLine("- nizki ball po praktike. nyzno peresdati raboti.");
// else
//     Console.WriteLine("- problems s posesiaemostiy, i s osenkoi."); 



// Console.WriteLine("vvedite number: ");
// int n = int.Parse(Console.ReadLine());

// string result = n % 2 == 0 ? "chetnoe" : "nechetnoe";
// Console.WriteLine(result);

// int age = 17;
// string status = age >= 18 ? "sovershennoletni" : "nesovershennoletni";
// Console.WriteLine(status);







// Console.WriteLine("menu:");
// Console.WriteLine("1. raspisanie");
// Console.WriteLine("2. osenki");
// Console.WriteLine("3. svaz s prepodom");
// Console.WriteLine("4. vihod");
// Console.Write("viberi punkt (1-4): ");

// string choice = Console.ReadLine();

// switch (choice)
// {
//     case "1": Console.WriteLine("raspisanie: ISP-243, kab. 102, 08:30"); break;
//     case "2": Console.WriteLine("osenki: ISRPO — 20, RMP — 35"); break;
//     case "3": Console.WriteLine("email: example@mail.ru"); break;
//     case "4": Console.WriteLine("dosvidaniya!"); break;
//     default:  Console.WriteLine($"oshibka: punkta «{choice}» net."); break;
// }


// Console.Write("vvedi den nedeli (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine());

// switch (dayNumber)
// {
//     case 1: case 2: case 3: case 4: case 5:
//         Console.WriteLine("rabochi den");
//         break;
//     case 6: case 7:
//         Console.WriteLine("vihodnoi");
//         break;
//     default:
//         Console.WriteLine("neverni nomer");
//         break;
// }


// Console.Write("vvedi mesac (1-12): ");
// int month = int.Parse(Console.ReadLine());

// switch (month)
// {
//     case 12: case 1: case 2:  Console.WriteLine("zima"); break;
//     case 3:  case 4: case 5:  Console.WriteLine("vesna"); break;
//     case 6:  case 7: case 8:  Console.WriteLine("leto"); break;
//     case 9:  case 10: case 11: Console.WriteLine("osen"); break;
//     default: Console.WriteLine("neverni mesac"); break;
// }







// Random random = new Random();
// int secret = random.Next(1, 101);
// int attempts = 0;
// bool guessed = false;

// Console.WriteLine("ugadai number (1-100)");
// Console.WriteLine("ya zagadal number. poprobui ugadat!");

// while (!guessed)
// {
//     Console.Write("tvoi variant: ");
//     string input = Console.ReadLine();

//     if (!int.TryParse(input, out int guess))
//     {
//         Console.WriteLine("eto ne number! poprobui eshe.");
//         continue;
//     }

//     if (guess < 1 || guess > 100)
//     {
//         Console.WriteLine("number dolzen bit ot 1 do 100!");
//         continue;
//     }

//     attempts++;

//     if (guess < secret)
//     {
//         int diff = secret - guess;
//         Console.WriteLine($"bolshe! {GetHint(diff)}\n");
//     }
//     else if (guess > secret)
//     {
//         int diff = guess - secret;
//         Console.WriteLine($"menshe! {GetHint(diff)}\n");
//     }
//     else
//     {
//         guessed = true;
//     }
// }

// string result = attempts <= 7
//     ? $"otlicni rezultat! vsego {attempts} popitok."
//     : $"number naiden za {attempts} popitok. mozno luchshe!";

// Console.WriteLine($"pravilno! zagadannoe number: {secret}");
// Console.WriteLine(result);

// static string GetHint(int diff)
// {
//     switch (diff)
//     {
//         case <= 5:  return "ocen goryacho!";
//         case <= 15: return "goryacho!";
//         case <= 30: return "teplo";
//         default:    return "holodno";
//     }
// }






Console.Write("parol: ");
string p1 = Console.ReadLine();
Console.Write("podtverzdenie: ");
string p2 = Console.ReadLine();
Console.WriteLine(p1 == p2 ? "parol prinyat" : "parol ne prinyat");


int age = int.Parse(Console.ReadLine());
Console.WriteLine(age >= 18 ? "dostup razreshen" : "dostup zapreshen");

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
string op = Console.ReadLine();

switch (op)
{
    case "+": Console.WriteLine($"{a} + {b} = {a + b}"); break;
    case "-": Console.WriteLine($"{a} - {b} = {a - b}"); break;
    case "*": Console.WriteLine($"{a} * {b} = {a * b}"); break;
    case "/":
        Console.WriteLine(b != 0 ? $"{a} / {b} = {a / b}" : "delenie na nul!");
        break;
    default: Console.WriteLine("neizvestnaya operaciya"); break;
}


int s = 0;
for (int i = 0; i < 3; i++)
{
    int x = int.Parse(Console.ReadLine());
    if (x > 0) s += x;
}
Console.WriteLine(s);



string path = Console.ReadLine().ToUpper();

if (path == "A")
{
    string answer = Console.ReadLine().ToLower();
    Console.WriteLine(answer == "riba" ? "drakon propuskaet!" : "drakon syel vas!");
}
else if (path == "B")
{
    string door = Console.ReadLine();
    Console.WriteLine(door == "1" ? "sokrovischa Dungeon Master!" : "lovushka s shipami!");
}
else Console.WriteLine("neverni put");