using Seal.Example.Console.Model;
using Seal.Shared.Results;

Console.WriteLine("Hello, Seal!");
var res0 = User.Create(0, "", "13600000");
//Console.WriteLine(res0?.Error?.Message);
var res = User.Create(1, "seal", "13600000");
var res1 = User.Create(2, "", "13600000");

Result<int> result = 5;
var result1 = Result<int>.Success(5);
var result2 = Result.Failure(new Error("0001", "失败"));
var result3 = Result.Success(5, "这里输入是5");
var result4 = Result<int>.Failure(new Error("0002", "失败"));
Console.WriteLine(result1.Value);
Console.ReadLine();