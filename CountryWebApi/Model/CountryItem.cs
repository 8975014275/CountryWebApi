namespace CountryWebApi.Model
{
    public class CountryItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? State { get; set; }
        public bool IsDone { get; set; }
    }
}
