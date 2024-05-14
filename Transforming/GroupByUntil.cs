namespace Observables.Lab.Transforming;

public class GroupByUntil
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Emits the events that were emitted by the inner observable */
		/* The first lambda expression determines the key for each element */
		/* The second lambda expression selects the elements to be emitted by the inner observable */
		/* The third lambda expression determines when each group should be completed and emitted */
		var groupByUntil = source.GroupByUntil( x => x % 2 == 0, x => x, x => x );

		groupByUntil.Subscribe(
			x => x.Subscribe(
				x => Console.WriteLine( $"Emitted from inner observable: {x}" ),
				error => Console.WriteLine( $"Error: {error}" ),
				() => Console.WriteLine( "Inner observable sequence completed" )
			),
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
