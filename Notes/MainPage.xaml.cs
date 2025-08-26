

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

            DisplayAlert("Salvar", $"O arquivo foi salvo em: {caminho}", "ok");
        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
            CaixaEditor.Text = String.Empty;
           if (File.Exists(caminho))
            {
                File.Delete(caminho);
                DisplayAlert("Exclusão", "Arquivo apagado com sucesso", "ok");
            }

           else
           {
                DisplayAlert("Arquivo não encontrado", "Não há arquivo para APAGAR", "ok");
           }
           
        }
    }

}
