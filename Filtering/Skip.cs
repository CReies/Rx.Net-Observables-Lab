using System.Reactive.Linq;

namespace Observables.Lab.Filtering;

public class Skip
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Skips the first n events */
		var skip = source.Skip( 5 );

		skip.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
