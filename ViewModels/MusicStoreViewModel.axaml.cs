using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Avalonia.MusicStore.ViewModels
{
    public partial class MusicStoreViewModel : ViewModelBase
    {
        [ObservableProperty] public partial string? SearchText { get; set; }

        [ObservableProperty] public partial bool IsBusy { get; private set; }

        [ObservableProperty] public partial AlbumViewModel? SelectedAlbum { get; set; }
        public ObservableCollection<AlbumViewModel> SearchResults { get; } = new();


        public MusicStoreViewModel()
        {
            SearchResults.Add(new AlbumViewModel());
            SearchResults.Add(new AlbumViewModel());
            SearchResults.Add(new AlbumViewModel());

        }

    }
}



