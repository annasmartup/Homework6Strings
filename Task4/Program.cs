static void ReverseString(string str)
{
    string [] rever = str.Split(' ');
    string reverse = "";
    for (int i = rever.Length - 1; i >= 0; i--)
    {
        reverse += rever[i] + " ";
    }
    Console.Write(reverse);
}

string str1 = "Hello my world";
ReverseString(str1);
