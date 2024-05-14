namespace Observables.Lab.Transforming;

public class SelectMany
{
	public static void Exec()
	{
		List<string> fruits = ["apple", "orange", "watermelon"];
		var source = fruits.ToObservable();

		/* Emits the events that were emitted by the inner observable */
		var selectMany = source.SelectMany( x => new[] { $"{x} genetically modified" }.ToObservable() );

		selectMany.Subscribe(
			x => Console.WriteLine( $"Emitted: {x}" ),
			error => Console.WriteLine( $"Error: {error}" ),
			() => Console.WriteLine( "Observable sequence completed" )
		);

		Console.ReadLine();
	}
}
