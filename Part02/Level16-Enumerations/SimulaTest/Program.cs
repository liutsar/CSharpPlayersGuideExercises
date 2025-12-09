ChestState currentState = ChestState.Closed;

while (true)
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");

    string command = Console.ReadLine();
    currentState = PerformAction(command, currentState);
}

ChestState PerformAction(string command, ChestState currentState)
{
    if (command == "close" && currentState == ChestState.Open)
        return ChestState.Closed;
    if (command == "lock" && currentState == ChestState.Closed)
        return ChestState.Locked;
    if (command == "unlock" && currentState == ChestState.Locked)
        return ChestState.Closed;
    if (command == "open" && currentState == ChestState.Closed)
        return ChestState.Open;
    return currentState;
}

enum ChestState
{
    Open,
    Closed,
    Locked
}