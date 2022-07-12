using Microsoft.AspNetCore.StaticFiles;
using System.ComponentModel;
using System.Windows.Input;

namespace VersalityApp.ViewModels
{
    public class TeachingPlanViewModel : INotifyPropertyChanged
    {
        public ICommand GenerateFile { get; set; }
        public TeachingPlanViewModel()
        {
            GenerateFile = new Command(obj => GetFileName());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async Task<MemoryStream> DownloadFile()
        {
            var fileName = System.IO.Path.GetFileName("caminho");
            var content = await System.IO.File.ReadAllBytesAsync("caminho");
            new FileExtensionContentTypeProvider()
                .TryGetContentType(fileName, out string contentType);

            return new MemoryStream(content);
        }
        public List<string> GetFileName()
        {
            List<string> arquivos = new List<string>();
            DirectoryInfo d = new DirectoryInfo("C:\\Users\\Public\\Files");
            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo file in Files)
            {
                arquivos.Add(file.Name);
            }
            return arquivos;
        }
   
    }
}
