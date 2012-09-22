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

using Rock.Data;

namespace Rock.Crm
{
	/// <summary>
	/// Data Transfer Object for Campus object
	/// </summary>
	public partial class CampusDto : IDto
	{

#pragma warning disable 1591
		public bool IsSystem { get; set; }
		public string Name { get; set; }
		public DateTime? CreatedDateTime { get; set; }
		public DateTime? ModifiedDateTime { get; set; }
		public int? CreatedByPersonId { get; set; }
		public int? ModifiedByPersonId { get; set; }
		public int Id { get; set; }
		public Guid Guid { get; set; }
#pragma warning restore 1591

		/// <summary>
		/// Instantiates a new DTO object
		/// </summary>
		public CampusDto ()
		{
		}

		/// <summary>
		/// Instantiates a new DTO object from the model
		/// </summary>
		/// <param name="campus"></param>
		public CampusDto ( Campus campus )
		{
			CopyFromModel( campus );
		}

		/// <summary>
		/// Copies the model property values to the DTO properties
		/// </summary>
		/// <param name="campus"></param>
		public void CopyFromModel( IModel model )
		{
			if ( model is Campus )
			{
				var campus = (Campus)model;
				this.IsSystem = campus.IsSystem;
				this.Name = campus.Name;
				this.CreatedDateTime = campus.CreatedDateTime;
				this.ModifiedDateTime = campus.ModifiedDateTime;
				this.CreatedByPersonId = campus.CreatedByPersonId;
				this.ModifiedByPersonId = campus.ModifiedByPersonId;
				this.Id = campus.Id;
				this.Guid = campus.Guid;
			}
		}

		/// <summary>
		/// Copies the DTO property values to the model properties
		/// </summary>
		/// <param name="campus"></param>
		public void CopyToModel ( IModel model )
		{
			if ( model is Campus )
			{
				var campus = (Campus)model;
				campus.IsSystem = this.IsSystem;
				campus.Name = this.Name;
				campus.CreatedDateTime = this.CreatedDateTime;
				campus.ModifiedDateTime = this.ModifiedDateTime;
				campus.CreatedByPersonId = this.CreatedByPersonId;
				campus.ModifiedByPersonId = this.ModifiedByPersonId;
				campus.Id = this.Id;
				campus.Guid = this.Guid;
			}
		}
	}
}