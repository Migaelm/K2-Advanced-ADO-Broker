using System;

namespace SourceCode.SmartObjects.Services.Interfaces
{
    interface IDataConnector : IDisposable
    {
        #region Methods

        #region void GetConfiguration()
        void GetConfiguration();
        #endregion

        #region void SetupConfiguration()
        void SetupConfiguration();
        #endregion

        #region void SetupService()
        void SetupService();
        #endregion

        #region void DescribeSchema()
        void DescribeSchema();
        #endregion

        #endregion
    }
}