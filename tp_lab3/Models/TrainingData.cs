using System;

public class TrainingData
{
    public DateTime StartTime { get; set; }
    public TimeSpan Duration { get; set; }
    public double Distance { get; set; }
    public double MaxSpeed { get; set; }
    public double MinSpeed { get; set; }
    public double AvgSpeed { get; set; }
    public double AvgHeartRate { get; set; }
}