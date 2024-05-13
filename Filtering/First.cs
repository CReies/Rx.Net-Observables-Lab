﻿using System.Reactive.Linq;

namespace Observables.Lab.Filtering;

public class First
{
	public static void Exec()
	{
		List<int> numberList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		var source = numberList.ToObservable();

		/* Emits the first event that satisfies the condition */
		var first = source.FirstAsync( x => x % 2 == 0 );
		var firstInvalidOperation = source.FirstAsync( x => x > 10 );

		first.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		firstInvalidOperation.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
