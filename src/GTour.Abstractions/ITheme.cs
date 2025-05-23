﻿namespace GTour.Abstractions;

public interface ITheme
{

    public string GTourOverlay { get; set; }

    public string GTourWrapper { get; set; }

    public string GTourArrow { get; set; }

    public string GTourStepWrapper { get; set; }

    public string GTourStepHeaderWrapper { get; set; }

    public string GTourStepContentWrapper { get; set; }

    public string GTourStepFooterWrapper { get; set; }

    public string GTourStepHeaderTitle { get; set; }

    public string GTourStepCancelButton { get; set; }

    public string GTourStepPreviousButton { get; set; }

    public string GTourStepNextButton { get; set; }

    public string GTourStepCompleteButton { get; set; }

}
