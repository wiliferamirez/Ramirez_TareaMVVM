namespace Ramirez_TareaMVVM.Views;
[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class WRNotePage : ContentPage
{
    public string ItemId
    {
        set { LoadNote(value); }
    }
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public WRNotePage()
	{
		InitializeComponent();
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        LoadNote(Path.Combine(appDataPath, randomFileName));
    }

    private async void WRDeleteButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.WRNote note)
        {
            // Delete the file.
            if (File.Exists(note.Filename))
                File.Delete(note.Filename);
        }

        await Shell.Current.GoToAsync("..");
    }

    private async void WRSaveButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.WRNote note)
            File.WriteAllText(note.Filename, TextEditor.Text);

        await Shell.Current.GoToAsync("..");
    }
    private void LoadNote(string fileName)
    {
        Models.WRNote noteModel = new Models.WRNote();
        noteModel.Filename = fileName;

        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }

        BindingContext = noteModel;
    }
}