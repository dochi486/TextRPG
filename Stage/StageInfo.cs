namespace TextRPG.Stage;

public class StageInfo
{
    public Dictionary<int, MonsterInfo> StageDictionary = new Dictionary<int, MonsterInfo>()
    {
        {1, new MonsterInfo() {EMonsterType = EMonsterType.Slime}},
        {2, new MonsterInfo() {EMonsterType = EMonsterType.Orc}},
        {3, new MonsterInfo() {EMonsterType = EMonsterType.Goblin}}
    };
}