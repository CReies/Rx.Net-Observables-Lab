namespace Observables.Lab.Combining;

public class GroupJoin
{
	public static void Exec()
	{
		var source1 = Observable.Interval( TimeSpan.FromSeconds( 1 ) ).Select( x => $"Source 1: {x}" );
		var source2 = Observable.Interval( TimeSpan.FromSeconds( 2 ) ).Select( x => $"Source 2: {x}" );

		/* Similar to Join, but groups the pairs of events in another internal observable  */
		var combined = source1.GroupJoin(
			source2,
			_ => Observable.Timer( TimeSpan.FromSeconds( 3 ) ),
			_ => Observable.Timer( TimeSpan.FromSeconds( 3 ) ),
			( s1, s2 ) => s2.Select( x => $"{s1} - {x}" )
		);

		combined.Merge().Subscribe( Console.WriteLine );

		Console.ReadLine();
	}
}
