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
using System.ComponentModel.Composition;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

using Rock.Cms.Security;

namespace Rock.Api.Cms
{
    [Export(typeof(IService))]
    [ExportMetadata("RouteName", "api/Cms/BlogCategory")]
	[AspNetCompatibilityRequirements( RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed )]
    public partial class BlogCategoryService : IBlogCategoryService, IService
    {
		[WebGet( UriTemplate = "{id}" )]
        public Rock.Models.Cms.BlogCategory Get( string id )
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            if ( currentUser == null )
                throw new FaultException( "Must be logged in" );

            using (Rock.Helpers.UnitOfWorkScope uow = new Rock.Helpers.UnitOfWorkScope())
            {
                uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.Services.Cms.BlogCategoryService BlogCategoryService = new Rock.Services.Cms.BlogCategoryService();
                Rock.Models.Cms.BlogCategory BlogCategory = BlogCategoryService.Get( int.Parse( id ) );
                if ( BlogCategory.Authorized( "View", currentUser ) )
                    return BlogCategory;
                else
                    throw new FaultException( "Unauthorized" );
            }
        }
		
		[WebInvoke( Method = "PUT", UriTemplate = "{id}" )]
        public void UpdateBlogCategory( string id, Rock.Models.Cms.BlogCategory BlogCategory )
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            if ( currentUser == null )
                throw new FaultException( "Must be logged in" );

            using ( Rock.Helpers.UnitOfWorkScope uow = new Rock.Helpers.UnitOfWorkScope() )
            {
                uow.objectContext.Configuration.ProxyCreationEnabled = false;

                Rock.Services.Cms.BlogCategoryService BlogCategoryService = new Rock.Services.Cms.BlogCategoryService();
                Rock.Models.Cms.BlogCategory existingBlogCategory = BlogCategoryService.Get( int.Parse( id ) );
                if ( existingBlogCategory.Authorized( "Edit", currentUser ) )
                {
                    uow.objectContext.Entry(existingBlogCategory).CurrentValues.SetValues(BlogCategory);
                    BlogCategoryService.Save( existingBlogCategory, currentUser.PersonId() );
                }
                else
                    throw new FaultException( "Unauthorized" );
            }
        }

		[WebInvoke( Method = "POST", UriTemplate = "" )]
        public void CreateBlogCategory( Rock.Models.Cms.BlogCategory BlogCategory )
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            if ( currentUser == null )
                throw new FaultException( "Must be logged in" );

            using ( Rock.Helpers.UnitOfWorkScope uow = new Rock.Helpers.UnitOfWorkScope() )
            {
                uow.objectContext.Configuration.ProxyCreationEnabled = false;

                Rock.Services.Cms.BlogCategoryService BlogCategoryService = new Rock.Services.Cms.BlogCategoryService();
                BlogCategoryService.Add( BlogCategory, currentUser.PersonId() );
                BlogCategoryService.Save( BlogCategory, currentUser.PersonId() );
            }
        }

		[WebInvoke( Method = "DELETE", UriTemplate = "{id}" )]
        public void DeleteBlogCategory( string id )
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            if ( currentUser == null )
                throw new FaultException( "Must be logged in" );

            using ( Rock.Helpers.UnitOfWorkScope uow = new Rock.Helpers.UnitOfWorkScope() )
            {
                uow.objectContext.Configuration.ProxyCreationEnabled = false;

                Rock.Services.Cms.BlogCategoryService BlogCategoryService = new Rock.Services.Cms.BlogCategoryService();
                Rock.Models.Cms.BlogCategory BlogCategory = BlogCategoryService.Get( int.Parse( id ) );
                if ( BlogCategory.Authorized( "Edit", currentUser ) )
                {
                    BlogCategoryService.Delete( BlogCategory, currentUser.PersonId() );
                }
                else
                    throw new FaultException( "Unauthorized" );
            }
        }

    }
}