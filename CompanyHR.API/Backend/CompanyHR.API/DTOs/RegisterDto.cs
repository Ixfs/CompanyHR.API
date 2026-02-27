public class RegisterDto
{
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
    
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }
    
    public string Phone { get; set; }
    public int PositionId { get; set; }
    public DateTime HireDate { get; set; } = DateTime.Now;
}