namespace Observables.Lab.Transforming;

public class GroupBy
{
	public static void Exec()
	{
		var source = Observable.Range( 1, 10 );

		/* Groups the events by a condition and returns various groups of observables, depending on the quantity of results of the condition  */
		var groupBy = source.GroupBy( x => x % 2 );

		groupBy.Subscribe(
			x => x.Subscribe(
				y => Console.WriteLine( $"Emitted: {(x.Key == 0 ? "Odd" : "Even")}: {y}" ),
				error => Console.WriteLine( $"Error: {error}" ),
				() => Console.WriteLine( "Inner observable sequence completed" )
			),
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
