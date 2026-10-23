Console.WriteLine("vvedite number: ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
    Console.WriteLine("number polozitelnoe.");
else if (number < 0)
    Console.WriteLine("number otrisat.");
else
    Console.WriteLine("number pavno zero.");


Console.WriteLine("vvedite ball (0-100): ");
int score = int.Parse(Console.ReadLine());

if (score >= 91)
    Console.WriteLine("osenka: otlisnio (5)");
else if (score >= 71)
    Console.WriteLine("osenka: good (4)");
else if (score >= 51)
    Console.WriteLine("osenka: ydovlet. (3)");
else
    Console.WriteLine("osenka: noydovlet. (2)");

Console.WriteLine("vvedite kolvo posesenii (is 19): ");
int attendance = int.Parse(Console.ReadLine());

Console.WriteLine("vvedite sredni ball po praktike: ");
double practiceGpa = double.Parse(Console.ReadLine());

bool goodAttendance = attendance >= 14;
bool goodGrades = practiceGpa >= 3.0;

if (goodAttendance && goodGrades)
    Console.WriteLine("+ exam razreson.");
else if (!goodAttendance && goodGrades)
    Console.WriteLine("- posesenii. nyzno otpabotat propysk.");
else if (goodAttendance && !goodGrades)
    Console.WriteLine("- nizki ball po praktike. nyzno peresdati raboti.");
else
    Console.WriteLine("- problems s posesiaemostiy, i s osenkoi."); 