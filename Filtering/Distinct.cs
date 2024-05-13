using System.Reactive.Linq;

namespace Observables.Lab.Filtering;

public class Distinct
{
	public static void Exec()
	{
		List<int> numbersList = [1, 1, 2, 2, 2, 3, 4, 5, 5];
		var source = numbersList.ToObservable();

		/* Filters if there are event values repeated */
		var distinct = source.Distinct();

		distinct.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
