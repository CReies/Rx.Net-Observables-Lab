namespace Observables.Lab.Combining;

public class Zip
{
	public static void Exec()
	{
		var source1 = Observable.Interval( TimeSpan.FromSeconds( 1 ) ).Select( x => $"Source 1: {x}" );
		var source2 = Observable.Interval( TimeSpan.FromSeconds( 2 ) ).Select( x => $"Source 2: {x}" );

		/* Combine the observables like a zip, one from source 1 with one from source 2 */
		var combined = source1.Zip( source2, ( s1, s2 ) => $"{s1} - {s2}" );

		combined.Subscribe( Console.WriteLine );

		Console.ReadLine();
	}
}
