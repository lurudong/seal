
namespace Seal.Shared.Results;

/// <summary>
/// 结果错误
/// </summary>
public partial record struct Error
{
    /// <summary>
    /// 码
    /// </summary>
    public string Code { get; init; } = string.Empty;

    /// <summary>
    /// 消息
    /// </summary>
    public string Message { get; init; } = string.Empty;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="message">消息</param>
    public Error(string message)
    {
        Message = message;
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="code">编码</param>
    /// <param name="message">消息</param>

    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }

    //public static implicit operator string(Error error) => error.Code;

    /// <summary>
    /// 空
    /// </summary>
    public static readonly Error Empty = new(string.Empty, string.Empty);
}
