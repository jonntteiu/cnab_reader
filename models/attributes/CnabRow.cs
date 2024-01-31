using CnabReader.Models.Cnabs.Sizes;

namespace CnabReader.Models.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class CnabRow : Attribute
{
    public int RowNumber { get; set; }

    public CnabRow(int rowNumber)
    {
        RowNumber = rowNumber;
    }
}