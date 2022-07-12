using VersalityApp.Views;

namespace VersalityApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("problembasedlearning", typeof(ProblemBasedLearning));
        Routing.RegisterRoute("teambasedlearning", typeof(TeamBasedLearning));
        Routing.RegisterRoute("peerinstruction", typeof(PeerInstruction));
        Routing.RegisterRoute("flippedclassroom", typeof(FlippedClassroom));
        Routing.RegisterRoute("jigsaw", typeof(Jigsaw));
        Routing.RegisterRoute("stad", typeof(Stad));
        Routing.RegisterRoute("teamsgamestournament", typeof(TeamsGamesTournament));
        Routing.RegisterRoute("projectbasedlearning", typeof(ProjectBasedLearning));
    }

}
