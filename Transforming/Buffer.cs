namespace Observables.Lab.Transforming;

public class Buffer
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Emits a list of events that were emitted in the specified window */
		var buffer = source.Buffer( 3 );
		var bufferWithSkip = source.Buffer( 2, 3 );

		buffer.Subscribe(
			x => Console.WriteLine( $"Emitted: {string.Join( ", ", x )}" ),
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		bufferWithSkip.Subscribe(
			x => Console.WriteLine( $"Emitted: {string.Join( ", ", x )}" ),
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
