namespace Observables.Example;

// @TODO Change this to T instead of BaggageInfo
// Apparantly that goes against best practices! It may result in a null reference
//https://learn.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern-best-practices
internal sealed class Unsubscriber<BaggageInfo> : IDisposable
{
    private readonly ISet<IObserver<BaggageInfo>> _observers;
    private readonly IObserver<BaggageInfo> _observer;

    internal Unsubscriber(
        ISet<IObserver<BaggageInfo>> observers,
        IObserver<BaggageInfo> observer) => (_observers, _observer) = (observers, observer);

    public void Dispose() => _observers.Remove(_observer);
}