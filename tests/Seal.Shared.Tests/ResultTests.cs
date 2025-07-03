using Seal.Shared.Results;

namespace Seal.Shared.Tests;

public class ResultTests
{
    [Fact]
    public void Constructor_WithValueAndSuccess_SetsProperties()
    {
        // Arrange
        var value = "test value";

        // Act
        var result = new Result<string>(value, true);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.False(result.IsFailed);
        Assert.Equal(value, result.Value);
    }



    [Fact]
    public void Constructor_WithNullValueAndSuccess_SetsProperties()
    {
        // Arrange & Act
        var result = new Result<string>(default, true);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.False(result.IsFailed);
        Assert.Null(result.Value);
    }

    [Fact]
    public void Constructor_WithValueAndFailure_SetsProperties()
    {
        // Arrange
        var value = "test value";

        // Act
        var result = new Result<string>(value, false);

        // Assert
        Assert.False(result.IsSuccess);
        Assert.True(result.IsFailed);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void ImplicitOperator_FromValue_CreatesSuccessResult()
    {
        // Arrange
        string value = "test value";

        // Act
        Result<string> result = value;

        // Assert
        Assert.True(result.IsSuccess);
        Assert.False(result.IsFailed);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void Failure_CreatesFailureResult()
    {
        // Act
        var result = Result.Failure<string>();

        // Assert
        Assert.False(result.IsSuccess);
        Assert.True(result.IsFailed);
        Assert.Null(result.Value);
    }
}