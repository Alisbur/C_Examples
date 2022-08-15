// Console.Clear();
// Console.WriteLine("Введите текст");
// string text = Console.ReadLine();
// string result = String.Empty;

// for(int i=0;i<text.Length;i++)
//     switch(text[i])
//     {
//         case ' ': {result = result + '-';break;}
//         case 'к': {result = result + 'К';break;}
//         case 'С': {result = result + 'с';break;}
//         default: {result = result + text[i];break;}
//     }

// Console.WriteLine(result);

string ReplaceSym(string text, char c1, char c2){
    string result = String.Empty;

    for(int i=0;i<text.Length;i++){
        if (text[i] == c1) result=result+c2;
        else result= result+text[i];        
    }
    return(result);
}
string someText = "кывдалткк ва фы ССС сс ККК ккк ывтывадлш узщшкцчь";

someText = ReplaceSym(someText,' ','|');
someText = ReplaceSym(someText,'С','с');
someText = ReplaceSym(someText,'к','К');

Console.WriteLine(someText);