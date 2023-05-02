int a = 7;
// declare variable type as int
int b = 4;
int c = 3;
int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
// order of operations is same as maths
Console.WriteLine(d);

int e =  (a + b) / c;
Console.WriteLine(e);
// this gives an integer as using just '/' is considered
//  as integer division unlike it python where this would
// return a float and using '//' would rather be the 
// integer division

int f = (a + b) % c;
Console.WriteLine($"quotient: {e}");
Console.WriteLine($"remainder: {f}");
// using the modulo sign "%" shows the remainder
// same as python


// numbers have min and max value bounds
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

// when you go beyond the min or max values,
// numbers "overflow" to the next allowable integer
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");


// doubles work like floats in python
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);
// will include the decimal point

// doubles have a much greater range
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);
// doubles can have rounding errors just like floats in python