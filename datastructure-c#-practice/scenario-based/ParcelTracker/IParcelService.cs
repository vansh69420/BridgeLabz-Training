using System;
interface IParcelService
{
    void CreateDefaultChain();
    void AddIntermediateStage(string afterStage, string newStage);
    void TrackForward();
    void MarkParcelLost();
}

