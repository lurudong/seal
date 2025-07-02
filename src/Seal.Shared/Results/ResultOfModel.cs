namespace Seal.Shared.Results;


/// <summary>
/// 结果类
/// </summary>
public class Result<TValue> : Result
{

    /// <summary>
    /// 值
    /// </summary>
    public required TValue Value { get; set; }
}