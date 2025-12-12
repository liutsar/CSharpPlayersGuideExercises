Arrow customerArrow = GetArrow();
Console.WriteLine($"Your arrow costs {customerArrow.GetCost()} gold.");

Arrow GetArrow()
{
    ArrowheadType arrowhead= GetArrowheadType();
    FletchingType fletching = GetFletchingType();
    float arrowLength = GetArrowLength();
    
    return new Arrow(arrowhead, fletching, arrowLength);
}

ArrowheadType GetArrowheadType()
{
    Console.Write("Arrowhead type (steel, wood, obsidian): ");
    ArrowheadType arrowheadType = Console.ReadLine().ToLower() switch
    {
        "steel" => ArrowheadType.Steel,
        "wood" => ArrowheadType.Wood,
        "obsidian" => ArrowheadType.Obsidian,
        _ => ArrowheadType.Steel
    };
    
    return arrowheadType;
}

FletchingType GetFletchingType()
{
    Console.Write("Fletching type (plastic, turkey feathers, goose feathers): ");
    FletchingType fletchingType = Console.ReadLine().ToLower().Replace(" ", string.Empty) switch
    {
        "plastic" => FletchingType.Plastic,
        "turkeyfeathers" => FletchingType.TurkeyFeathers,
        "goosefeathers" => FletchingType.GooseFeathers,
        _ => FletchingType.Plastic
    };
    
    return fletchingType;
}

float GetArrowLength()
{
    float arrowLength = 0;

    while (arrowLength is < 60 or > 100)
    {
        Console.Write("Shaft length (between 60-100 cm): ");
        arrowLength = float.Parse(Console.ReadLine());
    }

    return arrowLength;
}

internal class Arrow
{
    private ArrowheadType arrowheadType;
    private FletchingType fletchingType;
    private float length;
    
    public ArrowheadType GetArrowheadType() => arrowheadType;
    public FletchingType GetFletchingType() => fletchingType;
    public float GetLength() => length;

    internal Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float length)
    {
        this.arrowheadType = arrowheadType;
        this.fletchingType = fletchingType;
        this.length = length;
    }
    

    public float GetCost()
    {
        float arrowheadCost = arrowheadType switch
        {
            ArrowheadType.Steel => 10,
            ArrowheadType.Wood => 3,
            ArrowheadType.Obsidian => 5
        };
        float fletchingCost = fletchingType switch
        {
            FletchingType.Plastic => 10,
            FletchingType.TurkeyFeathers => 5,
            FletchingType.GooseFeathers => 3
        };
        float shaftCost = length * 0.05f;

        return arrowheadCost + fletchingCost + shaftCost;
    }
}

enum ArrowheadType
{
    Steel,
    Wood,
    Obsidian
}

enum FletchingType
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}
