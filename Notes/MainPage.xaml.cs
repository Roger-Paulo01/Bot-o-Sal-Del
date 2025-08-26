

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");
        
        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(caminho))
                CaixaEditor.Text = File.ReadAllText(caminho);
        }
        
        
        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
            string conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho, conteudo);

            DisplayAlert("Arquivo salvo", Path.GetFileName(conteudo) , caminho, "ok");
        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
            File.Delete(caminho);
           if (File.Exists(caminho))
            {
                File.Delete(caminho);
                CaixaEditor.Text = string.Empty;
            }

           else
           {
                DisplayAlert("Arquivo não encontrado", "Não há arquivo para apagar", "OK");
           }
           
        }
    }

}
