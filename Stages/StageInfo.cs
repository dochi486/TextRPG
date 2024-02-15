using TextRPG.Factories;

namespace TextRPG.Stages;

public static class StageInfo
{
    public static Dictionary<int, EMonsterType> StageDictionary = new Dictionary<int, EMonsterType>()
    {
        {1, EMonsterType.Slime},
        {2, EMonsterType.Orc},
        {3, EMonsterType.Goblin}
    };
}