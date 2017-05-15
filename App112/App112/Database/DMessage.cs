using SQLite;


namespace App112.Database
{
    public class DMessage
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string reportID { get; set; }
        public string Text { get; set; }
        public string PhoneNumber { get; set; }
    }
}
