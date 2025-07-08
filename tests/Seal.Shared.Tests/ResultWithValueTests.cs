namespace Seal.Shared.Tests;



using global::Seal.Shared.Results;

/// <summary>
/// 测试有返回值的结果
/// </summary>
public class ResultWithValueTests
{
    [Fact]
    public void Result_SuccessWithValue_ShouldReturnSuccessResult()
    {
        var result = Result<int>.Success(1);
        Assert.True(result.IsSuccess);
        Assert.Equal(1, result.Value);
    }

    [Fact]
    public void Result_SuccessWithMessage_ShouldReturnSuccessResultWithMessage()
    {
        var result = Result<int>.Success(1, "Success");
        Assert.True(result.IsSuccess);
        Assert.Equal(1, result.Value);
        Assert.Equal("Success", result.SuccessMessage);
    }

    [Fact]
    public void Result_FailureWithError_ShouldReturnFailureResultWithError()
    {
        var error = new Error("Error", "An error occurred");
        Result<int> result = Result<int>.Failure(error);
        Assert.False(result.IsSuccess);
        Assert.True(result.Value >= 0);
        Assert.Equal(error, result?.Error);
    }

    [Fact]
    public void Result_FailureWithMessageAndCode_ShouldReturnFailureResultWithMessageAndCode()
    {
        Result<int?> result = Result<int?>.Failure("An error occurred", "ERROR_CODE");
        Assert.False(result.IsSuccess);
        Assert.Null(result.Value);
        Assert.Equal("ERROR_CODE", result.Error.Code);
        Assert.Equal("An error occurred", result.Error.Message);
    }

    [Fact]
    public void Result_HasValue_ShouldReturnTrueIfValueIsNotNull()
    {
        var result = Result<int>.Success(1);
        Assert.True(result.HasValue());
    }

    [Fact]
    public void Result_HasValue_ShouldReturnFalseIfValueIsNull()
    {
        var result = Result<int>.Success(default(int));
        Assert.False(result.HasValue());
    }

    [Fact]
    public void Result_GetValue_ShouldReturnTheValue()
    {
        var result = Result<int>.Success(1);
        Assert.Equal(1, result.GetValue());
    }

    [Fact]
    public void Result_GetValue_ShouldReturnNullIfValueIsNull()
    {
        var result = Result<string>.Success(default(string)!);
        Assert.Null(result.GetValue());
    }

    [Fact]
    public void Result_ImplicitOperator_ShouldConvertValueToResult()
    {
        var value = 1;
        var result = (Result<int>)value;
        Assert.True(result.IsSuccess);
        Assert.Equal(1, result.Value);
    }

    [Fact]
    public void Result_ImplicitOperator_ShouldConvertResultToResult()
    {
        var result = Result<int>.Success(1);
        var convertedResult = (Result<int>)result;
        Assert.True(convertedResult.IsSuccess);
        Assert.Equal(1, convertedResult.Value);
    }
}