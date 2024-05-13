namespace Observables.Lab.Filtering;

public class TakeLast
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Takes the last n events */
		var takeLast = source.TakeLast( 5 );

		takeLast.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
