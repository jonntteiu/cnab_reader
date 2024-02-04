using System.Reflection;
using CnabReader.Models.Attributes;

namespace CnabReader.Models.Classes;

public abstract class CnabRow
{
    public void ValidateMapping(CnabInfo cnabInfo)
    {
        var cnabFields = GetType().GetProperties().Where(property => property.GetCustomAttribute<CnabField>() != null);
        var currentCnabSize = 0;
        var currentPos = 0;

        foreach (var field in cnabFields)
        {
            var cnabField = field.GetCustomAttribute<CnabField>();

            currentCnabSize += cnabField!.DataLength;

            if (cnabField.StartPosition != currentPos)
            {
                throw new Exception($"'{GetType().Name}' tem campos em que suas posições se sobrescrevem. ('{field.Name}')");
            }

            currentPos += cnabField.DataLength;
        }

        if (currentCnabSize != (int)cnabInfo.Size)
        {
            throw new Exception($"'{GetType().Name}' não tem o tamanho do cnab informado. ({cnabInfo.Size})");
        }
    }
}