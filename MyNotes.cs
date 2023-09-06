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



public static string ArraysPageOne = 
@"...
I programmering bruges arrays til at gemme en samling af elementer af samme datatyper.
Du kan definere, tildele og ændre elementer i et array.

Defining
";
}