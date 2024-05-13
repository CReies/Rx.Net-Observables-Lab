using System.Reactive.Linq;

namespace Observables.Lab.Filtering;

public class IgnoreElements
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Ignores all the events and only calls the OnCompleted method */
		var ignoreElements = source.IgnoreElements();

		ignoreElements.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
