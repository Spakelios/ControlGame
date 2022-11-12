using System;

[Serializable]
public class InputEntry
{
    public static string playerName;

    public InputEntry(string name, int points)
    {
        playerName = name;
    }
}