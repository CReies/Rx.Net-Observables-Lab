namespace Observables.Lab.Transforming;

public class ManySelect
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Emits the events that were emitted by the inner observable */
		var manySelect = source.ManySelect( x => x.Subscribe( x => Console.WriteLine( $"Emitted from inner observable: {x}" ) ) );

		manySelect.Subscribe(
			x => Console.WriteLine( $"Emitted" ),
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
