﻿using System.Reactive.Linq;

namespace Observables.Lab.Filtering;

public class Single
{
	public static void Exec()
	{
		List<int> numberList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		var source = numberList.ToObservable();

		/* Filters the events that are the only one in the sequence that satisfies the predicate */
		var single = source.SingleAsync( x => x == 5 );
		var singleInvalidOperation = source.SingleAsync( x => x > 10 );

		single.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		singleInvalidOperation.Subscribe(
			Console.WriteLine,
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
