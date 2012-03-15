//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;

namespace Rock.CRM.DTO
{
    /// <summary>
    /// Person Viewed Data Transfer Object.
    /// </summary>
	/// <remarks>
	/// Data Transfer Objects are a lightweight version of the Entity object that are used
	/// in situations like serializing the object in the REST api
	/// </remarks>
    public partial class PersonViewed
    {
        /// <summary>
        /// The Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the GUID.
        /// </summary>
        /// <value>
        /// The GUID.
        /// </value>
        public Guid Guid { get; set; }

		/// <summary>
		/// Gets or sets the Viewer Person Id.
		/// </summary>
		/// <value>
		/// Viewer Person Id.
		/// </value>
		public int? ViewerPersonId { get; set; }

		/// <summary>
		/// Gets or sets the Target Person Id.
		/// </summary>
		/// <value>
		/// Target Person Id.
		/// </value>
		public int? TargetPersonId { get; set; }

		/// <summary>
		/// Gets or sets the View Date Time.
		/// </summary>
		/// <value>
		/// View Date Time.
		/// </value>
		public DateTime? ViewDateTime { get; set; }

		/// <summary>
		/// Gets or sets the Ip Address.
		/// </summary>
		/// <value>
		/// Ip Address.
		/// </value>
		public string IpAddress { get; set; }

		/// <summary>
		/// Gets or sets the Source.
		/// </summary>
		/// <value>
		/// Source.
		/// </value>
		public string Source { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonViewedDTO"/> class.
        /// </summary>
		public PersonViewed()
		{
		}
	}
}