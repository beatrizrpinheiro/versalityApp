namespace VersalityApp.Views;

public partial class ClassPlan : ContentPage
{
	public ClassPlan()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        List<string> arquivos = new List<string>();
        DirectoryInfo d = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        FileInfo[] Files = d.GetFiles();
        foreach (FileInfo file in Files)
        {
            arquivos.Add(file.Name);
        }
  
    }
}