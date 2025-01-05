using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramirez_TareaMVVM.Models
{
    internal class WRAllNotes
    {
        public ObservableCollection<WRNote> Notes { get; set; } = new ObservableCollection<WRNote>();

        public WRAllNotes() =>
            LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();

            string appDataPath = FileSystem.AppDataDirectory;


            IEnumerable<WRNote> notes = Directory

                                        .EnumerateFiles(appDataPath, "*.notes.txt")

                                        .Select(filename => new WRNote()
                                        {
                                            Filename = filename,
                                            Text = File.ReadAllText(filename),
                                            Date = File.GetLastWriteTime(filename)
                                        })

                                        .OrderBy(note => note.Date);

            foreach (WRNote note in notes)
                Notes.Add(note);
        }
    }
}
