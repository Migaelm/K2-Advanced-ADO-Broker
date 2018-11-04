using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using SourceCode.Data.SmartObjectsClient;
using SourceCode.SmartObjects.Services.Helpers;
using SourceCode.SmartObjects.Services.ServiceSDK.Objects;
using SourceCode.SmartObjects.Services.ServiceSDK.Types;
using Attributes = SourceCode.SmartObjects.Services.ServiceSDK.Attributes;

namespace SourceCode.SmartObjects.Services.Data
{
    [Attributes.ServiceObject("AdvancedADOService", "Advanced ADO Service", "Advanced ADO Service")]
    class ADOQueryClass
    {

        private ServiceConfiguration _serviceConfig;
        public ServiceConfiguration ServiceConfiguration
        {
            get { return _serviceConfig; }
            set { _serviceConfig = value; }
        }

        #region Class Level Fields

        #region Private Fields
        private string sADOQuery = string.Empty;
        private string sValue = string.Empty;
        private string sValue2 = string.Empty;
        private string sValue3 = string.Empty;
        private string sValue4 = string.Empty;
        private string sValue5 = string.Empty;
        private string sValue6 = string.Empty;
        private string sValue7 = string.Empty;
        private string sValue8 = string.Empty;
        private string sValue9 = string.Empty;
        private string sValue10 = string.Empty;
        private string sValue11 = string.Empty;
        private string sValue12 = string.Empty;
        private string sValue13 = string.Empty;
        private string sValue14 = string.Empty;
        private string sValue15 = string.Empty;
        #endregion

        #endregion

        #region Properties with Property Attribute

        #region string ADOQuery property
        /// <summary>
        /// Property representing ADO Query
        /// </summary>
        [Attributes.Property("ADOQuery", SoType.Text, "ADO Query String", "Specified ADO Query String to select column of data")]
        public string ADOQuery
        {
            get { return sADOQuery; }
            set { sADOQuery = value; }
        }
        #endregion

        #region string Value property
        /// <summary>
        /// Property Value 1 used for input and output
        /// </summary>
        [Attributes.Property("Value1", SoType.Text, "Value1", "First Column that is being returned")]
        public string Value1
        {
            get { return sValue; }
            set { sValue = value; }
        }

        /// <summary>
        /// Property Value 2 used for input and output
        /// </summary>
        [Attributes.Property("Value2", SoType.Text, "Value2", "Second Column that is being returned")]
        public string Value2
        {
            get { return sValue2; }
            set { sValue2 = value; }
        }

        /// <summary>
        /// Property Value 3 used for input and output
        /// </summary>
        [Attributes.Property("Value3", SoType.Text, "Value3", "Third Column that is being returned")]
        public string Value3
        {
            get { return sValue3; }
            set { sValue3 = value; }
        }

        /// <summary>
        /// Property Value 4 used for input and output
        /// </summary>
        [Attributes.Property("Value4", SoType.Text, "Value4", "Fourth Column that is being returned")]
        public string Value4
        {
            get { return sValue4; }
            set { sValue4 = value; }
        }

        /// <summary>
        /// Property Value 5 used for input and output
        /// </summary>
        [Attributes.Property("Value5", SoType.Text, "Value5", "Fifth Column that is being returned")]
        public string Value5
        {
            get { return sValue5; }
            set { sValue5 = value; }
        }

        /// <summary>
        /// Property Value 6 used for input and output
        /// </summary>
        [Attributes.Property("Value6", SoType.Text, "Value6", "Sixth Column that is being returned")]
        public string Value6
        {
            get { return sValue6; }
            set { sValue6 = value; }
        }

        /// <summary>
        /// Property Value 7 used for input and output
        /// </summary>
        [Attributes.Property("Value7", SoType.Text, "Value7", "Seventh Column that is being returned")]
        public string Value7
        {
            get { return sValue7; }
            set { sValue7 = value; }
        }

