namespace Seal.Shared.Results;

/// <summary>
/// 结果类
/// </summary>
public class Result : IResult
{
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="isSuccess">是否成功</param>
    protected internal Result(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }
    public bool IsSuccess { get; private set; }


    public static Result Success() => new(true);
}
