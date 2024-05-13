namespace Observables.Lab.Filtering;

public class DistinctUntilChanged
{
	public static void Exec()
	{
		List<int> numbersList1 = [1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		List<int> numbersList2 = [1, 2, 3, 4, 5];

		var source = numbersList1.ToObservable();

		source = source.Concat( numbersList2.ToObservable() ).Concat( numbersList1.ToObservable() );

		/* Filters if there are event values repeated per change, on the final observer maybe repeated values */
		var distinctUntilChanged = source.DistinctUntilChanged();

		distinctUntilChanged.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
