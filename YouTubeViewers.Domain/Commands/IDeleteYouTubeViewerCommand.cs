using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.Domain.Commands
{
    public interface IDeleteYouTubeViewerCommand
    {
        /// <summary>
        /// interface to deleteyou tube viewers
        /// </summary>
        /// <param name="id">pass id as parameter</param>
        /// <returns>deleted dto</returns>
        Task Execute(Guid id);
    }
}
