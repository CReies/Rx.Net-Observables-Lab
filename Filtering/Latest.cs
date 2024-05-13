namespace Observables.Lab.Filtering;

public class Latest
{
	public static void Exec()
	{
		List<int> numberList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		List<int> latestEvent = [1];
		var source = numberList.ToObservable();

		source = source.Concat( latestEvent.ToObservable() );

		/* Returns an Enumerable of the latest value emitted by an observable */
		var latest = source.Latest();

		latest.ToObservable().Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
