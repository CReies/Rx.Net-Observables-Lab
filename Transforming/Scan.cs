namespace Observables.Lab.Transforming;

public class Scan
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Accumulates the events emitted by the observable */
		var scan = source.Scan( ( prev, actual ) => prev + actual );

		scan.Subscribe(
			x => Console.WriteLine( $"Emitted: {x}" ),
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
