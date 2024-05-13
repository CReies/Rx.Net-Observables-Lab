using System.Reactive.Linq;

namespace Observables.Lab.Filtering;

public class Throttle
{
	public static void Exec()
	{
		var source = Observable.Interval( TimeSpan.FromMilliseconds( 250 ) );

		/* Filters the events if te time between them are less than the established */
		var throttled = source.Throttle( TimeSpan.FromMilliseconds( 900 ) );

		throttled.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
