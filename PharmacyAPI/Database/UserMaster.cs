namespace PharmacyAPI.Database
{
    public class UserMaster
    {
        public string 薬局コード { get; set; }
        public string ユーザーID { get; set; }
        public string 氏名 { get; set; }
        public string 役職 { get; set; }
        public bool 管理者フラグ { get; set; }
        public bool 削除フラグ { get; set; }
        
    }
}
