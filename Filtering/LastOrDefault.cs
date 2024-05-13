namespace Observables.Lab.Filtering;

public class LastOrDefault
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Emits the last event of the sequence or the last element that satisfies the predicate */
		var last = source.LastOrDefaultAsync( x => x % 2 == 0 );
		var lastInvalidOperation = source.LastOrDefaultAsync( x => x > 10 );

		last.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		lastInvalidOperation.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
