namespace Seal.Shared.Results;


/// <summary>
/// 结果类
/// </summary>
public class Result<TValue> : Result
{

    public Result(TValue? value, bool isSuccess) : base(isSuccess)
    {
        Value = value;
    }


    /// <summary>
    /// 值
    /// </summary>
    public TValue? Value { get; init; }

    /// <inheritdoc/>
    public static implicit operator Result<TValue>(TValue data)
    {

        return new Result<TValue>(data, true);
    }
}