using CnabReader.Models.Cnabs.Sizes;

namespace CnabReader.Models.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class CnabInfo : Attribute
{
    public CnabSize Size { get; set; }

    public CnabInfo(CnabSize size)
    {
        Size = size;
    }
}