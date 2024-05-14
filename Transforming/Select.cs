namespace Observables.Lab.Transforming;

public class Select
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Maps the event values on the observable */
		var select = source.Select( x => x * 2 );

		select.Subscribe(
			x => Console.WriteLine( $"Emitted: {x}" ),
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
