namespace TextRPG
{
    public static class PlayerDialogModel
    {
        private static readonly Dictionary<string, string> dialog_dic = new Dictionary<string, string>()
        {
            ["ClassSelectDialog"] = "클래스를 선택하세요 \n" +
                                    "1. 마법사 \n" +
                                    "2. 전사 \n" +
                                    "3. 궁수"
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
            return "클래스를 선택하세요 \n" +
                   "1. 마법사 \n" +
                   "2. 전사 \n" +
                   "3. 궁수";
        }
    }
}