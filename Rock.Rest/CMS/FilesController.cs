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

using Rock.Cms;

namespace Rock.Rest.Cms
{
    /// <summary>
    /// Files REST API
    /// </summary>
    public partial class FilesController : Rock.Rest.ApiController<Rock.Cms.File, Rock.Cms.FileDto>
    {
        public FilesController() : base( new Rock.Cms.FileService() ) { } 
    }
}