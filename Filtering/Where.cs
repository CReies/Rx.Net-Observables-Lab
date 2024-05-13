using System.Reactive.Linq;

namespace Observables.Lab.Filtering;

public class Where
{
	public static void Exec()
	{
		List<int> numberList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		var source = numberList.ToObservable();

		/* Filters the events that satisfy the condition */
		var where = source.Where( x => x % 2 == 0 );

		where.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
