namespace Observables.Lab.Transforming;

public class Window
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Similar to the Buffer method, but emits single events, instead of a list */
		var window = source.Window( 3 );

		window.Subscribe(
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
