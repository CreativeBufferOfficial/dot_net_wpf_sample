using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Domain.Models;

namespace YouTubeViewers.Domain.Commands
{
    public interface ICreateYouTubeViewerCommand
    {
        /// <summary>
        /// interface to create you tube viewers
        /// </summary>
        /// <param name="youTubeViewer">pass as parameter</param>
        /// <returns>crerated dto</returns>
        Task Execute(YouTubeViewer youTubeViewer);
    }
}
