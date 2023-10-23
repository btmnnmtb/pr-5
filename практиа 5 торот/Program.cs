using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.IO;


using пр_5__;
using System.Security.Cryptography.X509Certificates;

int sum = 0;

string chasti = " ";

void menu()
{

    Console.WriteLine("Заказ тортов в ГосМосРосТорт");
    Console.WriteLine("Выберите параметры торта");
    Console.WriteLine("____________________________");
    Console.WriteLine("  Форма торта");
    Console.WriteLine("  Размер торта");
    Console.WriteLine("  Вкус коржей");
    Console.WriteLine("  Кол-во коржей");
    Console.WriteLine("  Глазурь");
    Console.WriteLine("  Декор");
    Console.WriteLine("  Конец заказов");
    Console.WriteLine("");
    Console.WriteLine("Цена:" + sum);
    Console.WriteLine();


    Console.Write("Ваш торт:" + chasti);



}

ConsoleKeyInfo key;

do
{
    Console.Clear();

    menu();
    key = Console.ReadKey();


    SR_menu sr_menu = new SR_menu();
    sr_menu.minstrel = 3;
    sr_menu.maxstrel = 9;
    int pos = sr_menu.sr_menu();
    if (pos == 3)
    {
        Console.Clear();
        Console.WriteLine("Для выхлда нажмите Escape");
        Console.WriteLine("Выбери форму:");
        Console.WriteLine("---------------------------");
        Console.WriteLine("  Круг - 300 руб");
        Console.WriteLine("  Квадрат - 350 руб");
        Console.WriteLine("  Ромб - 350 руб");
        Console.WriteLine("  Пентограмма - 666 руб ");

        new SR_menu();
        sr_menu.minstrel = 3;
        sr_menu.maxstrel = 6;
        int pod_po = sr_menu.sr_menu();
        if (pod_po == -1)
        {
            continue;
        }
        if (pod_po == 3)
        {
            sum = 0 + 320;

            chasti = chasti + " Круг,";



        }
        if (pod_po == 4)
        {
            sum = 0 + 350;
            chasti = chasti + " Квадрат,";
        }
        if (pod_po == 5)
        {
            chasti = chasti + " Ромб,";
            sum = 0 + 350;
        }
        if (pod_po == 6)
        {
            chasti = chasti + " Пентаграмма,";
            sum = 0 + 666;
        }

    }




















    if (pos == 4)
    {
        Console.Clear();
        Console.WriteLine("Для выхлда нажмите Escape");
        Console.WriteLine("Выбери размер:");
        Console.WriteLine("__________________________ ");
        Console.WriteLine("  Маленький - 600 руб");
        Console.WriteLine("  Средний - 1000 руб");
        Console.WriteLine("  Большой - 1500 руб");
        new SR_menu();
        sr_menu.minstrel = 3;
        sr_menu.maxstrel = 5;
        int pod_po = sr_menu.sr_menu();
        if (pod_po == 3)
        {
            sum = sum + 600;
            chasti = chasti + " Маленький размер(диаметр 15 см),";
        }
        else if (pod_po == 4)
        {
            sum = sum + 1000;
            chasti = chasti + " Средний размер(диаметр 30 см),";
        }
        if (pod_po == 5)
        {
            sum = sum + 1000;
            chasti = chasti + " Большой рамер (диаметр 60 см),";

        }

    }
    if (pos == 5)
    {
        Console.Clear();
        Console.WriteLine("Для выхлда нажмите Escape");
        Console.WriteLine("Выбери вкус коржей:");
        Console.WriteLine("___________________________ ");
        Console.WriteLine("  Клубничный - 500 руб");
        Console.WriteLine("  Банановый - 600 руб");
        Console.WriteLine("  Ванильный - 550 руб");
        new SR_menu();
        sr_menu.minstrel = 3;
        sr_menu.maxstrel = 5;
        int pod_po = sr_menu.sr_menu();
        if (pod_po == 3)
        {
            sum = sum + 500;
            chasti = chasti + " Клубничный вкус коржей,";
        }
        if (pod_po == 4)
        {
            sum = sum + 600;
            chasti = chasti + " Банановый вкус коржей,";
        }
        if (pod_po == 5)
        {
            sum = sum + 550;
            chasti = chasti + " Ванильный вкус коржей,";
        }

    }

    if (pos == 6)
    {
        Console.Clear();
        Console.WriteLine("Для выхлда нажмите Escape");
        Console.WriteLine("Выбери кол-во коржей:");
        Console.WriteLine("___________________________ ");
        Console.WriteLine("  3 - 300 руб");
        Console.WriteLine("  5 - 500 руб");
        Console.WriteLine("  6 - 600 руб");
        new SR_menu();
        sr_menu.minstrel = 3;
        sr_menu.maxstrel = 5;
        int pod_po = sr_menu.sr_menu();
        if (pod_po == 3)
        {
            sum = sum + 300;
            chasti = chasti + " 3 коржа,";
        }
        if (pod_po == 4)
        {
            sum = sum + 500;
            chasti = chasti + " 5 коржей,";

        }
        if (pod_po == 5)
        {
            sum = sum + 600;
            chasti = chasti + " 6 коржей,";

        }
    }
    if (pos == 7)
    {
        Console.Clear();
        Console.WriteLine("Для выхлда нажмите Escape");
        Console.WriteLine("Выбери глазурь:");
        Console.WriteLine("___________________________ ");
        Console.WriteLine("  Шоколад - 150 руб");
        Console.WriteLine("  Кокосовая стружка - 300 руб");
        Console.WriteLine("  Мармелад - 350 руб");
        new SR_menu();
        sr_menu.minstrel = 3;
        sr_menu.maxstrel = 5;
        int pod_po = sr_menu.sr_menu();
        if (pod_po == 3)
        {
            sum = sum + 150;
            chasti = chasti + " Шоколадная глазурь,";
        }
        if (pod_po == 4)
        {
            sum = sum + 300;
            chasti = chasti + " Кокосовая стружка,";
        }
        if (pod_po == 5)
        {
            sum = sum + 150;
            chasti = chasti + " Мармеладная глазурь,";
        }

    }
    if (pos == 8)
    {
        Console.Clear();
        Console.WriteLine("Для выхлда нажмите Escape");
        Console.WriteLine("Выбери декор:");
        Console.WriteLine("___________________________ ");
        Console.WriteLine("  Шоколад - 350 руб");
        Console.WriteLine("  Ваниль - 355 руб");
        Console.WriteLine("  Ягоды - 370 руб");

        new SR_menu();
        sr_menu.minstrel = 3;
        sr_menu.maxstrel = 5;
        int pod_po = sr_menu.sr_menu();
        if (pod_po == 3)
        {
            sum = sum + 350;
            chasti = chasti + " Шоколадный декор";
        }
        if (pod_po == 4)
        {
            sum = sum + 355;
            chasti = chasti + " Ванильный  декор";
        }
        if (pod_po == 5)
        {
            sum = sum + 370;
            chasti = chasti + " Ягдный декор";

        }


    }
    if (pos == 9)
    {

        Console.Clear();
        Console.WriteLine("Спасибо за заказ в ГосМосРосТорт. Если вы хотите сделать  еще один заказ нажмите Enter");
        Console.WriteLine("Если вы закончили заказы нажмите Escape ");
        Console.WriteLine("Цена:" + sum);
        Console.WriteLine();
        Console.Write("Ваш торт:" + chasti);
        string con_sum = Convert.ToString(sum);
        File.WriteAllText("D:\\Рабочий стол\\История заказов.txt", con_sum + chasti);
        

            string co_sum = Convert.ToString(sum);
            File.AppendAllText("D:\\Рабочий стол\\История заказов.txt", "\n" + co_sum + chasti);
        



























        key = Console.ReadKey();
        sum = 0;
        chasti = " ";
        if (key.Key == ConsoleKey.Enter) ;



    }




} while (key.Key != ConsoleKey.Escape);