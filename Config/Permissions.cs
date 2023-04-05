namespace Icomment.Config
{
    public static class Permissions
    {

        private static string permissions = @"{
            'icomments.comments':{
                'manage':'icomments::comments.manage resource',
                'index':'icomments::comments.list resource',
                'create':'icomments::comments.create resource',
                'edit':'icomments::comments.edit resource',
                'destroy':'icomments::comments.destroy resource',
                'restore':'icomments::comments.restore resource'
            }
        }";

        public static string GetPermissions()
        {
            return permissions;
        }
    }
}
