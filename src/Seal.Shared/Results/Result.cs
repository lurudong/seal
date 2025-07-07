namespace Seal.Shared.Results;

/// <summary>
/// 代表带有类型的返回结果。
/// </summary>
/// <typeparam name="TValue">与结果关联的值。</typeparam>
public partial class Result<TValue> : ResultBase, IResult
{

    /// <summary>
    /// 初始化 <see cref="Result{T}"/> 类的新实例。
    /// </summary>

    protected Result() { }

    /// <summary>
    /// 初始化 <see cref="Result{T}"/> 类的新实例。
    /// </summary>
    /// <param name="value">关联的值</param>
    public Result(TValue value) => Value = value;

    /// <summary>
    /// 初始化 <see cref="Result{T}"/> 类的新实例。
    /// </summary>
    /// <param name="value">关联的值</param>
    /// <param name="successMessage">成功消息</param>
    protected internal Result(TValue value, string successMessage) : this(value) => SuccessMessage = successMessage;

    /// <summary>
    /// 初始化 <see cref="Result{T}"/> 类的新实例。
    /// </summary>
    /// <param name="isSuccess">是否成功</param>
    protected Result(bool isSuccess) => IsSuccess = isSuccess;

    /// <summary>
    /// 获取与结果关联的数据。
    /// </summary>
    /// <value>
    /// 与结果关联的数据。
    /// 其默认值为 <c>null</c>。
    /// </value>
    public TValue Value { get; protected set; } = default!;



    /// <summary>
    /// 是否有值
    /// </summary>
    /// <returns>返回true,false</returns>
    public virtual bool HasValue() => !EqualityComparer<TValue>.Default.Equals(Value, default);

    /// <summary>
    /// 得到值
    /// </summary>
    /// <returns>返回相关默认的值或者null</returns>

    public virtual object? GetValue()
    {
        return this.Value;
    }

    /// <summary>
    /// 成功操作
    /// </summary>
    /// <param name="value">相关值</param>
    /// <returns>最后结果实例<typeparamref name="TValue"/></returns>

    public static Result<TValue> Success(TValue value) => new(value);


    /// <summary>
    /// 成功操作
    /// </summary>
    /// <param name="value">相关值</param>
    /// <param name="successMessage">成功消息</param>
    /// <returns>最后结果实例<typeparamref name="TValue"/></returns>

    public static Result<TValue> Success(TValue value, string successMessage) => new(value) { SuccessMessage = successMessage };



    /// <summary>
    /// 失败操作
    /// </summary>
    /// <param name="error">错误相关类型</param>
    /// <returns>最后结果实例<typeparamref name="TValue"/></returns>

    public static Result<TValue> Failure([NotNull] Error error) => new(false) { Error = error };

    /// <summary>
    /// 失败操作
    /// </summary>
    /// <param name="message">失败消息</param>
    /// <param name="code">失败编码</param>
    /// <returns>最后结果实例<typeparamref name="TValue"/></returns>
    public static Result<TValue> Failure(string message, string code = "") => Failure(new Error(code, message));



    /// <summary>
    /// 将类型为 <typeparamref name="TValue"/> 的值转换为类型为 <see cref="Result{TValue}"/> 的实例。
    /// </summary>
    /// <param name="value">表示该值的 <typeparamref name="TValue"/>类型的实例。</param>

    public static implicit operator Result<TValue>(TValue value) => Success(value);

    /// <summary>
    /// 将类型为  <see cref="Result"/> 的值转换为类型为 <typeparamref name="Result{TValue}"/> 的实例。
    /// </summary>
    /// <param name="result">表示要转换的值的 <see cref="Result"/> 类型的实例。</param>

    public static implicit operator Result<TValue>(Result result) => new(default(TValue)!)
    {
        SuccessMessage = result.SuccessMessage ?? string.Empty,
        IsSuccess = result.IsSuccess,
        Error = result.Error
    };
}



