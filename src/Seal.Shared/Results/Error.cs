
namespace Seal.Shared.Results;

/// <summary>
/// 错误类型
/// </summary>
public partial record struct Error
{
    /// <summary>
    /// 错误码
    /// </summary>
    public string Code { get; init; } = string.Empty;

    /// <summary>
    /// 错误消息
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

    /// <summary>
    /// 创建错误实例
    /// </summary>
    /// <param name="code">错误码</param>
    /// <param name="message">错误消息</param>
    /// <returns>返回<typeparamref name="Error"/>类型实例</returns>
    public static Error Create(string code, string message) => new(code, message);

    /// <summary>
    /// 创建错误编码
    /// </summary>
    /// <param name="code">错误码</param>
    /// <returns>返回<typeparamref name="Error"/>类型实例</returns>
    public static Error WithCode(string code) => new(code, string.Empty);



    /// <summary>
    /// 创建错误消息
    /// </summary>
    /// <param name="message">错误码</param>
    /// <returns>返回<typeparamref name="Error"/>类型实例</returns>
    public static Error WithMessage(string message) => new(string.Empty, message);

    //public static implicit operator string(Error error) => error.Code;




    /// <summary>
    /// 返回一个空的实例
    /// </summary>
    public static readonly Error Empty = new(string.Empty, string.Empty);
}
