namespace orm_json_benchmarking.Models;

public class UserModel
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public int Role { get; set; }

    public DateTime CreationDate { get; set; }
}