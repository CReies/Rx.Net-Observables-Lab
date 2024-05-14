namespace Observables.Lab.Combining;

public class Merge
{
	public static void Exec()
	{
		var source1 = Observable.Range( 1, 5 );
		var source2 = Observable.Range( 6, 5 );

		/* Combine multiple observables into one */
		var combined = source1.Merge( source2 );

		combined.Subscribe( Console.WriteLine );

		Console.ReadLine();
	}
}
