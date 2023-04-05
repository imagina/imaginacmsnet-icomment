using Core.Exceptions;
using Core;
using Core.Repositories;
using Core.Storage.Interfaces;
using Core.Storage;
using Idata.Data.Entities;
using Idata.Entities.Idhl;
using System.Data.SqlClient;
using Razor.Templating.Core;
using jsreport.Local;
using System.Runtime.InteropServices;
using jsreport.Binary;
using jsreport.Types;
using Newtonsoft.Json;
using Idata.Entities.Idhl.ViewModels;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using jsreport.Client;
using Idata.Entities.Icomment;
using Icomment.Repositories.Interfaces;
using Icomment.Data;
using Core.Events.Interfaces;
using Idata.Data;

namespace Icomment.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(IEventHandlerBase<Comment>? eventHandler) 
        {
            _eventHandler = eventHandler;
        }

    }
}
