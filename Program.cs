// See https://aka.ms/new-console-template for more information
int num1;
int num2;

Console.WriteLine("Insira o primeiro número:");
num1= int.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo número:");
num2= int.Parse(Console.ReadLine());

if(num1> num2){
    Console.WriteLine("O numero {0}, é maior que o número {1}.",num1,num2);
}else{
    Console.WriteLine("O número {0}, é menor que o número {1}.",num1,num2);
}
