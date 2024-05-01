namespace ProductAPI.Dtos
{
    public class CreateDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
