namespace Observables.Lab.Filtering;

public class ElementAt
{
	public static void Exec()
	{
		List<int> numbersList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		var source = numbersList.ToObservable();

		/* Filters the event at the specified index */
		var elementAt = source.ElementAt( 5 );
		var elementAtOutOfRange = source.ElementAt( 500 );

		elementAt.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		elementAtOutOfRange.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
