using System.Reflection;
using CnabReader.Models.Attributes;

namespace CnabReader.Models.Classes;

public abstract class Cnab
{
    public void ValidateMapping()
    {
        var cnabRows = GetType().GetNestedTypes().Where(nested => nested.IsAssignableTo(typeof(CnabRow)));
        var cnabInfo = GetType().GetCustomAttribute<CnabInfo>();

        if (cnabInfo is null)
        {
            throw new Exception($"'{GetType().Name}' não possui um atributo {nameof(CnabInfo)}");
        }

        foreach (var cnabRow in cnabRows)
        {
            var cnabRowInstance = Activator.CreateInstance(cnabRow) as CnabRow;

            cnabRowInstance?.ValidateMapping(cnabInfo);
        }
    }
}