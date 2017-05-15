using SQLite;

namespace App112.Database
{
    public class DReport
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string reportID { get; set; }
        public string reportDate { get; set; }
    }
}
