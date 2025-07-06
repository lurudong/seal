namespace Seal.Shared.Results;


/// <summary>
/// 结果类
/// </summary>
public partial class Result<TValue> : ResultBase, IResult
{
    /// <summary>
    /// 
    /// </summary>

    protected Result() { }
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="value">值</param>
    public Result(TValue value) => Value = value;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="successMessage">值</param>
    protected internal Result(TValue value, string successMessage) : this(value) => SuccessMessage = successMessage;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="isSuccess">是否成功</param>
    protected Result(bool isSuccess) => IsSuccess = isSuccess;

    /// <summary>
    /// 值
    /// </summary>
    public TValue Value { get; protected set; } = default!;



    /// <summary>
    /// 是否有值
    /// </summary>
    /// <returns></returns>
    public virtual bool HasValue() => !EqualityComparer<TValue>.Default.Equals(Value, default);

    /// <summary>
    /// 得到值
    /// </summary>
    /// <returns></returns>

    public virtual object? GetValue()
    {
        return this.Value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>

    public static Result<TValue> Success(TValue value) => new(value);


    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="successMessage"></param>
    /// <returns></returns>

    public static Result<TValue> Success(TValue value, string successMessage) => new(value) { SuccessMessage = successMessage };



    /// <summary>
    /// 
    /// </summary>
    /// <param name="error"></param>
    /// <returns></returns>

    public static Result<TValue> Failure([NotNull] Error error) => new(false) { Error = error };

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static Result<TValue> Failure([NotNull] string message) => Failure(string.Empty, message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="code"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static Result<TValue> Failure([NotNull] string code, [NotNull] string message) => Failure(new Error(code, message));


    //public static implicit operator TValue(Result<TValue> result) => result.Value;

    public static implicit operator Result<TValue>(TValue value) => Success(value);

    public static implicit operator Result<TValue>(Result result) => new(default(TValue)!)
    {
        SuccessMessage = result.SuccessMessage ?? string.Empty,
        IsSuccess = result.IsSuccess,
        Error = result.Error
    };
}



