using System;
using System.Transactions;
using SourceCode.SmartObjects.Services.Data;
using SourceCode.SmartObjects.Services.ServiceSDK;
using SourceCode.SmartObjects.Services.ServiceSDK.Objects;
using SourceCode.SmartObjects.Services.ServiceSDK.Types;

namespace SourceCode.SmartObjects.Services.ADO
{

    class AdvancedQueryService : ServiceAssemblyBase
    {
        #region Default Constructor
        public AdvancedQueryService()
        {
            // No implementation necessary.
        }
        #endregion

        #region Methods

        #region Service Interaction Methods

        #region override string DescribeSchema()
        public override string DescribeSchema()
        {
            try
            {
                using (DataConnector connector = new DataConnector(this))
                {
                    connector.GetConfiguration();
                    connector.DescribeSchema();
                    connector.SetupService();
                }
                ServicePackage.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                ServicePackage.ServiceMessages.Add(ex.Message, MessageSeverity.Error);
                ServicePackage.IsSuccessful = false;
            }

            return base.DescribeSchema();
        }
        #endregion

        #region override string GetConfigSection()
        public override string GetConfigSection()
        {
            try
            {
                using (DataConnector connector = new DataConnector(this))
                {
                    connector.SetupConfiguration();
                }
            }
            catch (Exception ex)
            {
                ServicePackage.ServiceMessages.Add(ex.Message, MessageSeverity.Error);
            }

            return base.GetConfigSection();
        }
        #endregion

        #region override void Extend()
        public override void Extend()
        {
            try
            {
                throw new NotImplementedException("Service Object \"Extend()\" is not implemented.");
            }
            catch (Exception ex)
            {
                ServicePackage.ServiceMessages.Add(ex.Message, MessageSeverity.Error);
                ServicePackage.IsSuccessful = false;
            }
        }
        #endregion

        #endregion

        #region Transaction Support Methods

        #region void Commit(Enlistment enlistment)
        /// <summary>
        /// Responds to the Commit notification.
        /// </summary>
        /// <param name="enlistment">An Enlistment that facilitates communication between the enlisted transaction participant and the transaction manager during the final phase of the transaction.</param>
        public override void Commit(Enlistment enlistment)
        {
            if (enlistment != null)
            {
                // Indicate that the transaction participant has completed its work.
                enlistment.Done();
            }
        }
        #endregion

        #region void InDoubt(Enlistment enlistment)
        /// <summary>
        /// Responds to the InDoubt notification.
        /// </summary>
        /// <param name="enlistment">An Enlistment that facilitates communication between the enlisted transaction participant and the transaction manager during the final phase of the transaction.</param>
        public override void InDoubt(Enlistment enlistment)
        {
            if (enlistment != null)
            {
                // Indicate that the transaction participant has completed its work.
                enlistment.Done();
            }
        }
        #endregion

        #region void Prepare(PreparingEnlistment preparingEnlistment)
        /// <summary>
        /// Responds to the Prepare notification.
        /// </summary>
        /// <param name="preparingEnlistment">An Enlistment that facilitates communication between the enlisted transaction participant and the transaction manager during the Prepare phase of the transaction.</param>
        public override void Prepare(PreparingEnlistment preparingEnlistment)
        {
            // Allow the base class to handle the Prepare notification.
            base.Prepare(preparingEnlistment);
        }
        #endregion

        #region void Rollback(Enlistment enlistment)
        /// <summary>
        /// Responds to the Rollback notification.
        /// </summary>
        /// <param name="enlistment">An Enlistment that facilitates communication between the enlisted transaction participant and the transaction manager during the final phase of the transaction.</param>
        public override void Rollback(Enlistment enlistment)
        {
            if (enlistment != null)
            {
                // Indicate that the transaction participant has completed its work.
                enlistment.Done();
            }
        }
        #endregion

        #endregion

        #endregion
    }
}