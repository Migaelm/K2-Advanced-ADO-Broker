using System;
using System.Collections.Generic;
using System.Text;
using SourceCode.SmartObjects.Services.ServiceSDK.Objects;
using Attributes = SourceCode.SmartObjects.Services.ServiceSDK.Attributes;
using SourceCode.SmartObjects.Services.ServiceSDK.Types;
using SourceCode.Data.SmartObjectsClient;
using SourceCode.SmartObjects.Services.Helpers;
using System.Text.RegularExpressions;

namespace SourceCode.SmartObjects.Services.Data
{
    /// <summary>
    /// Sample implementation of a Static Service Object.
    /// The class is decorated with a ServiceObject Attribute providing definition information for the Service Object.
    /// The Properties and Methods in the class are each decorated with attributes that describe them in Service Object terms
    /// This sample implementation contains two Properties (Number and Text) and two Methods (Read and List)
    /// </summary>
    [Attributes.ServiceObject("ADOQueryService", "ADO Query Service", "ADO Query Service")]
    class ADOQueryClass
    {

        /// <summary>
        /// This property is required if you want to get the service instance configuration 
        /// settings in this class
        /// </summary>
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
        /// Property
        /// </summary>
        [Attributes.Property("Value1", SoType.Text, "Value1", "First Column that is being returned")]
        public string Value1
        {
            get { return sValue; }
            set { sValue = value; }
        }
        [Attributes.Property("Value2", SoType.Text, "Value2", "Second Column that is being returned")]
        public string Value2
        {
            get { return sValue2; }
            set { sValue2 = value; }
        }
        [Attributes.Property("Value3", SoType.Text, "Value3", "Third Column that is being returned")]
        public string Value3
        {
            get { return sValue3; }
            set { sValue3 = value; }
        }
        [Attributes.Property("Value4", SoType.Text, "Value4", "Fourth Column that is being returned")]
        public string Value4
        {
            get { return sValue4; }
            set { sValue4 = value; }
        }
        [Attributes.Property("Value5", SoType.Text, "Value5", "Fifth Column that is being returned")]
        public string Value5
        {
            get { return sValue5; }
            set { sValue5 = value; }
        }
        [Attributes.Property("Value6", SoType.Text, "Value6", "Sixth Column that is being returned")]
        public string Value6
        {
            get { return sValue6; }
            set { sValue6 = value; }
        }
        [Attributes.Property("Value7", SoType.Text, "Value7", "Seventh Column that is being returned")]
        public string Value7
        {
            get { return sValue7; }
            set { sValue7 = value; }
        }
        [Attributes.Property("Value8", SoType.Text, "Value8", "Eighth Column that is being returned")]
        public string Value8
        {
            get { return sValue8; }
            set { sValue8 = value; }
        }
        [Attributes.Property("Value9", SoType.Text, "Value9", "Ninth Column that is being returned")]
        public string Value9
        {
            get { return sValue9; }
            set { sValue9 = value; }
        }
        [Attributes.Property("Value10", SoType.Text, "Value10", "Tenth Column that is being returned")]
        public string Value10
        {
            get { return sValue10; }
            set { sValue10 = value; }
        }
        [Attributes.Property("Value11", SoType.Text, "Value11", "Eleventh Column that is being returned")]
        public string Value11
        {
            get { return sValue11; }
            set { sValue11 = value; }
        }
        [Attributes.Property("Value12", SoType.Text, "Value12", "Twelveth Column that is being returned")]
        public string Value12
        {
            get { return sValue12; }
            set { sValue12 = value; }
        }
        [Attributes.Property("Value13", SoType.Text, "Value13", "Thirteenth Column that is being returned")]
        public string Value13
        {
            get { return sValue13; }
            set { sValue13 = value; }
        }
        [Attributes.Property("Value14", SoType.Text, "Value14", "Fourteenth Column that is being returned")]
        public string Value14
        {
            get { return sValue14; }
            set { sValue14 = value; }
        }
        [Attributes.Property("Value15", SoType.Text, "Value15", "Fifteenth Column that is being returned")]
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

