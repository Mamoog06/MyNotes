public static class MyNotes
{
    public static string VariablesPageOne =
@"...
Variabler indeholder forskelligt information der kan ændres igennem koden.
Der findes 4 forskellige typer variabler. 'int', 'float', 'string' og 'bool'.
Variabler skal defineres sådan her 'type variabelNavn = værdi'
Her er nogle eksempler:
 int peopleIveKilled = 116;
 string name = ""Benny Bunsenbrænder"";
 float howOldAmI = 5.4f;
 bool doIRegretIt = false;
";

    public static string VariablesPageTwo =
@"...
De basale datetyper (int, float, string, bool), bruges til at repræsentere forskellige typer af data i programmeringssprog.
Her er en forklaring på hver disse datatyper.
'variablen¨ er en navngivet beholder af en værdi, og kan være af forskllige typer.
Type af variablen bestemme hvilken slags værdi den kan holde, eller hvilke slags operationer kan blive udført.
Der er mange forskellige typer af variabler, men de mest kendte er 'int', 'string', 'float', and 'bool'.

'int' står for 'integere' hvilket betyder heltal på dansk.
Denne datatype bruges til at repræsentere hele tal uden decimaler.
et eksempel på heltal: -4, 0, 45, 3939399
eksempel på 'int': x = 5

'float' står for 'floating-point' hvilket betyder tal med decimaler på dansk.
DEnne datatype bruges til at repræsentere tal med decimaler.
Eksempler på decimaltal: -3.492, 6,129, 93149,123
Eksempel på 'float': pi = 3.14159

'string' bruges til at repræsentere tekst eller en sekvens af tegn.
Tekststrengen skal normalt omgives af enten ekelt- eller dobbelcitationstegn.
Eksempel på en tekststreng: 'Hello world!'
Eksempel på en 'string': name = 'Marcus'

'bool' står for 'boolean' hvilket betyder sandt eller falsk på dansk.
Denne datatype bruges til at repræsentere to mulige værdiger: sandt (True) eller falsk (False).
Den bruges ofte til at udtrykke betingelser i programmer, hvor noget enten er sandt eller falsk.
Eksempler på brug: 'True', 'False'
Eksempel på 'bool': is_sunny = True";


public static string conditionalsPageOne = 
@"...
Når man snakker om konditioner er der tale om at hvis specifikke krav er opfyldt vil bestemte ting ske.
Udtrykkende (if, else, switch and og or), er alle relateret til betingede udsagn i programmering, men de bruges på forskellige måder og har forskellige formål.
Her er en kort forklaring af hver:

'else-if' eller 'else' og 'if' bruges til at udføre forskellige handlinger af, om en betingelse er sand eller falsk.
Eksempel:
int number = 40;
if (number > 20)
{
    Console.WriteLine('Tallet er over 20');
}
else
{
    Console.WriteLine('Tallet er 20 eller mindre');
}


'switch' bruges til at håndtere flere mulige tilfælde baseret på værdien af en variabel.
Eksempel:
int choice = 2;
switch (choice)
{
    case 1:
        Console.WriteLine('Valg 1 blev valgt');
    case 2:
        Console.WriteLine('Valg 2 blev valgt');
    default:
        Console.WriteLine('Ingen gyldigt valg.');
} ";


public static string conditionalsPageTwo = 
@"...
'and' (&&) og 'or' (||) er logiske operatorer, der bruges til at kombinere betingelser.
'and' ('&&') kræver, at begge betingelser er sande for at give en sand værdi.
'or' ('||') kræver, at mindst en af betingelserne er sand for at give en sand værdi.
Eksempel:
int age = 25;
bool isStudent = true;

if (age > 18 && isStudent)
{
    Console.WriteLine('Du er en studerende over 18 år.');
}

if (age < 12 || age > 65)
{
    Console.WriteLine('Du er enten under 12 år eller over 65 år.');
}

Bemærk, at selvom 'if' og 'else' samt 'switch' har til formål at håndtere betingede situationer, er de forskellige i deres anvendelse og kompleksitet.
'And' og 'or' er logiske operatorer, der bruges til at opbygge mere komplekse betingelser ved at kombinere en eller flere betingelser.";



public static string arraysPageOne = 
@"...
I programmering bruges arrays til at gemme en samling af elementer af samme datatyper.
Du kan definere, tildele og ændre elementer i et array.

Defining:
Når du definerer et array, angiver du datatypen for elementerne, arrayets navn og størrelsen på arrayet.
Her er et eksempel:
int[] numbers = new int[3];

Assigning:
Når arrayet er defineret, kan du tildele værdier til hvert element i arrayet ved at angive indekset for hvert element.
Arrays strarter i 0.
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;

Modifying:
Du kan ændre værdierne i et array ved at tildele nyr værdier til de eksisterende indekser.
Her er et eksempel:
Number[1] = 25
Nu vil 'numbers'-arrayet indeholde følgende værdier '[10, 25, 30]'

Husk at størrelsen på et array er fast, når det først er defineret, og du kan ikke tilføje eller fjerne elementer uden at oprette
et nyt array med en anden størrelse. Arrays er meget nyttige til til at gemme og arbejde med en samling af data, hvor elementerne 
er relaterede til hinanden.";



public static string listsPageOne = 
@"...
'lists' er en alternativ til arrays der er mere versitale. 
Opretning:
Man laver en liste med denne generelle kode:
List<type> navn = new List<type>();
";



public static string loopsPageOne = 
@"...
'loops' er kontrolstrukturer i programmering, der giver dig mulighed for at udføre gentagne handlinger.
De forskellige typer af loops i programmering gør generelt det samme - udføre gentagne handlinger baseret på
en betingelse, indtil betingelsen ikke længere er opfyldt. Her er en oversigt over nogle af de mest almindelige
loop-typer og begreber:

'For-loop' bruges til at udføre en række handlinger et bestemt antal gange.
Typisk bruges sammen med en tæller, der ændres i hver iteration.
Eksempel:
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

'foreach-loop' bruges til at iterer over elementer i en samling, som f.eks. et array eller en liste.
Giver en mere enkel syntaks til at arbejde med samlinger.
Eksempel:
int[] numbers = {1, 2, 3, 4, 5};
foreach (int number in numbers)
{
    Console.WriteLine(numbers);
}

'while-loop' udfører en række handlinger, så længe en betingelse er sand.
Betingelsen evalueres først, og hvis den er sand, udføres handlingerne.
Eksempel:
int count = 0;
while (count < 5)
{
    Console.WriteLine(count);
    count++;
}

'do-while-loop' ligner en 'while-loop', men udfører handlingerne mindst en gang, inden betingelsen evalueres.
Eksempel:
int x = 5;
do
{
    Console.WriteLine(x);
    x--;
} while (x > 0);
";



public static string loopsPageTwo = 
@"...
Til at iterere gennem arrays kan du både bruge 'for-loops' og 'foreach-loops' til at iterere gennem arrays.

'break' bruges til at afbryde en loop og forlade den før betingelserne er falsk.
'continue' bruges til at springe den aktuelle iteration over og gå videre til næste iteration af loopen.

med 'Nested loops' kan du placere en loop i en anden loop for at opnå mere komplekse gentagne handlinger.
Eksempel:
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($'i: {i}, j: {j}');
    }
}

Hver type loop har sin egen anvendelse og bruges afhængigt af det specifikke problem, du forsøger at løse i dit program.";
}