# Seal
## .net core framework

![logo](images/logo.png)

Seal��һ�����ڴ�������ʹ�������.NET Core��ܡ����ṩ��һ�ּ򵥶�ǿ��ķ�ʽ������Ӧ�ó����еĳɹ���ʧ�ܽ����



## ����
- �����ɹ���ʧ�ܽ��
- �ṩ����������
- �򻯴����д

## ��װ
ʹ��NuGet����������װSeal��

������

```NuGet
Install-Package Seal
```




## ʹ�÷���
����Ŀ��ʹ��Seal�ǳ��򵥡����ȣ�����Ҫ����һ���������Ȼ����ݽ����״ִ̬����Ӧ�Ĳ�����

```csharp
var result = Result<int>.Success(1);
if (result.IsSuccess)
{
    // �����ɹ����
}
else
{
    // ����ʧ�ܽ��
}

```