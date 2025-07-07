
using Seal.Shared.Results;

namespace Seal.Example.Console.Model;
public record class User
{
    private User()
    {

    }

    public User(int id, string name, string phone)
    {
        Id = id;
        Name = name;
        Phone = phone;
    }

    public int Id { get; init; }

    public string Name { get; init; }

    public string Phone { get; init; }

    private string Dscription { get; init; }
    public static Result<User> Create(int id, string name, string phone)
    {

        if (id <= 0)
        {

            return Result.Failure(new Error("01111", "Id不能小于0"));
            //return Result<User>.Failure(new Error("01111", "Id不能小于0"));
        }

        if (string.IsNullOrWhiteSpace(name))
        {

            return Result<User>.Failure("名字不能为空");
        }
        return new User(id, name, phone) { Dscription = "海豹" };
    }

}