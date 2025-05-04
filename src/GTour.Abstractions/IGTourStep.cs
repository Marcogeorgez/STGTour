using System.Threading.Tasks;

namespace GTour.Abstractions;

public interface IGTourStep
{

    string StepName { get; set; }

    int? TourStepSequence { get; set; }

    Task CancelTour();

    Task PreviousStep();

    Task NextStep();

    Task GoToStep(string stepName);

    Task CompleteTour();

    bool SkipStep { get; set; }

    Task Initialise();

    Task DeActivate();

    Task Activate(bool isFirstStep, bool isLastStep);
}
