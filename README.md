# Практическая работа №5

ФИО: Куксова Софья  
Группа: ИСП-243  
Дата: 23.10.2026

 Что изучено

- if / else — общее ветвление и сложные условия
- switch / case — выбор по конкретному значению
- тернарный оператор ? : — короткая запись для двух вариантов
- логические операторы &&, ||, !
- int.TryParse — безопасное преобразование
- Random.Next — генерация случайных чисел

 Структура проекта

- GuessNumber/Program.cs — все задания и игра
- img/ — скриншоты
- README.md — этот файл

 Фрагмент кода

csharp
static string GetHint(int diff)
     switch (diff)
     {
         case <= 5:  return "ocen goryacho!";
         case <= 15: return "goryacho!";
         case <= 30: return "teplo";
         default:    return "holodno";
     }
 

