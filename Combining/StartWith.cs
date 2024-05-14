namespace Observables.Lab.Combining;

public class StartWith
{
	public static void Exec()
	{
		var source = Observable.Range( 6, 5 );

		/* Start the sequence with the specified values */
		var combined = source.StartWith( 1, 2, 3, 4, 5 );

		combined.Subscribe( Console.WriteLine );

		Console.ReadLine();
	}
}
