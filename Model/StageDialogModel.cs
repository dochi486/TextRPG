namespace TextRPG;

public class StageDialogModel
{
    
    private static readonly Dictionary<string, string> dialog_dic = new Dictionary<string, string>()
    {
        ["StageActionSelectDialogue"] = "무엇을 하시겠습니까? \n" +
                                "1. 사냥한다. \n" +
                                "2. 쉰다. \n" 
    };

    public static string Get(string dialog) => DataBaseManager.mode switch
    {
        DataBaseManager.DB_MODE.Code => dialog_dic[dialog],
        DataBaseManager.DB_MODE.Database => DataFromDataBase(),
        _ => dialog_dic[dialog]
    };
    
    // DB에서 가져올때의 로직
    private static string DataFromDataBase()
    {
        return "무엇을 하시겠습니까? \n" +
               "1. 사냥한다. \n" +
               "2. 쉰다. \n";
    }
}