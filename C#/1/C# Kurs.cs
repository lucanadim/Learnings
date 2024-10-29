//Hello world
Console.WriteLine("Hello world");   //---> Hello world
Console.WriteLine("Can be everything");  //---> Can be everything



//Variables and data types
//Variables
string myName = "Luca";
Console.WriteLine(myName);   //---> Luca

//date types

//integers
int number = 20;

//floating-point numbers
float number1 = 10.3f;
double number2 = 20.343;
decimal number3 = 58.23452m;

//truth values
bool is_adult = false;

//text values
string name = "Luca";
char character = 'L';



//Calculating in code
int result = 15 + 2;
float result = 15f - 2f;
float result = 15f * 2f;
float result = 15f / 2f;
int result = 10 + 15 * 2;
int result = (10 + 15) * 2;
Console.WritLine(result);

int number4 = 30;
int number5 = 20;
int result2 = number4 + number5;

result2 += 10;

Console.WriteLine(result2)



//methods
void CountToThree()
{
    Console.WriteLine(1);
    Console.WriteLine(2);
    Console.WriteLine(3);
    Console.WriteLine("-------");
}
CountToThree();

//method parameters
void SeyHelloTo(string name)
{
    Console.WriteLine("Hello" + name);
    Console.WriteLine("how are you");
    Consele.WriteLine("-------");
}
 SeyHelloTo("Luca")

 //return value
 double Square(double number6)
 {
    double result = number6 * number6;
    return result;
 }
 double quadrat = Square(5);
 Console.WriteLine(quadrat);

 double CalculateCircumference(double radius)
 {
    double result = 2 * Math.PI * radius;
 }
 Console.WriteLine(CalculateCircumference(5))



 //input from the user
 