public class Employee
{
    public int EmployeeId { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    public string Phone { get; set; }
    public int? PositionId { get; set; }
    public Position Position { get; set; }
    
    [Required]
    public DateTime HireDate { get; set; }
    
    public decimal? Salary { get; set; }
    public string Department { get; set; }
    public string Address { get; set; }
    public string PhotoUrl { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}