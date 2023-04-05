
using Core.Events.Interfaces;
using Icomment.Data;
using Icomment.Repositories;
using Icomment.Repositories.Interfaces;
using Idata.Data;
using Idata.Data.Entities;
using Idata.Entities.Icomment;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;

namespace Icomment
{
    public static class IcommentServiceProvider
    {


        public static WebApplicationBuilder? Boot(WebApplicationBuilder? builder)
        {
            //TODO Implement controllerBase to avoid basic crud redundant code
            builder.Services.AddControllers().ConfigureApplicationPartManager(o =>
            {

                o.ApplicationParts.Add(new AssemblyPart(typeof(IcommentServiceProvider).Assembly));
            });
           
            builder.Services.AddScoped<ICommentRepository, CommentRepository>();

           
            builder.Services.AddDbContext<IdataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            }, ServiceLifetime.Transient, ServiceLifetime.Scoped);
            return builder;

        }
    }
}
