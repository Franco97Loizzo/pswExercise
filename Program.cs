short tries = 5;

for (int i = 0; i < tries; i++)
{
    string check = enterPassword();
    if (checkPSW(check))
    {
        printCorrect(check);
        break;
    }
    else
    {
        Console.WriteLine($"Try again, you have {tries - i} tries");
        
    }
    if(i == 4)
    {
        Console.WriteLine("User blocked :c");
    }
}


string enterPassword()
{
    Console.WriteLine("Enter your Password");
    string check = Console.ReadLine();
    return check;
}

bool checkPSW(string check)
{
    const string pwd = "usSystem-2022";
    return check == pwd;
}

void printCorrect(string pwd)
{
    string msg = "";
    for(int i = 0; i < pwd.Length; i++)
    {
        msg += "*";
    }
    Console.WriteLine(msg + " is correct");
}