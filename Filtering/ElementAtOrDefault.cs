namespace Observables.Lab.Filtering;

public class ElementAtOrDefault
{
	public static void Exec()
	{
		List<int> numbersList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		var source = numbersList.ToObservable();

		/* Filters the event at the specified index */
		var elementAtOrDefault = source.ElementAtOrDefault( 5 );
		var elementAtOrDefaultOutOfRange = source.ElementAtOrDefault( 500 );

		elementAtOrDefault.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		elementAtOrDefaultOutOfRange.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
