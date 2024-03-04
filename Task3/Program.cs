static bool IfPalindrom(string str)
{
    str = str.ToLower();
    char[]palin = new char[str.Length];
    for(int i = 0; i < str.Length; i++)
{
    palin[i] = str[i];
}
    int ind = 0;
    bool palindrom = true;
    while(palindrom == true && ind < str.Length / 2)
    {
        if (palin[ind] == palin[palin.Length - 1 - ind])
        {
            ind++;
        }
        else{
            palindrom = false;
        }
    }
    return palindrom;
}

static void PrintPalindrom(bool pal)
{
    if (pal == true)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}



string str1 = "шалаш";
string str2 = "Шалаш";
string str3 = "1ffg3";
PrintPalindrom(IfPalindrom(str1)); 
PrintPalindrom(IfPalindrom(str2)); 
PrintPalindrom(IfPalindrom(str3));



