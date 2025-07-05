using Seal.Shared.Results;

Console.WriteLine("Hello, Seal!");

var res = User.Create(1, "seal", "13600000");
var res1 = User.Create(2, "", "13600000");
Result<int> result = 5; // T -> Result<T>

Console.ReadLine();