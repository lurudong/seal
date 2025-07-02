namespace Seal.Shared.Results;


/// <summary>
/// 结果类
/// </summary>
public class Result<TValue> : Result
{

    /// <summary>
    /// 构造函数
    /// </summary>
    protected Result()
    {
    }
    /// <summary>
    /// 值
    /// </summary>
    public TValue Value { get; init; }
}