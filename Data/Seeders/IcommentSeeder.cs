
using Idata.Data;

namespace Icomment.Data.Seeders
{
    public class IcommentSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<IdataContext>();

                context.Database.EnsureCreated();
                IcommentModuleSeeder.Seed(applicationBuilder);
                
            }
        }
    }
}
