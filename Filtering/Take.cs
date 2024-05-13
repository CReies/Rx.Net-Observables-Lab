namespace Observables.Lab.Filtering;

public class Take
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Takes the first n events */
		var take = source.Take( 5 );

		take.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
