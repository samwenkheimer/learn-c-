using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





Console.WriteLine ("Enter number:");

// READ LINE IS THE FUCKING USER INPUT AND WE STORE IT IN NUMBER 
string? number = Console.ReadLine();
int x;

int.TryParse(number, out x);

for (int i = 0; i < x; i++) {
    Console.WriteLine(i);
}
    
    


