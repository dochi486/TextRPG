namespace TextRPG
{
    public static class DataBaseManager
    {
        public enum DB_MODE
        {
            Code,
            Local,
            Database
        }
        
        public static DB_MODE mode = DB_MODE.Code;
        public static string GetStageDialog(string dialog_key) => StageDialogModel.Get(dialog_key);
        public static string GetPlayerDialog(string dialog_key) => PlayerDialogModel.Get(dialog_key);
    }
}