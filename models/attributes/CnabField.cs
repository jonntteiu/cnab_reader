namespace CnabReader.Models.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class CnabField : Attribute
{
    public int StartPosition { get; set; } = 0;
    public int DataLength { get; set; } = 0;

    public CnabField(int startPosition, int dataLength)
    {
        StartPosition = startPosition - 1;
        DataLength = dataLength;
    }
}