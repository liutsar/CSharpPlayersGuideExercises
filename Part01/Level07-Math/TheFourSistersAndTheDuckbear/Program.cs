Console.Write("Chocolate eggs gathered today: ");
int chocolateEggsCount = Convert.ToInt32(Console.ReadLine());
int sisterCount = 4;
int forEachSister = chocolateEggsCount / sisterCount;
int leftoverForDuckbear = chocolateEggsCount % sisterCount;

string Pluralize(int count, string word) => count == 1 ? word : word + "s";

Console.WriteLine($"Each sister gets {forEachSister} {Pluralize(forEachSister, "egg")}");
Console.WriteLine($"The Duckbear gets {leftoverForDuckbear} {Pluralize(leftoverForDuckbear, "egg")}");

int waysWhereDuckbearGetsMore = 0;
Console.WriteLine("\nAnswering the additional question:");
for (int eggs = 0; eggs <= chocolateEggsCount; eggs++)
{
    int sisterShare = eggs / sisterCount;
    int duckBearShare = eggs % sisterCount;

    if (duckBearShare > sisterShare)
    {
        Console.WriteLine($"- If there are {eggs} {Pluralize(eggs, "egg")}, Duckbear gets more than each sister does.");
        waysWhereDuckbearGetsMore++;
    }
}