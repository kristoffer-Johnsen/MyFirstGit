// See https://aka.ms/new-console-template for more information

int counter = 0;

List<int> numbers = new List<int>();

while (counter < 5)
{
    int nr = Convert.ToInt32(Console.ReadLine());

    numbers.Add(nr);
    counter++;
}

int sum = 0;
int largest = 0;
int smallest = 999999999;
int[] digitCounter = new int[10]; //sifrene 0 - 10

//0, 1
//0, 2
//0, 3
//0, 4
//0, 5
//0, 6
//0, 7
//0, 8
//0, 9

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] > largest)
    {
        largest = numbers[i];
    }

    if (numbers[i] < smallest)
    {
        smallest = numbers[i];
    }

    sum += numbers[i];

    digitCounter[numbers[i] - 1]++;
}

int? mostOf = null;
foreach (int digit in digitCounter)
{
    if(mostOf == null) mostOf = digit;
    if(digit > mostOf) mostOf = digit;
}

Console.WriteLine($"størst             : {largest}\n" +
                  $"minst              : {smallest}\n" +
                  $"sum                : {sum}\n" +
                  $"Most of this digit : {mostOf}");



//Du skal lage en konsoll-applikasjon hvor brukeren skriver inn 5 tall, for så å finne ut:
//      -Hvilket tall det er flest av
//      -Hvilket tall som er størst
//      -Hvilket tall som er minst
//      -Summen av alle tallene
