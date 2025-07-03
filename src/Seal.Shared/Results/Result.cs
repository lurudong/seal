namespace Seal.Shared.Results;

/// <summary>
/// 结果类
/// </summary>
public class Result
{
    /// <summary>
    /// 构造函数
    /// </summary>
    protected Result()
    {
    }
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="isSuccess">是否成功</param>
    protected internal Result(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }
    /// <summary>
    /// 是否成功
    /// </summary>
    public bool IsSuccess { get; private set; }

    /// <summary>
    /// 是否失败
    /// </summary>
    public bool IsFailed => !IsSuccess;

    /// <summary>
    /// 成功
    /// </summary>
    /// <returns></returns>
    public static Result Success() => new(true);


    /// <summary>
    /// 失败
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Result<TValue> Failure<TValue>() =>
    new(default, false);
}
