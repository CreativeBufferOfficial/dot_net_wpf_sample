using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.WPF.Commands;
using YouTubeViewers.Domain.Models;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModels
{
    public class EditYouTubeViewerViewModel : ViewModelBase
    {
        public Guid YouTubeViewerId { get; }

        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

		/// <summary>
		/// view models for edit youtubr viewers
		/// </summary>
		/// <param name="youTubeViewer">pass as parameter youTubeViewer</param>
		/// <param name="youTubeViewersStore">pass as parameter youTubeViewersStore</param>
		/// <param name="modalNavigationStore">pass as parameter modalNavigationStore</param>
		public EditYouTubeViewerViewModel(YouTubeViewer youTubeViewer, YouTubeViewersStore youTubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            YouTubeViewerId = youTubeViewer.Id;

            ICommand submitCommand = new EditYouTubeViewerCommand(this, youTubeViewersStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(submitCommand, cancelCommand)
            { 
                Username = youTubeViewer.Username,
                IsSubscribed = youTubeViewer.IsSubscribed,
                IsMember = youTubeViewer.IsMember,
            };
        }
    }
}
