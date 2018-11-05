using System;
using SourceCode.SmartObjects.Services.Interfaces;
using SourceCode.SmartObjects.Services.ServiceSDK;

namespace SourceCode.SmartObjects.Services.Data
{
    internal class DataConnector : IDataConnector
    {
        #region Class Level Fields

        #region Constants
        private const string TYPEMAPPINGS = "Type Mappings";
        #endregion

        #region Private Fields
        private ServiceAssemblyBase serviceBroker = null;
        private string configHostServerName = string.Empty;
        private string configHostServerPort = string.Empty;
        #endregion

        #endregion

        #region Constructor
        public DataConnector(ServiceAssemblyBase serviceBroker)
        {
            this.serviceBroker = serviceBroker;
        }
        #endregion

        #region Methods

        #region void SetupConfiguration()
        public void SetupConfiguration()
        {
            serviceBroker.Service.ServiceConfiguration.Add("Host Server Name", true, "localhost");
            serviceBroker.Service.ServiceConfiguration.Add("Host Server Port", true, "5555");
        }
        #endregion

        #region void GetConfiguration()
        public void GetConfiguration()
        {
            configHostServerName = serviceBroker.Service.ServiceConfiguration["Host Server Name"].ToString();
            configHostServerPort = serviceBroker.Service.ServiceConfiguration["Host Server Port"].ToString();
        }
        #endregion

        #region void SetupService()
        public void SetupService()
        {
            serviceBroker.Service.Name = GetType().Namespace;
            string friendlyName = "Advanced ADO Service";
            serviceBroker.Service.MetaData.DisplayName = friendlyName;
            serviceBroker.Service.MetaData.Description = friendlyName;
        }
        #endregion

        #region void DescribeSchema()
        public void DescribeSchema()
        {
            Type[] types = GetType().Assembly.GetTypes();
            foreach (Type t in types)
            {
                if (t.IsClass)
                {
                    if (t.GetCustomAttributes(typeof(SourceCode.SmartObjects.Services.ServiceSDK.Attributes.ServiceObjectAttribute), false).Length > 0)
                    {
                        serviceBroker.Service.ServiceObjects.Create(new SourceCode.SmartObjects.Services.ServiceSDK.Objects.ServiceObject(t));
                    }
                }
            }
        }
        #endregion

        #region void Dispose()
        public void Dispose()
        {
            serviceBroker = null;
        }
        #endregion

        #endregion
    }
}