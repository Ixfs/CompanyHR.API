public class Position
{
    public int PositionId { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string PositionName { get; set; }
    
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
}