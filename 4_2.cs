using System;

public class Arithm_pr
{
    private double first_number, difference;
    public double nth_number, sum_of_n_numbers;
    private int numbers;
    public Arithm_pr(int numbers, double first_number, double difference)
	{
        this.first_number = first_number;
        this.numbers = numbers;
        this.difference = difference;
        nth_number = member(first_number, difference, numbers);
        sum_of_n_numbers = sum(first_number, difference, numbers);
    }


    public double member(double first_number, double difference, int numbers)
    {
        do
        {
            nth_number = member(first_number, difference, numbers - 1) + difference;
        }
        while (numbers > 1);
        return nth_number;
    }

    public double sum(double first_number, double difference, int numbers)
    {
        do
        {
            sum_of_n_numbers = member(first_number, difference, numbers - 1) + sum(first_number, difference, numbers); //алгоритм взял навскидку, не силен в рекурсиях. Лучше поискать в справочниках
        }
        while (numbers > 1); 
        return sum_of_n_numbers;
    }
}