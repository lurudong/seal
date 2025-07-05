namespace Seal.Shared.Results;


/// <summary>
/// 结果类
/// </summary>
public class Result<TValue> : IResult
{
    protected Result()
    {
    }
    private readonly TValue _value;
    private readonly bool _isSuccess;

    public Result(TValue value, bool isSuccess)
    {
        _value = value;
        _isSuccess = isSuccess;
    }


    /// <summary>
    /// 值
    /// </summary>
    public TValue Value => _value;

    //public bool IsSuccess { get; init; }

    public bool IsSuccess => _isSuccess && HasValue();

    public bool IsFailed => !IsSuccess;


    public Error Error { get; init; }

    /// <summary>
    /// 是否有值
    /// </summary>
    /// <returns></returns>
    public virtual bool HasValue() => !EqualityComparer<TValue>.Default.Equals(Value, default);



    public virtual object GetValue()
    {
        return this.Value!;
    }

    public static Result<TValue> Success(TValue value) => new Result<TValue>(value, true);

    public static Result<TValue> Failure(Error error) => new Result<TValue>(default!, false) { Error = error };
    /// <inheritdoc/>
    //public static implicit operator TValue(Result<TValue> result)
    //    => result is null || !result.HasValue() ? default : result.Value;


    public static Result<TValue> Create(TValue value) =>
      value is not null ? Success(value) : Failure(null);
    /// <inheritdoc/>
    public static implicit operator Result<TValue>(TValue value) => Create(value);

}