        /// <summary>
        /// Property Value 8 used for input and output
        /// </summary>
        [Attributes.Property("Value8", SoType.Text, "Value8", "Eighth Column that is being returned")]
        public string Value8
        {
            get { return sValue8; }
            set { sValue8 = value; }
        }

        /// <summary>
        /// Property Value 9 used for input and output
        /// </summary>
        [Attributes.Property("Value9", SoType.Text, "Value9", "Ninth Column that is being returned")]
        public string Value9
        {
            get { return sValue9; }
            set { sValue9 = value; }
        }

        /// <summary>
        /// Property Value 10 used for input and output
        /// </summary>
        [Attributes.Property("Value10", SoType.Text, "Value10", "Tenth Column that is being returned")]
        public string Value10
        {
            get { return sValue10; }
            set { sValue10 = value; }
        }

        /// <summary>
        /// Property Value 11 used for input and output
        /// </summary>
        [Attributes.Property("Value11", SoType.Text, "Value11", "Eleventh Column that is being returned")]
        public string Value11
        {
            get { return sValue11; }
            set { sValue11 = value; }
        }

        /// <summary>
        /// Property Value 12 used for input and output
        /// </summary>
        [Attributes.Property("Value12", SoType.Text, "Value12", "Twelveth Column that is being returned")]
        public string Value12
        {
            get { return sValue12; }
            set { sValue12 = value; }
        }

        /// <summary>
        /// Property Value 13 used for input and output
        /// </summary>
        [Attributes.Property("Value13", SoType.Text, "Value13", "Thirteenth Column that is being returned")]
        public string Value13
        {
            get { return sValue13; }
            set { sValue13 = value; }
        }

        /// <summary>
        /// Property Value 14 used for input and output
        /// </summary>
        [Attributes.Property("Value14", SoType.Text, "Value14", "Fourteenth Column that is being returned")]
        public string Value14
        {
            get { return sValue14; }
            set { sValue14 = value; }
        }

        /// <summary>
        /// Property Value 15 used for input and output
        /// </summary>
        [Attributes.Property("Value15", SoType.Text, "Value15", "up to Fifteenth Column that is being returned")]
        public string Value15
        {
            get { return sValue15; }
            set { sValue15 = value; }
        }

        #endregion

        #endregion

        #region Default Constructor
        /// <summary>
        /// Instantiates a new ServiceObject1.
        /// </summary>
        public ADOQueryClass()
        {
            // No implementation necessary.
        }
        #endregion

