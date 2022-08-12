bool IsPalindrome(string s){
    bool isPalindrome = true;    
    for(int i=0;i<(int)s.Length/2;i++){
        if(s[i]!=s[s.Length-1-i])isPalindrome=false;
    }
    return(isPalindrome);
}

Console.Clear();
Console.WriteLine("Введите пятизначное число");
string s = Console.ReadLine();

if(s.Length!=5)Console.WriteLine("Введённое число не соответствует условию");
else
    if(IsPalindrome(s))
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число не является палиндромом");