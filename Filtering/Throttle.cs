using System.Reactive.Linq;

namespace Observables.Lab.Filtering;

public class Throttle
{
	public static void Exec()
	{
		var source = Observable.Interval(TimeSpan.FromMilliseconds(250));

		var throttled = source.Throttle(TimeSpan.FromMilliseconds(900));

		throttled.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine($"Error: {error}"),
			() => Console.WriteLine("Observable sequence completed")
		);

		Console.ReadLine();
	}
}
