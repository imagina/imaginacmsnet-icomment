using Idata.Data.Entities;
using Newtonsoft.Json;
using Icomment.Config;
using Idata.Data;
using Idata.Data.Entities.Isite;

namespace Icomment.Data.Seeders
{
    public class IcommentModuleSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<IdataContext>();

                context.Database.EnsureCreated();

                object values = new
                {
                    name = "Icomment",
                    alias = "icomment",
                    permissions = Permissions.GetPermissions(),
                    settings = "",
                    enabled = true,
                    priority = 1,
                    configs = Configs.GetConfigs(),
                    cms_pages = "",
                    cms_sidebar = ""
                };



                Module? module = context.Modules.Where(m => m.alias == "icomment").FirstOrDefault();

                if (module == null)
                {
                    module = JsonConvert.DeserializeObject<Module>(JsonConvert.SerializeObject(values));
                    context.Modules.Add(module);
                    context.SaveChanges();
                    module = context.Modules.Where(m => m.alias == "icomment").FirstOrDefault();
                    module.translations = new List<ModuleTranslation>() {
                        new ModuleTranslation()
                            {
                                locale = "en",
                                title = "COMMENT"
                            }
                        };

                }
                else
                {
                    context.Entry(module).CurrentValues.SetValues(values);
                }



                context.SaveChanges();

            }
        }
    }
}