        #region List<StaticServiceObject1>  ListMethod(Property[] input, RequiredProperties required, Property[] returns, MethodType methodType, ServiceObject serviceObject)
        #region Old Methods
        //        /// <summary>
        //        /// Sample implementation of a static service Object List method
        //        /// The method is decorated with a Method Attribute which describes the Service Object Method.
        //        /// Note that the method must return a List of the class type, and the method should not include any input parameters
        //        /// The Properties for the class will automatically be populated by K2 using the Property arrays passed into the method
        //        /// </summary>
        //        [Attributes.Method("List", MethodType.List, "List Method", "List Method that returns a single column of data",
        //            new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
        //            new string[] { "ADOQuery" }, //input property array (no optional properties)
        //            new string[] { "Value1" })] //return property 1-column array
        //        public List<ADOQueryClass> ListMethod()
        //        {
        //            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

        //            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
        //            using (SOCommand command = new SOCommand(sADOQuery, connection))
        //            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //            {
        //                connection.Open();
        //                while (reader.Read())
        //                {
        //                    ADOQueryClass svcADOQuery = new ADOQueryClass();
        //                    svcADOQuery.Value1 = reader.GetValue(0).ToString();
        //                    svcADOQueryItems.Add(svcADOQuery);
        //                    svcADOQuery = null;
        //                }
        //                connection.Close();
        //            }
        //            return svcADOQueryItems;
        //        }

        //        [Attributes.Method("List2", MethodType.List, "List2 Method", "List Method that returns two columns of data",
        //    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
        //    new string[] { "ADOQuery" }, //input property array (no optional properties)
        //    new string[] { "Value1", "Value2" })] //return property 1-column array
        //        public List<ADOQueryClass> ListMethod2()
        //        {
        //            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

        //            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
        //            using (SOCommand command = new SOCommand(sADOQuery, connection))
        //            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //            {
        //                connection.Open();
        //                while (reader.Read())
        //                {
        //                    ADOQueryClass svcADOQuery = new ADOQueryClass();
        //                    svcADOQuery.Value1 = reader.GetValue(0).ToString();
        //                    svcADOQuery.Value2 = reader.GetValue(1).ToString();
        //                    svcADOQueryItems.Add(svcADOQuery);
        //                    svcADOQuery = null;
        //                }
        //                connection.Close();
        //            }
        //            return svcADOQueryItems;
        //        }

        //        [Attributes.Method("List3", MethodType.List, "List3 Method", "List Method that returns three columns of data",
        //new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
        //new string[] { "ADOQuery" }, //input property array (no optional properties)
        //new string[] { "Value1", "Value2", "Value3" })] //return property 1-column array
        //        public List<ADOQueryClass> ListMethod3()
        //        {
        //            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

        //            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
        //            using (SOCommand command = new SOCommand(sADOQuery, connection))
        //            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //            {
        //                connection.Open();
        //                while (reader.Read())
        //                {
        //                    ADOQueryClass svcADOQuery = new ADOQueryClass();
        //                    svcADOQuery.Value1 = reader.GetValue(0).ToString();
        //                    svcADOQuery.Value2 = reader.GetValue(1).ToString();
        //                    svcADOQuery.Value3 = reader.GetValue(2).ToString();
        //                    svcADOQueryItems.Add(svcADOQuery);
        //                    svcADOQuery = null;
        //                }
        //                connection.Close();
        //            }
        //            return svcADOQueryItems;
        //        }

        //        [Attributes.Method("List4", MethodType.List, "List4 Method", "List Method that returns four columns of data",
        //new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
        //new string[] { "ADOQuery" }, //input property array (no optional properties)
        //new string[] { "Value1", "Value2", "Value3", "Value4" })] //return property 1-column array
        //        public List<ADOQueryClass> ListMethod4()
        //        {
        //            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

        //            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
        //            using (SOCommand command = new SOCommand(sADOQuery, connection))
        //            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //            {
        //                connection.Open();
        //                while (reader.Read())
        //                {
        //                    ADOQueryClass svcADOQuery = new ADOQueryClass();
        //                    svcADOQuery.Value1 = reader.GetValue(0).ToString();
        //                    svcADOQuery.Value2 = reader.GetValue(1).ToString();
        //                    svcADOQuery.Value3 = reader.GetValue(2).ToString();
        //                    svcADOQuery.Value4 = reader.GetValue(3).ToString();
        //                    svcADOQueryItems.Add(svcADOQuery);
        //                    svcADOQuery = null;
        //                }
        //                connection.Close();
        //            }
        //            return svcADOQueryItems;
        //        }

