namespace Observables.Lab.Combining;

public class Join
{
	public static void Exec()
	{
		var source1 = Observable.Interval( TimeSpan.FromSeconds( 1 ) ).Select( x => $"Source 1: {x}" );
		var source2 = Observable.Interval( TimeSpan.FromSeconds( 2 ) ).Select( x => $"Source 2: {x}" );

		/* Combine items emitted by source1 and source2 whenever an item from one Observable is emitted during a time window */
		var combined = source1.Join(
			source2,
			_ => Observable.Timer( TimeSpan.FromSeconds( 3 ) ),
			_ => Observable.Timer( TimeSpan.FromSeconds( 3 ) ),
			( s1, s2 ) => $"{s1} - {s2}"
		);

		combined.Subscribe( Console.WriteLine );

		Console.ReadLine();
	}
}
