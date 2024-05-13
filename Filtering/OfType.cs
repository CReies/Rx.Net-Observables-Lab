namespace Observables.Lab.Filtering;

public class OfType
{
	public static void Exec()
	{
		var source = new object[] { 1, "Hello", 2, "World", 3, "!" }.ToObservable();

		/* Filters the events that are of the specified type */
		var ofType = source.OfType<string>();

		ofType.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
