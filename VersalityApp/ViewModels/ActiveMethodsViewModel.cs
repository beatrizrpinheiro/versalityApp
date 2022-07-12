using System.Collections.ObjectModel;
using System.ComponentModel;
using VersalityApp.Models;
using VersalityApp.Views;

namespace VersalityApp.ViewModels
{
    public class ActiveMethodsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Methods> Methods { get; set; }
        public Command <string> NavigateCommand { get; }
        public string Text => "RootPage";

        public ActiveMethodsViewModel()
        {
            Methods = new ObservableCollection<Methods>();
            Methods.Add(new Methods { Name = "Aprendizagem Baseada em Problemas", Description = "A aprendizagem baseada em problemas possui como finalidade transformar o aluno em um indivíduo qualificado para...", ButtonLeiaMais="1" });
            Methods.Add(new Methods { Name = "Aprendizagem Baseada em Equipes", Description = "A aprendizagem baseada em equipes tem foco na aprendizagem de adultos e possui a capacidade de estimular a disp...", ButtonLeiaMais = "2" });
            Methods.Add(new Methods { Name = "Instrução por Pares", Description = "O método de Instrução por Pares tem como foco a aprendizagem colaborativa  e estimula a participação dos alunos por meio de uma...", ButtonLeiaMais = "3" });
            Methods.Add(new Methods { Name = "Sala de Aula Invertida", Description = "Sala de aula invertida é um método que que se baseia na modalidade de aprendizagem eletrônica, isto é, o conteúdo e as orient...", ButtonLeiaMais = "4" });
            Methods.Add(new Methods { Name = "JigSaw", Description = "Jigsaw é um método baseado na aprendizagem cooperativa, e é posto em prática por meio de um grupo de alunos, nos quais cada grupo elege um...", ButtonLeiaMais = "5" });
            Methods.Add(new Methods { Name = "Divisão dos alunos em Equipes para o Sucesso", Description = "O método de Divisão dos alunos em Equipes para o Sucesso, pertence ao grupo de métodos de aprendizagem...", ButtonLeiaMais = "6" });
            Methods.Add(new Methods { Name = "Torneio de Jogos em Equipes", Description = "O método Torneio de Jogos em Equipes induz a formação de equipes de maneira heterogênea a nível de competência técnica e...", ButtonLeiaMais = "7" });
            Methods.Add(new Methods { Name = "Aprendizagem Baseada em Projetos", Description = "A aprendizagem baseada em projetos se destina a auxiliar os alunos na aquisição de autonomia e em proporcionar consciên...", ButtonLeiaMais = "8" });

            NavigateCommand = new Command<string>(NavigateCommandExecute);
        }

         void NavigateCommandExecute(string arg)
        {
            var id = int.Parse(arg);
            ContentPage page = id switch
            {
                1 => new ProblemBasedLearning(),
                2 => new TeamBasedLearning(),
                3 => new PeerInstruction(),
                4 => new FlippedClassroom(),
                5 => new Jigsaw(),
                6 => new Stad(),
                7 => new TeamsGamesTournament(),
                8 => new ProjectBasedLearning(),
            };
             App.Current.MainPage.Navigation.PushAsync(page);
        }

    }
}
