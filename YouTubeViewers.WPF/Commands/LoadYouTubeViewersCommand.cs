using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF.Commands
{
    public class LoadYouTubeViewersCommand : AsyncCommandBase
    {
        private readonly YouTubeViewersViewModel _youTubeViewersViewModel;
        private readonly YouTubeViewersStore _youTubeViewersStore;

        public LoadYouTubeViewersCommand(YouTubeViewersViewModel youTubeViewersViewModel, YouTubeViewersStore youTubeViewersStore)
        {
            _youTubeViewersViewModel = youTubeViewersViewModel;
            _youTubeViewersStore = youTubeViewersStore;
        }

        #region YouTube Viewers List 
        /// <summary>
        /// Load youtube list
        /// </summary>
        /// <param name="parameter">pass object as parameter</param>
        /// <returns></returns>
        public override async Task ExecuteAsync(object parameter)
        {
            _youTubeViewersViewModel.ErrorMessage = null;
            _youTubeViewersViewModel.IsLoading = true;

            try
            {
                await _youTubeViewersStore.Load();
            }
            catch (Exception)
            {
                _youTubeViewersViewModel.ErrorMessage = "Failed to load YouTube viewers. Please restart the application.";
            }
            finally
            {
                _youTubeViewersViewModel.IsLoading = false;
            }
        } 
        #endregion
    }
}
