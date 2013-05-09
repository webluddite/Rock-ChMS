//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// FinancialScheduledTransactionDetail Service class
    /// </summary>
    public partial class FinancialScheduledTransactionDetailService : Service<FinancialScheduledTransactionDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialScheduledTransactionDetailService"/> class
        /// </summary>
        public FinancialScheduledTransactionDetailService()
            : base( new EFRepository<FinancialScheduledTransactionDetail>( new Rock.Data.RockContext() ) )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialScheduledTransactionDetailService"/> class
        /// </summary>
        public FinancialScheduledTransactionDetailService(IRepository<FinancialScheduledTransactionDetail> repository) : base(repository)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( FinancialScheduledTransactionDetail item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static class FinancialScheduledTransactionDetailExtensionMethods
    {
        /// <summary>
        /// Clones this FinancialScheduledTransactionDetail object to a new FinancialScheduledTransactionDetail object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static FinancialScheduledTransactionDetail Clone( this FinancialScheduledTransactionDetail source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as FinancialScheduledTransactionDetail;
            }
            else
            {
                var target = new FinancialScheduledTransactionDetail();
                target.ScheduledTransactionId = source.ScheduledTransactionId;
                target.AccountId = source.AccountId;
                target.Amount = source.Amount;
                target.Summary = source.Summary;
                target.EntityTypeId = source.EntityTypeId;
                target.EntityId = source.EntityId;
                target.Id = source.Id;
                target.Guid = source.Guid;

            
                return target;
            }
        }
    }
}