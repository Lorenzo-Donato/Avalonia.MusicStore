using Avalonia.MusicStore.Messages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Threading.Tasks;

namespace Avalonia.MusicStore.ViewModels;



public partial class MainWindowViewModel : ObservableObject
{
    public MainWindowViewModel()
    {

    }

    [RelayCommand]
    private async Task AddAlbumAsync()
    {
        var album = await WeakReferenceMessenger.Default.Send(new PurchaseAlbumMessage());
    }
}
