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
    /// Data Transfer Object for PersonAccount object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class PersonAccountDto : IDto, DotLiquid.ILiquidizable
    {
        /// <summary />
        [DataMember]
        public int? PersonId { get; set; }

        /// <summary />
        [DataMember]
        public string Account { get; set; }

        /// <summary />
        [DataMember]
        public int Id { get; set; }

        /// <summary />
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public PersonAccountDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="personAccount"></param>
        public PersonAccountDto ( PersonAccount personAccount )
        {
            CopyFromModel( personAccount );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<string, object> ToDictionary()
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add( "PersonId", this.PersonId );
            dictionary.Add( "Account", this.Account );
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
            expando.PersonId = this.PersonId;
            expando.Account = this.Account;
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
            if ( model is PersonAccount )
            {
                var personAccount = (PersonAccount)model;
                this.PersonId = personAccount.PersonId;
                this.Account = personAccount.Account;
                this.Id = personAccount.Id;
                this.Guid = personAccount.Guid;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyToModel ( IEntity model )
        {
            if ( model is PersonAccount )
            {
                var personAccount = (PersonAccount)model;
                personAccount.PersonId = this.PersonId;
                personAccount.Account = this.Account;
                personAccount.Id = this.Id;
                personAccount.Guid = this.Guid;
            }
        }

        /// <summary>
        /// Converts to liquidizable object for dotLiquid templating
        /// </summary>
        /// <returns></returns>
        public object ToLiquid()
        {
            return this.ToDictionary();
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public static class PersonAccountDtoExtension
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PersonAccount ToModel( this PersonAccountDto value )
        {
            PersonAccount result = new PersonAccount();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<PersonAccount> ToModel( this List<PersonAccountDto> value )
        {
            List<PersonAccount> result = new List<PersonAccount>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<PersonAccountDto> ToDto( this List<PersonAccount> value )
        {
            List<PersonAccountDto> result = new List<PersonAccountDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PersonAccountDto ToDto( this PersonAccount value )
        {
            return new PersonAccountDto( value );
        }

    }
}