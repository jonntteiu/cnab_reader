namespace CnabReader.Models.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class CnabRowInfo : Attribute
{
    public int RowNumber { get; set; }

    public CnabRowInfo(int rowNumber)
    {
        RowNumber = rowNumber;
    }
}