using System.Reactive.Linq;

namespace Observables.Lab.Filtering;

public class Sample
{
	public static void Exec()
	{
		var source = Observable.Interval( TimeSpan.FromMilliseconds( 300 ) );

		/* Filters the events based on the established time, it will emit only one event every 900 ms */
		var sampled = source.Sample( TimeSpan.FromMilliseconds( 900 ) );

		sampled.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
