using System.Reflection;
using CnabReader.Models.Attributes;

namespace CnabReader.Models.Classes;

public abstract class Cnab
{
    public static void ValidateMapping<T>()
    {
        var cnabInfo = typeof(T).GetCustomAttribute<CnabInfo>();
        var currentCnabSize = 0;

        if (cnabInfo == null)
        {
            throw new ArgumentException($"A classe {typeof(T).Name} não possui o atributo '{nameof(CnabInfo)}'");
        }

        foreach (var cnabRow in typeof(T).GetNestedTypes())
        {
            if (cnabRow.GetCustomAttribute<CnabRow>() == null)
            {
                throw new ArgumentException($"A classe {cnabRow.Name} não possui o atributo '{nameof(CnabRow)}'");
            }

            foreach (var propertyInfo in cnabRow.GetProperties())
            {
                var cnabField = propertyInfo.GetCustomAttribute<CnabField>();

                if (cnabField == null)
                {
                    throw new ArgumentException($"A propriedade {propertyInfo.Name} não possui o atributo '{nameof(CnabField)}'");
                }

                currentCnabSize += cnabField.DataLength;
            }

            if (currentCnabSize != (int)cnabInfo.Size)
            {
                throw new ArgumentException($"A classe {cnabRow.Name} não respeita o tamanho do cnab: {typeof(T).Name} ({cnabInfo.Size})");
            }
        }
    }
}