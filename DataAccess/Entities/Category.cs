namespace AmassWebApi.DataAccess.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string? Name { get; set; }
        public int Kind { get; set; }
        public DateTime dtc { get; set; }
    }
}
