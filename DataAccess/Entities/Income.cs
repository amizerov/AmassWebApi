namespace AmassWebApi.DataAccess.Entities
{
    public class Income
    {
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string? Name { get; set; }
        public decimal LastPlan { get; set; }
        public bool IsClosed { get; set; }
        public int Client_Id { get; set; }
        public DateTime dtc { get; set; }
    }
}
