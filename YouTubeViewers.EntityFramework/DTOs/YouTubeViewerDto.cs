using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.EntityFramework.DTOs
{
    /// <summary>
    /// Entity for add. edit or delete you yube viewers
    /// </summary>
    public class YouTubeViewerDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsMember { get; set; }
    }
}
