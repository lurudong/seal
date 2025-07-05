/// <summary>
/// 结果错误
/// </summary>
public record class Error(string Code, string Description)
{
    /// <summary>
    /// 空
    /// </summary>
    public static readonly Error None = new(string.Empty, string.Empty);
}
