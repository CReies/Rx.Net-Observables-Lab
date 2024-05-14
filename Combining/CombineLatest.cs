namespace Observables.Lab.Combining;

public class CombineLatest
{
	public static void Exec()
	{
		var source1 = Observable.Interval( TimeSpan.FromSeconds( 1 ) ).Select( x => $"Source 1: {x}" );
		var source2 = Observable.Interval( TimeSpan.FromSeconds( 2 ) ).Select( x => $"Source 2: {x}" );

		/* Combine the latest event with the actual emited event  */
		var combined = source1.CombineLatest( source2, ( s1, s2 ) => $"{s1} - {s2}" );

		combined.Subscribe( Console.WriteLine );

		Console.ReadLine();
	}
}
