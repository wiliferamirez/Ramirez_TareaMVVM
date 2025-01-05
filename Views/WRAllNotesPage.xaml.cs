namespace Ramirez_TareaMVVM.Views;

public partial class WRAllNotesPage : ContentPage
{
	public WRAllNotesPage()
	{
		InitializeComponent();
        BindingContext = new Models.WRAllNotes();
    }
    protected override void OnAppearing()
    {
        ((Models.WRAllNotes)BindingContext).LoadNotes();
    }
    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(WRNotePage));
    }
    private async void WRnotesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var note = (Models.WRNote)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(WRNotePage)}?{nameof(WRNotePage.ItemId)}={note.Filename}");

            // Unselect the UI
            notesCollection.SelectedItem = null;
        }
    }
}