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


// decimals have a smaller range, but greater 
// precision(more decimal places) than the double
decimal min2 = decimal.MinValue;
decimal max2 = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);
// fewer decimal places

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
// more decimal places (precision)
// the 'M' suffix indicates that a constant should 
// use the 'decimal' type
// 'M' was chosen because it's more visually distinct
// compared to the keywords 'doucble' and 'decimal'

// there's a long type, which is similar to integers, 
// but has a larger range, so uses more memory
long min3 = long.MinValue;
long max3 = long.MaxValue;
Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

// there's also a 'short' number type