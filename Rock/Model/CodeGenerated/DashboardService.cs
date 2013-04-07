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
    /// Dashboard Service class
    /// </summary>
    public partial class DashboardService : Service<Dashboard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardService"/> class
        /// </summary>
        public DashboardService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardService"/> class
        /// </summary>
        public DashboardService(IRepository<Dashboard> repository) : base(repository)
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
        public bool CanDelete( Dashboard item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static class DashboardExtensionMethods
    {
        /// <summary>
        /// Clones this Dashboard object to a new Dashboard object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static Dashboard Clone( this Dashboard source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as Dashboard;
            }
            else
            {
                var target = new Dashboard();
                target.IsSystem = source.IsSystem;
                target.MetricId = source.MetricId;
                target.PersonId = source.PersonId;
                target.Description = source.Description;
                target.StartDate = source.StartDate;
                target.EndDate = source.EndDate;
                target.Size = source.Size;
                target.Order = source.Order;
                target.Id = source.Id;
                target.Guid = source.Guid;

            
                return target;
            }
        }
    }
}