        //        [Attributes.Method("List5", MethodType.List, "List5 Method", "List Method that returns five columns of data",
        //new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
        //new string[] { "ADOQuery" }, //input property array (no optional properties)
        //new string[] { "Value1", "Value2", "Value3", "Value4", "Value5" })] //return property 1-column array
        //        public List<ADOQueryClass> ListMethod5()
        //        {
        //            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

        //            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
        //            using (SOCommand command = new SOCommand(sADOQuery, connection))
        //            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //            {
        //                connection.Open();
        //                while (reader.Read())
        //                {
        //                    ADOQueryClass svcADOQuery = new ADOQueryClass();
        //                    svcADOQuery.Value1 = reader.GetValue(0).ToString();
        //                    svcADOQuery.Value2 = reader.GetValue(1).ToString();
        //                    svcADOQuery.Value3 = reader.GetValue(2).ToString();
        //                    svcADOQuery.Value4 = reader.GetValue(3).ToString();
        //                    svcADOQuery.Value5 = reader.GetValue(4).ToString();
        //                    svcADOQueryItems.Add(svcADOQuery);
        //                    svcADOQuery = null;
        //                }
        //                connection.Close();
        //            }
        //            return svcADOQueryItems;
        //        }

        //        [Attributes.Method("List6", MethodType.List, "List6 Method", "List Method that returns six columns of data",
        //new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
        //new string[] { "ADOQuery" }, //input property array (no optional properties)
        //new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6" })] //return property 1-column array
        //        public List<ADOQueryClass> ListMethod6()
        //        {
        //            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

        //            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
        //            using (SOCommand command = new SOCommand(sADOQuery, connection))
        //            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //            {
        //                connection.Open();
        //                while (reader.Read())
        //                {
        //                    ADOQueryClass svcADOQuery = new ADOQueryClass();
        //                    svcADOQuery.Value1 = reader.GetValue(0).ToString();
        //                    svcADOQuery.Value2 = reader.GetValue(1).ToString();
        //                    svcADOQuery.Value3 = reader.GetValue(2).ToString();
        //                    svcADOQuery.Value4 = reader.GetValue(3).ToString();
        //                    svcADOQuery.Value5 = reader.GetValue(4).ToString();
        //                    svcADOQuery.Value6 = reader.GetValue(5).ToString();
        //                    svcADOQueryItems.Add(svcADOQuery);
        //                    svcADOQuery = null;
        //                }
        //                connection.Close();
        //            }
        //            return svcADOQueryItems;
        //        }

        //        [Attributes.Method("List7", MethodType.List, "List7 Method", "List Method that returns seven columns of data",
        //new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
        //new string[] { "ADOQuery" }, //input property array (no optional properties)
        //new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7" })] //return property 1-column array
        //        public List<ADOQueryClass> ListMethod7()
        //        {
        //            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

        //            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
        //            using (SOCommand command = new SOCommand(sADOQuery, connection))
        //            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //            {
        //                connection.Open();
        //                while (reader.Read())
        //                {
        //                    ADOQueryClass svcADOQuery = new ADOQueryClass();
        //                    svcADOQuery.Value1 = reader.GetValue(0).ToString();
        //                    svcADOQuery.Value2 = reader.GetValue(1).ToString();
        //                    svcADOQuery.Value3 = reader.GetValue(2).ToString();
        //                    svcADOQuery.Value4 = reader.GetValue(3).ToString();
        //                    svcADOQuery.Value5 = reader.GetValue(4).ToString();
        //                    svcADOQuery.Value6 = reader.GetValue(5).ToString();
        //                    svcADOQuery.Value7 = reader.GetValue(6).ToString();
        //                    svcADOQueryItems.Add(svcADOQuery);
        //                    svcADOQuery = null;
        //                }
        //                connection.Close();
        //            }
        //            return svcADOQueryItems;
        //        }

        //        [Attributes.Method("List8", MethodType.List, "List8 Method", "List Method that returns eight columns of data",
        //new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
        //new string[] { "ADOQuery" }, //input property array (no optional properties)
        //new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8" })] //return property 1-column array
        //        public List<ADOQueryClass> ListMethod8()
        //        {
        //            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

