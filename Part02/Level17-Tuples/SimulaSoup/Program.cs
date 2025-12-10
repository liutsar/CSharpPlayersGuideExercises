(SoupType soupType, MainIngredient mainIngredient, Seasoning seasoning) soup = GetSoup();
Display(soup);

(SoupType, MainIngredient, Seasoning) GetSoup()
{
    return (GetSoupType(), GetMainIngredient(), GetSeasoning());
}


SoupType GetSoupType()
{
    Console.Write("Choose your Soup type (soup, stew, gumbo): ");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "soup" => SoupType.Soup,
        "stew" => SoupType.Stew,
        "gumbo" => SoupType.Gumbo,
    };
}

MainIngredient GetMainIngredient()
{
    Console.Write("Choose your Main ingredient (mushrooms, chicken, carrots, potatoes): ");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "mushrooms" => MainIngredient.Mushrooms,
        "chicken" => MainIngredient.Chicken,
        "carrots" => MainIngredient.Carrots,
        "potatoes" => MainIngredient.Potatoes,
    };
}


Seasoning GetSeasoning()
{
    Console.Write("Choose your Seasoning (spicy, salty, sweet): ");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet,
    };
}


void Display((SoupType soupType, MainIngredient mainIngredient, Seasoning seasoning) soup)
{
    Console.WriteLine($"{soup.seasoning} {soup.mainIngredient} {soup.soupType}");
}


enum SoupType
{
    Soup,
    Stew,
    Gumbo
}

enum MainIngredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}