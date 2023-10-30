using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesBwBr
{
    class Program
    {
        static void Main(string[] args)
        {
            //задача 2
            //Random random = new Random();
            //int.TryParse(Console.ReadLine(), out int num);

            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < num; i++)
            //    {
            //        bw.Write(random.NextDouble() + random.Next(0, 101));
            //    }
            //}
            //using (var n = File.OpenRead("n"))
            //using (var br = new BinaryReader(n))

            //{
            //    double S = 1;

            //    for (int i = 1; n.Position < n.Length; i++)
            //    {
            //        var number = br.ReadDouble();
            //        S *= number;
            //        Console.WriteLine(number);


            //    }
            //    Console.WriteLine(S);

            //}

            //задача 3
            //Random random = new Random();
            //int.TryParse(Console.ReadLine(), out int n);
            //int.TryParse(Console.ReadLine(), out int m);

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        bw.Write(random.Next(0, 101));
            //    }
            //}
            //using (var f = File.OpenRead("f"))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //using (var br = new BinaryReader(f))
            //{
            //    while(f.Position < f.Length)
            //    {
            //        var number = br.ReadInt32();
            //        if(number % m == 0 && number % n != 0)
            //        {
            //            bw.Write(number);
            //            Console.WriteLine(number);
            //        }
            //    }
            //}

            //задача 5
            //    Random random = new Random();

            //    using (var f = File.Create("f"))
            //    using (var bw = new BinaryWriter(f))
            //    {
            //        for (int i = 0; i < 50; i++)
            //        {
            //            bw.Write(random.Next(0, 10));
            //        }
            //    }
            //    List<int> list = new List<int>();
            //    using (var f = File.OpenRead("f"))
            //    using (var g = File.Create("g"))
            //    using (var bw = new BinaryWriter(g))
            //    using (var br = new BinaryReader(f))
            //    {

            //        for(int i = 0; i < 50;i++)
            //        {
            //            var number = br.ReadInt32();
            //            if (!list.Contains(number))
            //            {
            //                list.Add(number);
            //                bw.Write(number);
            //                Console.WriteLine(number);

            //            }
            //        }
            //    }

            //задача 6
            //Random random = new Random();
            //int.TryParse(Console.ReadLine(), out int k);

            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        bw.Write(random.Next(0, 101));
            //    }
            //}
            //using (var n = File.OpenRead("n"))
            //using (var m = File.Create("m"))
            //using (var bw = new BinaryWriter(m))
            //using (var br = new BinaryReader(n))
            //{
            //    while (n.Position < n.Length)
            //    {
            //        var number = br.ReadInt32();
            //        if (number % k == 0)
            //        {
            //            bw.Write(number);
            //            Console.WriteLine(number);
            //        }
            //    }
            //}
            ////задача 7
            //Random random = new Random();


            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        bw.Write(random.Next(0, 101));
            //    }
            //}
            //using (var n = File.OpenRead("n"))

            //using (var br = new BinaryReader(n))
            //{
            //    int min = int.MaxValue;
            //    int max = int.MinValue;
            //    for(int i = 0; i < 50;i++)
            //    {
            //        var number = br.ReadInt32();
            //        if (number > max)
            //            max = number;
            //        if(number < min)
            //            min = number;

            //    }
            //    int s = max + min;

            //    Console.WriteLine(s);
            //}

            //задача 8
            //Random random = new Random();
            //int.TryParse(Console.ReadLine(), out int k);

            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < k; i++)
            //    {
            //        bw.Write(random.Next(1, 10));
            //    }
            //}
            //using (var n = File.OpenRead("n"))
            //using (var m = File.Create("m"))
            //using (var bw = new BinaryWriter(m))
            //using (var br = new BinaryReader(n))
            //{
            //    int S = 1;

            //    while( n.Position < n.Length)
            //{
            //    var number = br.ReadInt32();
            //    S *= number; 
            //    bw.Write(S);
            //    Console.WriteLine(S);


            //}
            //}

            //задача 9
            //Random random = new Random();
            //int.TryParse(Console.ReadLine(), out int k);

            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        bw.Write(random.Next(0, 101));
            //    }
            //}
            //using (var n = File.OpenRead("n"))
            //using (var m = File.Create("m"))
            //using (var bw = new BinaryWriter(m))
            //using (var br = new BinaryReader(n))
            //{
            //    while (n.Position < n.Length)
            //    {
            //        var number = br.ReadInt32();
            //        if (number % k != 0)
            //        {
            //            bw.Write(number);
            //            Console.WriteLine(number);
            //        }
            //    }
            //}




            //бонусное задание
            //using (var file = File.OpenRead("hot.db"))
            //using (var br = new BinaryReader(file))
            //{
            //    string paket = br.ReadString();
            //    Console.WriteLine(paket);
            //    int countpic = br.ReadByte();
            //    Console.WriteLine(countpic);

            //    string[] arrstr = new string[countpic];

            //    for (int i = 0; i < countpic; i++)
            //    {
            //        string nameFile = br.ReadString();
            //        string rash = br.ReadString();
            //        string summa = nameFile + rash;
            //        arrstr[i] = summa;
            //        Console.WriteLine(summa);
            //    }
            //    List<byte[]> bytes = new List<byte[]>();

            //    for (int i = 0; i < countpic; i++)
            //    {
            //        int countbyte = br.ReadInt32();
            //        bytes.Add(br.ReadBytes(countbyte));

            //    }
            //    for (int i = 0; i < countpic; i++)
            //    {
            //        File.WriteAllBytes(arrstr[i], bytes[i]);
            //    }

            //}

            //задача 10
            //    Random random = new Random();


            //    using (var f = File.Create("f"))
            //    using (var bw = new BinaryWriter(f))
            //    {
            //        for (int i = 0; i < 10; i++)
            //        {
            //            bw.Write(random.Next(0, 30));
            //        }
            //    }
            //    using (var f = File.OpenRead("f"))

            //    using (var br = new BinaryReader(f))
            //    {
            //        int count = 0;
            //        while (f.Position < f.Length)
            //        {
            //            var number = br.ReadInt32();

            //            if (number / 2 % 2 != 0 && number % 2 ==0)
            //            {
            //                count++;
            //            }
            //            Console.WriteLine(number);
            //        }
            //        Console.WriteLine(count);
            //    }

            //задача 11
            //Random random = new Random();

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        bw.Write(random.Next(1, 30));
            //    }
            //}
            //using (var f = File.OpenRead("f"))

            //using (var br = new BinaryReader(f))
            //{
            //    int count = 0;
            //    while (f.Position < f.Length)
            //    {
            //        var number = br.ReadInt32();

            //        if (Math.Sqrt(number) % 2 != 0)
            //        {
            //            count++;
            //        }
            //        Console.WriteLine(number);
            //    }
            //    Console.WriteLine(count);
            //}




            //залача 12
            //Random random1 = new Random();

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        bw.Write(random1.NextDouble() + random1.Next(-100, 101));
            //    }
            //}
            //using (var f = File.OpenRead("f"))

            //using (var br = new BinaryReader(f))
            //{
            //    int count = -1;
            //    double max = double.MinValue;
            //    while (f.Position < f.Length)
            //    {
            //        var number = br.ReadDouble();

            //        if (Math.Abs(number) > max && count < 0)
            //        {
            //            max = number;
            //            
            //        }
            //        count *= -1;
            //        Console.WriteLine(number);

            //    }
            //    Console.WriteLine(max);
            //}

            //задача 13
            //Random random = new Random();

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        bw.Write(random.Next(0, 10));
            //    }
            //}
            //using (var f = File.OpenRead("f"))

            //using (var br = new BinaryReader(f))
            //{


            //    while (f.Position < f.Length)
            //    {
            //        var number = br.ReadInt32();


            //        Console.WriteLine(number);

            //    }
            //    Console.WriteLine("______");

            //}
            //List<int> list = new List<int>();
            //using (var f = File.OpenRead("f"))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //using (var br = new BinaryReader(f))
            //{

            //    while (f.Position < f.Length)
            //    {
            //        var number = br.ReadInt32();
            //        if (!list.Contains(number))
            //        {
            //            list.Add(number);
            //            bw.Write(number);
            //            Console.WriteLine(number);

            //        }
            //    }
            //}

            //задача 14
            //Random random = new Random();
            //int.TryParse(Console.ReadLine(), out int k);


            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < k; i++)
            //    {
            //        bw.Write(random.NextDouble() + random.Next(-50, 51));
            //    }
            //}


            //double number = 0;
            //using (var f = File.OpenRead("f"))
            //using (var br = new BinaryReader(f))
            //{
            //    double first = br.ReadDouble();
            //    f.Seek(-8, SeekOrigin.End);
            //    double lastg = br.ReadDouble();
            //    double summ = first - number;
            //    Console.WriteLine(summ);
            //}

            //задачав 15
            //Random random = new Random();
            //int.TryParse(Console.ReadLine(), out int k);


            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{

            //    for (int i = 0; i < k; i++)
            //    {
            //        bw.Write(random.Next(0, 101));
            //    }
            //}

            //using (var f = File.OpenRead("f"))
            //using (var g = File.Create("g"))
            //using (var br = new BinaryReader(f))
            //using (var bw = new BinaryWriter(g))
            //{
            //    for (int i = 0; i < k; i+=2)
            //    {
            //        int number = br.ReadInt32();
            //        int number1 = br.ReadInt32();

            //        bw.Write(number1 * number);
            //        Console.WriteLine(number * number1);
            //    }
            //}


            //13.2
            //задача 1
            //Console.WriteLine("Введите кол-во пассажиров");
            //int.TryParse(Console.ReadLine(), out int pass);
            //Console.WriteLine("Введите число m");
            //int.TryParse(Console.ReadLine(), out int m);
            //using (var bagazh = File.Create("bagazh"))
            //using (var bw = new BinaryWriter(bagazh))
            //{
            //    for(int i = 1; i < pass; i++)
            //    {
            //        int.TryParse(Console.ReadLine(), out int countv);
            //        bw.Write(countv);
            //        double.TryParse(Console.ReadLine(), out double massav);
            //        bw.Write(massav);
            //    }

            //}

            //using (var bagazh = File.OpenRead("bagazh"))
            //using (var br = new BinaryReader(bagazh))
            //{
            //    int count1 = 0;//число пассажиров, имеющих более 2-х вещей
            //    double massapasss = 0;//масса вещей всех пассажиров
            //    int countVsezV = 0; //кол-во всех вещей пассажиров
            //    int count2 = 0;//число пассажиров, количество вещей которых превосходит среднее
            //    //a
            //    for(int i =0;  i < pass; i++)
            //    {
            //        int countv = br.ReadInt32();//кол-во вещей
            //        double massav = br.ReadDouble();//масса вещей(кг)
            //        massapasss += massav;//масса всех вещей всех пассажиров
            //        countVsezV += countv;//кол-во всех вещей всех пассажиров

            //    }
            //    double sredMassVsexV = massapasss / countVsezV;// общая средняя масса одной вещи 
            //    double sredCountVsexV = countVsezV / pass; //среднее количество всех вещей всех пассажиров
            //    bagazh.Position = 0;
            //    for (int i = 0; i < pass; i++)
            //    {
            //        int countv = br.ReadInt32();//кол-во вещей
            //        double massav = br.ReadDouble();//масса вещей(кг)
            //        if (Math.Abs(sredMassVsexV - massav / countv) < m)
            //        {
            //            Console.WriteLine("Багаж, средняя масса отличается на" + m + " кг от общ массы 1-ой вещи");
            //            Console.WriteLine(countv);
            //            Console.WriteLine(massav);
            //        }
            //    }
            //    //б
            //    bagazh.Position = 0;
            //    for (int i = 0; i < pass; i ++)
            //    {
            //        int countv = br.ReadInt32();//кол-во вещей
            //        double massav = br.ReadDouble();//масса вещей(кг)

            //        if (countv > 2)
            //            count1++;//число пассажиров, имеющих более 2-х вещей
            //        if (countv > sredCountVsexV)
            //            count2++; //число пассажиров, количество вещей которых превосходит среднее
            //    }
            //    Console.WriteLine("Число пассажиров, имеющих более 2-х вещей: " + count1);
            //    Console.WriteLine("число пассажиров, количество вещей которых превосходит среднее: " + count2);

            //    //в
            //    bagazh.Position = 0;
            //    for (int i = 0; i < pass; i++)
            //    {
            //        int countv = br.ReadInt32();//кол-во вещей
            //        double massav = br.ReadDouble();//масса вещей(кг)

            //        if (countv == 1 && massav < m)
            //            Console.WriteLine("Имеется пассажир, у которого багаж состоит из 1-й вещи массой менее " + m);                       
            //    }

            //}

            //задача 2
            //Console.WriteLine("Введите кол-во книг");
            //int.TryParse(Console.ReadLine(), out int book);
            //using (var bibl = File.Create("bibl"))
            //using (var bw = new BinaryWriter(bibl))
            //{
            //    for(int i = 0; i < book; i++)
            //    {
            //        Console.WriteLine("Автор: ");
            //        string avtor = Console.ReadLine();
            //        bw.Write(avtor);
            //        Console.WriteLine("Название: ");
            //        string name = Console.ReadLine();
            //        bw.Write(name);
            //        Console.WriteLine("Год издания: ");
            //        int.TryParse(Console.ReadLine(), out int year);
            //        bw.Write(year);
            //    }
            //}

            //using (var bibl = File.OpenRead("bibl"))
            //using (var br = new BinaryReader(bibl))
            //{
            //    //a
            //    List<string> names = new List<string>();
            //    Console.WriteLine("Введите автора");
            //    string avtorsearch = Console.ReadLine();
            //    for(int i = 0; i < book; i++)
            //    {
            //        string avtor = br.ReadString();
            //        string name = br.ReadString();
            //        int year = br.ReadInt32();
            //        if(avtorsearch == avtor)
            //        {
            //            if(year >= 1960)
            //            {
            //                names.Add(name);

            //            }
            //        }
            //    }
            //    Console.WriteLine("Книги, изданные с 1960 г." );

            //    foreach(string name in names)
            //    {
            //        Console.WriteLine($"{name}");
            //    }
            //    //b
            //    bibl.Position = 0;
            //    for (int i = 0; i < book; i++)
            //    {
            //        string avtor = br.ReadString();
            //        string name = br.ReadString();
            //        int year = br.ReadInt32();
            //        if (name == "Информатика")
            //        {
            //            Console.WriteLine("Информатика: " + avtor + year);
            //        }
            //    }

            //задача 3

            //    int.TryParse(Console.ReadLine(), out int sotrudnik);
            //using (var t = File.Create("t"))
            //using (var bw = new BinaryWriter(t))
            //{
            //    for (int i = 0; i < sotrudnik; i++)
            //    {
            //        Console.WriteLine("Номер телефона: ");
            //        string nomer = Console.ReadLine();
            //        bw.Write(nomer);
            //        Console.WriteLine("ФИО: ");
            //        string fio = Console.ReadLine();
            //        bw.Write(fio);
            //    }
            //}

            //using (var t = File.OpenRead("t"))
            //using (var br = new BinaryReader(t))
            //{

            //    Console.WriteLine("Введите ФИО");
            //    string fiosearch = Console.ReadLine();
            //    for (int i = 0; i < sotrudnik; i++)
            //    {
            //        string nomer = br.ReadString();
            //        string fio = br.ReadString();


            //        if (fiosearch == fio)
            //        {
            //            Console.WriteLine($"{nomer} {fiosearch}");
            //        }

            //    }

            //}

            //задача 4
            //int.TryParse(Console.ReadLine(), out int dats);
            //using (var data = File.Create("data"))
            //using (var bw = new BinaryWriter(data))
            //{
            //    for (int i = 0; i < dats; i++)
            //    {
            //        Console.WriteLine("Дата: ");
            //        string data1 = Console.ReadLine();
            //    }
            //}

            //using (var t = File.OpenRead("t"))
            //using (var br = new BinaryReader(t))
            //{
            //    string fiosearch = Console.ReadLine();
            //    for (int i = 0; i < dats; i++)
            //    {
            //        string data1 = br.ReadString();
            //        char[] splitter = new char[] { '.' };

            //        string[] strings = data1.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            //        foreach (string s in strings)
            //        {

            //        }

            //    }

            //}




        }
    }
}
