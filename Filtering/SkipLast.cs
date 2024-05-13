namespace Observables.Lab.Filtering;

public class SkipLast
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Skips the last n events */
		var skipLast = source.SkipLast( 5 );

		skipLast.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
