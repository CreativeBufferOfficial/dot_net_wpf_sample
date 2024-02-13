using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Domain.Models;

namespace YouTubeViewers.Domain.Queries
{
    public interface IGetAllYouTubeViewersQuery
    {
        /// <summary>
        /// interface for common query
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<YouTubeViewer>> Execute();
    }
}
