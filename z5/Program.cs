using System;

// Класс, который хранит информацию о температуре
public class TemperatureChangedEventArgs : EventArgs
{
    public double NewTemperature { get; }

    public TemperatureChangedEventArgs(double newTemperature)
    {
        NewTemperature = newTemperature;
    }
}

// Класс TemperatureSensor, который генерирует событие TemperatureChanged
class TemperatureSensor
{
    private double currentTemperature;

    // Событие, которое вызывается при изменении температуры
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    // Метод для установки температуры (с генерацией события)
    public void SetTemperature(double newTemperature)
    {
        if (newTemperature != currentTemperature)
        {
            currentTemperature = newTemperature;
            OnTemperatureChanged(new TemperatureChangedEventArgs(newTemperature));
        }
    }

    // Метод, вызывающий событие TemperatureChanged
    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        // Если на событие есть подписчики, уведомляем их об изменении температуры
        TemperatureChanged?.Invoke(this, e);
    }
}

// Класс Thermostat, который реагирует на изменение температуры
class Thermostat
{
    private double temperatureThreshold;

    public Thermostat(double threshold)
    {
        temperatureThreshold = threshold;
    }

    // Метод, который будет вызван при изменении температуры
    public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        if (e.NewTemperature < temperatureThreshold)
        {
            Console.WriteLine($"Температура {e.NewTemperature} ниже порога {temperatureThreshold}. Включаем отопление.");
        }
        else
        {
            Console.WriteLine($"Температура {e.NewTemperature} выше порога {temperatureThreshold}. Отключаем отопление.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем датчик температуры и термостат с порогом 23 градусов
        TemperatureSensor sensor = new TemperatureSensor();
        Thermostat thermostat = new Thermostat(23);

        // Подписываем термостат на событие изменения температуры
        sensor.TemperatureChanged += thermostat.OnTemperatureChanged;

        // Изменяем температуру и вызываем событие
        sensor.SetTemperature(-228); // Включаем отопление
        sensor.SetTemperature(45); // Отключаем отопление
        sensor.SetTemperature(7); // Включаем отопление
    }
}