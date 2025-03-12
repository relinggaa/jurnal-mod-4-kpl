using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System. Threading. Tasks;
using System;

public class FanLaptop
{
	

	public enum FanState
	{
		Quiet,Turbo,Balanced,Performance
	}
	private FanState currentState;
    public FanLaptop()
    {
		currentState = FanState.Quiet;
    }
	public void Turbo()
	{
		if (currentState == FanState.Turbo)
		{
			currentState = FanState.Turbo;
			Console.WriteLine("Fan Quiet berubah menjadi Turbo");
		}
	}
    public void Quite()
    {
        if (currentState == FanState.Quiet)
        {
            currentState = FanState.Quiet;
            Console.WriteLine("Fan Quiet berubah menjadi Quite");
        }
    }
    public void Balanced()
    {
        if (currentState == FanState.Balanced)
        {
            currentState = FanState.Balanced;
            Console.WriteLine("Fan Quiet berubah menjadi Balanced");
        }
    }
    public void Performance()
    {
        if (currentState == FanState.Performance)
        {
            currentState = FanState.Performance;
            Console.WriteLine("Fan Quiet berubah menjadi Performance");
        }
    }
    public void ShowState()
    {
        Console.WriteLine($"Status fan saat ini: {currentState}");
    }
}