        //            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
        //            using (SOCommand command = new SOCommand(sADOQuery, connection))
        //            using (SODataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //            {
        //                connection.Open();
        //                while (reader.Read())
        //                {
        //                    ADOQueryClass svcADOQuery = new ADOQueryClass();
        //                    svcADOQuery.Value1 = reader.GetValue(0).ToString();
        //                    svcADOQuery.Value2 = reader.GetValue(1).ToString();
        //                    svcADOQuery.Value3 = reader.GetValue(2).ToString();
        //                    svcADOQuery.Value4 = reader.GetValue(3).ToString();
        //                    svcADOQuery.Value5 = reader.GetValue(4).ToString();
        //                    svcADOQuery.Value6 = reader.GetValue(5).ToString();
        //                    svcADOQuery.Value7 = reader.GetValue(6).ToString();
        //                    svcADOQuery.Value8 = reader.GetValue(7).ToString();
        //                    svcADOQueryItems.Add(svcADOQuery);
        //                    svcADOQuery = null;
        //                }
        //                connection.Close();
        //            }
        //            return svcADOQueryItems;
        //        }
        #endregion

        [Attributes.Method("Query", MethodType.List, "Query", "List Method that returns Fifteen columns of data based on the input ADO Query. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
                    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
                    new string[] { "ADOQuery", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public List<ADOQueryClass> Query()
        {
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();
            string polulatedQuery = GetPopulatedQuery();

            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
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

        [Attributes.Method("QueryFirst", MethodType.Read, "Query First Item", "Read Method that returns first row with Fifteen columns of data based on the input ADO Query. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
                    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
                    new string[] { "ADOQuery", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public ADOQueryClass QueryFirst()
        {
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

            string polulatedQuery = GetPopulatedQuery();

            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
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
                return svcADOQueryItems[0];
            else
                return new ADOQueryClass();
        }

        [Attributes.Method("QueryLast", MethodType.Read, "Query Last Item", "Read Method that returns last row with Fifteen columns of data based on the input ADO Query. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
                    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
                    new string[] { "ADOQuery", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public ADOQueryClass QueryLast()
        {
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

            string polulatedQuery = GetPopulatedQuery();

            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
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
                return svcADOQueryItems[svcADOQueryItems.Count - 1];
            else
                return new ADOQueryClass();
        }

        [Attributes.Method("QueryIndex", MethodType.Read, "Query Item as Index", "Read Method that returns row at index with Fifteen columns of data based on the input ADO Query. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
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

            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
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
                throw new Exception(string.Format("Index position '{0}' could not be found. The number of rows returned by Query was '{1}'.", index, svcADOQueryItems.Count));
            else
                return svcADOQueryItems[index];
        }

        [Attributes.Method("QueryToString", MethodType.Read, "Query to Joined String", "Read Method that returns Fifteen columns of data based on the input ADO Query but joined into a string. You can use placeholders in the query (E.g \"{value1}\" or \"{value15}\") to reference the input properties.",
                    new string[] { "ADOQuery" },  //required property array (No required properties for this sample)
                    new string[] { "ADOQuery", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" }, //input property array (no optional properties)
                    new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9", "Value10", "Value11", "Value12", "Value13", "Value14", "Value15" })] //return property 1-column array
        public ADOQueryClass QueryToString(
            [Attributes.Parameter("Delimiter",SoType.Text,"Delimiter","Delimiter to use for joining values",false)]
            string delimiter = ";"
            )
        {
            if (string.IsNullOrEmpty(delimiter))
                delimiter = ";";
            ADOQueryClass joinedItems = new ADOQueryClass();
            List<ADOQueryClass> svcADOQueryItems = new List<ADOQueryClass>();

            string polulatedQuery = GetPopulatedQuery();

            using (SOConnection connection = new SOConnection(this.ServiceConfiguration["Host Server Name"].ToString(), Convert.ToInt32(this.ServiceConfiguration["Host Server Port"])))
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

        //TODO:Split Values
        //TODO:Execute SMO For Each Result Row
        //TODO:Execute ADO Query (No Results) For Each Result Row
        //TODO:Execute ADO Query (Union Results) For Each Result Row
        //TODO:Execute ADO Query (Union  Distinct Results) For Each Result Row

        #endregion
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