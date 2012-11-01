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
using System.Collections.Generic;
using System.Dynamic;

using Rock.Data;

namespace Rock.Util
{
    /// <summary>
    /// Data Transfer Object for Job object
    /// </summary>
    public partial class JobDto : IDto
    {

#pragma warning disable 1591
        public bool IsSystem { get; set; }
        public bool? IsActive { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Assemby { get; set; }
        public string Class { get; set; }
        public string CronExpression { get; set; }
        public DateTime? LastSuccessfulRun { get; set; }
        public DateTime? LastRunDate { get; set; }
        public int? LastRunDuration { get; set; }
        public string LastStatus { get; set; }
        public string LastStatusMessage { get; set; }
        public string LastRunSchedulerName { get; set; }
        public string NotificationEmails { get; set; }
        public JobNotificationStatus NotificationStatus { get; set; }
        public int Id { get; set; }
        public Guid Guid { get; set; }
#pragma warning restore 1591

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public JobDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="job"></param>
        public JobDto ( Job job )
        {
            CopyFromModel( job );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<string, object> ToDictionary()
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add( "IsSystem", this.IsSystem );
            dictionary.Add( "IsActive", this.IsActive );
            dictionary.Add( "Name", this.Name );
            dictionary.Add( "Description", this.Description );
            dictionary.Add( "Assemby", this.Assemby );
            dictionary.Add( "Class", this.Class );
            dictionary.Add( "CronExpression", this.CronExpression );
            dictionary.Add( "LastSuccessfulRun", this.LastSuccessfulRun );
            dictionary.Add( "LastRunDate", this.LastRunDate );
            dictionary.Add( "LastRunDuration", this.LastRunDuration );
            dictionary.Add( "LastStatus", this.LastStatus );
            dictionary.Add( "LastStatusMessage", this.LastStatusMessage );
            dictionary.Add( "LastRunSchedulerName", this.LastRunSchedulerName );
            dictionary.Add( "NotificationEmails", this.NotificationEmails );
            dictionary.Add( "NotificationStatus", this.NotificationStatus );
            dictionary.Add( "Id", this.Id );
            dictionary.Add( "Guid", this.Guid );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public virtual dynamic ToDynamic()
        {
            dynamic expando = new ExpandoObject();
            expando.IsSystem = this.IsSystem;
            expando.IsActive = this.IsActive;
            expando.Name = this.Name;
            expando.Description = this.Description;
            expando.Assemby = this.Assemby;
            expando.Class = this.Class;
            expando.CronExpression = this.CronExpression;
            expando.LastSuccessfulRun = this.LastSuccessfulRun;
            expando.LastRunDate = this.LastRunDate;
            expando.LastRunDuration = this.LastRunDuration;
            expando.LastStatus = this.LastStatus;
            expando.LastStatusMessage = this.LastStatusMessage;
            expando.LastRunSchedulerName = this.LastRunSchedulerName;
            expando.NotificationEmails = this.NotificationEmails;
            expando.NotificationStatus = this.NotificationStatus;
            expando.Id = this.Id;
            expando.Guid = this.Guid;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyFromModel( IEntity model )
        {
            if ( model is Job )
            {
                var job = (Job)model;
                this.IsSystem = job.IsSystem;
                this.IsActive = job.IsActive;
                this.Name = job.Name;
                this.Description = job.Description;
                this.Assemby = job.Assemby;
                this.Class = job.Class;
                this.CronExpression = job.CronExpression;
                this.LastSuccessfulRun = job.LastSuccessfulRun;
                this.LastRunDate = job.LastRunDate;
                this.LastRunDuration = job.LastRunDuration;
                this.LastStatus = job.LastStatus;
                this.LastStatusMessage = job.LastStatusMessage;
                this.LastRunSchedulerName = job.LastRunSchedulerName;
                this.NotificationEmails = job.NotificationEmails;
                this.NotificationStatus = job.NotificationStatus;
                this.Id = job.Id;
                this.Guid = job.Guid;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyToModel ( IEntity model )
        {
            if ( model is Job )
            {
                var job = (Job)model;
                job.IsSystem = this.IsSystem;
                job.IsActive = this.IsActive;
                job.Name = this.Name;
                job.Description = this.Description;
                job.Assemby = this.Assemby;
                job.Class = this.Class;
                job.CronExpression = this.CronExpression;
                job.LastSuccessfulRun = this.LastSuccessfulRun;
                job.LastRunDate = this.LastRunDate;
                job.LastRunDuration = this.LastRunDuration;
                job.LastStatus = this.LastStatus;
                job.LastStatusMessage = this.LastStatusMessage;
                job.LastRunSchedulerName = this.LastRunSchedulerName;
                job.NotificationEmails = this.NotificationEmails;
                job.NotificationStatus = this.NotificationStatus;
                job.Id = this.Id;
                job.Guid = this.Guid;
            }
        }
    }
}