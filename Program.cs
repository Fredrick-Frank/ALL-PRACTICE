byte option1 = 1;
byte options2 = 2;

byte totalOptions;

totalOptions = (byte) (option1 | options2); //bitwise inclusive OR Operator
//Console.WriteLine(totalOptions);

//bitwise exclusive OR operator
byte invertMask = 225;
byte someByte = 240;
byte inverse;

inverse = (byte) (someByte ^ invertMask);
//Console.WriteLine(inverse);

//boolean AND operator
/*
bool inStock = false;
decimal price = 18.95m;

bool buy;
buy = inStock & (price < 20.00m);
*/

//Console.WriteLine(buy);


//boolean Inclusive OR operator
/*
int mileage = 2305;
int months = 4;
bool changeOil;

changeOil = mileage > 3000 | months > 3;
*/

//Console.WriteLine(changeOil);

//the boolean exclusive OR operator
bool availFlag = false;
bool toggle = true;
bool available;

available = availFlag ^ toggle;
//Console.WriteLine(available);

//the conditinal AND operator: when two expressions are true it returns true, also if one expression is false it returns false.
bool inStock = false;
decimal price = 18.95m;

bool buy;
buy = inStock && (price < 20.00m);//price < 20 will never be evaluated
//Console.WriteLine(buy);

//the conditional OR operator
int mileage = 2305;
int months = 4;
bool changeOil;

changeOil = mileage > 3000 || months > 3; //months > 3 returning true
//Console.WriteLine(changeOil);


//Ternary Operator: for three expressions
long democratvotes = 18188883889;
long republicvotes = 111111111198;

string headline = democratvotes != republicvotes ?
    "We finally Have a Winner!" : "Recount";
//Console.WriteLine(headline);

//The is Operator
/*
int i = 0;
bool isTest = i is int;
Console.WriteLine(isTest);

//The as Operator
object obj = new Customer();
string cust = obj as string;

Console.WriteLine("cust {0} a string.",
    cust == null? "is not" : "is");
*/
//type Operator:
Type myType = typeof(int);
C//onsole.WriteLine("The" +
    " int type:{0}", myType);

//the checked operator
/*
short val1 = 20000, val2 = 20000;
short myShort = checked((short)(val1 + val2));
*/


//the unchecked operator

short val1 = 20000, val2 = 20000;
short myShort = 
    unchecked((short)(val1 + val2));