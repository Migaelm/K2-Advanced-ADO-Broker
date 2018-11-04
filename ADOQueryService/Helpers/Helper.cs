using SourceCode.Data.SmartObjectsClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceCode.SmartObjects.Services.Helpers
{
    public static class Helper
    {
        public static string GetValueAsString(this SODataReader reader, int index)
        {
            string returnValue = string.Empty;
            if (reader.FieldCount >= index + 1)
            {
                var value = reader.GetValue(index);
                if (value is byte[])
                {
                    //var file = reader.Get(index);
                    //string fileXML = "<file><name>{FileName}</name><content>{0}</content></file>";
                    //returnValue = string.Format(fileXML, Convert.ToBase64String(value as byte[]));
                    returnValue = Convert.ToBase64String(value as byte[]);
                }
                else
                    returnValue = value.ToString();
            }
            return returnValue;
        }

        public static string GetValueAtIndex(string[] stringArray, int i)
        {
            if (stringArray != null && stringArray.Length > i)
            {
                return stringArray[i];
            }
            else
            {
                return string.Empty;
            }
        }

        public static string IfNullSetToDefault(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }
            else
            {
                return value;
            }
        }
    }
}
