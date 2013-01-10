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
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Data Transfer Object for UserLogin object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class UserLoginDto : DtoSecured<UserLoginDto>
    {
        /// <summary />
        [DataMember]
        public AuthenticationServiceType ServiceType { get; set; }

        /// <summary />
        [DataMember]
        public string ServiceName { get; set; }

        /// <summary />
        [DataMember]
        public string UserName { get; set; }

        /// <summary />
        [DataMember]
        public string Password { get; set; }

        /// <summary />
        [DataMember]
        public bool? IsConfirmed { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? LastActivityDate { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? LastLoginDate { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? LastPasswordChangedDate { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? CreationDate { get; set; }

        /// <summary />
        [DataMember]
        public bool? IsOnLine { get; set; }

        /// <summary />
        [DataMember]
        public bool? IsLockedOut { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? LastLockedOutDate { get; set; }

        /// <summary />
        [DataMember]
        public int? FailedPasswordAttemptCount { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? FailedPasswordAttemptWindowStart { get; set; }

        /// <summary />
        [DataMember]
        public string ApiKey { get; set; }

        /// <summary />
        [DataMember]
        public int? PersonId { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public UserLoginDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="userLogin"></param>
        public UserLoginDto ( UserLogin userLogin )
        {
            CopyFromModel( userLogin );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, object> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            dictionary.Add( "ServiceType", this.ServiceType );
            dictionary.Add( "ServiceName", this.ServiceName );
            dictionary.Add( "UserName", this.UserName );
            dictionary.Add( "Password", this.Password );
            dictionary.Add( "IsConfirmed", this.IsConfirmed );
            dictionary.Add( "LastActivityDate", this.LastActivityDate );
            dictionary.Add( "LastLoginDate", this.LastLoginDate );
            dictionary.Add( "LastPasswordChangedDate", this.LastPasswordChangedDate );
            dictionary.Add( "CreationDate", this.CreationDate );
            dictionary.Add( "IsOnLine", this.IsOnLine );
            dictionary.Add( "IsLockedOut", this.IsLockedOut );
            dictionary.Add( "LastLockedOutDate", this.LastLockedOutDate );
            dictionary.Add( "FailedPasswordAttemptCount", this.FailedPasswordAttemptCount );
            dictionary.Add( "FailedPasswordAttemptWindowStart", this.FailedPasswordAttemptWindowStart );
            dictionary.Add( "ApiKey", this.ApiKey );
            dictionary.Add( "PersonId", this.PersonId );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public override dynamic ToDynamic()
        {
            dynamic expando = base.ToDynamic();
            expando.ServiceType = this.ServiceType;
            expando.ServiceName = this.ServiceName;
            expando.UserName = this.UserName;
            expando.Password = this.Password;
            expando.IsConfirmed = this.IsConfirmed;
            expando.LastActivityDate = this.LastActivityDate;
            expando.LastLoginDate = this.LastLoginDate;
            expando.LastPasswordChangedDate = this.LastPasswordChangedDate;
            expando.CreationDate = this.CreationDate;
            expando.IsOnLine = this.IsOnLine;
            expando.IsLockedOut = this.IsLockedOut;
            expando.LastLockedOutDate = this.LastLockedOutDate;
            expando.FailedPasswordAttemptCount = this.FailedPasswordAttemptCount;
            expando.FailedPasswordAttemptWindowStart = this.FailedPasswordAttemptWindowStart;
            expando.ApiKey = this.ApiKey;
            expando.PersonId = this.PersonId;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is UserLogin )
            {
                var userLogin = (UserLogin)model;
                this.ServiceType = userLogin.ServiceType;
                this.ServiceName = userLogin.ServiceName;
                this.UserName = userLogin.UserName;
                this.Password = userLogin.Password;
                this.IsConfirmed = userLogin.IsConfirmed;
                this.LastActivityDate = userLogin.LastActivityDate;
                this.LastLoginDate = userLogin.LastLoginDate;
                this.LastPasswordChangedDate = userLogin.LastPasswordChangedDate;
                this.CreationDate = userLogin.CreationDate;
                this.IsOnLine = userLogin.IsOnLine;
                this.IsLockedOut = userLogin.IsLockedOut;
                this.LastLockedOutDate = userLogin.LastLockedOutDate;
                this.FailedPasswordAttemptCount = userLogin.FailedPasswordAttemptCount;
                this.FailedPasswordAttemptWindowStart = userLogin.FailedPasswordAttemptWindowStart;
                this.ApiKey = userLogin.ApiKey;
                this.PersonId = userLogin.PersonId;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is UserLogin )
            {
                var userLogin = (UserLogin)model;
                userLogin.ServiceType = this.ServiceType;
                userLogin.ServiceName = this.ServiceName;
                userLogin.UserName = this.UserName;
                userLogin.Password = this.Password;
                userLogin.IsConfirmed = this.IsConfirmed;
                userLogin.LastActivityDate = this.LastActivityDate;
                userLogin.LastLoginDate = this.LastLoginDate;
                userLogin.LastPasswordChangedDate = this.LastPasswordChangedDate;
                userLogin.CreationDate = this.CreationDate;
                userLogin.IsOnLine = this.IsOnLine;
                userLogin.IsLockedOut = this.IsLockedOut;
                userLogin.LastLockedOutDate = this.LastLockedOutDate;
                userLogin.FailedPasswordAttemptCount = this.FailedPasswordAttemptCount;
                userLogin.FailedPasswordAttemptWindowStart = this.FailedPasswordAttemptWindowStart;
                userLogin.ApiKey = this.ApiKey;
                userLogin.PersonId = this.PersonId;
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public static class UserLoginDtoExtension
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static UserLogin ToModel( this UserLoginDto value )
        {
            UserLogin result = new UserLogin();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<UserLogin> ToModel( this List<UserLoginDto> value )
        {
            List<UserLogin> result = new List<UserLogin>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<UserLoginDto> ToDto( this List<UserLogin> value )
        {
            List<UserLoginDto> result = new List<UserLoginDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static UserLoginDto ToDto( this UserLogin value )
        {
            return new UserLoginDto( value );
        }

    }
}