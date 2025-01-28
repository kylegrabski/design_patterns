using Observables.Example;

BaggageHandler provider = new();
ArrivalsMonitor observer1 = new("BaggageClaimMonitor1");
ArrivalsMonitor observer2 = new("SecurityExit");

provider.BaggageStatus(712, "Detroit", 3);
observer1.Subscribe(provider);

provider.BaggageStatus(712, "Kalamazoo", 3);
provider.BaggageStatus(400, "New York-Kennedy", 1);
provider.BaggageStatus(712, "Detroit", 3);
observer2.Subscribe(provider);

provider.BaggageStatus(511, "San Francisco", 2);
provider.BaggageStatus(712);
observer2.Unsubscribe();

provider.BaggageStatus(400);
provider.LastBaggageClaimed();

Console.WriteLine("AND THATS THE END OF THAT");

/*
 * The subject holds all of the observers/subscribers.
 * The subject should loop through observers when calling update functions and trigger the OnNext() function.
 * When an observer is subscribed to the subject, trigger the OnNext() function. This could be redundant if I only want the OnNext() to trigger after a specific condition is met.
 * When first subscribing, we return an Unsubscriber for that specific subjects type. This is used in order to give the subject the Dispose() function.
 * The Observer will have the necessary logic for OnNext, etc...
 */