        #region Methods with Method Attribute
        [Attributes.Method("Query", MethodType.List, "Query", "List Method that returns up to Fifteen columns of data based on the input ADO Query. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
                    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
                    new string[] { "ADOQuery", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public List<ADOQueryClass> Query()
        {
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();
            string polulatedQuery = GetPopulatedQuery();

            using (SOConnection connection = new SOConnection(ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(ServiceConfiguration["Host Server Port"])))
            using (SOCommand command = new SOCommand(polulatedQuery, connection))
            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
            {
                connection.Open();
                while (reader.Read())
                {
                    ADOQueryClass svcADOQuery = new ADOQueryClass();
                    svcADOQuery.Value1 = reader.GetValueAsString(0);
                    svcADOQuery.Value2 = reader.GetValueAsString(1);
                    svcADOQuery.Value3 = reader.GetValueAsString(2);
                    svcADOQuery.Value4 = reader.GetValueAsString(3);
                    svcADOQuery.Value5 = reader.GetValueAsString(4);
                    svcADOQuery.Value6 = reader.GetValueAsString(5);
                    svcADOQuery.Value7 = reader.GetValueAsString(6);
                    svcADOQuery.Value8 = reader.GetValueAsString(7);
                    svcADOQuery.Value9 = reader.GetValueAsString(8);
                    svcADOQuery.Value10 = reader.GetValueAsString(9);
                    svcADOQuery.Value11 = reader.GetValueAsString(10);
                    svcADOQuery.Value12 = reader.GetValueAsString(11);
                    svcADOQuery.Value13 = reader.GetValueAsString(12);
                    svcADOQuery.Value14 = reader.GetValueAsString(13);
                    svcADOQuery.Value15 = reader.GetValueAsString(14);
                    svcADOQueryItems.Add(svcADOQuery);
                    svcADOQuery = null;
                }
                connection.Close();
            }
            return svcADOQueryItems;
        }

        [Attributes.Method("QueryFirst", MethodType.Read, "Query First Item", "Read Method that returns first row with up to Fifteen columns of data based on the input ADO Query. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
                    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
                    new string[] { "ADOQuery", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public ADOQueryClass QueryFirst()
        {
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

            string polulatedQuery = GetPopulatedQuery();

            using (SOConnection connection = new SOConnection(ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(ServiceConfiguration["Host Server Port"])))
            using (SOCommand command = new SOCommand(polulatedQuery, connection))
            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
            {
                connection.Open();
                while (reader.Read())
                {
                    ADOQueryClass svcADOQuery = new ADOQueryClass();
                    svcADOQuery.Value1 = reader.GetValueAsString(0);
                    svcADOQuery.Value2 = reader.GetValueAsString(1);
                    svcADOQuery.Value3 = reader.GetValueAsString(2);
                    svcADOQuery.Value4 = reader.GetValueAsString(3);
                    svcADOQuery.Value5 = reader.GetValueAsString(4);
                    svcADOQuery.Value6 = reader.GetValueAsString(5);
                    svcADOQuery.Value7 = reader.GetValueAsString(6);
                    svcADOQuery.Value8 = reader.GetValueAsString(7);
                    svcADOQuery.Value9 = reader.GetValueAsString(8);
                    svcADOQuery.Value10 = reader.GetValueAsString(9);
                    svcADOQuery.Value11 = reader.GetValueAsString(10);
                    svcADOQuery.Value12 = reader.GetValueAsString(11);
                    svcADOQuery.Value13 = reader.GetValueAsString(12);
                    svcADOQuery.Value14 = reader.GetValueAsString(13);
                    svcADOQuery.Value15 = reader.GetValueAsString(14);
                    svcADOQueryItems.Add(svcADOQuery);
                    svcADOQuery = null;
                }
                connection.Close();
            }
            if (svcADOQueryItems.Count > 0)
            {
                return svcADOQueryItems[0];
            }
            else
            {
                return new ADOQueryClass();
            }
        }

        [Attributes.Method("QueryLast", MethodType.Read, "Query Last Item", "Read Method that returns last row with up to Fifteen columns of data based on the input ADO Query. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
                    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
                    new string[] { "ADOQuery", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public ADOQueryClass QueryLast()
        {
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

            string polulatedQuery = GetPopulatedQuery();

            using (SOConnection connection = new SOConnection(ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(ServiceConfiguration["Host Server Port"])))
            using (SOCommand command = new SOCommand(polulatedQuery, connection))
            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
            {
                connection.Open();
                while (reader.Read())
                {
                    ADOQueryClass svcADOQuery = new ADOQueryClass();
                    svcADOQuery.Value1 = reader.GetValueAsString(0);
                    svcADOQuery.Value2 = reader.GetValueAsString(1);
                    svcADOQuery.Value3 = reader.GetValueAsString(2);
                    svcADOQuery.Value4 = reader.GetValueAsString(3);
                    svcADOQuery.Value5 = reader.GetValueAsString(4);
                    svcADOQuery.Value6 = reader.GetValueAsString(5);
                    svcADOQuery.Value7 = reader.GetValueAsString(6);
                    svcADOQuery.Value8 = reader.GetValueAsString(7);
                    svcADOQuery.Value9 = reader.GetValueAsString(8);
                    svcADOQuery.Value10 = reader.GetValueAsString(9);
                    svcADOQuery.Value11 = reader.GetValueAsString(10);
                    svcADOQuery.Value12 = reader.GetValueAsString(11);
                    svcADOQuery.Value13 = reader.GetValueAsString(12);
                    svcADOQuery.Value14 = reader.GetValueAsString(13);
                    svcADOQuery.Value15 = reader.GetValueAsString(14);
                    svcADOQueryItems.Add(svcADOQuery);
                    svcADOQuery = null;
                }
                connection.Close();
            }
            if (svcADOQueryItems.Count > 0)
            {
                return svcADOQueryItems[svcADOQueryItems.Count - 1];
            }
            else
            {
                return new ADOQueryClass();
            }
        }

        [Attributes.Method("QueryIndex", MethodType.Read, "Query Item as Index", "Read Method that returns row at index with up to Fifteen columns of data based on the input ADO Query. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
                    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
                    new string[] { "ADOQuery", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public ADOQueryClass QueryIndex(
            [Attributes.Parameter("Index",SoType.Number,"Index","Index of row to return",true)]
            int index = 0
            )
        {
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

            string polulatedQuery = GetPopulatedQuery();

            using (SOConnection connection = new SOConnection(ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(ServiceConfiguration["Host Server Port"])))
            using (SOCommand command = new SOCommand(polulatedQuery, connection))
            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
            {
                connection.Open();
                while (reader.Read())
                {
                    ADOQueryClass svcADOQuery = new ADOQueryClass();
                    svcADOQuery.Value1 = reader.GetValueAsString(0);
                    svcADOQuery.Value2 = reader.GetValueAsString(1);
                    svcADOQuery.Value3 = reader.GetValueAsString(2);
                    svcADOQuery.Value4 = reader.GetValueAsString(3);
                    svcADOQuery.Value5 = reader.GetValueAsString(4);
                    svcADOQuery.Value6 = reader.GetValueAsString(5);
                    svcADOQuery.Value7 = reader.GetValueAsString(6);
                    svcADOQuery.Value8 = reader.GetValueAsString(7);
                    svcADOQuery.Value9 = reader.GetValueAsString(8);
                    svcADOQuery.Value10 = reader.GetValueAsString(9);
                    svcADOQuery.Value11 = reader.GetValueAsString(10);
                    svcADOQuery.Value12 = reader.GetValueAsString(11);
                    svcADOQuery.Value13 = reader.GetValueAsString(12);
                    svcADOQuery.Value14 = reader.GetValueAsString(13);
                    svcADOQuery.Value15 = reader.GetValueAsString(14);
                    svcADOQueryItems.Add(svcADOQuery);
                    svcADOQuery = null;
                }
                connection.Close();
            }
            if (index >= svcADOQueryItems.Count)
            {
                throw new Exception(string.Format("Index position '{0}' could not be found. The number of rows returned by Query was '{1}'.", index, svcADOQueryItems.Count));
            }
            else
            {
                return svcADOQueryItems[index];
            }
        }

        [Attributes.Method("QueryToString", MethodType.Read, "Query to Joined String", "Read Method that returns up to Fifteen columns of data based on the input ADO Query but joined into a string. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
                    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
                    new string[] { "ADOQuery", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public ADOQueryClass QueryToString(
            [Attributes.Parameter("Delimiter",SoType.Text,"Delimiter","Delimiter to use for joining values",false)]
            string delimiter = ";"
            )
        {
            if (string.IsNullOrEmpty(delimiter))
            {
                delimiter = ";";
            }

            ADOQueryClass joinedItems = new ADOQueryClass();
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

            string polulatedQuery = GetPopulatedQuery();

            using (SOConnection connection = new SOConnection(ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(ServiceConfiguration["Host Server Port"])))
            using (SOCommand command = new SOCommand(polulatedQuery, connection))
            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
            {
                connection.Open();
                while (reader.Read())
                {
                    ADOQueryClass svcADOQuery = new ADOQueryClass();
                    svcADOQuery.Value1 = reader.GetValueAsString(0);
                    svcADOQuery.Value2 = reader.GetValueAsString(1);
                    svcADOQuery.Value3 = reader.GetValueAsString(2);
                    svcADOQuery.Value4 = reader.GetValueAsString(3);
                    svcADOQuery.Value5 = reader.GetValueAsString(4);
                    svcADOQuery.Value6 = reader.GetValueAsString(5);
                    svcADOQuery.Value7 = reader.GetValueAsString(6);
                    svcADOQuery.Value8 = reader.GetValueAsString(7);
                    svcADOQuery.Value9 = reader.GetValueAsString(8);
                    svcADOQuery.Value10 = reader.GetValueAsString(9);
                    svcADOQuery.Value11 = reader.GetValueAsString(10);
                    svcADOQuery.Value12 = reader.GetValueAsString(11);
                    svcADOQuery.Value13 = reader.GetValueAsString(12);
                    svcADOQuery.Value14 = reader.GetValueAsString(13);
                    svcADOQuery.Value15 = reader.GetValueAsString(14);
                    svcADOQueryItems.Add(svcADOQuery);
                    svcADOQuery = null;
                }
                connection.Close();
            }
            bool isFirst = true;
            foreach (var item in svcADOQueryItems)
            {
                if (isFirst)
                {
                    isFirst = false;
                    joinedItems.Value1 = item.Value1;
                    joinedItems.Value2 = item.Value2;
                    joinedItems.Value3 = item.Value3;
                    joinedItems.Value4 = item.Value4;
                    joinedItems.Value5 = item.Value5;
                    joinedItems.Value6 = item.Value6;
                    joinedItems.Value7 = item.Value7;
                    joinedItems.Value8 = item.Value8;
                    joinedItems.Value9 = item.Value9;
                    joinedItems.Value10 = item.Value10;
                    joinedItems.Value11 = item.Value11;
                    joinedItems.Value12 = item.Value12;
                    joinedItems.Value13 = item.Value13;
                    joinedItems.Value14 = item.Value14;
                    joinedItems.Value15 = item.Value15;
                }
                else
                {
                    joinedItems.Value1 += delimiter + item.Value1;
                    joinedItems.Value2 += delimiter + item.Value2;
                    joinedItems.Value3 += delimiter + item.Value3;
                    joinedItems.Value4 += delimiter + item.Value4;
                    joinedItems.Value5 += delimiter + item.Value5;
                    joinedItems.Value6 += delimiter + item.Value6;
                    joinedItems.Value7 += delimiter + item.Value7;
                    joinedItems.Value8 += delimiter + item.Value8;
                    joinedItems.Value9 += delimiter + item.Value9;
                    joinedItems.Value10 += delimiter + item.Value10;
                    joinedItems.Value11 += delimiter + item.Value11;
                    joinedItems.Value12 += delimiter + item.Value12;
                    joinedItems.Value13 += delimiter + item.Value13;
                    joinedItems.Value14 += delimiter + item.Value14;
                    joinedItems.Value15 += delimiter + item.Value15;
                }
            }
            return joinedItems;
        }

        [Attributes.Method("SplitStrings", MethodType.List, "Split Strings", "List Method that returns up to Fifteen columns of data based on the input joined strings.",
                    new string[] { },  //required property array (No required properties for this sample)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public List<ADOQueryClass> SplitStrings(
            [Attributes.Parameter("Delimiter",SoType.Text,"Delimiter","Delimiter to use for splitting values",true)]
            string delimiter = ";"
            )
        {
            string[] delim = new string[1];
            delim[0] = delimiter;
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();
            Value1 = Helper.IfNullSetToDefault(Value1);
            Value2 = Helper.IfNullSetToDefault(Value2);
            Value3 = Helper.IfNullSetToDefault(Value3);
            Value4 = Helper.IfNullSetToDefault(Value4);
            Value5 = Helper.IfNullSetToDefault(Value5);
            Value6 = Helper.IfNullSetToDefault(Value6);
            Value7 = Helper.IfNullSetToDefault(Value7);
            Value8 = Helper.IfNullSetToDefault(Value8);
            Value9 = Helper.IfNullSetToDefault(Value9);
            Value10 = Helper.IfNullSetToDefault(Value10);
            Value11 = Helper.IfNullSetToDefault(Value11);
            Value12 = Helper.IfNullSetToDefault(Value12);
            Value13 = Helper.IfNullSetToDefault(Value13);
            Value14 = Helper.IfNullSetToDefault(Value14);
            Value15 = Helper.IfNullSetToDefault(Value15);

            string[] Value1Array = Value1.Split(delim, StringSplitOptions.None);
            string[] Value2Array = Value2.Split(delim, StringSplitOptions.None);
            string[] Value3Array = Value3.Split(delim, StringSplitOptions.None);
            string[] Value4Array = Value4.Split(delim, StringSplitOptions.None);
            string[] Value5Array = Value5.Split(delim, StringSplitOptions.None);
            string[] Value6Array = Value6.Split(delim, StringSplitOptions.None);
            string[] Value7Array = Value7.Split(delim, StringSplitOptions.None);
            string[] Value8Array = Value8.Split(delim, StringSplitOptions.None);
            string[] Value9Array = Value9.Split(delim, StringSplitOptions.None);
            string[] Value10Array = Value10.Split(delim, StringSplitOptions.None);
            string[] Value11Array = Value11.Split(delim, StringSplitOptions.None);
            string[] Value12Array = Value12.Split(delim, StringSplitOptions.None);
            string[] Value13Array = Value13.Split(delim, StringSplitOptions.None);
            string[] Value14Array = Value14.Split(delim, StringSplitOptions.None);
            string[] Value15Array = Value15.Split(delim, StringSplitOptions.None);

            for (int i = 0; i < Value1Array.Length; i++)
            {
                ADOQueryClass svcADOQuery = new ADOQueryClass();
                svcADOQuery.Value1 = Helper.GetValueAtIndex(Value1Array, i);
                svcADOQuery.Value2 = Helper.GetValueAtIndex(Value2Array, i);
                svcADOQuery.Value3 = Helper.GetValueAtIndex(Value3Array, i);
                svcADOQuery.Value4 = Helper.GetValueAtIndex(Value4Array, i);
                svcADOQuery.Value5 = Helper.GetValueAtIndex(Value5Array, i);
                svcADOQuery.Value6 = Helper.GetValueAtIndex(Value6Array, i);
                svcADOQuery.Value7 = Helper.GetValueAtIndex(Value7Array, i);
                svcADOQuery.Value8 = Helper.GetValueAtIndex(Value8Array, i);
                svcADOQuery.Value9 = Helper.GetValueAtIndex(Value9Array, i);
                svcADOQuery.Value10 = Helper.GetValueAtIndex(Value10Array, i);
                svcADOQuery.Value11 = Helper.GetValueAtIndex(Value11Array, i);
                svcADOQuery.Value12 = Helper.GetValueAtIndex(Value12Array, i);
                svcADOQuery.Value13 = Helper.GetValueAtIndex(Value13Array, i);
                svcADOQuery.Value14 = Helper.GetValueAtIndex(Value14Array, i);
                svcADOQuery.Value15 = Helper.GetValueAtIndex(Value15Array, i);
                svcADOQueryItems.Add(svcADOQuery);
            }
            return svcADOQueryItems;
        }


        //TODO:Execute SMO For Each Result Row
        //TODO:Execute ADO Query (No Results) For Each Result Row
        //TODO:Execute ADO Query (Union Results) For Each Result Row
        //TODO:Execute ADO Query (Union  Distinct Results) For Each Result Row

        #endregion

        #region Helper Methods
        private string GetPopulatedQuery()
        {
            string polulatedQuery = sADOQuery;
            polulatedQuery = Regex.Replace(polulatedQuery, "{value1}", Value1 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value2}", Value2 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value3}", Value3 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value4}", Value4 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value5}", Value5 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value6}", Value6 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value7}", Value7 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value8}", Value8 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value9}", Value9 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value10}", Value10 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value11}", Value11 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value12}", Value12 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value13}", Value13 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value14}", Value14 ?? "", RegexOptions.IgnoreCase);
            polulatedQuery = Regex.Replace(polulatedQuery, "{value15}", Value15 ?? "", RegexOptions.IgnoreCase);
            return polulatedQuery;
        }
        #endregion
    }
}