//Console.WriteLine("Doğum yılınızı giriniz.");

//var input = int.Parse(Console.ReadLine());
//var nowYear = DateTime.Now.Year;

//var result = nowYear - input;
//Console.WriteLine("Yaşınız : " + result);

//var input = int.Parse(Console.ReadLine());
//var input = Console.ReadLine();
//int yıl = int.Parse(input);

//var input11 = int.Parse(Console.ReadLine());
//var input12 = Convert.ToInt32(Console.ReadLine());
//var input13 = input11 + input12;
//Console.WriteLine(input13);

var vizeCarpan = (0.4);
var finalCarpan = (0.6);

Console.WriteLine("Adınız:");
var name = Console.ReadLine();
Console.WriteLine("Soyadınız:");
Console.ReadLine();
Console.WriteLine("Yaşınız");
Console.ReadLine();
Console.WriteLine("Öğrenci Numaranız:");
Console.ReadLine();
Console.WriteLine("Vize Puanınız :");

var input1 = Console.ReadLine();
var inthali = int.Parse(input1);

Console.WriteLine("Final Puanınız :");
int input2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Not Ortalamanız");
double input3 = (inthali * vizeCarpan) + (input2 * finalCarpan);

void HarfBelirleme()
{
    if (input3 < 45)
    {
        Console.WriteLine($"Tebrikler {name}, {input3} puan alarak sınıfta kaldınız. Harf Notunuz : 'FF'");
    }
    else if (input3 >= 45 && input3 < 50)
    {
        Console.WriteLine($"Tebrikler {name}, {input3} puan alarak sınıfınızı geçtiniz. Harf Notunuz : 'DD'");
    }
    else if (input3 >= 50 && input3 < 60)
    {
        Console.WriteLine($"Tebrikler {name}, {input3} puan alarak sınıfınızı geçtiniz. Harf Notunuz : 'DC'");
    }
    else if (input3 >= 60 && input3 < 70)
    {
        Console.WriteLine($"Tebrikler {name}, {input3} puan alarak sınıfınızı geçtiniz. Harf Notunuz : 'CC'");
    }
    else if (input3 >= 70 && input3 < 75)
    {
        Console.WriteLine($"Tebrikler {name}, {input3} puan alarak sınıfınızı geçtiniz. Harf Notunuz : 'BC'");
    }
    else if (input3 >= 75 && input3 < 80)
    {
        Console.WriteLine($"Tebrikler {name}, {input3} puan alarak sınıfınızı geçtiniz. Harf Notunuz : 'BB'");
    }
    else if (input3 >= 80 && input3 < 90)
    {
        Console.WriteLine($"Tebrikler {name}, {input3} puan alarak sınıfınızı geçtiniz. Harf Notunuz : 'BA'");
    }
    else
    {
        Console.WriteLine($"Tebrikler {name}, {input3} puan alarak sınıfınızı geçtiniz. Harf Notunuz : 'AA'");
    }
}

HarfBelirleme();