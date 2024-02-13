using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Domain.Models;

namespace YouTubeViewers.Domain.Commands
{
    public interface IUpdateYouTubeViewerCommand
    {
		/// <summary>
		/// interface to edit you tube viewers
		/// </summary>
		/// <param name="youTubeViewer">pass as parameter youTubeViewer</param>
		/// <returns></returns>
		Task Execute(YouTubeViewer youTubeViewer);
    }
}
